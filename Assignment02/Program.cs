using System.Collections;

namespace Assignment02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Q01
            /* 1. Given an array  consists of  numbers with size N and number of queries,
                * in each query you will be given an integer X, and you should print how many numbers in array that is greater than  X.
                * Ex:
                * Input
                * 3 3 //Size of array , number of queries
                * 11 5 3 //Array
                * 1 //Query1
                * 5 //Query2
                * 13 //Query 3
                * Output
                * 3 //11,5,3
                * 1 //11
                * 0
                */

            //int[] arr;
            //int N, Q, X, countNumbers;


            //do
            //{
            //    Console.Write("Enter the size of the array N: "); 
            //} while (!int.TryParse(Console.ReadLine(), out N));

            //arr = new int[N];


            //do
            //{
            //    Console.Write("Enter the Number of queries : ");
            //} while (!int.TryParse(Console.ReadLine(), out Q));

            ////Enter the value of the array
            //for (int i = 0; i < arr.Length; i++)
            //{
            //    do
            //    {
            //        Console.Write($"Enter the the value of arr[{i}]: ");    
            //    } while (!int.TryParse(Console.ReadLine(), out arr[i]));
            //}

            ////Queries
            //for (int i = 0; i < Q; i++)
            //{
            //    countNumbers = 0;

            //    do
            //    {
            //        Console.Write("Enter the value of X: "); 
            //    } while (!int.TryParse(Console.ReadLine(), out X));

            //    for (int j = 0; j < arr.Length; j++)
            //    {

            //        if (arr[j] > X)
            //        {
            //            countNumbers++;
            //        }
            //    }

            //    Console.WriteLine(countNumbers);
            //} 
            #endregion

            #region Q02
            /* 2. Given a number N and an array of N numbers. Determine if it's palindrome or not.
                 * Ex:
                 * Input:
                 * 5
                 * 1 3 2 3 1
                 * Output:
                 * YES
                 */

            //int[] arr;
            //int N;
            //bool ispalindrome = true;

            //do
            //{
            //    Console.Write("Enter the size of the array N: ");
            //} while (!int.TryParse(Console.ReadLine(), out N));

            //arr = new int[N];

            ////Enter the values of the array
            //for (int i = 0; i < arr.Length; i++)
            //{
            //    do
            //    {
            //        Console.Write($"Enter the the value of arr[{i}]: ");
            //    } while (!int.TryParse(Console.ReadLine(), out arr[i]));
            //}

            //for (int i = 0; i < arr?.Length / 2; i++)
            //{
            //    if (arr[i] != arr[arr.Length - 1 - i])
            //    {
            //        ispalindrome = false;
            //        break;
            //    }
            //}

            //if (ispalindrome)
            //    Console.WriteLine("YES");

            //else
            //    Console.WriteLine("NO"); 

            #endregion

            #region Q03
            ///* 3.Given a Queue, implement a function to reverse the elements of a queue using a stack. */
            //int N;
            //Queue<string> queue = new Queue<string>();


            //do
            //{
            //    Console.Write("Enter the size of the queueu N: ");
            //} while (!int.TryParse(Console.ReadLine(), out N));



            ////Enter the values of the queue
            //for (int i = 0; i < N; i++)
            //{
            //    Console.Write($"Enter the value of queueu[{i}] : ");
            //    queue.Enqueue(Console.ReadLine()??"");
            //}

            //Console.WriteLine("****Queueu before reversing****");
            //Helper.PrintQueue(queue);

            //Console.WriteLine("****Queueu after reversing****");
            //Helper.RreverseQueue<string>(ref queue);
            //Helper.PrintQueue(queue); 
            #endregion

            #region Q04
            /*4. Given a Stack, implement a function to check if a string of parentheses is balanced using a stack.
                *   Ex:
                *   Input: [()]{}
                *   Output: Balanced
                */

            //Console.Write("Enter String: ");

            //string? str = Console.ReadLine();

            //if (Helper.isBalanced(str))
            //{
            //    Console.WriteLine("Balanced");
            //}

            //else
            //{
            //    Console.WriteLine("Unbalanced");
            //} 
            #endregion

            #region Q05

            /* 5.Given an array, implement a function to remove duplicate elements from an array. */
            //ArrayList arrList;
            //int N;

            //do
            //{
            //    Console.Write("Enter the size of the array N: ");
            //} while (!int.TryParse(Console.ReadLine(), out N));

            //arrList = new ArrayList(N);

            ////Enter the values of the array
            //for (int i = 0; i < N; i++)
            //{
            //    Console.Write($"Enter the array[{i}]: ");
            //    arrList.Add(Console.ReadLine());
            //}

            //Console.WriteLine("**** Array List before removing dublicate ****");
            //Helper.PrintArrayList(arrList);

            //Console.WriteLine("**** Array List after removing dublicate ****");
            //Helper.removeDublicate(ref arrList);
            //Helper.PrintArrayList(arrList);

            #endregion

            #region Q06
            ///* 6. Given an array list , implement a function to remove all odd numbers from it. */

            //List<int> list;
            //int capacity, value;

            //do
            //{
            //    Console.Write("Enter the capacity of the list: ");
            //} while (!int.TryParse(Console.ReadLine(), out capacity));

            //list = new List<int>(capacity);

            ////Enter the values of the list
            //for (int i = 0; i < capacity; i++)
            //{
            //    do
            //    {
            //        Console.Write($"Enter the the value of list[{i}]: ");
            //    } while (!int.TryParse(Console.ReadLine(), out value));

            //    list.Add(value);
            //}

            //Console.WriteLine("**** List of numbers before removing odd numbers ****");
            //Helper.PrintList(list);

            //Console.WriteLine("**** List of numbers after removing odd numbers ****");
            //Helper.removeOddNumbers(list);
            //Helper.PrintList(list); 
            #endregion

            #region Q07
            /* 7. Implement a queue that can hold different data types. 
                 *    And insert the following data:
                 *    queue.Enqueue(1)
                 *    queue.Enqueue(“Apple”)
                 *    queue.Enqueue(5.28)
                 */

            Queue queue = new Queue();
            queue.Enqueue(1);
            queue.Enqueue("Apple");
            queue.Enqueue(5.28);

            while (queue.Count > 0)
            {
                Console.WriteLine(queue.Dequeue());
            } 
            #endregion



        }
    }
}
