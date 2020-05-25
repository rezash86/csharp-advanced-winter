using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace session2_projects
{
    static class MyStaticClass
    {
        public static int myStaticVariable = 0;

        static MyStaticClass()
        {
            Console.WriteLine("inside static constuctor in the static class");
        }
        
        public static void MyStaticMethod()
        {
            Console.WriteLine("this is a static method");
        }

        

        //compile error
        //in a static class, you cannot have none static methods
        //public void MyNoneStaticMethod()
        //{
        //    Console.WriteLine("this is a non-static method");
        //}

        public static int MyStaticProperty { get; set; }
    }
}
