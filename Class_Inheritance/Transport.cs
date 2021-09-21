using System;

namespace Class_Inheritance
{
    public class Transport
    {
        public string brand { get; set; }
        public string color { get; set; }
        public int price { get; set; }
        public string production { get; set; }
        
        public Transport()
        {
            Console.WriteLine(brand);
        }

        public virtual void OutPut()
        {
            // Console.WriteLine(brand);
            // Console.WriteLine(color);
            // Console.WriteLine(price);
            // Console.WriteLine(production);
        }

    }
    
    /*Derived Class Auto from Based Class Transport*/
    public class Auto:Transport
    {
        public string AutoMotorType;
        public int howManyWeels;
        public int manufactureYear;
        
        public Auto()
        {
            // Console.WriteLine(AutoColor);
            
        }
        public override void OutPut()
        {
            Console.WriteLine(brand);
            Console.WriteLine(color);
            Console.WriteLine(price);
            Console.WriteLine(production);   
        }

    }
    /**/
    
    /*Derived class from Transport*/
    public class Airplane:Transport
    {
        
        public Airplane()
        {
        }

        public override void OutPut()
        {
            Console.WriteLine(brand);
            Console.WriteLine(color);
            Console.WriteLine(price);
            Console.WriteLine(production);   
        }
        
    }
    /*#########################*/
    
    /*Derived class from Transport*/
    public class Train:Transport
    {
        public Train()
        {
            
        }

        public override void OutPut()
        {
            Console.WriteLine(brand);
            Console.WriteLine(color);
            Console.WriteLine(price);
            Console.WriteLine(production);   
        }

    }
    /*#########################*/
    
    /*Auto Inheritance*/
    public class LightAuto:Auto
    {
        public LightAuto()
        {
        }

        
        public override void OutPut()
        {
            Console.WriteLine(AutoMotorType);
            Console.WriteLine(brand);
            Console.WriteLine(price);
            Console.WriteLine(manufactureYear);   
        }

    }
    /*#########################*/
    
    /*Auto Inheritance*/
    public class CargoCar:Auto
    {
        public CargoCar()
        {
        }

        public override void OutPut()
        {
            Console.WriteLine(AutoMotorType);
            Console.WriteLine(brand);
            Console.WriteLine(price);
            Console.WriteLine(manufactureYear); 
        }


    }
    /*#########################*/
    
    /*Airplane Inheritance*/

    public class CargoAirPlane: Airplane
    {
        public CargoAirPlane()
        {
        }
        public override void OutPut()
        {
            Console.WriteLine(brand);
            Console.WriteLine(color);
            Console.WriteLine(price);
            Console.WriteLine(production);   
        }
    }
    
    /*#########################*/
    
    /*Airplane Inheritance*/
    public class PassengerPlane: Airplane
    {
        public PassengerPlane()
        {
        }

        public override void OutPut()
        {
            Console.WriteLine(brand);
            Console.WriteLine(color);
            Console.WriteLine(price);
            Console.WriteLine(production);   
        }
    }
    /*#########################*/


}