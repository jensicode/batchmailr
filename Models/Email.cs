using System;
namespace batchmailr.Models
{
    public class Email
    {
        public int EmailId { get; set; }

        public string EmailSubject { get; set; }

        public string EmailHtmlContent { get; set; }
    }
}
