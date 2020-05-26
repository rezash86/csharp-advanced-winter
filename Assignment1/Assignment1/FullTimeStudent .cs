using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1
{
    class FullTimeStudent: Student
    {
        public FullTimeStudent(int studentId, string firstName, string lastName)
        {
            this.StudentId = studentId;
            this.FirstName = firstName;
            this.LastName = lastName;
        }
    }
}
