#pragma checksum "G:\PRC391\Project_Assignment\Final_Project\WebClient\Pages\SingleChapter.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a8e3a8bf1f9aaed40dd6b0f6b295c628b47ff243"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(WebClient.Pages.Pages_SingleChapter), @"mvc.1.0.razor-page", @"/Pages/SingleChapter.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.RazorPages.Infrastructure.RazorPageAttribute(@"/Pages/SingleChapter.cshtml", typeof(WebClient.Pages.Pages_SingleChapter), null)]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a8e3a8bf1f9aaed40dd6b0f6b295c628b47ff243", @"/Pages/SingleChapter.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a1ce43a8420f343725c03187d8e04e65d3a1116b", @"/Pages/_ViewImports.cshtml")]
    public class Pages_SingleChapter : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 3 "G:\PRC391\Project_Assignment\Final_Project\WebClient\Pages\SingleChapter.cshtml"
  
    ViewData["Title"] = "singlechapter";
    Layout = "~/Pages/Shared/_Layout.cshtml";

#line default
#line hidden
            BeginContext(146, 1658, true);
            WriteLiteral(@"
<section class=""site-section py-lg"">
    <div class=""container"">

        <div class=""row blog-entries element-animate"">

            <div class=""col-md-12 col-lg-12 main-content"">
                <div id=""info"">

                </div>
                <a href="""" id=""linkstory"">
                    <h1 class=""mb-4"" id=""StoryName""></h1>
                </a>
                <a class=""category mb-5"" href=""#"" id=""categoryName""></a>
                <div class=""row mt-5"">
                    <div class=""col-md-12 text-center"">
                        <nav aria-label=""Page navigation"" class=""text-center"">
                            <ul class=""pagination"" id=""paginationhead""></ul>
                        </nav>
                    </div>
                </div>
                <h4 class=""mb-4"" id=""chapterName""></h4>
                <div class=""post-content-body"">

                </div>
                <div class=""row mt-5"">
                    <div class=""col-md-12 text-center"">
         ");
            WriteLiteral(@"               <nav aria-label=""Page navigation"" class=""text-center"">
                            <ul class=""pagination"" id=""pagination""></ul>
                        </nav>
                    </div>
                </div>
            </div>

           
        </div>
    </div>
</section>




<script id=""hidden-template"" type=""text/x-custom-template"">
    <div class=""post-meta"">
        <span class=""author mr-2"" id=""authorName""></span>&bullet;
        <span class=""mr-2"">${createDate} </span> &bullet;
        <span class=""ml-2""><span class=""fa fa-eye""></span> ${totalVisit}</span>
    </div>
</script>

");
            EndContext();
            DefineSection("scripts", async() => {
                BeginContext(1821, 300, true);
                WriteLiteral(@"
<script>
            $(document).ready(function () {
                LoadChapter();
                LoadStory();
    });
    var currentChapter = 0;
            function LoadChapter() {
                $.ajax({
                    url: `${configuration.BASE_API_URL}Chapter/getDetailClient/");
                EndContext();
                BeginContext(2122, 15, false);
#line 66 "G:\PRC391\Project_Assignment\Final_Project\WebClient\Pages\SingleChapter.cshtml"
                                                                          Write(Model.chapterId);

#line default
#line hidden
                EndContext();
                BeginContext(2137, 950, true);
                WriteLiteral(@"`,
                    method: ""GET"",
                    success: function (result) {
                        $('.post-content-body').append(result.data.detail);
                        $(""#chapterName"").text(""Chương "" + result.data.position + "": "" + result.data.name);
                            var story = $('#hidden-template').text();
                        story = story.replace(""${name}"", result.data.name);
                        story = story.replace(""${createDate}"", result.data.createTime);
                        story = story.replace(""${totalVisit}"", result.data.totalVisit);
                        $(""#info"").append(story);
                        currentChapter = result.data.position;
                        if (result.data.position > 1) {
                            $('#pagination').append('<li class=""page-item""><a class=""page-link"" href =""/singlechapter?chapterId=' + (result.data.position - 1) + '&storySeoName=");
                EndContext();
                BeginContext(3088, 18, false);
#line 78 "G:\PRC391\Project_Assignment\Final_Project\WebClient\Pages\SingleChapter.cshtml"
                                                                                                                                                                           Write(Model.StorySeoName);

#line default
#line hidden
                EndContext();
                BeginContext(3106, 200, true);
                WriteLiteral("\">&lt;</a></li>\');\r\n                            $(\'#paginationhead\').append(\'<li class=\"page-item\"><a class=\"page-link\" href =\"/singlechapter?chapterId=\' + (result.data.position - 1) + \'&storySeoName=");
                EndContext();
                BeginContext(3307, 18, false);
#line 79 "G:\PRC391\Project_Assignment\Final_Project\WebClient\Pages\SingleChapter.cshtml"
                                                                                                                                                                               Write(Model.StorySeoName);

#line default
#line hidden
                EndContext();
                BeginContext(3325, 361, true);
                WriteLiteral(@""">&lt;</a></li>');
                        }
                    },
                    error: function (result) {
                        alert(""Có lỗi xảy ra!"")
                    }
                });
        }
        function LoadStory() {
                $.ajax({
                    url: `${configuration.BASE_API_URL}Story/getDetailbySeoName/");
                EndContext();
                BeginContext(3687, 18, false);
#line 89 "G:\PRC391\Project_Assignment\Final_Project\WebClient\Pages\SingleChapter.cshtml"
                                                                           Write(Model.StorySeoName);

#line default
#line hidden
                EndContext();
                BeginContext(3705, 165, true);
                WriteLiteral("`,\r\n                    method: \"GET\",\r\n                    success: function (result) {\r\n                        $(\'#linkstory\').attr(\'href\', \'/chapterList?seoName=");
                EndContext();
                BeginContext(3871, 18, false);
#line 92 "G:\PRC391\Project_Assignment\Final_Project\WebClient\Pages\SingleChapter.cshtml"
                                                                      Write(Model.StorySeoName);

#line default
#line hidden
                EndContext();
                BeginContext(3889, 609, true);
                WriteLiteral(@"&storyName=' + result.data.name);
                        $('#categoryName').attr('href', '/category?seoName=' + result.data.categorySeoName);
                        $('#authorName').append(result.data.authorName);
                        $('#StoryName').append(result.data.name);
                        $('#categoryName').append(result.data.categoryName);
                        if (result.data.totalChapters > currentChapter) {
                            $('#pagination').append('<li class=""page-item""><a class=""page-link"" href =""/singlechapter?chapterId=' + (currentChapter + 1) + '&storySeoName=");
                EndContext();
                BeginContext(4499, 18, false);
#line 98 "G:\PRC391\Project_Assignment\Final_Project\WebClient\Pages\SingleChapter.cshtml"
                                                                                                                                                                     Write(Model.StorySeoName);

#line default
#line hidden
                EndContext();
                BeginContext(4517, 194, true);
                WriteLiteral("\">&gt;</a></li>\');\r\n                            $(\'#paginationhead\').append(\'<li class=\"page-item\"><a class=\"page-link\" href =\"/singlechapter?chapterId=\' + (currentChapter + 1) + \'&storySeoName=");
                EndContext();
                BeginContext(4712, 18, false);
#line 99 "G:\PRC391\Project_Assignment\Final_Project\WebClient\Pages\SingleChapter.cshtml"
                                                                                                                                                                         Write(Model.StorySeoName);

#line default
#line hidden
                EndContext();
                BeginContext(4730, 230, true);
                WriteLiteral("\">&gt;</a></li>\');\r\n                        }\r\n                    },\r\n                    error: function (result) {\r\n                        alert(\"Có lỗi xảy ra!\")\r\n                    }\r\n                });\r\n    }\r\n</script>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<WebClient.Pages.SingleChapterModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<WebClient.Pages.SingleChapterModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<WebClient.Pages.SingleChapterModel>)PageContext?.ViewData;
        public WebClient.Pages.SingleChapterModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
