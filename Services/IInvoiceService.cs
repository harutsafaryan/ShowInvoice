using ShowInvoice.Models;
using System;
using System.Collections.Generic;

namespace ShowInvoice.Services
{
    public interface IInvoiceService
    {
        List<Invoice> GetInvoicesByUserId(Guid id);
        List<Invoice> GetAll();
    }
}