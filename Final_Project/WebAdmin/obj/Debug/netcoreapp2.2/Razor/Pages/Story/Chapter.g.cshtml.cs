#pragma checksum "D:\Cloud\Cloud-Project\Final_Project\WebAdmin\Pages\Story\Chapter.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "9ef4d89ef52a309f746a0ce0b99a279e41f4beae"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(WebAdmin.Pages.Story.Pages_Story_Chapter), @"mvc.1.0.razor-page", @"/Pages/Story/Chapter.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.RazorPages.Infrastructure.RazorPageAttribute(@"/Pages/Story/Chapter.cshtml", typeof(WebAdmin.Pages.Story.Pages_Story_Chapter), null)]
namespace WebAdmin.Pages.Story
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#line 1 "D:\Cloud\Cloud-Project\Final_Project\WebAdmin\Pages\_ViewImports.cshtml"
using WebAdmin;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9ef4d89ef52a309f746a0ce0b99a279e41f4beae", @"/Pages/Story/Chapter.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f416e5b7e94e1b3197113b3dca862a887c682f0a", @"/Pages/_ViewImports.cshtml")]
    public class Pages_Story_Chapter : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/assets/plugins/datatables/jquery.dataTables.min.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/assets/plugins/cdn.datatables.net/buttons/1.2.2/js/buttons.html5.min.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/assets/plugins/cdn.datatables.net/buttons/1.2.2/js/buttons.flash.min.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/assets/plugins/cdn.datatables.net/buttons/1.2.2/js/dataTables.buttons.min.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 3 "D:\Cloud\Cloud-Project\Final_Project\WebAdmin\Pages\Story\Chapter.cshtml"
  
    ViewData["Title"] = "Chapter";
    Layout = "~/Pages/Shared/_Layout.cshtml";

#line default
#line hidden
            BeginContext(139, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(165, 432, true);
            WriteLiteral(@"<div class=""row page-titles"">
    <div class=""col-md-5 col-8 align-self-center"">
        <h3 class=""text-themecolor"">Quản lý truyện</h3>
        <ol class=""breadcrumb"">
            <li class=""breadcrumb-item""><a href=""/"">Trang chủ</a></li>
            <li class=""breadcrumb-item""><a href=""/story"">Quản lý truyện</a></li>
            <li class=""breadcrumb-item active"">Danh sách chương</li>
        </ol>
    </div>
</div>
");
            EndContext();
            BeginContext(666, 2647, true);
            WriteLiteral(@"<div class=""row"">
    <div class=""col-12"">
        <div class=""card"">
            <div class=""card-body"">

                <div class=""row"">
                    <div class=""col-3"">
                        <div id=""review_container""></div>
                    </div>
                    <div class=""col-8"">
                        <h4 class=""card-title"" id=""name"">ĐẤU PHÁ THƯƠNG KHUNG</h4>
                        <div class=""col-md-6"">
                            <label class=""card-subtitle"">Tác giả:</label>
                            <span id=""author""> Thiên Tằm thổ đậu</span>
                        </div>
                        <div class=""col-md-6"">
                            <label class=""card-subtitle"">Người đăng:</label>
                            <span id=""poster""> tin@gmail.com</span>
                        </div>
                        <div class=""col-md-6"">
                            <label class=""card-subtitle"">Thể loại:</label>
                            <span id=""categor");
            WriteLiteral(@"y""> Huyền huyễn</span>
                        </div>
                        <div class=""col-md-6"">
                            <label class=""card-subtitle"">Trạng thái:</label>
                            <span id=""status""></span>
                        </div>
                        <div class=""col-md-6"">
                            <label class=""card-subtitle"">Lượt xem:</label>
                            <span id=""totalVisit""> 50</span>
                        </div>
                        <div class=""col-md-12"">
                            <label class=""card-subtitle"">Giới thiệu:</label>
                            <div id=""description""></div>
                        </div>
                    </div>

                </div>

                <div class=""table-responsive m-t-40"">
                    <h3 class=""card-title card-info text-white"">DANH SÁCH CHƯƠNG</h3>
                    <table id=""StoryCategoriesDatatable"" class=""table table-striped table-bordered table-hover"">
        ");
            WriteLiteral(@"                <thead class=""table-success"">
                            <tr>
                                <th>Chương</th>
                                <th>Tiêu đề</th>
                                <th>Ngày đăng</th>
                                <th>Lượt xem</th>
                                <th>Trạng thái</th>
                                <th></th>
                            </tr>
                        </thead>
                        <tbody></tbody>
                    </table>
                </div>
            </div>
        </div>
    </div>
</div>
");
            EndContext();
            BeginContext(3359, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(3406, 1029, true);
            WriteLiteral(@"
<div class=""modal fade"" id=""UpdateStatusEventModal"" tabindex=""-1"" role=""dialog"" aria-labelledby=""myModalLabel""
     aria-hidden=""true"">
    <div class=""modal-dialog"" role=""document"">
        <div class=""modal-content"">
            <div class=""modal-header text-center"">
                <h4 class=""modal-title w-100 font-weight-bold"">Xét duyệt Chương</h4>
                <input type=""hidden"" id=""eventIdStatus"" />
                <button type=""button"" class=""close"" data-dismiss=""modal"" aria-label=""Close"">
                    <span aria-hidden=""true"">&times;</span>
                </button>
            </div>
            <div class=""modal-body mx-3 d-flex justify-content-center"">
                <button type=""button"" class=""btn btn-success waves-effect waves-light m-r-10"" onclick=""ChangeStatus(1)"">Duyệt</button>
                <button type=""button"" class=""btn btn-danger waves-effect waves-light m-r-10"" onclick=""ChangeStatus(2)"">Từ chối</button>
            </div>
        </div>
    </div>
</div");
            WriteLiteral(">\r\n\r\n");
            EndContext();
            BeginContext(4480, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(4516, 1114, true);
            WriteLiteral(@"
<div class=""modal fade"" id=""EditEventModal"" tabindex=""-1"" role=""dialog"" aria-labelledby=""myModalLabel""
     aria-hidden=""true"">
    <div class=""modal-dialog modal-lg"" role=""document"">
        <div class=""modal-content"">
            <div class=""modal-header text-center"">
                <h4 class=""modal-title w-100 font-weight-bold"">Nội dung Chương <span id=""position""></span>: <span id=""chaptername""></span></h4>
                <button type=""button"" class=""close"" data-dismiss=""modal"" aria-label=""Close"">
                    <span aria-hidden=""true"">&times;</span>
                </button>
            </div>
            <div class=""modal-body mx-3"">
                <div class=""col-md-12"" id=""detail"">

                </div>
            </div>
            <div class=""modal-footer d-flex justify-content-center"">
                <button type=""button"" class=""btn btn-black waves-effect waves-light m-r-10"" data-dismiss=""modal"" aria-label=""Close"">
                    <span aria-hidden=""true"">Đóng</sp");
            WriteLiteral("an>\r\n                </button>\r\n            </div>\r\n        </div>\r\n    </div>\r\n</div>\r\n\r\n");
            EndContext();
            BeginContext(5664, 4, true);
            WriteLiteral("\r\n\r\n");
            EndContext();
            DefineSection("Scripts", async() => {
                BeginContext(5686, 6, true);
                WriteLiteral("\r\n    ");
                EndContext();
                BeginContext(5692, 76, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "9ef4d89ef52a309f746a0ce0b99a279e41f4beae11383", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(5768, 6, true);
                WriteLiteral("\r\n    ");
                EndContext();
                BeginContext(5774, 97, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "9ef4d89ef52a309f746a0ce0b99a279e41f4beae12639", async() => {
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
                BeginContext(5871, 6, true);
                WriteLiteral("\r\n    ");
                EndContext();
                BeginContext(5877, 97, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "9ef4d89ef52a309f746a0ce0b99a279e41f4beae13895", async() => {
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
                BeginContext(5974, 6, true);
                WriteLiteral("\r\n    ");
                EndContext();
                BeginContext(5980, 102, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "9ef4d89ef52a309f746a0ce0b99a279e41f4beae15152", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(6082, 85, true);
                WriteLiteral("\r\n    <script>\r\n        $(document).ready(function () {\r\n            getStoryDetails(");
                EndContext();
                BeginContext(6168, 13, false);
#line 141 "D:\Cloud\Cloud-Project\Final_Project\WebAdmin\Pages\Story\Chapter.cshtml"
                       Write(Model.StoryId);

#line default
#line hidden
                EndContext();
                BeginContext(6181, 262, true);
                WriteLiteral(@");
            InitDatatable();
        });
        var InitDatatable = function () {
            $('#StoryCategoriesDatatable').dataTable({
                ""ajax"": {
                    ""url"": `${configuration.BASE_API_URL}Chapter/getChapterListbyStoryId/");
                EndContext();
                BeginContext(6444, 13, false);
#line 147 "D:\Cloud\Cloud-Project\Final_Project\WebAdmin\Pages\Story\Chapter.cshtml"
                                                                                    Write(Model.StoryId);

#line default
#line hidden
                EndContext();
                BeginContext(6457, 7516, true);
                WriteLiteral(@"`,
                    ""method"": ""GET"",
                },
                dom: 'ftip',
                ""columns"": [
                    { data: 'position' },
                    { data: 'name' },
                    {
                        data: 'createTime', render: function (data) {
                            return formatDate(data);
                        }
                    },

                    { data: 'totalVisit' },
                    {
                        data: 'isApproved',
                        render: function (data, type, row) {
                            if (data == 0) {
                                return '<button class=""btn btn-success"" onclick=""OpenChangeStatusPopup(' + row['id'] + ')"">Chờ duyệt</button>'
                            } else if (data == 1) {
                                return '<button class=""btn btn-info""  onclick=""OpenChangeStatusPopup(' + row['id'] + ')"">Duyệt</button>'
                            }
                            else");
                WriteLiteral(@" if (data == 2) {
                                return '<button class=""btn btn-danger""  onclick=""OpenChangeStatusPopup(' + row['id'] + ')"">Từ chối</button>'
                            } else {
                                return '<span class=""label label-warning"">Không xác dịnh</span>'
                            }
                        }
                    },
                    {
                        width: '10%',
                        data: 'id', render: function (data) {
                            return '<button type=""button"" class=""btn btn-info m-l-10"" title=""Update"" onclick=""getEventDetails(' + data + ')""><i class=""fa fa-eye""></i></button>';
                        }
                    }
                ],
                autoWidth: false,
            });
        };

        //Get Story Detail
        var getStoryDetails = function (id) {
            $.ajax({
                url: `${configuration.BASE_API_URL}Story/getDetail/${id}`,
                method: ""GET"",
");
                WriteLiteral(@"                success: function (result) {
                    actionAdd = false;
                    $('#name').text(result.data.name);
                    $('#description').append(result.data.description);
                    $('#category').text(result.data.categoryName);
                    $('#poster').text(result.data.categoryName.posterName);
                    $('#author').text(result.data.authorName);
                    $('#totalVisit').text(result.data.totalVisit)
                    if (result.data.imageUrl != null) {
                        $(""#review_container"").children().remove().end();
                        var oldHandle = result.data.imageUrl.replace(""https://cdn.filestackcontent.com/"", """");
                        $(""#review_container"").append(""<img src='https://cdn.filestackcontent.com/resize=height:300/"" + oldHandle + ""' alt='Preview-loading'/>"");
                    }
                    var data = result.data.status;
                    if (data == 0) {
              ");
                WriteLiteral(@"          $('#status').append('<span class=""badge badge-success"">Chờ duyệt</span>');
                    } else if (data == 1) {
                        $('#status').append('<span class=""badge badge-info"">Đã duyệt</span>');
                    }
                    else if (data == 2) {
                        $('#status').append('<span class=""badge badge-danger"">Từ chối</span>');
                    } else {
                        $('#status').append('<span class=""badge badge-warning"">Chưa xác định</span>');
                    }
                },
                error: function (result) {
                    $.toast({
                        heading: result.data.title,
                        text: result.data.msg,
                        position: 'top-right',
                        loaderBg: '#ffff',
                        icon: 'error',
                        hideAfter: 3500
                    });
                }
            });
        };

        //Change Status Event
  ");
                WriteLiteral(@"      function OpenChangeStatusPopup(eventId) {
            $(""#UpdateStatusEventModal"").modal(""show"");
            $(""#eventIdStatus"").val(eventId);
        }
        function ChangeStatus(statusNum) {
            var eventId = $(""#eventIdStatus"").val();
            $.ajax({
                url: `${configuration.BASE_API_URL}Chapter/updateStatus?eventId=${eventId}&statusNum=${statusNum}`,
                headers: {
                    ""Authorization"": `${configuration.ACCESSTOKEN}`,
                },
                method: ""PUT"",
                contentType: false,
                success: function (result) {
                    if (result.success) {
                        $.toast({
                            heading: result.data.title,
                            text: result.data.msg,
                            position: 'top-right',
                            loaderBg: '#ffff',
                            icon: 'success',
                            hideAfter: 3500,
           ");
                WriteLiteral(@"                 stack: 6
                        });
                    } else {
                        $.toast({
                            heading: result.data.title,
                            text: result.data.msg,
                            position: 'top-right',
                            loaderBg: '#ffff',
                            icon: 'error',
                            hideAfter: 3500
                        });
                    }
                    $('#StoryCategoriesDatatable').DataTable().ajax.reload();
                    $(""#UpdateStatusEventModal"").modal('hide');
                },
                error: function (result) {
                    $.toast({
                        heading: result.data.title,
                        text: result.data.msg,
                        position: 'top-right',
                        loaderBg: '#ffff',
                        icon: 'error',
                        hideAfter: 3500
                    });
               ");
                WriteLiteral(@" }
            });
        }
        //Click View button in datatable row
       function getEventDetails(id) {
            $.ajax({
                url: `${configuration.BASE_API_URL}Chapter/getDetail/${id}`,
                method: ""GET"",
                success: function (result) {
                    $('#position').text(result.data.position);
                    $('#chaptername').text(result.data.name);
                    $('#detail').text(result.data.detail)
                    $(""#EditEventModal"").modal('show');
                },
                error: function (result) {
                    $.toast({
                        heading: result.data.title,
                        text: result.data.msg,
                        position: 'top-right',
                        loaderBg: '#ffff',
                        icon: 'error',
                        hideAfter: 3500
                    });
                }
            });
        };
        function formatDate(date) {
       ");
                WriteLiteral(@"     var d = new Date(date),
                month = '' + (d.getMonth() + 1),
                day = '' + d.getDate(),
                year = d.getFullYear();

            if (month.length < 2) month = '0' + month;
            if (day.length < 2) day = '0' + day;

            return [day, month, year].join('/');
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<WebAdmin.Pages.Story.ChapterModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<WebAdmin.Pages.Story.ChapterModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<WebAdmin.Pages.Story.ChapterModel>)PageContext?.ViewData;
        public WebAdmin.Pages.Story.ChapterModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
