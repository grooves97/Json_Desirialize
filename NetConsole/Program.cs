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
            var jsonCharacters = client.DownloadString("http://hp-api.herokuapp.com/api/characters");
            var rootDeserializedFirst = JsonConvert.DeserializeObject<RootObject[]>(jsonCharacters);

            var jsonStudent = client.DownloadString("http://hp-api.herokuapp.com/api/characters/students");
            var rootDeserializedSecond = JsonConvert.DeserializeObject<RootObject[]>(jsonStudent);

            var jsonStaff = client.DownloadString("http://hp-api.herokuapp.com/api/characters/staff");
            var rootDeserializedThird = JsonConvert.DeserializeObject<RootObject[]>(jsonStaff);

            var jsonHomeGryffindor = client.DownloadString("http://hp-api.herokuapp.com/api/characters/house/gryffindor");
            var rootDeserializedFourth = JsonConvert.DeserializeObject<RootObject[]>(jsonHomeGryffindor);

        }
    }
}

