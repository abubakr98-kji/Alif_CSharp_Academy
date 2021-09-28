using System;
using System.Data;
using System.Data.SqlClient;
using System.Data.SqlTypes;



using System;
using System.Collections.Generic;
using Microsoft.VisualBasic;

namespace First_Connection_DB
{
    public class Person
    {

        public Person()
        {
        }

        /*Method Insert by User*/
        public void InsertToTable(ref string connect)
        {
            
            string conString=connect ;// connection string
            Console.WriteLine("Add LAsName by your own");
            string LastName = Console.ReadLine();
            
            /*FIrst Name*/
            Console.WriteLine("Add FirstName by your own");
            string FirstName = Console.ReadLine();
            
            /*Middle Name*/
            Console.WriteLine("Add MiddleName by your own");
            string MiddleName = Console.ReadLine();
            
            /*Command Text*/
            /*one way to add data to Data Base*/
            string commandText =$"INSERT INTO Person (LastName,FirstName,MiddleName) VALUES('LastName', 'FirstName',  'MiddleName')" ;
            
            /*second way to add data to Data Base, i just cooment it , dont want ot losse it:)*/
            // string commandText =String.Format("INSERT INTO Person (LastName,FirstName,MiddleName) VALUES('{0}','{1}','{2}')", LastName, FirstName,  MiddleName);

            
            using (SqlConnection connection = new SqlConnection(conString))
            {
                connection.Open();
            
                SqlCommand command = new SqlCommand(commandText,connection);
            
                var number = command.ExecuteNonQuery();
                
                Console.WriteLine($"Added those{number}");
            
            }
            
        }
        /*##########################################################*/
        
        /*Method Select All by User*/
        public void SelectAll(ref string connect)
        {
            string conString = connect;

            string commandText = $"SELECT * FROM Person";

            using (SqlConnection connection = new SqlConnection(conString)) 
            {
                connection.Open();
                SqlCommand newCommand = new SqlCommand(commandText, connection);
                
                Console.WriteLine("Please chosee which table you want ot Select. Please press 1 to choose table Person.");

                int enterNum = Convert.ToInt32(Console.ReadLine());

                if (enterNum==1)
                {
                    var number = newCommand.ExecuteReader();
                    while (number.Read())
                    {
                        Console.WriteLine($"Selected all from table Person: {number[2]}");       
                    }
                    
                }

            }
        }
        /*##############################################################*/

        /*Method Delete by User*/

        public void UserDeleteBySelf(ref string connect)
        {
            string conString = connect;
           
        
            try
            {
                /*SQL Command first to let user see column FirstName and choose Person he/she wants to delete*/
                /*##########################################*/
                string selectFirstName = $"SELECT * FROM Person";
                
                SqlConnection connection = new SqlConnection(conString);
                connection.Open();
        
                SqlCommand selectCommand = new SqlCommand(selectFirstName,connection);
                var select = selectCommand.ExecuteReader();
                List<string>array = new List<string>();
                while (select.Read())
                {
                    Console.WriteLine($"Selected FirstName column: {select[2]}");    
                    array.Add(select[2].ToString());
                }
                select.Close();
                 /*##############################################*/
                
                //Enter table you want ot delete
                Console.WriteLine("PLease write table you want to delete from, but actually we have just one table named Person");
                string tableToDelete = Console.ReadLine();
                //Enter FirstName of Person you want to delete
                Console.WriteLine("PLease name of person you want to delete");
                string FirstNameToDelete = Console.ReadLine();
                //
                string commandText = $"DELETE FROM {tableToDelete} WHERE FirstName='{FirstNameToDelete}'";
                
                
                SqlCommand command = new SqlCommand(commandText,connection);
                
                
                if ((tableToDelete!="Person") && !array.Contains(FirstNameToDelete))
                {
                    throw new Exception("This Person does not exist in this column");
                }
                else
                {
                    var number = command.ExecuteNonQuery();
                    Console.WriteLine($"You have deleted {number} from table {tableToDelete} column FirstName = {FirstNameToDelete}");
                }
        
            }
            catch (Exception e)
            {
                Console.WriteLine($"Error :{e.Message}");
            }
        
        }
        /*######################################################################*/
        
        /*Method Choose one by ID by User*/
        public void SelectById(ref string connect)
        {
            string conString = connect;
            int userEnterId = Convert.ToInt32(Console.ReadLine());
            var commandText = $"SELECT * FROM Person WHERE ID='{userEnterId}'";
            using (SqlConnection connection = new SqlConnection(conString))
            {
                connection.Open();
                SqlCommand command = new SqlCommand(commandText,connection);
                var number = command.ExecuteReader();
                while (number.Read())
                {
                    Console.WriteLine($"Selected by Id: {number[userEnterId]}");

                }
            }
        }
        /*#################################################################*/

        /*Method Update by User*/
        public void UpdateUser(ref string connect)
        {
            string conString = connect;
            string addFirstName = Console.ReadLine();
            string addLastName = Console.ReadLine();
            int addID = Convert.ToInt32(Console.ReadLine());

            var commandText = $"UPDATE Person SET LastName='{addLastName}', FirstName='{addFirstName}' WHERE ID ='{addID}'" ;
            using (SqlConnection connection = new SqlConnection(conString))
            {
                connection.Open();
                SqlCommand command = new SqlCommand(commandText, connection);
                int number = command.ExecuteNonQuery();
                Console.WriteLine($"Updated table Person with: {number}");

            }

        }

    }
    
}