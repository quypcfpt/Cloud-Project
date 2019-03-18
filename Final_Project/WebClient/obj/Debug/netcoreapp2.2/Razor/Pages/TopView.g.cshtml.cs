#pragma checksum "G:\PRC391\Project_Assignment\Final_Project\WebClient\Pages\TopView.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "0d797a6c0d49d60cb4058ecd61e9b12d46dadff6"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(WebClient.Pages.Pages_TopView), @"mvc.1.0.razor-page", @"/Pages/TopView.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.RazorPages.Infrastructure.RazorPageAttribute(@"/Pages/TopView.cshtml", typeof(WebClient.Pages.Pages_TopView), null)]
namespace WebClient.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#line 1 "G:\PRC391\Project_Assignment\Final_Project\WebClient\Pages\_ViewImports.cshtml"
using WebClient;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0d797a6c0d49d60cb4058ecd61e9b12d46dadff6", @"/Pages/TopView.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a1ce43a8420f343725c03187d8e04e65d3a1116b", @"/Pages/_ViewImports.cshtml")]
    public class Pages_TopView : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 2 "G:\PRC391\Project_Assignment\Final_Project\WebClient\Pages\TopView.cshtml"
  
    ViewData["Title"] = "TopView";
    Layout = "~/Pages/Shared/_Layout.cshtml";

#line default
#line hidden
            BeginContext(97, 1847, true);
            WriteLiteral(@"
<section class=""site-section py-sm"">
    <div class=""container"">
        <div class=""row"">
            <div class=""col-md-6"">
                <h2 class=""mb-4"">Truyện mới cập nhật</h2>
            </div>
        </div>
        <div class=""row blog-entries"">
            <div class=""col-md-12 col-lg-12 main-content"">
                <div class=""row"" id=""storyList"">
                </div>

                <div class=""row mt-5"">
                    <div class=""col-md-12 text-center"">
                        <nav aria-label=""Page navigation"" class=""text-center"">
                            <ul id=""pagination""></ul>
                        </nav>
                    </div>
                </div>
            </div>
            <!-- END main-content -->
            <!-- END sidebar -->
        </div>
    </div>
</section>

<script id=""hidden-template"" type=""text/x-custom-template"">
    <div class=""col-md-3"">
        <a href=""${link}"" class=""blog-entry"">
            <img src=""${image}"" wi");
            WriteLiteral(@"dth=""200"" height=""300"" alt=""Image placeholder"">
            <div class=""blog-content-body"">
                <div class=""post-meta"">
                    <span class=""author mr-2"">
                        ${authorName} &bullet;
                        <span class=""mr-2"">${category}</span>
                        <br />
                        <span class=""ml-2""><span class=""fa fa-comments""></span> ${totalchapter}</span>&bullet;
                        <span class=""ml-2""><span class=""fa fa-eye""></span> ${totalVisit}</span>&bullet;
                        <br />
                        <span class=""ml-2""><span class=""fa fa-calendar""></span> ${lastupdate}</span>
                    </span>
                </div>
                <h2>${name}</h2>
            </div>
        </a>
    </div>
</script>

");
            EndContext();
            DefineSection("scripts", async() => {
                BeginContext(1961, 2497, true);
                WriteLiteral(@"
    <script>
            $(document).ready(function () {
                LoadStory();
            });
            function LoadStory() {
                $.ajax({
                    url: `${configuration.BASE_API_URL}Story/getStoriesTopView`,
                    method: ""GET"",
                    success: function (result) {
                        Pagination(result.data);
                    },
                    error: function (result) {
                        alert(""Có lỗi xảy ra!"")
                    }
                });
            }
            function Pagination(sources) {
                var container = $('#pagination');
                var options = {
                    dataSource: sources,
                    pageSize: 8,
                    callback: function (response, pagination) {
                        window.console && console.log(response, pagination);

                        var dataHtml = '';
                        $.each(response, function (key, value) ");
                WriteLiteral(@"{
                            var story = $('#hidden-template').text();
                            story = story.replace(""${image}"", value.imageUrl);
                            story = story.replace(""${authorName}"", value.authorName);
                            story = story.replace(""${category}"", value.categoryName);
                            story = story.replace(""${totalchapter}"", value.totalChapters);
                            story = story.replace(""${name}"", value.name);
                            story = story.replace(""${link}"", ""/chapterList?seoName="" + value.seoName + ""&storyName="" + value.name);
                            story = story.replace(""${totalVisit}"", value.totalVisit);
                            story = story.replace(""${lastupdate}"", value.lastDateTimePostChapter);
                            dataHtml += story;
                        });
                        dataHtml += '';

                        $(""#storyList"").html(dataHtml);
                    }
         ");
                WriteLiteral(@"       };

                container.addHook('beforeInit', function () {
                    window.console && console.log('beforeInit...');
                });
                container.pagination(options);

                container.addHook('beforePageOnClick', function () {
                    window.console && console.log('beforePageOnClick...');
                    //return false
                });
            }
    </script>
");
                EndContext();
            }
            );
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Pages_TopView> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<Pages_TopView> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<Pages_TopView>)PageContext?.ViewData;
        public Pages_TopView Model => ViewData.Model;
    }
}
#pragma warning restore 1591