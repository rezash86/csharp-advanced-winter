using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1
{
    class RegisterFullTime : IRegisterStudent
    {
        List<FullTimeStudent> listOfFullTimeStds = new List<FullTimeStudent>();
        public void getStudents()
        {
            foreach (var item in listOfFullTimeStds)
            {
                Console.WriteLine(item.ToString());
            }
        }

        public void Register(Student s)
        {
            listOfFullTimeStds.Add((FullTimeStudent)s);
        }
    }
}
