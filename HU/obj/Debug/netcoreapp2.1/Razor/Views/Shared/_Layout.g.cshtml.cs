#pragma checksum "C:\Users\Oksana\source\repos\HU\HU\Views\Shared\_Layout.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "93f92609e9c7919fbee24b7bc40bafb98663f647"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared__Layout), @"mvc.1.0.view", @"/Views/Shared/_Layout.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Shared/_Layout.cshtml", typeof(AspNetCore.Views_Shared__Layout))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"93f92609e9c7919fbee24b7bc40bafb98663f647", @"/Views/Shared/_Layout.cshtml")]
    public class Views_Shared__Layout : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(0, 25, true);
            WriteLiteral("<!DOCTYPE html>\r\n<html>\r\n");
            EndContext();
            BeginContext(25, 17455, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "51f11a41907f45759cb5efc269e29cb1", async() => {
                BeginContext(31, 17442, true);
                WriteLiteral(@"
    <link href=""https://www.jqueryscript.net/css/jquerysctipttop.css"" rel=""stylesheet"" type=""text/css"">
    <link rel=""stylesheet"" type=""text/css"" href=""https://fonts.googleapis.com/css?family=Roboto"">
    <script src=""https://ajax.aspnetcdn.com/ajax/jQuery/jquery-2.0.3.min.js""></script>
    <link rel=""stylesheet"" href=""https://ajax.aspnetcdn.com/ajax/bootstrap/3.3.7/css/bootstrap.min.css"">
    <link href=""../Content/MvcGrid/mvc-grid.css"" rel=""stylesheet"">
    <script src=""https://ajax.aspnetcdn.com/ajax/bootstrap/3.3.7/bootstrap.min.js""></script>
    <title>University History</title>
    <script type=""text/javascript"">
        (function ($) {
            var RangeRover = function () {
                this.options = {
                    range: false,
                    mode: 'plain',
                    autocalculate: true,
                    color: '#3498db',
                    step: 1,
                    vLabels: false
                };
                this.coordinates = {
       ");
                WriteLiteral(@"             startSkate: {
                        min: 0,
                        max: 0
                    }
                };
                this.selector = null;
                this.startSkate = null;

                this.progressBar = null;
                // whether mouse/finger pressed or not
                this.enabledSkater = null;
                this.selected = {
                    start: {
                        value: 0,
                        timeId: 1
                    }
                };
                this.setEvendHandlers = function () {
                    var self = this;

                    self.startSkate.on('mousedown touchstart', function () {
                        self.enabledSkater = 'startSkate';
                    });



                    $(document).on('mouseup touchend', function () {
                        self.checkSelection(null);
                        self.enabledSkater = null;
                    });

                    $");
                WriteLiteral(@"(document).on('mousemove touchmove', function (e) {
                        if (self.enabledSkater) {
                            self.checkSelection(null);
                            var positionToScroll = e.pageX - self.selector.offset().left;

                            if (positionToScroll < self.coordinates[self.enabledSkater].min) {
                                // use slider's left border as a min position
                                positionToScroll = self.coordinates[self.enabledSkater].min;
                            } else if (positionToScroll > self.coordinates[self.enabledSkater].max) {
                                // use slider's right border as a max position
                                positionToScroll = self.coordinates[self.enabledSkater].max;
                            }
                            // drag `skate` element if mouse/ finger pressed
                            self[self.enabledSkater].css('left', positionToScroll);
                        }
    ");
                WriteLiteral(@"                });

                    this.progressBar.on('click tap', function (e) {
                        self.progressBarSelection(e.pageX);
                    });
                };

                this.init = function () {
                    var self = this;
                    var progressBarContent = [];

                    if (this.options.mode === 'plain') {
                        self.options.data.size = 100;
                        self.options.data = [this.options.data];
                    }
                    // add specific class to slider to use its width below
                    self.selector.addClass('ds-container');
                    if (self.options.autocalculate && this.options.mode === 'categorized') {
                        RangeRover.autocalculateCategoriesSizes(self.options.data);
                    }

                    $.each(self.options.data, function (index, category) {
                        // set category's percent size and background co");
                WriteLiteral(@"lor to its div
                        var exludedValuesPlain = category.exclude ? RangeRover.getExcludedValuesPlain(category) : [];
                        var categoryContent = '<div class=""ds-category"" id=""' + category.timeId + '"" data-category=""' + (category.id || category.name) + '"" style=""width:' + category.size + '%;' + (category.color ? ('background:' + category.color) : '') + '""><span class=""ds-category-start"">' + category.start + '</span>';

                        var valuesCount = category.end - category.start - exludedValuesPlain.length;
                        // calculate category px width
                        var categoryWidth = self.selector.width() / 100 * category.size;
                        //  calculate value's px width
                        var valueWidth = categoryWidth / valuesCount;

                        var j = 0;

                        // set first element as a default
                        self.selected.start.value = category.start;
                     ");
                WriteLiteral(@"   self.selected.start.timeId = category.timeId;
                        if (self.options.mode === 'categorized') {
                            self.selected.start.category = (category.id || category.name);
                        }

                        for (var i = category.start; i < category.end; i++) {
                            j = i;
                            if (i + self.options.step - 1 > category.end) {
                                j = category.end;
                            }
                            if (~exludedValuesPlain.indexOf(i)) {
                                continue;
                            }

                            categoryContent += '<span class=""ds-item"" data-year=""' + j + '"" style=""width:' + (valueWidth * self.options.step) + 'px"">' + (self.options.vLabels && i != category.start && i != category.end ? i : '') + '</span>';
                            i = i + self.options.step - 1;
                        }
                        if (index === ");
                WriteLiteral(@"self.options.data.length - 1) {
                            categoryContent += '<span class=""ds-category-end"">' + category.end + '</span>';
                            if (self.options.range) {
                                self.selected.end = {};
                                self.selected.end.value = category.end;
                                if (self.options.mode === 'categorized') {
                                    self.selected.end.category = (category.id || category.name);
                                }
                            }
                        }
                        categoryContent += '</div>';
                        progressBarContent.push(categoryContent);
                    });

                    // put progressBar's with ranges, skate elements to container
                    var progressBarHtml = '<div class=""ds-skate""><span class=""ds-skate-year-mark"">' + self.selected.start.value + '</span></div><div class=""ds-progress"">' + progressBarContent.join(''");
                WriteLiteral(@") + ' </div>';

                    this.selector.html(progressBarHtml);
                    this.startSkate = this.selector.find('.ds-skate');

                    this.progressBar = this.selector.find('.ds-progress');
                    if (this.options.color) {
                        this.progressBar.css('background', this.options.color);
                    }
                    // prevent browser native drag
                    this.selector.attr(""ondragstart"", 'return false');
                    // calculate min left and max right coordinates to use as a border of slider
                    this.calculateAndSetCoordinates();
                    this.setEvendHandlers();
                };

                this.checkSelection = function (selectedPosition) {
                    var selectedValue, selectedCategory, selectedTimeId;
                    var self = this;
                    var isTriggeredFromProgressBar = !!selectedPosition;
                    var skateChanged = null;
");
                WriteLiteral(@"
                    if (isTriggeredFromProgressBar) {
                        if (!self.options.range) {
                            skateChanged = 'start';
                        }

                        self.startSkate.css('left', selectedPosition);
                        skateChanged = 'start';

                    } else {
                        if (!self[self.enabledSkater]) {
                            return;
                        }
                        selectedPosition = parseInt(self[self.enabledSkater].css('left'), 10);
                    }

                    // loop through all items to find selected one
                    if (!selectedValue) {
                        self.progressBar.find('.ds-item').each(function (index, item) {
                            item = $(item);
                            var itemLeftOffset = item.offset().left - self.selector.offset().left;
                            if (itemLeftOffset <= selectedPosition && itemLeftOffset + item.");
                WriteLiteral(@"width() > selectedPosition) {
                                selectedValue = +item.attr('data-year');
                                selectedCategory = item.parent().attr('data-category');
                                selectedTimeId = item.parent().attr('id');
                                return false;
                            }
                        });
                    }
                    skateChanged = skateChanged || (self.enabledSkater ? self.enabledSkater.split('Skate')[0] : null);
                    // update selectedValue and call onChange if selectedYear has been changed

                    if (selectedValue && selectedValue !== this.selected[skateChanged].value) {
                        self.selected[skateChanged].value = +selectedValue;

                        self.selected[skateChanged].timeId = selectedTimeId;

                        if (self.options.mode === 'categorized') {
                            self.selected[skateChanged].category = selectedCategor");
                WriteLiteral(@"y;
                        }
                        self.updateSelectedLabels();
                        if (self.options.onChange && typeof self.options.onChange === 'function') {
                            self.onChange();
                        }
                    }
                };

                this.onChange = function () {
                    this.options.onChange(this.selected);
                };

                this.progressBarSelection = function (pageX) {
                    this.checkSelection(pageX - $('.ds-container').offset().left);
                };

                this.updateSelectedLabels = function () {
                    this.updateCoordinates();
                    this.startSkate.children('.ds-skate-year-mark').html(this.selected.start.value);


                };

                this.updateCoordinates = function () {
                    if (this.options.range) {
                        this.coordinates.startSkate.max = this.selector.width() - thi");
                WriteLiteral(@"s.startSkate.width() - parseInt(this.startSkate.css('border-width'), 10)

                    }
                };

                this.calculateAndSetCoordinates = function () {
                    this.coordinates.startSkate.max = this.selector.width() - this.startSkate.width() - parseInt(this.startSkate.css('border-width'), 10);

                };

                this.select = function (year) {
                    if (year !== this.selectedYear) {
                        var yearElement = $('.ds-category-item[data-year=""' + year + '""]');
                        if (!yearElement.length) {
                            console.warn('RangeRover -> select: element `' + year + '` is not found.');
                            return this;
                        }
                        var leftPosition = yearElement.offset().left;
                        this.skate.css('left', leftPosition);
                        this.selectedYear = year;
                        this.updateSelectedYear();");
                WriteLiteral(@"

                        if (this.options.onChange && typeof this.options.onChange === 'function') {
                            this.onChange();
                        }
                    }
                    return this;
                }
            };

            RangeRover.autocalculateCategoriesSizes = function (categories) {
                var totalCount = categories.reduce(function (prev, next, index) {
                    if (index === 1) {
                        return (prev.end - prev.start) + (next.end - next.start);
                    } else {
                        return prev + (next.end - next.start);
                    }
                });
                return categories.map(function (e) {
                    e.size = 100 / totalCount * (e.end - e.start);
                });
            };

            RangeRover.getExcludedValuesPlain = function (category) {
                var plainYears = [];
                $.each(category.exclude, function (index, y");
                WriteLiteral(@") {
                    if (typeof y === 'object' && y.start && y.end) {
                        for (var i = y.start; i <= y.end; i++) {
                            plainYears.push(i);
                        }
                    } else {
                        plainYears.push(y);
                    }
                });
                return plainYears;
            };

            RangeRover.isArray = function (obj) {
                if (Object.prototype.toString.call(obj) === '[object Array]') {
                    return true;
                }
            };

            $.fn.extend({
                rangeRover: function (options) {
                    var slider = new RangeRover();
                    slider.options = $.extend(slider.options, options);

                    if (!slider.options.data || RangeRover.isArray(slider.options.data) && !slider.options.data.length) {
                        console.warn('RangeRover -> please provide data');
                        retu");
                WriteLiteral(@"rn;
                    }

                    if (slider.options.mode === 'plain' && (RangeRover.isArray(slider.options.data) || typeof slider.options.data != 'object')) {
                        console.warn('RangeRover -> `data` must be object in `plain` mode');
                        return;
                    }

                    if (slider.options.mode === 'categorized' && !RangeRover.isArray(slider.options.data)) {
                        console.warn('RangeRover -> `data` must be array in `categorized` mode');
                        return;
                    }

                    slider.selector = $(this);
                    slider.init();

                    if (options.onInit && typeof options.onInit === 'function') {
                        options.onInit();
                    }
                    return slider;
                }
            });
        })(jQuery);

    </script>

    <style>
        .ds-container {
            position: relative;
        }");
                WriteLiteral(@"

            .ds-container .ds-category-title::selection, .ds-container .ds-category-start::selection, .ds-container .ds-category-end::selection, .ds-container .ds-skate-year-mark::selection, .ds-item::selection {
                background: none;
            }

            .ds-container .ds-category-title::-moz-selection, .ds-container .ds-category-start-moz-::selection, .ds-container .ds-category-end-moz-::selection, .ds-container .ds-skate-year-mark::-moz-selection, .ds-item::moz-selection {
                background: none;
            }

        .ds-progress {
            width: 100%;
            height: 20px;
            margin-top: 20px;
            cursor: pointer;
        }

        .ds-skate {
            width: 10px;
            height: 40px;
            border: 4px solid red;
            position: absolute;
            top: -13px;
            cursor: pointer;
            z-index: 2;
        }

        .ds-end-skate {
            width: 10px;
            height: 40px;
");
                WriteLiteral(@"            border: 4px solid white;
            position: absolute;
            top: -13px;
            cursor: pointer;
            z-index: 2;
            right: 0
        }

        .ds-skate-year-mark {
            position: absolute;
            top: 47px;
            left: -10px;
        }

        .ds-category {
            position: relative;
            display: inline-block;
            z-index: 1;
            height: 100%;
        }

        .ds-item {
            height: 100%;
            display: inline-block;
            text-align: left;
            font-size: 12px;
        }

        .ds-category-title {
            display: inline-block;
            width: 100%;
            text-align: center;
        }

        .ds-category-start {
            position: absolute;
            margin-left: -15px;
            left: 0;
            top: 22px;
        }

        .ds-category-end {
            right: -15px;
            position: absolute;
            top");
                WriteLiteral(": 22px;\r\n        }\r\n    </style>\r\n");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(17480, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(17482, 242, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "43e4559d09a14bc9a1311e4336091d30", async() => {
                BeginContext(17488, 6, true);
                WriteLiteral("\r\n    ");
                EndContext();
                BeginContext(17495, 12, false);
#line 400 "C:\Users\Oksana\source\repos\HU\HU\Views\Shared\_Layout.cshtml"
Write(RenderBody());

#line default
#line hidden
                EndContext();
                BeginContext(17507, 210, true);
                WriteLiteral("\r\n\r\n<script src=\"../Scripts/MvcGrid/mvc-grid.js\"></script>\r\n<script>\r\n    [].forEach.call(document.getElementsByClassName(\'mvc-grid\'), function (element) {\r\n        new MvcGrid(element);\r\n    });\r\n</script>\r\n\r\n");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(17724, 9, true);
            WriteLiteral("\r\n</html>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
