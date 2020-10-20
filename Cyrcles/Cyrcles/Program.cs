using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cyrcles
{
    class Program
    {
        static void doFirstTask()
        {
            Console.Write("Please, enter A and B: ");
            int A = Convert.ToInt32(Console.ReadLine());
            int B = Convert.ToInt32(Console.ReadLine());

            int ans = 1;
            while(B != 0)
            {
                ans *= A;
            }
            Console.WriteLine($"Answer is: {ans}");
        }
        static void doSecondTask()
        {
            Console.Write("Please, enter A: ");
            int A = Convert.ToInt32(Console.ReadLine());

            for(int i = A; i <= 1000; ++i)
            {
                if(i % A == 0)
                {
                    Console.Write($"{i} ");
                }
            } 

        }
        static void doThirdTask()
        {
            Console.Write("Please, enter A: ");
            int A = Convert.ToInt32(Console.ReadLine());
            int amount = 0;

            for(int i = 1; i < A; ++i)
            {
                if(i *i > A)
                {
                    break;
                }
                else
                {
                    ++amount;
                }
            }
            Console.WriteLine($"Answe is: {amount}");
        }
        static void doFourthTask()
        {
            Console.Write("Please, enter A: ");
            int A = Convert.ToInt32(Console.ReadLine());
            int ans = A - 1;
            while(A % ans == 0)
            {
                if(ans == 1)
                {
                    break;
                }
                --ans;
            }
            Console.WriteLine($"Answer is: {ans}");
        }
        static void doFifthTask()
        {
            Console.Write("Please, enter A and B: ");
            int A = Convert.ToInt32(Console.ReadLine());
            int B = Convert.ToInt32(Console.ReadLine());
            int step;

            if(A > B)
            {
                step = -1;
            }
            else
            {
                step = 1;
            }

            int ans = 0;
            for(int i = A; i != B; i += step)
            {
                if(i % 7 == 0)
                {
                    ans += i;
                }
            }
            Console.WriteLine($"Answer is: {ans}");
        }

        static void doSixthTask()
        {
            Console.Write("Please, enter N: ");
            int N = Convert.ToInt32(Console.ReadLine());
            int firstNum = 1;
            int secondNum = 1;
            int temp;

            for(int i = 0; i < N - 2; ++i)
            {
                temp = firstNum + secondNum;
                firstNum = secondNum;
                secondNum = temp;
            }
            Console.WriteLine($"Answer is: {secondNum}");
        }
        static void doSeventhTask()
        {
            Console.Write("Please, enter A and B: ");
            int A = Convert.ToInt32(Console.ReadLine());
            int B = Convert.ToInt32(Console.ReadLine());

            while(A != B)
            {
                if(A > B)
                {
                    A -= B;
                }
                else
                {
                    B -= A;
                }
            }
            Console.WriteLine($"Answer is: {A}");
        }
        static void doEighthTask()
        {
            Console.Write("Please, enter N: ");
            int N = Convert.ToInt32(Console.ReadLine());
            int rightBorder = N;
            int leftBorder = 1;
            int ans = (leftBorder + rightBorder) / 2;
            
            while(ans*ans*ans != N)
            {
                if(ans*ans*ans > N)
                {
                    rightBorder = ans;
                }
                else
                {
                    leftBorder = ans;
                }
                ans = (leftBorder + rightBorder) / 2;

            }
            Console.WriteLine($"Answer is: {ans}");
        }
     static void doNinthTask()
        {
            Console.Write("Please, enter A: ");
            string A = Console.ReadLine();

            int ans = 0;
            for(int i = 0; i < A.Length; ++i)
            {
                if(Convert.ToInt32(A[i]) % 2 != 0)
                {
                    ++ans;
                }
            }
            Console.WriteLine($"Answer is: {ans}");
        }

        static void doTenthTask()
        {
            Console.Write("Please, enter String: ");
            string Str = Console.ReadLine();

            string ans = "";
            for (int i = 0; i < Str.Length; ++i)
            {
                ans += Str[Str.Length - i - 1];
            }
            Console.WriteLine($"Answer is: {ans}");
        }
        static void doEleventhTask()
        {
            Console.Write("Please, enter N: ");
            int N = Convert.ToInt32(Console.ReadLine());
            int ans = 0;
            int amountOdd = 0;
            int amountEven = 0;
            int curentNum;

            for (int i = 1; i <=N; ++i)
            {
                curentNum = i;
                while(curentNum != 0)
                {
                    if(curentNum % 2 != 0)
                    {
                        amountOdd += curentNum % 10;
                    }
                    else
                    {
                        amountEven += curentNum % 10;
                    }
                    curentNum /= 10; 
                }
                if (amountEven > amountOdd)
                {
                    ++ans;
                }
                amountOdd = 0;
                amountEven = 0;
            }
            Console.WriteLine($"Answer is: {ans}");
        }
        static void doTwelfthTask()
        {
            Console.Write("Please, enter A and B: ");
            string A = Console.ReadLine();
            string B = Console.ReadLine();

            bool isThereEquel = false;
            for(int i = 0; i < A.Length; ++i)
            {
                if (isThereEquel)
                {
                    break;
                }

                for(int j = 0; j < B.Length; ++j)
                {
                    if(A[i] == B[j])
                    {
                        isThereEquel = true;
                        break;
                    }
                }
            }

            if (isThereEquel)
            {
                Console.WriteLine("Yes");
            }
            else
            {
                Console.WriteLine("No");
            }
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
                    case 11:
                        doEleventhTask();
                        break;
                    case 12:
                        doTwelfthTask();
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
