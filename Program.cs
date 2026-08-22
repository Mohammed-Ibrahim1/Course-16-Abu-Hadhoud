using System;

class clsPersos
{
    public int ID { get; set; }
    public string Name { get; set; }
    public int Age { get; set; }

    public clsPersos()
    {
        ID = -1;
        Name = "Empty";
        Age = 0;
    }
}

internal class Program
{
    static void Main (string[] args)
    {

        clsPersos Person1 = new clsPersos();

        Console.WriteLine("ID   = {0}", Person1.ID);
        Console.WriteLine("Name = {0}", Person1.Name);
        Console.WriteLine("Age  = {0}", Person1.Age);

        Console.ReadKey();
    }

}