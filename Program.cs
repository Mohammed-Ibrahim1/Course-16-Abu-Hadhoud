using System;

namespace Calculator
{
   class clsCalculator
    {
        private float _counter = 0;
        private float _LastNumber = 0;
        private string _LastOperation = "Clear";

        private bool _ValidateNOTZero (float Number)
        {
            return (Number <= 0);
        }
        public void Add (float number )
        {
            _LastNumber = number;
            _LastOperation = "Adding";
            _counter += number;
        }

        public void Subtract (float number )
        {
            _LastNumber -= number;
            _LastOperation = "Subtracting";
_counter -= number;
        }

        public void Multiply (float number)
        {
            _LastNumber = number;
            _LastOperation = "Multiplying";
            _counter *= number;
        }
        public void Divide(float number)
        {

            bool Succeeded = true;
            _LastOperation = "Dividing";

            if (_ValidateNOTZero(number))
            {
                _LastNumber = number;
                _counter /= 1;
                Succeeded = false;

            }
            else
            {
                _LastNumber = number;
                _counter /= number;
            }


            _counter = _counter / number;
        }

        public void Clear ()
        {
            _counter = 0;
        }

        public float GetFinalResult()
        {
            return _counter;
        }

        public void PrintReslt()
        {
            Console.WriteLine("{0}", _counter);
        }

    }

    internal class Program
    {

        public static void Main(string[] args)
        {
            clsCalculator calculator1  =  new clsCalculator();

            calculator1.Add(10);
            calculator1.Multiply(10);
            Console.WriteLine(calculator1.GetFinalResult());

        }
    
    
    }


}