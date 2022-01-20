using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShowInvoice.ViewModels
{
    public class InvoiceViewModel
    {
        public Guid InvoiceId { get; set; }
        public string Name { get; set; }
        public DateTime PaidDate { get; set; }
        public int TotalAmount { get; set; }
    }
}
