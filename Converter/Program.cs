using System;

namespace Converter
{
    class Program
    {
        static void Main(string[] args)
        {
            double america = 11.33;
            double europe = 13.41;
            double russia = 0.16;
            
            
            Money dollar = new Money( america, europe, russia);



        }
    }
}