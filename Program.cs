using System;
using System.ComponentModel;

namespace Practice
{
    class clsPractice
    {
        private string _Name;
        private string _Phone;

        public string Name
        {
            get { return _Name; }
            set { _Name = value; }
        }

        public string Phone
        {
            get { return _Phone; }
            set { _Phone = value; }
        }


        public int Age
        {
            get;
            set;
        }
        public int ID
        {
            get;
            set;
        }
        public clsPractice()
        {
            ID = 0;
            Name = "Mohammed Ibrahim";
        }

        public clsPractice(string name, int id, string phone, int age)
        {
            this.ID = id;
            this.Phone = phone;
            this.Name = name;
            this.Age = age;
        }

    }


    class clsPractice2
    {
        static public int _ID;

        static public int ID
        { get { return _ID; }
            set { _ID = value; }
        }
        static clsPractice2()
        {
            _ID = 100;
        }
    }

    static class clsPractice3
    {
        static public int ID { get; set; }
        static public string Name { get; set; }



        static clsPractice3()
        {
            ID = 100;
            Name = "Mohammed Ibrahim";
            
        }

    }

    internal class Program
    {
        static int Main ()
        {
            clsPractice P1 = new clsPractice();

            P1.ID = 100;
            Console.WriteLine("Name : {0}", P1.Name);
            Console.WriteLine("ID   : {0}", P1.ID);

            Console.ReadKey();
            Console.WriteLine("\n");


            clsPractice P2  = new clsPractice(id : 078412123 , name : "Rabee Ibrahim" , phone : "0995-491-570" , age : 44);
            Console.WriteLine("{0}", P2.ID);
            Console.WriteLine("{0}", P2.Name);
            Console.WriteLine("{0}", P2.Phone);

            Console.WriteLine("\n");
            Console.ReadKey();


            clsPractice2 P3 = new clsPractice2();
            Console.WriteLine("Static Constructor Practice\n");

            Console.WriteLine("ID  :{0}\n", clsPractice2.ID);

            clsPractice2.ID = 123412;
            Console.WriteLine("ID  :{0}", clsPractice2.ID);

            Console.WriteLine("\n");
            Console.ReadKey();


            Console.WriteLine(clsPractice3.ID);
            Console.WriteLine(clsPractice3.Name);
            return 0;
        }


    }


}
