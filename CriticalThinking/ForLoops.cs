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
            string helloWorld = "Hello World";
            int i;
            int j;                     
            
            j = helloWorld.Length;           
           
            for (i = 0; i <= j - 1; i++)
            {
                Console.WriteLine(i);
            }

        }
        // member methods (CAN DO)
    }
}
