
using System;
using System.ComponentModel;
using System.Security.Cryptography.X509Certificates;

namespace AccessModifiers

{
    class clsEmployees
    {
        private int _ID;
        private string _Name = string.Empty;
        private string _Phone = string.Empty;

        private string _Email = "mohammasrabee@gmail.com";

        public int Salary 
            { get;
              set;
        }

        public int ID
        {
            get
            {
                return _ID;
            }
            set
            {
                _ID = value;

            }
        }

        public string Name

        {
            get
            {
                return _Name;
            }
            set
            {
                _Name = value;
            }
        }
        public string Phone
        {
            get
            {
                return _Phone;
            }
            set
            {
                _Phone = value;
            }

        }

        public string Email
        {
            get {return _Email; }
        }

    }
    internal class Program
    {
        static void Main(string[] args)
        {
         clsEmployees Employee1 = new clsEmployees();

            Employee1.ID = 512;
            Employee1.Name = "Mohammed Ibrahim";
            Employee1.Phone = "0995-491-570";
            Employee1.Salary = 1000;
        Console.WriteLine("Employee ID     = {0}", Employee1.ID);
        Console.WriteLine("Employee Name   = {0}", Employee1.Name);
        Console.WriteLine("Employee Phone  = {0}", Employee1.Phone);
        Console.WriteLine("Employee Email  = {0}", Employee1.Email);
        Console.WriteLine("Employee Salary = {0}", Employee1.Salary);
            Console.ReadKey();
                


                }

    }  

}
