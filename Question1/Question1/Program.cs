using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Question1
{
    public class Program
    {
        static void Main(string[] args)
        {
            string InputString = "abcdefab";
            List<string> InputList = new List<string>() { "Abc", "def", "ab", "cd" };

            GetMinNumberOfSpaces(InputString, InputList);
        }

        public static string GetMinNumberOfSpaces(string inputString, List<string> inputList)
        {
            int LengthOfInputString = inputString.Length;
            inputList = inputList.ConvertAll(word => word.ToLower());

            int NumberOfSpaces = 0;
            int MinNumberOfSpaces = int.MaxValue;

            for (int i = 0; i < inputList.Count; i++)
            {
                NumberOfSpaces = 0;
                string concatWord = inputList[i];
                inputList[i] = inputList[0];
                inputList[0] = concatWord;

                if(concatWord == inputString)
                {
                    return "0";
                }

                for (int j = 1; j < inputList.Count; j++)
                {
                    concatWord += inputList[j];
                    NumberOfSpaces += 1;

                    if (concatWord.Length > LengthOfInputString)
                    {
                        concatWord = concatWord.Remove(concatWord.LastIndexOf(inputList[j]));
                        NumberOfSpaces -= 1;
                    }

                    else if (concatWord.Length == LengthOfInputString)
                    {
                        concatWord = String.Concat(concatWord.OrderBy(c => c));
                        inputString = String.Concat(inputString.OrderBy(c => c));
                        if (concatWord == inputString && NumberOfSpaces <= MinNumberOfSpaces)
                        {
                            MinNumberOfSpaces = NumberOfSpaces;
                        }

                        NumberOfSpaces = 0;
                    }
                }

            }

            if (MinNumberOfSpaces == int.MaxValue)
            {
                Console.WriteLine("Min Number Of Spaces: " + "N/A");
                return "N/A";
            }
            else
            {
                Console.WriteLine("Min Number Of Spaces: " + MinNumberOfSpaces);
                return Convert.ToString(MinNumberOfSpaces);
            }
        }
    }
}
