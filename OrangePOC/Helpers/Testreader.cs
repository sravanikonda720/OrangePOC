using System.IO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace OrangePOC.Helpers
{
    internal class Testreader
    {

        static String json = File.ReadAllText(@"C:\Users\al4041\source\repos\OrangePOC\OrangePOC\Helpers\Testdata.json");
        dynamic data = JsonConvert.DeserializeObject(json);

        public string getURL()
        { 
        return data.URL;

        }

        public string getUserName() 
        
        { return data.UserName;
        
        }
        public string getPassword()

        {
            return data.Password;

        }

    }
}
