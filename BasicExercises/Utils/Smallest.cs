using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicExercises.Utils
{
    public class ConvertResponse
    {
        public bool IsValid;
        public List<int> SortedList;
        public string? Message;
    }

    public class Smallest
    {
        public static void GetSmallestFromList()
        {
            Console.WriteLine("Please type a list of numbers separated by comma");
            var input = Console.ReadLine();
            

            if (string.IsNullOrEmpty(input))
            {
                Console.WriteLine("Invalid String");
                GetSmallestFromList();
            } else
            {
                var intList = ConvertToSortedList(input);

                if (!intList.IsValid) 
                {
                    Console.WriteLine(intList.Message);
                    GetSmallestFromList();
                }
                else
                {
                    Console.WriteLine(intList.Message);
                    LoopList(intList.SortedList);
                }
            }
        }

        private static void LoopList(List<int> list)
        {
            for (int i = 0; i <= 2; i++)
            {
                Console.Write($"{list[i]} ");
            }
        }

        private static ConvertResponse ConvertToSortedList(string str) 
        {
            var response = new ConvertResponse();
            var list = new List<int>();
            const string errorMessage = "Invalid List";
            const string successMessage = "Success";
            

            if (string.IsNullOrEmpty(str))
            {
                response.IsValid = false;
                response.SortedList = list; 
                response.Message = errorMessage;

            }
            else
            {
                var charArray = str.Split(',');

                if (charArray.Length < 5) 
                {
                    response.IsValid = false;
                    response.SortedList = list;
                    response.Message = errorMessage;
                } 
                else
                {
                    for (int i = 0; i < charArray.Length; i++)
                    {
                        var isDigit = Int32.TryParse(charArray[i], out int digit);
                        if (isDigit) { list.Add(digit); }
                    }

                    list.Sort();

                    response.IsValid = true;
                    response.SortedList = list;
                    response.Message = successMessage;
                }
            }

            return response;
        }
    }
}
