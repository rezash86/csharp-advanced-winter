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

        static void Main(string[] args)
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
