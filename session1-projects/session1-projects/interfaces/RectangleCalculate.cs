using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace session1_projects
{
    class RectangleCalculate : ICalculate
    {
        public void DisplayShape(Shape shape)
        {
            Console.WriteLine(shape.ToString());
        }

        public Shape GetShape()
        {
            return new Rectangle();
        }
    }
}
