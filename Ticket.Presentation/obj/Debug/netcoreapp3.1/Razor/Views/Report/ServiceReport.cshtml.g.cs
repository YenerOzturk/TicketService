#pragma checksum "/Users/yener.ozturk/Projects/TicketWeb/Ticket.Presentation/Views/Report/ServiceReport.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "8d4f7d3206897b365a3e0884bf80873fdbd862ff"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Report_ServiceReport), @"mvc.1.0.view", @"/Views/Report/ServiceReport.cshtml")]
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
#line 1 "/Users/yener.ozturk/Projects/TicketWeb/Ticket.Presentation/Views/_ViewImports.cshtml"
using Ticket.Presentation;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "/Users/yener.ozturk/Projects/TicketWeb/Ticket.Presentation/Views/_ViewImports.cshtml"
using Ticket.Presentation.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8d4f7d3206897b365a3e0884bf80873fdbd862ff", @"/Views/Report/ServiceReport.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b5b80179090756b5b3afa7471abe24d7f2ecc9ed", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Report_ServiceReport : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("kt-form kt-form--fit mb-15"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("frmFilter"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"
<script>


    function RenderTable() {
        

        var data = $('#frmFilter').serializeArray();

        var startDate = GetFormatedDate($(""#StartDate"").datepicker('getDate'));

        var endDate = GetFormatedDate($(""#EndDate"").datepicker('getDate'));

        data.push({ name: ""StartDate"", value: startDate });

        data.push({ name: ""EndDate"", value: endDate });

        $.ajax({
            type: 'GET',
            url: '../Report/GetServiceReport',
            data: data,
            success: function (result) {

                var pivot = new WebDataRocks({
                    container: ""#output"",
                    toolbar: true,
                    report: {
                        dataSource: {
                            data: result
                        },
                        formats: [
                            {
                                ""name"": """",
                                ""decimalPlaces"": 4,
                            }
                        ],
          ");
            WriteLiteral(@"              slice: {
                            rows: [
                                {
                                    uniqueName: ""nameSurname"",
                                    caption:""Atanan Kişi""
                                },
                                {
                                    uniqueName: ""projectName"",
                                    caption:""Proje Adı""
                                },
                                {
                                    uniqueName: ""description"",
                                    caption:""Ticket Açıklama""
                                }
                            ],
                            columns: [
                                {
                                    ""uniqueName"": ""cardName"",
                                    caption: ""Cari Adı""
                                },
                                {
                                    ""uniqueName"": ""productName"",
                                    ca");
            WriteLiteral(@"ption: ""Ürün""
                                },
                                {
                                    ""uniqueName"": ""totalDays"",
                                    caption: ""Toplam Çalışma""
                                },
                            ],
                            measures: [
                                {
                                    ""uniqueName"": ""totalDays"",
                                    ""aggregation"": ""sum""
                                }
                            ],
                           
                        }
                    },
                    ""options"": {
                        ""grid"": {
                            ""type"": ""classic""
                        }
                    },
                    global: {
                        // replace this path with the path to your own translated file
                        localization: ""https://cdn.webdatarocks.com/loc/tr.json""
                    }
                });
            ");
            WriteLiteral(@"}
        });
    }

</script>

<div class=""card card-custom"">
    <div class=""card-header flex-wrap border-0 pt-6 pb-0"">
        <div class=""card-title"">
            <h3 class=""card-label"">
                Performans Raporu
            </h3>
        </div>
    </div>
    <div class=""card-body"">
        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "8d4f7d3206897b365a3e0884bf80873fdbd862ff7531", async() => {
                WriteLiteral(@"
            <div class=""row mb-6"">
                <div class=""col-lg-3 mb-lg-0 mb-6"">
                    <label>Başlangıç Tarihi:</label>
                    <input type=""text"" class=""form-control datetimepicker-input""  placeholder=""Tarih Seç"" id=""StartDate"" />
                   
                </div>
                <div class=""col-lg-3 mb-lg-0 mb-6"">
                    <label>Bitiş Tarihi:</label>
                    <input type=""text"" class=""form-control datetimepicker-input""  placeholder=""Tarih Seç"" id=""EndDate"" />
                    
                </div>
            </div>
            <div class=""row mt-8"">
                <div class=""col-lg-12"">
                    <button type=""button"" class=""btn btn-primary btn-primary--icon"" id=""reload"">
                        <span>
                            <i class=""la la-search""></i>
                            <span>Ara</span>
                        </span>
                    </button>&#160;&#160;
                    <button class=""btn btn-secondar");
                WriteLiteral(@"y btn-secondary--icon"" id=""kt_reset"">
                        <span>
                            <i class=""la la-close""></i>
                            <span>Temizle</span>
                        </span>
                    </button>
                </div>
            </div>
        ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
        <div id=""output"" style=""width:100%""></div>

    </div>
</div>

<script>var table;
    $(document).ready(function () {

        $(""#menuReport"").removeClass(""menu-item-open menu-item-here"").addClass(""menu-item-open menu-item-here"");;
        $(""#menuUser"").removeClass(""menu-item-open menu-item-here"");
        $(""#menuTicket"").removeClass(""menu-item-open menu-item-here"");
        $(""#menuCalendar"").removeClass(""menu-item-open menu-item-here"");
        $(""#menuProject"").removeClass(""menu-item-open menu-item-here"");
        $(""#menuVersion"").removeClass(""menu-item-open menu-item-here"");
        $(""#menuCustomer"").removeClass(""menu-item-open menu-item-here"");

        RenderDatePicker(""StartDate"", new Date(new Date().setMonth(new Date().getMonth() - 1)));
        RenderDatePicker(""EndDate"", new Date());

        RenderTable();

        $('#reload').on(""click"", function () {

            RenderTable();
        });
       
        
    })</script>



");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
