#pragma checksum "/Users/yener.ozturk/Projects/TicketWeb/Ticket.Presentation/Views/Home/Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "887434e60ab03b139c5d8c6e6b5eab7db77923d9"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"887434e60ab03b139c5d8c6e6b5eab7db77923d9", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b5b80179090756b5b3afa7471abe24d7f2ecc9ed", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/css/fullcalendar.bundle.css?v=7.0.4"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("rel", new global::Microsoft.AspNetCore.Html.HtmlString("stylesheet"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", new global::Microsoft.AspNetCore.Html.HtmlString("text/css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "1", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "2", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "3", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("form"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("name", new global::Microsoft.AspNetCore.Html.HtmlString("frmAppointment"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_8 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/js/fullcalendar.bundle.js?v=7.0.4"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "/Users/yener.ozturk/Projects/TicketWeb/Ticket.Presentation/Views/Home/Index.cshtml"
   ViewData["Title"] = "Home Page"; 

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "887434e60ab03b139c5d8c6e6b5eab7db77923d96717", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"

<script>

    function RefreshCalendar() {

        var el = document.getElementsByName(""UserId"");

        var userId = el[0].value;

        window.location.href = ""/Home/Index/"" + userId;

    }

</script>

<div class=""card card-custom"">
    <div class=""card-header"">
        <div class=""card-title"">
            <h3 class=""card-label"">
                Takvim
            </h3>
        </div>
        <div class=""card-toolbar"">
            <a href=""#"" onclick=""ClearForm()"" class=""btn btn-light-primary font-weight-bold"" data-toggle=""modal"" data-target=""#exampleModalScrollable"">
                <i class=""ki ki-plus ""></i> Yeni Kayıt
            </a>
        </div>
    </div>
    <div class=""card-body"">
        <div class=""row"">
            <div class=""col-lg-3 mb-lg-0 mb-6"">
                <label>Kullanıcı:</label>
                <select name=""UserId"" class=""form-control"" onchange=""RefreshCalendar()"">
                </select>
            </div>
        </div>
        <di");
            WriteLiteral(@"v id=""kt_calendar""></div>
    </div>
</div>



<!-- Modal-->
<div class=""modal fade"" id=""exampleModalScrollable"" tabindex=""-1"" role=""dialog"" aria-labelledby=""staticBackdrop"" aria-hidden=""true"">
    <div class=""modal-dialog modal-dialog-scrollable"" role=""document"">
        <div class=""modal-content"">
            <div class=""modal-header"">
                <h5 class=""modal-title"" id=""exampleModalLabel"">Yeni Kayıt</h5>
                <button type=""button"" class=""close"" data-dismiss=""modal"" aria-label=""Close"">
                    <i aria-hidden=""true"" class=""ki ki-close""></i>
                </button>
            </div>
            <div class=""modal-body"" style=""height: 700px;"">
                <div class=""col-lg-12"">
                    <div class=""card card-custom gutter-b example example-compact"">
                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "887434e60ab03b139c5d8c6e6b5eab7db77923d99885", async() => {
                WriteLiteral(@"
                            <div class=""card-body"">
                                <input type=""hidden"" name=""Id"" />
                                <div class=""form-group"">
                                    <label>Müşteri:</label>
                                    <select class=""form-control"" name=""CardCode"">
                                    </select>
                                </div>
                                <div class=""form-group"">
                                    <label>Başlık:</label>
                                    <input type=""text"" name=""Title"" class=""form-control form-control-solid"" placeholder=""Başlık"" />
                                </div>
                                <div class=""form-group"">
                                    <label>Açıklama:</label>
                                    <input type=""text"" name=""Description"" class=""form-control form-control-solid"" placeholder=""Açıklama"" />
                                </div>
                     ");
                WriteLiteral(@"           <div class=""form-group"">
                                    <label>Başlangıç Tarihi:</label>
                                    <input type=""text"" id=""StartDate"" class=""form-control form-control-solid"" placeholder=""Başlangıç Tarihi"" />
                                </div>
                                <div class=""form-group"">
                                    <label>Bitiş Tarihi:</label>
                                    <input type=""text"" id=""EndDate"" class=""form-control form-control-solid"" placeholder=""Başlangıç Tarihi"" />
                                </div>
                                <div class=""form-group"">
                                    <label>Event Type:</label>
                                    <select class=""form-control"" name=""AppointmentType"">
                                        ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "887434e60ab03b139c5d8c6e6b5eab7db77923d912106", async() => {
                    WriteLiteral("Ofis");
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
                WriteLiteral("\r\n                                        ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "887434e60ab03b139c5d8c6e6b5eab7db77923d913352", async() => {
                    WriteLiteral("Deactive");
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
                WriteLiteral("\r\n                                        ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "887434e60ab03b139c5d8c6e6b5eab7db77923d914602", async() => {
                    WriteLiteral("İzin");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_5.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n                                    </select>\r\n                                </div>\r\n                            </div>\r\n                        ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_6);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_7);
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
            <div class=""modal-footer"">
                <button type=""button"" class=""btn btn-light-primary font-weight-bold"" data-dismiss=""modal"">İptal</button>
                <button type=""button"" class=""btn btn-primary font-weight-bold"" onclick=""Save()"">Kaydet</button>
            </div>
        </div>
    </div>
</div>



");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "887434e60ab03b139c5d8c6e6b5eab7db77923d917510", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_8);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"


<script>

    function ClearForm() {

            $(""[name='Description']"").val('');
            RenderDateTimePicker('StartDate', '');
            RenderDateTimePicker('EndDate', '');
            $(""[name='Title']"").val('');
            $(""[name='Id']"").val(0);
    }



    var calendarElm;
    function Save() {

        var data = $('[name=""frmAppointment""]').serializeArray();

        var startDate = GetFormatedDate($(""#StartDate"").data(""datetimepicker"").getDate());

        var endDate = GetFormatedDate($(""#EndDate"").data(""datetimepicker"").getDate());

        data.push({ name:""StartDate"", value:startDate })
        data.push({ name:'EndDate', value:endDate });



        $.ajax({
            type: 'POST',
            url: 'Home/AddNewApp',
            data: data,
            success: function (result) {

                if (result.isUpdate) {

                    calendarElm.addEvent({
                        title: result.title,
                        descript");
            WriteLiteral(@"ion: result.description,
                        start: result.start,
                        end: result.end,
                        className: result.className
                    });
                }
                else {

                    var event = calendarElm.getEventById(result.id);
                    event.setProp('title', result.title);
                    event.setProp('description', result.description);
                    event.setStart(result.start);
                    event.setEnd(result.end);
                }

                $(""[name='Description']"").val('');
                RenderDateTimePicker('StartDate', '');
                RenderDateTimePicker('EndDate', '');
                $(""[name='Title']"").val('');
                $(""[name='Id']"").val(0);

            }
        });

    }


    var events = ");
#nullable restore
#line 175 "/Users/yener.ozturk/Projects/TicketWeb/Ticket.Presentation/Views/Home/Index.cshtml"
            Write(Html.Raw(Json.Serialize(ViewData["Events"])));

#line default
#line hidden
#nullable disable
            WriteLiteral(@";

    var KTCalendarBasic = function () {

        return {
            //main function to initiate the module
            init: function () {
                var todayDate = moment().startOf('day');
                var YM = todayDate.format('YYYY-MM');
                var YESTERDAY = todayDate.clone().subtract(1, 'day').format('YYYY-MM-DD');
                var TODAY = todayDate.format('YYYY-MM-DD');
                var TOMORROW = todayDate.clone().add(1, 'day').format('YYYY-MM-DD');

                var calendarEl = document.getElementById('kt_calendar');
                var calendar = new FullCalendar.Calendar(calendarEl, {
                    plugins: ['bootstrap', 'interaction', 'dayGrid', 'timeGrid', 'list'],
                    themeSystem: 'bootstrap',

                    isRTL: KTUtil.isRTL(),

                    header: {
                        left: 'prev,next today',
                        center: 'title',
                        right: 'dayGridMonth,timeGridWeek,timeGr");
            WriteLiteral(@"idDay'
                    },

                    height: 800,
                    contentHeight: 780,
                    aspectRatio: 3,  // see: https://fullcalendar.io/docs/aspectRatio

                    nowIndicator: true,
                    now: TODAY + 'T09:25:00', // just for demo

                    views: {
                        dayGridMonth: { buttonText: 'Ay' },
                        timeGridWeek: { buttonText: 'Hafya' },
                        timeGridDay: { buttonText: 'Gün' }
                    },

                    defaultView: 'dayGridMonth',
                    defaultDate: TODAY,

                    editable: true,
                    eventLimit: true, // allow ""more"" link when too many events
                    navLinks: true,
                    events: events,
                    locale:'tr',
                    eventDrop: function (info) {

                        var data = { Id: info.event.id, StartDate: info.event.start.toISOString(), EndDate:");
            WriteLiteral(@" info.event.end.toISOString() };

                        $.ajax({
                            type: 'POST',
                            url: 'Home/UpdateApp',
                            data: data,
                        });

                    },

                    eventClick: function (info) {

                        $.ajax({
                            type: 'GET',
                            url: '../../Home/GetAppointmentById',
                            data: { id: info.event.id },
                            success: function (data) {

                                RenderDateTimePicker('StartDate', data['startDate']);
                                RenderDateTimePicker('EndDate', data['endDate']);
                                $('[name=""Title""]').val(data['title']);
                                $('[name=""Description""]').val(data['description']);
                                $('[name=""AppointmentType""]').val(data['appointmentType']);
                            ");
            WriteLiteral(@"    $('[name=""CardCode""]').val(data['cardCode']);
                                $('[name=""Id""]').val(info.event.id);

                                $('#exampleModalScrollable').modal();

                            }
                        });




                    },

                    eventResize: function (info) {

                        var data = { Id: info.event.id, StartDate: info.event.start.toISOString(), EndDate: info.event.end.toISOString() };

                        $.ajax({
                            type: 'POST',
                            url: 'Home/UpdateApp',
                            data: data,
                        });

                    },

                    eventRender: function (info) {
                        var element = $(info.el);

                        if (info.event.extendedProps && info.event.extendedProps.description) {
                            if (element.hasClass('fc-day-grid-event')) {
                                el");
            WriteLiteral(@"ement.data('content', info.event.extendedProps.description);
                                element.data('placement', 'top');
                                KTApp.initPopover(element);
                            } else if (element.hasClass('fc-time-grid-event')) {
                                element.find('.fc-title').append('<div class=""fc-description"">' + info.event.extendedProps.description + '</div>');
                            } else if (element.find('.fc-list-item-title').lenght !== 0) {
                                element.find('.fc-list-item-title').append('<div class=""fc-description"">' + info.event.extendedProps.description + '</div>');
                            }
                        }
                    }
                });

                calendar.render();

                calendarElm = calendar;
            }
        };
    }();

    jQuery(document).ready(function () {

        KTCalendarBasic.init();

        FillDropDown(""/JsonObject/GetCustomersForDr");
            WriteLiteral("opDown\", \"CardCode\");\r\n\r\n        RenderDateTimePicker(\'StartDate\', \'\');\r\n        RenderDateTimePicker(\'EndDate\', \'\');\r\n\r\n        FillMultiDropDown(\"/JsonObject/GetUsersForDropDown\", \"UserId\",\"");
#nullable restore
#line 305 "/Users/yener.ozturk/Projects/TicketWeb/Ticket.Presentation/Views/Home/Index.cshtml"
                                                                  Write(ViewData["SelectedUserId"]);

#line default
#line hidden
#nullable disable
            WriteLiteral(@""");


        $(""#menuUser"").removeClass(""menu-item-open menu-item-here"");
        $(""#menuTicket"").removeClass(""menu-item-open menu-item-here"");
        $(""#menuCalendar"").removeClass(""menu-item-open menu-item-here"").addClass(""menu-item-open menu-item-here"");
        $(""#menuProject"").removeClass(""menu-item-open menu-item-here"");
        $(""#menuVersion"").removeClass(""menu-item-open menu-item-here"");
        $(""#menuCustomer"").removeClass(""menu-item-open menu-item-here"");
        $(""#menuReport"").removeClass(""menu-item-open menu-item-here"");


    });
</script>");
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
