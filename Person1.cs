using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Web.Script.Serialization;
using Newtonsoft.Json;

namespace JavascriptSerialization
{
    class Program1
    {
        public string name { get; set; }
        public int age { get; set; }
        public override string ToString()
        {
            return string.Format("Name:{0}\n Age:{1}", name, age);
        }
    }
    class Person1
    {
        static void Main(string[] args)
        {
            //deserialize json from file
            String JSONstring = File.ReadAllText(@"F:\BIZRUNTIME\Practice\json-csharp\JavascriptSerialization\JavascriptSerialization\json1.json");
            JavaScriptSerializer ser = new JavaScriptSerializer();
            Program1 p1 = ser.Deserialize<Program1>(JSONstring);//JSONstring is an object
            Console.WriteLine(p1);

            Program p2 = new Program() { name = "Srrrrrrrr", age =23456789 };
            string outputJSON = ser.Serialize(p2);
            File.WriteAllText("ex.json", outputJSON);
        }
    }
}
