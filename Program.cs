using System;
namespace SealedClasses
{
    public sealed class clsApplication
    {
        public int ID { get; set; }
        public string name { get; set; }
        public float Size { get; set; }
        
        public clsApplication (string name)
        {
            this.name = name;
        }
        public void Introducer ()
        {
            Console.WriteLine("This is Mohammed Application");
        }

      
    
   }

    public class clsPerson
    {
        public string Name { get; set; }
        public string Phone { get; set; }
        public int ID { get; set; }

        public virtual void Inroduce ()
        {
            Console.WriteLine($"Hello My Name is {Name} and My PhoneNumber is {Phone}");
        }

        public clsPerson(string name, string phone)
        {
            this.Name = name;
           this.Phone=  phone;
        }
    }

    public class clsEmployee : clsPerson {
    public float Salary { get; set; }

        public string Work { get; set; }

        public sealed override void Inroduce()
        {
            Console.WriteLine($"I Earn {Salary} and I work at {Work}");
            base.Inroduce();

        }
    
    
  public clsEmployee (string name, string phone) :  base (name, phone) 
        {

        }
    
    }

  public  class clsDoctor :  clsEmployee
    {
        public string Specialization { get; set; }


        public override void Inroduce()
        {
            Console.WriteLine("Hello Iam Doctor");
        }
        public clsDoctor(string name, string phone) : base(name, phone)
        {

        }

    }

    public class clsManager : clsPerson
    {

        public override void Inroduce()
        {
            
        }

   public clsManager(string name, string phone) : base(name, phone)
        {

        }

    }





    internal class Program
    {
        public static void Main(string[] args)
        {
            clsApplication App1 = new clsApplication("Mohammed");
            App1.ID = 100;
            App1.Introducer();
            Console.WriteLine(App1.name);
            Console.ReadKey();


        }
    }
}