using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays
{
    class Program
    {
        static void PrintArray(int[] Array)
        {
            for (int i = 0; i < Array.Length; ++i)
            {
                Console.Write($"{Array[i]} ");
            }
            Console.WriteLine();
        }
        static int[] GenerateArray()
        {
            Random r = new Random();
            int[] Array = new int[r.Next(3, 9)];
            for (int i = 0; i < Array.Length; ++i)
            {
                Array[i] = r.Next(-100, 100);
            }
            return Array;
        }
        static void doFirstTask()
        {
            int[] Array = GenerateArray();
            int min = Array[0];

            Console.WriteLine("Array is:");
            PrintArray(Array);

            for (int i = 1; i < Array.Length; ++i)
            {
                if(Array[i] < min)
                {
                    min = Array[i];
                }
            }
            Console.WriteLine($"Min element is: {min}");
        }
        static void doSecondTask()
        {
            int[] Array = GenerateArray();
            int max = Array[0];

            Console.WriteLine("Array is:");
            PrintArray(Array);

            for (int i = 1; i < Array.Length; ++i)
            {
                if (Array[i] > max)
                {
                    max = Array[i];
                }
            }
            Console.WriteLine($"Max element is: {max}");
        }
        static void doThirdTask()
        {
            int[] Array = GenerateArray();
            int minIndex = 0;

            Console.WriteLine("Array is:");
            PrintArray(Array);

            for (int i = 1; i < Array.Length; ++i)
            {
                if (Array[i] < Array[minIndex])
                {
                    minIndex = i;
                }
            }
            Console.WriteLine($"Min element index is: {minIndex}");
        }
        static void doFourthTask()
        {
            int[] Array = GenerateArray();
            int maxIndex = 0;

            Console.WriteLine("Array is:");
            PrintArray(Array);

            for (int i = 1; i < Array.Length; ++i)
            {
                if (Array[i] > Array[maxIndex])
                {
                    maxIndex = i;
                }
            }
            Console.WriteLine($"Max element index is: {maxIndex}");
        }
        static void doFifthTask()
        {
            int[] Array = GenerateArray();
            int sum = 0;

            Console.WriteLine("Array is:");
            PrintArray(Array);

            for (int i = 1; i < Array.Length; i = i + 2)
            {
                sum += Array[i];
            }
            Console.WriteLine($"Sum is: {sum}");
        }

        static void doSixthTask()
        {
            int[] Array = GenerateArray();
            int temp;

            Console.WriteLine("Array is:");
            PrintArray(Array);

            for (int i = 0; i < Array.Length / 2; ++i)
            {
                temp = Array[Array.Length - 1 - i];
                Array[Array.Length - 1 - i] = Array[i];
                Array[i] = temp;
            }
            PrintArray(Array);
        }
        static void doSeventhTask()
        {
            int[] Array = GenerateArray();
            int sum = 0;

            Console.WriteLine("Array is:");
            PrintArray(Array);

            PrintArray(Array);
            for (int i = 0; i < Array.Length; ++i)
            {
                if(Array[i] % 2 == 1)
                {
                    sum += Array[i];
                }
            }
            Console.WriteLine($"Sum is: {sum}");
        }
        static void doEighthTask()
        {
            int[] Array = GenerateArray();
            int temp;
            Console.WriteLine("First array is:");
            PrintArray(Array);
            for (int i = 0; i < Array.Length / 2 ; ++i)
            {
                temp = Array[Array.Length / 2 + 1 + i];
                Array[Array.Length / 2 + 1 + i] = Array[i];
                Array[i] = temp;
            }
            Console.WriteLine("Last array is:");
            PrintArray(Array);
        }
        static void doNinthTask()
        {
            int[] Array = GenerateArray();
            int temp;
            Console.WriteLine("First array is:");
            PrintArray(Array);
            for(int i = 0; i < Array.Length; ++i)
            {
                temp = Array[i];

                int j;
                for (j = i; j > 0; --j)
                {
                    if (Array[j - 1] < temp)
                    {
                        break;
                    }
                    Array[j] = Array[j - 1];
                }
                Array[j] = temp;
            }
            Console.WriteLine("last array is:");
            PrintArray(Array);
           
        }

        static void doTenthTask()
        {
            int[] Array = GenerateArray();
            int temp;
            Console.WriteLine("First array is:");
            PrintArray(Array);
            for (int i = 0; i < Array.Length; ++i)
            {
                for(int j = i; j < Array.Length; ++j)
                {
                    if(Array[j] > Array[i])
                    {
                        temp = Array[i];
                        Array[i] = Array[j];
                        Array[j] = temp;
                        break;
                    }
                }
            }
            Console.WriteLine("Last array is:");
            PrintArray(Array);
        }
        static void Main(string[] args)
        {

            Console.Write("Choose task (if you want to quit enter 0): ");
            while (true)
            {
                int decision = Convert.ToInt32(Console.ReadLine());
                bool isDone = false;
                switch (decision)
                {
                    case 0:
                        isDone = true;
                        break;
                    case 1:
                        doFirstTask();
                        break;
                    case 2:
                        doSecondTask();
                        break;
                    case 3:
                        doThirdTask();
                        break;
                    case 4:
                        doFourthTask();
                        break;
                    case 5:
                        doFifthTask();
                        break;
                    case 6:
                        doSixthTask();
                        break;
                    case 7:
                        doSeventhTask();
                        break;
                    case 8:
                        doEighthTask();
                        break;
                    case 9:
                        doNinthTask();
                        break;
                    case 10:
                        doTenthTask();
                        break;
                    default:
                        Console.WriteLine("Input incorrect, please repeat: ");
                        break;
                }
                if (isDone)
                {
                    break;
                }
                Console.Write("Choose task (if you want to quit enter 0): ");
            }
        }
    }
}
