#pragma checksum "D:\Sorimachi\DiChoSaiGon-master\WebShop\Views\Blog\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "4854284d40ab7e5be217eb04eb78fa288714e41b"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Blog_Details), @"mvc.1.0.view", @"/Views/Blog/Details.cshtml")]
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
#line 1 "D:\Sorimachi\DiChoSaiGon-master\WebShop\Views\_ViewImports.cshtml"
using WebShop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\Sorimachi\DiChoSaiGon-master\WebShop\Views\_ViewImports.cshtml"
using WebShop.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4854284d40ab7e5be217eb04eb78fa288714e41b", @"/Views/Blog/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4bfba31bbcaa032efb64f666603006a07f085fa2", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Blog_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<WebShop.Models.TinDang>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("img-full"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "D:\Sorimachi\DiChoSaiGon-master\WebShop\Views\Blog\Details.cshtml"
  
    ViewData["Title"] = Model.Title;
    Layout = "~/Views/Shared/_Layout.cshtml";
    string url = $"/tin-tuc/{Model.Alias}-{Model.PostId}.html";
    List<TinDang> Baivietlienquan = ViewBag.Baivietlienquan;

#line default
#line hidden
#nullable disable
            WriteLiteral(@"<main class=""main-content"">
    <div class=""breadcrumb-area breadcrumb-height"" data-bg-image=""assets/images/breadcrumb/bg/1-1-1920x373.jpg"">
        <div class=""container h-100"">
            <div class=""row h-100"">
                <div class=""col-lg-12"">
                    <div class=""breadcrumb-item"">
                        <h1 class=""breadcrumb-heading"">");
#nullable restore
#line 14 "D:\Sorimachi\DiChoSaiGon-master\WebShop\Views\Blog\Details.cshtml"
                                                  Write(Model.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h1>\n                        <ul>\n                            <li> \n                                <a href=\"/\">Trang chủ <i class=\"pe-7s-angle-right\"></i></a>\n                            </li>\n                            <li>");
#nullable restore
#line 19 "D:\Sorimachi\DiChoSaiGon-master\WebShop\Views\Blog\Details.cshtml"
                           Write(Model.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</li>
                        </ul>
                    </div>
                </div>
            </div>
        </div>
    </div>
    <div class=""blog-area section-space-y-axis-100"">
        <div class=""container"">
            <div class=""row"">
                <div class=""col-lg-12"">
                    <div class=""blog-detail-item"">
                        <div class=""blog-img"">
                            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "4854284d40ab7e5be217eb04eb78fa288714e41b5324", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 1293, "~/images/news/", 1293, 14, true);
#nullable restore
#line 32 "D:\Sorimachi\DiChoSaiGon-master\WebShop\Views\Blog\Details.cshtml"
AddHtmlAttributeValue("", 1307, Model.Thumb, 1307, 12, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "alt", 1, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
#nullable restore
#line 32 "D:\Sorimachi\DiChoSaiGon-master\WebShop\Views\Blog\Details.cshtml"
AddHtmlAttributeValue("", 1326, Model.Title, 1326, 12, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
                        </div>
                        <div class=""blog-content text-start pb-0"">
                            <div class=""blog-meta text-dim-gray pb-3"">
                                <ul>
                                    <li class=""date""><i class=""fa fa-calendar-o me-2""></i>May 21, 2021</li>
                                    <li>
                                        <span class=""comments me-3"">
                                            <a href=""javascript:void(0)"">2 Comments</a>
                                        </span>
                                        <span class=""link-share"">
                                            <a href=""javascript:void(0)"">Share</a>
                                        </span>
                                    </li>
                                </ul>
                            </div>
                            <h5 class=""title mb-4"">
                                <a");
            BeginWriteAttribute("href", " href=\"", 2299, "\"", 2310, 1);
#nullable restore
#line 49 "D:\Sorimachi\DiChoSaiGon-master\WebShop\Views\Blog\Details.cshtml"
WriteAttributeValue("", 2306, url, 2306, 4, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 49 "D:\Sorimachi\DiChoSaiGon-master\WebShop\Views\Blog\Details.cshtml"
                                          Write(Model.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a>\n                            </h5>\n                            <p class=\"short-desc mb-4 mb-7\">");
#nullable restore
#line 51 "D:\Sorimachi\DiChoSaiGon-master\WebShop\Views\Blog\Details.cshtml"
                                                       Write(Model.Scontents);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\n                            ");
#nullable restore
#line 52 "D:\Sorimachi\DiChoSaiGon-master\WebShop\Views\Blog\Details.cshtml"
                       Write(Html.Raw(Model.Contents));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                            <div class=""tag-wtih-social"">
                                <div class=""tag"">
                                    <span class=""title text-primary"">Tags:</span>
                                    <ul>
                                        <li>
                                            <a href=""javascript:void(0)"">Furniture,</a>
                                        </li>
                                        <li>
                                            <a href=""javascript:void(0)"">Electronic,</a>
                                        </li>
                                        <li>
                                            <a href=""javascript:void(0)"">Fashion</a>
                                        </li>
                                    </ul>
                                </div>
                                <div class=""social-link"">
                                    <ul>
                                        <li>
                                ");
            WriteLiteral(@"            <a href=""javascript:void(0)"">
                                                <i class=""fa fa-facebook""></i>
                                            </a>
                                        </li>
                                        <li>
                                            <a href=""javascript:void(0)"">
                                                <i class=""fa fa-pinterest-p""></i>
                                            </a>
                                        </li>
                                        <li>
                                            <a href=""javascript:void(0)"">
                                                <i class=""fa fa-dribbble""></i>
                                            </a>
                                        </li>
                                    </ul>
                                </div>
                            </div>
                            
                            <div class=""feedback-area section-space-top-55");
            WriteLiteral(@""">
                                <h4 class=""heading mb-1"">Bài viết liên quan</h4>
                                <hr />
                                <div class=""widgets-area mb-9"">
                                    <div class=""widgets-item"">
                                        <div class=""swiper-container widgets-list-slider style-2 swiper-container-multirow swiper-container-initialized swiper-container-horizontal swiper-container-pointer-events"">
                                            <div class=""swiper-wrapper"" id=""swiper-wrapper-62104b1dfbb1d3188"" aria-live=""polite"" style=""width: 288px; transform: translate3d(0px, 0px, 0px);"">
");
#nullable restore
#line 96 "D:\Sorimachi\DiChoSaiGon-master\WebShop\Views\Blog\Details.cshtml"
                                                 if (Baivietlienquan != null && Baivietlienquan.Count() > 0)
                                                            {
                                                                foreach (var item in Baivietlienquan)
                                                                {
                                                                    string _url = $"/tin-tuc/{item.Alias}-{item.PostId}.html";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                                                                    <div class=""swiper-slide"" role=""group"" aria-label=""3 / 3"" style=""margin-top: 25px; width: 263px; margin-right: 25px;"">
                                                            <div class=""product-list-item"">
                                                                <div class=""product-img img-zoom-effect"">
                                                                    <a");
            BeginWriteAttribute("href", " href=\"", 6121, "\"", 6133, 1);
#nullable restore
#line 104 "D:\Sorimachi\DiChoSaiGon-master\WebShop\Views\Blog\Details.cshtml"
WriteAttributeValue("", 6128, _url, 6128, 5, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\n                                                                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "4854284d40ab7e5be217eb04eb78fa288714e41b13852", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 6235, "~/images/news/", 6235, 14, true);
#nullable restore
#line 105 "D:\Sorimachi\DiChoSaiGon-master\WebShop\Views\Blog\Details.cshtml"
AddHtmlAttributeValue("", 6249, item.Thumb, 6249, 11, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "alt", 1, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
#nullable restore
#line 105 "D:\Sorimachi\DiChoSaiGon-master\WebShop\Views\Blog\Details.cshtml"
AddHtmlAttributeValue("", 6267, item.Title, 6267, 11, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
                                                                    </a>
                                                                </div>
                                                                <div class=""product-content"">
                                                                    <h5 class=""title mb-3"">
                                                                        <a");
            BeginWriteAttribute("href", " href=\"", 6685, "\"", 6697, 1);
#nullable restore
#line 110 "D:\Sorimachi\DiChoSaiGon-master\WebShop\Views\Blog\Details.cshtml"
WriteAttributeValue("", 6692, _url, 6692, 5, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 110 "D:\Sorimachi\DiChoSaiGon-master\WebShop\Views\Blog\Details.cshtml"
                                                                                   Write(item.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</a>
                                                                    </h5>
                                                                    <div class=""blog-meta text-manatee pb-1"">
                                                                        <ul>
                                                                            <li class=""date"">");
#nullable restore
#line 114 "D:\Sorimachi\DiChoSaiGon-master\WebShop\Views\Blog\Details.cshtml"
                                                                                        Write(item.CreatedDate);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</li>
                                                                        </ul>
                                                                    </div>
                                                                </div>
                                                            </div>
                                                        </div>
");
#nullable restore
#line 120 "D:\Sorimachi\DiChoSaiGon-master\WebShop\Views\Blog\Details.cshtml"

                                                    }
                                                }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                                            </div>
                                        </div>
                                    </div>
                                </div>
                            </div>
                        </div>
                    </div>
                </div>
            </div>
        </div>
    </div>
</main>");
        }
        #pragma warning restore 1998
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<WebShop.Models.TinDang> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
