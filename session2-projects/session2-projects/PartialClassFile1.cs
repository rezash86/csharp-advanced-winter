using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace session2_projects
{
    partial class MyPartialClass
    {
        partial void MyPartialMethod();
        
        public MyPartialClass()
        {

        }

        public void Method1(int val)
        {
            Console.WriteLine(val);
        }
    }
}
