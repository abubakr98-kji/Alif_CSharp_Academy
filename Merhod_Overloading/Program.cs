using System;


namespace Merhod_Overloading
{
    class Program
    {


        static void Main(string[] args)
        {
            /* POP Method */
            string[] myArray = new[] {"salom", "nihao", "salut", "hola", "privet"};
            
            ArrayHelper ownArr = new ArrayHelper();
            ownArr.Pop(ref myArray, 4);
            Console.WriteLine();
            /* POP Method */
            
            /* PUSH Method */
            
            int[] text = new[] {25,62,4,5,8,7};
            int add = 46;
            ArrayHelper stringArr = new ArrayHelper();
            stringArr.Push(ref text, ref add);
            Console.WriteLine();

            /* PUSH Method */
            
            /* Shift Method */

            decimal[] shift = new[] { 1m,2m,85m,65m,3m };
            ArrayHelper decShift = new ArrayHelper();
            decShift.Shift(ref shift);
            Console.WriteLine();
    
            /* Shift Method */
            
            /* UnShift Method */

            float[] unShift = new[] { 5f, 56f, 8f,9f,76f,21f };
            float newnum = 46f;
            ArrayHelper floatShift = new ArrayHelper();
            floatShift.UnShift(ref unShift,ref newnum);
            Console.WriteLine();


            /* UnShift Method */

        }
    }
}
