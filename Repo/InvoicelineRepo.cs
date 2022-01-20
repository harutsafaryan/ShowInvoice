using ShowInvoice.JsonManager;
using ShowInvoice.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShowInvoice.Repo
{
    public class InvoicelineRepo : IInvoicelineRepo
    {
        private readonly IJsonRead<Invoiceline> _userInvoicelineJson;

        public InvoicelineRepo(IJsonRead<Invoiceline> userInvoicelinJson)
        {
            _userInvoicelineJson = userInvoicelinJson;
        }
        public List<Invoiceline> GetAll()
        {
            return _userInvoicelineJson.Read(@"C:\Users\user\source\repos\ShowInvoice\Data\invoicelines.json");
        }
    }
}
