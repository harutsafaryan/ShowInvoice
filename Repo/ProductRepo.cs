using ShowInvoice.JsonManager;
using ShowInvoice.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShowInvoice.Repo
{
    public class ProductRepo : IProductRepo
    {
        private readonly IJsonRead<Product> _productJson;
        public ProductRepo(IJsonRead<Product> productJso)
        {
            _productJson = productJso;
        }

        public List<Product> GetAll()
        {
            return _productJson.Read("products.json");
        }
    }
}
