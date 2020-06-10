using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace session2_projects
{
    class MyGenericClass<T>
    {
        private T genericMemberVariable;

        public MyGenericClass(T val)
        {
            genericMemberVariable = val;
        }

        public T genericMethod(T genericParameter)
        {
         
            return genericMemberVariable;
        }

        public T genericProperty { get; set; }
    }
}
