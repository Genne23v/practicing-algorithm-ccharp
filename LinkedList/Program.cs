using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedList
{
    class Program
    {
        static void main(string[] args)
        {
            LinkedList<string> linkedList = new LinkedList<string>();

            linkedList.AddLast("Sarah");
            linkedList.AddLast("Rebecca");
            linkedList.AddFirst("Jess");
            linkedList.AddFirst("Jackie");
            Console.WriteLine(linkedList.Contains("Jess"));
            Console.WriteLine(linkedList.Count);

            linkedList.RemoveFirst();

            foreach(string item in linkedList)
            {
                Console.Write(item + "->");
            }
            Console.WriteLine(); 
        }
    }
}
