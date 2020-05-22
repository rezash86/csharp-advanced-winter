using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace session1_projects
{
    class BluePen : IPen
    {
        public string Color { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public bool Close()
        {
            //It does something
            Console.WriteLine("I am blue");
            return true;
        }

        public void Dosomething()
        {
            throw new NotImplementedException();
        }

        public bool Open()
        {
            throw new NotImplementedException();
        }

        public void Write(string text)
        {
            Console.WriteLine("I am blue and I am writing");
        }
    }
}
