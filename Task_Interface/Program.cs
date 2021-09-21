using System;

namespace Task_Interface
{
    class Program
    {
        static void Main(string[] args)
        {
            InterfaceMethods myPLayer = new InterfaceMethods();
            
            myPLayer.Play();
            myPLayer.Pause();
            myPLayer.Stop();
            myPLayer.Record();
            
            





        }
    }
}