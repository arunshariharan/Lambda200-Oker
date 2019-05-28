using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace LambdaOker
{
    public class FileReader
    {
        private const string fileName = "urls.json";

        public static List<string> GetUrlsFromFile()
        {
            using (StreamReader reader = new StreamReader(fileName))
            {
                var jsonString = reader.ReadToEnd();
                List<string> urls = new List<string>();

                foreach(var item in JObject.Parse(jsonString))
                {
                    urls.Add(item.Value.ToString());
                }

                return urls;
            }
        }
    }
}
