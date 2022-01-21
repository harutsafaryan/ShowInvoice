using ShowInvoice.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;

namespace ShowInvoice.JsonManager
{
    public class JsonRead<T> : IJsonRead<T>
    {
        public List<T> Read(string filename)
        {
            string strJson;
            using (FileStream stream = new FileStream(filename, FileMode.Open))
            {
                byte[] arr = new byte[stream.Length];
                stream.Read(arr, 0, arr.Length);
                strJson = System.Text.Encoding.Default.GetString(arr);
            }

            List<T> items = JsonSerializer.Deserialize<List<T>>(strJson);
            return items;
        }
    }
}
