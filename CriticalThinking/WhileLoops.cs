using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CriticalThinking
{
    class WhileLoops
    {
        private int counter;

        public WhileLoops()
        {
            EnterNumber42();
            CheckNumber();
        }
        public int EnterNumber42()
        {
            Console.WriteLine("Please enter the number 42");
            counter = int.Parse(Console.ReadLine());

            return counter;
        }
        public void CheckNumber()
        {            
            while (counter != 42)
            {
                Console.WriteLine("Invalid Input! Please try again.");
                Console.WriteLine("");
                EnterNumber42();
            }
            if (counter == 42)
            {
                Console.WriteLine("Congratulations! You entered 42.");
            }
                        
        }
        
    }
}
