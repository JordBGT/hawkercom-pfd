#pragma checksum "C:\Users\jordb\OneDrive\Documents\School\Year 2.2\PFD\Assignment 2\PFD_Team3\PFD_Team3\Views\Post\PostDetails.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f6df6e7e10f11da92bce6267cba4e15dd2262e15"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Post_PostDetails), @"mvc.1.0.view", @"/Views/Post/PostDetails.cshtml")]
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
#line 1 "C:\Users\jordb\OneDrive\Documents\School\Year 2.2\PFD\Assignment 2\PFD_Team3\PFD_Team3\Views\_ViewImports.cshtml"
using PFD_Team3;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\jordb\OneDrive\Documents\School\Year 2.2\PFD\Assignment 2\PFD_Team3\PFD_Team3\Views\_ViewImports.cshtml"
using PFD_Team3.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\jordb\OneDrive\Documents\School\Year 2.2\PFD\Assignment 2\PFD_Team3\PFD_Team3\Views\_ViewImports.cshtml"
using Microsoft.AspNetCore.Http;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f6df6e7e10f11da92bce6267cba4e15dd2262e15", @"/Views/Post/PostDetails.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"78b3fb17ffda63339a9d6d7f0a7f606151fd83f2", @"/Views/_ViewImports.cshtml")]
    public class Views_Post_PostDetails : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<PFD_Team3.Models.PostViewModel>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("width:700px"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\jordb\OneDrive\Documents\School\Year 2.2\PFD\Assignment 2\PFD_Team3\PFD_Team3\Views\Post\PostDetails.cshtml"
  
    ViewData["Title"] = "PostDetails";
    Layout = "~/Views/Shared/_Menu.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<style>
    .bg {
        min-height: 100vh;
        width: 100%;
        background-image: linear-gradient(rgba(4,9,30,0.7),rgba(4,9,30,0.7)),url(/images/camera.jpg);
        background-position: center;
        background-size: cover;
        position: absolute;
        background-attachment: fixed;
        background-repeat: no-repeat;
    }
    .h3 {
        color: black;
        text-align: center;
    }

    .cards {
        display: flex;
        flex-direction: column;
        flex-wrap: wrap;
        align-content: center;
        max-height: 200vh;
        padding: 25px;
    }

    .card {
        background-color: #F8F0E3; 
        width: 700px;
        margin: 10px;
        border: 1px solid #ccc;
        box-shadow: 2px 2px 6px 0px rgba(0,0,0,0.3);
    }

    .card img {
        max-width: 100%;
    }

    .card .text {
        padding: 0 20px 20px;
    }

    .card .text > button {
        background: gray;
        border: 0;
        color: white;
 ");
            WriteLiteral("       padding: 10px;\r\n        width: 100%;\r\n    }\r\n\r\n    .posts {\r\n        margin: auto;\r\n        width: 50%;\r\n    }\r\n</style>\r\n");
#nullable restore
#line 62 "C:\Users\jordb\OneDrive\Documents\School\Year 2.2\PFD\Assignment 2\PFD_Team3\PFD_Team3\Views\Post\PostDetails.cshtml"
  
    if (Context.Session.GetString("Role") != null)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <h3 class=\"h3\">Welcome, ");
#nullable restore
#line 65 "C:\Users\jordb\OneDrive\Documents\School\Year 2.2\PFD\Assignment 2\PFD_Team3\PFD_Team3\Views\Post\PostDetails.cshtml"
                           Write(ViewData["UserName"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h3>\r\n");
#nullable restore
#line 66 "C:\Users\jordb\OneDrive\Documents\School\Year 2.2\PFD\Assignment 2\PFD_Team3\PFD_Team3\Views\Post\PostDetails.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("<div class=\"bg\">\r\n\r\n    <div class=\"posts\">\r\n");
#nullable restore
#line 71 "C:\Users\jordb\OneDrive\Documents\School\Year 2.2\PFD\Assignment 2\PFD_Team3\PFD_Team3\Views\Post\PostDetails.cshtml"
         foreach (var item in Model)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <div class=\"cards\">\r\n                <article class=\"card\">\r\n");
#nullable restore
#line 75 "C:\Users\jordb\OneDrive\Documents\School\Year 2.2\PFD\Assignment 2\PFD_Team3\PFD_Team3\Views\Post\PostDetails.cshtml"
                       string imageFileName = item.FileSubmitted + ".jpg"; 

#line default
#line hidden
#nullable disable
            WriteLiteral("                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "f6df6e7e10f11da92bce6267cba4e15dd2262e156945", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 1707, "~/images/", 1707, 9, true);
#nullable restore
#line 76 "C:\Users\jordb\OneDrive\Documents\School\Year 2.2\PFD\Assignment 2\PFD_Team3\PFD_Team3\Views\Post\PostDetails.cshtml"
AddHtmlAttributeValue("", 1716, imageFileName, 1716, 14, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                    <div class=\"text\">\r\n                        <h1>");
#nullable restore
#line 79 "C:\Users\jordb\OneDrive\Documents\School\Year 2.2\PFD\Assignment 2\PFD_Team3\PFD_Team3\Views\Post\PostDetails.cshtml"
                       Write(Html.DisplayFor(modelItem => item.Title));

#line default
#line hidden
#nullable disable
            WriteLiteral("</h1>\r\n                        <h4>Posted By:</h4> ");
#nullable restore
#line 80 "C:\Users\jordb\OneDrive\Documents\School\Year 2.2\PFD\Assignment 2\PFD_Team3\PFD_Team3\Views\Post\PostDetails.cshtml"
                                       Write(Html.DisplayFor(modelItem => item.UserName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        <p>\r\n                            <h4>Hawker Centre:</h4> ");
#nullable restore
#line 82 "C:\Users\jordb\OneDrive\Documents\School\Year 2.2\PFD\Assignment 2\PFD_Team3\PFD_Team3\Views\Post\PostDetails.cshtml"
                                               Write(Html.DisplayFor(modelItem => item.HawkerName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </p>\r\n                        <p>\r\n                            <h4>Hawker Stall:</h4> ");
#nullable restore
#line 85 "C:\Users\jordb\OneDrive\Documents\School\Year 2.2\PFD\Assignment 2\PFD_Team3\PFD_Team3\Views\Post\PostDetails.cshtml"
                                              Write(Html.DisplayFor(modelItem => item.HawkerStore));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </p>\r\n                        <p>\r\n                            <h4>Ratings:</h4> ");
#nullable restore
#line 88 "C:\Users\jordb\OneDrive\Documents\School\Year 2.2\PFD\Assignment 2\PFD_Team3\PFD_Team3\Views\Post\PostDetails.cshtml"
                                         Write(Html.DisplayFor(modelItem => item.Rating));

#line default
#line hidden
#nullable disable
            WriteLiteral("/5\r\n                        </p>\r\n                        <br />\r\n                        <p>\r\n                            <h4>Description:</h4>\r\n                        ");
#nullable restore
#line 93 "C:\Users\jordb\OneDrive\Documents\School\Year 2.2\PFD\Assignment 2\PFD_Team3\PFD_Team3\Views\Post\PostDetails.cshtml"
                   Write(Html.DisplayFor(modelItem => item.Description));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </p>\r\n                    </div>\r\n                </article>\r\n            </div>\r\n");
#nullable restore
#line 98 "C:\Users\jordb\OneDrive\Documents\School\Year 2.2\PFD\Assignment 2\PFD_Team3\PFD_Team3\Views\Post\PostDetails.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </div>\r\n\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<PFD_Team3.Models.PostViewModel>> Html { get; private set; }
    }
}
#pragma warning restore 1591
