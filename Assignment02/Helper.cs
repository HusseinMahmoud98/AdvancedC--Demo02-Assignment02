using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
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

        public static bool isBalanced(string? str)
        {
            if (str is not null)
            {
                char[] chars = str.ToCharArray();
                Stack<char> stack = new Stack<char>();

                foreach (var item in chars)
                {
                    if (item == '[' || item == '{' || item == '(')
                    {
                        stack.Push(item);
                    }

                    else if (item == ']' || item == '}' || item == ')')
                    {
                        switch (item)
                        {
                            case ']':
                                if (stack.Pop() != '[')
                                {
                                    return false;
                                }
                                break;
                            case ')':
                                if (stack.Pop() != '(')
                                {
                                    return false;
                                }
                                break;
                            case '}':
                                if (stack.Pop() != '{')
                                {
                                    return false;
                                }
                                break;
                            default:
                                continue;
                        }
                    }
                }
            }
            

            return true;
        }
    }
}
