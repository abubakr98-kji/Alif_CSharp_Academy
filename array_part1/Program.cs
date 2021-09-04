using System;
using System.Security.Cryptography.X509Certificates;
using System.Xml;

namespace array_part1
{
    class Program
    {
        static void Main(string[] args)
        {

            ///home work 1.a
            int a = Convert.ToInt32(Console.ReadLine());
            int b = Convert.ToInt32(Console.ReadLine());

            int sum = 0;

            for (int i = a + 1; i < b; i++)
            {
                sum += i;

                Console.WriteLine($"Sum of numbers between a and b is:{sum}");
            }

            //home work 1.b

            int aa = Convert.ToInt32(Console.ReadLine());
            int bb = Convert.ToInt32(Console.ReadLine());

            for (int j = aa + 1; j < bb; j++)
            {
                if (j % 2 == 1)
                {
                    Console.WriteLine(j);
                }
            }



            /*home work 3*/
            /* Прямоугольник*/
            int num = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < num; i++)
            {
                Console.Write("*");
                for (int j = 0; j < num; j++)
                {
                    Console.Write("*");
                }

                Console.WriteLine();
            }



            /*Прямоугольный трегольник*/
            for (int i = 0; i <= 7; i++)
            {
                for (int j = 0; j < i; j++)
                {
                    Console.Write("*");
                    Console.Write(" ");
                }

                Console.WriteLine();
            }

            Console.Write("\n");
            Console.Write("\n");
            Console.Write("\n");




            /*Равностороний треугольник*/

            int number, r, y, count = 1;
            Console.Write("Enter number of rows:");
            number = int.Parse(Console.ReadLine());
            count = number - 1;
            for (y = 1; y <= number; y++)
            {
                for (r = 1; r <= count; r++)
                    Console.Write(" ");
                count--;
                for (r = 1; r <= 2 * y - 1; r++)
                    Console.Write("*");
                Console.WriteLine();
            }


            /*Rhombus*/

            Console.Write("Enter the maximum number of *: ");
            int n = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("\nHere is the Diamond of Stars\n");

            for (int i = 1; i <= n; i++)

            {
                for (int j = 0; j < (n - i); j++)
                    Console.Write(" ");
                for (int j = 1; j <= i; j++)
                    Console.Write("*");
                for (int k = 1; k < i; k++)
                    Console.Write("*");
                Console.WriteLine();
            }

            for (int i = n - 1; i >= 1; i--)
            {

                for (int j = 0; j < (n - i); j++)

                    Console.Write(" ");

                for (int j = 1; j <= i; j++)

                    Console.Write("*");

                for (int k = 1; k < i; k++)

                    Console.Write("*");

                Console.WriteLine();
            }

            Console.WriteLine();
            
            /*Home Work*/
            int first_Deposite = 1000;

            int month = 12;

            // int max_value = 25;
            int c;

            int d;

            for (c = 1; c<25; c++)
            {
                for (d = 1; d < month; d++)
                {
                    int calc = ((first_Deposite * c) / 100);
                    first_Deposite += calc;
                    if (first_Deposite <= 1100)
                    {
                        Console.WriteLine($"Month{d}/ Percantage {c} = {first_Deposite}");
                    }
                    else if (first_Deposite > 1100)
                    {
                        first_Deposite = 1000;
                        break;
                    }

                }

            }
            
        }

    }

}







