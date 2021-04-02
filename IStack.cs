using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp4
{
    interface IStack
    {
        void Push(object item);
        object Peek();
        object Pop();


    }
}
