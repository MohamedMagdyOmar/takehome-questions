using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static List<string> AllPossibleCombination = new List<string>();
        static List<string> bridge = new List<string>();
        static void Main(string[] args)
        {
            string str = "ABC";
            char[] charArry = str.ToCharArray();
            string[] stringArray = { "Abc", "def", "ab", "cd" };
            string[]  newstringArray = { "Abc", "def", "ab", "cd" };
            for (int t = 0; t < stringArray.Length; t++)
            {
                int c = stringArray.Length;
                for (int i = 0; i < c; i++)
                {                  
                    permute(stringArray, 0, (stringArray.Length - 1));
                    bridge = stringArray.ToList();
                    bridge.RemoveAt(0);
                    //bridge.RemoveRange(t, i);
                    stringArray = bridge.ToArray();
                }
                
                bridge = newstringArray.ToList();
                string first = bridge[0];
                bridge.RemoveAt(0);
                bridge.Add(first);
                newstringArray = bridge.ToArray();
                stringArray = newstringArray;
            }
            
            
            Console.ReadKey();
        }

        static void permute(string[] arry, int i, int n)
        {
            int j;
            if (i == n)
            {
                string result = "";
                for(int z = 0; z < arry.Length; z++)
                {
                    result += arry[z];
                }
                AllPossibleCombination.Add(result);
                Console.WriteLine(result);
            }
                
            else
            {
                for (j = i; j <= n; j++)
                {
                    swap(ref arry[i], ref arry[j]);
                    permute(arry, i + 1, n);
                    swap(ref arry[i], ref arry[j]);
                }
            }
        }

        static void swap(ref string a, ref string b)
        {
            string tmp;
            tmp = a;
            a = b;
            b = tmp;
        }
    }
}
