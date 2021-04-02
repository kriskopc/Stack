using System;
// using System.Collections;  
namespace ConsoleApp4
{











    class Program
    {
        public static void Main()
        {
            Stack stack;
            stack = new Stack();

            stack.Push(34);

            object k;
            k = stack.Peek();
            Console.WriteLine(k);

            k = stack.Pop();
            Console.WriteLine(k);

            Console.WriteLine("---------");

            stack.Push(28);
            stack.Push(53);
            stack.Push(45);

            k = stack.Pop();
            Console.WriteLine(k);
            k = stack.Pop();
            Console.WriteLine(k);
            k = stack.Pop();
            Console.WriteLine(k);





        }
    }

}