using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicExercises.Utils
{
    public class MaxNumber
    {
        public static int GetMaxFromString(string str)
        {

            var intList = ConvertToList(str);

            if (intList.Count == 0)
            {
                return -1;
            }

            return intList.Max();

        }

        private static List<int> ConvertToList(string str)
        {
            var strArray = str.Split(",");
            var intList = new List<int>();

            for (int i = 0; i < strArray.Length; i++)
            {
                int num;
                bool isNumber = Int32.TryParse(strArray[i], out num);
                if (isNumber) { intList.Add(num); }
            }

            return intList;
        }
    }
}
