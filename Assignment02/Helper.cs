using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment02
{
    internal static class Helper
    {
        public static void RreverseQueue<T>(ref Queue<T> queue)
        {
            Stack<T> stack = new Stack<T>();


            while (queue?.Count > 0)
            {
                stack.Push(queue.Dequeue());
            }

            while (stack?.Count>0)
            {
                queue.Enqueue(stack.Pop());
            }
        }

        public static void PrintQueue<T>(Queue<T> queue)
        {
            foreach (var item in queue)
            {
                Console.WriteLine(item);
            }
        }
    }
}
