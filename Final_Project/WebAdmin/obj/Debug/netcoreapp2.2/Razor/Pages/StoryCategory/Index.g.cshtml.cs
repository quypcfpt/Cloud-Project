#pragma checksum "G:\PRC391\Final_Project\WebAdmin\Pages\StoryCategory\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "242999f061e68db4db9c9c08a710220ebd81fbdf"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(WebAdmin.Pages.StoryCategory.Pages_StoryCategory_Index), @"mvc.1.0.razor-page", @"/Pages/StoryCategory/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.RazorPages.Infrastructure.RazorPageAttribute(@"/Pages/StoryCategory/Index.cshtml", typeof(WebAdmin.Pages.StoryCategory.Pages_StoryCategory_Index), null)]
namespace WebAdmin.Pages.StoryCategory
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#line 1 "G:\PRC391\Final_Project\WebAdmin\Pages\_ViewImports.cshtml"
using WebAdmin;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"242999f061e68db4db9c9c08a710220ebd81fbdf", @"/Pages/StoryCategory/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f416e5b7e94e1b3197113b3dca862a887c682f0a", @"/Pages/_ViewImports.cshtml")]
    public class Pages_StoryCategory_Index : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("form p-t-20"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("AddStoryCatesForm"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("EditCategoryForm"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/assets/plugins/datatables/jquery.dataTables.min.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/assets/plugins/cdn.datatables.net/buttons/1.2.2/js/buttons.html5.min.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/assets/plugins/cdn.datatables.net/buttons/1.2.2/js/buttons.flash.min.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/assets/plugins/cdn.datatables.net/buttons/1.2.2/js/dataTables.buttons.min.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 3 "G:\PRC391\Final_Project\WebAdmin\Pages\StoryCategory\Index.cshtml"
  
    ViewData["Title"] = "Thể loại truyện";
    Layout = "~/Pages/Shared/_Layout.cshtml";

#line default
#line hidden
            BeginContext(153, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(179, 352, true);
            WriteLiteral(@"<div class=""row page-titles"">
    <div class=""col-md-5 col-8 align-self-center"">
        <h3 class=""text-themecolor"">Quản lý thể loại</h3>
        <ol class=""breadcrumb"">
            <li class=""breadcrumb-item""><a href=""/"">Trang chủ</a></li>
            <li class=""breadcrumb-item active"">Quản lý thể loại</li>
        </ol>
    </div>
</div>
");
            EndContext();
            BeginContext(600, 716, true);
            WriteLiteral(@"<div class=""row"">
    <div class=""col-12"">
        <div class=""card"">
            <div class=""card-body"">
                <div class=""table-responsive m-t-40"">
                    <table id=""StoryCategoriesDatatable"" class=""table table-striped table-bordered table-hover"">
                        <thead>
                            <tr>
                                <th>Thể loại</th>
                                <th>SeoName</th>
                                <th>Action</th>
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
            BeginContext(1398, 614, true);
            WriteLiteral(@"<div class=""modal fade"" id=""AddStoryCatesModal"" tabindex=""-1"" role=""dialog"" aria-labelledby=""myModalLabel""
     aria-hidden=""true"">
    <div class=""modal-dialog"" role=""document"">
        <div class=""modal-content"">
            <div class=""modal-header"">
                <h4 class=""modal-title w-100 font-weight-bold"">Thêm mới thể loại truyện</h4>
                <button type=""button"" class=""close"" data-dismiss=""modal"" aria-label=""Close"">
                    <span aria-hidden=""true"">&times;</span>
                </button>
            </div>
            <div class=""modal-body mx-3"">
                ");
            EndContext();
            BeginContext(2012, 779, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "242999f061e68db4db9c9c08a710220ebd81fbdf8649", async() => {
                BeginContext(2075, 709, true);
                WriteLiteral(@"
                    <div class=""form-group"">
                        <label for=""name"">Tên thể loại</label>
                        <div class=""input-group"">
                            <input type=""text"" name=""name"" class=""form-control"" id=""name"" placeholder=""Tên thể loại"">
                        </div>
                    </div>
                    <div class=""form-group"">
                        <label for=""description"">SeoName</label>
                        <div class=""input-group"">
                            <input type=""text"" class=""form-control"" name=""seoname"" id=""seoname"" placeholder=""vd: huyen-huyen"">
                        </div>
                    </div>
                ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(2791, 492, true);
            WriteLiteral(@"
            </div>
            <div class=""modal-footer d-flex justify-content-center"">
                <button type=""button"" id=""btnAddNew"" class=""btn btn-success waves-effect waves-light m-r-10"">Thêm</button>
                <button type=""button"" class=""btn btn-black waves-effect waves-light m-r-10"" data-dismiss=""modal"" aria-label=""Close"">
                    <span aria-hidden=""true"">Hủy</span>
                </button>
            </div>
        </div>
    </div>
</div>

");
            EndContext();
            BeginContext(3321, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(3357, 613, true);
            WriteLiteral(@"
<div class=""modal fade"" id=""EditCategoryModal"" tabindex=""-1"" role=""dialog"" aria-labelledby=""myModalLabel""
     aria-hidden=""true"">
    <div class=""modal-dialog"" role=""document"">
        <div class=""modal-content"">
            <div class=""modal-header text-center"">
                <h4 class=""modal-title w-100 font-weight-bold"">Edit Event</h4>
                <button type=""button"" class=""close"" data-dismiss=""modal"" aria-label=""Close"">
                    <span aria-hidden=""true"">&times;</span>
                </button>
            </div>
            <div class=""modal-body mx-3"">
                ");
            EndContext();
            BeginContext(3970, 878, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "242999f061e68db4db9c9c08a710220ebd81fbdf12567", async() => {
                BeginContext(4032, 809, true);
                WriteLiteral(@"
                    <div class=""form-group"">
                        <label for=""editname"">Tên thể loại</label>
                        <div class=""input-group"">
                            <input type=""text"" name=""name"" class=""form-control"" id=""editname"" placeholder=""vd: Huyền huyễn, kiếm hiệp,..."">
                        </div>
                    </div>
                    <div class=""form-group"">
                        <label for=""editSeoname"">Seoname</label>
                        <div class=""input-group"">
                            <input type=""text"" class=""form-control"" name=""editSeoname"" id=""editSeoname"" placeholder=""vd: huyen-huyen, kiem-hiep"">
                        </div>
                    </div>
                    <input type=""hidden"" id=""cateId"">
                ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(4848, 494, true);
            WriteLiteral(@"
            </div>
            <div class=""modal-footer d-flex justify-content-center"">
                <button type=""button"" id=""btnEdit"" class=""btn btn-success waves-effect waves-light m-r-10"">Cập nhật</button>
                <button type=""button"" class=""btn btn-black waves-effect waves-light m-r-10"" data-dismiss=""modal"" aria-label=""Close"">
                    <span aria-hidden=""true"">Hủy</span>
                </button>
            </div>
        </div>
    </div>
</div>

");
            EndContext();
            BeginContext(5376, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            DefineSection("Scripts", async() => {
                BeginContext(5396, 6, true);
                WriteLiteral("\r\n    ");
                EndContext();
                BeginContext(5402, 76, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "242999f061e68db4db9c9c08a710220ebd81fbdf16020", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(5478, 6, true);
                WriteLiteral("\r\n    ");
                EndContext();
                BeginContext(5484, 97, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "242999f061e68db4db9c9c08a710220ebd81fbdf17276", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(5581, 6, true);
                WriteLiteral("\r\n    ");
                EndContext();
                BeginContext(5587, 97, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "242999f061e68db4db9c9c08a710220ebd81fbdf18532", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_6);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(5684, 6, true);
                WriteLiteral("\r\n    ");
                EndContext();
                BeginContext(5690, 102, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "242999f061e68db4db9c9c08a710220ebd81fbdf19789", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_7);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(5792, 8905, true);
                WriteLiteral(@"
    <script>
        $(document).ready(function () {
            InitDatatable();
        });
        var InitDatatable = function () {
            $('#StoryCategoriesDatatable').dataTable({
                ""ajax"": {
                    ""url"": `${configuration.BASE_API_URL}StoryCategory/getAll`,
                    ""method"": ""GET"",
                },
                ""buttons"": [
                    {
                        text: '<i class=""left-icon fa fa-plus""></i>&nbsp;Thêm mới',
                        className: 'dt-button-success',
                        action: function (e, dt, node, config) {
                            ShowAddNewEventForm();
                        }
                    },
                ],
                dom: 'Bftip',
                ""columns"": [
                    { data: 'name' },
                    { data: 'seoName' },
                    {
                        data: 'id', render: function (data) {
                            return '<button typ");
                WriteLiteral(@"e=""button"" class=""btn btn-success"" onclick=""getEventDetails(' + data + ')""><i class=""fa fa-pencil""></i></button>'
                                + '<button type=""button"" class=""btn btn-danger m-l-10"" onclick=""DeleteEvent(' + data + ')""><i class=""fa fa-trash""></i></button>';
                        }
                    }
                ],
                'bAutoWidth': false,
            });
        };

        function DeleteEvent(id) {
            swal({
                title: ""Xác thực"",
                text: ""Bạn có muốn xóa thể loại truyện này không?"",
                type: ""warning"",
                showCancelButton: true,
                confirmButtonColor: ""#DD6B55"",
                confirmButtonText: ""Xóa"",
                cancelButtonText: ""Thoát"",
            }, function () {
                $.ajax({
                    type: 'DELETE',
                    url: `${configuration.BASE_API_URL}StoryCategory/delete?id=${id}`,
                    headers: {
                       ");
                WriteLiteral(@" ""Authorization"": `${configuration.ACCESSTOKEN}`,
                    },
                    success: function (result) {
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
                            $('#StoryCategoriesDatatable').DataTable().ajax.reload();
                        } else {
                            $.toast({
                                heading: result.data.title,
                                text: result.data.msg,
                                position: 'top-right',
                                loaderBg: '#ffff',
                            ");
                WriteLiteral(@"    icon: 'error',
                                hideAfter: 3500
                            });
                        }
                    },
                    Error: function (result) {
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
            });
        }

        //Add New Event Module
        function ShowAddNewEventForm() {
            $(""#AddStoryCatesModal"").modal().show();
        }

        var addNewEvent = function () {
            var formData = new FormData();
            formData.append(""name"", $(""#name"").val());
            formData.append(""seoname"", $(""#seoname"").val());
            $.ajax({
                url: ");
                WriteLiteral(@"`${configuration.BASE_API_URL}StoryCategory/create`,
                headers: {
                    ""Authorization"": `${configuration.ACCESSTOKEN}`,
                },
                method: ""post"",
                data: formData,
                processData: false,
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
                            stack: 6
                        });
                        $('#StoryCategoriesDatatable').DataTable().ajax.reload();
                        $('#AddStoryCatesModal').modal('hide');
                    }
                },
                error: functi");
                WriteLiteral(@"on (result) {
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

        $(""#btnAddNew"").on(""click"", function () {
            addNewEvent();
        });


        //Edit Event Module
        //Click Edit button in datatable row
        var getEventDetails = function (id) {
            $.ajax({
                url: `${configuration.BASE_API_URL}StoryCategory/getDetail/${id}`,
                method: ""GET"",
                success: function (result) {
                    $('#editname').val(result.data.name);
                    $('#editSeoname').val(result.data.seoName);
                    $('#cateId').val(result.data.id);
                    $(""#EditCategoryModal"").moda");
                WriteLiteral(@"l('show');
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
        //Click Edit Submit Edit Form
        var editEventDetails = function () {
            var formData = new FormData();
            formData.append(""name"", $(""#editname"").val());
            formData.append(""seoname"", $(""#editSeoname"").val());
            formData.append(""id"", $(""#cateId"").val());
            $.ajax({
                url: `${configuration.BASE_API_URL}StoryCategory/edit`,
                headers: {
                    ""Authorization"": `${configuration.ACCESSTOKEN}`,
                },
                method: ""PUT"",
              ");
                WriteLiteral(@"  data: formData,
                processData: false,
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
                    $('#");
                WriteLiteral(@"StoryCategoriesDatatable').DataTable().ajax.reload();
                    $(""#EditCategoryModal"").modal('hide');
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
        //click button to edit organization details
        $(""#btnEdit"").click(function () {
            editEventDetails();
        });
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<WebAdmin.Pages.StoryCategory.IndexModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<WebAdmin.Pages.StoryCategory.IndexModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<WebAdmin.Pages.StoryCategory.IndexModel>)PageContext?.ViewData;
        public WebAdmin.Pages.StoryCategory.IndexModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591