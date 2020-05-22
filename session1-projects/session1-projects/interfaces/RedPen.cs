using session1_projects.interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace session1_projects
{
    class RedPen : IPen
    {
        string IPen.Color { get => throw new NotImplementedException(); 
            set => throw new NotImplementedException(); }

        bool IPen.Close()
        {
            throw new NotImplementedException();
        }

        void ITool.Dosomething()
        {
            throw new NotImplementedException();
        }

        bool IPen.Open()
        {
            throw new NotImplementedException();
        }

        void IPen.Write(string text)
        {
            throw new NotImplementedException();
        }
    }
}
