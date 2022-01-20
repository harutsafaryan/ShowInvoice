using ShowInvoice.Models;
using ShowInvoice.Repo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShowInvoice.Services
{
    public class ProductService : IProductService
    {
        private readonly IProductRepo _productRepo;
        private readonly IInvoicelineRepo _invoiceLineRepo;

        public ProductService(IProductRepo productRepo, IInvoicelineRepo invoicelineRepo)
        {
            _productRepo = productRepo;
            _invoiceLineRepo = invoicelineRepo;
        }

        public List<Product> GetProductsByInvoiceId(Guid id)
        {
            List<Guid> productsId = _invoiceLineRepo.GetAll()
                                                    .Where(l => l.InvoiceId == id)
                                                    .Select(p => p.ProductId)
                                                    .ToList();
            
            List<Product> products = new List<Product>(productsId.Count);
            foreach (var prouctId in productsId)
            {
                products.Add(_productRepo.GetAll().FirstOrDefault(p => p.ProductId == prouctId));
            }

            return products;
        }
    }
}
