#pragma checksum "C:\Users\Zhi Cheng\source\repos\Lab7\Lab7\Views\AcademicRecords\_ViewStart.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "6164dcd5de69dd93be2f5bb0bd1c156f25ebf632"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_AcademicRecords__ViewStart), @"mvc.1.0.view", @"/Views/AcademicRecords/_ViewStart.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/AcademicRecords/_ViewStart.cshtml", typeof(AspNetCore.Views_AcademicRecords__ViewStart))]
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
#line 1 "C:\Users\Zhi Cheng\source\repos\Lab7\Lab7\Views\_ViewImports.cshtml"
using Lab7;

#line default
#line hidden
#line 2 "C:\Users\Zhi Cheng\source\repos\Lab7\Lab7\Views\_ViewImports.cshtml"
using Lab7.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6164dcd5de69dd93be2f5bb0bd1c156f25ebf632", @"/Views/AcademicRecords/_ViewStart.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ca9c45965cdb4328646c2d59bfb24b4086998780", @"/Views/_ViewImports.cshtml")]
    public class Views_AcademicRecords__ViewStart : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 1 "C:\Users\Zhi Cheng\source\repos\Lab7\Lab7\Views\AcademicRecords\_ViewStart.cshtml"
  
    Layout = "_ACLayout";

#line default
#line hidden
#line 4 "C:\Users\Zhi Cheng\source\repos\Lab7\Lab7\Views\AcademicRecords\_ViewStart.cshtml"
   
    ViewBag.Title = "Academic Records System";

    List<TopMenuItem> topMenu = new List<TopMenuItem>();
    topMenu.Add(new TopMenuItem { AspAction = "Index", AspController = "Employees", DisplayText = "Employees"});
    topMenu.Add(new TopMenuItem { AspAction = "Index", AspController = "Students", DisplayText = "Students" });
    topMenu.Add(new TopMenuItem { AspAction = "Index", AspController = "Courses", DisplayText = "Courses" });
    topMenu.Add(new TopMenuItem { AspAction = "Index", AspController = "AcademicRecords", DisplayText = "Student Records" });

    ViewBag.TopMenu = topMenu;

#line default
#line hidden
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
