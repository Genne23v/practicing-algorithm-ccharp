using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Queue_Stack
{
    class Program
    {
        static void printBinary(int n)
        {
            if (n <= 0) return;

            Queue<int> queue = new Queue<int>();
            queue.Enqueue(1);
            for (int i=0; i<n; i++)
            {
                int current = queue.Dequeue();
                Console.WriteLine(current);
                queue.Enqueue(current * 10);
                queue.Enqueue(current * 10 + 1);
            }
            Console.WriteLine();
        }

        static void printNextGreaterElement(int[] arr)
        {
            if (arr.Length <= 0) return;

            Stack<int> stack = new Stack<int>();
            stack.Push(arr[0]);

            for (int i=1; i<arr.Length; i++)
            {
                int next = arr[i];
                if(stack.Count > 0)
                {
                    int popped = stack.Pop();

                    while (popped < next)
                    {
                        Console.WriteLine(popped + " --> " + next);
                        if (stack.Count == 0) break;
                        popped = stack.Pop();
                    }
                    if (popped > next)
                    {
                        stack.Push(popped);
                    }
                }
                stack.Push(next);
            }
            while(stack.Count > 0)
            {
                Console.WriteLine(stack.Pop() + " --> -1");
            }
        }

        static Boolean hasMatchingParentheses(string s)
        {
            Stack<char> stack = new Stack<char>();

            for (int i=0; i<s.Length; i++)
            {
                char current = s[i];

                if(current == '(')
                {
                    stack.Push(current);
                    continue;
                }
                if (current == ')')
                {
                    if (stack.Count > 0)
                    {
                        stack.Pop();
                    } 
                    else
                    {
                        return false;
                    }
                }
            }
            return stack.Count == 0;
        }

        static Boolean hasMatchingParentheses2(string s)
        {
            int matchingSymbolTracker = 0;

            for (int i = 0; i < s.Length; i++)
            {
                char current = s[i];

                if (current == '(')
                {
                    matchingSymbolTracker++;
                    continue;
                }
                if (current == ')')
                {
                    if (matchingSymbolTracker > 0)
                    {
                        matchingSymbolTracker--;
                    }
                    else
                    {
                        return false;
                    }
                }
            }
            return matchingSymbolTracker == 0;
        }

        static void Main(string[] args)
        {
            Console.WriteLine(hasMatchingParentheses("((hello()))"));
            Console.WriteLine(hasMatchingParentheses("()(hello())"));
            Console.WriteLine(hasMatchingParentheses("((hello)"));
            Console.WriteLine(hasMatchingParentheses(")hello)"));
            Console.WriteLine();
            Console.WriteLine(hasMatchingParentheses2("((hello()))"));
            Console.WriteLine(hasMatchingParentheses2("()(hello())"));
            Console.WriteLine(hasMatchingParentheses2("((hello)"));
            Console.WriteLine(hasMatchingParentheses2(")hello)"));


            int[] arr1 = new int[] { 15, 8, 4, 10 };
            int[] arr2 = new int[] { 2 };
            int[] arr3 = new int[] { 2, 3 };
            int[] arr4 = new int[] { };

            printNextGreaterElement(arr1);
            printNextGreaterElement(arr2);
            printNextGreaterElement(arr3);
            printNextGreaterElement(arr4);

            printBinary(5);
            printBinary(-2);
            printBinary(0);
            printBinary(2);
            printBinary(8);

            Queue<int> queue = new Queue<int>();
            queue.Enqueue(1);
            queue.Enqueue(8);
            queue.Enqueue(20);
            queue.Enqueue(23);

            int removed = queue.Dequeue();
            Console.WriteLine(removed);
            Console.WriteLine(queue.Dequeue());
            Console.WriteLine(queue.Peek());

            int current;
            /*while(queue.TryDequeue(out current))
            {
                Console.WriteLine(current);
            }*/

            Stack<string> stack = new Stack<string>();
            Console.WriteLine("Start Main");
            stack.Push("Main");
            Console.WriteLine("Start ResponseBuilder");
            stack.Push("ResponseBuilder");
            Console.WriteLine("Start CallExternalService");
            stack.Push("CallExternalService");
            Console.WriteLine("END " + stack.Pop());
            Console.WriteLine("Start ParseExternalData");
            stack.Push("ParseExternalData");
            Console.WriteLine("END " + stack.Pop());
            Console.WriteLine("END " + stack.Pop());
            Console.WriteLine("END " + stack.Pop());

            string item;
            //Console.WriteLine(stack.TryPeek(out item));
        }
    }
}
