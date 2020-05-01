using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CriticalThinking
{    
    class CalculatorMadness
    {
        public int numberOne;
        public int numberTwo;

        public int AddTwoNumbers(int numberOne, int numberTwo)
        {
            int result = numberOne + numberTwo;            
            return result;
        }
        public void RunCalculations()
        {
            numberOne = 8;
            numberTwo = 40;
            int results1 = AddTwoNumbers(numberOne, numberTwo);

            numberOne = 200;
            numberTwo = 50;
            int results2 = AddTwoNumbers(numberOne, numberTwo);

            int results = AddTwoNumbers(results1, results2);
            Console.WriteLine("The result is " + results);
        }
        public int SubtractTwoNumbers(int numberOne, int numberTwo)
        {
            int result = numberOne - numberTwo;
            return result;
        }
        public int MultiplyTwoNumbers(int numberOne, int numberTwo)
        {
            int result = numberOne * numberTwo;
            return result;
        }
        public int DivideTwoNumbers(int numberOne, int numberTwo)
        {
            int result = numberOne / numberTwo;
            return result;
        }
        public void SolveMathProblem()
        {

        }


    }
    
}
