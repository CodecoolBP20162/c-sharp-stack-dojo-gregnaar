using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stack_Dojo
{
    class Program
    {

        static void Main(string[] args)
        {
            //Just some testing, as i cant write tests :O
            Stack<int> mystack = new Stack<int>(5);
            mystack.Push(3);
            mystack.Push(4);
            mystack.Push(1);
            Console.WriteLine(mystack.GetSize());
            Console.WriteLine(mystack.FreeSpaceLeft());
            Console.WriteLine("--");
            Console.WriteLine(mystack.Pop());
            Console.WriteLine(mystack.Pop());
            Console.WriteLine(mystack.Pop());
            Console.WriteLine("--");
            mystack.Push(1);
            Console.WriteLine(mystack.Pop());
            Console.WriteLine("--");
            Console.WriteLine(mystack.FreeSpaceLeft());
            Console.ReadLine();
        }
    }
}
