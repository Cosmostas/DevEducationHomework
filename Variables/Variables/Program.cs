using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Variables
{
    class Program
    {
        static void doFirstTask()
        {
            Console.WriteLine("Please, enter two number: ");
            int A = Convert.ToInt32(Console.ReadLine());
            int B = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine($"Answer is: {(5 * A + B * B) / (B - A)}");

        }
        static void doSecondTask()
        {
            Console.WriteLine("Please, enter A and B: ");
            int A = Convert.ToInt32(Console.ReadLine());
            int B = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"Variables before swap: A : {A}, B : {B}");
            int temp;
            temp = A;
            A = B;
            B = temp;
            Console.WriteLine($"Variables after swap: A : {A}, B : {B}");

        }
        static void doThirdTask()
        {
            Console.WriteLine("Please, enter A and B: ");
            int A = Convert.ToInt32(Console.ReadLine());
            int B = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"A / B: {A / B}\n A mod B: {A % B}");

        }
        static void doFourthTask()
        {
            Console.WriteLine("Please, enter A, B and C: ");
            int A = Convert.ToInt32(Console.ReadLine());
            int B = Convert.ToInt32(Console.ReadLine());
            int C = Convert.ToInt32(Console.ReadLine());    
            Console.WriteLine($"X is: {(C - B) / A}");

        }
        static void doFifthTask()
        {
            Console.WriteLine("Please, enter X1, Y1, X2, Y2: ");
            int X1 = Convert.ToInt32(Console.ReadLine());
            int Y1 = Convert.ToInt32(Console.ReadLine());
            int X2 = Convert.ToInt32(Console.ReadLine());
            int Y2 = Convert.ToInt32(Console.ReadLine());
            float A = (Y2 - Y1) / (X2 - X1);
            float B = Y2 - X2 * A;
            Console.WriteLine($"Answer is: Y = {A} * X + {B}");
        }
        static void Main(string[] args)
        {
            Console.ReadKey();
        }
    }
}
