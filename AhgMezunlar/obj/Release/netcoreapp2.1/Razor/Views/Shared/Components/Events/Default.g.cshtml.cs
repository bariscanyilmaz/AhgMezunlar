#pragma checksum "D:\Projects\AhgMezunlar\AhgMezunlar\Views\Shared\Components\Events\Default.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ffecb37dbed07e917f051188a7a3ef6546b5056b"
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ffecb37dbed07e917f051188a7a3ef6546b5056b", @"/Views/Shared/Components/Events/Default.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d68a26112f05f5ab4cfddb99277f4008fb9ca04d", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared_Components_Events_Default : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Events>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(21, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "D:\Projects\AhgMezunlar\AhgMezunlar\Views\Shared\Components\Events\Default.cshtml"
 if (Model.Count() > 0)
{

    for (int i = 0; i < Model.Count; i++)
    {

#line default
#line hidden
            BeginContext(103, 23, true);
            WriteLiteral("        <li data-image=");
            EndContext();
#line 8 "D:\Projects\AhgMezunlar\AhgMezunlar\Views\Shared\Components\Events\Default.cshtml"
                        if (Model[i].PhotoPath != null) { 

#line default
#line hidden
            BeginContext(163, 45, false);
#line 8 "D:\Projects\AhgMezunlar\AhgMezunlar\Views\Shared\Components\Events\Default.cshtml"
                                                      Write("img/Events/" + Model[i].PhotoPath.ToString());

#line default
#line hidden
            EndContext();
#line 8 "D:\Projects\AhgMezunlar\AhgMezunlar\Views\Shared\Components\Events\Default.cshtml"
                                                                                                          } else { 

#line default
#line hidden
            BeginContext(220, 27, false);
#line 8 "D:\Projects\AhgMezunlar\AhgMezunlar\Views\Shared\Components\Events\Default.cshtml"
                                                                                                               Write("/img/Defaults/320x220.png");

#line default
#line hidden
            EndContext();
#line 8 "D:\Projects\AhgMezunlar\AhgMezunlar\Views\Shared\Components\Events\Default.cshtml"
                                                                                                                                                  }

#line default
#line hidden
            BeginWriteAttribute("class", " class=\"", 250, "\"", 338, 3);
            WriteAttributeValue("", 258, "one_third", 258, 9, true);
#line 8 "D:\Projects\AhgMezunlar\AhgMezunlar\Views\Shared\Components\Events\Default.cshtml"
WriteAttributeValue(" ", 267, i == 0 ? "first" : "", 268, 24, false);

#line default
#line hidden
#line 8 "D:\Projects\AhgMezunlar\AhgMezunlar\Views\Shared\Components\Events\Default.cshtml"
WriteAttributeValue(" ", 292, Model[i].PopupState == true ? "popup" : "", 293, 45, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(339, 69, true);
            WriteLiteral(">\r\n            <article>\r\n                <a>\r\n                    <i");
            EndContext();
            BeginWriteAttribute("class", " class=\"", 408, "\"", 437, 2);
            WriteAttributeValue("", 416, "fa", 416, 2, true);
#line 11 "D:\Projects\AhgMezunlar\AhgMezunlar\Views\Shared\Components\Events\Default.cshtml"
WriteAttributeValue(" ", 418, Model[i].IconName, 419, 18, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(438, 65, true);
            WriteLiteral("></i>\r\n                </a>\r\n                <h6 class=\"heading\">");
            EndContext();
            BeginContext(504, 14, false);
#line 13 "D:\Projects\AhgMezunlar\AhgMezunlar\Views\Shared\Components\Events\Default.cshtml"
                               Write(Model[i].Title);

#line default
#line hidden
            EndContext();
            BeginContext(518, 26, true);
            WriteLiteral("</h6>\r\n                <p>");
            EndContext();
            BeginContext(545, 26, false);
#line 14 "D:\Projects\AhgMezunlar\AhgMezunlar\Views\Shared\Components\Events\Default.cshtml"
              Write(Html.Raw(Model[i].Content));

#line default
#line hidden
            EndContext();
            BeginContext(571, 157, true);
            WriteLiteral("</p>\r\n                <footer>\r\n                    <a class=\"btn\">Görüntüle &raquo;</a>\r\n                </footer>\r\n            </article>\r\n        </li> \r\n");
            EndContext();
#line 20 "D:\Projects\AhgMezunlar\AhgMezunlar\Views\Shared\Components\Events\Default.cshtml"
    }

}
else
{

#line default
#line hidden
            BeginContext(749, 70, true);
            WriteLiteral("    <div class=\"alert alert-danger\">\r\n        İçerik Yok\r\n    </div>\r\n");
            EndContext();
#line 28 "D:\Projects\AhgMezunlar\AhgMezunlar\Views\Shared\Components\Events\Default.cshtml"
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Events>> Html { get; private set; }
    }
}
#pragma warning restore 1591