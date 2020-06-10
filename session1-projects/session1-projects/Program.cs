using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace session1_projects
{
    class Program
    {
        //class Level does not accept var!

        static void Main(string[] args)
        {
            //TestVar();
            //CheckDefault();
            //Task1();
            //CheckDynamic()

            //PrintValue("Allo!");
            //PrintValue(100);
            //PrintValue(true);
            //PrintValue(DateTime.UtcNow);

            //IPen pen = new BluePen();
            //pen.Close();

            //IPen pen2 = new RedPen();
            //pen2.Close();


            
            ICalculate calculate = new RectangleCalculate();
            //downcasting
            Rectangle rectangle = (Rectangle)calculate.GetShape();

            Shape shape = new Circle();
            calculate.DisplayShape(shape);
  
        }

        static void PrintValue(dynamic val)
        {
            Console.WriteLine(val);
        }
        private void CheckDynamic()
        {
            //Dynamic type
            //At compile time, it will be resolved as integer
            var x = 6;

            //At Runtime, it will be resolved as integer
            dynamic dynamicVariable = 1;
            // object dynamicVariable

            Console.WriteLine("value = {0}, type={1}", dynamicVariable, dynamicVariable.GetType().ToString());

            dynamicVariable = "Hello !!!";
            Console.WriteLine("value = {0}, type={1}", dynamicVariable, dynamicVariable.GetType().ToString());

            dynamicVariable = true;
            Console.WriteLine("value = {0}, type={1}", dynamicVariable, dynamicVariable.GetType().ToString());

            dynamicVariable = DateTime.Now;
            Console.WriteLine("value = {0}, type={1}", dynamicVariable, dynamicVariable.GetType().ToString());

            dynamic dynamicAccount = new Account(6, DateTime.Now, 50000);
            //It will throw an exception because FakeDisplay is not there in the class 
            //dynamicAccount.FakeDisplay();
            dynamicAccount.Display();
        }
        private static void Task1()
        {
            //UnGeneric
            ArrayList listOfAccounts = new ArrayList()
            {
                new {AccountNumber = 1 , OpeningDate = DateTime.Now, Balance = 1000  },
                new {AccountNumber = 2 , OpeningDate = DateTime.Now.AddDays(-2), Balance = 2000  },
                new {AccountNumber = 3 , OpeningDate = DateTime.Now.AddDays(-20), Balance = 3000  },
                new {AccountNumber = 4 , OpeningDate = DateTime.Now.AddDays(-12), Balance = 4000  },
                new {AccountNumber = 5 , OpeningDate = DateTime.Now.AddDays(-200), Balance = 5000  },
            };

            foreach (var item in listOfAccounts)
            {
                Console.WriteLine(item.GetType().
                    GetProperty("AccountNumber").
                    GetValue(item) + "  " + item.GetType().
                    GetProperty("OpeningDate").
                    GetValue(item) + "  " + item.GetType().
                    GetProperty("Balance").
                    GetValue(item));
            }

            //Generic List
            List<Account> accounts = new List<Account>()
            {
                new Account(1, DateTime.Now, 1000),
                new Account(2, DateTime.Now, 2000),
                new Account(3, DateTime.Now, 3000),
            };

            foreach(var item in accounts)
            {
                Console.WriteLine(item.accountNumber+" " +item.openingDate + " " + item.balance);
            }

            
        }


        private void TestAnnonymous()
        {
            var student1 = new { Id = 1, FirstName = "Alex", LastName = "Verveill" };
            Console.WriteLine(student1.Id); //output = 1
            Console.WriteLine(student1.FirstName); //output = Alex
            Console.WriteLine(student1.LastName); //output = Verveill

            //Compile erro-> you cannot assign new values to the properties of annonymous type
            //student.Id = 2;
            //student.FirstName = "Olivier";

            var student2 = new
            {
                Id = 2,
                FirstName = "Kevin",
                LastName = "Bond",
                Address = new { Id = 1, City = "Montreal", Country = "Canada" }
            };

            string city = student2.Address.City;

            ArrayList valueTypes = new ArrayList()
            {
                new {Id = 1, name="x" },
                new {Id = 2, name="y" },
            };

            foreach (var item in valueTypes)
            {
                //I have access to each item
            }
            //Imagine that you fetch data from database from 2 tables
            //You don't want to create another class/variable to keep the data
            //and you want to show the data

            //Console/ =>convert to Json
            //If I want to pass an AnnonymousType to a method
            //you need to use class/struct
        }

        private static void TestVar()
        {
            var i = 10; //implicitly typed
            Console.WriteLine("Type of i {0}", i.GetType().ToString());

            var str = "Hello C#";
            Console.WriteLine("Type of str is {0}", str.GetType().ToString());

            var d = 100.50d;
            Console.WriteLine("Type of d is {0}", d.GetType().ToString());

            var b = true;
            Console.WriteLine("The type of b is {0}", b.GetType().ToString());

            //Loops foreach(var item in List)

            // it is wrong-compile error
            //var k;

            //usages
            // Local variable in a function => stack
            //For loop, foreach
            //Using statement => File opening, database connection opening
        }

        private void CheckDefault()
        {
            //Default values
            int d_i = default; // 0
            float d_f = default;// 0
        }

    }

    class Account
    {
        public int accountNumber;
        public DateTime openingDate;
        public double balance;

        public void Display()
        {
            Console.WriteLine("Account!!!!");
        }

        public Account(int accountNumber, DateTime openingDate, double balance)
        {
            this.accountNumber = accountNumber;
            this.openingDate = openingDate;
            this.balance = balance;
        }
    }
}
