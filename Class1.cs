using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp4
{
    class Stack : IStack
    {
        object[] data;
        public Stack()
        {
            data = null;
        }
        public void Push(object item)
        {
            if (data != null)
            {
                object[] temp = new object[data.Length];

                for (int i = 0; i < data.Length; i++)
                {
                    temp[i] = data[i];
                }

                data = new object[1];

                for (int i = 0; i < temp.Length; i++)
                {
                    data[i] = temp[i];
                }
            }
            else
            {
                data = new object[1];
            }
            data[data.Length - 1] = item;
        }
        public object Peek()
        {
            object item = null;
            try
            {
                if (data != null)
                {
                    item = data[data.Length - 1];
                }
            }
            catch
            {
                Console.WriteLine("Stack empty.");
            }
            return item;
        }
        public object Pop()
        {
            object item = null;
            if (data != null)
            {
                object[] temp = new object[data.Length - 1];

                for (int i = 0; i < data.Length - 1; i++)
                {
                    temp[i] = data[i];
                }

                item = data[data.Length - 1];

                data = new object[data.Length - 1];

                for (int i = 0; i < temp.Length; i++)
                {
                    data[i] = temp[i];
                }


            }
            return item;
        }




    }
}
