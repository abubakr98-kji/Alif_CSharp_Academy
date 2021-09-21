using System;

namespace OOP
{
    public class Rectangle
    {
        public double side1 { get; set; }
        public double side2 { get; set; }

        public double Area { get; }
        public double Perimeter { get; }

        public Rectangle(double _side1,double _side2)
        {
            side1 = _side1;
            side2 = _side2;

        }

        public double AreaCalculator()
        {
            double calcArea = (side1* side2);
            return calcArea;
        }
        
        public double  PerimeterCalculator()
        {
             double calcPerimeter = 2 * (side1 + side2);
             return calcPerimeter;
        }
        
        
      
   
       

       

    }
}