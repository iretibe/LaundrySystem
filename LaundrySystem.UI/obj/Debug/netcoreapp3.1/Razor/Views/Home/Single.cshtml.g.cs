#pragma checksum "C:\Users\user\Videos\LaundrySystem\LaundrySystem.UI\Views\Home\Single.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "0c0f36040328ae0617943a88a2b40e87188a15a3"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Single), @"mvc.1.0.view", @"/Views/Home/Single.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0c0f36040328ae0617943a88a2b40e87188a15a3", @"/Views/Home/Single.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"174fd7856118f752d52143aa8d6cf0e9e580691a", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Single : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn text-white"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Home", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("action", new global::Microsoft.AspNetCore.Html.HtmlString(""), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 1 "C:\Users\user\Videos\LaundrySystem\LaundrySystem.UI\Views\Home\Single.cshtml"
  
    ViewData["Title"] = "Single";
    Layout = "~/Views/Shared/_Main.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"    <!-- Page Header Start -->
    <div class=""page-header container-fluid bg-secondary pt-2 pt-lg-5 pb-2 mb-5"">
        <div class=""container py-5"">
            <div class=""row align-items-center py-4"">
                <div class=""col-md-6 text-center text-md-left"">
                    <h1 class=""mb-4 mb-md-0 text-white"">Detail Page</h1>
                </div>
                <div class=""col-md-6 text-center text-md-right"">
                    <div class=""d-inline-flex align-items-center"">
                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "0c0f36040328ae0617943a88a2b40e87188a15a35433", async() => {
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
            BeginWriteAttribute("href", " href=\"", 822, "\"", 829, 0);
            EndWriteAttribute();
            WriteLiteral(@">Detail</a>
                    </div>
                </div>
            </div>
        </div>
    </div>
    <!-- Page Header Start -->


    <!-- Detail Start -->
    <div class=""container py-5"">
        <div class=""row"">
            <!-- Blog Detail Start -->
            <div class=""col-lg-8"">
                <div class=""d-flex flex-column text-left mb-4"">
                    <h6 class=""text-primary font-weight-normal text-uppercase mb-3"">Blog Detail Page</h6>
                    <h1 class=""mb-4 section-title"">Diam dolor est ipsum clita lorem</h1>
                    <div class=""d-index-flex mb-2"">
                        <span class=""mr-3""><i class=""fa fa-user text-primary""></i> Admin</span>
                        <span class=""mr-3""><i class=""fa fa-folder text-primary""></i> Web Design</span>
                        <span class=""mr-3""><i class=""fa fa-comments text-primary""></i> 15</span>
                    </div>
                </div>

                <div class=""mb-5"">
       ");
            WriteLiteral(@"             <img class=""img-fluid w-100 mb-4"" src=""img/carousel-1.jpg"" alt=""Image"">
                    <p>Sadipscing labore amet rebum est et justo gubergren. Et eirmod ipsum sit diam ut magna lorem. Nonumy vero labore lorem sanctus rebum et lorem magna kasd, stet amet magna accusam consetetur eirmod. Kasd accusam sit ipsum sadipscing et at at sanctus et. Ipsum sit gubergren dolores et, consetetur justo invidunt at et aliquyam ut et vero clita. Diam sea sea no sed dolores diam nonumy, gubergren sit stet no diam kasd vero.</p>
                    <p>Voluptua est takimata stet invidunt sed rebum nonumy stet, clita aliquyam dolores vero stet consetetur elitr takimata rebum sanctus. Sit sed accusam stet sit nonumy kasd diam dolores, sanctus lorem kasd duo dolor dolor vero sit et. Labore ipsum duo sanctus amet eos et. Consetetur no sed et aliquyam ipsum justo et, clita lorem sit vero amet amet est dolor elitr, stet et no diam sit. Dolor erat justo dolore sit invidunt.</p>
                    <h2 class=""mb-4"">");
            WriteLiteral(@"Est dolor lorem et ea</h2>
                    <img class=""img-fluid w-50 float-left mr-4 mb-3"" src=""img/blog-1.jpg"" alt=""Image"">
                    <p>Diam dolor est labore duo invidunt ipsum clita et, sed et lorem voluptua tempor invidunt at est sanctus sanctus. Clita dolores sit kasd diam takimata justo diam lorem sed. Magna amet sed rebum eos. Clita no magna no dolor erat diam tempor rebum consetetur, sanctus labore sed nonumy diam lorem amet eirmod. No at tempor sea diam kasd, takimata ea nonumy elitr sadipscing gubergren erat. Gubergren at lorem invidunt sadipscing rebum sit amet ut ut, voluptua diam dolores at sadipscing stet. Clita dolor amet dolor ipsum vero ea ea eos. Invidunt sed diam dolores takimata dolor dolore dolore sit. Sit ipsum erat amet lorem et, magna sea at sed et eos. Accusam eirmod kasd lorem clita sanctus ut consetetur et. Et duo tempor sea kasd clita ipsum et. Takimata kasd diam justo est eos erat aliquyam et ut. Ea sed sadipscing no justo et eos labore, gubergren ipsum magna dolo");
            WriteLiteral(@"r lorem dolore, elitr aliquyam takimata sea kasd dolores diam, amet et est accusam labore eirmod vero et voluptua. Amet labore clita duo et no. Rebum voluptua magna eos magna, justo gubergren labore sit voluptua eos.</p>
                    <h3 class=""mb-4"">Est dolor lorem et ea</h3>
                    <img class=""img-fluid w-50 float-right ml-4 mb-3"" src=""img/blog-2.jpg"" alt=""Image"">
                    <p>Diam dolor est labore duo invidunt ipsum clita et, sed et lorem voluptua tempor invidunt at est sanctus sanctus. Clita dolores sit kasd diam takimata justo diam lorem sed. Magna amet sed rebum eos. Clita no magna no dolor erat diam tempor rebum consetetur, sanctus labore sed nonumy diam lorem amet eirmod. No at tempor sea diam kasd, takimata ea nonumy elitr sadipscing gubergren erat. Gubergren at lorem invidunt sadipscing rebum sit amet ut ut, voluptua diam dolores at sadipscing stet. Clita dolor amet dolor ipsum vero ea ea eos. Invidunt sed diam dolores takimata dolor dolore dolore sit. Sit ipsum erat");
            WriteLiteral(@" amet lorem et, magna sea at sed et eos. Accusam eirmod kasd lorem clita sanctus ut consetetur et. Et duo tempor sea kasd clita ipsum et. Takimata kasd diam justo est eos erat aliquyam et ut. Ea sed sadipscing no justo et eos labore, gubergren ipsum magna dolor lorem dolore, elitr aliquyam takimata sea kasd dolores diam, amet et est accusam labore eirmod vero et voluptua. Amet labore clita duo et no.</p>
                </div>

                <!-- Related Post Start -->
                <div class=""mb-5"">
                    <h3 class=""font-weight-bold mb-4"">Related Post</h3>
                    <div class=""owl-carousel related-carousel position-relative"">
                        <div class=""bg-light"">
                            <div class=""position-relative"">
                                <img class=""img-fluid w-100"" src=""img/blog-1.jpg""");
            BeginWriteAttribute("alt", " alt=\"", 5788, "\"", 5794, 0);
            EndWriteAttribute();
            WriteLiteral(">\r\n                                <a");
            BeginWriteAttribute("href", " href=\"", 5832, "\"", 5839, 0);
            EndWriteAttribute();
            WriteLiteral(@" class=""position-absolute w-100 h-100 d-flex flex-column align-items-center justify-content-center   text-decoration-none p-4"" style=""top: 0; left: 0; background: rgba(0, 0, 0, .4);"">
                                    <h4 class=""text-center text-white font-weight-medium mb-3"">Dolor site amet clita kasd sanct ipsum</h4>
                                    <div class=""d-flex text-light"">
                                        <small class=""mr-2""><i class=""fa fa-user text-secondary""></i> Admin</small>
                                        <small class=""mr-2""><i class=""fa fa-folder text-secondary""></i> Web Design</small>
                                        <small class=""mr-2""><i class=""fa fa-comments text-secondary""></i> 15</small>
                                    </div>
                                </a>
                            </div>
                            <p class=""m-0 p-4"">Amet dolores labore magna et amet tempor dolor et dolor. Et sit ipsum et eos rebum labore ea labore sea. E");
            WriteLiteral(@"t sed elitr labore sed labore. Lorem et lorem amet sed sed kasd ipsum rebum</p>
                        </div>
                        <div class=""bg-light"">
                            <div class=""position-relative"">
                                <img class=""img-fluid w-100"" src=""img/blog-2.jpg""");
            BeginWriteAttribute("alt", " alt=\"", 7167, "\"", 7173, 0);
            EndWriteAttribute();
            WriteLiteral(">\r\n                                <a");
            BeginWriteAttribute("href", " href=\"", 7211, "\"", 7218, 0);
            EndWriteAttribute();
            WriteLiteral(@" class=""position-absolute w-100 h-100 d-flex flex-column align-items-center justify-content-center   text-decoration-none p-4"" style=""top: 0; left: 0; background: rgba(0, 0, 0, .4);"">
                                    <h4 class=""text-center text-white font-weight-medium mb-3"">Dolor site amet clita kasd sanct ipsum</h4>
                                    <div class=""d-flex text-light"">
                                        <small class=""mr-2""><i class=""fa fa-user text-secondary""></i> Admin</small>
                                        <small class=""mr-2""><i class=""fa fa-folder text-secondary""></i> Web Design</small>
                                        <small class=""mr-2""><i class=""fa fa-comments text-secondary""></i> 15</small>
                                    </div>
                                </a>
                            </div>
                            <p class=""m-0 p-4"">Amet dolores labore magna et amet tempor dolor et dolor. Et sit ipsum et eos rebum labore ea labore sea. E");
            WriteLiteral(@"t sed elitr labore sed labore. Lorem et lorem amet sed sed kasd ipsum rebum</p>
                        </div>
                        <div class=""bg-light"">
                            <div class=""position-relative"">
                                <img class=""img-fluid w-100"" src=""img/blog-3.jpg""");
            BeginWriteAttribute("alt", " alt=\"", 8546, "\"", 8552, 0);
            EndWriteAttribute();
            WriteLiteral(">\r\n                                <a");
            BeginWriteAttribute("href", " href=\"", 8590, "\"", 8597, 0);
            EndWriteAttribute();
            WriteLiteral(@" class=""position-absolute w-100 h-100 d-flex flex-column align-items-center justify-content-center   text-decoration-none p-4"" style=""top: 0; left: 0; background: rgba(0, 0, 0, .4);"">
                                    <h4 class=""text-center text-white font-weight-medium mb-3"">Dolor site amet clita kasd sanct ipsum</h4>
                                    <div class=""d-flex text-light"">
                                        <small class=""mr-2""><i class=""fa fa-user text-secondary""></i> Admin</small>
                                        <small class=""mr-2""><i class=""fa fa-folder text-secondary""></i> Web Design</small>
                                        <small class=""mr-2""><i class=""fa fa-comments text-secondary""></i> 15</small>
                                    </div>
                                </a>
                            </div>
                            <p class=""m-0 p-4"">Amet dolores labore magna et amet tempor dolor et dolor. Et sit ipsum et eos rebum labore ea labore sea. E");
            WriteLiteral(@"t sed elitr labore sed labore. Lorem et lorem amet sed sed kasd ipsum rebum</p>
                        </div>
                    </div>
                </div>
                <!-- Related Post End -->

                <!-- Comment List Start -->
                <div class=""mb-5"">
                    <h3 class=""font-weight-bold mb-4"">3 Comments</h3>
                    <div class=""media mb-4"">
                        <img src=""img/user.jpg"" alt=""Image"" class=""img-fluid mr-3 mt-1"" style=""width: 45px;"">
                        <div class=""media-body"">
                            <h6>John Doe <small><i>01 Jan 2045 at 12:00pm</i></small></h6>
                            <p>Diam amet duo labore stet elitr invidunt ea clita ipsum voluptua, tempor labore accusam ipsum et no at. Kasd diam tempor rebum magna dolores sed sed eirmod ipsum. Gubergren clita aliquyam consetetur sadipscing, at tempor amet ipsum diam tempor consetetur at sit.</p>
                            <button class=""btn btn-sm btn-light""");
            WriteLiteral(@">Reply</button>
                        </div>
                    </div>
                    <div class=""media mb-4"">
                        <img src=""img/user.jpg"" alt=""Image"" class=""img-fluid mr-3 mt-1"" style=""width: 45px;"">
                        <div class=""media-body"">
                            <h6>John Doe <small><i>01 Jan 2045 at 12:00pm</i></small></h6>
                            <p>Diam amet duo labore stet elitr invidunt ea clita ipsum voluptua, tempor labore accusam ipsum et no at. Kasd diam tempor rebum magna dolores sed sed eirmod ipsum. Gubergren clita aliquyam consetetur sadipscing, at tempor amet ipsum diam tempor consetetur at sit.</p>
                            <button class=""btn btn-sm btn-light"">Reply</button>
                            <div class=""media mt-4"">
                                <img src=""img/user.jpg"" alt=""Image"" class=""img-fluid mr-3 mt-1"" style=""width: 45px;"">
                                <div class=""media-body"">
                                    <");
            WriteLiteral(@"h6>John Doe <small><i>01 Jan 2045 at 12:00pm</i></small></h6>
                                    <p>Diam amet duo labore stet elitr invidunt ea clita ipsum voluptua, tempor labore accusam ipsum et no at. Kasd diam tempor rebum magna dolores sed sed eirmod ipsum. Gubergren clita aliquyam consetetur sadipscing, at tempor amet ipsum diam tempor consetetur at sit.</p>
                                    <button class=""btn btn-sm btn-light"">Reply</button>
                                </div>
                            </div>
                        </div>
                    </div>
                </div>
                <!-- Comment List End -->

                <!-- Comment Form Start -->
                <div class=""bg-light p-5"">
                    <h3 class=""font-weight-bold mb-4"">Leave a comment</h3>
                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "0c0f36040328ae0617943a88a2b40e87188a15a320120", async() => {
                WriteLiteral(@"
                        <div class=""form-group"">
                            <label for=""name"">Name *</label>
                            <input type=""text"" class=""form-control"" id=""name"">
                        </div>
                        <div class=""form-group"">
                            <label for=""email"">Email *</label>
                            <input type=""email"" class=""form-control"" id=""email"">
                        </div>
                        <div class=""form-group"">
                            <label for=""website"">Website</label>
                            <input type=""url"" class=""form-control"" id=""website"">
                        </div>

                        <div class=""form-group"">
                            <label for=""message"">Message *</label>
                            <textarea id=""message"" cols=""30"" rows=""5"" class=""form-control""></textarea>
                        </div>
                        <div class=""form-group mb-0"">
                            <");
                WriteLiteral("input type=\"submit\" value=\"Leave Comment\" class=\"btn btn-primary px-3\">\r\n                        </div>\r\n                    ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
                </div>
                <!-- Comment Form End -->
            </div>
            <!-- Blog Detail End -->

            <!-- Sidebar Start -->
            <div class=""col-lg-4 mt-5 mt-lg-0"">
                <!-- Author Start -->
                <div class=""d-flex flex-column text-center bg-secondary mb-5 py-5 px-4"">
                    <img class=""rounded-circle bg-white shadow mx-auto mb-4"" src=""img/user.jpg"" style=""width: 100px; height: 100px; padding: 12px;""");
            BeginWriteAttribute("alt", " alt=\"", 14171, "\"", 14177, 0);
            EndWriteAttribute();
            WriteLiteral(@">
                    <h3 class=""text-primary mb-3"">John Doe</h3>
                    <p class=""text-white m-0"">Conset elitr erat vero dolor ipsum et diam, eos dolor lorem ipsum, ipsum ipsum sit no ut est. Guber ea ipsum erat kasd amet est elitr ea sit.</p>
                </div>
                <!-- Author End -->

                <!-- Search Form Start -->
                <div class=""mb-5"">
                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "0c0f36040328ae0617943a88a2b40e87188a15a323655", async() => {
                WriteLiteral(@"
                        <div class=""input-group"">
                            <input type=""text"" class=""form-control form-control-lg"" placeholder=""Keyword"">
                            <div class=""input-group-append"">
                                <span class=""input-group-text bg-transparent text-primary""><i
                                        class=""fa fa-search""></i></span>
                            </div>
                        </div>
                    ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
                </div>
                <!-- Search Form End -->

                <!-- Category Start -->
                <div class=""mb-5"">
                    <h3 class=""font-weight-bold mb-4"">Categories</h3>
                    <ul class=""list-group"">
                        <li class=""list-group-item d-flex justify-content-between align-items-center"">
                            Web Design
                            <span class=""badge badge-primary badge-pill"">150</span>
                        </li>
                        <li class=""list-group-item d-flex justify-content-between align-items-center"">
                            Web Development
                            <span class=""badge badge-primary badge-pill"">131</span>
                        </li>
                        <li class=""list-group-item d-flex justify-content-between align-items-center"">
                            Online Marketing
                            <span class=""badge badge-primary badge-pill"">78</span>
  ");
            WriteLiteral(@"                      </li>
                        <li class=""list-group-item d-flex justify-content-between align-items-center"">
                            Keyword Research
                            <span class=""badge badge-primary badge-pill"">56</span>
                        </li>
                        <li class=""list-group-item d-flex justify-content-between align-items-center"">
                            Email Marketing
                            <span class=""badge badge-primary badge-pill"">98</span>
                        </li>
                    </ul>
                </div>
                <!-- Category End -->

                <!-- Image Start -->
                <div class=""mb-5"">
                    <img src=""img/blog-1.jpg""");
            BeginWriteAttribute("alt", " alt=\"", 16898, "\"", 16904, 0);
            EndWriteAttribute();
            WriteLiteral(@" class=""img-fluid"">
                </div>
                <!-- Image End -->

                <!-- Recent Post Start -->
                <div class=""mb-5"">
                    <h3 class=""font-weight-bold mb-4"">Recent Post</h3>
                    <div class=""d-flex align-items-center border-bottom mb-3 pb-3"">
                        <img class=""img-fluid"" src=""img/blog-1.jpg"" style=""width: 80px; height: 80px;""");
            BeginWriteAttribute("alt", " alt=\"", 17327, "\"", 17333, 0);
            EndWriteAttribute();
            WriteLiteral(">\r\n                        <div class=\"d-flex flex-column pl-3\">\r\n                            <a class=\"text-dark mb-2\"");
            BeginWriteAttribute("href", " href=\"", 17453, "\"", 17460, 0);
            EndWriteAttribute();
            WriteLiteral(@">Lorem ipsum dolor sit amet consec adipis elit</a>
                            <div class=""d-flex"">
                                <small class=""mr-3""><i class=""fa fa-user text-primary""></i> Admin</small>
                                <small class=""mr-3""><i class=""fa fa-folder text-primary""></i> Web Design</small>
                                <small class=""mr-3""><i class=""fa fa-comments text-primary""></i> 15</small>
                            </div>
                        </div>
                    </div>
                    <div class=""d-flex align-items-center border-bottom mb-3 pb-3"">
                        <img class=""img-fluid"" src=""img/blog-2.jpg"" style=""width: 80px; height: 80px;""");
            BeginWriteAttribute("alt", " alt=\"", 18175, "\"", 18181, 0);
            EndWriteAttribute();
            WriteLiteral(">\r\n                        <div class=\"d-flex flex-column pl-3\">\r\n                            <a class=\"text-dark mb-2\"");
            BeginWriteAttribute("href", " href=\"", 18301, "\"", 18308, 0);
            EndWriteAttribute();
            WriteLiteral(@">Lorem ipsum dolor sit amet consec adipis elit</a>
                            <div class=""d-flex"">
                                <small class=""mr-3""><i class=""fa fa-user text-primary""></i> Admin</small>
                                <small class=""mr-3""><i class=""fa fa-folder text-primary""></i> Web Design</small>
                                <small class=""mr-3""><i class=""fa fa-comments text-primary""></i> 15</small>
                            </div>
                        </div>
                    </div>
                    <div class=""d-flex align-items-center border-bottom mb-3 pb-3"">
                        <img class=""img-fluid"" src=""img/blog-3.jpg"" style=""width: 80px; height: 80px;""");
            BeginWriteAttribute("alt", " alt=\"", 19023, "\"", 19029, 0);
            EndWriteAttribute();
            WriteLiteral(">\r\n                        <div class=\"d-flex flex-column pl-3\">\r\n                            <a class=\"text-dark mb-2\"");
            BeginWriteAttribute("href", " href=\"", 19149, "\"", 19156, 0);
            EndWriteAttribute();
            WriteLiteral(@">Lorem ipsum dolor sit amet consec adipis elit</a>
                            <div class=""d-flex"">
                                <small class=""mr-3""><i class=""fa fa-user text-primary""></i> Admin</small>
                                <small class=""mr-3""><i class=""fa fa-folder text-primary""></i> Web Design</small>
                                <small class=""mr-3""><i class=""fa fa-comments text-primary""></i> 15</small>
                            </div>
                        </div>
                    </div>
                    <div class=""d-flex align-items-center border-bottom mb-3 pb-3"">
                        <img class=""img-fluid"" src=""img/blog-1.jpg"" style=""width: 80px; height: 80px;""");
            BeginWriteAttribute("alt", " alt=\"", 19871, "\"", 19877, 0);
            EndWriteAttribute();
            WriteLiteral(">\r\n                        <div class=\"d-flex flex-column pl-3\">\r\n                            <a class=\"text-dark mb-2\"");
            BeginWriteAttribute("href", " href=\"", 19997, "\"", 20004, 0);
            EndWriteAttribute();
            WriteLiteral(@">Lorem ipsum dolor sit amet consec adipis elit</a>
                            <div class=""d-flex"">
                                <small class=""mr-3""><i class=""fa fa-user text-primary""></i> Admin</small>
                                <small class=""mr-3""><i class=""fa fa-folder text-primary""></i> Web Design</small>
                                <small class=""mr-3""><i class=""fa fa-comments text-primary""></i> 15</small>
                            </div>
                        </div>
                    </div>
                    <div class=""d-flex align-items-center border-bottom mb-3 pb-3"">
                        <img class=""img-fluid"" src=""img/blog-2.jpg"" style=""width: 80px; height: 80px;""");
            BeginWriteAttribute("alt", " alt=\"", 20719, "\"", 20725, 0);
            EndWriteAttribute();
            WriteLiteral(">\r\n                        <div class=\"d-flex flex-column pl-3\">\r\n                            <a class=\"text-dark mb-2\"");
            BeginWriteAttribute("href", " href=\"", 20845, "\"", 20852, 0);
            EndWriteAttribute();
            WriteLiteral(@">Lorem ipsum dolor sit amet consec adipis elit</a>
                            <div class=""d-flex"">
                                <small class=""mr-3""><i class=""fa fa-user text-primary""></i> Admin</small>
                                <small class=""mr-3""><i class=""fa fa-folder text-primary""></i> Web Design</small>
                                <small class=""mr-3""><i class=""fa fa-comments text-primary""></i> 15</small>
                            </div>
                        </div>
                    </div>
                </div>
                <!-- Recent Post End -->

                <!-- Image Start -->
                <div class=""mb-5"">
                    <img src=""img/blog-2.jpg""");
            BeginWriteAttribute("alt", " alt=\"", 21567, "\"", 21573, 0);
            EndWriteAttribute();
            WriteLiteral(@" class=""img-fluid"">
                </div>
                <!-- Image End -->

                <!-- Tags Start -->
                <div class=""mb-5"">
                    <h3 class=""font-weight-bold mb-4"">Tag Cloud</h3>
                    <div class=""d-flex flex-wrap m-n1"">
                        <a");
            BeginWriteAttribute("href", " href=\"", 21883, "\"", 21890, 0);
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-outline-primary m-1\">Design</a>\r\n                        <a");
            BeginWriteAttribute("href", " href=\"", 21966, "\"", 21973, 0);
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-outline-primary m-1\">Development</a>\r\n                        <a");
            BeginWriteAttribute("href", " href=\"", 22054, "\"", 22061, 0);
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-outline-primary m-1\">Marketing</a>\r\n                        <a");
            BeginWriteAttribute("href", " href=\"", 22140, "\"", 22147, 0);
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-outline-primary m-1\">SEO</a>\r\n                        <a");
            BeginWriteAttribute("href", " href=\"", 22220, "\"", 22227, 0);
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-outline-primary m-1\">Writing</a>\r\n                        <a");
            BeginWriteAttribute("href", " href=\"", 22304, "\"", 22311, 0);
            EndWriteAttribute();
            WriteLiteral(@" class=""btn btn-outline-primary m-1"">Consulting</a>
                    </div>
                </div>
                <!-- Tags End -->

                <!-- Image Start -->
                <div class=""mb-5"">
                    <img src=""img/blog-3.jpg""");
            BeginWriteAttribute("alt", " alt=\"", 22573, "\"", 22579, 0);
            EndWriteAttribute();
            WriteLiteral(@" class=""img-fluid"">
                </div>
                <!-- Image End -->

                <!-- Plain Text Start -->
                <div>
                    <h3 class=""font-weight-bold mb-4"">Plain Text</h3>
                    Aliquyam sed lorem stet diam dolor sed ut sit. Ut sanctus erat ea est aliquyam dolor et. Et no consetetur eos labore ea erat voluptua et. Et aliquyam dolore sed erat. Magna sanctus sed eos tempor rebum dolor, tempor takimata clita sit et elitr ut eirmod.
                </div>
                <!-- Plain Text End -->
            </div>
            <!-- Sidebar End -->
        </div>
    </div>
    <!-- Detail End -->
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
