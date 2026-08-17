
using System;
using System.ComponentModel;
using System.Security.Cryptography.X509Certificates;

namespace AccessModifiers

{
    class clsA
    {
        public int X1;
        //Shared Between All Classes
        public static int X2 ;
       
        public  int Menthod1 ()
        {
            return X1 + X2;
        }
        //Can Be Called Without Creating Object
        public static int Menthod2()
        {
            return X2;
        }


    }
    
    internal class Program
    {
        static void Main(string[] args)
        {
          
         clsA obj1 = new clsA();
         clsA obj2 = new clsA();

            obj1.X1 = 7;
            obj2.X1 = 10;

            clsA.X2 = 100;

            Console.WriteLine("Obj1 X1 = {0}", obj1.X1);
            Console.WriteLine("Obj2 X1 = {0}", obj2.X1);
            Console.WriteLine("Obj1 Method1  = {0}", obj1.Menthod1());
            Console.WriteLine("Obj2 Method1  = {0}", obj2.Menthod1());
            Console.ReadKey();

            Console.WriteLine("\nStatic method2 = {0}", clsA.Menthod2());
            Console.WriteLine("Static Member  = {0}", clsA.X2);

            Console.ReadKey();
        }

    }  

}


