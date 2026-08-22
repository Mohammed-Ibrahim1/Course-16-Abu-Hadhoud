
using System;
using System.Net.Cache;
using System.Runtime.InteropServices;

 class clsPerson
{
    private int _ID;
    private string _Name;


    public int ID 
        { get { return _ID; }
         set { _ID = value; }
    }
public string Name { get { return _Name; }
                     set { _Name = value; } }

    public int Age
    {
        get;
        set;
    }

   public  clsPerson ()
    {
        ID = 0;
        Name = "Mohammed";
        Age = 0;
    }
    public clsPerson (int age  ,  int id   ,  string name)
    {
this.Name = name;
       this. Age = age;
        this.ID = id;

    }
}

internal class Program
{
static void Main (string[] args)
    {
        clsPerson Person1 = new clsPerson();
        Console.WriteLine("Calling Parameterless Constructor");
        Console.WriteLine("ID   = {0}", Person1.ID);
        Console.WriteLine("Age  = {0}", Person1.Age);
        Console.WriteLine("Name = {0}", Person1.Name);
        Console.ReadKey();
        Console.WriteLine();


        clsPerson Person2 = new clsPerson(id:122, age : 18 , name : "Mohammed Ibrahim");
        Console.WriteLine("Calling Parametered Constructor");
        Console.WriteLine("ID   = {0}", Person2.ID);
        Console.WriteLine("Age  = {0}", Person2.Age);
        Console.WriteLine("Name = {0}", Person2.Name);
        Console.ReadKey();

    }




}


