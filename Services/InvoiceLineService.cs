using ShowInvoice.Models;
using ShowInvoice.Repo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShowInvoice.Services
{
    public class InvoiceLineService : IInvoiceLineService
    {
        private readonly IInvoicelineRepo _invoicelineRepo;

        public InvoiceLineService(IInvoicelineRepo invoicelineRepo)
        {
            _invoicelineRepo = invoicelineRepo;
        }

        public List<Invoiceline> GetAll()
        {
            return _invoicelineRepo.GetAll();
        }

        public List<Invoiceline> GetInvoicelinesByInvoiceId(Guid id)
        {
            return _invoicelineRepo.GetAll().Where(l => l.InvoiceId == id).ToList();
        }
    }
}
