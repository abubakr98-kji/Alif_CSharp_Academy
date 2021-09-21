using System;

namespace Class_Inheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            
            /*Class Transport*/
            Console.WriteLine("This is class Transport");
            Transport myTransport = new Transport();
            Console.WriteLine("Class Transport Brand");
            myTransport.brand = Console.ReadLine();
            Console.WriteLine("Class Transport Color");
            myTransport.color = Console.ReadLine();
            Console.WriteLine("Class Transport Price");
            myTransport.price = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Class Transport Production");
            myTransport.production = Console.ReadLine();
            myTransport.OutPut();
            /*#####################################*/
            
            
            /*Class Auto*/
            Console.WriteLine("This is Class Auto");
            Auto myAuto = new Auto();
            Console.WriteLine("Class Auto Brand");
            myAuto.brand = Console.ReadLine();
            Console.WriteLine("Class Auto Color");
            myAuto.color = Console.ReadLine();
            Console.WriteLine("Class Auto Price");
            myAuto.price = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Class Auto Production");
            myAuto.production = Console.ReadLine();
            myAuto.OutPut();
            /*##########################*/
            
            /*Class Airplane*/
            
            Console.WriteLine("This is Class Airplane");
            Airplane myAirplane = new Airplane();
            Console.WriteLine("Class Airplane Brand");
            myAirplane.brand = Console.ReadLine();
            Console.WriteLine("Class Airplane Color");
            myAirplane.color = Console.ReadLine();
            Console.WriteLine("Class Airplane Price");
            myAirplane.price = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Class Airplane Production");
            myAirplane.production = Console.ReadLine();
            myAirplane.OutPut();
            
            /*###########################*/

            /*Class Train*/
            
            Console.WriteLine("This is Class Airplane");
            Train myTrain = new Train();
            Console.WriteLine("Class Train Brand");
            myAirplane.brand = Console.ReadLine();
            Console.WriteLine("Class Train Color");
            myAirplane.color = Console.ReadLine();
            Console.WriteLine("Class Train Price");
            myAirplane.price = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Class Train Production");
            myAirplane.production = Console.ReadLine();
            myAirplane.OutPut();
            
            /*###########################*/
            
            /*Derived class LightAuto from Base class Auto*/

            LightAuto myLightAuto = new LightAuto();
            myLightAuto.AutoMotorType = Console.ReadLine();
            myLightAuto.brand = Console.ReadLine();
            myLightAuto.price = Convert.ToInt32(Console.ReadLine());
            myLightAuto.manufactureYear = Convert.ToInt32(Console.ReadLine()); 

            /*###########################*/

            
            /*Derived class CargoAuto from Base class Auto*/

            LightAuto myCargoAuto = new LightAuto();
            myLightAuto.AutoMotorType = Console.ReadLine();
            myLightAuto.brand = Console.ReadLine();
            myLightAuto.price = Convert.ToInt32(Console.ReadLine());
            myLightAuto.manufactureYear = Convert.ToInt32(Console.ReadLine()); 

            /*###########################*/
            
            /*Derived class CargoPlane from Base class Airplane*/

            Airplane myCargoPlane = new Airplane();
            myCargoPlane.brand = Console.ReadLine();
            myCargoPlane.price = Convert.ToInt32(Console.ReadLine());
            myCargoPlane.color = Console.ReadLine(); 

            /*###########################*/
            
            /*Derived class PassengerPlane from Base class Airplane*/

            Airplane myPassengerPlane = new Airplane();
            myPassengerPlane.brand = Console.ReadLine();
            myPassengerPlane.price = Convert.ToInt32(Console.ReadLine());
            myPassengerPlane.color = Console.ReadLine();

            /*###########################*/






        }
    }
}