using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace session3_projects
{
    class Program
    {
        public delegate void Display(int n);
        public delegate int Operation(int x, int y);

        public delegate void PrintDelegate(int value);

        static void Main(string[] args)
        {
            //DelegateExample();
            //AnnonymousType();

            //Predicate
            Predicate<string> isUppper = IsUpperCase;
            bool result = isUppper("HHHHH!");
            Console.WriteLine(result);

            Predicate<string> isUpper2 = delegate (string str)
            {
                return str.Equals(str.ToUpper());
            };
            result = isUpper2("value test");

            Predicate<int> isOdd = IsOdd;
            result = isOdd(15);
        }
      
        static bool IsUpperCase(string str)
        {
            return str.Equals(str.ToUpper());
        }

        static bool IsOdd(int number)
        {
            return number % 2 == 0;
        }

        public static void AnnonymousType()
        {
            //Annonynmous method
            var person = new { id = 1, name = "A" };

            int i = 10;
            PrintDelegate print = delegate (int value)
            {
                //they have access to the outer variables
                value += i;
                Console.WriteLine("value is {0}", value);
            };

            PrintDelegate dddd = TEMP;

            print(100);
        }

        public static void TEMP(int val)
        {
            Console.WriteLine("value is {0}", val);
        }

        public static void DelegateExample()
        {
            Display display = new Display(PrettyPrint);
            display += Print;
            Operation operation = Product;


            Calculate(display, operation);

            DelegateExample2 example2 = new DelegateExample2();
            example2.UseDelegate();
        }

        private static void Calculate(Display display, Operation operation)
        {
            var a = int.Parse(Console.ReadLine());
            var b = int.Parse(Console.ReadLine());
            var result = operation(a, b);
            display(result);
            //display.Invoke(result);
        }

        private static int Sum(int a, int b)
        {
            return a + b;
        }

        private static int Product(int a, int b)
        {
            return a * b;
        }

        private static void Print(int n)
        {
            Console.WriteLine("result in normal print is " + n);
            Console.WriteLine();
        }

        private static void PrettyPrint(int n)
        {
            Console.WriteLine("---------------");
            Console.WriteLine("Result is " + n);
            Console.WriteLine("---------------");
            Console.WriteLine();
        }

    }
}
