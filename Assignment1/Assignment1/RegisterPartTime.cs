using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1
{
    class RegisterPartTime : IRegisterStudent
    {
        List<PartTimeStudent> listOfPartTimeStds = new List<PartTimeStudent>();
        public void getStudents()
        {
            foreach (var item in listOfPartTimeStds)
            {
                Console.WriteLine(item.ToString());
            }
        }

        public void Register(Student s)
        {
            listOfPartTimeStds.Add((PartTimeStudent)s);
        }
    }
}
