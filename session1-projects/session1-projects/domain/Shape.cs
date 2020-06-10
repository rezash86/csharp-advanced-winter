using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace session1_projects
{
    class Shape
    {
        string name;
        public Shape()
        {
            name = "Shape";
        }

        public override string ToString()
        {
            return this.name.ToString();
        }
    }
}
