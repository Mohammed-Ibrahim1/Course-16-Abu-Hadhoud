using System;

namespace Main
{
   public interface IPerson
    {
       string FirstName { get; set; }
       string LastName { get; set; }
        string Phone { get; set; }
        string Email { get; set; }
        string ID { get; set; }
        int Age { get; set; }

        void PresentPersonalInfo();
    }

    public interface IEmployee
    {
 string EmployeeID  { get; set; }
    string WorkEmail { get; set; }

        float Salary { get; set; }

        string Workingstation { get; set; }
        void Introduce();
    }

    public class clsEmployee : IPerson, IEmployee
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public string ID { get; set; }
        public int Age { get; set; }

        public string EmployeeID { get; set; }
        public string WorkEmail { get; set; }
        public float Salary { get; set; }

        public string Workingstation { get; set; }
        public string FullName()
        {
            return FirstName + " " + LastName;
        }

        public void PresentPersonalInfo()
        {
            Console.WriteLine($"Hello My Name is {FullName()} and Iam {Age} Years Old");
            Console.WriteLine($"My Phone Number is {Phone} and My Email is {Email}");
        }


        public void Introduce()
        {
            Console.WriteLine($"I Work at {Workingstation} and I Earn {Salary} Per Month");
            Console.WriteLine($"My Working Email is {WorkEmail}");
        }

        public clsEmployee(string firstname  ,  string lastname  ,string email , string phone  ,  int age , string station 
            , string workingEmail  ,float salary , string id , string Empid)
        {
            FirstName = firstname; 
            LastName = lastname; 
            Phone = phone; 
            Email = email; 
            Phone = phone; 
            Age = age; 
            Workingstation = station; 
            WorkEmail = workingEmail;
            Salary = salary;
            ID = id;
            EmployeeID = Empid;
        }

    }

    internal class Program
    {
    static public void Main (string[] args)
        {
            clsEmployee Employee1 = new clsEmployee("Mohammed" , "Ibrahim"  ,"mohammasrabee@gmail.com" , "099-549-1570"  ,18,"University"
                , "hellenqqpp1122@gmail,com" ,5000 ,"512D" ,"223C");

            Console.WriteLine("Employee FullName = {0}", Employee1.FullName());
            Console.WriteLine("Employee Salary   = {0}", Employee1.Salary);

        }
    }

}