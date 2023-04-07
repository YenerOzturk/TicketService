#pragma checksum "/Users/yener.ozturk/Projects/TicketWeb/Ticket.Presentation/Views/Customer/CustomerTickets.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "cce65bacd933a42ed31f2ac45cb983b6412c9418"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Customer_CustomerTickets), @"mvc.1.0.view", @"/Views/Customer/CustomerTickets.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"cce65bacd933a42ed31f2ac45cb983b6412c9418", @"/Views/Customer/CustomerTickets.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b5b80179090756b5b3afa7471abe24d7f2ecc9ed", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Customer_CustomerTickets : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "-1", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "1", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "2", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "3", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "4", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("selected", new global::Microsoft.AspNetCore.Html.HtmlString("selected"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("kt-form kt-form--fit mb-4"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("name", new global::Microsoft.AspNetCore.Html.HtmlString("frmTicket"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_8 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("form"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
<script>function GetSubTickets(ticketId) {

        $.ajax({
            type: 'GET',
            url: '../../Ticket/GetSubTicketsForCustomers',
            data: { ticketId: ticketId },
            success: function (data) {

                $('#subTickets').empty();

                if (data == """") {

                    Swal.fire(""Bilgilendirme!"", ""Alt İş Kaydı Bulunamadı."", ""info"");

                } else {
                    $('#subTickets').append(data);

                    $('#modalSubTicket').modal();
                }

            },
            error: function (xhr, ajaxOptions, thrownError) {
                Swal.fire(""Hata!"", ""Hata Oluştu."", ""error"");
            }
        });
    }

    function GetTicket(id) {

        $.ajax({
            type: 'GET',
            url: '../../Ticket/GetTicketById',
            data: { id: id },
            success: function (data) {

                var dsc = data.data.description;

                $(""[name='Description']"").val(dsc);

                $('#mod");
            WriteLiteral(@"alTicket').modal();
            }
        });
    }</script>
<style>
    .customCell{
        font-size:13px!important;
        padding:2px 2px 2px 2px!important;
    }
    .customButtonCell {
        font-size: 13px !important;
        padding: 2px 2px 2px 2px !important;
        text-align:center;
    }
    .modal-open {
        overflow-y: hidden!important;
    }
</style>





<div class=""card card-custom"">
    <div class=""card-header flex-wrap border-0 pt-6 pb-0"">
        <div class=""card-title"">
            <h3 class=""card-label"">
                Ticket Listesi
            </h3>
        </div>
    </div>
    <div class=""card-body"">

        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "cce65bacd933a42ed31f2ac45cb983b6412c94188026", async() => {
                WriteLiteral("\n            <input type=\"hidden\" id=\"CardCode\"");
                BeginWriteAttribute("value", " value=\"", 1773, "\"", 1802, 1);
#nullable restore
#line 75 "/Users/yener.ozturk/Projects/TicketWeb/Ticket.Presentation/Views/Customer/CustomerTickets.cshtml"
WriteAttributeValue("", 1781, ViewData["CardCode"], 1781, 21, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(@" />
            <div class=""row mb-6"">
                <div class=""col-lg-3 mb-lg-0 mb-6"">
                    <label>Ticket Id:</label>
                    <input type=""text"" class=""form-control datatable-input"" id=""Id"" data-col-index=""0"" />
                </div>
                <div class=""col-lg-3 mb-lg-0 mb-6"">
                    <label>Destek Tipi:</label>
                    <select class=""form-control datatable-input"" id=""SupportType"" data-col-index=""6"">
                        ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "cce65bacd933a42ed31f2ac45cb983b6412c94189236", async() => {
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
                WriteLiteral("\n                        ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "cce65bacd933a42ed31f2ac45cb983b6412c941810464", async() => {
                    WriteLiteral("Yerinde Destek");
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
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "cce65bacd933a42ed31f2ac45cb983b6412c941811702", async() => {
                    WriteLiteral("Telefon");
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
                WriteLiteral("\n                        ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "cce65bacd933a42ed31f2ac45cb983b6412c941812933", async() => {
                    WriteLiteral("Mail");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_3.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\n                        ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "cce65bacd933a42ed31f2ac45cb983b6412c941814161", async() => {
                    WriteLiteral("Uzaktan Destek");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_4.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
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
                    <label>Konu:</label>
                    <input type=""text"" class=""form-control datatable-input"" id=""Subject"" data-col-index=""0"" />
                </div>
                <div class=""col-lg-3 mb-lg-0 mb-6"">
                    <label class=""col-md-12"">Durum:</label>
                    <select multiple=""multiple"" class=""form-control datatable-input"" id=""Status"" data-col-index=""6"">
                        ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "cce65bacd933a42ed31f2ac45cb983b6412c941815930", async() => {
                    WriteLiteral("Açık");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_1.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\n                        ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "cce65bacd933a42ed31f2ac45cb983b6412c941817244", async() => {
                    WriteLiteral("Kapalı");
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
                WriteLiteral("\n                        ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "cce65bacd933a42ed31f2ac45cb983b6412c941818474", async() => {
                    WriteLiteral("Yeni Talep");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_4.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
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
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_6);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"

        <table class=""table table-bordered table-hover table-checkable"" id=""ticketList"" style=""width:100%"">
            <thead>
                <tr>
                    <th>Id</th>
                    <th>Atanan Kişi</th>
                    <th>Oluşturma Tarihi</th>
                    <th>Proje</th>
                    <th>Konu</th>
                    <th>Destek Tipi</th>
                    <th>Öncelik</th>
                    <th>Durum</th>
                    <th>#</th>
                    <th>#</th>
                </tr>
            </thead>
        </table>
       
    </div>
</div>

<div class=""modal fade"" id=""modalTicket"" data-backdrop=""static"" tabindex=""-1"" role=""dialog"" aria-labelledby=""staticBackdrop"" aria-hidden=""true"">
    <div class=""modal-dialog modal-dialog-centered modal-lg"" role=""document"">
        <div class=""modal-content"">
            <div class=""modal-header"">
                <h5 class=""modal-title"" id=""exampleModalLabel"">Ticket Detay</h5>
                <button type=""button"" class=");
            WriteLiteral(@"""close"" data-dismiss=""modal"" aria-label=""Close"">
                    <i aria-hidden=""true"" class=""ki ki-close""></i>
                </button>
            </div>
            <div class=""modal-body"">
                <div class=""card card-custom"">

                    <!--begin::Form-->
                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "cce65bacd933a42ed31f2ac45cb983b6412c941823022", async() => {
                WriteLiteral(@"

                        <div class=""card-body"">

                            <div class=""form-group row"">
                                <label class=""col-lg-2 col-form-label"">Açıklama</label>
                                <div class=""col-lg-10"">
                                    <textarea class=""form-control"" name=""Description"" data-provide=""markdown"" rows=""30""></textarea>
                                </div>
                            </div>

                        </div>
                    ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_7);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_8);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
                </div>
            </div>
        </div>
    </div>
</div>

<div class=""modal fade"" id=""modalSubTicket"" data-backdrop=""static"" tabindex=""-1"" role=""dialog"" aria-labelledby=""staticBackdrop"" aria-hidden=""true"">
    <div class=""modal-dialog modal-dialog-centered modal-lg"" role=""document"">
        <div class=""modal-content"">
            <div class=""modal-header"">
                <h5 class=""modal-title"" id=""exampleModalLabel"">Alt İşler</h5>
                <button type=""button"" class=""close"" data-dismiss=""modal"" aria-label=""Close"">
                    <i aria-hidden=""true"" class=""ki ki-close""></i>
                </button>
            </div>
            <div class=""modal-body"">
                <div class=""card card-custom"">
                    <div class=""card-body"" id=""subTickets"" style=""overflow: scroll;max-height:500px"">



                    </div>
                </div>
            </div>
        </div>
    </div>
</div>





<script>var table;
    $(document).ready(function () {

        $('");
            WriteLiteral(@"#Status').multiselect({
            enableFiltering: true,
            includeSelectAllOption: true,
            enableCaseInsensitiveFiltering: true,
            buttonWidth: '100%'
        });


        $(""#modalSubTicket"").on(""show.bs.modal"", function () {
            $(""body"").addClass(""modal-open"");
        }).on(""hide.bs.modal"", function () {
            $(""body"").removeClass(""modal-open"")
        });


        $(""#reload"").click(function () {
            table.ajax.reload();
        });

        $(""#menuReport"").removeClass(""menu-item-open menu-item-here"").addClass(""menu-item-open menu-item-here"");;
        $(""#menuUser"").removeClass(""menu-item-open menu-item-here"");
        $(""#menuTicket"").removeClass(""menu-item-open menu-item-here"");
        $(""#menuProject"").removeClass(""menu-item-open menu-item-here"");
        $(""#menuVersion"").removeClass(""menu-item-open menu-item-here"");
        $(""#menuCustomer"").removeClass(""menu-item-open menu-item-here"");
        $(""#menuCalendar"").removeClass(""menu-item-ope");
            WriteLiteral(@"n menu-item-here"");

        table = $('#ticketList').DataTable({
            dom: 'Bfrtip', //Excel export için frtip olması gerekiyor.
            ""select"": true,
            ""processing"": true,
            ""searching"": false,
            ""info"": false,
            ""paging"": false,
            ""serverSide"": true,
            ""ordering"": false,
            ""responsive"": true,
            buttons: [
                'copy',
                'excel',
                'csv',
                'pdf'
            ],
            columnDefs: [
                {
                    className: 'customButtonCell', targets: 7
                },
                {
                    className: 'customButtonCell', targets: 8
                },
                {
                    className: 'customButtonCell', targets: 9
                },
                {
                    className: 'customCell', targets: ""_all""
                }
               
            ],
            ""ajax"": {
                ""url"": ""../../Ticket/Ge");
            WriteLiteral(@"tTickets"",
                ""dataType"": ""JSON"",
                ""traditional"": true,
                ""data"": function (d) {
                    d.id = $('#Id').val();
                    d.statuList = $('#Status').val();
                    d.subject = $('#Subject').val();
                    d.supportType = $('#SupportType').val();
                    d.cardCodes = $('#CardCode').val();
                    d.pageLength = -1;
                }
            },
            ""columns"": [
                {
                    ""data"": ""id"",
                    ""autoWidth"": true,
                    
                },
                {
                    ""data"": ""createdUser"",
                    ""autoWidth"": true,
                },
                {
                    ""data"": ""createDateAsString"",
                    ""autoWidth"": true,
                },
                {
                    ""data"": ""projectName"",
                    ""autoWidth"": true,
                },
                {
                    ""dat");
            WriteLiteral(@"a"": ""subject"",
                    ""width"": '30%',
                },
                {
                    ""data"": ""supportType"",
                    ""autoWidth"": true,
                    ""render"": function (data, type, row) {

                        return '<span>' + data + '</span>';
                    }
                },
                {
                    ""data"": ""priority"",
                    ""autoWidth"": true,
                    ""render"": function (data, type, row) {

                        var cls = ""btn-primary btn-sm"";
                        var opts = """";

                        if (data == 1) {

                            cls = ""btn-primary btn-sm"";
                            opts = '<option value=""1"" selected>Düşük</option>' +
                                '<option value=""2"">Orta</option>' +
                                '<option value=""3"">Yüksek</option>';

                        }
                        else if (data == 2) {

                            cls = ""btn-warning btn");
            WriteLiteral(@"-sm"";
                            opts = '<option value=""1"">Düşük</option>' +
                                '<option value=""2"" selected>Orta</option>' +
                                '<option value=""3"">Yüksek</option>';
                        }
                        else {

                            cls = ""btn-danger btn-sm"";
                            opts = '<option value=""1"">Düşük</option>' +
                                '<option value=""2"">Orta</option>' +
                                '<option value=""3"" selected>Yüksek</option>';

                        }


                        return '<select class=""form-control selectpicker"" title=""Primary"" data-key=""' + row[""id""] + '"" id=""priority"" data-style=""' + cls + '"">' +
                            opts +
                            '</select>';

                    }
                },
                {
                    ""data"": ""status"",
                    ""autoWidth"": true,
                    ""render"": function (data, type, row) {

     ");
            WriteLiteral(@"                   if (data === ""YeniTalep"") {
                            return '<span class=""label label-danger label-pill label-inline mr-2"">Yeni</span>';
                        }
                        else if (data === ""Development"") {
                            return '<span class=""label label-warning label-pill label-inline mr-2"">Yazılımda</span>'
                        }
                        else if (data === ""Close"") {
                            return '<span class=""label label-dark label-inline mr-2"">Kapalı</span>'
                        } else {
                            return '<span class=""label label-info label-inline mr-2"">Açık</span>';
                        }
                    }
                },
                {
                    ""data"": ""id"",
                    ""render"": function (data, type, row) {
                        return '<a onclick=""GetTicket(' + data + ')"" class=""btn btn-dark btn-sm"">Detay</a>'
                    }
                },
                {
       ");
            WriteLiteral(@"             ""data"": ""id"",
                    ""render"": function (data, type, row) {

                        var subTicketCount = row[""subTicketCount""];

                        var retval = '<a onclick=""GetSubTickets(' + data + ')"" class=""btn btn-light btn-sm"">Alt İşler</a>';
                        if (subTicketCount > 0) {
                            retval = '<a onclick=""GetSubTickets(' + data + ')"" class=""btn btn-success btn-sm"">Alt İşler</a>';
                        }

                        return retval; 
                    }
                }
            ],
            ""initComplete"": function (settings, json) {
                $('.selectpicker').selectpicker();

                $('#ticketList thead th').removeClass('customCell');

                $('.selectpicker').on('changed.bs.select', function (e, clickedIndex, isSelected, previousValue) {

                    var ticketId = e.currentTarget.attributes[2].nodeValue;

                    var data = { Id: ticketId, Priority: clickedIndex };

 ");
            WriteLiteral(@"                   $.ajax({
                        type: 'POST',
                        url: '../../Ticket/UpdatePriority',
                        data: data,
                        success: function () {
                            table.ajax.reload();
                        },
                        error: function (xhr, ajaxOptions, thrownError) {
                            Swal.fire(""Hata!"", ""Hata Oluştu."", ""error"");
                        }
                    });


                });
            },
            ""drawCallback"": function (settings) {
                $('.selectpicker').selectpicker();

                $('.selectpicker').on('changed.bs.select', function (e, clickedIndex, isSelected, previousValue) {

                    var ticketId = e.currentTarget.attributes[2].nodeValue;

                    var data = { Id: ticketId, Priority: clickedIndex };

                    $.ajax({
                        type: 'POST',
                        url: '../../Ticket/UpdatePriority',
         ");
            WriteLiteral(@"               data: data,
                        success: function () {
                            table.ajax.reload();
                        },
                        error: function (xhr, ajaxOptions, thrownError) {
                            Swal.fire(""Hata!"", ""Hata Oluştu."", ""error"");
                        }
                    });


                });
            }

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
