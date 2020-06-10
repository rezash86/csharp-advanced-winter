using session1_projects.interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace session1_projects
{
    interface IPen: ITool
    {
        string Color { get; set; }
        bool Open();
        bool Close();
        void Write(string text);
    }
}
