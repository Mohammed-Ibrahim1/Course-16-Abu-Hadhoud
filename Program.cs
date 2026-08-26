
using System;
using System.Runtime.InteropServices;
using System.Security;

namespace Practice
{
    public class clsA
    {
        public string Name { get; set; }

        public int Age { get; set; }

        public virtual void Printer()
        {
            Console.WriteLine("Name  = {0}", Name);
            Console.WriteLine("Age   = {0}", Name);
            Console.ReadKey();
        }

        public clsA(string name, int age)
        {
            Name = name;
            Age = age;
        }
    }

    public class clsB : clsA
    {
        public float Salary { get; set; }

        public string WorkingStaion { get; set; }

        public override void Printer()
        {
            Console.WriteLine("Salary             = {0}", Salary);
            Console.WriteLine("Working Station    = {0}", WorkingStaion);
            base.Printer();
        }

        public clsB(string name, int age, float salary, string workingStaion) : base(name, age)
        {
            Salary = salary;
            WorkingStaion = workingStaion;
        }
    }

    internal class Program

    {
        public static void Main(string[] args)
        {
            clsA A1 = new clsA("Mohammed", 19);

            clsB B1 = new clsB("Mohammed", 19, 200, "Hospital");
            B1.Printer();

            clsA A2 = new clsB("Mohammed", 19, 200, "Hospital");
            clsB B2 = (clsB)A2;

            B2.Printer();

        }





    }

}
