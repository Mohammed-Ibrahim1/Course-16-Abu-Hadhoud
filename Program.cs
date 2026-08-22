
using System;

class Settings
{
    public static int DayNumber
    {
        get
        {
            return DateTime.Today.Day;
        }
    }

    public static string DayName
    {
        get
        {
            return DateTime.Today.DayOfWeek.ToString();
        }
    }
   public static string ProjectPath
    {
        get;
        set;
    }

    private Settings()
    {

    }


}

internal class Program
{
  static void Main ()
    {
        //if We Use Static class or Private Constructor We Can Create an object of this class ;
        // Settings Obj1 = new Settings();

        Console.WriteLine(Settings.DayNumber);
        Console.WriteLine(Settings.DayName);

    }


}
