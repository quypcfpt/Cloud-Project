#pragma checksum "D:\Cloud\Cloud-Project\Final_Project\WebAdmin\Pages\Story\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a44c53a4c8dabb44914aa42cc612affe8d650a87"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(WebAdmin.Pages.Story.Pages_Story_Index), @"mvc.1.0.razor-page", @"/Pages/Story/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.RazorPages.Infrastructure.RazorPageAttribute(@"/Pages/Story/Index.cshtml", typeof(WebAdmin.Pages.Story.Pages_Story_Index), null)]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a44c53a4c8dabb44914aa42cc612affe8d650a87", @"/Pages/Story/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f416e5b7e94e1b3197113b3dca862a887c682f0a", @"/Pages/_ViewImports.cshtml")]
    public class Pages_Story_Index : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
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
#line 3 "D:\Cloud\Cloud-Project\Final_Project\WebAdmin\Pages\Story\Index.cshtml"
  
    ViewData["Title"] = "Quản lý truyện";
    Layout = "~/Pages/Shared/_Layout.cshtml";

#line default
#line hidden
            BeginContext(166, 350, true);
            WriteLiteral(@"
<div class=""row page-titles"">
    <div class=""col-md-5 col-8 align-self-center"">
        <h3 class=""text-themecolor"">Quản lý truyện</h3>
        <ol class=""breadcrumb"">
            <li class=""breadcrumb-item""><a href=""/"">Trang chủ</a></li>
            <li class=""breadcrumb-item active"">Quản lý truyện</li>
        </ol>
    </div>
</div>
");
            EndContext();
            BeginContext(585, 1079, true);
            WriteLiteral(@"<div class=""row"">
    <div class=""col-12"">
        <div class=""card"">
            <div class=""card-body"">
                <div class=""table-responsive m-t-40"">
                    <table id=""StoryCategoriesDatatable"" class=""table table-striped table-bordered table-hover"">
                        <thead>
                            <tr>
                                <th>Tên</th>
                                <th>Hình ảnh</th>
                                <th>Thể loại</th>
                                <th>Tác giả</th>
                                <th>Người đăng</th>
                                <th>Trạng thái</th>
                                <th>Tổng số chương</th>
                                <th>Lượt xem</th>
                                <th>Xét duyệt</th>
                                <th>Action</th>
                            </tr>
                        </thead>
                        <tbody></tbody>
                    </table>
                </div>
 ");
            WriteLiteral("           </div>\r\n        </div>\r\n    </div>\r\n</div>\r\n");
            EndContext();
            BeginContext(1753, 1029, true);
            WriteLiteral(@"
<div class=""modal fade"" id=""UpdateStatusEventModal"" tabindex=""-1"" role=""dialog"" aria-labelledby=""myModalLabel""
     aria-hidden=""true"">
    <div class=""modal-dialog"" role=""document"">
        <div class=""modal-content"">
            <div class=""modal-header text-center"">
                <h4 class=""modal-title w-100 font-weight-bold"">Xét duyệt truyện</h4>
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
            BeginContext(2816, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            DefineSection("Scripts", async() => {
                BeginContext(2836, 6, true);
                WriteLiteral("\r\n    ");
                EndContext();
                BeginContext(2842, 76, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "a44c53a4c8dabb44914aa42cc612affe8d650a878011", async() => {
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
                BeginContext(2918, 6, true);
                WriteLiteral("\r\n    ");
                EndContext();
                BeginContext(2924, 97, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "a44c53a4c8dabb44914aa42cc612affe8d650a879266", async() => {
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
                BeginContext(3021, 6, true);
                WriteLiteral("\r\n    ");
                EndContext();
                BeginContext(3027, 97, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "a44c53a4c8dabb44914aa42cc612affe8d650a8710521", async() => {
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
                BeginContext(3124, 6, true);
                WriteLiteral("\r\n    ");
                EndContext();
                BeginContext(3130, 102, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "a44c53a4c8dabb44914aa42cc612affe8d650a8711778", async() => {
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
                BeginContext(3232, 5588, true);
                WriteLiteral(@"
    <script>
        $(document).ready(function () {
            InitDatatable();
        });
        var InitDatatable = function () {
            $('#StoryCategoriesDatatable').dataTable({
                ""ajax"": {
                    ""url"": `${configuration.BASE_API_URL}Story/getAll`,
                    ""method"": ""GET"",
                },
                dom: 'ftip',
                ""columns"": [
                    { data: 'name' },
                    {
                        data: 'imageUrl',
                        render: function (data) {
                            return '<img src=""' + data + '"" width=""100"" height=""150""/>'
                        }
                    },
                    { data: 'categoryName' },
                    { data: 'authorName' },
                    { data: 'posterName' },
                    {
                        data: 'status',
                        render: function (data) {
                            if (data == 0) {
             ");
                WriteLiteral(@"                   return '<span class=""label label-success"">Đang ra</span>'
                            } else if (data == 1) {
                                return '<span class=""label label-info"">Hoàn thành</span>'
                            }
                            else if (data == 2) {
                                return '<span class=""label label-danger"">Droped</span>'
                            } else {
                                return '<span class=""label label-warning"">Chưa xác định</span>'
                            }
                        }
                    },
                    { data: 'totalChapters' },
                    { data: 'totalVisit' },
                    {
                        data: 'approved',
                        render: function (data, type, row) {
                            if (data == 0) {
                                return '<button class=""btn btn-success"" onclick=""OpenChangeStatusPopup(' + row['id'] + ')"">Chờ duyệt</button>'
   ");
                WriteLiteral(@"                         } else if (data == 1) {
                                return '<button class=""btn btn-info""  onclick=""OpenChangeStatusPopup(' + row['id'] + ')"">Duyệt</button>'
                            }
                            else if (data == 2) {
                                return '<button class=""btn btn-danger""  onclick=""OpenChangeStatusPopup(' + row['id'] + ')"">Từ chối</button>'
                            } else {
                                return '<span class=""label label-warning"">Không xác dịnh</span>'
                            }
                        }
                    },
                    {
                        width: '40%',
                        data: 'id', render: function (data) {
                            return '<a class=""btn btn-info text-white"" title=""view detail"" href=""story/chapter?storyId=' + data + '""><i class=""fa fa-eye""></i></a>'
                                //+ '<button type=""button"" class=""btn btn-success m-l-10"" title=""Update""");
                WriteLiteral(@" onclick=""getEventDetails(' + data + ')""><i class=""fa fa-pencil""></i></button>'
                                + '<button type=""button"" class=""btn btn-danger"" title=""remove"" onclick=""DeleteEvent(' + data + ')""><i class=""fa fa-trash""></i></button>';
                        }
                    }
                ],
                autoWidth: false,
            });
        };

        //Change Status Event
        function OpenChangeStatusPopup(eventId) {
            $(""#UpdateStatusEventModal"").modal(""show"");
            $(""#eventIdStatus"").val(eventId);
        }
        function ChangeStatus(statusNum) {
            var eventId = $(""#eventIdStatus"").val();
            $.ajax({
                url: `${configuration.BASE_API_URL}Story/updateApproved?eventId=${eventId}&statusNum=${statusNum}`,
                headers: {
                    ""Authorization"": `${configuration.ACCESSTOKEN}`,
                },
                method: ""PUT"",
                contentType: false,
               ");
                WriteLiteral(@" success: function (result) {
                    if (result.success) {
                        $.toast({
                            heading: result.data.title,
                            text: result.data.msg,
                            position: 'top-right',
                            loaderBg: '#ffff',
                            icon: 'success',
                            hideAfter: 3500,
                            stack: 6
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
                    $(""#UpdateStatusEventModal"").moda");
                WriteLiteral(@"l('hide');
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<WebAdmin.Pages.Story.IndexModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<WebAdmin.Pages.Story.IndexModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<WebAdmin.Pages.Story.IndexModel>)PageContext?.ViewData;
        public WebAdmin.Pages.Story.IndexModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
