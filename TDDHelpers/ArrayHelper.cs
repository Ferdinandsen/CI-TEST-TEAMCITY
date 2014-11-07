using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Collections.Specialized;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TDDHelpers
{
    class ArrayHelper
    {
        public int[] ReturnAscArray(int[] arr)
        {
            int[] newArr = new int[arr.Length];
            Array.Copy(arr, newArr, arr.Length);
            Array.Sort(newArr);.

            return newArr;
        }

        public int[] ReturnDescArray(int[] arr)
        {
            int[] newArr = new int[arr.Length];
            Array.Copy(arr, newArr, arr.Length);
            Array.Sort(newArr);
            Array.Reverse(newArr);
            return newArr;
        }

        public int[] ReplaceXwithY(int[] arr, int x, int y)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] == x)
                {
                    arr[i] = y;
                }
            }
            return arr;
        }

        // FIX THIS!
        //FIX IT MORE!
        public int GetAverage(int[] arr)
        {
            return (int)arr.Average();
        }
    }
}
