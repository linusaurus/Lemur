#pragma checksum "C:\Users\rich.DESIGNSYNTHESIS\Source\Repos\Weaselware.Lemur\Weaselware.Lemur\Pages\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "8d80b7abbf0226dda28d7aad24eb19e0475eef11"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(Weaselware.Lemur.Pages.Pages_Index), @"mvc.1.0.razor-page", @"/Pages/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.RazorPages.Infrastructure.RazorPageAttribute(@"/Pages/Index.cshtml", typeof(Weaselware.Lemur.Pages.Pages_Index), null)]
namespace Weaselware.Lemur.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#line 1 "C:\Users\rich.DESIGNSYNTHESIS\Source\Repos\Weaselware.Lemur\Weaselware.Lemur\Pages\_ViewImports.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#line 2 "C:\Users\rich.DESIGNSYNTHESIS\Source\Repos\Weaselware.Lemur\Weaselware.Lemur\Pages\_ViewImports.cshtml"
using Weaselware.Lemur;

#line default
#line hidden
#line 3 "C:\Users\rich.DESIGNSYNTHESIS\Source\Repos\Weaselware.Lemur\Weaselware.Lemur\Pages\_ViewImports.cshtml"
using Weaselware.Lemur.Data;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8d80b7abbf0226dda28d7aad24eb19e0475eef11", @"/Pages/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f51ad6d1a1c67d0a21aa1ccc9a0205b782f8c9a4", @"/Pages/_ViewImports.cshtml")]
    public class Pages_Index : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-page", "./Orders/Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn-link"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-page", "./Parts/Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-page", "./Products/Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
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
#line 3 "C:\Users\rich.DESIGNSYNTHESIS\Source\Repos\Weaselware.Lemur\Weaselware.Lemur\Pages\Index.cshtml"
  
    ViewData["Title"] = "Home page";
  

#line default
#line hidden
            BeginContext(75, 119, true);
            WriteLiteral("\r\n\r\n\r\n<div class=\"row\">\r\n    <div class=\"col-md-3 \">\r\n        <h2>Design Synthesis</h2>\r\n        <ul>\r\n            <li>");
            EndContext();
            BeginContext(194, 72, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "9bc514e4459a4294873addf41f401488", async() => {
                BeginContext(240, 22, true);
                WriteLiteral("Create Purchase Order ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Page = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(266, 23, true);
            WriteLiteral("</li>\r\n            <li>");
            EndContext();
            BeginContext(289, 72, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "383f9f7e65ce4c2e99804ef608fbe6fe", async() => {
                BeginContext(335, 22, true);
                WriteLiteral("Recieve Purchase Order");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Page = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(361, 23, true);
            WriteLiteral("</li>\r\n            <li>");
            EndContext();
            BeginContext(384, 60, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "bc63b381d5484651818ff244dd8fcf25", async() => {
                BeginContext(429, 11, true);
                WriteLiteral("Create Part");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Page = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(444, 23, true);
            WriteLiteral("</li>\r\n            <li>");
            EndContext();
            BeginContext(467, 63, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "dece698277034ad9a34ac86a4d79169b", async() => {
                BeginContext(515, 11, true);
                WriteLiteral("New Product");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Page = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(530, 780, true);
            WriteLiteral(@"</li>
            
 
        </ul>
    </div>
</div>

<div class=""container"">
 
    <div class=""alert alert-warning "">
        <h4>Import Notice</h4>
        <p></p>
    </div>
    <hr />
    <div class=""agenda"">
        <div class=""table-responsive"">
            <table class=""table table-condensed table-bordered"">
                <thead>
                    <tr>
                        <th>Date</th>
                        <th>Time</th>
                        <th>Event</th>
                    </tr>
                </thead>
                <tbody>
                    <!-- Single event in a single day -->
                    <tr>
                        <td class=""agenda-date"" class=""active"" rowspan=""1"">
                            <div><h2>");
            EndContext();
            BeginContext(1311, 18, false);
#line 45 "C:\Users\rich.DESIGNSYNTHESIS\Source\Repos\Weaselware.Lemur\Weaselware.Lemur\Pages\Index.cshtml"
                                Write(DateTime.Today.Day);

#line default
#line hidden
            EndContext();
            BeginContext(1329, 46, true);
            WriteLiteral("</h2></div>\r\n                            <div>");
            EndContext();
            BeginContext(1376, 24, false);
#line 46 "C:\Users\rich.DESIGNSYNTHESIS\Source\Repos\Weaselware.Lemur\Weaselware.Lemur\Pages\Index.cshtml"
                            Write(DateTime.Today.DayOfWeek);

#line default
#line hidden
            EndContext();
            BeginContext(1400, 196, true);
            WriteLiteral("</div>\r\n                            <div class=\"shortdate text-muted\">July, 2014</div>\r\n                        </td>\r\n                        <td class=\"agenda-time\">\r\n                           ");
            EndContext();
            BeginContext(1597, 32, false);
#line 50 "C:\Users\rich.DESIGNSYNTHESIS\Source\Repos\Weaselware.Lemur\Weaselware.Lemur\Pages\Index.cshtml"
                      Write(DateTime.Now.ToShortTimeString());

#line default
#line hidden
            EndContext();
            BeginContext(1629, 653, true);
            WriteLiteral(@"
                        </td>
                        <td class=""agenda-events"">
                            <div class=""agenda-event"">
                                <i class=""glyphicon glyphicon-repeat text-muted"" title=""Repeating event""></i>
                                <a href=""https://www.smartsheet.com/"">Schedule</a>
                            </div>
                        </td>
                    </tr>

                    <!-- Multiple events in a single day (note the rowspan) -->
                    <tr>
                        <td class=""agenda-date"" class=""active"" rowspan=""3"">
                            <div><h2>");
            EndContext();
            BeginContext(2283, 29, false);
#line 63 "C:\Users\rich.DESIGNSYNTHESIS\Source\Repos\Weaselware.Lemur\Weaselware.Lemur\Pages\Index.cshtml"
                                Write(DateTime.Today.AddDays(1).Day);

#line default
#line hidden
            EndContext();
            BeginContext(2312, 48, true);
            WriteLiteral(" </h2></div>\r\n                            <div >");
            EndContext();
            BeginContext(2361, 35, false);
#line 64 "C:\Users\rich.DESIGNSYNTHESIS\Source\Repos\Weaselware.Lemur\Weaselware.Lemur\Pages\Index.cshtml"
                             Write(DateTime.Today.AddDays(1).DayOfWeek);

#line default
#line hidden
            EndContext();
            BeginContext(2396, 1371, true);
            WriteLiteral(@"</div>
                            <div class=""shortdate text-muted"">July, 2014</div>
                        </td>
                        <td class=""agenda-time"">
                            8:00 - 9:00 AM
                        </td>
                        <td class=""agenda-events"">
                            <div class=""agenda-event"">
                                Delivery
                            </div>
                        </td>
                    </tr>
                    <tr>
                        <td class=""agenda-time"">
                            10:15 AM - 12:00 PM
                        </td>
                        <td class=""agenda-events"">
                            <div class=""agenda-event"">
                                Review
                            </div>
                        </td>
                    </tr>
                    <tr>
                        <td class=""agenda-time"">
                            7:00 - 9:00 PM
                  ");
            WriteLiteral(@"      </td>
                        <td class=""agenda-events"">
                            <div class=""agenda-event"">
                                Safety Meeting
                            </div>
                        </td>
                    </tr>
                </tbody>
            </table>
        </div>
    </div>
</div>
");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IndexModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<IndexModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<IndexModel>)PageContext?.ViewData;
        public IndexModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
