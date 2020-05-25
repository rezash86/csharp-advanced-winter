using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace session2_projects
{
    partial class Reza
    {
        public void Method2(string name)
        {
            Console.WriteLine(name + "is being called in Method 2");
        }

        partial void PartialMethod()
        {
            Console.WriteLine("is being called in Partial Method");
        }


        public void ProxyMethod()
        {
            PartialMethod();
        }
    }
}
