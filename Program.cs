
using System;

namespace Practice

{
    class clsPerson
    {
        public string FirstName;
        public string LastName;

        public string FullName()
        {
            return FirstName + " " + LastName;

        }

    }

    class clsEmployees
    {
        public string ID;
        public int Age;
        public string FullName;
    
    public void InsertData (string id  ,  int age  , string  fullname )
        {
            ID = id;
            Age  = age;
            FullName  = fullname;

        }
    public void PrinData ()
        {
            Console.WriteLine("ID       = {0}", ID);
            Console.WriteLine("Age      = {0}", Age);
            Console.WriteLine("FullName = {0}", FullName);

            Console.ReadKey();
        }
    
    
    
    }






    internal class Program
    {
        static void Main(string[] args)
        {
            clsPerson Person1 = new clsPerson();
            Console.WriteLine("Accessing Object 1 (Person1): ");
            Person1.FirstName = "Mohammed";
            Person1.LastName = "Ibrahim";
            Console.WriteLine(Person1.FullName());


            clsPerson Person2 = new clsPerson();
            Console.WriteLine("\nAccessing Object2 (Person2) :");
            Person2.FirstName = "Ali";
            Person2.LastName = "Maher";
            Console.WriteLine(Person2.FullName());

            Console.WriteLine("\n");
            Console.ReadKey();

            clsEmployees Employee1 = new clsEmployees();
            Employee1.InsertData(age: 30, fullname: "Mohammed Ibrahim", id: "004615250009");

            Employee1.PrinData();


        }


    }
}



