using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace session2_projects
{
    partial class MyPartialClass
    {
        public void Method2(int val)
        {
            Console.WriteLine(val);
        }

        partial void MyPartialMethod()
        {
            throw new NotImplementedException();
        }
    }
}
