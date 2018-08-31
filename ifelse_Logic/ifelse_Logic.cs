using System;
using System.Collections.Generic;

namespace ifelse_Logic
{
    class Program
    {
        static void Main(string[] args)
        {

            List<string> myList = new List<string> { "James", "Jarryd", "Kevin", "Gabe", "Ketchup", "Mustard" ,"santhosh"};
            List<string> myList1 = new List<string>();
            string[] array1 = new string[2];
            string[] array2 = new string[2];
            string[] array3 = new string[2];
            int j = 0, k = 0, l = 0;

            for (var i = 0; i < myList.Count; i++)
            {
                if (myList[i].StartsWith('J'))
                {
                    array1[j] = myList[i];
                    j++;
                 
                 
                }

                else if (myList[i].StartsWith('K'))
                {
                    array2[k] = myList[i];
                    k++;


                }

                else
                    array3[l] = myList[i];
                l++;


            }
            Console.WriteLine("The elements in array1 are {0},{1}", array1[0], array1[1]);
            Console.WriteLine("The elements in array2 are {0},{1}", array2[0], array2[1]);
            Console.WriteLine("The elements in array3 are {0},{1}", array3[0], array3[1]);

            Console.ReadLine();

        }
    }
}
