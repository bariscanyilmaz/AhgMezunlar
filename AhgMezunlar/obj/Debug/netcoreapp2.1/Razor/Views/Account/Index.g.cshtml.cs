#pragma checksum "D:\Projects\AhgMezunlar\AhgMezunlar\Views\Account\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "015b74590eafbf61db2d00149d37dbac7cfa7be0"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Account_Index), @"mvc.1.0.view", @"/Views/Account/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Account/Index.cshtml", typeof(AspNetCore.Views_Account_Index))]
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
#line 1 "D:\Projects\AhgMezunlar\AhgMezunlar\Views\_ViewImports.cshtml"
using AhgMezunlar.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"015b74590eafbf61db2d00149d37dbac7cfa7be0", @"/Views/Account/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d68a26112f05f5ab4cfddb99277f4008fb9ca04d", @"/Views/_ViewImports.cshtml")]
    public class Views_Account_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "1", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "2", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(0, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 2 "D:\Projects\AhgMezunlar\AhgMezunlar\Views\Account\Index.cshtml"
  
    ViewData["Title"] = "Index";

#line default
#line hidden
            BeginContext(43, 1437, true);
            WriteLiteral(@"

<div class=""container d-flex justify-content-end p-0"">
    <a data-toggle=""tooltip"" title=""Admin Paneline Git"" href=""/Admin"">
        <i class=""fa fa-2x fa-cogs""></i>
    </a>
</div>
<div class=""container"">

    <button class=""accordion"">Kullanıcı Listesi</button>
    <div class=""panel"">
        <table class=""userListTable table table-hover table-sm"">
            <thead>
                <tr>
                    <th>Email</th>
                    <th class=""w-25"">Rol</th>
                    <th class=""w-10""><i data-toggle=""tooltip"" title=""Düzenlemek için tıklayabilirsiniz"" class=""fa fa-question-circle-o fa-2x""></i></th>
                </tr>
            </thead>
            <tbody>
                <tr>
                    <td data-user-id=""guidveri"" class=""user-name"">baris@bariscanyilmaz</td>
                    <td class=""user-role"" data-role=""2"">Kullanıcı</td>
                    <td>
                        <div class=""btn btn-danger btn-sm"">
                            <i class=");
            WriteLiteral(@"""fa fa-trash""></i>
                        </div>
                        <div class=""btn btn-primary btn-sm"">
                            <i class=""fa fa-edit""></i>
                        </div>


                    </td>
                </tr>
            </tbody>
        </table>
    </div>
    <button class=""accordion"">Kullanıcı Oluştur veya Düzenle</button>
    <div class=""panel "">
        ");
            EndContext();
            BeginContext(1480, 948, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b3ebd57d9ee24991addc1666bb17bc77", async() => {
                BeginContext(1486, 615, true);
                WriteLiteral(@"
            <input type=""hidden"" id=""user-id"" name=""user-id"" value="""" />
            <div class=""form-group"">
                <label for=""user-email"">Email</label>
                <input  class=""form-control"" id=""user-email"" name=""user-email"" type=""email"">
            </div>
            <div class=""form-group"">
                <label for=""password"">Şifre</label>
                <input type=""password"" class=""form-control"" name=""password"" id=""password"">
            </div>
            <div class=""form-group"">
                <select name=""role"" class=""custom-select"" id=""role"" >
                    ");
                EndContext();
                BeginContext(2101, 67, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b38b47824aaf49cfa2da019abe35ee35", async() => {
                    BeginContext(2127, 32, true);
                    WriteLiteral("Kullanıcı Yetki Derecesi Seçiniz");
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                BeginWriteTagHelperAttribute();
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __tagHelperExecutionContext.AddHtmlAttribute("selected", Html.Raw(__tagHelperStringValueBuffer), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.Minimized);
                BeginWriteTagHelperAttribute();
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __tagHelperExecutionContext.AddHtmlAttribute("disabled", Html.Raw(__tagHelperStringValueBuffer), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.Minimized);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(2168, 22, true);
                WriteLiteral("\r\n                    ");
                EndContext();
                BeginContext(2190, 35, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "8295597f79f541cfb9cb5eabf89c550f", async() => {
                    BeginContext(2208, 8, true);
                    WriteLiteral("Yönetici");
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(2225, 22, true);
                WriteLiteral("\r\n                    ");
                EndContext();
                BeginContext(2247, 43, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "a5bce980f23e40b4a49bc40eedcd1a80", async() => {
                    BeginContext(2265, 16, true);
                    WriteLiteral("Normal Kullanıcı");
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_1.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(2290, 131, true);
                WriteLiteral("\r\n                </select>\r\n            </div>\r\n            <input type=\"submit\" class=\"btn btn-primary\" value=\"Kaydet\">\r\n        ");
                EndContext();
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
            EndContext();
            BeginContext(2428, 41, true);
            WriteLiteral("\r\n    </div>\r\n</div>\r\n\r\n<!--Sections-->\r\n");
            EndContext();
            DefineSection("scripts", async() => {
                BeginContext(2486, 1863, true);
                WriteLiteral(@" 
    <script>
        var accordion = document.getElementsByClassName(""accordion"");
        var i;
        for (i = 0; i < accordion.length; i++) {
            accordion[i].addEventListener('click', function () {
                this.classList.toggle('active');

                var panel = this.nextElementSibling;
                if (panel.style.maxHeight) {
                    panel.style.maxHeight = null;
                    panel.classList.toggle('m-3');
                } else {
                    panel.style.maxHeight = panel.scrollHeight + 'px';
                    panel.classList.toggle('m-3');
                }

            });

        }

        var navLinks = document.getElementsByClassName('nav-link');
        var tabContentList = document.getElementsByClassName('tab-pane');

        $('.nav-item a').click(function () {
            var targetId = $(this).data('pill').replace('#', '');
            openTab(targetId);
        })

        function openTab(tabpaneid) {
  ");
                WriteLiteral(@"          for (let i = 0; i < tabContentList.length; i++) {
                tabContentList[i].style.display = 'none';
            }

            element = document.getElementById(tabpaneid);
            element.style.display = 'flex';
        }

        $('.userListTable tr').click(function (e) {
            let id = $(this).find('.user-name').data('user-id');
            let userName = $(this).find('.user-name').text();
            let role = $(this).find('.user-role').data('role');

            console.log(id);
            console.log(userName);
            console.log(role);

            $('#user-email').val(userName);
            $('#role').val(role);
            $('#user-id').val(id);
            
            e.stopImmediatePropagation();
            e.preventDefault();
        })

    </script>1
");
                EndContext();
            }
            );
            BeginContext(4352, 2, true);
            WriteLiteral("\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
