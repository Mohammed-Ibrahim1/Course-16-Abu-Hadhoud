
using System;
using System.Security.Authentication;

public interface IPerson
{
string FirstName { get; set; }
string LastName { get; set; }

    void Introduce();
    void Print();
    string To_String ();

}

public abstract class clsPerson : IPerson
{
    public  string   FirstName { get; set; }

    public string LastName { get; set; }

    public abstract void Introduce();


    public void SayGoodBye()
    {
        Console.WriteLine("GoodBye!");
    }

    public void Print()
    {
        Console.WriteLine("Hi I am Mohammed");
    }

    public string To_String()
    {
        return "Hallo ich bin Mohammed";
    }

    public clsPerson(string firstname  ,  string lastname)
    {
        FirstName = firstname;
        LastName = lastname;

    }

}

public class clsEmployee : clsPerson
{
    public override void Introduce()
    {
        Console.WriteLine("Hello Iam Mohammed and Iam 18 Years Old");
    }

   public clsEmployee (string fitstname  ,  string lastname) : base (fitstname, lastname) 
    {

    }
}


public class Program
{
   public static void Main (string[] args)
    {
        clsEmployee Employee1 = new clsEmployee("Mohammed" ,  "Ibrahim");

       
    }

}