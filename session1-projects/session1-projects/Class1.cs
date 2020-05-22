using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace session1_projects
{
    class Class1
    {
        
        void mymethod()
        {
            var x = 10;
            List<int> list = new List<int>();
            list.Add(1);
            list.Add(2);
            list.Add(3);
            list.Add(4);

            foreach(var item in list)
            {
                Console.WriteLine(item.ToString());
            }
        }
    }
}
