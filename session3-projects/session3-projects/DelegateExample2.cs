using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace session3_projects
{
    class DelegateExample2
    {
        public delegate void MyDelegate(string message); //declare a delegate

        public void UseDelegate()
        {
            MyDelegate del = new MyDelegate(MethodA); //set target method
            //or
            MyDelegate del2 = MethodB;

            del("Hello- first time");
            //or
            del.Invoke("Hello-second time");

            InvokeDelegate(del2);


            MyDelegate combinedDel = del + del2;
            combinedDel += del;
            combinedDel.Invoke("my message");

        }

        public void InvokeDelegate(MyDelegate del)
        {
            del("Hello-in the invoke delegate method");
        }
        //target method
        static void MethodA(string mes1)
        {
            Console.WriteLine(mes1);
        }

        static void MethodB(string message2)
        {
            Console.WriteLine(message2);
        }
    }
}
