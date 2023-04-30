#pragma checksum "/Users/yener.ozturk/Projects/TicketWeb/Ticket.Presentation/Views/Report/TicketDetailReport.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "5812882555a36f951baf89d810b63c0b33d49735"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Report_TicketDetailReport), @"mvc.1.0.view", @"/Views/Report/TicketDetailReport.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5812882555a36f951baf89d810b63c0b33d49735", @"/Views/Report/TicketDetailReport.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b5b80179090756b5b3afa7471abe24d7f2ecc9ed", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Report_TicketDetailReport : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "0", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "1", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("kt-form kt-form--fit mb-15"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("frmFilter"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper;
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

        data.push({ name: ""CardCode"", value: $('#CardCode').val() });

        $.ajax({
            type: 'POST',
            url: '../Report/GetTicketDetailReport',
            traditional: true,
            data: data,
            success: function (result) {

                var pivot = new WebDataRocks({
                    container: ""#output"",
                    toolbar: true,
                    report: {
                        dataSource: {
                            data: result
                        },
                        ""options"": {
                            ""grid"": {
                                ""type"": ""flat""
        ");
            WriteLiteral(@"                    }
                        },
                        formats: [
                            {
                                ""name"": """",
                                ""decimalPlaces"": 4,
                            }
                        ],
                        slice: {
                            rows: [

                                /*{
                                    uniqueName: ""subTicketDetail"",
                                    caption: ""SubTicket Açıklama""
                                }*/
                            ],
                            columns: [
                                {
                                    uniqueName: ""workingBy"",
                                    caption: ""Danışman""
                                },
                                {
                                    uniqueName: ""owner"",
                                    caption: ""Talep Sahibi""
                                },
                                {
      ");
            WriteLiteral(@"                              uniqueName: ""ticketDetail"",
                                    caption: ""Ticket Açıklama""
                                },
                                {
                                    uniqueName: ""startDate"",
                                    caption: ""Tarih""
                                },
                                {
                                    uniqueName: ""subTicketDetail"",
                                    caption: ""SubTicket Açıklama""
                                },
                                {
                                    uniqueName: ""isRejected"",
                                    caption: ""İptal""
                                }
                            ],
                            measures: [
                                {
                                    ""uniqueName"": ""workDay"",
                                    caption: ""Toplam Çalışma (Gün)"",
                                    ""aggregation"": ""sum""
        ");
            WriteLiteral(@"                        },
                                {
                                    ""uniqueName"": ""workHour"",
                                    caption: ""Toplam Çalışma (Saat)"",
                                    ""aggregation"": ""sum""
                                }
                            ],

                        }
                    },
                    global: {
                        // replace this path with the path to your own translated file
                        localization: ""https://cdn.webdatarocks.com/loc/tr.json""
                    }
                });



            }
        });


        
    }

</script>

<div class=""card card-custom"">
    <div class=""card-header flex-wrap border-0 pt-6 pb-0"">
        <div class=""card-title"">
            <h3 class=""card-label"">
                Ticket Detay Raporu
            </h3>
        </div>
    </div>
    <div class=""card-body"">
        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "5812882555a36f951baf89d810b63c0b33d497359201", async() => {
                WriteLiteral(@"
            <div class=""row mb-6"">
                <div class=""col-lg-3 mb-lg-0 mb-6"">
                    <label>Başlangıç Tarihi:</label>
                    <input type=""text"" class=""form-control datetimepicker-input"" placeholder=""Tarih Seç"" id=""StartDate"" />

                </div>
                <div class=""col-lg-3 mb-lg-0 mb-6"">
                    <label>Bitiş Tarihi:</label>
                    <input type=""text"" class=""form-control datetimepicker-input"" placeholder=""Tarih Seç"" id=""EndDate"" />

                </div>
                <div class=""col-lg-3 mb-lg-0 mb-6"">
                    <label>Cari Kodu:</label>
                    <select class=""form-control datatable-input"" id=""CardCode"" data-col-index=""0"">
                        ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "5812882555a36f951baf89d810b63c0b33d4973510239", async() => {
                    WriteLiteral("Hepsi");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral(@"
                    </select>
                </div>
                <div class=""col-lg-3 mb-lg-0 mb-6"">
                    <label>Faturalandırıldı:</label>
                    <select multiple class=""form-control datatable-input"" name=""Billing"" id=""Billing"" data-col-index=""0"">
                        ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "5812882555a36f951baf89d810b63c0b33d4973511758", async() => {
                    WriteLiteral("Evet");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_1.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\n                        ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "5812882555a36f951baf89d810b63c0b33d4973512986", async() => {
                    WriteLiteral("Hayır");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_2.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral(@"
                    </select>
                </div>
                <div class=""col-lg-3 mb-lg-0 mb-6"">
                    <label>Proje:</label>
                    <select multiple class=""form-control datatable-input"" name=""ProjectIds"" id=""ProjectId"" data-col-index=""0"">
                        
                    </select>
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
                    <button class=""btn btn-secondary btn-secondary--icon"" id=""kt_reset"">
                        <span>
                            <i class=""la la-close""></i>
                            <span>Temizle</span>
                        </span>
                ");
                WriteLiteral("    </button>\n                </div>\n            </div>\n        ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
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


        $('#CardCode').change(function () {
            callback();
        });

        var callback = function () {

            var data = [];

            var cardCode = $('#CardCode').val();

      ");
            WriteLiteral(@"      data.push({ name: ""cardCode"", value: cardCode });

            FillMultiDropDown(""/JsonObject/GetProjectsForDropDown"", ""ProjectId"",""-1"");
        };


        FillMultiDropDown(""/JsonObject/GetCustomersForDropDown"", ""CardCode"", null,null, callback);

        $('#Billing').multiselect({
            enableFiltering: true,
            includeSelectAllOption: true,
            enableCaseInsensitiveFiltering: true,
            buttonWidth: '100%'
        });


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
