using System;

namespace Task_Interface
{
    /*Interface IPlayable*/
    public interface IPlayable
    {
        void Play();

         void Pause();

         void Stop();

    }
    
    /*Interface IRecordable*/
    public interface IRecordable:IPlayable
    {
        void Record();
        
    }
    
    public class InterfaceMethods:IRecordable
    {
        
            public void Play()
            {
                Console.WriteLine("Play it Bro!");
            }
    
            public void Pause()
            {
                Console.WriteLine("Pause it Bro!");
            }
    
    
            public  void Stop()
            {
                Console.WriteLine("Stop it Bro!");
            }
            
            /*Override Method*/
            
            public void Record()
            {
                Console.WriteLine("Record it Bro!");
            }
            
        }
        
        
}