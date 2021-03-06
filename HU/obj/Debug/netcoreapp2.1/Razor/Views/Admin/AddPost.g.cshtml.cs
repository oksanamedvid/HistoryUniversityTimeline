#pragma checksum "C:\Users\Oksana\source\repos\HU\HU\Views\Admin\AddPost.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b851a2752069ff0294f30f774cf93ee5ab1a2d32"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Admin_AddPost), @"mvc.1.0.view", @"/Views/Admin/AddPost.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Admin/AddPost.cshtml", typeof(AspNetCore.Views_Admin_AddPost))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b851a2752069ff0294f30f774cf93ee5ab1a2d32", @"/Views/Admin/AddPost.cshtml")]
    public class Views_Admin_AddPost : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<HU.Models.UpdatePostViewModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(38, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\Users\Oksana\source\repos\HU\HU\Views\Admin\AddPost.cshtml"
  
    Model.EventTypes = Model.EventTypes ?? new List<SelectListItem>();
    Model.FigureTypes = Model.FigureTypes ?? new List<SelectListItem>();
    Model.PeriodsList = Model.PeriodsList ?? new List<SelectListItem>();

#line default
#line hidden
            BeginContext(267, 718, true);
            WriteLiteral(@"
<script>
    $(document).ready(function () {
        $(""#AddPostForm"").submit(function () {

            var form = $(this)[0];           
            var data = new FormData(form);
            $.ajax({
                type: ""POST"",
                url: $(this).attr(""action""),
                data: data,
                cache: false,
                contentType: false,
                processData: false,
                success: function (res) {
                    if (res.success) {
                        $("".close"").click();
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
#line 35 "C:\Users\Oksana\source\repos\HU\HU\Views\Admin\AddPost.cshtml"
 using (Html.BeginForm(null, null, FormMethod.Post, new {enctype = "multipart/form-data", id = "AddPostForm"}))
{
    

#line default
#line hidden
            BeginContext(1106, 23, false);
#line 37 "C:\Users\Oksana\source\repos\HU\HU\Views\Admin\AddPost.cshtml"
Write(Html.AntiForgeryToken());

#line default
#line hidden
            EndContext();
            BeginContext(1136, 42, false);
#line 38 "C:\Users\Oksana\source\repos\HU\HU\Views\Admin\AddPost.cshtml"
Write(Html.HiddenFor(model => model.PeriodsList));

#line default
#line hidden
            EndContext();
            BeginContext(1182, 163, true);
            WriteLiteral("    <div class=\"modal-header\" style=\"background-color: #d9edf7\">                 \r\n        <div class=\"panel-title\">Додати пост</div>                \r\n    </div>\r\n");
            EndContext();
            BeginContext(1347, 324, true);
            WriteLiteral(@"    <div class=""modal-body"">
        <div class=""mainbox"">
            <div class=""panel panel-info"">
                <div class=""panel-body"">
                    <div class=""form-group"">
                        <label class=""col-md-4 control-label"">
                            Заголовок
                            ");
            EndContext();
            BeginContext(1672, 47, false);
#line 51 "C:\Users\Oksana\source\repos\HU\HU\Views\Admin\AddPost.cshtml"
                       Write(Html.ValidationMessageFor(model => model.Title));

#line default
#line hidden
            EndContext();
            BeginContext(1719, 112, true);
            WriteLiteral("\r\n                        </label>\r\n                        <div class=\"col-md-8\">\r\n                            ");
            EndContext();
            BeginContext(1832, 98, false);
#line 54 "C:\Users\Oksana\source\repos\HU\HU\Views\Admin\AddPost.cshtml"
                       Write(Html.TextBoxFor(model => model.Title, new {@class = "input-md  textinput textInput form-control"}));

#line default
#line hidden
            EndContext();
            BeginContext(1930, 325, true);
            WriteLiteral(@"
                        </div>


                    </div>

                    <div class=""form-group"">
                        <label class=""col-md-4 control-label"">
                            Контент
                        </label>
                        <div class=""col-md-8"">
                            ");
            EndContext();
            BeginContext(2256, 125, false);
#line 65 "C:\Users\Oksana\source\repos\HU\HU\Views\Admin\AddPost.cshtml"
                       Write(Html.TextAreaFor(model => model.Content, new {@class = "input-md  textinput textInput form-control", style = "height:300px"}));

#line default
#line hidden
            EndContext();
            BeginContext(2381, 240, true);
            WriteLiteral("\r\n                        </div>\r\n                    </div>\r\n                    <div class=\"form-group\">\r\n                        <label class=\"col-md-4 control-label\">\r\n                            Дата події\r\n                            ");
            EndContext();
            BeginContext(2622, 50, false);
#line 71 "C:\Users\Oksana\source\repos\HU\HU\Views\Admin\AddPost.cshtml"
                       Write(Html.ValidationMessageFor(model => model.PostDate));

#line default
#line hidden
            EndContext();
            BeginContext(2672, 112, true);
            WriteLiteral("\r\n                        </label>\r\n                        <div class=\"col-md-8\">\r\n                            ");
            EndContext();
            BeginContext(2785, 101, false);
#line 74 "C:\Users\Oksana\source\repos\HU\HU\Views\Admin\AddPost.cshtml"
                       Write(Html.TextBoxFor(model => model.PostDate, new {@class = "input-md  textinput textInput form-control"}));

#line default
#line hidden
            EndContext();
            BeginContext(2886, 238, true);
            WriteLiteral("\r\n                        </div>\r\n                    </div>\r\n\r\n                    <div class=\"form-group\">\r\n                        <label class=\"col-md-4 control-label\">\r\n                            Період\r\n                            ");
            EndContext();
            BeginContext(3125, 58, false);
#line 81 "C:\Users\Oksana\source\repos\HU\HU\Views\Admin\AddPost.cshtml"
                       Write(Html.ValidationMessageFor(model => model.SelectedPeriodId));

#line default
#line hidden
            EndContext();
            BeginContext(3183, 112, true);
            WriteLiteral("\r\n                        </label>\r\n                        <div class=\"col-md-8\">\r\n                            ");
            EndContext();
            BeginContext(3296, 220, false);
#line 84 "C:\Users\Oksana\source\repos\HU\HU\Views\Admin\AddPost.cshtml"
                       Write(Html.DropDownListFor(model => model.SelectedPeriodId,
                                Model.PeriodsList,
                                "Вибрати період",
                                new {@class = "form-control"}));

#line default
#line hidden
            EndContext();
            BeginContext(3516, 247, true);
            WriteLiteral("\r\n                        </div>\r\n                    </div>\r\n\r\n                    <div class=\"form-group\">\r\n                        <label class=\"col-md-4 control-label\">\r\n                            Тип події\r\n                        </label>\r\n");
            EndContext();
#line 95 "C:\Users\Oksana\source\repos\HU\HU\Views\Admin\AddPost.cshtml"
                         foreach (var item in Model.EventTypes)
                        {

#line default
#line hidden
            BeginContext(3855, 312, true);
            WriteLiteral(@"                            <div class=""controls col-md-offset-4 col-md-8  checkbox"">
                                <label class=""form-check-label"">
                                    <input type=""checkbox"" class=""input-ms checkboxinput""
                                           name=""SelectedEventTypes""");
            EndContext();
            BeginWriteAttribute("value", "\r\n                                           value=\"", 4167, "\"", 4230, 1);
#line 101 "C:\Users\Oksana\source\repos\HU\HU\Views\Admin\AddPost.cshtml"
WriteAttributeValue("", 4219, item.Value, 4219, 11, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(4231, 3, true);
            WriteLiteral("/> ");
            EndContext();
            BeginContext(4235, 9, false);
#line 101 "C:\Users\Oksana\source\repos\HU\HU\Views\Admin\AddPost.cshtml"
                                                            Write(item.Text);

#line default
#line hidden
            EndContext();
            BeginContext(4244, 80, true);
            WriteLiteral("\r\n                                </label>\r\n                            </div>\r\n");
            EndContext();
#line 104 "C:\Users\Oksana\source\repos\HU\HU\Views\Admin\AddPost.cshtml"
                        }

#line default
#line hidden
            BeginContext(4351, 217, true);
            WriteLiteral("                    </div>\r\n\r\n                    <div class=\"form-group\">\r\n\r\n                        <label class=\"col-md-4 control-label\">\r\n                            Тип постаті\r\n                        </label>\r\n");
            EndContext();
#line 112 "C:\Users\Oksana\source\repos\HU\HU\Views\Admin\AddPost.cshtml"
                         foreach (var item in Model.FigureTypes)
                        {

#line default
#line hidden
            BeginContext(4661, 313, true);
            WriteLiteral(@"                            <div class=""controls col-md-offset-4 col-md-8  checkbox"">
                                <label class=""form-check-label"">
                                    <input type=""checkbox"" class=""input-ms checkboxinput""
                                           name=""SelectedFigureTypes""");
            EndContext();
            BeginWriteAttribute("value", "\r\n                                           value=\"", 4974, "\"", 5037, 1);
#line 118 "C:\Users\Oksana\source\repos\HU\HU\Views\Admin\AddPost.cshtml"
WriteAttributeValue("", 5026, item.Value, 5026, 11, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(5038, 3, true);
            WriteLiteral("/> ");
            EndContext();
            BeginContext(5042, 9, false);
#line 118 "C:\Users\Oksana\source\repos\HU\HU\Views\Admin\AddPost.cshtml"
                                                            Write(item.Text);

#line default
#line hidden
            EndContext();
            BeginContext(5051, 80, true);
            WriteLiteral("\r\n                                </label>\r\n                            </div>\r\n");
            EndContext();
#line 121 "C:\Users\Oksana\source\repos\HU\HU\Views\Admin\AddPost.cshtml"
                        }

#line default
#line hidden
            BeginContext(5158, 205, true);
            WriteLiteral("                    </div>\r\n                    <div class=\"form-group\">\r\n                        <label class=\"col-md-4 control-label\">\r\n                            Медіадані\r\n                            ");
            EndContext();
            BeginContext(5364, 47, false);
#line 126 "C:\Users\Oksana\source\repos\HU\HU\Views\Admin\AddPost.cshtml"
                       Write(Html.ValidationMessageFor(model => model.Image));

#line default
#line hidden
            EndContext();
            BeginContext(5411, 112, true);
            WriteLiteral("\r\n                        </label>\r\n                        <div class=\"col-md-8\">\r\n                            ");
            EndContext();
            BeginContext(5524, 50, false);
#line 129 "C:\Users\Oksana\source\repos\HU\HU\Views\Admin\AddPost.cshtml"
                       Write(Html.TextBoxFor(m => m.Image, new {type = "file"}));

#line default
#line hidden
            EndContext();
            BeginContext(5574, 343, true);
            WriteLiteral(@"
                        </div>
                    </div>
                </div>
            </div>
        </div>
    </div>
    <div class=""modal-footer"">
        <button type=""submit"" class=""btn btn-default"">Зберегти</button>
        <button type=""button"" class=""btn btn-danger"" data-dismiss=""modal"">Закрити</button>
    </div>
");
            EndContext();
#line 140 "C:\Users\Oksana\source\repos\HU\HU\Views\Admin\AddPost.cshtml"
}

#line default
#line hidden
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<HU.Models.UpdatePostViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
