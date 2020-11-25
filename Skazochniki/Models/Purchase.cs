using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Skazochniki.Models
{
    public class Purchase
    {
        public int PurchaseId { get; set; }

        public int CourseId { get; set; }

        public string FIO { get; set; }

        public string Email { get; set; }

        public string Payed { get; set; }

        public DateTime DateTime { get; set; }
    }
}