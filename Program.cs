using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms_Example
{
    class Program
    {
        static void Main (string[ ] args)
        {   
            //**STRING ALGORITHMS**

                    StringAlgorithms obj = new StringAlgorithms();
 
                    Console.WriteLine(obj.findMaximum(1, 2, 4));
                    Console.WriteLine(obj.findMaximum2(1, 2, 4));

                    //Validation Examples

                    Console.WriteLine(obj.isLowerCase("HELLO"));

                    Console.WriteLine(obj.isUpperCase("helloo"));

                    Console.WriteLine(obj.isPasswordComplex("Hello1"));
                    Console.WriteLine(obj.isPasswordComplex("HEllo1"));
                    Console.WriteLine(obj.isPasswordComplex("hello"));
                    Console.WriteLine(obj.isPasswordComplex(" "));

                    //Normalize Examples
                    Console.WriteLine(obj.normalizeString("  Hello There, BUDDY     "));

                    //Parse and Search String Examples
                    obj.ParseContents("helloq");

                    Console.WriteLine(obj.IsAtEvenIndex("helloq", 'l'));
                    Console.WriteLine(obj.IsAtEvenIndex("helloq", 'q'));

                    Console.WriteLine(obj.IsAtEvenIndex("", 'l'));

                    //5- Reverse Each Word

                    Console.WriteLine(obj.Reverse("hello world"));
                    Console.WriteLine(obj.Reverse("hello world*?***"));
                    Console.WriteLine(obj.Reverse(""));
                    Console.WriteLine(obj.Reverse("hello123"));
                    Console.WriteLine(obj.Reverse(null));


                    //6- Reverse Each Word Concept 2

                    Console.WriteLine(obj.Reverse("hello world"));
                    Console.WriteLine(obj.Reverse("hello world*?***"));
                    Console.WriteLine(obj.Reverse(""));
                    Console.WriteLine(obj.Reverse("hello123"));
                    Console.WriteLine(obj.Reverse(null));

                    //7- Reverse Sentence 
                    Console.WriteLine("Reverse Sentence ");
                    Console.WriteLine("------------------------------");
                    Console.WriteLine(obj.ReverseSentence("HELLo         world"));
                    Console.WriteLine(obj.ReverseSentence("HELLo         world   third word"));



            //ARRAY ALGORITHMS 
            Console.WriteLine("\n\nARRAY ALGORITHMS\n\n");
            ArrayAlgorithms arrayObj = new ArrayAlgorithms();

            //Linear Search

            int[ ] arr = { 1, 2, 3, 4, 5, 6 };
            
            Console.WriteLine(arrayObj.LinearSearch1(arr, 4));
            Console.WriteLine(arrayObj.LinearSearch2(arr, 9));

            //Built in Function
            int item = Array.Find(arr, element => element == 3);
            Console.WriteLine(item);

            int[] items = Array.FindAll(arr, element => element >= 5);
            Array.ForEach(items, Console.WriteLine);

            //Binary Search
            Console.WriteLine(arrayObj.BinarySearch(arr, 5));

            //Built in Function
            Array.BinarySearch(arr, 1);


            //Find Even Numbers
            ArrayAlgorithms obj2 = new ArrayAlgorithms();

            int[ ] arr1 = {-8,2,3,-9,11,-20};
            int[ ] arr2 = { 0,-2,-9,-39,39,10,7 };

            int[ ] evenArr = obj2.FindEvenNumbers(arr1, arr2);

            Console.WriteLine("Even Array:");
            Array.ForEach(evenArr, Console.WriteLine);

            //Reverse array
            int[ ] arr3 = { 1,2,3,5,7,22,23456};
            Array.ForEach(arr3, Console.WriteLine);

            Array.ForEach(obj2.Reverse(arr3), Console.WriteLine);


            //Reverse array
            int[ ] arr4 = { 1, 2, 3, 5, 7 };
            Array.ForEach(arr4, Console.WriteLine);
            obj2.ReverseInPlace(arr4);
            Array.ForEach(arr4, Console.WriteLine);


            //rotate Array : Create an algorithm that rotates the contents of an array to the left by one space
            //Input 1,2,3,4,5,6
            //output 2,3,4,5,6,1

            int[ ] arr5 = { 1, 2, 3, 4, 5, 6 ,0};
            Console.WriteLine("Rotate Array");
            obj2.ReverseToLeft(arr5);
            Array.ForEach(arr5, Console.WriteLine);

            //Linked List 


            LinkedList<string> listy = new LinkedList<string>();
            listy.AddLast("Sarah");
            listy.AddLast("polly");
            listy.AddLast("rebecca");
            listy.AddLast("jack");

            Console.WriteLine(listy.Contains("jack"));
            Console.WriteLine(listy.Count);

            listy.RemoveFirst();

            foreach (string i in listy)
            {
                Console.Write(i+"->");
            }
            Console.WriteLine();
            Console.ReadLine();


        }


    }
}