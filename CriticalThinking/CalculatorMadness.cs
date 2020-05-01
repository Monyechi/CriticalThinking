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

        public CalculatorMadness()
        {
            SolveMathProblem();
        }

        public int AddTwoNumbers(int numberOne, int numberTwo)
        {
            int result = numberOne + numberTwo;            
            return result;
        }
        public void RunCalculations()
        {
            int result1 = AddTwoNumbers(8, 40);
            int result2 = AddTwoNumbers(200, 50);
            int results = AddTwoNumbers(result1, result2);
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
            int result1 = AddTwoNumbers(6, 5);
            int result2 = MultiplyTwoNumbers(40, 35);            
            int result3 = DivideTwoNumbers(result2, 4);
            int result4 = SubtractTwoNumbers(result1, result3);
            int result5 = MultiplyTwoNumbers(2, 2);
            int finaleResults = AddTwoNumbers(result4, result5);

            Console.WriteLine(finaleResults);

        }


    }
    
}
