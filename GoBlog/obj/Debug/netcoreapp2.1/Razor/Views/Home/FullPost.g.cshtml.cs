#pragma checksum "C:\Users\John Karaplis\SideProjects\GoBlog\GoBlog\Views\Home\FullPost.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "00ab6d062dff97bdbc9269954fed740cbf0b9a4e"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_FullPost), @"mvc.1.0.view", @"/Views/Home/FullPost.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/FullPost.cshtml", typeof(AspNetCore.Views_Home_FullPost))]
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
#line 1 "C:\Users\John Karaplis\SideProjects\GoBlog\GoBlog\Views\_ViewImports.cshtml"
using GoBlog;

#line default
#line hidden
#line 2 "C:\Users\John Karaplis\SideProjects\GoBlog\GoBlog\Views\_ViewImports.cshtml"
using GoBlog.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"00ab6d062dff97bdbc9269954fed740cbf0b9a4e", @"/Views/Home/FullPost.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0beff96d5e095c31aa22f2827cbe43f74cd3f633", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_FullPost : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Post>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Home", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 2 "C:\Users\John Karaplis\SideProjects\GoBlog\GoBlog\Views\Home\FullPost.cshtml"
  
    ViewData["Title"] = "FullPost";
    string lastTag = Model.Tags[Model.Tags.Count - 1];

#line default
#line hidden
            BeginContext(113, 22, true);
            WriteLiteral("\r\n<div class=\"post\">\r\n");
            EndContext();
#line 8 "C:\Users\John Karaplis\SideProjects\GoBlog\GoBlog\Views\Home\FullPost.cshtml"
     if (Model.Username == null)
    {


#line default
#line hidden
            BeginContext(178, 108, true);
            WriteLiteral("        <div class=\"error\">\r\n            <h2>Uh-oh! Looks like you\'re in the wrong place.</h2>\r\n            ");
            EndContext();
            BeginContext(286, 96, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "6c0e880f99b54c71aa515d220d50acad", async() => {
                BeginContext(330, 48, true);
                WriteLiteral("\r\n                <h2>Return?</h2>\r\n            ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(382, 18, true);
            WriteLiteral("\r\n        </div>\r\n");
            EndContext();
#line 17 "C:\Users\John Karaplis\SideProjects\GoBlog\GoBlog\Views\Home\FullPost.cshtml"

    }
    else
    {
        string postDate = Model.DatePosted[0];
        string postTime = Model.DatePosted[1];


#line default
#line hidden
            BeginContext(524, 37, true);
            WriteLiteral("        <h2 class=\"full_post_header\">");
            EndContext();
            BeginContext(562, 11, false);
#line 24 "C:\Users\John Karaplis\SideProjects\GoBlog\GoBlog\Views\Home\FullPost.cshtml"
                                Write(Model.Title);

#line default
#line hidden
            EndContext();
            BeginContext(573, 7, true);
            WriteLiteral("</h2>\r\n");
            EndContext();
            BeginContext(582, 77, true);
            WriteLiteral("        <div class=\"post_body\">\r\n            <p class=\"postedby_info\">posted ");
            EndContext();
            BeginContext(660, 8, false);
#line 27 "C:\Users\John Karaplis\SideProjects\GoBlog\GoBlog\Views\Home\FullPost.cshtml"
                                       Write(postDate);

#line default
#line hidden
            EndContext();
            BeginContext(668, 4, true);
            WriteLiteral(" at ");
            EndContext();
            BeginContext(673, 8, false);
#line 27 "C:\Users\John Karaplis\SideProjects\GoBlog\GoBlog\Views\Home\FullPost.cshtml"
                                                    Write(postTime);

#line default
#line hidden
            EndContext();
            BeginContext(681, 4, true);
            WriteLiteral(" by ");
            EndContext();
            BeginContext(686, 14, false);
#line 27 "C:\Users\John Karaplis\SideProjects\GoBlog\GoBlog\Views\Home\FullPost.cshtml"
                                                                 Write(Model.Username);

#line default
#line hidden
            EndContext();
            BeginContext(700, 39, true);
            WriteLiteral("</p>\r\n            <p class=\"post_text\">");
            EndContext();
            BeginContext(740, 10, false);
#line 28 "C:\Users\John Karaplis\SideProjects\GoBlog\GoBlog\Views\Home\FullPost.cshtml"
                            Write(Model.Body);

#line default
#line hidden
            EndContext();
            BeginContext(750, 217, true);
            WriteLiteral("</p>\r\n\r\n            <div class=\"tag_block\">\r\n                <p class=\"tags\"><strong>tags:</strong></p>\r\n                <!-- We check each tag to see if is the last tag;\r\n                if so, it gets no comma -->\r\n");
            EndContext();
#line 34 "C:\Users\John Karaplis\SideProjects\GoBlog\GoBlog\Views\Home\FullPost.cshtml"
                 foreach (var tag in Model.Tags)
                {
                    if (tag != lastTag)
                    {

#line default
#line hidden
            BeginContext(1100, 40, true);
            WriteLiteral("                        <p class=\"tags\">");
            EndContext();
            BeginContext(1141, 3, false);
#line 38 "C:\Users\John Karaplis\SideProjects\GoBlog\GoBlog\Views\Home\FullPost.cshtml"
                                   Write(tag);

#line default
#line hidden
            EndContext();
            BeginContext(1144, 7, true);
            WriteLiteral(",</p>\r\n");
            EndContext();
#line 39 "C:\Users\John Karaplis\SideProjects\GoBlog\GoBlog\Views\Home\FullPost.cshtml"
                    }
                    else
                    {

#line default
#line hidden
            BeginContext(1223, 40, true);
            WriteLiteral("                        <p class=\"tags\">");
            EndContext();
            BeginContext(1264, 3, false);
#line 42 "C:\Users\John Karaplis\SideProjects\GoBlog\GoBlog\Views\Home\FullPost.cshtml"
                                   Write(tag);

#line default
#line hidden
            EndContext();
            BeginContext(1267, 6, true);
            WriteLiteral("</p>\r\n");
            EndContext();
#line 43 "C:\Users\John Karaplis\SideProjects\GoBlog\GoBlog\Views\Home\FullPost.cshtml"
                    }
                }

#line default
#line hidden
            BeginContext(1315, 36, true);
            WriteLiteral("            </div>\r\n        </div>\r\n");
            EndContext();
#line 47 "C:\Users\John Karaplis\SideProjects\GoBlog\GoBlog\Views\Home\FullPost.cshtml"
    }

#line default
#line hidden
            BeginContext(1358, 6, true);
            WriteLiteral("</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Post> Html { get; private set; }
    }
}
#pragma warning restore 1591
