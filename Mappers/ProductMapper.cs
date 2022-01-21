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
            List<ProductViewModel> productMappers = new List<ProductViewModel>(invoicelines.Count());

            Product temp = new Product();
            foreach (var item in invoicelines)
            {
                temp = products.FirstOrDefault(p => p.ProductId == item.ProductId);

                productMappers.Add(new ProductViewModel()
                {
                    Name = temp.Name,
                    Price = temp.Price,
                    Quantity = item.Quantity,
                    TotalAmount = temp.Price * item.Quantity
                });
            }
            return productMappers;
        }
    }
}
