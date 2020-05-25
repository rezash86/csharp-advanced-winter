using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace session2_projects
{
    class MyGenericConstraintClass<T> where T: class
    {
        private T genericVariable;

        public MyGenericConstraintClass(T value)
        {
            genericVariable = value;
        }

        public T genericMethod<U>(T genericParameter, U anotherGenericParameter) where U: struct
        {
            return genericVariable;
        }
    }
}
