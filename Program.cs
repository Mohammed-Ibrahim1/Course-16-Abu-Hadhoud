
using System;
using System.Security.Authentication;
using System.Xml.Serialization;

public interface IPerson
{
string FirstName { get; set; }
string LastName { get; set; }

    void Introduce();
    void Print();
    string To_String ();

}

public interface ICommunicate
{
    void CallPhone(string PhoneNumber);

    void SendEmail(string Title ,  string Body);
    void SendSMS();


}

public abstract class clsPerson : IPerson , ICommunicate
{
    public  string   FirstName { get; set; }

    public string LastName { get; set; }

    public abstract void Introduce();

    public abstract void CallPhone(string number);
    
    public void SendEmail (string Title  ,  string Body )
    {
        Console.WriteLine("Email Sent");
    }

    public void SendSMS ()
    {
        Console.WriteLine("SMS sent");
    }

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

    public override void CallPhone(string number)
    {
        Console.WriteLine($"Calling Number {number}");
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