using System;
using System.Collections;
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
        public static void PrintQueue(Queue queue)
        {
            foreach (var item in queue)
            {
                Console.WriteLine(item);
            }
        }
        public static void PrintArrayList(ArrayList arrayList)
        {
            foreach (var item in arrayList)
            {
                Console.WriteLine(item);
            }
        }
        public static void PrintList<T>(List<T> list)
        {
            foreach (var item in list)
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
        public static void removeDublicate(ref ArrayList arr)
        {
            if (arr is not null)
            {
                for (int i = 0; i < arr.Count; i++)
                {
                    for (int j = i+1; j < arr.Count - 1; j++)
                    {
                        if (arr[i].Equals(arr[j]))
                        {
                            arr.RemoveAt(j);
                        }
                    }

                }
            }
        }
        public static void removeOddNumbers(List<int> list)
        {
            bool isRemoved = false;
            for (int i = 0; i < list.Count; i++)
            {
               
                if (list[i] % 2 != 0)
                {
                    list.RemoveAt(i);
                    i--; //decrement 1 from i because the list count is decremented by 1
                } 
            }
            
        }
        public static int FindTarget(int startSeries, int endSeries, int target)
        {
            Stack<int> stack = new Stack<int>();
            int count = 0;

            for (int i = startSeries; i <= endSeries; i++)
            {
                stack.Push(i);
            }

            while (stack.Count > 0)
            {
                if (stack.Pop() == target)
                {
                    return count;
                }
            }

            return -1;
        }
        public static ArrayList FindIntersectionOfArrayList(ArrayList arrlist1, ArrayList arrlist2)
        {
            ArrayList result = new ArrayList();
            if (arrlist1 is not null && arrlist2 is not null)
            {
                

                for (int i = 0; i < arrlist1.Count; i++)
                {
                    for (int j = 0; j < arrlist2.Count; j++)
                    {
                        if (arrlist1[i].Equals(arrlist2[j]))
                        {
                            result.Add(arrlist1[i]);
                            arrlist1.RemoveAt(i);
                            arrlist2.RemoveAt(j);
                            i--;
                            break;

                        }
                    }
                }

            }
                       
        

            return result;
        }
        public static List<int> FindContigusSum(List<int> arrayList, int target)
        {
            
            List<int> result = new List<int>();

            for (int i = 0; i < arrayList?.Count; i++)
            {
                int Sum = 0;
                for (int j = i; j < arrayList?.Count ; j++)
                {
                    Sum += arrayList[j];

                    if (Sum>target)
                    {
                        result.Clear();
                        break;
                    }

                    else if (Sum == target)
                    {
                        result.Add(arrayList[j]);
                        return result;
                    }

                    else
                    {
                        result.Add(arrayList[j]);
                    }
                }
            }

            return new List<int>(); //return empty list if no sequence is found           
        }

        public static void ReverseFirstKQueueElements(Queue queue, int K)
        {
            if (queue?.Count > 0)
            {
                Stack stack = new Stack();
                Queue tempQueue = new Queue();


                for (int i = 0; i < K; i++)
                {
                    if (queue.Count > 0)
                    {
                        stack.Push(queue.Dequeue());
                    }
                }


                while (queue?.Count > 0)
                {
                    tempQueue.Enqueue(queue.Dequeue());

                }



                //now the required queue is empty
                //we will enqueue the stack first then the the tempqueue

                while (stack?.Count > 0)
                {
                    queue.Enqueue(stack.Pop());
                }

                while (tempQueue?.Count > 0)
                {
                    queue.Enqueue(tempQueue.Dequeue());

                }
            }
        }
    }
}
