using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace session11_entityFramework_crud
{
    class Program
    {
        static void Main(string[] args)
        {
            //AddUpdateDeleteEntityConnectedMode();
            //AddUpdateDeleteEntityDisConnectedMode();
            //LinqToEntitiesQuery();
            //FindEntity();
            ExcuteRawSQLQueries();
        }

        private static void ExcuteRawSQLQueries()
        {
            Console.WriteLine("RawSQLQueries started");

            using (var context = new mySchooldbEntities())
            {
                context.Database.Log = Console.WriteLine;

                var studentList = context.Students.SqlQuery("select * from Students").ToList();
            }
        }
        private static void FindEntity()
        {
            Console.WriteLine("find an entity started");

            using (var context = new mySchooldbEntities())
            {
                context.Database.Log = Console.WriteLine;
                var student = context.Students.Find(69);

                Console.WriteLine($"{student.StudentName}");
            }
        }

        private static void LinqToEntitiesQuery()
        {
            Console.WriteLine("LinqToEntitits Query starts");

            using (var context = new mySchooldbEntities())
            {
                context.Database.Log = Console.WriteLine;

                //Retrive by Query Syntax
                var students = from s in context.Students
                                where s.StudentName == "Donald"
                                select s;

                foreach (var student in students)
                {
                    Console.WriteLine(student.StudentName);
                }

                Console.WriteLine("students with the same name");
                var studentsWithSameName = context.Students
                    .GroupBy(s => s.StudentName) // groups them by name
                    .Where(g => g.Count() > 1) // gives the groups that has more than 1 record
                    .Select(g => g.Key); // gives me the key for grouping the objects


                foreach (var student in studentsWithSameName)
                {
                    Console.WriteLine(student);
                }
            }
        }

        private static void AddUpdateDeleteEntityDisConnectedMode()
        {
            Console.WriteLine("Adding a new student in disconnected mode started");
            var newStudent = new Student() { StudentName = "new good student" };
            var existingStudent = new Student() { StudentID = 64, StudentName = "is update by me" };

            //Keep in mind if any exception happens during the transaction
            //all the transacation will be rollbacked and cancelled
            using (var context =  new mySchooldbEntities())
            {
                context.Database.Log = Console.WriteLine;


                context.Entry(existingStudent).State = existingStudent.StudentID == 0 ?
                    System.Data.Entity.EntityState.Added : System.Data.Entity.EntityState.Modified;

                context.Entry(newStudent).State = newStudent.StudentID == 0 ?
                    System.Data.Entity.EntityState.Added : System.Data.Entity.EntityState.Modified;

                
                context.SaveChanges();
            }
            Console.WriteLine("Adding a new student disconnected mode is finished");
        }

        public static void AddUpdateDeleteEntityConnectedMode()
        {
            Console.WriteLine("Adding a new student in connected mode started");

            using(var context = new mySchooldbEntities())
            {
                context.Database.Log = Console.WriteLine;
                //for insertion you need to add the entity into the list of 
                //objects and then save it
                var newStudent = context.Students.Add(new Student()
                {
                    StudentName = "Reza4",
                    StudentAddress= new StudentAddress()
                    {
                        Address1 = "address 12",
                        City = "Montreal"
                    },
                    Height = decimal.Parse("2.5")
                });

                context.SaveChanges();
                
                //for update you need to take the object and then modify it
                //and then save it back again
                newStudent.StudentName = "update name";
                context.SaveChanges();

                context.Students.Remove(newStudent);
                context.SaveChanges();
            }
        }
    }
}

