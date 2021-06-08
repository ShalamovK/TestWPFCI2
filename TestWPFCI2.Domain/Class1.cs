using log4net;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace TestWPFCI2.Domain
{
    public class Class1
    {
        private static readonly ILog log = LogManager.GetLogger(typeof(Class1));
        public string json = JsonConvert.SerializeObject(new Foo {
            A = "10"
        });
    }

    public class Foo {
        public string A { get; set; }
    }
}
