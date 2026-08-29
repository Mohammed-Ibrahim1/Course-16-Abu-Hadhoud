
using System;
using System.Diagnostics;

namespace Main
{
    public abstract class clsPerson
    {
       public string Name { get; set; }
        public int ID { get; set; }

        public abstract void Introduce();

        public void Greet ()
        {
            Console.WriteLine($"Hello I am {Name} and ID is {ID}");
        }
    }

    public class Employees  : clsPerson
    {
        public float Salary { get; set; }
        public string EmployeeID { get; set; }
        public override void Introduce()
        {
            Console.WriteLine($"I Earn {Salary} Per Month");
        }



    }

    internal class Program
    {
    public static void Main ()
        {
          // clsPerson Person1 = new clsPerson();

          Employees Employee1 = new Employees();

            Employee1.Name = "Mohammed";
            Employee1.Salary = 1000;
            Employee1.ID  =33141;
            Employee1.EmployeeID = "512D";


            Employee1.Greet();
            Console.ReadKey();
            Console.WriteLine("\n");

            Employee1.Introduce();
            Console.ReadKey();
        }
   
    
    }

}