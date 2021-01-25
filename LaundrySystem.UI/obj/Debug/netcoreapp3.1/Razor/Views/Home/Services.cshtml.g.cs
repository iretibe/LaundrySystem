#pragma checksum "C:\Microservices\LaundrySystem\LaundrySystem.UI\Views\Home\Services.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "6edcc532526efbed433c5178fef826c6913852a9"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Services), @"mvc.1.0.view", @"/Views/Home/Services.cshtml")]
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
#line 1 "C:\Microservices\LaundrySystem\LaundrySystem.UI\Views\_ViewImports.cshtml"
using LaundrySystem.UI;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Microservices\LaundrySystem\LaundrySystem.UI\Views\_ViewImports.cshtml"
using LaundrySystem.UI.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6edcc532526efbed433c5178fef826c6913852a9", @"/Views/Home/Services.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"174fd7856118f752d52143aa8d6cf0e9e580691a", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Services : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn text-white"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Home", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 2 "C:\Microservices\LaundrySystem\LaundrySystem.UI\Views\Home\Services.cshtml"
  
    ViewData["Title"] = "Services";
    Layout = "~/Views/Shared/_Main.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
    <!-- Page Header Start -->
    <div class=""page-header container-fluid bg-secondary pt-2 pt-lg-5 pb-2 mb-5"">
        <div class=""container py-5"">
            <div class=""row align-items-center py-4"">
                <div class=""col-md-6 text-center text-md-left"">
                    <h1 class=""mb-4 mb-md-0 text-white"">Our Services</h1>
                </div>
                <div class=""col-md-6 text-center text-md-right"">
                    <div class=""d-inline-flex align-items-center"">
                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "6edcc532526efbed433c5178fef826c6913852a94846", async() => {
                WriteLiteral("Home");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                        <i class=\"fas fa-angle-right text-white\"></i>\r\n                        <a class=\"btn text-white disabled\"");
            BeginWriteAttribute("href", " href=\"", 829, "\"", 836, 0);
            EndWriteAttribute();
            WriteLiteral(@">Services</a>
                    </div>
                </div>
            </div>
        </div>
    </div>
    <!-- Page Header Start -->


    <!-- Services Start -->
    <div class=""container-fluid pt-5 pb-3"">
        <div class=""container"">
            <h6 class=""text-secondary text-uppercase text-center font-weight-medium mb-3"">Our Services</h6>
            <h1 class=""display-4 text-center mb-5"">What We Offer</h1>
            <div class=""row"">
                <div class=""col-lg-3 col-md-6 pb-1"">
                    <div class=""d-flex flex-column align-items-center justify-content-center text-center bg-light mb-4 px-4"" style=""height: 300px;"">
                        <div class=""d-inline-flex align-items-center justify-content-center bg-white shadow rounded-circle mb-4"" style=""width: 100px; height: 100px;"">
                            <i class=""fa fa-3x fa-cloud-sun text-secondary""></i>
                        </div>
                        <h4 class=""font-weight-bold m-0"">Dry Cleaning");
            WriteLiteral(@"</h4>
                    </div>
                </div>
                <div class=""col-lg-3 col-md-6 pb-1"">
                    <div class=""d-flex flex-column align-items-center justify-content-center text-center bg-light mb-4 px-4"" style=""height: 300px;"">
                        <div class=""d-inline-flex align-items-center justify-content-center bg-white shadow rounded-circle mb-4"" style=""width: 100px; height: 100px;"">
                            <i class=""fas fa-3x fa-soap text-secondary""></i>
                        </div>
                        <h4 class=""font-weight-bold m-0"">Wash & Laundry</h4>
                    </div>
                </div>
                <div class=""col-lg-3 col-md-6 pb-1"">
                    <div class=""d-flex flex-column align-items-center justify-content-center text-center bg-light mb-4 px-4"" style=""height: 300px;"">
                        <div class=""d-inline-flex align-items-center justify-content-center bg-white shadow rounded-circle mb-4"" style=""width: 100px;");
            WriteLiteral(@" height: 100px;"">
                            <i class=""fa fa-3x fa-burn text-secondary""></i>
                        </div>
                        <h4 class=""font-weight-bold m-0"">Curtain Laundry</h4>
                    </div>
                </div>
                <div class=""col-lg-3 col-md-6 pb-1"">
                    <div class=""d-flex flex-column align-items-center justify-content-center text-center bg-light mb-4 px-4"" style=""height: 300px;"">
                        <div class=""d-inline-flex align-items-center justify-content-center bg-white shadow rounded-circle mb-4"" style=""width: 100px; height: 100px;"">
                            <i class=""fa fa-3x fa-tshirt text-secondary""></i>
                        </div>
                        <h4 class=""font-weight-bold m-0"">Suits Cleaning</h4>
                    </div>
                </div>
                <div class=""col-lg-3 col-md-6 pb-1"">
                    <div class=""d-flex flex-column align-items-center justify-content-center text-");
            WriteLiteral(@"center bg-light mb-4 px-4"" style=""height: 300px;"">
                        <div class=""d-inline-flex align-items-center justify-content-center bg-white shadow rounded-circle mb-4"" style=""width: 100px; height: 100px;"">
                            <i class=""fa fa-3x fa-cloud-sun text-secondary""></i>
                        </div>
                        <h4 class=""font-weight-bold m-0"">Dry Cleaning</h4>
                    </div>
                </div>
                <div class=""col-lg-3 col-md-6 pb-1"">
                    <div class=""d-flex flex-column align-items-center justify-content-center text-center bg-light mb-4 px-4"" style=""height: 300px;"">
                        <div class=""d-inline-flex align-items-center justify-content-center bg-white shadow rounded-circle mb-4"" style=""width: 100px; height: 100px;"">
                            <i class=""fas fa-3x fa-soap text-secondary""></i>
                        </div>
                        <h4 class=""font-weight-bold m-0"">Wash & Laundry</h4>
  ");
            WriteLiteral(@"                  </div>
                </div>
                <div class=""col-lg-3 col-md-6 pb-1"">
                    <div class=""d-flex flex-column align-items-center justify-content-center text-center bg-light mb-4 px-4"" style=""height: 300px;"">
                        <div class=""d-inline-flex align-items-center justify-content-center bg-white shadow rounded-circle mb-4"" style=""width: 100px; height: 100px;"">
                            <i class=""fa fa-3x fa-burn text-secondary""></i>
                        </div>
                        <h4 class=""font-weight-bold m-0"">Curtain Laundry</h4>
                    </div>
                </div>
                <div class=""col-lg-3 col-md-6 pb-1"">
                    <div class=""d-flex flex-column align-items-center justify-content-center text-center bg-light mb-4 px-4"" style=""height: 300px;"">
                        <div class=""d-inline-flex align-items-center justify-content-center bg-white shadow rounded-circle mb-4"" style=""width: 100px; height: ");
            WriteLiteral(@"100px;"">
                            <i class=""fa fa-3x fa-tshirt text-secondary""></i>
                        </div>
                        <h4 class=""font-weight-bold m-0"">Suits Cleaning</h4>
                    </div>
                </div>
            </div>
        </div>
    </div>
    <!-- Services End -->


    <!-- Testimonial Start -->
    <div class=""container-fluid py-5"">
        <div class=""container"">
            <h6 class=""text-secondary text-uppercase text-center font-weight-medium mb-3"">Testimonial</h6>
            <h1 class=""display-4 text-center mb-5"">Our Clients Say</h1>
            <div class=""owl-carousel testimonial-carousel"">
                <div class=""testimonial-item"">
                    <img class=""position-relative rounded-circle bg-white shadow mx-auto"" src=""img/testimonial-1.jpg"" style=""width: 100px; height: 100px; padding: 12px; margin-bottom: -50px; z-index: 1;""");
            BeginWriteAttribute("alt", " alt=\"", 6885, "\"", 6891, 0);
            EndWriteAttribute();
            WriteLiteral(@">
                    <div class=""bg-light text-center p-4 pt-0"">
                        <h5 class=""font-weight-medium mt-5"">Client Name</h5>
                        <p class=""text-muted font-italic"">Profession</p>
                        <p class=""m-0"">Sed ea amet kasd elitr stet, stet rebum et ipsum est duo elitr eirmod clita lorem. Dolor ipsum clita</p>
                    </div>
                </div>
                <div class=""testimonial-item"">
                    <img class=""position-relative rounded-circle bg-white shadow mx-auto"" src=""img/testimonial-2.jpg"" style=""width: 100px; height: 100px; padding: 12px; margin-bottom: -50px; z-index: 1;""");
            BeginWriteAttribute("alt", " alt=\"", 7560, "\"", 7566, 0);
            EndWriteAttribute();
            WriteLiteral(@">
                    <div class=""bg-light text-center p-4 pt-0"">
                        <h5 class=""font-weight-medium mt-5"">Client Name</h5>
                        <p class=""text-muted font-italic"">Profession</p>
                        <p class=""m-0"">Sed ea amet kasd elitr stet, stet rebum et ipsum est duo elitr eirmod clita lorem. Dolor ipsum clita</p>
                    </div>
                </div>
                <div class=""testimonial-item"">
                    <img class=""position-relative rounded-circle bg-white shadow mx-auto"" src=""img/testimonial-3.jpg"" style=""width: 100px; height: 100px; padding: 12px; margin-bottom: -50px; z-index: 1;""");
            BeginWriteAttribute("alt", " alt=\"", 8235, "\"", 8241, 0);
            EndWriteAttribute();
            WriteLiteral(@">
                    <div class=""bg-light text-center p-4 pt-0"">
                        <h5 class=""font-weight-medium mt-5"">Client Name</h5>
                        <p class=""text-muted font-italic"">Profession</p>
                        <p class=""m-0"">Sed ea amet kasd elitr stet, stet rebum et ipsum est duo elitr eirmod clita lorem. Dolor ipsum clita</p>
                    </div>
                </div>
                <div class=""testimonial-item"">
                    <img class=""position-relative rounded-circle bg-white shadow mx-auto"" src=""img/testimonial-4.jpg"" style=""width: 100px; height: 100px; padding: 12px; margin-bottom: -50px; z-index: 1;""");
            BeginWriteAttribute("alt", " alt=\"", 8910, "\"", 8916, 0);
            EndWriteAttribute();
            WriteLiteral(@">
                    <div class=""bg-light text-center p-4 pt-0"">
                        <h5 class=""font-weight-medium mt-5"">Client Name</h5>
                        <p class=""text-muted font-italic"">Profession</p>
                        <p class=""m-0"">Sed ea amet kasd elitr stet, stet rebum et ipsum est duo elitr eirmod clita lorem. Dolor ipsum clita</p>
                    </div>
                </div>
            </div>
        </div>
    </div>
    <!-- Testimonial End -->
");
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
