using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms_Example
{
    class ArrayAlgorithms
    {

        public bool LinearSearch1 (int[] input, int n)
        {
            foreach(int current in input)
            {
                if (n == current)
                {
                    return true;
                }
            }
            return false;
        }

        public int LinearSearch2 (int[ ] input, int n)
        {
            foreach (int current in input)
            {
                if (n == current)
                {
                    return n;
                }
                
            }
            return -1;

        }

        public Boolean BinarySearch (int[ ] input, int item) //Assume array is sorted 
        {
            int min = 0;
            int max = input.Length - 1;

            while(min <= max)
            {
                int mid = (min + max) / 2;
                Console.WriteLine("mid:"+ mid);
                if (item == input[mid])
                {
                    return true;
                }
                else if (item < input[mid])
                    max = mid - 1;
                else
                    min = mid + 1;
            }
            return false;


        }


        public int[] FindEvenNumbers(int[] arr1, int[] arr2) //Combine two or more datasets into a single dataset. Find the even numbers and Create new array. 
        {
            ArrayList result = new ArrayList(); //We could create a new array instead but we do not know how many even numbers will be in each array.

            //1. Check the each element
            foreach (int num in arr1)
            {
                if (num % 2 == 0)
                    result.Add(num);
            }

            foreach (int num in arr2)
            {
                if (num % 2 == 0)
                    result.Add(num);
            }


            return (int[ ])result.ToArray(typeof(int));
        }

        public int[ ] Reverse (int[ ] input) 
        {
            int len = input.Length;

            int[ ] reversed = new int[len];

            for (int i=0; i< reversed.Length; i++)
            {
                reversed[i] = input[len - i - 1];
                
            }

            return reversed;
        }
        public void ReverseInPlace (int[ ] input)
        {
            int len = input.Length;

            for (int i = 0; i < len/2; i++)
            {   //Input: 2 4 6 8
                //output 8 6 4 2
                int temp = input[i];

                input[i] = input[len - i - 1];
                input[len - i - 1] = temp ;

            }

        }


        public void ReverseToLeft (int[ ] input)
        {
            int len = input.Length;

            int temp = input[0];

            for (int i = 0; i < len - 1; i++)
            {
                input[i] = input[i+1];
            }

            input[input.Length - 1] = temp;



        }

    }
}




/*
 *         public int[ ] ReverseToLeft (int[ ] input)
        {
            int len = input.Length;

            int[ ] reversed = new int[len];

            for (int i = 0; i < reversed.Length-1; i++)
            {
                reversed[i] = input[i+1];
                reversed[reversed.Length-1] = input[0];

            }

            return reversed;


        }
*/