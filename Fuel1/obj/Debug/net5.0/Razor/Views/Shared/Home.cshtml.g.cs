#pragma checksum "C:\Users\pooitha rao\source\repos\Fuel1\Fuel1\Views\Shared\Home.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "6eb035ceaabdfde1a4bf59176ebc23533d700f0a"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_Home), @"mvc.1.0.view", @"/Views/Shared/Home.cshtml")]
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
#nullable restore
#line 1 "C:\Users\pooitha rao\source\repos\Fuel1\Fuel1\Views\_ViewImports.cshtml"
using Fuel1;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\pooitha rao\source\repos\Fuel1\Fuel1\Views\_ViewImports.cshtml"
using Fuel1.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6eb035ceaabdfde1a4bf59176ebc23533d700f0a", @"/Views/Shared/Home.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"47f90a52167d7e29ba00ebeed7c198e306b0fe80", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared_Home : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #line hidden
        #pragma warning disable 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        #pragma warning restore 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __backed__tagHelperScopeManager = null;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __tagHelperScopeManager
        {
            get
            {
                if (__backed__tagHelperScopeManager == null)
                {
                    __backed__tagHelperScopeManager = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager(StartTagHelperWritingScope, EndTagHelperWritingScope);
                }
                return __backed__tagHelperScopeManager;
            }
        }
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "C:\Users\pooitha rao\source\repos\Fuel1\Fuel1\Views\Shared\Home.cshtml"
  
    ViewBag.Title = "HomeView";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<!DOCTYPE html>\r\n<html>\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "6eb035ceaabdfde1a4bf59176ebc23533d700f0a3397", async() => {
                WriteLiteral(@"
    <style>
        body {
            font-size: 28px;
        }

        ul {
            list-style-type: none;
            margin: 0;
            padding: 0;
            overflow: hidden;
            background-color: #333;
            position: -webkit-sticky; /* Safari */
            position: sticky;
            top: 0;
        }

        li {
            float: left;
        }

            li a {
                display: block;
                color: white;
                text-align: center;
                padding: 14px 16px;
                text-decoration: none;
            }

                li a:hover {
                    background-color: #111;
                }

        .active {
            background-color: #4CAF50;
        }

        html, body, iframe {
            margin: 0px;
            padding: 0px;
            height: 100%;
            border: none;
        }

        iframe {
            display: block;
            width: 100%;
       ");
                WriteLiteral("     border: none;\r\n            overflow-y: auto;\r\n            overflow-x: hidden;\r\n        }\r\n    </style>\r\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "6eb035ceaabdfde1a4bf59176ebc23533d700f0a5538", async() => {
                WriteLiteral(@"
    <div id=""myDIV"">
        <ul>
            <li><a class=""btn active"" href=""homepage.html"" target=""iframe_a"">Home</a></li>
            <li><a class=""btn"" href=""Quote_history.html"" target=""iframe_a"">Quote History</a></li>
            <li><a class=""btn"" href=""profile_manager.html"" target=""iframe_a"">Profile</a></li>
            <li><a class=""btn"" href=""Quote_gen.html"" target=""iframe_a"">Quote Generator</a></li>
        </ul>
    </div>

    <iframe src=""homepage.html""
            name=""iframe_a""
            title=""Iframe Example""
            frameborder=""0""
            marginheight=""0""
            marginwidth=""0""
            width=""100%""
            height=""100%""
            scrolling=""auto"">
    </iframe>

    <script>// Add active class to the current button (highlight it)
var header = document.getElementById(""myDIV"");
var btns = header.getElementsByClassName(""btn"");
for (var i = 0; i < btns.length; i++) {
  btns[i].addEventListener(""click"", function() {
  var current = document.get");
                WriteLiteral("ElementsByClassName(\"active\");\r\n  current[0].className = current[0].className.replace(\" active\", \"\");\r\n  this.className += \" active\";\r\n  });\r\n}</script>\r\n\r\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n</html>\r\n");
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
