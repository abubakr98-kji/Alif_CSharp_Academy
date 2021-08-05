using System;
using Microsoft.VisualBasic;

namespace Program
{
    class Program
    {
        static void Main(string[] args)
        {
            /////////////////////// Home Work 1
            double number1 = 16.80D;
            double number2 = 12.400D;
            Console.WriteLine(Math.Sqrt(number1 * number2));
            ///////////////////////////// Home Work 2
            double a = 1.40D;
            double b = -5.50D;
            double c = 0.60D;

            double ac = a - c;
            double bc =  c-(b);
            Console.WriteLine(ac+bc);
            ////////////////////////////////////////// Home Work 3
            
            double x1 = -6.20D;
            double y1 = 5.20D;
            double x2 = 2.10D;
            double y2 = 9.80D;
            double firstResult = x2 - x1;
            double secondResult = y2 - y1;
            double calculationX1 = Math.Pow(firstResult,2 ) ;
            double calculationY1 = Math.Pow(secondResult,2 ) ;
            double totalResult = calculationX1 + calculationY1;
            
            Console.WriteLine(Math.Sqrt(totalResult ) );
            
            ///////////////////////////////////////// Home Work 4 
            
            int num1 = 4;
            int num2 = 1;
            Console.WriteLine($"{num2}{num1}");
            
            ///////////////////////////////////////////Home Work 5
            
            int N = 10985;
            int result = N / 60;
            Console.WriteLine(decimal.Round(result));
            
            //////////////////////////////////////////
            int sunday = 0;
            int monday = 1;
            int tuesday = 2;
            int wednsday = 3;
            int thursday = 4;
            int friday = 5;
            int saturday = 6;

            int dayK = 202;
            int dayToMonth = dayK % 7;
            Console.WriteLine(dayToMonth);

        }
    }
}