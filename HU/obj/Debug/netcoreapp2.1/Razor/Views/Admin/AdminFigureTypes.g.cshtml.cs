#pragma checksum "C:\Users\Oksana\source\repos\HU\HU\Views\Admin\AdminFigureTypes.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "4d0d69bf393aaf683fe34b331ba91b00aad6827e"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Admin_AdminFigureTypes), @"mvc.1.0.view", @"/Views/Admin/AdminFigureTypes.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Admin/AdminFigureTypes.cshtml", typeof(AspNetCore.Views_Admin_AdminFigureTypes))]
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
#line 2 "C:\Users\Oksana\source\repos\HU\HU\Views\Admin\AdminFigureTypes.cshtml"
using NonFactors.Mvc.Grid;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4d0d69bf393aaf683fe34b331ba91b00aad6827e", @"/Views/Admin/AdminFigureTypes.cshtml")]
    public class Views_Admin_AdminFigureTypes : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<HU.Models.AdminFigureTypesViewModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(0, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(74, 762, true);
            WriteLiteral(@"
<script>
    $(function () {
        $('.modal-open').click(function () {
            var url = $(this).attr('href');
            $.get(url, function (data) {
                $('.modal-content').html(data);
                $('.modal').modal('show');
            });

            return false;
        });

        $('.delete-figureType').click(function () {
            $.ajax({
                type: ""GET"",
                url: $(this).attr(""href""),
                data: $(this).serialize(),
                success: function (res) {
                    if (res.success) {
                        location.reload();
                    }
                }
            });

            return false;
        });
    })
</script>

");
            EndContext();
            BeginContext(837, 25, false);
#line 34 "C:\Users\Oksana\source\repos\HU\HU\Views\Admin\AdminFigureTypes.cshtml"
Write(Html.Partial("AdminMenu"));

#line default
#line hidden
            EndContext();
            BeginContext(862, 31, true);
            WriteLiteral("\r\n<div class=\"container\">\r\n    ");
            EndContext();
            BeginContext(894, 21, false);
#line 36 "C:\Users\Oksana\source\repos\HU\HU\Views\Admin\AdminFigureTypes.cshtml"
Write(Html.Partial("Modal"));

#line default
#line hidden
            EndContext();
            BeginContext(915, 21, true);
            WriteLiteral("\r\n    <div>\r\n        ");
            EndContext();
            BeginContext(938, 1115, false);
#line 38 "C:\Users\Oksana\source\repos\HU\HU\Views\Admin\AdminFigureTypes.cshtml"
    Write(Html
              .Grid(Model.FigureTypes)
              .Build(columns =>
              {
                  columns.Add(model => model.FigureTypeName).Titled("Тип постаті").Css("table-cell");
                  columns.Add().Encoded(false)
                      .RenderedAs(o => (
                          Html.ActionLink("Редагувати", "UpdateFigureType", "Admin", new { figureTypeId = o.FigureTypeId }, new { @class = "btn btn-default modal-open"})
                          )
                      ).Css("table-cell");
                  ;
                  columns.Add().Encoded(false)
                      .RenderedAs(o => (
                          Html.ActionLink("Видалити", "DeleteFigureType", "Admin", new { figureTypeId = o.FigureTypeId }, new { @class = "btn btn-default delete-figureType" })
                          )
                      ).Css("table-cell");
                  ;
              })
              .Empty("Даних не знайдено")
              .Filterable()
              .Pageable(pager =>
              {
                  pager.RowsPerPage = 10;
              }));

#line default
#line hidden
            EndContext();
            BeginContext(2054, 22, true);
            WriteLiteral("\r\n\r\n    </div>\r\n\r\n    ");
            EndContext();
            BeginContext(2077, 121, false);
#line 65 "C:\Users\Oksana\source\repos\HU\HU\Views\Admin\AdminFigureTypes.cshtml"
Write(Html.ActionLink("Додати тип постаті", "UpdateFigureType", "Admin", new { }, new { @class = "btn btn-primary modal-open"}));

#line default
#line hidden
            EndContext();
            BeginContext(2198, 8, true);
            WriteLiteral("\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<HU.Models.AdminFigureTypesViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
