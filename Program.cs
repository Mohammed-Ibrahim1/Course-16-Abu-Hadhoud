

using System;
namespace Practicing
{
   public class clsPerson
    {   
    public string Name { get; set; }

    public int Age { get; set; }
    
        public void Greet ()
        {
            Console.WriteLine($"Hi , My Name is {Name} and I am {Age} years old");
        }
   
    
    }

    public class clsEmployee : clsPerson 
    {
        public string Company { get; set; }
        public int Salary { get; set; }
        
        public void Work ()
        {
            Console.WriteLine($"I work at {Company} and earn {Salary:C} per year");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {

            //UpCasting
            clsEmployee Employee1 = new clsEmployee { Name = "Mohammed", Age = 18, Salary = 0, Company = string.Empty };
            clsPerson Person1 = Employee1;
            Person1.Greet();
            Console.WriteLine("\n");
            Console.ReadKey();

            //DownCasting
            clsPerson person2 = new clsEmployee { Name = "Mohammed", Age = 18, Salary = 0, Company = string.Empty };
            clsEmployee Employee2 = (clsEmployee)person2;

            Employee2.Greet();
            Employee2.Work();

            clsPerson Person3 = new clsPerson { Name = "Mohammed", Age = 18 };
            clsEmployee Employee3 = (clsEmployee)Person3;

            Console.ReadKey();

        }


}
}
