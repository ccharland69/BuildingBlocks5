using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuildingBlocks2
{
    class Program
    {
        static void Main(string[] args)
        {
            {
                AddTwoNumbers(32, 45);
                DivideTwoNumbers(48, 4);
                SubtractTwoNumbers(442, 208);
                MultiplyTwoNumbers(3, 102);
                ShowRemainder(10, -8);
            }

            static void AddTwoNumbers(int a, int b)
            {
                int c = a + b;
                Console.WriteLine("Addition of 23 and 45 = " + c);
            }

            static void DivideTwoNumbers(int d, int c)
            {
                int e = d / c;
                Console.WriteLine("Division of 48 by 4 = " + e);
            }

            static void SubtractTwoNumbers(int f, int g)
            {
                int h = f - g;
                Console.WriteLine("Subtracting 208 from 442 = " + h);
            }

            static void MultiplyTwoNumbers(int i, int j)
            {
                int k = i * j;
                Console.WriteLine("Multiplying 3 by 102 = " + k);
            }

            static void ShowRemainder(int l, int m)
            {
                int n = l % m;
                Console.WriteLine("The remainder of 10 and -8 = " + n);
            }

            try
            {
                int a, b, c;
                Console.WriteLine("enter a numeric value for a");
                a = int.Parse(Console.ReadLine());
                Console.WriteLine("enter a numeric value for b");
                b = int.Parse(Console.ReadLine());

                c = a / b;
                Console.WriteLine("Division of a by b is = " + c);
            }
            catch (DivideByZeroException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch (FormatException ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                Console.WriteLine("Program Exceuted");
            }
            {
                var sentence = "The quick brown fox jumps over the lazy dog.";
                Console.WriteLine(sentence);
            }

        }
    }
}

