using System;
using System.Data.SqlClient;

namespace PartProject
{
    class Program
    {
        
        
        
        static void Main(string[] args)
        {
            
            string connection = @"Data Source=ABUBAKRNAZIRMAD;Initial Catalog=PaymentInstalments;Integrated Security=True";

            // int login = Convert.ToInt32(Console.ReadLine());//login
            // string userPassword = Console.ReadLine();// here he/she enters password data
            // string userStatus = Console.ReadLine();// userStatus he/she can choose admin or simple user
            // string passportData = Console.ReadLine();// here he/she enters passport data
            
            
            Registration newUser = new Registration();
            // newUser.UserRegistration(ref connection);
            // newUser.Login = login;
            // newUser.Status = userStatus;
            // newUser.Passport = passportData;
            // newUser.UserRegistration(ref connection);
            newUser.Questionnaire(ref connection);

            // Questionnaire userQuestionnaire = new Questionnaire();
            // userQuestionnaire.Gender(ref connection);



        }
    }
}