using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShowInvoice.Models
{
    public class Invoice
    {
        public Guid InvoiceId { get; set; }
        public string Name { get; set; }
        public Guid UserId { get; set; }
        public DateTime PaidDate { get; set; }
    }               
}
