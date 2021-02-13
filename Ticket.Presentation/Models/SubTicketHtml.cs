using System;
namespace Ticket.Presentation.Models
{
    public class SubTicketHtml
    {
        public static readonly string Html = "<div class=\"d-flex align-items-start list-item card-spacer-x py-4\" data-inbox=\"message\">" +
                                       "<div class=\"d-flex align-items-center\">" +
                                            "<div class=\"d-flex align-items-center mr-3\" data-inbox=\"actions\">" +
                                            "<span class=\"label label-light-{StatusColor} font-weight-bold label-inline\">{Status}</span>" +
                                            "</div>" +
                                        "</div>" +
                                        "<div class=\"flex-grow-1 mt-1 mr-2\" data-toggle=\"view\"  style=\"max-width: 370px;\">" +
                                            "<div class=\"mr-2\">{Description}</div>" +
                                            "<div class=\"mt-2\">" +
                                                "<b>Yetkili:</b> {UserName}" +
                                            "</div>" +
                                            "<div class=\"mt-2\">" +
                                                "<b>Başlangıç Tarihi:</b> {StartDate}" +
                                            "</div>" +
                                            "<div class=\"mt-2\">" +
                                                "<b>Bitiş Tarihi:</b> {EndDate}" +
                                            "</div>" +
                                            "[Attachment]"+
                                        "</div>" +
                                        "<div class=\"d-flex align-items-center justify-content-end flex-wrap\" data-toggle=\"view\">" +
                             "<a onclick=\"FillSubTicketForm({id})\" class=\"btn btn-icon btn-primary btn-sm\"><i class=\"flaticon2-pen\"></i></a>" +
                             "<a onclick=\"DeleteSubTicket({id},{ticketId})\" class=\"btn btn-icon btn-danger btn-sm\"><i class=\"flaticon2-trash\"></i></a>" +
                                                                        "</div>" +
                                    "</div>";
      
        
    }
}
