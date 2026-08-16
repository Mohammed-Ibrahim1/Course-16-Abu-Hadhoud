
using System;
using System.ComponentModel;

namespace AccessModifiers

{
    class clsA
    {
        public int X1 = 10;
        protected int X3 = 20;
        private int X2 = 30;


        public int func1 ()
        {
            return 100;
        }

        private  int func2()
        {
            return 200;
        }

        protected int func3()
        {
            return 300;
        }


    }
    class clsB : clsA
    {
        public int func4()
        {
            return X1 + X3 ;
        }
    }



    internal class Program
    {
        static void Main(string[] args)
        {
          
         clsA A = new clsA();

         Console.WriteLine("All public members are accessible");
         Console.WriteLine("X1 = {0}", A.X1);
         Console.WriteLine("Result of fun1 = {0}", A.func1());

          clsB B = new clsB();
            Console.WriteLine("\nObjects from Class B expose all public members of Class A ");
            Console.WriteLine("X1 = {0}", B.X1);
            Console.WriteLine("Result of Func 1  = {0}", B.func1());

        }

    }

}


