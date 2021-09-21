using System;

namespace Polymorphism
{
    class Program
    {
        static void Main(string[] args)
        {
            DocumentWorker myWorker = new DocumentWorker();

           /*Pro Worker*/
            ProDocumentWorker myPro = new ProDocumentWorker();
            Console.WriteLine("PLease enter key for Pro Version");
            myPro.key = Convert.ToInt32(Console.ReadLine());
           
            /*Expert Worker*/
            ExpertDocumentWorker myExpert = new ExpertDocumentWorker();
            Console.WriteLine("PLease enter key for Expert Version");
            myExpert.key = Convert.ToInt32(Console.ReadLine());

            /*Checking Key*/
            if (!(myPro.key==123)&& !(myExpert.key==000))
            {
                Console.WriteLine("Sorry but you can use only free version");
            }else if (myPro.key==123)
            {
                Console.WriteLine("You can use Pro Version");
            }else if (myExpert.key==000)
            {
                Console.WriteLine("You can use Expert Version");
            }










        }
    }
}