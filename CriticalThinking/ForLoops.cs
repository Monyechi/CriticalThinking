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
            string str = "Hello World";
            var result = string.Empty;
            for (var i = 0; i < str.Length; i++)
            {
                if (i % 3 == 0) result += str[i];
            }
            Console.WriteLine(result);
            Console.ReadLine();

        }
        // member methods (CAN DO)
    }
}
