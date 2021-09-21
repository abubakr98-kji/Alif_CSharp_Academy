using System;
// using static OOP.Rectangle;


namespace OOP
{
    
    class Program
    {
       
        
        static void Main(string[] args)
        {
        double check = Convert.ToDouble(Console.ReadLine());
        double check2 = Convert.ToDouble(Console.ReadLine());
        
        Rectangle myObj = new Rectangle(check,check2);
          
            
            
            Console.WriteLine(myObj.AreaCalculator());
            Console.WriteLine(myObj.PerimeterCalculator());
        }
    
 
    }
}