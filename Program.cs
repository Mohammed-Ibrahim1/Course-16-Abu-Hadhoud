
using System;

namespace Practice
{

    // Base Class / Super Class

public class clsPerson
    {
        public int ID { get; set; }
        public string FirstName { get; set; }
    public string LastName { get; set; }
        public string Title { get; set; }

        public string FullName
        {
        get
            {
                return FirstName  +  " " + LastName;
            }
        }

    }

    //Sub Class  / Dervied Class
    public class clsEmployee :  clsPerson 
    {
    public float Salary { get; set; }
    public string DepartmentName { get; set; }
    
    public void IncreaseSalaryBy (float Amount)
        {
            Salary += Amount;
        }
   
    }


    internal  class Program
    {
        static void Main ()
        {
            clsEmployee Employee1 = new clsEmployee ();

            Employee1.FirstName = "Mohammed";
            Employee1.LastName = "Ibrahim";
            Employee1.Salary = 5000;
            Employee1.ID = 612;
            Employee1.DepartmentName = "IT";
            Employee1.Title = "Mr";



            Console.WriteLine("ID             = {0}", Employee1.ID);
            Console.WriteLine("Full Name      = {0}", Employee1.FullName);
            Console.WriteLine("Salary         = {0}", Employee1.Salary);
            Console.WriteLine("DepartmentName = {0}", Employee1.DepartmentName);
            Console.WriteLine("Title          = {0}", Employee1.Title);

            Console.ReadKey();

        }
    }

}
