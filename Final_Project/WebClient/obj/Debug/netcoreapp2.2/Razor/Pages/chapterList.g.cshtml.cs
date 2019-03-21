#pragma checksum "G:\PRC391\Project_Assignment\Final_Project\WebClient\Pages\chapterList.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "16b507411d8b1ab63c63c5d2be2a631893600008"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(WebClient.Pages.Pages_chapterList), @"mvc.1.0.razor-page", @"/Pages/chapterList.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.RazorPages.Infrastructure.RazorPageAttribute(@"/Pages/chapterList.cshtml", typeof(WebClient.Pages.Pages_chapterList), null)]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"16b507411d8b1ab63c63c5d2be2a631893600008", @"/Pages/chapterList.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a1ce43a8420f343725c03187d8e04e65d3a1116b", @"/Pages/_ViewImports.cshtml")]
    public class Pages_chapterList : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 3 "G:\PRC391\Project_Assignment\Final_Project\WebClient\Pages\chapterList.cshtml"
  
    ViewData["Title"] = "chapterList";
    Layout = "~/Pages/Shared/_Layout.cshtml";

#line default
#line hidden
            BeginContext(142, 231, true);
            WriteLiteral("<section class=\"site-section pt-5\">\r\n    <div class=\"container\">\r\n        <div class=\"row mb-4\">\r\n            <div class=\"col-md-3\"></div>\r\n            <div class=\"col-md-6 title-chapter\">\r\n                <h2 class=\"mb-4\">Truyện: ");
            EndContext();
            BeginContext(374, 15, false);
#line 12 "G:\PRC391\Project_Assignment\Final_Project\WebClient\Pages\chapterList.cshtml"
                                    Write(Model.StoryName);

#line default
#line hidden
            EndContext();
            BeginContext(389, 2298, true);
            WriteLiteral(@"</h2>
            </div>
            <div class=""col-md-3""></div>
        </div>
        <div class=""row mb-4"">
            <div class=""col-md-4"">
                <img src=""images/person_2.jpg"" alt=""Image Placeholder"" class=""img-fluid img-list-chapter"">
            </div>
            <div class=""col-md-8"" id=""description"">
                <ul>
                    <li>
                        Tác Giả : <h4 id=""authorName""></h4>
                    </li>
                    <li>
                        Loại Truyện : <h5 id=""CategoryName""></h5>
                    </li>
                    <li>
                        Tổng số Chap : <h5 id=""TotalChapter""></h5>
                    </li>
                    <li>
                        Trạng Thái : <h5 id=""status""></h5>
                    </li>
                    <li>Chap mới nhất được cập nhật : <h5 id=""lastTimePost""></h5></li>
                </ul>

            </div>
        </div>
        <div class=""row mb-4"">
            <h3>Giớ");
            WriteLiteral(@"i Thiệu</h3>
            <div id=""story_description"">

            </div>
        </div>
            <div class=""row blog-entries"">
                <div class=""col-md-12 col-lg-2 main-content""></div>
                <div class=""col-md-12 col-lg-8 main-content"">
                    <div class=""row mb-5 mt-5"">

                        <div class=""col-md-12"" id=""listChapter"">

                            <!-- END post -->
                        </div>
                    </div>
                    <div class=""row mt-5"">
                        <div class=""col-md-12 text-center"">
                            <nav aria-label=""Page navigation"" class=""text-center"">
                                <ul id=""pagination""></ul>
                            </nav>
                        </div>
                    </div>
                </div>
                <div class=""col-md-12 col-lg-2 main-content""></div>
            </div>
        </div>

</section>
<script id=""hidden-template"" type=""text/x");
            WriteLiteral("-custom-template\">\r\n    <div class=\"post-entry-horzontal\">\r\n        <a href=\"${link}\" style=\"width:750px\">\r\n            <span class=\"text\">\r\n                <h2>Chapter ${id} :${name}</h2>\r\n            </span>\r\n        </a>\r\n    </div>\r\n</script>\r\n\r\n");
            EndContext();
            DefineSection("scripts", async() => {
                BeginContext(2704, 300, true);
                WriteLiteral(@"
    <script>
            $(document).ready(function () {
                LoadChapterList();
                LoadStory();
        })
            function LoadChapterList() {
                $.ajax({
                    url: `${configuration.BASE_API_URL}Chapter/getChapterListbyStoryIdClient/");
                EndContext();
                BeginContext(3005, 13, false);
#line 86 "G:\PRC391\Project_Assignment\Final_Project\WebClient\Pages\chapterList.cshtml"
                                                                                        Write(Model.SeoName);

#line default
#line hidden
                EndContext();
                BeginContext(3018, 448, true);
                WriteLiteral(@"`,
                    method: ""GET"",
                    success: function (result) {
                        Pagination(result.data);
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
                BeginContext(3467, 13, false);
#line 99 "G:\PRC391\Project_Assignment\Final_Project\WebClient\Pages\chapterList.cshtml"
                                                                       Write(Model.SeoName);

#line default
#line hidden
                EndContext();
                BeginContext(3480, 1825, true);
                WriteLiteral(@"`,
                method: ""GET"",
                success: function (result) {
                    $('#story_description').append(result.data.description)
                    $('#authorName').append(result.data.authorName)
                    $('#CategoryName').append(result.data.categoryName)
                    $('#TotalChapter').append(result.data.totalChapters)
                    $('#lastTimePost').append(result.data.lastDateTimePostChapter)
                    var status = result.data.status;
                    var statusView="""";
                    if (status == 0) {
                        statusView = ""Đang Ra"";
                    } else if (status == 1) {
                        statusView = ""Hoàn Thành"";
                    } else {
                        statusView = ""Chưa Xác Định"";
                    }
                    $('#status').append(statusView)
                },
                error: function (result) {
                    alert(""Có lỗi xảy ra!"")
             ");
                WriteLiteral(@"   }
            });
        }
       
        function Pagination(sources) {
            var container = $('#pagination');
            var options = {
                dataSource: sources,
                pageSize: 3,
                callback: function (response, pagination) {
                    window.console && console.log(response, pagination);

                    var dataHtml = '';
                    $.each(response, function (key, value) {
                       var story = $('#hidden-template').text();
                            story = story.replace(""${name}"", value.name);
                            story = story.replace(""${id}"", value.id);
                            story = story.replace(""${link}"", ""/singlechapter?chapterId="" + value.position + ""&storySeoName=");
                EndContext();
                BeginContext(5306, 13, false);
#line 137 "G:\PRC391\Project_Assignment\Final_Project\WebClient\Pages\chapterList.cshtml"
                                                                                                                      Write(Model.SeoName);

#line default
#line hidden
                EndContext();
                BeginContext(5319, 609, true);
                WriteLiteral(@""");
                        dataHtml += story;
                    });
                    dataHtml += '';

                    $(""#listChapter"").html(dataHtml);
                }
            };

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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<WebClient.Pages.chapterListModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<WebClient.Pages.chapterListModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<WebClient.Pages.chapterListModel>)PageContext?.ViewData;
        public WebClient.Pages.chapterListModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
