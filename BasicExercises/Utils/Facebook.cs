using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicExercises.Utils
{
    public class Facebook
    {
        public static void ShowLikes(List<string> list)
        {
            Console.Write("Enter your friends name: ");
            var input = Console.ReadLine();

            if (!string.IsNullOrEmpty(input) ) { list.Add(input); }

            while (!string.IsNullOrEmpty(input)) 
            {
                Console.Write("Enter your friends name: ");
                input = Console.ReadLine();

                if (!string.IsNullOrEmpty(input)) { list.Add(input); }
            }

            switch (list.Count)
            {
                case 0:
                    Console.WriteLine("0 Likes");
                    break;
                case 1:
                    Console.WriteLine($"{list[0]} likes your post");
                    break;
                case 2:
                    Console.WriteLine($"{list[0]} and {list[1]} like your post");
                    break;
                default:
                    var remaining = list.Count - 2;
                    Console.WriteLine($"{list[0]}, {list[1]}, and {remaining} others like your post");
                    break;
            }
        }
    }
}
