using System;

namespace Merhod_Overloading
{
    public class ArrayHelper
    {
        
        public  void Pop(ref string[] array, int index )
        {
            string [] newArray = new String[array.Length - 1];
            for (int i = 0; i < index; i++)  
            {
                newArray[i] = array[i];
            }
           
            foreach (var VARIABLE in newArray)
            {
                Console.WriteLine(VARIABLE);
            }
        }
        
        /*Push Method*/
        public void Push(ref int[] take, ref int index)
        {
            int[] newText = new int[take.Length + 1];
            newText[6] = index;
            for (int i = 0; i < take.Length; i++)
            {
                newText[i] = take[i];
            }
        
            foreach (var VAR in newText)
            {
                Console.WriteLine(VAR);
            }
            
        }
        
        /*Method Shift*/
        public  void Shift(ref decimal[] please)
        {
            decimal[] newShift = new decimal[please.Length];
        
            for (int i = 0; i < please.Length; i++)
            {
               
                if (please[0]>i)
                {
                    continue;
                    Console.WriteLine("less");
                }
        
                newShift[i] = please[i];
                Console.WriteLine(newShift[i]);
            }
        }
        /*Method Shift*/
        
        /*Method UnShift*/
        
        public void UnShift(ref float[] accept, ref float index)
        {
            
            float[] newBody = new float[accept.Length+1];
            newBody[6] = index;
            float six = newBody[6];
            
            for (int i = 0; i < accept.Length; i++)
            {
               
                newBody[i] = accept[i];
            }
            float zer = newBody[0];
            if (newBody[0]>=0 )
            {
                newBody[0] = six;
                newBody[6] = zer;
            }
                
            foreach (var element in newBody)
            {
                Console.WriteLine(element);
            }

        }
        
        
        /*Method UnShift*/
        
        
        
        
    }
}