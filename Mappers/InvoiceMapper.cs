using ShowInvoice.Models;
using ShowInvoice.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShowInvoice.Mappers
{
    public static class InvoiceMapper
    {
        public static List<InvoiceViewModel> MapInvoiceToVoewModel(this List<Invoice> invoices, List<Invoiceline> invoicelines, List<Product> products)
        {
            List<InvoiceViewModel> invoiceMappers = new List<InvoiceViewModel>(invoices.Count);

            List<Invoiceline> currentInvoicelines = new List<Invoiceline>();
            List<Product> currentProducts = new List<Product>();
            foreach (var item in invoices)
            {
                currentInvoicelines = invoicelines.Where(l => l.InvoiceId == item.InvoiceId).ToList();

                int sum = 0;
                foreach (var line in currentInvoicelines)
                {
                    sum += line.Quantity * products.FirstOrDefault(p => p.ProductId == line.ProductId).Price;
                }

                invoiceMappers.Add(new InvoiceViewModel()
                {
                    InvoiceId = item.InvoiceId,
                    Name = item.Name,
                    PaidDate = item.PaidDate,
                    TotalAmount = sum
                }); ;
            }

            return invoiceMappers;
        }
    }
}
