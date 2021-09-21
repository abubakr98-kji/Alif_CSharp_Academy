using System;

namespace Converter
{
    public class Money
    {

        public double usd;
        public double eur;
        public double rub;
        
        
        public Money(double ausd, double aeur, double nrub)
        {
            // double enterNum = Convert.ToInt32(Console.ReadLine());
            // double entercurrency = Convert.ToInt32(Console.ReadLine());
            usd = ausd;
            eur = aeur;
            rub = nrub;
            Console.WriteLine("You want to convert somoni to any Currency? Please enter 1");
            Console.WriteLine("You want to convert usd, euro , rubl to Somoni? Please enter 2");
            double enter = Convert.ToInt32(Console.ReadLine());

            /*Converter from somoni to any currency*/
            if (enter==1)
            {
                Console.WriteLine("You choose first operation");
                Console.WriteLine("PLease enter amount of somoni you want to convert:");
                double enterSomoni = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Please enter the currency you want to convert to somoni using number of currency which is written in scope usd(40) / eur(41) / rub(42) ");
                double convToCurrency = Convert.ToInt32(Console.ReadLine());
                if (convToCurrency==40)
                {
                    double toDollar =  enterSomoni / usd;
                    Console.WriteLine($"The amount of{enterSomoni} somoni converted to  dollar: {toDollar}");
                }else if (convToCurrency==41)
                {
                    double toEuro =  enterSomoni / eur;
                    Console.WriteLine($"The amount of {enterSomoni} somoni converted to euro:{toEuro}");
                }else if (convToCurrency == 42)
                {
                    double toRubl =  enterSomoni / rub;
                    Console.WriteLine($"The amount of {enterSomoni} somoni converted to  rubl: {toRubl}");
                }else if (!(convToCurrency== 40) && !(convToCurrency==41) && !(convToCurrency==42))
                {
                    Console.WriteLine("Number of currency you entered is wrong. PLease enter one of those please just enter the number is scope usd(40) / eur(41) / rub(42).");
                }
                
                
                /*Converter from any currency to somoni*/    
            }else if (enter==2)
            {
                Console.WriteLine("You choose second operation");
                /**/
                Console.WriteLine("Please enter amount of Dollar");
                double enterUsd = Convert.ToInt32(Console.ReadLine());
                /**/
                Console.WriteLine("Please enter amount of Euro");
                double enterEuro = Convert.ToInt32(Console.ReadLine());
                /**/
                Console.WriteLine("Please enter amount of Rubl");
                double enterRubli = Convert.ToInt32(Console.ReadLine());

                double resultUsd = enterUsd * usd;
                double resultEuro = enterEuro * eur;
                double resultRubli = enterRubli * rub;
                
                Console.WriteLine($" Dollar to Somoni: {resultUsd}\nEuro to Somoni: {resultEuro}\nRubl to Somoni: {resultRubli}");
                
            }
            
        }
        // public class ConvertIt
        // {
        //     private double convToCurrency = Convert.ToInt32(Console.ReadLine());
        //     
        // }
            
       

        


    }
}
