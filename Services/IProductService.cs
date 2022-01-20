using ShowInvoice.Models;
using System;
using System.Collections.Generic;

namespace ShowInvoice.Services
{
    public interface IProductService
    {
        List<Product> GetProductsByInvoiceId(Guid id);
    }
}