using System;

namespace Main
{
    public class clsPerson
    {
        public string Name { get; set; }
        public int Id { get; set; }
        public int Age { get; set; }

        public void Greet()
        {
            Console.WriteLine($"Hello it is {Name} and my Id is {Id} and Iam {Age} Years Old");
        }
   
    }

public class clsEmployee : clsPerson
    {
        public string WorkingStation { get; set; }
        public float Salary { get; set; }

        public void Introducting ()
        {
            Greet();
            Console.WriteLine($"I Work at {WorkingStation} and i get {Salary} Per Month");
        }

    }

 internal class Program
    {
        public static void Main(string[] args)
        {
            clsEmployee Employee1 = new clsEmployee {WorkingStation = "Hostptal" , Salary = 500  ,Age = 20  ,Id = 1231 , Name = "Mohammed"  };
            clsPerson Person1 = Employee1;

            Person1.Greet();
            Console.ReadKey();
            Console.WriteLine("\n");


            Employee1.Introducting();
            Console.ReadKey();



            //DownCasting
            clsPerson Person2 = new clsEmployee { WorkingStation = "Clink", Salary = 5000, Age = 22, Id = 712, Name = "Ali" };
            Person2.Greet();
            Console.ReadKey();
            Console.WriteLine("\n");
            clsEmployee Employee3 = (clsEmployee)Person2;

            Employee3.Introducting();
            Console.ReadKey();

        }




    }





}
