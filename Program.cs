using System;
public partial class clsClass2
{

    public int Age { get; set; }

    public void Printer()
    {
        Console.WriteLine($"I am {Age} Years Old");
    }

}

public partial class clsClass2
{
   public string name { get; set; }

    public void Printer2 ()
    {
        Console.WriteLine($"MY Name is {name}");
    }

}

public partial class clsClass()
{
    public void Method3 ()
    {
        Console.WriteLine("This is Method 3");
    }

}



internal class Program
{




   public static void Main (string[] args)
    {
        clsClass C1 = new clsClass();

        C1.Method1();
        C1.Method2();

        Console.ReadKey();
    }






}