using BasicExercises.Utils;

namespace BasicExercises
{
    class Program
    {
        static void Main(string[] args)
        {
            // Factorial
            Console.WriteLine("\nFactorial");
            var factorialOfFive = Factorial.GetFactorial(3);
            Console.WriteLine(factorialOfFive);

            // Max number in string
            Console.WriteLine("\nMax number in string");
            var myNumbers = "100,75, 1000, 5900, John, Zion, gh";
            var maxNumber = MaxNumber.GetMaxFromString(myNumbers);
            Console.WriteLine($"Max Number is {maxNumber}");

            Console.WriteLine("Type a string of numbers separated by commas");
            //var userInput = Console.ReadLine();

            //while (string.IsNullOrEmpty(userInput))
            //{
            //    Console.WriteLine("Cannot add an empty or null string. Please type the string of numbers: ");
            //    userInput = Console.ReadLine();
            //}
            //var maxInputNumber = MaxNumber.GetMaxFromString(userInput);
            //Console.WriteLine(maxInputNumber > -1 ? $"Max number {maxInputNumber}" : "Invalid string");

            // Facebook
            Console.WriteLine("\nFacebook");
            var friends = new List<string>();
            //Facebook.ShowLikes(friends);

            // Unique numbers from input
            Console.WriteLine("\nUnique numbers from input");
            var numbers = new List<int>();
            //UniqueNumbers.GetUniqueFromInput(numbers);

            // Get Smallest
            //Smallest.GetSmallestFromList();

            // Enter Five numbers
            var numbersList = new List<int>();
            var mySortedNumbers = FiveNumbers.AddToList(numbersList);
            Console.WriteLine(mySortedNumbers);
        }
    }
}