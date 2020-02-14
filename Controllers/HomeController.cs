using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using C_Sharp_LogReg.Models;
using Microsoft.EntityFrameworkCore;
// for password validation login
using Microsoft.AspNetCore.Identity;
// For Sessions:
using Microsoft.AspNetCore.Http;
using Newtonsoft.Json;

namespace C_Sharp_LogReg.Controllers
{
    public class HomeController : Controller
    {
        
        private MyContext dbContext;
     
        // here we can "inject" our context service into the constructor
        public HomeController(MyContext context)
        {
            dbContext = context;
        }
        [HttpGet]
        [Route("")]
        public IActionResult Reg_page()
        {

            return View("RegPage");
        }

        [HttpPost]
        // [Route("user/create")]
        public IActionResult Create(User newuser)
        {
            if(ModelState.IsValid)
            {
                User oldUser = dbContext.Users.FirstOrDefault(u => u.Email == newuser.Email);
                if (oldUser != null)
                {
                    ModelState.AddModelError("Email", "User with such email already exist!");
                    return View("RegPage", newuser);
                }
                PasswordHasher<User> Hasher = new PasswordHasher<User>();
                newuser.Password = Hasher.HashPassword(newuser, newuser.Password);
                dbContext.Add(newuser);
                dbContext.SaveChanges();

                HttpContext.Session.SetInt32("UserId", newuser.UserId);
                Console.WriteLine("*******************************");
                Console.WriteLine("VALID VALID!");
                Console.WriteLine("*******************************");
                Console.WriteLine(HttpContext.Session.GetInt32("UserId"));
                Console.WriteLine("*******************************");
                return RedirectToAction("Success");
            }
            else
            {
                return View("RegPage");
            }
        }

        [HttpGet]
        [Route("login_page")]
        public IActionResult Login_page()
        {
            return View("LoginPage");
        }


        [HttpPost]
        // [Route("user/login")]
        public IActionResult Login(Login userSubmission)
        {
            // Console.WriteLine("*******************************");
            // Console.WriteLine("WE ARE IN LOGIN FUNCTION");
            if(ModelState.IsValid)
            {
                User userInDb = dbContext.Users.FirstOrDefault(u=> u.Email == userSubmission.Email);
                if(userInDb == null)
                {
                    ModelState.AddModelError("Email", "User with such email does not exist");
                    // Console.WriteLine("*******************************");
                    // Console.WriteLine("User DOES NOT EXIST");
                    return View("LoginPage");
                }
                PasswordHasher<Login> hasher = new PasswordHasher<Login>();
                var result = hasher.VerifyHashedPassword(userSubmission, userInDb.Password, userSubmission.Password);
                if(result == 0)
                {
                    // Console.WriteLine("*******************************");
                    // Console.WriteLine("PASSWORD WRONGT");
                    ModelState.AddModelError("Password", "Invalid Password");
                    return View("LoginPage");
                }
                HttpContext.Session.SetInt32("UserId", userInDb.UserId);
                Console.WriteLine("*******************************");
                Console.WriteLine("VALID VALID!");
                Console.WriteLine("*******************************");
                Console.WriteLine(HttpContext.Session.GetInt32("UserId"));
                Console.WriteLine("*******************************");
               return RedirectToAction("Success");
            }
            return View("LoginPage");
        }


        [HttpGet]
        [Route("success")]
        public IActionResult Success()
        {   
            ViewBag.SessionId = HttpContext.Session.GetInt32("UserId");
            var goSessions = HttpContext.Session.GetInt32("UserId");
            if(goSessions != null)
                return View("Success");
            return View("FailedSessions_html");
        }


    // EXTRA
        [HttpGet]
        [Route("failed")]
        public IActionResult FailedSessions_page()
        {   
            return View("FailedSessions_html");
        }



        [HttpGet]
        [Route("logout")]
        public IActionResult Logout()
        {   
            HttpContext.Session.Clear();
            return RedirectToAction("Reg_page");
        }

        




        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
