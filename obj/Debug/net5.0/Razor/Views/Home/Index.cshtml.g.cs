#pragma checksum "C:\Users\48574\Documents\Code\TheBlogProject\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "58fefc1c0be8ff80ea6feaef3edfe83a58523ad9"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
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
#line 1 "C:\Users\48574\Documents\Code\TheBlogProject\Views\_ViewImports.cshtml"
using TheBlogProject;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "C:\Users\48574\Documents\Code\TheBlogProject\Views\Home\Index.cshtml"
using TheBlogProject.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\48574\Documents\Code\TheBlogProject\Views\Home\Index.cshtml"
using X.PagedList;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\48574\Documents\Code\TheBlogProject\Views\Home\Index.cshtml"
using X.PagedList.Mvc.Core;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\48574\Documents\Code\TheBlogProject\Views\Home\Index.cshtml"
using X.PagedList.Web.Common;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"58fefc1c0be8ff80ea6feaef3edfe83a58523ad9", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b811867fd638411d128bbc407e360539a4742b31", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IPagedList<Blog>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Posts", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "BlogPostIndex", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 7 "C:\Users\48574\Documents\Code\TheBlogProject\Views\Home\Index.cshtml"
  
    ViewData["Title"] = "Home Page";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n <div class=\"container px-4 px-lg-5\">\r\n            <div class=\"row gx-4 gx-lg-5 justify-content-center\">\r\n                <div class=\"col-md-10 col-lg-8 col-xl-7\">\r\n");
#nullable restore
#line 14 "C:\Users\48574\Documents\Code\TheBlogProject\Views\Home\Index.cshtml"
             foreach(var blog in Model)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <!-- Post preview-->\r\n                    <div class=\"post-preview\">\r\n                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "58fefc1c0be8ff80ea6feaef3edfe83a58523ad94944", async() => {
                WriteLiteral("\r\n                            <h2 class=\"post-title\">");
#nullable restore
#line 19 "C:\Users\48574\Documents\Code\TheBlogProject\Views\Home\Index.cshtml"
                                              Write(blog.Name);

#line default
#line hidden
#nullable disable
                WriteLiteral("</h2>\r\n                            <h3 class=\"post-subtitle\">");
#nullable restore
#line 20 "C:\Users\48574\Documents\Code\TheBlogProject\Views\Home\Index.cshtml"
                                                 Write(blog.Description);

#line default
#line hidden
#nullable disable
                WriteLiteral("</h3>\r\n                        ");
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
#line 18 "C:\Users\48574\Documents\Code\TheBlogProject\Views\Home\Index.cshtml"
                                                                               WriteLiteral(blog.Id);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                        <p class=\"post-meta\">\r\n                            Posted by\r\n                            <a href=\"#!\">Simon Sparrow</a>\r\n                            on ");
#nullable restore
#line 25 "C:\Users\48574\Documents\Code\TheBlogProject\Views\Home\Index.cshtml"
                          Write(blog.Created.ToString());

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </p>\r\n                    </div>\r\n");
            WriteLiteral("                    <!-- Divider-->\r\n                    <hr class=\"my-4\" />\r\n");
#nullable restore
#line 31 "C:\Users\48574\Documents\Code\TheBlogProject\Views\Home\Index.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("            \r\n                    <!-- Pager-->\r\n                    <div class=\"d-flex justify-content-end mb-4\"><a class=\"btn btn-primary text-uppercase\" href=\"#!\">Older Posts →</a></div>\r\n                </div>\r\n            </div>\r\n        </div>\r\n\r\n");
            WriteLiteral("        <div class=\"row\">\r\n            <div class=\"col h3\">\r\n                Page ");
#nullable restore
#line 42 "C:\Users\48574\Documents\Code\TheBlogProject\Views\Home\Index.cshtml"
                 Write(Model.PageCount< Model.PageNumber?0:Model.PageNumber);

#line default
#line hidden
#nullable disable
            WriteLiteral(" of ");
#nullable restore
#line 42 "C:\Users\48574\Documents\Code\TheBlogProject\Views\Home\Index.cshtml"
                                                                           Write(Model.PageCount);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </div>\r\n        </div>\r\n\r\n        <div class=\"row\">\r\n            <div class=\"col\">\r\n                ");
#nullable restore
#line 48 "C:\Users\48574\Documents\Code\TheBlogProject\Views\Home\Index.cshtml"
           Write(Html.PagedListPager(Model, page=>Url.Action("Index",new{page}),
                new PagedListRenderOptions
                {
                    LiElementClasses= new string[]{"page-item"},
                    PageClasses= new string[] {"page-link"}
                }));

#line default
#line hidden
#nullable disable
            WriteLiteral(";\r\n                \r\n            </div>\r\n        </div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IPagedList<Blog>> Html { get; private set; }
    }
}
#pragma warning restore 1591
