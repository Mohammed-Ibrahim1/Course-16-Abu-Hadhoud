

using System;
using System.ComponentModel;
namespace Practicing
{
    public class clsPerson
    {
        private int _ID;
        private string _FirstName;
        private string _LastName;
        private string _Phone;
        private string _Email;
        private string _Gender;
        private int _Age;

        public int ID { get { return _ID; } set { _ID = value; } }
        public string FirstName { get { return _FirstName; } set { _FirstName = value; } }
        public string LastName { get { return _LastName; } set { _LastName = value; } }
        public string Phone { get { return _Phone; } set { _Phone = value; } }
        public string Email { get { return _Email; } set { _Email = value; } }
        public string Gender { get { return _Gender; } set { _Gender = value; } }
        public int Age { get { return _Age; } set { _Age = value; } }

        public string FullName
        {
            get
            {
                return FirstName + " " + LastName;
            }
        }
        public void ShowPersonalInformations()
        {
            Console.WriteLine("ID        = {0}", _ID);
            Console.WriteLine("Fullname  = {0}", FullName);
            Console.WriteLine("Phone     = {0}", _Phone);
            Console.WriteLine("Email     = {0}", _Email);
            Console.WriteLine("Gender    = {0}", _Gender);
            Console.WriteLine("Age       = {0}", _Age);

            Console.WriteLine("\n");
            Console.ReadKey();

        }

        public clsPerson(int iD, string firstName, string lastName, string phone, string email, string gender, int age)
        {
            ID = iD;
            FirstName = firstName;
            LastName = lastName;
            Phone = phone;
            Email = email;
            Gender = gender;
            Age = age;

        }
    }

    public class clsEmployees : clsPerson
    {

   public float Salary { get; set; }
   public int WorkingHours { get; set; }
   public string WorkingEmail { get; set; } 

    public clsEmployees (int iD, string firstName, string lastName, string phone, string email, string gender, int age
        , float salary , int working , string Wemail) : base (iD , firstName , lastName , phone , email ,  gender , age)
        {
this.Salary = salary;
            this.WorkingHours = working;
            this.WorkingEmail = Wemail;
        }
    }

    public class clsDoctor : clsEmployees
    {
        public string Specialization { get; set; }
        public string HospitalName { get; set; }
        public string EmergencyNumber { get; set; }

        public clsDoctor (int iD, string firstName, string lastName, string phone, string email, string gender, int age
        , float salary, int working, string Wemail , string spec , string hospname , string Emcnumber ) : base (iD, firstName, lastName, phone, email, gender, age
            , salary , working ,Wemail)
        {
            Specialization = spec;
            HospitalName = hospname;
            EmergencyNumber = Emcnumber;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            clsDoctor Doctor1 = new clsDoctor(512, "Mohammed", "Ibrahim", "0995-491-570", "mohammasrabee@gmail.com", "Male",18 ,
                5000, 8, "hellenqqpp1122@gmail.com", "Childrens", "AlMashrek", "1234");


            Console.ReadKey();
        }
    }
}
 