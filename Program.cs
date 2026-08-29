using System;

namespace Practice
{
 public interface IConstract
    {
      string FirstName { set; get; }
        string LastName { set; get; }

        void Printer(string Name , int age );

        void Greet();
    }


    public class clsEmployee : IConstract
    {
        public string FirstName { set; get; }
        public string LastName { set; get; }

        public void Printer(string Name, int age)
        {
            Console.WriteLine($"Hello Iam {Name} and Iam {age} Years Old");
        }

        public void Greet()
        {
            Console.WriteLine("Hello Every Body");
        }

    }



    internal class Program
    {
    static public void Main (string[] args)
        {
          clsEmployee employee = new clsEmployee {FirstName = "Mohammed" , LastName = "Ibrahim" };
            employee.Greet();

            employee.Printer("Mohammed Ibrahim", 18);
            Console.ReadKey();
        }
    
    
    }





}
