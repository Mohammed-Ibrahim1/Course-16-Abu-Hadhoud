
using System;
namespace Main
{
    public class OuterClass
    {

        private int outervariable = 100;

        public void OuterMethod ()
        {
            Console.WriteLine("This is Outer Mehtode");
        }


        public class InnerClass
        {
            private int innervariable = 00;

            public void InnerMethod ()
            {
                Console.WriteLine("Hello This is Inner Method");
            }

            public void AccessOuterClass (OuterClass outer)
            {
                Console.WriteLine($"This is Variable From Outer Class  = {outer.outervariable}");
            }
        }

    }
    internal class Program
    {
    static public void Main (string[]args)
        {
            OuterClass Class1 = new OuterClass ();

            OuterClass.InnerClass Inner1 = new OuterClass.InnerClass();

            Class1.OuterMethod();
            Inner1.InnerMethod();
            Inner1.AccessOuterClass(Class1);

            Console.ReadKey(); 
        }
    
    
    }


}