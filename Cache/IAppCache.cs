using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShowInvoice.Cache
{
    public interface IAppCache
    {
        Dictionary<string, object> ViewBag { get; set; }
    }
}
