using System;
using System.Collections.Generic;
using System.Linq;

namespace Class_Part_One
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Array Part Two , Task 2 , Start*/
            /*Min and Max*/            
            
            int size = Convert.ToInt32(Console.ReadLine());
            int[] grades = new int[size];
            int  max, min;
          
          for (int i = 0; i < grades.Length; i++)
          {
              grades[i] = Convert.ToInt32(Console.ReadLine());
          }
          max = grades[0];
          min = grades[0];
          for (int i = 0; i < grades.Length; i++)
          {
              Console.Write(grades[i]+ "  ");
              Console.Write( "\n");
          }
            for (int i = 0; i < grades.Length; i++)
            {
                if (grades[i]>max)
                {
                    max = grades[i];
                }
          
              if (grades[i]<min)
              {
                  min = grades[i];
              }
          }
          Console.WriteLine($"Maximum element:  {max}");
          Console.WriteLine($"Minimum element:  {min}");
            
            /*End*/
            /*Sum of All Elements*/
            int zero = 0;
            for (int i = 0; i < grades.Length; i++)
            {
                zero += grades[i];
                
            }
            Console.Write($"Sum of ALl: {zero}\n");
            Console.Write($"Arithmetic mean: {zero/grades.Length}\n");
            
            /*End*/
            
            /*Odd Values*/
            for (int i = 0; i < grades.Length; i++)
            {
                int odd = grades[i];
                // int oddValue = i / 2;
                if (odd%2==0)
                {
                    continue;
                }
                Console.Write($"This is odd numbers of array:{odd}\n");
            
            }
            /*End*/
            /*Array Part Two , Task 2 , End*/
            /*Array Part Two , Task 3 , Start*/
           
            int[] arr = new int[] { 12, 2, 13, 0, 85 };  
            int length = arr.Length - 1;  
            string strReverse = null;  
            while (length >= 0)  
            {  
                strReverse = strReverse + arr[length];  
                length--;  
            }  
            Console.WriteLine();  
            Console.Write("Reverse Array is "+" "+strReverse );
            Console.WriteLine();
            /*Array Part Two , Task 3 , End*/

            /*Array Part Two , Task 4 , Start*/
            /*Enter N nigga*/
            int big = Convert.ToInt32(Console.ReadLine());
            int[]  bigArr = new int[big];
            Random randNum = new Random();
            for (int i = 0; i < bigArr.Length; i++)
            {
                bigArr[i] = randNum.Next(0,20);
                Console.Write(bigArr[i]);
                Console.Write(" ");
                
            }
            Console.WriteLine("\nEnter count and index values");
            int count = Convert.ToInt32(Console.ReadLine());
            int index = Convert.ToInt32(Console.ReadLine());

            int[] nigga= new int[count];
            Array.Copy(bigArr,index,nigga,0,count);
            
            if (nigga[count]>bigArr[big])
            {
                Console.WriteLine("Error");
            }  
            
           

            
            
           

            /*Array Part Two , Task 4 , End*/



        }
    }
}