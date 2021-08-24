using System;

namespace Classes_Part_Two
{
    class Program
    {
        static void Main(string[] args)
        {
            Pilav myPilav = new Pilav();
            myPilav.meat = "Beef";
            myPilav.rice = "long Pakistani";
            myPilav.salat = "Alading";
            myPilav.size = 1*1 ;
            myPilav.price = 20;
            
            Console.WriteLine($"My Pilav consist of:\nMeat:{myPilav.meat}\nRice:{myPilav.rice}\nSalat:{myPilav.salat}\nSize:{myPilav.size}\nPrice:{myPilav.price}");
        }
    }
}