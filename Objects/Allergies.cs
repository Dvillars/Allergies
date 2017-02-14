using System.Collections.Generic;
using System;

namespace Allergies
{
    public class Allergy
    {
        public static Dictionary<int, string> dValue = new Dictionary<int, string>()
        {
            {128, "cats"},
            {64, "pollen"},
            {32, "chocolate"},
            {16, "tomatoes"},
            {8, "strawberries"},
            {4, "shellfish"},
            {2, "peanuts"},
            {1, "eggs"},
        };
        private int _userInput;

        public int GetInput()
        {
            return _userInput;
        }
        public void SetInput(int newInput)
        {
            _userInput = newInput;
        }

        public string List()
        {
            int newInput = GetInput();
            List<string> output = new List<string>();
            string result;

            foreach(KeyValuePair<int, string> x in dValue)
            {
                if (newInput == 0)
                {
                    break;
                }
                else if (newInput < x.Key)
                {
                    continue;
                }
                else
                {
                    output.Add(x.Value);
                    newInput -= x.Key;
                }
            }

            result = string.Join(" ", output.ToArray());
            Console.WriteLine(result);
            return result;
        }
    }
}
