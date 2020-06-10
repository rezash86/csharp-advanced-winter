using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1
{
    class Program
    {
        static void Main(string[] args)
        {

            IRegisterStudent registerFullTime = new RegisterFullTime();
            IRegisterStudent registerPartTime = new RegisterPartTime();

            registerFullTime.Register(new FullTimeStudent(1, "A", "AAA"));
            registerPartTime.Register(new PartTimeStudent(1, "B", "BBB"));
            

            registerPartTime.getStudents();
            registerPartTime.getStudents();
        }
    }
}
