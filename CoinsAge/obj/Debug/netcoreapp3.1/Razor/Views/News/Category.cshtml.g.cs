#pragma checksum "D:\Asia Pacific University\Semester 6\Designing and Developing Applications on the Cloud\Assignment\CoinsAge\CoinsAge\Views\News\Category.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "599055fbb6d019e4988e3441a77b9ab7a68b60c9"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_News_Category), @"mvc.1.0.view", @"/Views/News/Category.cshtml")]
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
#line 1 "D:\Asia Pacific University\Semester 6\Designing and Developing Applications on the Cloud\Assignment\CoinsAge\CoinsAge\Views\_ViewImports.cshtml"
using CoinsAge;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\Asia Pacific University\Semester 6\Designing and Developing Applications on the Cloud\Assignment\CoinsAge\CoinsAge\Views\_ViewImports.cshtml"
using CoinsAge.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"599055fbb6d019e4988e3441a77b9ab7a68b60c9", @"/Views/News/Category.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"dd85cd8132af269000beadc4cb6f34f0b18df93e", @"/Views/_ViewImports.cshtml")]
    public class Views_News_Category : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<CoinsAge.Models.News>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "News", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Category", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("text-1 text-decoration-none category-link"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Details", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("text-2 text-decoration-none"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 3 "D:\Asia Pacific University\Semester 6\Designing and Developing Applications on the Cloud\Assignment\CoinsAge\CoinsAge\Views\News\Category.cshtml"
  
    ViewData["Title"] = "Category";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<div class=\"bg-1 text-1 w-100 p-4 px-5\">\r\n");
#nullable restore
#line 8 "D:\Asia Pacific University\Semester 6\Designing and Developing Applications on the Cloud\Assignment\CoinsAge\CoinsAge\Views\News\Category.cshtml"
     foreach (var item in @ViewBag.Categories)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "599055fbb6d019e4988e3441a77b9ab7a68b60c95599", async() => {
                WriteLiteral("\r\n            <p class=\"d-inline mr-4\">");
#nullable restore
#line 11 "D:\Asia Pacific University\Semester 6\Designing and Developing Applications on the Cloud\Assignment\CoinsAge\CoinsAge\Views\News\Category.cshtml"
                                Write(item.CategoryName);

#line default
#line hidden
#nullable disable
                WriteLiteral("</p>\r\n        ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 10 "D:\Asia Pacific University\Semester 6\Designing and Developing Applications on the Cloud\Assignment\CoinsAge\CoinsAge\Views\News\Category.cshtml"
                                                         WriteLiteral(item.CategoryId);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
#nullable restore
#line 13 "D:\Asia Pacific University\Semester 6\Designing and Developing Applications on the Cloud\Assignment\CoinsAge\CoinsAge\Views\News\Category.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n\r\n<div class=\"container mt-5 py-3\">\r\n");
#nullable restore
#line 17 "D:\Asia Pacific University\Semester 6\Designing and Developing Applications on the Cloud\Assignment\CoinsAge\CoinsAge\Views\News\Category.cshtml"
     foreach (var item in @ViewBag.Category)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <h4 class=\"text-3 font-weight-bold\">SHOWING NEWS FOR ");
#nullable restore
#line 19 "D:\Asia Pacific University\Semester 6\Designing and Developing Applications on the Cloud\Assignment\CoinsAge\CoinsAge\Views\News\Category.cshtml"
                                                        Write(item.CategoryName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h4>\r\n");
#nullable restore
#line 20 "D:\Asia Pacific University\Semester 6\Designing and Developing Applications on the Cloud\Assignment\CoinsAge\CoinsAge\Views\News\Category.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("    \r\n");
#nullable restore
#line 22 "D:\Asia Pacific University\Semester 6\Designing and Developing Applications on the Cloud\Assignment\CoinsAge\CoinsAge\Views\News\Category.cshtml"
     foreach (var item in @ViewBag.News)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "599055fbb6d019e4988e3441a77b9ab7a68b60c910126", async() => {
                WriteLiteral("\r\n            <div class=\"w-100 row trendnews-box mt-5 cursor-pointer\">\r\n                <div class=\"col-3\">\r\n");
#nullable restore
#line 27 "D:\Asia Pacific University\Semester 6\Designing and Developing Applications on the Cloud\Assignment\CoinsAge\CoinsAge\Views\News\Category.cshtml"
                     foreach (var image in @ViewBag.NewsImage)
                    {
                        string[] link = image.Split("#");
                        string[] fileid = link[0].Split(".");
                        

#line default
#line hidden
#nullable disable
#nullable restore
#line 31 "D:\Asia Pacific University\Semester 6\Designing and Developing Applications on the Cloud\Assignment\CoinsAge\CoinsAge\Views\News\Category.cshtml"
                         if (Int64.Parse(fileid[0]) == item.NewsId)
                        {

#line default
#line hidden
#nullable disable
                WriteLiteral("                            <img");
                BeginWriteAttribute("src", " src=\"", 1206, "\"", 1220, 1);
#nullable restore
#line 33 "D:\Asia Pacific University\Semester 6\Designing and Developing Applications on the Cloud\Assignment\CoinsAge\CoinsAge\Views\News\Category.cshtml"
WriteAttributeValue("", 1212, link[1], 1212, 8, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" class=\"w-100\">\r\n");
#nullable restore
#line 34 "D:\Asia Pacific University\Semester 6\Designing and Developing Applications on the Cloud\Assignment\CoinsAge\CoinsAge\Views\News\Category.cshtml"
                        }

#line default
#line hidden
#nullable disable
#nullable restore
#line 34 "D:\Asia Pacific University\Semester 6\Designing and Developing Applications on the Cloud\Assignment\CoinsAge\CoinsAge\Views\News\Category.cshtml"
                         
                    }

#line default
#line hidden
#nullable disable
                WriteLiteral("                </div>\r\n                <div class=\"col-9\">\r\n                    <div class=\"bg-3 text-1 font-size-1 px-3 py-1 d-inline-block font-weight-bold rounded-pill\">");
#nullable restore
#line 38 "D:\Asia Pacific University\Semester 6\Designing and Developing Applications on the Cloud\Assignment\CoinsAge\CoinsAge\Views\News\Category.cshtml"
                                                                                                           Write(item.Category.CategoryName);

#line default
#line hidden
#nullable disable
                WriteLiteral("</div>\r\n                    <div class=\"text-4 font-size-1 d-inline-block\">");
#nullable restore
#line 39 "D:\Asia Pacific University\Semester 6\Designing and Developing Applications on the Cloud\Assignment\CoinsAge\CoinsAge\Views\News\Category.cshtml"
                                                              Write(item.PublishDateTime);

#line default
#line hidden
#nullable disable
                WriteLiteral("</div>\r\n                    <h5 class=\"mt-2\">");
#nullable restore
#line 40 "D:\Asia Pacific University\Semester 6\Designing and Developing Applications on the Cloud\Assignment\CoinsAge\CoinsAge\Views\News\Category.cshtml"
                                Write(item.Title);

#line default
#line hidden
#nullable disable
                WriteLiteral("</h5>\r\n                    <p>");
#nullable restore
#line 41 "D:\Asia Pacific University\Semester 6\Designing and Developing Applications on the Cloud\Assignment\CoinsAge\CoinsAge\Views\News\Category.cshtml"
                  Write(item.Content);

#line default
#line hidden
#nullable disable
                WriteLiteral("</p>\r\n                </div>\r\n            </div>\r\n        ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 24 "D:\Asia Pacific University\Semester 6\Designing and Developing Applications on the Cloud\Assignment\CoinsAge\CoinsAge\Views\News\Category.cshtml"
                                                        WriteLiteral(item.NewsId);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
#nullable restore
#line 45 "D:\Asia Pacific University\Semester 6\Designing and Developing Applications on the Cloud\Assignment\CoinsAge\CoinsAge\Views\News\Category.cshtml"

    }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<CoinsAge.Models.News> Html { get; private set; }
    }
}
#pragma warning restore 1591
