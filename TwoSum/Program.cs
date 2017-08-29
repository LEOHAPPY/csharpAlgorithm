using System;
using System.Collections;
using System.Collections.Generic;

namespace TwoSum
{
    class Program
    {
        #region two for loop
        // public static int[] TwoSum(int[] nums, int target) {
        //     int[] result = new int[2];
        //     for(int i=0; i<nums.Length-1; i++){
        //         for(int j=i+1; j<nums.Length; j++){
        //             if(nums[i] + nums[j] == target){
        //                 result[0] = i;
        //                 result[1] = j;
        //                 break;
        //             }
        //         }
        //     }
        //     return result;
        // }
        #endregion

    //     #region hashtable
    //     public static int[] TwoSum(int[] nums, int target) {
    //     var map = new Hashtable();
    //     for (int i = 0; i < nums.Length; i++)
    //     {
    //         var complement = target - nums[i];
    //         if (map.ContainsKey(nums[i]))
    //         {
    //             return new int[] { (int)map[nums[i]], i };
    //         }

    //         if (!map.ContainsKey(complement))
    //         {
    //             map.Add(complement, i);
    //         }
    //     }

    //     throw new Exception("Not possible!");
    // }
    // #endregion

    #region Dictionary
        public static int[] TwoSum(int[] nums, int target) {
            Dictionary<int,int> map = new Dictionary<int, int>();
            for (int i = 0; i < nums.Length; i++)
            {
                var complement = target - nums[i];
                if (map.ContainsKey(nums[i]))
                {
                    return new int[] { (int)map[nums[i]], i };
                }

                if (!map.ContainsKey(complement))
                {
                    map.Add(complement, i);
                }
            }

            throw new Exception("Not possible!");
    }
    #endregion
        static void Main(string[] args)
        {
            int[] nums = {3,2,4};
            int[] result = TwoSum(nums, 6);
            Console.WriteLine(string.Join(',',result));
            // Console.WriteLine("hellow two sum");
        }
    }
}
