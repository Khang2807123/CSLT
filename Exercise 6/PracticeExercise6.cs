using System;
using System.Text;
using System.Globalization;
using System.Runtime.InteropServices.Marshalling;
namespace practice_buoi_7
{
    internal class Exercise6
    {
        //to calculate the average value of array elements.
        static double AvgValue(int[] arr)
        {
            double ans = 0;
            for(int i = 0; i<arr.Length;i++)
            {
                ans += arr[i];
            }
            return ans/arr.Length;
        }
    
        //to test if an array contains a specific value.
        static bool CheckSpecificValue(int[] arr, int target)
        {
            foreach(char c in arr)
            {
                {
                    if (arr.Contains(target))
                    {
                        return true;
                    }
                }
            }
            return false;
        }
        //to find the index of an array element.
        static int FindingIndex(int[] arr, int n)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr.Contains(n))
                {
                    return arr[i];
                }
            }
            return -1;
        }
        //to remove a specific element from an array.
        //to find the maximum and minimum value of an array.
        //to reverse an array of integer values.
        //to find duplicate values in an array of values.
        //to remove duplicate elements from an array.
        static void MainP6 (string[] args)
        {  
            Console.WriteLine(FindingIndex([1,4,3,5], 6));
        }
    }
}
