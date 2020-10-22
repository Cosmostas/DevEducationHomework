using System;

namespace DoubleArray
{
    class Program
    {
        static int[,] GenerateArray()
        {
            Random r = new Random();
            int[,] Array = new int[r.Next(2,6), r.Next(2, 6)];            

            for(int i = 0; i < Array.GetLength(0); ++i)
            {
                for(int j = 0; j < Array.GetLength(1); ++j)
                {
                    Array[i, j] = r.Next(-100,100);
                }
            }
            return Array;
        }

        static void PrintArray(int[,] Array)
        {

            for (int i = 0; i < Array.GetLength(0); ++i)
            {
                for (int j = 0; j < Array.GetLength(1); ++j)
                {
                    Console.Write($"{Array[i, j]} ");
                }
                Console.WriteLine();
            }
        }
        static void doFirstTask()
        {
            int[,] Array = GenerateArray();
            int min = Array[0, 0];

            Console.WriteLine("Array:\n");
            PrintArray(Array);

            for (int i = 0; i < Array.GetLength(0); ++i)
            {
                for (int j = 0; j < Array.GetLength(1); ++j)
                {
                    if(Array[i, j] < min)
                    {
                        min = Array[i, j];
                    }
                }
            }
            Console.WriteLine($"Min elem is: {min}");
        }

        static void doSecondTask()
        {
            int[,] Array = GenerateArray();
            int max = Array[0, 0];

            Console.WriteLine("Array:\n");
            PrintArray(Array);

            for (int i = 0; i < Array.GetLength(0); ++i)
            {
                for (int j = 0; j < Array.GetLength(1); ++j)
                {
                    if (Array[i, j] > max)
                    {
                        max = Array[i, j];
                    }
                }
            }

            Console.WriteLine($"Max elemis: {max}");
        }
        static void doThirdTask()
        {
            int[,] Array = GenerateArray();
            int minFirstIndex = 0;
            int minLastIndex = 0;

            Console.WriteLine("Array:\n");
            PrintArray(Array);

            for (int i = 0; i < Array.GetLength(0); ++i)
            {
                for (int j = 0; j < Array.GetLength(1); ++j)
                {
                    if (Array[i, j] < Array[minFirstIndex, minLastIndex])
                    {
                        minFirstIndex = i;
                        minLastIndex = j;
                    }
                }
            }

            Console.WriteLine($"Min elem index is: {minFirstIndex} {minLastIndex}");
        }
       
        static void doFourthTask()
        {
            int[,] Array = GenerateArray();
            int maxFirstIndex = 0;
            int maxLastIndex = 0;

            Console.WriteLine("Array:\n");
            PrintArray(Array);

            for (int i = 0; i < Array.GetLength(0); ++i)
            {
                for (int j = 0; j < Array.GetLength(1); ++j)
                {
                    if (Array[i, j] > Array[maxFirstIndex, maxLastIndex])
                    {
                        maxFirstIndex = i;
                        maxLastIndex = j;
                    }
                }
            }
            Console.WriteLine($"Max elem index is: {maxFirstIndex} {maxLastIndex}");
        }

        static void doFifthTask()
        {
            int[,] Array = GenerateArray();
            int amount = 0;

            Console.WriteLine("Array:\n");
            PrintArray(Array);

            for (int i = 0; i < Array.GetLength(0); ++i)
            {
                for (int j = 0; j < Array.GetLength(1); ++j)
                {
                    if (i == 0)
                    {
                        if(j == 0)
                        {
                            if(Array[i, j] > Array[i + 1, j] && Array[i, j] > Array[i, j + 1])
                            {
                                ++amount;
                            }
                        }
                        else if (j == Array.GetLength(1) - 1)
                        {
                            if (Array[i, j] > Array[i + 1, j] && Array[i, j] > Array[i, j - 1])
                            {
                                ++amount;
                            }
                        }
                        else
                        {
                            if (Array[i, j] > Array[i + 1, j] && Array[i, j] > Array[i, j - 1] && Array[i, j] > Array[i, j + 1])
                            {
                                ++amount;
                            }
                        }
                    }
                    else if (i == Array.GetLength(0) - 1)
                    {
                        if (j == 0)
                        {
                            if (Array[i, j] > Array[i - 1, j] && Array[i, j] > Array[i, j + 1])
                            {
                                ++amount;
                            }
                        }
                        else if (j == Array.GetLength(1) - 1)
                        {
                            if (Array[i, j] > Array[i - 1, j] && Array[i, j] > Array[i, j - 1])
                            {
                                ++amount;
                            }
                        }
                        else
                        {
                            if (Array[i, j] > Array[i - 1, j] && Array[i, j] > Array[i, j - 1] && Array[i, j] > Array[i, j + 1])
                            {
                                ++amount;
                            }
                        }
                    }
                    else
                    {
                        if (j == 0)
                        {
                            if (Array[i, j] > Array[i - 1, j] && Array[i, j] > Array[i + 1, j] && Array[i, j] > Array[i, j + 1])
                            {
                                ++amount;
                            }
                        }
                        else if (j == Array.GetLength(1) - 1)
                        {
                            if (Array[i, j] > Array[i - 1, j] && Array[i, j] > Array[i + 1, j] && Array[i, j] > Array[i, j - 1])
                            {
                                ++amount;
                            }
                        }
                        else
                        {
                            if (Array[i, j] > Array[i - 1, j] && Array[i, j] > Array[i + 1, j] && Array[i, j] > Array[i, j - 1] && Array[i, j] > Array[i, j + 1])
                            {
                                ++amount;
                            }
                        }
                    }
                }
            }
            Console.WriteLine($"Amount is: {amount}");
        }
       

        static void doSixthTask()
        {
            int[,] Array = GenerateArray();
            int[,] ArrayT = new int[Array.GetLength(1), Array.GetLength(0)];

            for(int i = 0; i < Array.GetLength(0); ++i)
            {
                for (int j = 0; j < Array.GetLength(1); ++j)
                {
                    ArrayT[j, i] = Array[i, j];
                }
            }
            Console.WriteLine("First Array:\n");
            PrintArray(Array);
            Console.WriteLine("Final Array:\n");
            PrintArray(ArrayT);
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
