using System.Collections;
using System.Collections.Generic;

namespace Demo02
{
    internal class Program
    {
        public static void PrintArrayList(ArrayList arrayList)
        {
            Console.WriteLine();

            foreach (var item in arrayList)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine();
        }
        public static void PrintList<T>(List<T> values)
        {
            Console.WriteLine();

            foreach (var item in values)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine();
        }
        public static int SumList(List<int> values)
        {
            int Sum = 0;

            foreach (var item in values)
            {
                Sum += item;
            }

            return Sum;

        }
        public static void PrintLinkedList<T>(LinkedList<T> linkedList)
        {
            Console.WriteLine();
            Console.Write("null");
            foreach (var item in linkedList)
            {
                Console.Write($"<-{item}->");
            }
            Console.Write("null");
            Console.WriteLine();
        }
        public static void PrintStack(Stack<int> stack)
        {
            Console.WriteLine();
            foreach (var item in stack)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine();
        }
        public static void PrintQueue(Queue<int> queue)
        {
            Console.WriteLine();
            foreach (var item in queue)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine();
        }

        static void Main(string[] args)
        {

            #region ArrayList Part01 
            //ArrayList arrayList = new ArrayList();

            //Console.WriteLine($"Count = {arrayList.Count}, Capacity = {arrayList.Capacity}");

            //arrayList.Add(1);
            //Console.WriteLine($"Count = {arrayList.Count}, Capacity = {arrayList.Capacity}");

            //arrayList.Add(2);
            //arrayList.Add(3);
            //arrayList.Add(4);
            //arrayList.Add(5);
            //Console.WriteLine($"Count = {arrayList.Count}, Capacity = {arrayList.Capacity}");

            //ArrayList arrayList2 = new ArrayList(new int[] { 0, 1, 2, 3, 4 });
            //Console.WriteLine($"Count = {arrayList2.Count}, Capacity = {arrayList2.Capacity}");

            //ArrayList arrayList3 = new ArrayList(7);
            //Console.WriteLine($"Count = {arrayList3.Count}, Capacity = {arrayList3.Capacity}");

            //Console.WriteLine(arrayList.IsFixedSize); //false
            //Console.WriteLine(arrayList.IsReadOnly); //false

            //arrayList[1] = 10;
            //Console.WriteLine(arrayList[1]); //10

            //arrayList.AddRange(new[] { 70, 80, 90 });

            //PrintArrayList(arrayList);

            //arrayList.Clear();
            //Console.WriteLine($"Count = {arrayList.Count}, Capacity = {arrayList.Capacity}");

            //arrayList.Add(1);
            //arrayList.Add(2);
            //arrayList.Add(3);
            //arrayList.Add(4);

            //int[] arr = new int[4];
            ////arrayList.CopyTo( arr);


            ////foreach (var item in arr)
            ////{
            ////    Console.WriteLine(item);
            ////}

            ////ArrayList list = arrayList.GetRange(1, 3);
            ////foreach (var item in list)
            ////{
            ////    Console.WriteLine(item);
            ////}

            //Console.WriteLine(arrayList.IndexOf(2));

            //arrayList.Insert(0, 100);
            //arrayList.InsertRange(0, new int[] { 11, 22, 33 });
            //PrintArrayList(arrayList);

            //arrayList.Remove(100);
            //PrintArrayList(arrayList);

            //arrayList.RemoveAt(0);
            //PrintArrayList(arrayList);

            //arrayList.RemoveRange(0, 3);
            //PrintArrayList(arrayList);

            //arrayList.TrimToSize();
            //Console.WriteLine($"Count = {arrayList.Count}, Capacity = {arrayList.Capacity}");

            #endregion

            #region ArrayList Part02
            //Employee employee01 = new Employee() { Id = 1, Name = "Hussein", Salary = 12000, Age = 29 };
            //Employee employee02 = new Employee() { Id = 2, Name = "Mahmoud", Salary = 15000, Age = 30 };
            //Employee employee03 = new Employee() { Id = 3, Name = "Fouad", Salary = 30000, Age = 35 };
            //Employee employee04 = new Employee() { Id = 4, Name = "Mariam", Salary = 270000, Age = 32 };

            //ArrayList EmployeeList = new ArrayList();

            //EmployeeList.AddRange(new Employee[] { employee01, employee02, employee03, employee04 });

            //Console.WriteLine($"index = { EmployeeList.BinarySearch(employee01)}");

            //Console.WriteLine($"index = {EmployeeList.BinarySearch(new Employee() { Name = "Mariam"}, new EmployeeCompareName())}");

            //Console.WriteLine($"index = {EmployeeList.BinarySearch(0, 2 ,new Employee() { Name = "Hussein" }, new EmployeeCompareName())}");


            //PrintArrayList(EmployeeList); 
            #endregion

            #region List Part01
            //List<int> list = new List<int>();
            //list.Add(1);
            //list.Add(2);
            //list.Add(3);
            //list.Add(4);

            //Console.WriteLine(SumList(list));
            //PrintList(list);


            //Console.WriteLine(list.BinarySearch(3));


            //Console.WriteLine("============================");
            //Console.WriteLine(list.EnsureCapacity(10)); //10
            //Console.WriteLine(list.Capacity); //10

            //Console.WriteLine("============================");
            //List<int> list2 = list.GetRange(1, 3);

            //PrintList(list2);

            #endregion

            #region List Part02
            //Employee employee01 = new Employee() { Id = 1, Name = "Hussein", Salary = 12000, Age = 29 };
            //Employee employee02 = new Employee() { Id = 2, Name = "Mahmoud", Salary = 15000, Age = 30 };
            //Employee employee03 = new Employee() { Id = 3, Name = "Fouad", Salary = 30000, Age = 35 };
            //Employee employee04 = new Employee() { Id = 4, Name = "Mariam", Salary = 270000, Age = 32 };

            //List<Employee> EmployeeList = new List<Employee> { employee01, employee02, employee03, employee04 };

            //Console.WriteLine(EmployeeList.BinarySearch(employee01));            

            //Console.WriteLine($"index = {EmployeeList.BinarySearch(new Employee() { Name = "Mariam" }, new EmployeeCompareName<Employee>())}");

            #endregion

            #region LinkedList
            //LinkedList<int> list = new LinkedList<int>();
            //list.AddFirst(1);
            //list.AddFirst(2);
            //list.AddLast(3);

            //list.AddLast(new LinkedListNode<int>(30));

            //LinkedListNode<int> node = list.Find(2);

            //list.AddAfter(node, 90);


            //PrintLinkedList(list);

            //Console.WriteLine(list.First.Value);
            //Console.WriteLine(list.First.Next.Value); 
            #endregion

            #region Stack
            //Stack<int> stack = new Stack<int>();

            //stack.Push(1);
            //stack.Push(2);
            //stack.Push(3);
            //stack.Push(4);

            //PrintStack(stack);

            //Console.WriteLine(stack.Pop());
            //Console.WriteLine(stack.Peek());

            //stack.TryPeek(out int top);

            //Console.WriteLine(top); 
            #endregion

            #region Queue
            Queue<int> queue = new Queue<int>();

            queue.Enqueue(1);
            queue.Enqueue(2);
            queue.Enqueue(3);
            queue.Enqueue(4);

            Console.WriteLine(queue.Dequeue());
            Console.WriteLine(queue.Peek());


            PrintQueue(queue); 
            #endregion

        }
    }
}
