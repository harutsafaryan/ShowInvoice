using ShowInvoice.JsonManager;
using ShowInvoice.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShowInvoice.Repo
{
    public class InvoiceRepo : IInvoiceRepo
    {
        private readonly IJsonRead<Invoice> _invoiceJson;
        public InvoiceRepo(IJsonRead<Invoice> invoiceJson)
        {
            _invoiceJson = invoiceJson;
        }

        public List<Invoice> GetAll()
        {
            return _invoiceJson.Read(@"C:\Users\user\source\repos\ShowInvoice\Data\invoices.json");
        }
    }
}
