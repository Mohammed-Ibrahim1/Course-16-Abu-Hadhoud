
using System;
using System.IO.Pipes;
using System.Net.Cache;

namespace Practice

{

    static class clsPracticing
    {

        private static string _Name = string.Empty;

        public static int Age
        {
            get { return Age; }
            set { Age = value; }
        }

        public static string Name
        {
            get { return _Name; }
            set { _Name = value; }
        }


    }
    class clsPractice
    {
        private string _Name = string.Empty;
        private int _Salary = 0;
        private int _Age = 0;
        private string _ID  = string.Empty;

        public string Name
        {
           get {return _Name;}
           set{ _Name = value; }

        }
        public int Salary
        {
            get { return _Salary; }
            set { _Salary = value; }

        }
        public int Age
        {
            get { return _Age; }
            set { _Age = value; }
        }
        public string ID
        { 
            get { return _ID; }
            set { _ID = value; }
        }

    }





    internal class Program
    {


        int[] Persons = { 1, 2, 3, 3, 4, 5, 5, 6, 7 };

        int[] Age = new int[10];
        static void Main(string[] args)
        {
            clsPractice Practice1 = new clsPractice();
            Console.WriteLine("Practicing Set and Get Prpereties");

            Practice1.ID = "OF12311009DFG";
            Console.WriteLine("Please Enter Your Name ?");
            Practice1.Name = Console.ReadLine();

            Console.WriteLine("How Much Do you earn per month ?");
            string Salary = Console.ReadLine();

            Practice1.Age = 19;
            Practice1.Salary =  Convert.ToInt32(Salary);

            Console.WriteLine("Name   = {0}", Practice1.Name);
            Console.WriteLine("Salary = {0}", Practice1.Salary);
            Console.WriteLine("Age    = {0}", Practice1.Age);
            Console.WriteLine("ID     = {0}", Practice1.ID);

            clsPracticing.Age = 12;
            clsPracticing.Name = "Mohammed Ibrahim";

            Console.WriteLine("Static Class Practice");

            Console.WriteLine("Age = {0}", clsPracticing.Age);

        }


    }
}



