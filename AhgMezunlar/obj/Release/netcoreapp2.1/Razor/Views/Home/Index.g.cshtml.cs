#pragma checksum "D:\Projects\AhgMezunlar\AhgMezunlar\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b885cd6727d4846816a7ac19bbe3959e44ce3d08"
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
#line 1 "D:\Projects\AhgMezunlar\AhgMezunlar\Views\_ViewImports.cshtml"
using AhgMezunlar.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b885cd6727d4846816a7ac19bbe3959e44ce3d08", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d68a26112f05f5ab4cfddb99277f4008fb9ca04d", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IList<SliderImage>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("d-block w-100"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/js/instafeed.min.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/js/instagram.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 2 "D:\Projects\AhgMezunlar\AhgMezunlar\Views\Home\Index.cshtml"
  
    ViewData["Title"] = "Ana Sayfa";

#line default
#line hidden
            BeginContext(72, 17, true);
            WriteLiteral("<!--carousel-->\r\n");
            EndContext();
#line 6 "D:\Projects\AhgMezunlar\AhgMezunlar\Views\Home\Index.cshtml"
 if (Model.Count() > 0)
{



#line default
#line hidden
            BeginContext(121, 134, true);
            WriteLiteral("    <div id=\"myCarousel\" class=\"carousel slide\" data-ride=\"carousel\" data-interval=\"2000\">\r\n        <ol class=\"carousel-indicators\">\r\n");
            EndContext();
#line 12 "D:\Projects\AhgMezunlar\AhgMezunlar\Views\Home\Index.cshtml"
             for (int i = 0; i < Model.Count(); i++)
            {
                if (i == 0)
                {

#line default
#line hidden
            BeginContext(372, 65, true);
            WriteLiteral("                    <li data-target=\"#myCarousel\" data-slide-to=\"");
            EndContext();
            BeginContext(438, 1, false);
#line 16 "D:\Projects\AhgMezunlar\AhgMezunlar\Views\Home\Index.cshtml"
                                                            Write(i);

#line default
#line hidden
            EndContext();
            BeginContext(439, 24, true);
            WriteLiteral("\" class=\"active\"></li>\r\n");
            EndContext();
#line 17 "D:\Projects\AhgMezunlar\AhgMezunlar\Views\Home\Index.cshtml"
                }
                else
                {

#line default
#line hidden
            BeginContext(523, 65, true);
            WriteLiteral("                    <li data-target=\"#myCarousel\" data-slide-to=\"");
            EndContext();
            BeginContext(589, 1, false);
#line 20 "D:\Projects\AhgMezunlar\AhgMezunlar\Views\Home\Index.cshtml"
                                                            Write(i);

#line default
#line hidden
            EndContext();
            BeginContext(590, 9, true);
            WriteLiteral("\"></li>\r\n");
            EndContext();
#line 21 "D:\Projects\AhgMezunlar\AhgMezunlar\Views\Home\Index.cshtml"

                }

            }

#line default
#line hidden
            BeginContext(637, 57, true);
            WriteLiteral("\r\n        </ol>\r\n        <div class=\"carousel-inner\">\r\n\r\n");
            EndContext();
#line 29 "D:\Projects\AhgMezunlar\AhgMezunlar\Views\Home\Index.cshtml"
             for (int i = 0; i < Model.Count; i++)
            {


#line default
#line hidden
            BeginContext(763, 20, true);
            WriteLiteral("                <div");
            EndContext();
            BeginWriteAttribute("class", " class=\"", 783, "\"", 827, 3);
            WriteAttributeValue("", 791, "carousel-item", 791, 13, true);
#line 32 "D:\Projects\AhgMezunlar\AhgMezunlar\Views\Home\Index.cshtml"
WriteAttributeValue(" ", 804, i == 0?"active":"", 805, 21, false);

#line default
#line hidden
            WriteAttributeValue(" ", 826, "", 827, 1, true);
            EndWriteAttribute();
            BeginContext(828, 23, true);
            WriteLiteral(">\r\n                    ");
            EndContext();
            BeginContext(851, 82, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "4fa55a28ba4f466892eee52493a928fd", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 883, "~/img/Slider/", 883, 13, true);
#line 33 "D:\Projects\AhgMezunlar\AhgMezunlar\Views\Home\Index.cshtml"
AddHtmlAttributeValue("", 896, Model[i].Path, 896, 14, false);

#line default
#line hidden
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "alt", 1, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
#line 33 "D:\Projects\AhgMezunlar\AhgMezunlar\Views\Home\Index.cshtml"
AddHtmlAttributeValue("", 917, Model[i].Path, 917, 14, false);

#line default
#line hidden
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(933, 26, true);
            WriteLiteral("\r\n                </div>\r\n");
            EndContext();
#line 35 "D:\Projects\AhgMezunlar\AhgMezunlar\Views\Home\Index.cshtml"

            }

#line default
#line hidden
            BeginContext(976, 466, true);
            WriteLiteral(@"        </div>
        <a class=""carousel-control-prev"" role=""button"" data-slide=""prev"">
            <span class=""carousel-control-prev-icon"" aria-hidden=""true""></span>
            <span class=""sr-only"">Previous</span>
        </a>
        <a class=""carousel-control-next"" role=""button"" data-slide=""next"">
            <span class=""carousel-control-next-icon"" aria-hidden=""true""></span>
            <span class=""sr-only"">Next</span>
        </a>
    </div>
");
            EndContext();
#line 47 "D:\Projects\AhgMezunlar\AhgMezunlar\Views\Home\Index.cshtml"

}
else
{

#line default
#line hidden
            BeginContext(1456, 70, true);
            WriteLiteral("    <div class=\"alert alert-danger\">\r\n        Görsel Yok\r\n    </div>\r\n");
            EndContext();
#line 54 "D:\Projects\AhgMezunlar\AhgMezunlar\Views\Home\Index.cshtml"
}

#line default
#line hidden
            BeginContext(1529, 2915, true);
            WriteLiteral(@"<!--Dernek Tanıtım Kısayolları-->
<div class=""wrapper row3"">
    <div id=""services"" class=""hoc clear"">
        <div class=""table"">
            <div class=""table-row"">
                <div class=""table-cell"">
                    <article>
                        <a href=""/Society#hak"">
                            <i class=""fa fa-info-circle""></i>
                        </a>
                        <h6 class=""heading"">Hakkımızda</h6>
                        <!-- <p>Massa finibus at integer dictum sem arcu eu venenatis purus porta eu aliquam&hellip;</p> -->
                        <footer>
                            <a href=""/Society#hak"">Git &raquo;</a>
                        </footer>
                    </article>
                </div>
                <div class=""table-cell"">
                    <article>
                        <a href=""/Society#yk"">
                            <i class=""fa fa-users""></i>
                        </a>
                        <h6 class=""heading"">Yönet");
            WriteLiteral(@"im Kurulu</h6>
                        <!-- <p>In venenatis ipsum ac tincidunt dolor duis accumsan massa velit eget luctus&hellip;</p> -->
                        <footer>
                            <a href=""/Society#yk"">Git &raquo;</a>
                        </footer>
                    </article>
                </div>
               
                <div class=""table-cell"">
                    <article>
                        <a href=""/Society#tuzuk"">
                            <i class=""fa fa-align-left""></i>
                        </a>
                        <h6 class=""heading"">Tüzük</h6>
                        <!-- <p>Lorem facilisis vel aliquam semper vestibulum iaculis etiam vel convallis porta&hellip;</p> -->
                        <footer>
                            <a href=""/Society#tuzuk"">Git &raquo;</a>
                        </footer>
                    </article>
                </div>
            </div>
        </div>
    </div>
</div>
<!-- Instafeed-->
<di");
            WriteLiteral(@"v class=""home container "">
    <p class=""instaslider"">
        <a class=""left-arrow"">
            <span>&lt;</span>
        </a>
        <a class=""right-arrow"">
            <span>&gt;</span>
        </a>
    </p>
    <div id=""instafeed"" class=""d-flex"" style=""overflow-x: scroll"">
    </div>
</div>
<!--Duyurular-->
<div class=""wrapper row3"">
    <main class=""hoc container clear"">

        <div class=""d-flex justify-content-center"">
            <div class=""center btmspace-50  anilarimiz"">
                <h3 class=""font-x2 nospace"">DUYURULARIMIZ</h3>
                <p class=""nospace"">
                    Düzenlemiş olduğumuz tüm duyurular için
                    <a href=""/Events"">tıkla</a>
                </p>
            </div>
        </div>

        <!-- main body -->
        <ul class=""events nospace group cta"">
            ");
            EndContext();
            BeginContext(4445, 37, false);
#line 130 "D:\Projects\AhgMezunlar\AhgMezunlar\Views\Home\Index.cshtml"
       Write(await Component.InvokeAsync("Events"));

#line default
#line hidden
            EndContext();
            BeginContext(4482, 620, true);
            WriteLiteral(@"
        </ul>
        <!-- / main body -->
        <div class=""clear""></div>
    </main>
</div>
<!-- Anılarımız-->
<div class=""wrapper row3"">
    <section class=""hoc container clear"">
        <div class=""d-flex justify-content-center"">
            <div class=""center btmspace-50  anilarimiz"">
                <h3 class=""font-x2 nospace"">Anılarımız</h3>
                <p class=""nospace"">
                    Okul hakkında anılarımıza sen de kendi anını katmak istyorsan
                    <a href=""anilarimiz.html#moment"">tıkla</a>
                </p>
            </div>
        </div>


        ");
            EndContext();
            BeginContext(5103, 38, false);
#line 150 "D:\Projects\AhgMezunlar\AhgMezunlar\Views\Home\Index.cshtml"
   Write(await Component.InvokeAsync("Moments"));

#line default
#line hidden
            EndContext();
            BeginContext(5141, 48, true);
            WriteLiteral("\r\n\r\n    </section>\r\n</div>\r\n\r\n<!-- Sections-->\r\n");
            EndContext();
            DefineSection("scripts", async() => {
                BeginContext(5206, 2314, true);
                WriteLiteral(@"
    <script>


        $('#instafeed').on('click', 'img', function () {
            var link = $(this).data('link');
            window.open(link);
        });

        //let global_image = ""/img/Defaults/320x220.png"";
        //anılara tıklandığında yapılacaklar
        $('.moments .col-md-4').click(function () {
            var content = $(this).find('p').text();
            var title = $(this).find('h4').text();
            var image = $(this).find('img').attr('src');

            $('.modal img').attr('src', image);
            $('.modal .modal-body').text(content);
            $('.modal .modal-title').text(title);
            $('.modal').modal();
        });

        //duyurulara click olduğunda yapılacakalr
        $('.one_third').on('click', function () {
            var content = $(this).find('p').text();
            var title = $(this).find('h6.heading').text();
            var image = $(this).data('image');

            $('.modal img').attr('src', image);
            $('");
                WriteLiteral(@".modal .modal-body').text(content);
            $('.modal .modal-title').text(title);

            $('.modal').modal();
        });


        //document ready popup
        $(document).ready(function () {

            //



            $('ul.events').children().each(function () {
                if ($(this).hasClass('popup')) {

                    let popup = $('.one_third.popup');

                    var content = popup.find('p').text();
                    var title = popup.find('h6.heading').text();
                    var image = popup.data('image');

                    $('.modal img').attr('src', image);
                    $('.modal .modal-body').text(content);
                    $('.modal .modal-title').text(title);
                    $('.modal.fade').modal();

                }

            });
            //
            $(""#myCarousel"").carousel();

            $("".carousel-control-prev"").click(function (e) {
                $(""#myCarousel"").carousel(""prev"");
");
                WriteLiteral(@"                e.preventDefault();
            });

            $("".carousel-control-next"").click(function (e) {
                $(""#myCarousel"").carousel(""next"");

                e.preventDefault();
            });

        });



    </script>
    ");
                EndContext();
                BeginContext(7520, 45, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "2f341ff3a50045d183296dab0dc6b519", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(7565, 6, true);
                WriteLiteral("\r\n    ");
                EndContext();
                BeginContext(7571, 41, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "721c5f0ced244e51b32f84f391c33e0a", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(7612, 2, true);
                WriteLiteral("\r\n");
                EndContext();
            }
            );
            BeginContext(7617, 2, true);
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IList<SliderImage>> Html { get; private set; }
    }
}
#pragma warning restore 1591