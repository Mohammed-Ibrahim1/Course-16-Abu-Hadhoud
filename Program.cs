using System;

class clsPersos
{
    public int ID { get; set; }
    public string Name { get; set; }
    public int Age { get; set; }

    public clsPersos(int id , string name  ,  short age)
    {
        this.ID = id;
        this.Name = name;
        this.Age = age;
    }
}

internal class Program
{
    static void Main (string[] args)
    {

        clsPersos Person1 = new clsPersos(age:18 , id:612,name: "Mohammed Ibrahim");

        Console.WriteLine("ID   = {0}", Person1.ID);
        Console.WriteLine("Name = {0}", Person1.Name);
        Console.WriteLine("Age  = {0}", Person1.Age);

        Console.ReadKey();
    }

}