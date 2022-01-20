using Newtonsoft.Json;
using ShowInvoice.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace ShowInvoice.JsonManager
{
    public class JsonRead<T> : IJsonRead<T>
    {
        public List<T> Read(string filename)
        {
            using (StreamReader file = File.OpenText(filename))
            {
                JsonSerializer serializer = new JsonSerializer();
                List<T> items = (List<T>)serializer.Deserialize(file, typeof(List<T>));
                return items;
            }

            //using (FileStream stream = new FileStream(filename, FileMode.OpenOrCreate))
            //{
            //    List<T> items = JsonSerializer.Deserialize<List<T>>(stream);
            //    return items;
            //}

        }
    }
}
