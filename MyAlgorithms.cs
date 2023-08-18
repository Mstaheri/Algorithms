using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms
{
    public class MyAlgorithms
    {
        public int Factorial(int number) 
        {
            int factorial = 1;
            for (int i = 1; i <= number; i++)
            {
                factorial*= i;
            }
            return factorial;
        }
        public bool LinearSearcher(string[] Nam , string search)
        {
            for (int i = 0; i < Nam.Length; i++)
            {
                if (Nam[i] == search)
                {
                    return true;
                }
            }
            return false;
        }
        public bool BinarySearcher(int[] Nam, int search)
        {
            int Left = 0;
            int Right = Nam.Length - 1;
            while (Left <= Right)
            {
                int Mid = (Left + Right) / 2;
                if (Nam[Mid] == search)
                {
                    return true;
                }
                else if (Nam[Mid] > search)
                {
                    Right = Mid -1;
                }
                else if (Nam[Mid] < search)
                {
                    Left = Mid + 1;
                }
            }
            return false;

        }
        ///////////////////////////////////////////////////////
        public int[] BinaryInsertionSort(int[] arr)
        {
            for (int i = 1; i < arr.Length; i++)
            {
                int key = arr[i];
                int left = 0;
                int right = i - 1;

                while (left <= right)
                {
                    int mid = (left + right) / 2;

                    if (key < arr[mid])
                        right = mid - 1;
                    else
                        left = mid + 1;
                }

                for (int j = i - 1; j >= left; j--)
                {
                    arr[j + 1] = arr[j];
                }

                arr[left] = key;
            }
            return arr;
        }
        public int[] BubbleSorter(int[] Nam)
        {
            for (int i = 0; i < Nam.Length - 1; i++)
            {
                for (int x = 0; x < Nam.Length - 1; x++)
                {
                    if (Nam[x] > Nam[x + 1])
                    {
                        int a = Nam[x];
                        Nam[x] = Nam[x + 1];
                        Nam[x + 1] = a;
                    }
                }
            }
            return Nam;
        }
    }
}
