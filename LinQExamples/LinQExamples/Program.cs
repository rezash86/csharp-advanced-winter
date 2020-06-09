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
                new Student() {Id = 3 , Name = "Sam", Age = 33},
                new Student() {Id = 4 , Name = "bill", Age = 33},
                new Student() {Id = 5 , Name = "Ron", Age = 43},
                new Student() {Id = 6 , Name = "Alex", Age = 33},
            };
            //LambdaExample();
            //WhereExample();
            //OftypeExample();
            //OrderByExample(studentList);
            //ThenByExample();
            //GroupByExample();
            //JoinExample();

            IList<int> intlist = new List<int> { 1, 2, 3, 4, 5 };
            bool result = intlist.Contains(10);


            IList<String> strList = new List<String>() { "one", "two", "three", "four", "five" };

            //seeding 
            string commaSeperatedString2 = studentList.Aggregate<Student, string>("student names : ", (str, s) => str += s.Name + ",");
            Console.WriteLine(commaSeperatedString2);

            var commaSeperatedString = strList.Aggregate((s1, s2) => s1 + ", " + s2);
            Console.WriteLine(commaSeperatedString);


            //Except
            IList<Student> list1 = new List<Student>()
            {
                new Student(){Id = 1, Name= "John", Age = 18},
                new Student(){Id = 2, Name= "Steve", Age = 15},
                new Student(){Id = 3, Name= "Bill", Age = 25},
                new Student(){Id = 5, Name= "Ron", Age = 19},

            };

            IList<Student> list2 = new List<Student>()
            {
                new Student(){Id = 3, Name= "Bill", Age = 25},
                new Student(){Id = 5, Name= "Ron", Age = 19}
            };

            var resultedColExcept = list1.Except(list2, new StudentComparer());

            foreach(Student std in resultedColExcept)
            {
                Console.WriteLine(std.Name);
            }

            Console.WriteLine("---------------");
            var resultedColInterSect = list1.Intersect(list2, new StudentComparer());

            foreach (Student std in resultedColInterSect)
            {
                Console.WriteLine(std.Name);
            }

            Console.WriteLine("---------------");
            var resultedColUnion = list1.Union(list2, new StudentComparer());

            foreach (Student std in resultedColUnion)
            {
                Console.WriteLine(std.Name);
            }
        }


        public static void AllandAnyExample()
        {

            IList<Student> studentList = new List<Student>()
            {
                new Student() {Id = 1 , Name = "John", Age = 13},
                new Student() {Id = 2 , Name = "Mo", Age = 19},
                new Student() {Id = 3 , Name = "Sam", Age = 33},
                new Student() {Id = 4 , Name = "bill", Age = 33},
                new Student() {Id = 5 , Name = "Ron", Age = 43},
                new Student() {Id = 6 , Name = "Alex", Age = 33},
            };

            //check if the students are teenager
            bool areAllStudentsTeenAger = studentList.All(s => s.Age > 12 && s.Age < 20);

            //similar to all
            //studentList.Any()
        }

        public static void selectExample()
        {

            IList<Student> studentList = new List<Student>()
            {
                new Student() {Id = 1 , Name = "John", Age = 13},
                new Student() {Id = 2 , Name = "Mo", Age = 19},
                new Student() {Id = 3 , Name = "Sam", Age = 33},
                new Student() {Id = 4 , Name = "bill", Age = 33},
                new Student() {Id = 5 , Name = "Ron", Age = 43},
                new Student() {Id = 6 , Name = "Alex", Age = 33},
            };

            //Query syntax
            var selectResult = from s in studentList
                                   //select s.Name;
                               select new { Name = "Mr." + s.Name, Age = s.Age };


            //Method syntax
            var selectedResult2 = studentList.Select(s => new { Name = s.Name, roomId = s.classroomId });
        }

        public static void JoinExample()
        {
            IList<string> strList1 = new List<string>()
            {
                "one",
                "two",
                "three",
                "four"
            };

            IList<string> strList2 = new List<string>()
            {
                "one",
                "two",
                "five",
                "six"
            };

            var innerjoin = strList1.Join( // outer sequence
                                            strList2, //inner sequence
                                            st1 => st1, // outer key selector
                                            st2 => st2,  //inner key selector
                                            (st1, st2) => st1); // result selector

            foreach (var str in innerjoin)
            {
                Console.WriteLine(str);
            }

            IList<Student> studentList4 = new List<Student>()
            {
                new Student(){ Id = 0, Name = "ttt0", Age = 13, classroomId = 1},
                new Student(){ Id = 1, Name = "ttt1", Age = 21, classroomId = 1},
                new Student(){ Id = 2, Name = "ttt2", Age = 18, classroomId = 2},
                new Student(){ Id = 3, Name = "ttt3", Age = 13, classroomId = 2},
                new Student(){ Id = 4, Name = "ttt4", Age = 40}
            };


            IList<ClassRoom> classRooms = new List<ClassRoom>()
            {
                new ClassRoom(){Id = 1, ClassName = "class 1"},
                new ClassRoom(){Id = 2, ClassName = "class 2"},
                new ClassRoom(){Id = 3, ClassName = "class 3"},
            };


            //method syntax
            var innerJoin2 = studentList4.Join(
                classRooms,
                student => student.classroomId,
                classroom => classroom.Id,
                (student, classroom) => new
                {
                    stdudentName = student.Name,
                    className = classroom.ClassName
                }
                );

            //Query syntax
            var innerJoin3 = from s in studentList4
                             join cl in classRooms
                             on s.classroomId equals cl.Id
                             select new
                             {
                                 stdudentName = s.Name,
                                 className = cl.ClassName
                             };

            foreach (var obj in innerJoin2)
            {
                Console.WriteLine("{0} - {1}", obj.stdudentName, obj.className);
            }
        }

        public static void GroupByExample()
        {
            IList<Student> studentList = new List<Student>()
            {
                new Student() {Id = 1 , Name = "John", Age = 13},
                new Student() {Id = 2 , Name = "Mo", Age = 19},
                new Student() {Id = 3 , Name = "Sam", Age = 33},
                new Student() {Id = 4 , Name = "bill", Age = 33},
                new Student() {Id = 5 , Name = "Ron", Age = 43},
                new Student() {Id = 6 , Name = "Alex", Age = 33},
            };

            var groupedResult1 = from s in studentList
                                 group s by s.Age;

            var groupedResult2 = studentList.GroupBy(s => s.Age);
            //iterate each group
            foreach (var ageGroup in groupedResult1)
            {
                Console.WriteLine("Age Group:{0}", ageGroup.Key);

                foreach (Student s in ageGroup)
                {
                    Console.WriteLine("Student Name:{0}", s.Name);
                }
            }

            var groupedResult3 = studentList.ToLookup(s => s.Age);
        }

        public static void ThenByExample()
        {
            IList<Student> studentList = new List<Student>()
            {
                new Student() {Id = 1 , Name = "John", Age = 13},
                new Student() {Id = 2 , Name = "Mo", Age = 19},
                new Student() {Id = 3 , Name = "bill", Age = 33},
                new Student() {Id = 4 , Name = "Ron", Age = 43},
            };

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

        public int classroomId { get; set; }
    }

    class StudentComparer : IEqualityComparer<Student>
    {
        public bool Equals(Student x, Student y)
        {
            if(x.Id == y.Id && x.Name.ToLower() == y.Name.ToLower()){
                return true;
            }
            return false;
        }

        public int GetHashCode(Student obj)
        {
            return obj.Id.GetHashCode();
        }
    }

    public class ClassRoom
    {
        public int Id { get; set; }

        public string ClassName { get; set; }
    }
}
