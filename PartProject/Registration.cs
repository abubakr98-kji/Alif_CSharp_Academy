using System;
using System.Data.SqlClient;
using System.Data.SqlTypes;
using System.Linq;

namespace PartProject
{
    public class Registration
    {
        // public int Login { get; set; }
        // public string Password { get; set; }
        // public string Status { get; set; }
        // public string Passport { get; set; }



        public Registration()
        {
        }


        // public void UserRegistration(ref string connect)
        // {
        //     Console.WriteLine("This registration is for peoples who want to take credits from Babuyin Bank.\nNow Registration will begin");
        //     
        //     /*User Login */
        //     Console.WriteLine("!!Warning:Your phone number will be you login.Please enter your phone numberLogin field can just have numbers.\nPlease enter your login here:");
        //
        //     statement1:
        //     if (int.TryParse(Console.ReadLine(), out int num))
        //     {
        //         Console.WriteLine("Login is accepted");
        //     }
        //     else
        //     {
        //         Console.WriteLine("Wrong login syntax");
        //         goto statement1;
        //     }
        //     
        //     /*Please enter your password*/
        //     Console.WriteLine("This is password field. Please enter you password. You can enter numbers,letters,symbols!!");
        //     string password = Console.ReadLine();
        //     
        //     /*Status entry field*/
        //     Console.WriteLine("In this field you need to choose your status it is possible to choose  two options 'admin' and 'user'");
        //     string status = Console.ReadLine();
        //     
        //     
        //     /*Here he/she enters Passport Data*/
        //     Console.WriteLine("Please enter your passport data");
        //     string passportData = Console.ReadLine();
        //     
        //     
        //
        //     string conString = connect;//connection string
        //     string commandText = $"INSERT INTO UserRegistration (UserLogin, UserPassword, UserStatus, PassportData) VALUES('{num}','{password}','{status}','{passportData}')";
        //         
        //     using (SqlConnection connection = new SqlConnection(conString))
        //     {
        //         connection.Open();
        //         
        //         SqlCommand command = new SqlCommand(commandText,connection);
        //         int number = command.ExecuteNonQuery();
        //         Console.WriteLine($"Added one UserLogin: {number}");
        //     
        //     }
        // }
        
        
        
        //Questionnaire
        public void Questionnaire(ref string connect)
        {
            
            // //Gender
            // Console.WriteLine("Please enter below your gender, you have two options 'male' and 'female'");
            // genderCheck:string gender = Console.ReadLine();
            // string genderMale = "male";
            // string genderFemale = "female";
            // int male = 1;
            // int female = 2;
            // int genderScore;
            //
            //
            //
            // switch (gender)
            // {
            //     case "male":
            //         genderFemale = null;
            //         Console.WriteLine($"Your gender is: {genderMale} and your credit point is: {male}");
            //         genderScore = male;
            //         break;
            //     case "female":
            //         genderMale = null;
            //         Console.WriteLine($"Your gender is: {genderFemale} and your credit point is: {female}");
            //         genderScore = female;
            //         break;
            //     default:
            //         Console.WriteLine("Dear customer gender you entered does not exist please enter one of those options 'male' or 'female' ");
            //         goto genderCheck;
            // }
            //
            string conString = connect;
            // string commandText = $"INSERT INTO Gender(Male, Female) VALUES('{genderMale}','{genderFemale}')";
            //
            // using (SqlConnection connection =new SqlConnection(conString))
            // {
            //     connection.Open();
            //     SqlCommand command = new SqlCommand(commandText,connection);
            //     int number = command.ExecuteNonQuery();
            //     Console.WriteLine($"User{number} gender is {gender} and his credit is {genderScore}");
            // }
            // //Gender Questions End
            //
            //
            // /*Family Status Questions*/
            //
            // Console.WriteLine("Please enter below your Family Status, you have four options 'alone', 'haveFamily', 'divorced', 'widowWidower'");
            // FamilyStatusCheck:string familyStatus = Console.ReadLine();
            //
            // //Variables to count credit
            // int alone = 1;
            // int haveFamily = 2;
            // int divorced = 1;
            // int widowWidower = 2;
            // int zero = 0;
            //
            // int familyScore; 
            //
            // switch (familyStatus)
            // {
            //     case "alone":
            //         haveFamily = zero;
            //         divorced = zero;
            //         widowWidower = zero;
            //         familyScore = genderScore;
            //         Console.WriteLine($"You are {familyStatus} and your {gender} point adds extra {alone} point!Totally {familyScore}");
            //         break;
            //     case "haveFamily":
            //         alone = 0;
            //         divorced = 0;
            //         widowWidower = 0;
            //         familyScore = genderScore;
            //         Console.WriteLine($"You  {familyStatus} and your {gender} point adds extra {haveFamily} point!Totally {familyScore}");
            //         break;
            //     case "divorced":
            //         alone = 0;
            //         haveFamily = 0;
            //         widowWidower = 0;
            //         familyScore = genderScore;
            //         Console.WriteLine($"You are {familyStatus} and your {gender} point adds extra {divorced} point!Totally {familyScore}");
            //         break;
            //     case "widowWidower":
            //         alone = 0;
            //         haveFamily = 0;
            //         divorced = 0;
            //         familyScore = genderScore;
            //         Console.WriteLine($"You are {familyStatus} and your {gender} point adds extra {widowWidower} point!Totally {familyScore}");
            //         break;
            //     default:
            //         Console.WriteLine($"Dear Customer i told you we just have four options 'alone', 'haveFamily', 'divorced', 'widowWidower'");
            //         goto FamilyStatusCheck;
            // }
            //
            // string familyCommand = $"INSERT INTO FamilySituation(Unmarried, Married, Divorced, Widow_Widower) VALUES('{alone}','{haveFamily}','{divorced}','{widowWidower}')";
            //
            // using (SqlConnection connection = new SqlConnection(conString))
            // {
            //     connection.Open();
            //     SqlCommand command = new SqlCommand(familyCommand, connection);
            //     int number = command.ExecuteNonQuery();
            //     Console.WriteLine($"This Customer {familyStatus} his/her score for now is {familyScore}");
            //
            // }
            //Family Status  Questions End
            
            /*Age Status Questions*/
            
            Console.WriteLine("Please enter below your Age, you have four options '<25', '26-35', '36-62', '>63'");
            ageCheck:int customerAge = Convert.ToInt32(Console.ReadLine());
            
            //Variables to count credit
            int underTF = 0;
            int tFiveToThirtyThree = 1;
            int tSixSixtyTwo = 2;
            int overSixtyThree = 1;
            int zeroAge = 0;
            int ageScore = 0;

            switch (customerAge)
            {
                case <=25:
                    ageScore = underTF;
                    tFiveToThirtyThree = zeroAge;
                    tSixSixtyTwo = zeroAge;
                    overSixtyThree = zeroAge;
                    Console.WriteLine($"Your Age is under <25: {ageScore}");
                    break;
                case int a when((a>=26) && (a<=35)):
                    ageScore = tFiveToThirtyThree;
                    underTF = zeroAge;
                    tSixSixtyTwo = zeroAge;
                    overSixtyThree = zeroAge;
                    Console.WriteLine($"Customer age is 26-35: {ageScore}");
                    break;
                case int b when ((b>=36)&&(b<=62)):
                    ageScore = tSixSixtyTwo;
                    underTF = zeroAge;
                    tFiveToThirtyThree = zeroAge;
                    overSixtyThree = zeroAge;
                    Console.WriteLine($"Customer age is 36-62: {ageScore}");
                    break;
                case >63:
                    ageScore = overSixtyThree;
                    underTF = 0;
                    tFiveToThirtyThree = zeroAge;
                    tSixSixtyTwo = zeroAge;
                    Console.WriteLine($"Customer age is >62: {ageScore}");
                    break;
                default:
                    Console.WriteLine($"Dear Customer thing that you entered is not what we ask for please reenter!!!!");
                    goto ageCheck;
            }
            string ageCommand = $"INSERT INTO Age(Under_TwentyFive, TwentyFiveTo_ThirtyFive, ThirtySixTo_SixtyTwo, OverSixtyThree) VALUES('{underTF}','{tFiveToThirtyThree}','{tSixSixtyTwo}','{overSixtyThree}')";
            
            
            using (SqlConnection connection = new SqlConnection(conString))
            {
                connection.Open();
                SqlCommand command = new SqlCommand(ageCommand, connection);
                int number = command.ExecuteNonQuery();
                Console.WriteLine($"Customer age is added to DB{number}.\nThis is Customer's {customerAge} his/her score for this is {ageScore}");
            
            }









        }
    }

    
}