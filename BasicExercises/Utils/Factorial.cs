using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicExercises.Utils
{
    public class Factorial
    {
        public static int GetFactorial(int number)
        {
            int result = 1;

            for(var i = 1; i <= number; i++)
            {
                result *= i;
            }

            return result;
        }
    }
}
