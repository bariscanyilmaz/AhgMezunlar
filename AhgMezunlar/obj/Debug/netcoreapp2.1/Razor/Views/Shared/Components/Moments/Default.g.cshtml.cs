#pragma checksum "D:\Projects\AhgMezunlar\AhgMezunlar\Views\Shared\Components\Moments\Default.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "56b895689dc20a43ef9cd190e9fe76a7221ad016"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_Components_Moments_Default), @"mvc.1.0.view", @"/Views/Shared/Components/Moments/Default.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Shared/Components/Moments/Default.cshtml", typeof(AspNetCore.Views_Shared_Components_Moments_Default))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"56b895689dc20a43ef9cd190e9fe76a7221ad016", @"/Views/Shared/Components/Moments/Default.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d68a26112f05f5ab4cfddb99277f4008fb9ca04d", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared_Components_Moments_Default : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Moments>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(29, 214, true);
            WriteLiteral("<p class=\"momentsslider\">\r\n    <a class=\"left-arrow\">\r\n        <span></span>\r\n    </a>\r\n    <a class=\"right-arrow\">\r\n        <span></span>\r\n    </a>\r\n</p>\r\n<div class=\"row moments\" style=\"justify-content:center\">\r\n");
            EndContext();
#line 11 "D:\Projects\AhgMezunlar\AhgMezunlar\Views\Shared\Components\Moments\Default.cshtml"
     if (Model.Count() > 0)
    {
        foreach (var item in Model)
        {

#line default
#line hidden
            BeginContext(327, 107, true);
            WriteLiteral("            <div class=\"col-md-4\">\r\n                <article>\r\n                    <img class=\"btmspace-30\"");
            EndContext();
            BeginWriteAttribute("src", " src=\"", 434, "\"", 536, 1);
#line 17 "D:\Projects\AhgMezunlar\AhgMezunlar\Views\Shared\Components\Moments\Default.cshtml"
WriteAttributeValue("", 440, item.CoverPhotoPath==null ? "/img/Defaults/320x220.png" : "/img/Moments/"+item.CoverPhotoPath, 440, 96, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginWriteAttribute("alt", " alt=\"", 537, "\"", 563, 1);
#line 17 "D:\Projects\AhgMezunlar\AhgMezunlar\Views\Shared\Components\Moments\Default.cshtml"
WriteAttributeValue("", 543, item.CoverPhotoPath, 543, 20, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(564, 73, true);
            WriteLiteral(">\r\n                    <h4 class=\"nospace btmspace-10 font-x1 uppercase\">");
            EndContext();
            BeginContext(638, 10, false);
#line 18 "D:\Projects\AhgMezunlar\AhgMezunlar\Views\Shared\Components\Moments\Default.cshtml"
                                                                 Write(item.Title);

#line default
#line hidden
            EndContext();
            BeginContext(648, 163, true);
            WriteLiteral("</h4>\r\n                    <ul class=\"nospace btmspace-10 group font-xs\">\r\n                        <li class=\"fl_left custom-orange\">\r\n                            ");
            EndContext();
            BeginContext(812, 15, false);
#line 21 "D:\Projects\AhgMezunlar\AhgMezunlar\Views\Shared\Components\Moments\Default.cshtml"
                       Write(item.SenderName);

#line default
#line hidden
            EndContext();
            BeginContext(827, 111, true);
            WriteLiteral("\r\n                        </li>\r\n                    </ul>\r\n                    <hr>\r\n                    <p>\r\n");
            EndContext();
#line 26 "D:\Projects\AhgMezunlar\AhgMezunlar\Views\Shared\Components\Moments\Default.cshtml"
                         if (item.Content.Length > 50)
                        {
                            

#line default
#line hidden
            BeginContext(1050, 42, false);
#line 28 "D:\Projects\AhgMezunlar\AhgMezunlar\Views\Shared\Components\Moments\Default.cshtml"
                       Write(Html.Raw(item.Content).ToString().Take(50));

#line default
#line hidden
            EndContext();
#line 28 "D:\Projects\AhgMezunlar\AhgMezunlar\Views\Shared\Components\Moments\Default.cshtml"
                                                                       
                        }
                        else
                        {
                            

#line default
#line hidden
            BeginContext(1207, 22, false);
#line 32 "D:\Projects\AhgMezunlar\AhgMezunlar\Views\Shared\Components\Moments\Default.cshtml"
                       Write(Html.Raw(item.Content));

#line default
#line hidden
            EndContext();
#line 32 "D:\Projects\AhgMezunlar\AhgMezunlar\Views\Shared\Components\Moments\Default.cshtml"
                                                   
                        }

#line default
#line hidden
            BeginContext(1258, 110, true);
            WriteLiteral("                        &hellip;\r\n                    </p>\r\n\r\n                </article>\r\n            </div>\r\n");
            EndContext();
#line 39 "D:\Projects\AhgMezunlar\AhgMezunlar\Views\Shared\Components\Moments\Default.cshtml"
        }





        

#line default
#line hidden
#line 106 "D:\Projects\AhgMezunlar\AhgMezunlar\Views\Shared\Components\Moments\Default.cshtml"
               

    }
    else
    {

#line default
#line hidden
            BeginContext(4155, 58, true);
            WriteLiteral("        <div class=\"alert alert-danger\">İçerik Yok</div>\r\n");
            EndContext();
#line 112 "D:\Projects\AhgMezunlar\AhgMezunlar\Views\Shared\Components\Moments\Default.cshtml"
    }

#line default
#line hidden
            BeginContext(4220, 6, true);
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<Moments>> Html { get; private set; }
    }
}
#pragma warning restore 1591
