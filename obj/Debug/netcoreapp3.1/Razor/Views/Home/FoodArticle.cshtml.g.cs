#pragma checksum "C:\Users\jordb\OneDrive\Documents\School\Year 2.2\PFD\Assignment 2\PFD_Team3\PFD_Team3\Views\Home\FoodArticle.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "068b036505c5e085dcaccd3071f625a1e22d8b18"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_FoodArticle), @"mvc.1.0.view", @"/Views/Home/FoodArticle.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"068b036505c5e085dcaccd3071f625a1e22d8b18", @"/Views/Home/FoodArticle.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"78b3fb17ffda63339a9d6d7f0a7f606151fd83f2", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_FoodArticle : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "C:\Users\jordb\OneDrive\Documents\School\Year 2.2\PFD\Assignment 2\PFD_Team3\PFD_Team3\Views\Home\FoodArticle.cshtml"
  
    ViewData["Title"] = "Food Articles";
    Layout = "~/Views/Shared/_Menu.cshtml";


#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<style>
    /* MENU */
    .menu {
        width: 100%;
        padding: 45px 5rem;
        background-image: linear-gradient(to right bottom, rgb(184, 178, 175), rgba(153, 145, 145, 0.5)),url(images/hawker-food-hero-image-image-credit-visit-singapore.jpg);
    }

    .menu-heading {
        font-size: 5rem;
        text-align: center;
        text-shadow: 0 0 1rem rgba(0,0,0,.9);
        text-transform: uppercase;
        color: white;
        font-weight: 800;
    }

    .menu-grid {
        display: grid;
        grid-template-rows: repeat(2, 1fr);
        grid-template-columns: repeat(4, 1fr);
        justify-self: center;
        grid-gap: 2rem;
    }

    .heading-secondary {
        font-size: 7rem;
        text-transform: uppercase;
        color: white;
        text-align: center;
    }

   /* .menu-img {
        height: 50%;
        width: 100%;
        background-size: cover;
        background-position: left;
        background-image: url(/images/piz.jpg)
  ");
            WriteLiteral(@"  }*/

    .menu-img1 {
        height: 50%;
        width: 100%;
        background-size: cover;
        background-position: center;
        background-image: url(/images/nasilemak.jpg);
    }

    .menu-img2 {
        height: 50%;
        width: 100%;
        background-size: cover;
        background-position: center;
        background-image: url(/images/beefnoodle.jpg);
    }

    .menu-img3 {
        height: 50%;
        width: 100%;
        background-size: cover;
        background-position: center;
        background-image: url(/images/mincedmeat.jpg);
    }

    .menu-img4 {
        height: 50%;
        width: 100%;
        background-size: cover;
        background-position: center;
        background-image: url(/images/western.jpg);
    }

    .menu-img5 {
        height: 50%;
        width: 100%;
        background-size: cover;
        background-position: center;
        background-image: url(/images/stingray.jpg);
    }

    .menu-img6 {
        heigh");
            WriteLiteral(@"t: 50%;
        width: 100%;
        background-size: cover;
        background-position: center;
        background-image: url(/images/meishiquan.jpg);
    }

    .menu-img7 {
        height: 50%;
        width: 100%;
        background-size: cover;
        background-position: center;
        background-image: url(/images/dessert.jpg);
    }

    .menu-img8 {
        height: 50%;
        width: 100%;
        background-size: cover;
        background-position: center;
        background-image: url(/images/hongkong.jpg);
    }

    .menu-container {
        width: 100%;
        height: 50rem;
        background-color: white;
        border-radius: 5px;
        overflow: hidden;
        box-shadow: 0 0 2rem rgba(0,0,0,.2);
        transition: all .4s ease;
    }

        .menu-container:hover {
            box-shadow: 0 0 5rem rgba(0,0,0,.4);
            transform: scale(1.07);
        }

    .menu-p {
        font-size: 1.4rem;
        padding: 1rem;
        text-alig");
            WriteLiteral(@"n: center;
    }

    .menu-title {
        font-size: 2rem;
        text-align: center;
    }

    .link a {
        margin-left: 38%;
        margin-top: 1rem;
        text-align: center;
        color: #4f1dda;
        text-shadow: 0 .4rem 2rem rgba(0,0,0,.4);
    }
</style>

<!DOCTYPE html>
<html>
");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "068b036505c5e085dcaccd3071f625a1e22d8b187200", async() => {
                WriteLiteral(@"
    <section class=""menu"">
        <div class=""container"">
            <div class=""menu-heading"">Stores in Singapore </div>
            <br>
            <div class=""menu-grid"">
                <div class=""menu-hold"">
                    <div class=""menu-container"">
                        <div class=""menu-img1"">
                            &nbsp;
                        </div>
                        <h1 class=""menu-title"">97 Nasi Lemak</h1>
                        <p class=""menu-p"">97 Nasi Lemak looked impeccably neat, bright and modern in contrast for a hawker stall.</p>
                        <h3 class=""link""> <a href=""https://danielfooddiary.com/2021/11/07/97nasilemak/"">Read More</a></h3>
                    </div>
                </div>
                <div class=""menu-hold"">
                    <div class=""menu-container"">
                        <div class=""menu-img2"">
                            &nbsp;
                        </div>
                        <h1 class=""menu-title""");
                WriteLiteral(@">Hong Kee Beef Noodle</h1>
                        <p class=""menu-p"">Gooey gravy, tender beef slices, slippery kway teow and a sprinkling of salted vegetables made a satisfying bowl.</p>
                        <h3 class=""link""> <a href=""https://danielfooddiary.com/2020/06/19/amoystreet/"">Read More</a></h3>
                    </div>
                </div>

                <div class=""menu-hold"">
                    <div class=""menu-container"">
                        <div class=""menu-img3"">
                            &nbsp;
                        </div>
                        <h1 class=""menu-title"">58 Minced Meat Noodle</h1>
                        <p class=""menu-p"">58 Minced Meat Noodles Taman at Jurong Food Centre is very popular. It was started in 1973 </p>
                        <h3 class=""link""> <a href=""https://www.misstamchiak.com/taman-jurong-market-and-food-centre/"">Read More</a></h3>
                    </div>
                </div>

                <div class=""menu-hold"">
   ");
                WriteLiteral(@"                 <div class=""menu-container"">
                        <div class=""menu-img4"">
                            &nbsp;
                        </div>
                        <h1 class=""menu-title"">Tom’s Kitchen/</h1>
                        <p class=""menu-p"">Tom’s Kitchen dishes out quality food in generous portions at affordable prices. You would definitely get your money’s worth here! </p>
                        <h3 class=""link""> <a href=""https://www.misstamchiak.com/taman-jurong-market-and-food-centre/"">Read More</a></h3>
                    </div>

                </div>

                <div class=""menu-hold"">
                    <div class=""menu-container"">
                        <div class=""menu-img5"">
                            &nbsp;
                        </div>
                        <h1 class=""menu-title"">B.B.Q Seafood</h1>
                        <p class=""menu-p"">The stingray was so soft, tender and juicy, with the smoky barbecue flavour permeating through the mea");
                WriteLiteral(@"t. It was as though the fish had been cooked in an outdoor barbecue under an open flame.  </p>
                        <h3 class=""link""> <a href=""https://www.misstamchiak.com/taman-jurong-market-and-food-centre/"">Read More</a></h3>
                    </div>
                </div>

                <div class=""menu-hold"">
                    <div class=""menu-container"">
                        <div class=""menu-img6"">
                            &nbsp;
                        </div>
                        <h1 class=""menu-title"">Mei Shi Quan</h1>
                        <p class=""menu-p"">Formerly from Orchard Carpark, they had moved to Gluttons by the Bay, and now finally, at Ci Yuan Hawker Centre.</p>
                        <h3 class=""link""> <a href=""https://www.misstamchiak.com/ci-yuan-hawker-centre/"">Read More</a></h3>
                    </div>
                </div>


                <div class=""menu-hold"">
                    <div class=""menu-container"">
                        <div cl");
                WriteLiteral(@"ass=""menu-img7"">
                            &nbsp;
                        </div>
                        <h1 class=""menu-title"">Dessert</h1>
                        <p class=""menu-p""> Previously studied Pharmaceutical Science at Republic Polytechnic, 23-year-old Aericurl saw the entrepreneurship program as an opportunity and decided to give it a try. </p>
                        <h3 class=""link""> <a href=""https://www.misstamchiak.com/ci-yuan-hawker-centre/"">Read More</a></h3>
                    </div>
                </div>
                <div class=""menu-hold"">
                    <div class=""menu-container"">
                        <div class=""menu-img8"">
                            &nbsp;
                        </div>
                        <h1 class=""menu-title"">Hong Kong Chef’s Kitchen</h1>
                        <p class=""menu-p""> This tasty and addictive dish has got 10 jumbo de-shelled prawn that was stir fried along with salted egg, curry leaves and chili.</p>
                  ");
                WriteLiteral("      <h3 class=\"link\"> <a href=\"https://www.misstamchiak.com/ci-yuan-hawker-centre/\">Read More</a></h3>\r\n                    </div>\r\n                </div>\r\n            </div>\r\n        </div>\r\n    </section>\r\n\r\n");
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
