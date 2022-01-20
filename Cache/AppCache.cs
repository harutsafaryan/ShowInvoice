using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShowInvoice.Cache
{
    public class AppCache   : IAppCache
    {
        public Dictionary<string, object> ViewBag { get; set; }
        public AppCache()
        {
            ViewBag = new Dictionary<string, object>();
        }
    }
}
