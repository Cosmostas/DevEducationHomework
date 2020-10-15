using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Branching
{
    class Program
    {
        static void doFirstTask()
        {
            Console.WriteLine("Please, enter A and B: ");
            int A = Convert.ToInt32(Console.ReadLine());
            int B = Convert.ToInt32(Console.ReadLine());
            int ans;
            if(A > B)
            {
                ans = A + B;
            }
            else if(A == B)
            {
                ans = A * B;
            }
            else
            {
                ans = A - B;
            }

            Console.WriteLine($"Answer is: {ans}");
        }
        static void doSecondTask()
        {
            Console.WriteLine("Please, enter X and Y: ");
            int X = Convert.ToInt32(Console.ReadLine());
            int Y = Convert.ToInt32(Console.ReadLine());
            if (X >= 0 && Y >= 0)
            {
                Console.WriteLine("Dot belongs to the first quarter");
            }
            else if (X < 0 && Y >= 0)
            {
                Console.WriteLine("Dot belongs to the second quarter");
            }
            else if (X < 0 && Y < 0)
            {
                Console.WriteLine("Dot belongs to the third quarter");
            }
            else
            {
                Console.WriteLine("Dot belongs to the fourth quarter");
            }
        }
        static void doThirdTask()
        {
            Console.WriteLine("Please, enter A, B and C: ");
            int A = Convert.ToInt32(Console.ReadLine());
            int B = Convert.ToInt32(Console.ReadLine());
            int C = Convert.ToInt32(Console.ReadLine());
            
            if (A >= B)
            {
                if (C >= A)
                {
                    Console.WriteLine($"{B} {A} {C}");
                }
                else
                {
                    Console.WriteLine($"{B} {C} {A}");
                }
            }
            else
            {
                if (C >= B)
                {
                    Console.WriteLine($"{A} {B} {C}");
                }
                else
                {
                    Console.WriteLine($"{A} {C} {B}");
                }
            }
        }
        static void doFourthTask()
        {
            Console.WriteLine("Please, enter A, B and C: ");
            int A = Convert.ToInt32(Console.ReadLine());
            int B = Convert.ToInt32(Console.ReadLine());
            int C = Convert.ToInt32(Console.ReadLine());

            float D = B * B - 4 * A * C;

            if(D > 0)
            {
                Console.WriteLine($"X1: { (-B + Math.Round(Math.Sqrt(D), 3) ) / (2 * A) }; X2 : { (-B - Math.Round(Math.Sqrt(D), 3) ) / (2 * A) }");
            }
            else if (D == 0){
                Console.WriteLine($"X : { -B / (2 * A) }");
            }
            else
            {
                Console.WriteLine($"X1: {-B} + {Math.Round(Math.Sqrt(-D), 3)}i / (2 * {A}); X2: {-B} - {Math.Round(Math.Sqrt(-D), 3)}i / (2 * {A})")    ;
            }
        }
        static void doFifthTask()
        {
            // Не уверен что в данном разделе можно решать через массив, поэтому условия
            // Не очень красивое решение с возвратом нуля, для окончания работы функции, но не очень хотелось липить еще больше условий
            Console.WriteLine("Please, enter two-digit number: ");
            string input = Console.ReadLine();
            if (input[0] == '1')
            {
                switch (input[1])
                {
                    case '0':
                        Console.Write("ten");
                        break;
                    case '1':
                        Console.Write("eleven");
                        break;
                    case '2':
                        Console.Write("twelve");
                        break;
                    case '3':
                        Console.Write("thirteen");
                        break;
                    case '4':
                        Console.Write("fourteen");
                        break;
                    case '5':
                        Console.Write("fifteen");
                        break;
                    case '6':
                        Console.Write("sixteen");
                        break;
                    case '7':
                        Console.Write("seventeen");
                        break;
                    case '8':
                        Console.Write("eighteen");
                        break;
                    case '9':
                        Console.Write("nineteen");
                        break;
                }
            }
            else
            {
                switch (input[0])
                {
                    case '2':
                        Console.Write("twenty ");
                        break;
                    case '3':
                        Console.Write("thirty ");
                        break;
                    case '4':
                        Console.Write("forty ");
                        break;
                    case '5':
                        Console.Write("fifty ");
                        break;
                    case '6':
                        Console.Write("sixty ");
                        break;
                    case '7':
                        Console.Write("seventy ");
                        break;
                    case '8':
                        Console.Write("eighty ");
                        break;
                    case '9':
                        Console.Write("ninety ");
                        break;
                }
                switch (input[1])
                {
                    case '1':
                        Console.Write("one");
                        break;
                    case '2':
                        Console.Write("two");
                        break;
                    case '3':
                        Console.Write("three");
                        break;
                    case '4':
                        Console.Write("four");
                        break;
                    case '5':
                        Console.Write("five");
                        break;
                    case '6':
                        Console.Write("six");
                        break;
                    case '7':
                        Console.Write("seven");
                        break;
                    case '8':
                        Console.Write("eight");
                        break;
                    case '9':
                        Console.Write("nine");
                        break;
                }
            }
            Console.WriteLine();
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
