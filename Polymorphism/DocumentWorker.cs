using System;

namespace Polymorphism
{
    public class DocumentWorker
    {
        public int key { get; set; }

        public DocumentWorker()
        {
        }
        
        public virtual void OpenDocument()
        {
            Console.WriteLine("Document is open");
            
        }
        public virtual void EditDocument()
        {
            Console.WriteLine("Document editing is available in Pro Version");
            
        }
        public virtual void SaveDocument()
        {
            Console.WriteLine("Document saving is avzaailable in Pro Version");
            
        }

    }
    /*Class ProDocumentWorker is derived from Base Class DocumentWorker*/

    public class ProDocumentWorker :DocumentWorker  {

        public ProDocumentWorker()
        {
        }


        public override void EditDocument()
        {
            Console.WriteLine("Document is edited");
        }
        
        public override void SaveDocument()
        {
            Console.WriteLine("Document is saved in old format , saving in new format is available in version Expert");
            
        }

    }
    /*####################################################################*/
    
    /*Class ExpertDocumentWorker is derived from base Class ProDocumentWorker*/
    public class ExpertDocumentWorker:ProDocumentWorker
    {
        public ExpertDocumentWorker()
        {
        }


        public override void SaveDocument()
        {
            Console.WriteLine("Document is saved in new Format");
        }




    }





    /*####################################################################*/
    
    
    
    
    
    
    
    
    
    
    
    
    
    
    

}