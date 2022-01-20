using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShowInvoice.JsonManager
{
    public interface IJsonRead<T>
    {
        List<T> Read(string filename);
    }
}
