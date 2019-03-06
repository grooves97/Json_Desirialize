using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Net;
using Newtonsoft.Json;
using System.Runtime.Serialization;

namespace NetConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            RootObject temp = new RootObject();

            var client = new WebClient();            
            var json = client.DownloadString("http://hp-api.herokuapp.com/api/characters");
            var rootDeserialized = JsonConvert.DeserializeObject<RootObject[]>(json);

        }
    }
}

