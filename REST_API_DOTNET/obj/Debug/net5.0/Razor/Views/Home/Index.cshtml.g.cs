#pragma checksum "C:\Users\Hi-tech\OneDrive\Рабочий стол\REST_API_DOTNET\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "883e0383b0eb63b262f5d995571f0536190598ac"
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
#line 1 "C:\Users\Hi-tech\OneDrive\Рабочий стол\REST_API_DOTNET\Views\_ViewImports.cshtml"
using REST_API_DOTNET;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Hi-tech\OneDrive\Рабочий стол\REST_API_DOTNET\Views\_ViewImports.cshtml"
using REST_API_DOTNET.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"883e0383b0eb63b262f5d995571f0536190598ac", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"71a53404e5546a11bdd57a8c3176c490ad49ce9a", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<REST_API_DOTNET.Models.Computer>>
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\Hi-tech\OneDrive\Рабочий стол\REST_API_DOTNET\Views\Home\Index.cshtml"
  
   // Layout = null;

#line default
#line hidden
#nullable disable
            WriteLiteral("<html>\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "883e0383b0eb63b262f5d995571f0536190598ac3450", async() => {
                WriteLiteral("\r\n    <title></title>\r\n    <link");
                BeginWriteAttribute("href", " href=\'", 128, "\'", 186, 1);
#nullable restore
#line 8 "C:\Users\Hi-tech\OneDrive\Рабочий стол\REST_API_DOTNET\Views\Home\Index.cshtml"
WriteAttributeValue("", 135, Url.Content("~/Content/themes/base/jquery-ui.css"), 135, 51, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" rel=\"stylesheet\" type=\"text/css\" />\r\n");
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
            WriteLiteral("\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "883e0383b0eb63b262f5d995571f0536190598ac4900", async() => {
                WriteLiteral("\r\n    <h2>Список компьютеров</h2>\r\n    <table>\r\n");
#nullable restore
#line 13 "C:\Users\Hi-tech\OneDrive\Рабочий стол\REST_API_DOTNET\Views\Home\Index.cshtml"
     foreach (var c in Model)
    {

#line default
#line hidden
#nullable disable
                WriteLiteral("        <tr><td>");
#nullable restore
#line 15 "C:\Users\Hi-tech\OneDrive\Рабочий стол\REST_API_DOTNET\Views\Home\Index.cshtml"
           Write(c.Model);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td><td>\r\n        ");
#nullable restore
#line 16 "C:\Users\Hi-tech\OneDrive\Рабочий стол\REST_API_DOTNET\Views\Home\Index.cshtml"
   Write(Html.ActionLink("Смотреть", "Details", "Home", new { id = c.Id }, 
            new { @class = "viewDialog",  data_dialog_title = "Описание модели" }));

#line default
#line hidden
#nullable disable
                WriteLiteral(" | \r\n        ");
#nullable restore
#line 18 "C:\Users\Hi-tech\OneDrive\Рабочий стол\REST_API_DOTNET\Views\Home\Index.cshtml"
   Write(Html.ActionLink("Изменить", "Edit", "Home", new { id = c.Id }, 
            new { @class = "viewDialog", data_dialog_title = "Редактирование модели" }));

#line default
#line hidden
#nullable disable
                WriteLiteral(" |\r\n        ");
#nullable restore
#line 20 "C:\Users\Hi-tech\OneDrive\Рабочий стол\REST_API_DOTNET\Views\Home\Index.cshtml"
   Write(Html.ActionLink("Удалить", "Delete", "Home", new { id = c.Id }, 
            new { @class = "viewDialog", data_dialog_title = "Удаление модели" }));

#line default
#line hidden
#nullable disable
                WriteLiteral(" </td></tr>\r\n");
#nullable restore
#line 22 "C:\Users\Hi-tech\OneDrive\Рабочий стол\REST_API_DOTNET\Views\Home\Index.cshtml"
    }

#line default
#line hidden
#nullable disable
                WriteLiteral("    </table>\r\n    <p> ");
#nullable restore
#line 24 "C:\Users\Hi-tech\OneDrive\Рабочий стол\REST_API_DOTNET\Views\Home\Index.cshtml"
   Write(Html.ActionLink("Добавить", "Create", "Home", new { }, new { @class = "viewDialog", data_dialog_title = "Создание модели" }));

#line default
#line hidden
#nullable disable
                WriteLiteral("</p> \r\n \r\n    <script");
                BeginWriteAttribute("src", " src=\'", 1034, "\'", 1086, 1);
#nullable restore
#line 26 "C:\Users\Hi-tech\OneDrive\Рабочий стол\REST_API_DOTNET\Views\Home\Index.cshtml"
WriteAttributeValue("", 1040, Url.Content("~/Scripts/jquery-1.12.4.min.js"), 1040, 46, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" type=\"text/javascript\"></script>\r\n    <script");
                BeginWriteAttribute("src", " src=\'", 1133, "\'", 1188, 1);
#nullable restore
#line 27 "C:\Users\Hi-tech\OneDrive\Рабочий стол\REST_API_DOTNET\Views\Home\Index.cshtml"
WriteAttributeValue("", 1139, Url.Content("~/Scripts/jquery-ui-1.12.1.min.js"), 1139, 49, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(@" type=""text/javascript""></script>
    <script>
    $(document).ready(function () {
 
        $.ajaxSetup({ cache: false });
 
        $("".viewDialog"").on(""click"", function (e) {
            e.preventDefault();
 
            $(""<div></div>"")
                .addClass(""dialog"")
                .appendTo(""body"")
                .dialog({
                    title: $(this).attr(""data-dialog-title""),
                     close: function () { $(this).remove() },
                    modal: true
                })
                .load(this.href);
        });
    });
    </script>
");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<REST_API_DOTNET.Models.Computer>> Html { get; private set; }
    }
}
#pragma warning restore 1591