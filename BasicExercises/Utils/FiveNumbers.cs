using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicExercises.Utils
{
    public class FiveNumbers
    {
        public static string AddToList(List<int> numbers)
        {
            while (numbers.Count < 5)
            {
                Console.Write("Enter a number: ");
                var input = Console.ReadLine();

                var isDigit = Int32.TryParse(input, out int digit);

                if (!isDigit)
                {
                    AddToList(numbers);
                } else if (numbers.Contains(digit))
                {
                    Console.WriteLine("Number already in the list");
                    AddToList(numbers);
                } else
                {
                    numbers.Add(digit);
                }

            }

            numbers.Sort();
            var response = ConvertListToString(numbers);
            return response;
        }

        private static string ConvertListToString(List<int> numbers)
        {
            var str = "";
            foreach (var number in numbers) 
            {
                str += $"{number.ToString()} ";
            }

            return str;
        }
    }
}
