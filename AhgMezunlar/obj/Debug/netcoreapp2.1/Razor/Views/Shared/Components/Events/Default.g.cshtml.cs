#pragma checksum "D:\Projects\AhgMezunlar\AhgMezunlar\Views\Shared\Components\Events\Default.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "9a0b828a69a2ab00a6d8011b14d20f19fa73a304"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_Components_Events_Default), @"mvc.1.0.view", @"/Views/Shared/Components/Events/Default.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Shared/Components/Events/Default.cshtml", typeof(AspNetCore.Views_Shared_Components_Events_Default))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9a0b828a69a2ab00a6d8011b14d20f19fa73a304", @"/Views/Shared/Components/Events/Default.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d68a26112f05f5ab4cfddb99277f4008fb9ca04d", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared_Components_Events_Default : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Events>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(28, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "D:\Projects\AhgMezunlar\AhgMezunlar\Views\Shared\Components\Events\Default.cshtml"
 if (Model.Count() > 0)
{
    foreach (var item in Model)
    {

#line default
#line hidden
            BeginContext(98, 35, true);
            WriteLiteral("        <li data-image=\"img/Events/");
            EndContext();
            BeginContext(135, 14, false);
#line 7 "D:\Projects\AhgMezunlar\AhgMezunlar\Views\Shared\Components\Events\Default.cshtml"
                               Write(item.PhotoPath);

#line default
#line hidden
            EndContext();
            BeginContext(150, 1, true);
            WriteLiteral("\"");
            EndContext();
            BeginWriteAttribute("class", " class=\"", 151, "\"", 210, 2);
            WriteAttributeValue("", 159, "one_third", 159, 9, true);
#line 7 "D:\Projects\AhgMezunlar\AhgMezunlar\Views\Shared\Components\Events\Default.cshtml"
WriteAttributeValue(" ", 168, item.PopupState == true ? "popup" : "", 169, 41, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(211, 69, true);
            WriteLiteral(">\r\n            <article>\r\n                <a>\r\n                    <i");
            EndContext();
            BeginWriteAttribute("class", " class=\"", 280, "\"", 305, 2);
            WriteAttributeValue("", 288, "fa", 288, 2, true);
#line 10 "D:\Projects\AhgMezunlar\AhgMezunlar\Views\Shared\Components\Events\Default.cshtml"
WriteAttributeValue(" ", 290, item.IconName, 291, 14, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(306, 65, true);
            WriteLiteral("></i>\r\n                </a>\r\n                <h6 class=\"heading\">");
            EndContext();
            BeginContext(372, 10, false);
#line 12 "D:\Projects\AhgMezunlar\AhgMezunlar\Views\Shared\Components\Events\Default.cshtml"
                               Write(item.Title);

#line default
#line hidden
            EndContext();
            BeginContext(382, 26, true);
            WriteLiteral("</h6>\r\n                <p>");
            EndContext();
            BeginContext(409, 12, false);
#line 13 "D:\Projects\AhgMezunlar\AhgMezunlar\Views\Shared\Components\Events\Default.cshtml"
              Write(item.Content);

#line default
#line hidden
            EndContext();
            BeginContext(421, 156, true);
            WriteLiteral("</p>\r\n                <footer>\r\n                    <a class=\"btn\">Görüntüle &raquo;</a>\r\n                </footer>\r\n            </article>\r\n        </li>\r\n");
            EndContext();
#line 19 "D:\Projects\AhgMezunlar\AhgMezunlar\Views\Shared\Components\Events\Default.cshtml"
    }
}
else
{

#line default
#line hidden
            BeginContext(596, 70, true);
            WriteLiteral("    <div class=\"alert alert-danger\">\r\n        İçerik Yok\r\n    </div>\r\n");
            EndContext();
#line 26 "D:\Projects\AhgMezunlar\AhgMezunlar\Views\Shared\Components\Events\Default.cshtml"
}

#line default
#line hidden
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<Events>> Html { get; private set; }
    }
}
#pragma warning restore 1591
