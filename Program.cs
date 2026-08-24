
using System;
using System.ComponentModel;

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
                return FirstName + " " + LastName;
            }
        }

        public clsPerson(int id  ,  string Firstname ,  string lastname  ,string title)
        {
            this.ID = id;
            this.FirstName =  Firstname;
            this.LastName = lastname;
            this.Title  = title;

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

        public clsEmployee (int id, string Firstname, string lastname, string title , float Salary ,string Departmentname )
            : base (id  ,  Firstname  , lastname , title)
        {
            this.Salary = Salary;
            this.DepartmentName = Departmentname;
        }
   
    }


    internal  class Program
    {
        static void Main ()
        {
            clsEmployee Employee1 = new clsEmployee (512,"Mohammed" , "Ibrahim"   ,"Mr" ,5000 , "IT");

            Console.WriteLine("ID             = {0}", Employee1.ID);
            Console.WriteLine("Full Name      = {0}", Employee1.FullName);
            Console.WriteLine("Salary         = {0}", Employee1.Salary);
            Console.WriteLine("DepartmentName = {0}", Employee1.DepartmentName);
            Console.WriteLine("Title          = {0}", Employee1.Title);

            Console.ReadKey();

        }
    }

}
