using System;
using System.Collections.Generic;

namespace batchmailr.Models
{
    public class RecipientList
    {
        public int RecipientListId { get; set; }

        public string RecipientListName { get; set; }

        public List<Recipient> Recipients { get; set; }
    }
}
