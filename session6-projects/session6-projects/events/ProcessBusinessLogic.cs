using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace session6_projects
{
    //declare a delegate
    //public delegate void Notify();
    //public delegate int CustomNotify(string a, int b);

    class ProcessBusinessLogic
    {
        //declare a variable of the delegate with event keyword
        //public event Notify processCompleted;
        public event Action processCompleted;

        //public event CustomNotify eventNotify;
        //Func<int, string, int> eventNotify;

        //Action Can be used when we have delegate void return type
        //Func<T> => delegate with return type and no parameters
        //Func<T1, T2, ...> => delegate with custom return type, custom paramter


        public void StartProcess()
        {
            Console.WriteLine("Process started");
            //some code here
            OnProcessCompleted();
        }

        private void OnProcessCompleted()
        {
            //int i = null;
            Nullable<int> j = null;
            int? jj = null;


            //this code can throw Null pointer exception
            
            if (processCompleted != null)
            {
                processCompleted.Invoke();
            }
            //or

            //If processCompleted is not null
            processCompleted?.Invoke();


        }
    }

    
}
