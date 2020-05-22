using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace session1_projects
{
    interface ICalculate
    {
        Shape GetShape();

        void DisplayShape(Shape shape);
    }
}
