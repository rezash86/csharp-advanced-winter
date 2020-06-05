using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinQExamples
{
    class Program
    {
        delegate bool IsYoungerThan(Student stud, int youngAge);

        delegate void Print();

        static void Main(string[] args)
        {
            IList<Student> studentList = new List<Student>()
            {
                new Student() {Id = 1 , Name = "John", Age = 13},
                new Student() {Id = 2 , Name = "Mo", Age = 19},
                new Student() {Id = 3 , Name = "bill", Age = 33},
                new Student() {Id = 4 , Name = "Ron", Age = 43},
            };
            //LambdaExample();
            //WhereExample();
            //OftypeExample();
            //OrderByExample(studentList);


            var thenByResult = studentList.OrderBy(s => s.Name).ThenBy(s => s.Age);

            var thenByDescResult = studentList.OrderBy(s => s.Name).ThenByDescending(s => s.Age);

        }


        public static void OrderByExample(List<Student> studentList)
        {
            //Query syntax
            var orderByResult = from s in studentList
                                orderby s.Name
                                select s;

            foreach (Student stud in orderByResult)
            {
                Console.WriteLine(stud.Name);
            }

            //methodsyntax
            Console.WriteLine("--------------------------");
            var studentInOrder = studentList.OrderBy(s => s.Name);
            foreach (Student stud in studentInOrder)
            {
                Console.WriteLine(stud.Name);
            }
        }
        public static void OftypeExample()
        {
            IList mixedList = new ArrayList();
            mixedList.Add(0);
            mixedList.Add("One");
            mixedList.Add("two");
            mixedList.Add(3);
            mixedList.Add(new Student() { Id = 1, Name = "Reza" });

            //Query syntax
            var stringResult = from s in mixedList.OfType<string>()
                               select s;

            var intResult = from s in mixedList.OfType<int>()
                            select s;

            //Method syntax
            var stringResult2 = mixedList.OfType<string>();

        }
        public static void WhereExample()
        {
            IList<Student> studentList = new List<Student>()
            {
                new Student() {Id = 1 , Name = "John", Age = 13},
                new Student() {Id = 2 , Name = "Mo", Age = 19},
                new Student() {Id = 3 , Name = "bill", Age = 33},
                new Student() {Id = 4 , Name = "Ron", Age = 43},
            };

            //query syntax
            var filteredResult = from s in studentList
                                 where s.Age > 12 && s.Age < 20
                                 select s.Name;

            foreach (string name in filteredResult)
            {
                Console.WriteLine(name);
            }

            Console.WriteLine("-------------------------");
            var filteredResult2 = from s in studentList
                                  where s.Age > 12 && s.Age < 20
                                  select s;

            foreach (Student std in filteredResult2)
            {
                Console.WriteLine(std.Name);
            }

            //Method syntax
            var filteredMethodSyntax = studentList.Where(s => s.Age > 12 && s.Age < 20);
        }
        public static void LambdaExample()
        {
            IsYoungerThan isYoungerThan = (s, youngAge) => s.Age < youngAge;

            Student student = new Student() { Id = 1, Age = 30, Name = "r" };

            Console.WriteLine(isYoungerThan(student, 25));


            Print print = () => Console.WriteLine("some thing");
            print();
        }
    }

    public class Student
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
    }
}
