using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace session1_projects
{
    class Circle: Shape
    {
        string name;
        public Circle()
        {
            name = "Circle";
        }
        public override string ToString()
        {
            return name.ToString();
        }
    }
}
