using ShowInvoice.Models;
using ShowInvoice.Repo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShowInvoice.Services
{
    public class InvoiceService : IInvoiceService
    {
        private readonly IInvoiceRepo _invoiceRepo;

        public InvoiceService(IInvoiceRepo invoiceRepo)
        {
            _invoiceRepo = invoiceRepo;
        }
        public List<Invoice> GetAll()
        {
            return _invoiceRepo.GetAll();
        }

        public List<Invoice> GetInvoicesByUserId(Guid id)
        {
            return _invoiceRepo.GetAll().Where(i => i.UserId == id).ToList();
        }
    }
}
