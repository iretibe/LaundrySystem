#pragma checksum "C:\Users\user\Videos\LaundrySystem\LaundrySystem.UI\Views\Home\Contact.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "7e82232cae78adca7d6fb39809b194d32b9e6769"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Contact), @"mvc.1.0.view", @"/Views/Home/Contact.cshtml")]
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
#line 1 "C:\Users\user\Videos\LaundrySystem\LaundrySystem.UI\Views\_ViewImports.cshtml"
using LaundrySystem.UI;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\user\Videos\LaundrySystem\LaundrySystem.UI\Views\_ViewImports.cshtml"
using LaundrySystem.UI.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7e82232cae78adca7d6fb39809b194d32b9e6769", @"/Views/Home/Contact.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"174fd7856118f752d52143aa8d6cf0e9e580691a", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Contact : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn text-white"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Home", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("name", new global::Microsoft.AspNetCore.Html.HtmlString("sentMessage"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("contactForm"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("novalidate", new global::Microsoft.AspNetCore.Html.HtmlString("novalidate"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "C:\Users\user\Videos\LaundrySystem\LaundrySystem.UI\Views\Home\Contact.cshtml"
  
    ViewData["Title"] = "Contact";
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
                    <h1 class=""mb-4 mb-md-0 text-white"">Contact Us</h1>
                </div>
                <div class=""col-md-6 text-center text-md-right"">
                    <div class=""d-inline-flex align-items-center"">
                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "7e82232cae78adca7d6fb39809b194d32b9e67696153", async() => {
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
            BeginWriteAttribute("href", " href=\"", 824, "\"", 831, 0);
            EndWriteAttribute();
            WriteLiteral(@">Contact Us</a>
                    </div>
                </div>
            </div>
        </div>
    </div>
    <!-- Page Header Start -->


    <!-- Contact Start -->
    <div class=""container-fluid py-5"">
        <div class=""container"" style=""max-width: 900px;"">
            <div class=""row"">
                <div class=""col-12"">
                    <div class=""row"">
                        <div class=""col-md-4"">
                            <div class=""d-flex flex-column align-items-center justify-content-center text-center mb-5"">
                                <div class=""d-inline-flex align-items-center justify-content-center bg-white border border-light shadow rounded-circle mb-4"" style=""width: 100px; height: 100px; border-width: 15px !important;"">
                                    <i class=""fa fa-2x fa-map-marker-alt text-secondary""></i>
                                </div>
                                <h5 class=""font-weight-medium m-0 mt-2"">Lapaz new Okai street, Accra Ghan");
            WriteLiteral(@"a</h5>
                            </div>
                        </div>
                        <div class=""col-md-4"">
                            <div class=""d-flex flex-column align-items-center justify-content-center text-center mb-5"">
                                <div class=""d-inline-flex align-items-center justify-content-center bg-white border border-light shadow rounded-circle mb-4"" style=""width: 100px; height: 100px; border-width: 15px !important;"">
                                    <i class=""fa fa-2x fa-envelope-open text-secondary""></i>
                                </div>
                                <h5 class=""font-weight-medium m-0 mt-2"">info@example.com</h5>
                            </div>
                        </div>
                        <div class=""col-md-4"">
                            <div class=""d-flex flex-column align-items-center justify-content-center text-center mb-5"">
                                <div class=""d-inline-flex align-items-center justify-c");
            WriteLiteral(@"ontent-center bg-white border border-light shadow rounded-circle mb-4"" style=""width: 100px; height: 100px; border-width: 15px !important;"">
                                    <i class=""fa fa-2x fa-phone-alt text-secondary""></i>
                                </div>
                                <h5 class=""font-weight-medium m-0 mt-2"">+233 55 164 9447</h5>
                            </div>
                        </div>
                    </div>
                </div>
                <div class=""col-12"">
                    <div class=""contact-form"">
                        <div id=""success""></div>
                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "7e82232cae78adca7d6fb39809b194d32b9e676910681", async() => {
                WriteLiteral(@"
                            <div class=""form-row"">
                                <div class=""col-md-6"">
                                    <div class=""control-group"">
                                        <input type=""text"" class=""form-control"" id=""name"" placeholder=""Your Name"" required=""required"" data-validation-required-message=""Please enter your name"" />
                                        <p class=""help-block text-danger""></p>
                                    </div>
                                </div>
                                <div class=""col-md-6"">
                                    <div class=""control-group"">
                                        <input type=""email"" class=""form-control"" id=""email"" placeholder=""Your Email"" required=""required"" data-validation-required-message=""Please enter your email"" />
                                        <p class=""help-block text-danger""></p>
                                    </div>
                                </div>
    ");
                WriteLiteral(@"                        </div>
                            <div class=""control-group"">
                                <input type=""text"" class=""form-control"" id=""subject"" placeholder=""Subject"" required=""required"" data-validation-required-message=""Please enter a subject"" />
                                <p class=""help-block text-danger""></p>
                            </div>
                            <div class=""control-group"">
                                <textarea class=""form-control"" rows=""6"" id=""message"" placeholder=""Message"" required=""required"" data-validation-required-message=""Please enter your message""></textarea>
                                <p class=""help-block text-danger""></p>
                            </div>
                            <div>
                                <button class=""btn btn-primary py-3 px-5"" type=""submit"" id=""sendMessageButton"">Send Message</button>
                            </div>
                        ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                    </div>\r\n                </div>\r\n            </div>\r\n        </div>\r\n    </div>\r\n    <!-- Contact End -->\r\n\r\n");
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
