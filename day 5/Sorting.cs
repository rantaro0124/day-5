using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace day_5
{
    class Sort
    {
        public static void Main()
        {
            String Ans;
            do
            {
                Sort test = new Sort();
                test.run();
                Console.WriteLine("Would you like test more?|| If you need, Press Y, else Press any Key to exit");
                Ans = Console.ReadLine();
            }
            while (Ans == "Y");
            
        }
     
        public void run()
        {
            int size = GetSizeOfArray();

            int[] arr = GetArrFromUserInput(size);
            Console.Write("Inputed Array:");
            PrintArr(arr);
            int[] sortedArr = SortArr(arr);
            Console.Write("Sorted Array:");
            PrintArr(sortedArr);
        }

        private int[] SortArr(int[] arr)
        {
            
            int [] aRR = arr; 
            int temp = 0;
            for (int i = 0; i < aRR.Length; i++)
            {
                for (int j = i+1; j < aRR.Length; j++)
                {
                    if (aRR[i] > aRR[j])
                    {
                        temp = aRR[i];
                        aRR[i] = aRR[j];
                        aRR[j] = temp;
                    }
                }
                
            }

            return aRR;
        }

        private void PrintArr(int[] arr)
        {
            int[] Item=arr;
            // in ra mang
            
            for (int i = 0; i < Item.Length; i++)
            {
                Console.Write(" {0} ", Item[i]);
            }

            Console.ReadLine();
        }

        private int[] GetArrFromUserInput(int size)
        {

            bool needInputAgain = true;
            int[] arrayWhichUserInput = new int[size];
            string stringUserInput;
            // Cho user nhap cac phan tu trong mang de tao thanh 1 mang voi so luong da dinh ban dau


            for (int i = 0; i < size; i++)
            {
               
                    do
                    {
                        Console.Write("Input item at index {0}:", i);
                        stringUserInput = Console.ReadLine();
                        try
                        {
                            
                        arrayWhichUserInput[i] = int.Parse(stringUserInput);                        
                        needInputAgain = false;
                        }

                        catch (Exception e)
                        {
                            Console.WriteLine("Unexpected input! Please try again:");
                            needInputAgain = true;
                        }

                    } while (needInputAgain);

                
            }



            return arrayWhichUserInput;
        }

        private int GetSizeOfArray()
        {
            Console.Write("Input expected array size:");
            bool needInputAgain1 = false;
            int sizeOfArray = 0;
            string stringOfSize="1";
            
                do
                {
                    stringOfSize = Console.ReadLine();
                    try
                    {
                    sizeOfArray = int.Parse(stringOfSize);
                    needInputAgain1 = false;
                    }
                    catch (Exception e)
                    {
                        Console.WriteLine("Unexpected input! Please try again:");
                        needInputAgain1 = true;

                    }
               
                } while (needInputAgain1);

            
           
            //Cho user nhap va tra ve so luong phan tu trong mang ma user muon
            return sizeOfArray;
        }
    }
}



/*
 * Input expected array size: 4
 * Input item at index 0: 8
 * Input item at index 1: a
 * Unexpected input! Please try again: x
 * Unexpected input! Please try again: 9
 * Input item at index 2: 2
 * Input item at index 3: 4
 * Inputed Array: 8 9 2 4
 * Sorted Array: 2 4 8 9
 */
