using System;
using ShowInvoice.Models;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShowInvoice.Repo
{
    public interface IInvoicelineRepo
    {
        List<Invoiceline> GetAll();
    }
}
