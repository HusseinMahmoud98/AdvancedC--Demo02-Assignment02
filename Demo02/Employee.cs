using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo02
{
    internal class EmployeeCompareName : IComparer
    {
        public int Compare(object? x, object? y)
        {
            Employee e01 = x as Employee;
            Employee e02 = y as Employee;

            return e01.Name.CompareTo(e02.Name);
        }
    }

    internal class EmployeeCompareName<T> : IComparer<T> where T : Employee
    {
        public int Compare(T? x, T? y)
        {
            Employee e01 = (Employee)x;
            Employee e02 = (Employee)y;
            return e01.Name.CompareTo(e02.Name);
        }
    }


    internal class Employee : IComparable
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        public double Salary { get; set; }

        public int CompareTo(object? other)
        {
            Employee e = other as Employee;
            return this.Age.CompareTo(e.Age); 
        }

        public override string ToString()
        {
            return $"Id = {Id}, Name = {Name}, Age = {Age}, Salary = {Salary}";
        }
    }
}
