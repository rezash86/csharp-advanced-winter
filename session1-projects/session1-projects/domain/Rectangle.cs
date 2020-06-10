using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace session1_projects
{
    class Rectangle : Shape
    {
        string name;
        public Rectangle()
        {
            name = "Rectangle";
        }
        public override string ToString()
        {
            return name.ToString();
        }
    }
}
