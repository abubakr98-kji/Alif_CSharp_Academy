using System;


namespace LogicalOperators
{
    class Program
    {
        static void Main(string[] args)
        {
            // Home Work 2
            int b = Convert.ToInt32(Console.ReadLine());
            int c = Convert.ToInt32(Console.ReadLine());
            if ((b>c) )
            {
                b = b;
                c = b;
               Console.WriteLine($"Expression b: {b} , Expression c: {c}");
            }else if (b>c)
            {
                b = c;
                c = c;
                Console.WriteLine($"Expression b: {b}, Expression c: {c}"); 
            }else if(b==c)
            {
                b = 0;
                c = 0;
                Console.WriteLine(($"Expression b: {b}, Expression c: {c}"));
            }

            

            // Home Work 3
             int operand1 = int.Parse(Console.ReadLine());
             int operand2 = int.Parse(Console.ReadLine());
             string sign = Console.ReadLine();
             
             switch (sign)
             {
                 case "+" :
                     Console.WriteLine(operand1+operand2);
                     break;
                 case "-":
                     Console.WriteLine(operand1-operand2);
                     break;
                 case "*":
                     Console.WriteLine(operand1*operand2);
                     break;
                 case "/"  :
                     Console.WriteLine(operand1/operand2);
                     break;
                 

             }
             if (sign=="/" ||  operand2==0 )
             {
                 Console.WriteLine("you are wrong");        
             }




             // Home Work 4
             // int enter = Convert.ToInt32(Console.ReadLine() );
             // switch (enter)
             // {
             //     case   < 0 :
             //         Console.WriteLine("Число не входит в прописаный промежуток!");
             //         break;
             //     case  <= 14 :
             //         Console.WriteLine("Вы ввели число в промежутке от 0-14");
             //         break;
             //     case   <= 35 :
             //         Console.WriteLine("Вы ввели число в промежутке от 15-35");
             //         break;
             //     case   <= 50 :
             //         Console.WriteLine("Вы ввели число в промежутке от 36-50");
             //         break;
             //     case   <= 100 :
             //         Console.WriteLine("Вы ввели число в промежутке от 50-100");
             //         break;
             //     case >100:
             //         Console.WriteLine("Число выше указанного промежутка!");
             //         break;
             // }

             // home work 4 , 2-nd way 

             int clinentEnter = Convert.ToInt32(Console.ReadLine() );
             if ((clinentEnter == 0) ||  (clinentEnter <=14) )
             {
                 Console.WriteLine("Number you wrote is in interval  0-14");
             }else if (clinentEnter < 0)
             {
                 Console.WriteLine("Number you wrote is not in interval  0-100???!");
                 
             }else if ((clinentEnter==15) ||  (clinentEnter<=35))
             {
                 Console.WriteLine("Number you wrote is in interval  15-35");
             }else if ((clinentEnter==36) || (clinentEnter <= 50) )
             {
                 Console.WriteLine("Number you wrote is in interval  36-50");
             }else if ((clinentEnter==50) || (clinentEnter<=100) )
             {
                 Console.WriteLine("Number you wrote is in interval  50-100!!!!");
             }else if (clinentEnter>100)
             {
                 Console.WriteLine("Number is greater than  0-100!");
             }


        }
    }
}