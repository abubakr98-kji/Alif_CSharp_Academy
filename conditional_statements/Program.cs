using System;
using System.Formats.Asn1;
using System.Linq;

namespace conditional_statements
{
    class Program
    {
        static void Main(string[] args)
        {
            Home work #2
             int enterNum = Convert.ToInt32(Console.ReadLine());
            
             if ((enterNum >= 500) && (enterNum <= 1000))
             {
                 var percentage3 = enterNum * 3 / 100;
                 var payment3 = enterNum - percentage3;
                 Console.WriteLine(
                     $"Number you entered is more than more than 500 and less than 1000  and discount is: {percentage3}\n and payment amount with discount is {payment3}");
             }
             else if (enterNum >= 1000)
             {
                 var percentage5 = enterNum * 5 / 100;
                 var payment5 = enterNum - percentage5;
                 Console.WriteLine(
                     $"Number you entered is more than more than 500 and less than 1000  and discount is: {percentage5}\n and payment amount with discount is {payment5}");
            
             }
             else if (enterNum < 500)
             {
                 Console.WriteLine("Number you entered is less than 500. No discount for you!!!");
             }

            
            // home work 3

            var num1 = Convert.ToInt32(Console.ReadLine());
            var num2 = Convert.ToInt32(Console.ReadLine());
            var num3 = Convert.ToInt32(Console.ReadLine());
            var num4 = Convert.ToInt32(Console.ReadLine());
            
            if (( num1 == num2) && ( num3==num4) )
            {
                Console.WriteLine((num1*num2)*(num3*num4));
            }else if ((num1<num2) && (num2<num3) && (num3<num4))
            {
                Console.WriteLine("Numbers are collected form lowest to highest!!");
                          
            } else if (num1>num2 && num3>num4 )
            {
                Console.WriteLine("this shit is working");
            }else if (true)
            {
                int[] check = {num1,num2,num3,num4 };
                int hello = check.Min();
                Console.WriteLine(hello);
            }

            
            //home work 4

            var a = Convert.ToInt32(Console.ReadLine());
            var b = Convert.ToInt32(Console.ReadLine());
            var c = Convert.ToInt32(Console.ReadLine());
            
            if ((a > b || a == b) && (c < b))
            {
                Console.WriteLine($"{a}>={b}>={c}");
            }
            else if (a < b && b > c)
            {
                int aa = a;
                int bb = b;
                int cc = c;
                a = bb;
                b = cc;
                c = aa;
              
                Console.WriteLine($"{a}>={b}>={c}");
            }else if(a==b && b==c)
            {
                    Console.WriteLine($"{a}>={b}>={c}");   
            }else if ((c>a && c>b) ||c>=a && c>=b )
            {
                int a1 = a;
                int a2 = b;
                int a3 = c;
            
                a = c;
                c = a1;
                Console.WriteLine($"{a}>={b}>={c}");
            }else if (a>b && b==c)
            {
                int a4 = a;
                int a5 = b;
                int a6 = c;
                
                Console.WriteLine($"{a}>={b}>={c}");
                
            }else if (a>b && b<c)
            {
                int a7 = a;
                int a8 = b;
                int a9 = c;
            
                b =a9;
                c = a8;
                
                Console.WriteLine($"{a}>={b}>={c}");
            }

        }
    }
}

