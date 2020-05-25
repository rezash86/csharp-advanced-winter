using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace session2_projects
{
    class Program
    {
        static void Main(string[] args)
        {
            //StructCheck();
            //TaskStringBuilders();
            //CheckPartials()
            //CheckStatics()
            //MultiDimensionExample();
            //JaggedArrayExample()
            //TupleExamples()
            //ValueTupleExample()

            MyGenericClass<int> intGenericClass = new MyGenericClass<int>(45);
            int value = intGenericClass.genericMethod(200);
            //Type safety
            //intGenericClass.genericProperty = "TTTT";

            MyGenericClass<string> myGenericClass2 = new MyGenericClass<string>("Olivier");
            string value2 = myGenericClass2.genericMethod("Eve");

            MyGenericConstraintClass<Employee> myGenericConstraintClass = 
                new MyGenericConstraintClass<Employee>(new Employee());

            myGenericConstraintClass.genericMethod(new Employee(), 12);

        }

        class Employee
        {
            public string name;
        }

        public static void ValueTupleExample()
        {
            //valueTuple
            var person = (1, "Bill", "Gates");

            ValueTuple<int, string, string> person2 = (1, "Bill", "Gates");

            (int, string, string) person3 = (1, "Bill", "Gates");

            //Named Members
            (int id, string FirstName, string LastName) person4 = (1, "Tom", "Cruise");

            int personId = person4.id;
            string firstName = person4.FirstName;

            var person5 = (Id: 1, FirstName: "Tom", LastName: "Hanks");
            DisplayMemeber(person5);
        }

        public static void DisplayMemeber((int Id, string fName, string lName) p)
        {
            //Print the values
            string name = p.fName + p.lName;
        }

        public static void TupleExamples()
        {
            Tuple<int, string, string> person =
                new Tuple<int, string, string>(1, "James", "Bond");

            int id = person.Item1;
            string firstname = person.Item2;
            string lastname = person.Item3;

            var person2 = Tuple.Create(1, "James", "Bond");
            var person3 = Tuple.Create(1, "Toto", Tuple.Create("Montreal"));
        }
        static Tuple<int, string, string> DisplayTuple
            (Tuple<int, string, string> person)
        {
            Console.WriteLine($"id = {person.Item1}");

            return Tuple.Create(3, "A", "B");
        }

        public Tuple<bool, string> Login(Tuple<string, string> credentials)
        {
            return Tuple.Create(true, "successful login at " + DateTime.Now);
        }

        public static void JaggedArrayExample()
        {
            int[][] jArray1 = new int[2][]; //It can include two single-dimensional array
            int[][,] jArray2 = new int[3][,]; //It can include 3 2-dimensional array

            jArray1[0] = new int[] { 1, 2, 3 };
            jArray1[1] = new int[4] { 4, 5, 6, 7 };

            int[][] jArray11 = new int[2][]
            {
                new int[] { 1, 2, 3 },
                new int[4] { 4, 5, 6, 7 }
            };



            int[][][] jArray3D = new int[2][][]
            {
                new int[2][]
                {
                    new int[] { 1, 2, 3 },
                    new int[4] { 4, 5, 6, 7 }
                },
                new int[1][]
                {
                   new int[3]{7,8,9}
                }
            };

            //4 2-D array
            int[][,] jaggedArray4 = new int[4][,]
            {
                new int[,] { {1,3 },{ 5,7} },
                new int[,] { {6,2 }, { 4,6}, {8,10 } },
                new int[,] { {9,2 }, { 4,6}, {8,10 } },
                new int[,] { {5,2 }, { 4,6}, {8,10 } },
            };

            //display the values
            for (int i = 0; i < jaggedArray4.Length; i++)
            {
                int x = 0;
                for (int j = 0; j < jaggedArray4[i].GetLength(x); j++)
                {
                    //Rank is used to determine the total
                    //dimension of an array
                    for (int k = 0; k < jaggedArray4[j].Rank; k++)
                    {
                        Console.WriteLine("i = " + i + "j= " + j + "k=" + k
                            + "  " + jaggedArray4[i][j, k] + " ");
                    }
                    Console.WriteLine();

                }
                x++;
                Console.WriteLine();
            }
        }

        public static void MultiDimensionExample()
        {
            int[] nums = new int[]
            {
                1,2,3,5
            };

            string[] strArray = new string[6];
            strArray[0] = "TOTO";

            int[,] arr2D_1 = new int[3, 2]
            {
                {1,2},
                {3,4},
                {5,6}
            };

            int[,] arr2D_2 =
            {
                {1,2},
                {3,4},
                {5,6}
            };

            //GetLenght of dimension 0
            for (int i = 0; i < arr2D_1.GetLength(0); i++)
            {
                //GetLenght of dimension 1
                for (int j = 0; j < arr2D_1.GetLength(1); j++)
                {
                    Console.WriteLine("i= " + i + " and j=" + j + " value= " + arr2D_1[i, j]);
                }
            }

            int[,,] arr3d = new int[2, 2, 3]
            {
                { {1,2,3 }, {4,5,6 } },{{7,8,9 }, {10,11,12 } }
            };

            for (int i = 0; i < arr3d.GetLength(0); i++)
            {
                //GetLenght of dimension 1
                for (int j = 0; j < arr3d.GetLength(1); j++)
                {
                    for (int k = 0; k < arr3d.GetLength(2); k++)
                    {
                        Console.WriteLine("i= " + i + " and j= " + j + " and  k= " + k + " value = " + arr3d[i, j, k]);
                    }

                }
            }
        }
        public static void CheckStatics()
        {
            //static
            //Console.WriteLine(MyStaticClass.myStaticVariable);  //0
            //MyStaticClass.MyStaticMethod();

            //MyStaticClass.MyStaticProperty = 100;

            //Console.WriteLine(MyStaticClass.MyStaticProperty);

            //compile error
            //MyStaticClass myStaticClass = new MyStaticClass();

            MyStaticClass.myStaticVariable = 100;
            MyStaticClass.myStaticVariable = 200;
            MyStaticClass.myStaticVariable = 300;
            MyStaticClass.myStaticVariable = 400;


            MyNoneStaticClass myObj1 = new MyNoneStaticClass();
            MyNoneStaticClass myObj2 = new MyNoneStaticClass();
            MyNoneStaticClass myObj3 = new MyNoneStaticClass();
            MyNoneStaticClass myObj4 = new MyNoneStaticClass();
        }

        public static void CheckPartials()
        {
            MyPartialClass myPartialClass = new MyPartialClass();

            Reza reza = new Reza();
            reza.Method1("toto");
            reza.Method2("popo");

            reza.ProxyMethod();

            //No access modifiers or attributes are allowed. 
            //Partial methods are implicitly private.
            //It's a private method, so you can't call it by instantiation
            //reza.PartialMethod();
        }
        public static void TaskStringBuilders()
        {
            List<string> tempStrings = new List<string>();
            tempStrings.Add("A");
            tempStrings.Add("B");
            tempStrings.Add("C");
            tempStrings.Add("D");
            tempStrings.Add("E");

            StringBuilder builder = new StringBuilder();
            foreach(var item in tempStrings)
            {
                builder.Append(item + " ");
            }

            Console.WriteLine(builder);
        }

        public void StringbuildCheck()
        {
            //string and stringbuilder
            string s = "Hello world";
            s = "modified Hello world";

            StringBuilder builder = new StringBuilder("Hello world");
            builder.Append(" people");

            builder.AppendLine("\nwelcome to 2020");
            builder.AppendFormat("{0:C}", 50);

            builder.Insert(5, "JohnAbbott");
            //Stringbuilder is mutable=> you change the value in the memory by calling the methods
            //Always use stringbuilder instead of string in your projects

            Console.WriteLine(builder);
        }
        public void StructCheck()
        {
            Employee emp = new Employee();
            emp.EmpId = 2;

            //Compile error 
            //Employee emp2;
            //Console.WriteLine(emp2.EmpId);

            //Console.WriteLine(emp.EmpId);

            Employee emp31 = new Employee(1, "A1", "B1");
            Employee emp32 = new Employee(2, "A2", "B2");


            Car car1 = new Car("A", 2000, "Blue1");
            Car car2 = new Car("B", 2001, "Blue2");
            Car car3 = new Car("C", 2002, "Blue3");

            List<Car> carList = new List<Car>();
            carList.Add(car1);
            carList.Add(car2);
            carList.Add(car3);

            foreach (var item in carList)
            {
                Console.WriteLine(item);
            }

            //Compile Error because no instantiation
            //Car car4;
            //car4.Display();
        }
    }


    

    struct Employee
    {
        public int EmpId;
        public string FirstName;
        public string LastName;

        static Employee()
        {
            Console.WriteLine("First Object Created");
        }

        public Employee(int empId, string firstName, string lastName)
        {
            EmpId = empId;
            FirstName = firstName;
            LastName = lastName;
        }

    }

    struct Car
    {
        public string make;
        int year;
        string color;

        public Car(string make, int year, string color)
        {
            this.make = make;
            this.year = year;
            this.color = color;
        }

        public void Display()
        {

        }

        public override string ToString()
        {
            return $"make ={this.make} and year ={this.year} and color = {this.color}";
        }
    }
}
