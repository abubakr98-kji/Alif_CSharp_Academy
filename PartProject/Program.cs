using System;
using System.Data.SqlClient;

namespace PartProject
{
    class Program
    {
        
        
        
        static void Main(string[] args)
        {
            
            string connection = @"Data Source=ABUBAKRNAZIRMAD;Initial Catalog=PaymentInstalments;Integrated Security=True";
            
            Registration newUser = new Registration();
            newUser.UserRegistration(ref connection);
            
            newUser.Questionnaire(ref connection);


        }
    }
}