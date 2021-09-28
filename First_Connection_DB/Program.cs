using System;
using System.Data;
using System.Data.SqlClient;
using System.Data.SqlTypes;

namespace First_Connection_DB
{
    class Program
    {
        static void Main(string[] args)
        {
           
            Person myPerson = new Person();
            string connect = @"Data Source=ABUBAKRNAZIRMAD;Initial Catalog=MSSql;Integrated Security=True";
            // User chooses command he/she wants to apply
            Console.WriteLine("Please enter SQL Command you want to apply:\n Insert Commad = 1\n Select All Commadn= 2\n Delete = 3\n Choose one of by ID= 4\n Update = 5");
            int enterMethod = Convert.ToInt32(Console.ReadLine());
            switch (enterMethod)
            {
                case 1:
                    myPerson.InsertToTable(ref connect);
                    break;
                case 2:
                    myPerson.SelectAll(ref connect);
                    break;
                case 3:
                    myPerson.UserDeleteBySelf(ref connect);
                    break;
                case 4:
                    myPerson.SelectById(ref connect);
                    break;
                case 5:
                    myPerson.UpdateUser(ref connect);
                    break;
            }
        }
    }
}