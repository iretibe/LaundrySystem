#pragma checksum "C:\Microservices\LaundrySystem\LaundrySystem.UI\Views\Dashboard\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "1cd0e71cf0f28992b022a0b62477a4b14cc17f00"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Dashboard_Index), @"mvc.1.0.view", @"/Views/Dashboard/Index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1cd0e71cf0f28992b022a0b62477a4b14cc17f00", @"/Views/Dashboard/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"174fd7856118f752d52143aa8d6cf0e9e580691a", @"/Views/_ViewImports.cshtml")]
    public class Views_Dashboard_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "C:\Microservices\LaundrySystem\LaundrySystem.UI\Views\Dashboard\Index.cshtml"
  
    ViewData["Title"] = "Dashboard";
    Layout = "~/Views/Shared/_Setup.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<div class=""row"">
    <div class=""col-lg-3"">
        <div class=""card"">
            <div class=""stat-widget-one"">
                <div class=""stat-icon dib"">
                    <i class=""ti-money color-success border-success""></i>
                </div>
                <div class=""stat-content dib"">
                    <div class=""stat-text"">Total Profit</div>
                    <div class=""stat-digit"">1,012</div>
                </div>
            </div>
        </div>
    </div>
    <div class=""col-lg-3"">
        <div class=""card"">
            <div class=""stat-widget-one"">
                <div class=""stat-icon dib"">
                    <i class=""ti-user color-primary border-primary""></i>
                </div>
                <div class=""stat-content dib"">
                    <div class=""stat-text"">New Customer</div>
                    <div class=""stat-digit"">961</div>
                </div>
            </div>
        </div>
    </div>
    <div class=""col-lg-3"">
        <div");
            WriteLiteral(@" class=""card"">
            <div class=""stat-widget-one"">
                <div class=""stat-icon dib"">
                    <i class=""ti-layout-grid2 color-pink border-pink""></i>
                </div>
                <div class=""stat-content dib"">
                    <div class=""stat-text"">Active Projects</div>
                    <div class=""stat-digit"">770</div>
                </div>
            </div>
        </div>
    </div>
    <div class=""col-lg-3"">
        <div class=""card"">
            <div class=""stat-widget-one"">
                <div class=""stat-icon dib""><i class=""ti-link color-danger border-danger""></i></div>
                <div class=""stat-content dib"">
                    <div class=""stat-text"">Referral</div>
                    <div class=""stat-digit"">2,781</div>
                </div>
            </div>
        </div>
    </div>
</div>
<div class=""row"">
    <div class=""col-lg-8"">
        <div class=""card"">
            <div class=""card-title"">
                <h4>Fe");
            WriteLiteral(@"e Collections and Expenses</h4>

            </div>
            <div class=""card-body"">
                <div class=""ct-bar-chart m-t-30""></div>
            </div>
        </div>
    </div>

    <div class=""col-lg-4"">
        <div class=""card"">

            <div class=""card-body"">
                <div class=""ct-pie-chart""></div>
            </div>
        </div>
    </div>
</div>
<div class=""row"">
    <div class=""col-lg-4"">
        <div class=""card"">
            <div class=""card-body"">
                <div class=""year-calendar""></div>
            </div>
        </div>
        <!-- /# card -->
    </div>
");
            WriteLiteral(@"    <div class=""col-lg-8"">
        <div class=""card"">
            <div class=""card-title pr"">
                <h4>All Expense</h4>

            </div>
            <div class=""card-body"">
                <div class=""table-responsive"">
                    <table class=""table student-data-table m-t-20"">
                        <thead>
                            <tr>
                                <th><label><input type=""checkbox""");
            BeginWriteAttribute("value", " value=\"", 11538, "\"", 11546, 0);
            EndWriteAttribute();
            WriteLiteral(@"></label>ID</th>
                                <th>Expense Type</th>
                                <th>Amount</th>
                                <th>Status</th>
                                <th>Email</th>
                                <th>Date</th>
                            </tr>
                        </thead>
                        <tbody>
                            <tr>
                                <td><label><input type=""checkbox""");
            BeginWriteAttribute("value", " value=\"", 12014, "\"", 12022, 0);
            EndWriteAttribute();
            WriteLiteral(@"></label>#2901</td>
                                <td>
                                    Salary
                                </td>
                                <td>
                                    $2000
                                </td>
                                <td>
                                    <span class=""badge badge-primary"">Paid</span>
                                </td>
                                <td>
                                    edumin@gmail.com
                                </td>
                                <td>
                                    10/05/2017
                                </td>
                            </tr>
                            <tr>
                                <td><label><input type=""checkbox""");
            BeginWriteAttribute("value", " value=\"", 12835, "\"", 12843, 0);
            EndWriteAttribute();
            WriteLiteral(@"></label>#2901</td>
                                <td>
                                    Salary
                                </td>
                                <td>
                                    $2000
                                </td>
                                <td>
                                    <span class=""badge badge-warning"">Pending</span>
                                </td>
                                <td>
                                    edumin@gmail.com
                                </td>
                                <td>
                                    10/05/2017
                                </td>
                            </tr>
                            <tr>
                                <td><label><input type=""checkbox""");
            BeginWriteAttribute("value", " value=\"", 13659, "\"", 13667, 0);
            EndWriteAttribute();
            WriteLiteral(@"></label>#2901</td>
                                <td>
                                    Salary
                                </td>
                                <td>
                                    $2000
                                </td>
                                <td>
                                    <span class=""badge badge-primary"">Paid</span>
                                </td>
                                <td>
                                    edumin@gmail.com
                                </td>
                                <td>
                                    10/05/2017
                                </td>
                            </tr>
                            <tr>
                                <td><label><input type=""checkbox""");
            BeginWriteAttribute("value", " value=\"", 14480, "\"", 14488, 0);
            EndWriteAttribute();
            WriteLiteral(@"></label>#2901</td>
                                <td>
                                    Salary
                                </td>
                                <td>
                                    $2000
                                </td>
                                <td>
                                    <span class=""badge badge-danger"">Due</span>
                                </td>
                                <td>
                                    edumin@gmail.com
                                </td>
                                <td>
                                    10/05/2017
                                </td>
                            </tr>
                            <tr>
                                <td><label><input type=""checkbox""");
            BeginWriteAttribute("value", " value=\"", 15299, "\"", 15307, 0);
            EndWriteAttribute();
            WriteLiteral(@"></label>#2901</td>
                                <td>
                                    Salary
                                </td>
                                <td>
                                    $2000
                                </td>
                                <td>
                                    <span class=""badge badge-primary"">Paid</span>
                                </td>
                                <td>
                                    edumin@gmail.com
                                </td>
                                <td>
                                    10/05/2017
                                </td>
                            </tr>
                        </tbody>
                    </table>
                </div>
            </div>
        </div>
    </div>
    <!-- /# column -->
");
            WriteLiteral(@"    <!-- /# column -->
</div>
<!-- /# row -->
<div class=""row"">
    <div class=""col-lg-3"">
        <div class=""card p-0"">
            <div class=""stat-widget-three home-widget-three"">
                <div class=""stat-icon bg-facebook"">
                    <i class=""ti-facebook""></i>
                </div>
                <div class=""stat-content"">
                    <div class=""stat-digit"">8,268</div>
                    <div class=""stat-text"">Likes</div>
                </div>
            </div>
        </div>
    </div>
    <div class=""col-lg-3"">
        <div class=""card p-0"">
            <div class=""stat-widget-three home-widget-three"">
                <div class=""stat-icon bg-youtube"">
                    <i class=""ti-youtube""></i>
                </div>
                <div class=""stat-content"">
                    <div class=""stat-digit"">12,545</div>
                    <div class=""stat-text"">Subscribes</div>
                </div>
            </div>
        </div>
    </di");
            WriteLiteral(@"v>
    <div class=""col-lg-3"">
        <div class=""card p-0"">
            <div class=""stat-widget-three home-widget-three"">
                <div class=""stat-icon bg-twitter"">
                    <i class=""ti-twitter""></i>
                </div>
                <div class=""stat-content"">
                    <div class=""stat-digit"">7,982</div>
                    <div class=""stat-text"">Tweets</div>
                </div>
            </div>
        </div>
    </div>
    <div class=""col-lg-3"">
        <div class=""card p-0"">
            <div class=""stat-widget-three home-widget-three"">
                <div class=""stat-icon bg-danger"">
                    <i class=""ti-linkedin""></i>
                </div>
                <div class=""stat-content"">
                    <div class=""stat-digit"">9,658</div>
                    <div class=""stat-text"">Followers</div>
                </div>
            </div>
        </div>
    </div>
</div>
");
            WriteLiteral("<!-- /# row -->\r\n\r\n");
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
