using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CriticalThinking
{
    class ForLoops
    {
        // member variables (HAS A) 
        


        // constructor (SPAWNER) 
        public ForLoops()
        {
            int i;
            int j;
            string userInput;

            Console.WriteLine("How Many Times Do You Want The Loop To Run?");
            userInput = Console.ReadLine();
            j = int.Parse(userInput);

            for (i = 0; i <= j; i++)
            {
                Console.WriteLine(i);
            }

        }
        // member methods (CAN DO)
    }
}
