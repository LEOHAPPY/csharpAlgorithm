using System;

namespace LongestSubstring
{
    class Program
    {
        public static int LengthOfLongestSubstring(string input) 
        {
            string substringPre = "";
            string substringSuf = "";
            string originInput = input;
            int result = 0;
            int resultSuf = 0;
            int resultPre = 0;

            string substringSuf2 = "";
            int resultSuf2 = 0;

            for (int i = 0; i < originInput.Length ; i++)
            {
                char subChar =  originInput[i];
                input = input.Substring(1);
                int indexof = input.IndexOf(subChar);
                if(indexof!=-1){
                    substringSuf = input.Substring(indexof);
                    substringPre = originInput.Substring(0,originInput.Length - substringSuf.Length);
                    
                    substringSuf2 = input;
                    if (result < substringPre.Length)
                        resultPre = LengthOfLongestSubstring(substringPre);
                    if (result < substringSuf.Length)
                        resultSuf = LengthOfLongestSubstring(substringSuf);
                    if (result < substringSuf2.Length)
                        resultSuf2 = LengthOfLongestSubstring(substringSuf2);

                    result = result > resultPre ? result : resultPre;
                    result = result > resultSuf ? result : resultSuf;
                    result = result > resultSuf2 ? result : resultSuf2;
                    return result;
                }
            }
            return result = originInput.Length;
        }
        static void Main(string[] args)
        {
            Console.WriteLine(LengthOfLongestSubstring("eacxpeogddgavxenmbnnylkkbvjlhjzljbjbgzjjfrlaopqct"));
        }
    }
}
