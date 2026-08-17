
using System;

namespace Practice

{

    class clsPractice
    {
        public int X1;
        public static int X2 = 100;


        public int SumofNumbers ()
        {
            return X1 + X2;
        }

        //Error Cannot Define Which Class to Bring the Value of X1
        public static int SumofNumbersStatic()
        {
            return X1 + X2;
        }

        public void Printer ()
        {
            Console.WriteLine("Mohammed The Best");
        }

        public static void PrinterStatic()
        {
            Printer(); //Error Cannot Define Which Class to Bring the Value of Printer
        }

        //No Problem Here Because We Are Calling the Static Method from a Non-Static Method
        public void Printer2()
        {
            PrinterStatic();
        }
        static void PrinterStatic2()
        {
            PrinterStatic();
        }


    }





    internal class Program
    {
        static void Main(string[] args)
        {
          


        }


    }
}



