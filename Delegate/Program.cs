using System;
using System.Collections.Generic;





namespace Delegate
{
    class Program
    {
        
        delegate int Calculator<T>(T a , T b);// delegate 

        static void Main(string[] args)
        {
            Console.WriteLine("Please enter 1,2,3 or 4 , every number is  command type 1 = Add , 2= Minus , 3= Multiply , 4 = Divide!!");
            int command = Convert.ToInt32(Console.ReadLine());
            
            // enter numbers for calculations please
            Console.WriteLine("PLease enter numbers for calculations please");
            int a = Convert.ToInt32(Console.ReadLine());
            int b = Convert.ToInt32(Console.ReadLine());

            Calculator<int> calc;
           
            switch (command)
            {
                case 1:
                    calc = Add;
                    int result1= calc(a, b);
                    Console.WriteLine(result1);
                    break;
                case 2:
                    calc = Minus;
                    int result2=calc(a, b);
                    Console.WriteLine(result2);
                    break;
                case 3:
                    calc = Multiply;
                    int result3=calc(a, b);
                    Console.WriteLine(result3);
                    break;
                case 4:
                    calc = Divide;
                    int result4 = calc(a, b);
                    Console.WriteLine(result4);
                    break;
                default:
                    Console.WriteLine("Number you entered is not a command. PLease try again later!!");
                    break;
                    
            }
            
        }

        static T Add<T>( T a,  T b)
        {
            return (dynamic) a + b;
        }
        static T Minus<T>( T a,  T b)
        {
            return (dynamic) a - b;
        }
        static T Multiply<T>( T a,  T b)
        {
            return (dynamic) a * b;
        }
        static T Divide<T>( T a,  T b)
        {
            return (dynamic) a / b;
        }

    }
}