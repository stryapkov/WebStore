#pragma checksum "C:\Users\computer\Source\Repos\stryapkov\WebStor\WebStore\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "98a6d45538f505cd3ada8b2825edab08ca4726ff"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/Index.cshtml", typeof(AspNetCore.Views_Home_Index))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"98a6d45538f505cd3ada8b2825edab08ca4726ff", @"/Views/Home/Index.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<WebStore.Models.EmployeeView>>
    {
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 2 "C:\Users\computer\Source\Repos\stryapkov\WebStor\WebStore\Views\Home\Index.cshtml"
  
    ViewData["Title"] = "Список сотрудников";

#line default
#line hidden
            BeginContext(104, 25, true);
            WriteLiteral("<!DOCTYPE html>\r\n<html>\r\n");
            EndContext();
            BeginContext(129, 116, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "e76777cb8e36410382bcb8b490cbad21", async() => {
                BeginContext(135, 103, true);
                WriteLiteral("\r\n    <meta name=\"viewport\" content=\"width=device-width\" charset=\"utf-8\" />\r\n    <title>Index</title>\r\n");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(245, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(247, 532, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b1b7d72b8f264d0ba6b913fcd4d40d2c", async() => {
                BeginContext(253, 161, true);
                WriteLiteral("\r\n    <table>\r\n        <tr>\r\n            <td>Фамилия</td>\r\n            <td>Имя</td>\r\n            <td>Отчество</td>\r\n            <td>Возраст</td>\r\n        </tr>\r\n");
                EndContext();
#line 19 "C:\Users\computer\Source\Repos\stryapkov\WebStor\WebStore\Views\Home\Index.cshtml"
         foreach (var item in Model)
        {

#line default
#line hidden
                BeginContext(463, 38, true);
                WriteLiteral("            <tr>\r\n                <td>");
                EndContext();
                BeginContext(502, 14, false);
#line 22 "C:\Users\computer\Source\Repos\stryapkov\WebStor\WebStore\Views\Home\Index.cshtml"
               Write(item.FirstName);

#line default
#line hidden
                EndContext();
                BeginContext(516, 27, true);
                WriteLiteral("</td>\r\n                <td>");
                EndContext();
                BeginContext(544, 12, false);
#line 23 "C:\Users\computer\Source\Repos\stryapkov\WebStor\WebStore\Views\Home\Index.cshtml"
               Write(item.SurName);

#line default
#line hidden
                EndContext();
                BeginContext(556, 27, true);
                WriteLiteral("</td>\r\n                <td>");
                EndContext();
                BeginContext(584, 15, false);
#line 24 "C:\Users\computer\Source\Repos\stryapkov\WebStor\WebStore\Views\Home\Index.cshtml"
               Write(item.Patronymic);

#line default
#line hidden
                EndContext();
                BeginContext(599, 27, true);
                WriteLiteral("</td>\r\n                <td>");
                EndContext();
                BeginContext(627, 8, false);
#line 25 "C:\Users\computer\Source\Repos\stryapkov\WebStor\WebStore\Views\Home\Index.cshtml"
               Write(item.Age);

#line default
#line hidden
                EndContext();
                BeginContext(635, 27, true);
                WriteLiteral("</td>\r\n                <td>");
                EndContext();
                BeginContext(663, 58, false);
#line 26 "C:\Users\computer\Source\Repos\stryapkov\WebStor\WebStore\Views\Home\Index.cshtml"
               Write(Html.ActionLink("Детали", "Details", new { id = item.Id }));

#line default
#line hidden
                EndContext();
                BeginContext(721, 26, true);
                WriteLiteral("</td>\r\n            </tr>\r\n");
                EndContext();
#line 28 "C:\Users\computer\Source\Repos\stryapkov\WebStor\WebStore\Views\Home\Index.cshtml"
        }

#line default
#line hidden
                BeginContext(758, 14, true);
                WriteLiteral("    </table>\r\n");
                EndContext();
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
            EndContext();
            BeginContext(779, 9, true);
            WriteLiteral("\r\n</html>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<WebStore.Models.EmployeeView>> Html { get; private set; }
    }
}
#pragma warning restore 1591
