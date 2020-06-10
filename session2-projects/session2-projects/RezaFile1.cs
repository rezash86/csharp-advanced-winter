using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace session2_projects
{
    partial class Reza
    {
        public Reza()
        {

        }

        partial void PartialMethod();
        public void Method1(string name)
        {
            Console.WriteLine(name + "is being called in Method 1");
        }
    }
}
