
using System;
using System.Runtime.InteropServices;
using System.Runtime.Intrinsics.X86;

namespace Main
{
public class clsA
    {
        public string Name { get; set; }
        public int Id { get; set; }

      public virtual void Cheers ()
        {
            Console.WriteLine($"Hello It is {Name} My ID is {Id}");
        }

        public virtual void Question ()
        {
            Console.WriteLine("What is your Name ?");
        }


    }

    public class clsB : clsA
    {
        public string phone { get; set; } 
        public string Email { get; set; }

        public override void Cheers()
        {
            Console.WriteLine($"My PhoneNumber is {phone} and my Email is {Email}");
        }

        public new void Question()
        {
            base.Question();
            Console.WriteLine("What is your Email ?");
            Console.WriteLine("What is your Phone Number ?");
        }
    }


   internal class Program
    { 
    static void Main (string[] args)
        {
          clsA A1 = new clsA { Name = "Mohammed" , Id = 312};
            A1.Cheers();
            A1.Question();
            Console.ReadKey();
            Console.WriteLine("\n");
            clsB B1 = new clsB();
            B1.Cheers();
            B1.Question();

            Console.ReadKey();
            Console.WriteLine("\n\n");

           clsB B2 = new clsB();
            clsA A2 = B2;

            A2.Cheers();
            A2.Question();
        }
    
    
    
    
    
    
    
    
    
    }

     






}
