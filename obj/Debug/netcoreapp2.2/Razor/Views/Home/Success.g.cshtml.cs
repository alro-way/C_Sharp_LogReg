#pragma checksum "D:\ALEX_and_SASHA\07 Training\Coding Dojo\c#_stack\C_Sharp_Assignments\C_Sharp_LogReg\Views\Home\Success.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "4a5b1b3b0547f14d5de7b15e73e78f63d6a04c4e"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Success), @"mvc.1.0.view", @"/Views/Home/Success.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/Success.cshtml", typeof(AspNetCore.Views_Home_Success))]
namespace AspNetCore
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#line 1 "D:\ALEX_and_SASHA\07 Training\Coding Dojo\c#_stack\C_Sharp_Assignments\C_Sharp_LogReg\Views\_ViewImports.cshtml"
using C_Sharp_LogReg;

#line default
#line hidden
#line 1 "D:\ALEX_and_SASHA\07 Training\Coding Dojo\c#_stack\C_Sharp_Assignments\C_Sharp_LogReg\Views\Home\Success.cshtml"
using System.ComponentModel.DataAnnotations;

#line default
#line hidden
#line 2 "D:\ALEX_and_SASHA\07 Training\Coding Dojo\c#_stack\C_Sharp_Assignments\C_Sharp_LogReg\Views\Home\Success.cshtml"
using C_Sharp_LogReg.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4a5b1b3b0547f14d5de7b15e73e78f63d6a04c4e", @"/Views/Home/Success.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1e823a89d16d6ae27f34f5f12c13cad6df4aff19", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Success : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 3 "D:\ALEX_and_SASHA\07 Training\Coding Dojo\c#_stack\C_Sharp_Assignments\C_Sharp_LogReg\Views\Home\Success.cshtml"
  
    ViewData["Title"] = "Success Page";

#line default
#line hidden
            BeginContext(126, 147, true);
            WriteLiteral("<div class=\"text-center\">\r\n    <a href=\"/logout\">Logout</a>\r\n    <h1 class=\"display-4\">Success</h1>\r\n    <h1 class=\"display-4\">User with SissionId ");
            EndContext();
            BeginContext(274, 17, false);
#line 9 "D:\ALEX_and_SASHA\07 Training\Coding Dojo\c#_stack\C_Sharp_Assignments\C_Sharp_LogReg\Views\Home\Success.cshtml"
                                         Write(ViewBag.SessionId);

#line default
#line hidden
            EndContext();
            BeginContext(291, 13, true);
            WriteLiteral("</h1>\r\n</div>");
            EndContext();
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
