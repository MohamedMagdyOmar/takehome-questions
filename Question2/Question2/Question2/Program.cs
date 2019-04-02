using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Question2
{
    public class Program
    {
        static void Main(string[] args)
        {
            int numberOfPieces = 7;
            List<int> LengthOfEach = new List<int>() { 1, 1, 3, 3, 4, 5, 7 };
            GetMaxArea(numberOfPieces, LengthOfEach);
        }

        public static int GetMaxArea(int numberOfPieces, List<int> lengthOfEachPeace)
        {
            int maximumArea = -1;
            int LengthOf2sides;
            List<int> LengthOfOtherSides = new List<int>();

            if ((numberOfPieces != lengthOfEachPeace.Count) || (lengthOfEachPeace.Count < 5) || (lengthOfEachPeace.Min() <= 0))
            {
                return -1;
            }
            // remove smallest value to satisfy the following requirement
            // "(the broken piece is the shortest one)"
            lengthOfEachPeace.Remove(lengthOfEachPeace.Where(x => x == lengthOfEachPeace.Min()).First());

            var GroupOfDuplicates = lengthOfEachPeace.GroupBy(x => x).Where(g => g.Count() > 1).Select(y => y.Key).ToList();

            if (GroupOfDuplicates.Count() == 0)
            {
                // this exception to satisfy the following requirement
                // "since the original fences are all manufactured separately, they can only be joined at the ends"
                return -1;
            }
            else
            {
                LengthOf2sides = GroupOfDuplicates.Max();
                lengthOfEachPeace.Remove(LengthOf2sides);
                lengthOfEachPeace.Remove(LengthOf2sides);

                if(lengthOfEachPeace.Count < 2)
                {
                    // Number Of Pieces Not Enough To Form a rectangle
                    return -1;
                }
                else if(lengthOfEachPeace.Count == 2 && lengthOfEachPeace[0] != lengthOfEachPeace[1])
                {
                    // Length Of Pieces Does not form a rectangle
                    return -1;
                }
                else if (lengthOfEachPeace.Count == 2 && lengthOfEachPeace[0] == lengthOfEachPeace[1])
                {
                    maximumArea = lengthOfEachPeace[0] * LengthOf2sides;
                }
                else
                {
                    int a;
                    for (int i = 0; i < lengthOfEachPeace.Count - 2; i++)
                    {
                        LengthOfOtherSides.Add(lengthOfEachPeace[i]);
                        LengthOfOtherSides.Add(lengthOfEachPeace[i + 1]);

                        for (int j = i + 2; j < lengthOfEachPeace.Count; j++)
                        {
                            LengthOfOtherSides.Add(lengthOfEachPeace[j]);
                            a = LengthOfOtherSides.Max();

                            LengthOfOtherSides.RemoveAt(LengthOfOtherSides.IndexOf(a));

                            if((a * LengthOf2sides > maximumArea) && (a == (LengthOfOtherSides[0] + LengthOfOtherSides[1])))
                            {
                                maximumArea = a * LengthOf2sides;
                            }
                        }
                    }
                }
                
            }

            return maximumArea;
        }
    }
}
