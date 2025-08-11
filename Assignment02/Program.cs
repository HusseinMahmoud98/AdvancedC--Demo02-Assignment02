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

            /* 3.Given a Queue, implement a function to reverse the elements of a queue using a stack. */
            int N;
            Queue<string> queue = new Queue<string>();


            do
            {
                Console.Write("Enter the size of the queueu N: ");
            } while (!int.TryParse(Console.ReadLine(), out N));



            //Enter the values of the queue
            for (int i = 0; i < N; i++)
            {
                Console.Write($"Enter the value of queueu[{i}] : ");
                queue.Enqueue(Console.ReadLine()??"");
            }

            Console.WriteLine("****Queueu before reversing****");
            Helper.PrintQueue(queue);

            Console.WriteLine("****Queueu after reversing****");
            Helper.RreverseQueue<string>(ref queue);
            Helper.PrintQueue(queue);








        }
    }
}
