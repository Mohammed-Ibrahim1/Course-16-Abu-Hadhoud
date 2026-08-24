
using System;
namespace Practice
{
    class clsPerson
    { 
       public int ID { get; set; }
       public string Name { get; set; }

        public int Age { get; set; }

        public string UserName { get; set; }

        public string Password { get; set; }

        public clsPerson (int iD, string name, int age)
        {
            ID = iD;
            Name = name;
            Age = age;
           
        }




        public static clsPerson Find (int Id)
        {
            if (Id== 10)
            {
                return new clsPerson(10, "Mohammed", 18);
            }
            else
            {
                return null;
            }


        }
    }

internal class Program
    {
        static void Main (string[] args)
        {
            clsPerson Person1 = new clsPerson(612, "Mohammed Ibrahim", 18);

            Console.WriteLine("Finding Person 1 By ID");

            clsPerson Person2 = clsPerson.Find(10); 



            if (Person2 != null)
            {
                Console.WriteLine("ID   =  {0}", Person2.ID);
                Console.WriteLine("Name =  {0}" , Person2.Name);
                Console.WriteLine("Age  =  {0}", Person2.Age);

                Console.ReadKey();

            }

            else
            {
                Console.WriteLine("Could Not Find The Person By Giving ID");
            }





        }





    }





}