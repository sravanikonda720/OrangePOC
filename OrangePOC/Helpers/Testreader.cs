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
        public static string workingDirectory = Environment.CurrentDirectory;
        public static string testdatapath = Directory.GetParent(workingDirectory).Parent.Parent.FullName + "\\Helpers\\Testdata.json";
        static String json = File.ReadAllText(testdatapath);
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
