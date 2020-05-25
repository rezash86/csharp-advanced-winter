using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace session2_projects
{
    class MyNoneStaticClass
    {
        public static int myStaticVariable = 0;

        static MyNoneStaticClass()
        {
            Console.WriteLine("inside static constuctor in the non static class");
        }

        public static void MyStaticMethod()
        {
            Console.WriteLine("this is a static method");
        }

        public void MyNoneStaticMethod()
        {
            Console.WriteLine("this is a non-static method");
        }

        public static int MyStaticProperty { get; set; }
    }
}
