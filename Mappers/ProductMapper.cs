using ShowInvoice.Models;
using ShowInvoice.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShowInvoice.Mappers
{
    public static class ProductMapper
    {
        public static List<ProductViewModel> MapProductToVoewModel(this List<Product> products, Guid invoiceId, List<Invoiceline> invoicelines)
        {
            List<Product> takenProducts = new List<Product>();
            List<ProductViewModel> productMappers = new List<ProductViewModel>(invoicelines.Where(l => l.InvoiceId == invoiceId).Count());

            foreach (var item in invoicelines)
            {
                if (item.InvoiceId == invoiceId)
                    foreach (var product in products)
                    {
                        if (item.ProductId == product.ProductId)
                            takenProducts.Add(product);

                        productMappers.Add(new ProductViewModel()
                        {
                           Name = product.Name,
                           Price = product.Price,
                           Quantity = item.Quantity,
                           TotalAmount = product.Price * item.Quantity
                        });
                    }
            }
            return productMappers;
        }
    }
}
