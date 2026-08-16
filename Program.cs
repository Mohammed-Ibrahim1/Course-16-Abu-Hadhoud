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

            Console.ReadKey();


            }

        }
    }



