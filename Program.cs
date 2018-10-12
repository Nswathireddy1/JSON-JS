using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Web.Script.Serialization;

namespace JavascriptSerialization
{
    class Program
    {
          public string name { get; set; }
          public int age { get; set; }
        public override string ToString()
        {
            return string.Format("Name:{0}\n Age:{1}",name,age);
        }
    }
    class Person
    {
        static void Main(string[] args)
        {
            //deserialize json from file
            String JSONstring = File.ReadAllText(@"F:\BIZRUNTIME\Practice\json-csharp\JavascriptSerialization\JavascriptSerialization\json1.json");
            JavaScriptSerializer ser = new JavaScriptSerializer();
            Program p1 = ser.Deserialize<Program>(JSONstring);//JSONstring is an object
            Console.WriteLine(p1);
        }
    }
}
