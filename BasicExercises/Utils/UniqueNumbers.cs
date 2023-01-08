using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicExercises.Utils
{
    public class UniqueNumbers
    {
        public static void GetUniqueFromInput(List<int> list)
        {
            Console.Write("Please type a number: ");
            var input = Console.ReadLine();

            if(input != "Quit") 
            {
                // If the input is not a digit
                var isDigit = Int32.TryParse(input, out int digit);

                // If the input is a digit
                if (isDigit) { list.Add(digit); }

                // Recurssion
                GetUniqueFromInput(list);
            }
            else
            {
                var unique = list.Distinct().ToList();

                loopList(unique);
            }
        }

        public static void loopList (List<int> list)
        {
            if (list.Count == 0)
            {
                Console.WriteLine("List is empty");
            } 
            else
            {
                Console.WriteLine("Looping list:");
                foreach (var item in list)
                {   
                    Console.WriteLine(item);
                }
            }
        }
    }
}
