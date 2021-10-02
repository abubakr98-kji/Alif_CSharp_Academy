using System;
using System.Data.SqlClient;
using System.Data.SqlTypes;
using System.Diagnostics;
using System.Linq;

namespace PartProject
{
    public class Registration
    {

        public Registration()
        {
        }


        public void UserRegistration(ref string connect)
        {
            Console.WriteLine("This registration is for peoples who want to take credits from Babuyin Bank.\nNow Registration will begin");
            
            /*User Login */
            Console.WriteLine("!!Warning:Your phone number will be you login.Please enter your phone numberLogin field can just have numbers.\nPlease enter your login here:");
        
            statement1:
            if (int.TryParse(Console.ReadLine(), out int num))
            {
                Console.WriteLine("Login is accepted");
            }
            else
            {
                Console.WriteLine("Wrong login syntax, number can not be more than 9 numbers!!");
                goto statement1;
            }
            
            /*Please enter your password*/
            Console.WriteLine("This is password field. Please enter you password. You can enter numbers,letters,symbols!!");
            string password = Console.ReadLine();
            
            /*Status entry field*/
            statusCheck:Console.WriteLine("In this field you need to choose your status it is possible to choose  two options 'admin' and 'user'");
            string status = Console.ReadLine();

            switch (status)
            {
                case "admin":
                    Console.WriteLine("You entered by admin status");
                    break;
                case "user":
                    Console.WriteLine("You entered by user status");
                    break;
                default:
                    Console.WriteLine("Status does not exist, please reenter again!!");
                    goto statusCheck; 
            }
            
            /*Here he/she enters Passport Data*/
            Console.WriteLine("Please enter your passport data");
            string passportData = Console.ReadLine();
            
            string conString = connect;//connection string
            string commandText = $"INSERT INTO UserRegistration (UserLogin, UserPassword, UserStatus, PassportData) VALUES('{num}','{password}','{status}','{passportData}')";
                
            using (SqlConnection connection = new SqlConnection(conString))
            {
                connection.Open();
                
                SqlCommand command = new SqlCommand(commandText,connection);
                int number = command.ExecuteNonQuery();
                Console.WriteLine($"Added one UserLogin: {number}");
            
            }
        }
        
        
        
        //Questionnaire
        public void Questionnaire(ref string connect)
        {
            
            // Gender
            Console.WriteLine("Please enter below your gender, you have two options 'male' and 'female'");
            genderCheck:string gender = Console.ReadLine();
            string genderMale = "male";
            string genderFemale = "female";
            int male = 1;
            int female = 2;
            int genderScore;
            
            switch (gender)
            {
                case "male":
                    genderFemale = null;
                    Console.WriteLine($"Your gender is: {genderMale} and your credit point is: {male}");
                    genderScore = male;
                    break;
                case "female":
                    genderMale = null;
                    Console.WriteLine($"Your gender is: {genderFemale} and your credit point is: {female}");
                    genderScore = female;
                    break;
                default:
                    Console.WriteLine("Dear customer gender you entered does not exist please enter one of those options шт text format 'male' or 'female' ");
                    goto genderCheck;
            }
            
            string conString = connect;
            string commandText = $"INSERT INTO Gender(Male, Female) VALUES('{genderMale}','{genderFemale}')";
            
            using (SqlConnection connection =new SqlConnection(conString))
            {
                connection.Open();
                SqlCommand command = new SqlCommand(commandText,connection);
                int number = command.ExecuteNonQuery();
                Console.WriteLine($"User{number} gender is {gender}. Your score is {genderScore}");
            }
            /*//////////////////////////////////////////////////////////////*/
            
            
            /*Family Status Questions*/
            
            Console.WriteLine("Please enter below your Family Status, you have four options please enter one of those in text format 'alone', 'haveFamily', 'divorced', 'widowWidower'");
            FamilyStatusCheck:string familyStatus = Console.ReadLine();
            
            //Variables to count credit
            int alone = 1;
            int haveFamily = 2;
            int divorced = 1;
            int widowWidower = 2;
            int zero = 0;
            
            int familyScore; 
            
            switch (familyStatus)
            {
                case "alone":
                    haveFamily = zero;
                    divorced = zero;
                    widowWidower = zero;
                    familyScore = genderScore;
                    Console.WriteLine($"You are {familyStatus} and your {gender} point adds extra {alone} point!Totally {familyScore}");
                    break;
                case "haveFamily":
                    alone = 0;
                    divorced = 0;
                    widowWidower = 0;
                    familyScore = genderScore;
                    Console.WriteLine($"You  {familyStatus} and your {gender} point adds extra {haveFamily} point!Totally {familyScore}");
                    break;
                case "divorced":
                    alone = 0;
                    haveFamily = 0;
                    widowWidower = 0;
                    familyScore = genderScore;
                    Console.WriteLine($"You are {familyStatus} and your {gender} point adds extra {divorced} point!Totally {familyScore}");
                    break;
                case "widowWidower":
                    alone = 0;
                    haveFamily = 0;
                    divorced = 0;
                    familyScore = genderScore;
                    Console.WriteLine($"You are {familyStatus} and your {gender} point adds extra {widowWidower} point!Totally {familyScore}");
                    break;
                default:
                    Console.WriteLine($"Dear Customer i told you we just have four options 'alone', 'haveFamily', 'divorced', 'widowWidower'");
                    goto FamilyStatusCheck;
            }
            
            string familyCommand = $"INSERT INTO FamilySituation(Unmarried, Married, Divorced, Widow_Widower) VALUES('{alone}','{haveFamily}','{divorced}','{widowWidower}')";
            
            using (SqlConnection connection = new SqlConnection(conString))
            {
                connection.Open();
                SqlCommand command = new SqlCommand(familyCommand, connection);
                int number = command.ExecuteNonQuery();
                Console.WriteLine($"This Customer {familyStatus} his/her score for this is {familyScore}!");
            
            }
            /*/////////////////////////////////////////////////////*/
            
            /*Age Status Questions*/
            
            ageCheck:Console.WriteLine("Please enter below your Age, you have four options '<25', '26-35', '36-62', '>63'. PLease don't enter symbols just numbers.");
            int customerAge = Convert.ToInt32(Console.ReadLine());
            
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
            /*//////////////////////////////////////////////////////*/
            
            // Nationality Status Starts here
            
            nationalityCheck:Console.WriteLine("Please enter below your Nationality, you have two options 'Tajikistan', and second is country where you are from. Please enter in text format!!");
            string customerNationality = Console.ReadLine();
            
            //Variables to count credit
            string tajikNation = "Tajikistan";
            string abroadCountry ;
            int tajik = 1;
            int abroad = 0;
            int nationalityScore = 0;
            
            switch (customerNationality)
            {
                case "Tajikistan":
                    nationalityScore = tajik;
                    abroadCountry = null;
                    Console.WriteLine($"Your nationality is {customerNationality}");
                    break;
                case "tajikistan":
                    nationalityScore = tajik;
                    nationalityScore = tajik;
                    abroadCountry = null;
                    Console.WriteLine($"Your nationality is {customerNationality}");
                    break;
                default:
                    nationalityScore = abroad;
                    tajikNation = null;
                    abroadCountry = customerNationality;
                    Console.WriteLine($"Dear Customer your Nationality is {customerNationality}");
                    break;
            }
            
            string nationalityCommand = $"INSERT INTO Nationality(Tajikistan, Other) VALUES('{tajikNation}', '{abroadCountry}')";

            using (SqlConnection connection = new SqlConnection(conString))
            {
                connection.Open();
                SqlCommand command = new SqlCommand(nationalityCommand, connection);
                int number = command.ExecuteNonQuery();
                Console.WriteLine($"Customer Nationality is added to DB: {number}. Customer Nationality is: {customerNationality} and his score is: {nationalityScore}");
            
            }
            /*/////////////////////////////////////////////////////////*/
            
            // Credit Period 
            
            creditPeriodCheck:Console.WriteLine("Please enter below Period of time you want to take for paying bills, you have two options '<12 ' months  and '>12' months\nPlease just enter numbers");
            int customerCreditPeriod = Convert.ToInt32(Console.ReadLine());
            // string text = Convert.ToString(customerCreditPeriod);

            int underTwelve = 1;
            int overTwelve = 1;
            int crediPeriodScore = 0;

                switch (customerCreditPeriod)
                {
                    case <12:
                        crediPeriodScore = underTwelve;
                        overTwelve = 0;
                        Console.WriteLine($"Your credit period is under 12 months");
                        break;
                    case >12:
                        crediPeriodScore = overTwelve;
                        underTwelve = 0;
                        Console.WriteLine($"Your credit period is over 12 months");
                        break;
                    default :
                        Console.WriteLine($"Dear Customer what you entered is not number please reenter!!!");
                        goto creditPeriodCheck;
                }

                string creditPeriodCommand = $"INSERT INTO CreditPeriod(OverTwelveMonth, UnderTwelveMonth) VALUES('{overTwelve}','{underTwelve}')";

            using (SqlConnection connection = new SqlConnection(conString))
            {
                connection.Open();
                SqlCommand command = new SqlCommand(creditPeriodCommand, connection);
                int number = command.ExecuteNonQuery();
                Console.WriteLine($"Your answer is added to DB:{number} Credit Period is {customerCreditPeriod} and you score for this is {crediPeriodScore}");

            }
            /*//////////////////////////////////////////////////////////////////*/
            
            /* Sum of Credit of Total Amount Starts here */
            
            // Object customer wants to buy price
            amountCheck:Console.WriteLine("Please enter below how much money does the thing you want to buy cost: ");
            int priceOfObject = Convert.ToInt32(Console.ReadLine());
            
            // Customers salary
            Console.WriteLine("Please enter below your salary per year");
            int customerSalary = Convert.ToInt32(Console.ReadLine());
            
            //credit calculation
            int calcAmount = (priceOfObject * 100) / customerSalary;
            
            //Variables to count credit
            int underEighty = 4;
            int eightyToOneFifty = 3;
            int oneFiftyToTwoFifty = 2;
            int overTwoFifty = 1;
            int amountScore = 0;
            
            switch (calcAmount)
            {
                case < 80:
                    amountScore = underEighty;
                    eightyToOneFifty = 0;
                    oneFiftyToTwoFifty = 0;
                    overTwoFifty = 0;
                    Console.WriteLine($"Your amount is  80%");
                    break;
                    case int c when ((c >= 80) || (c < 150)):
                        amountScore = eightyToOneFifty;
                        underEighty = 0;
                        oneFiftyToTwoFifty = 0;
                        overTwoFifty = 0;
                        Console.WriteLine($"Your amount is from 80-150% ");
                        break;
                    case int d when ((d>=150) || (d<250)):
                        amountScore = oneFiftyToTwoFifty;
                        underEighty = 0;
                        eightyToOneFifty = 0;
                        overTwoFifty = 0;
                        Console.WriteLine($"Your amount is from 150-250% ");
                        break;
                    case >250:
                        amountScore = overTwoFifty;
                        underEighty = 0;
                        eightyToOneFifty = 0;
                        oneFiftyToTwoFifty = 0;
                        Console.WriteLine($"Your amount is  250% and more ");
                        break;
                    default:
                        Console.WriteLine($"Something went wrong come again !!");
                        goto amountCheck;
            }

            string amountCommand = $"INSERT INTO AmountOfCreditOfTotalIncome(UnderEightyPercant,EightyToHundredFifty,HundredFiftyToTwoHundredFifty,OverHundredFifty) VALUES('{underEighty}','{eightyToOneFifty}','{oneFiftyToTwoFifty}','{overTwoFifty}')";
            using (SqlConnection connection = new SqlConnection(conString))
            {
                connection.Open();
                SqlCommand command = new SqlCommand(amountCommand, connection);
                int number = command.ExecuteNonQuery();
                Console.WriteLine($"Amount of Credit is added to DB: {number}.  Comparing to your income is percentage of credit is: {calcAmount}. Your score for this is: {amountScore} ");

            }
            /*////////////////////////////////////////////////////////*/
            
            // Credit History
            
            Console.WriteLine($"PLease enter how many credits have you taken and closed successfully, please enter number");
            creditHistoryCheck:int customerCreditHistory = Convert.ToInt32(Console.ReadLine());

            int overThreeCredits = 2;
            int oneToTwo = 1;
            int notTakenCredits = -1;
            int creditHistoryScore = 0;

            switch (customerCreditHistory)
            {
                case >=3:
                    creditHistoryScore = overThreeCredits;
                    oneToTwo = 0;
                    notTakenCredits = 0;
                    Console.WriteLine($"You have more than {customerCreditHistory} closed ");
                    break;
                case int f when ((f==1)||(f<=2))://here need to be OR ||
                    creditHistoryScore = oneToTwo;
                    overThreeCredits = 0;
                    notTakenCredits = 0;
                    Console.WriteLine($"Dear customer you have more than {customerCreditHistory} closed ");
                    break;
                case 0 :
                    creditHistoryScore = notTakenCredits;
                    overThreeCredits = 0;
                    overThreeCredits = 0;
                    Console.WriteLine($"Dear customer you have more than {customerCreditHistory} closed ");
                    break;
                case <0:
                    Console.WriteLine($"Dear Customer value you entered need to be 0 or more than 0. PLease reenter!!! ");
                    goto creditHistoryCheck;
            }

            string historyCommand = $"INSERT INTO CreditHistory(OverThreeClosedCredits,OneTwoClosedCredits,DontHaveCreditHistory) VALUES('{overThreeCredits}','{oneToTwo}','{notTakenCredits}') ";
            using (SqlConnection connection = new SqlConnection(conString))
            {
                connection.Open();
                SqlCommand command = new SqlCommand(historyCommand, connection);
                int number = command.ExecuteNonQuery();
                Console.WriteLine($"Your credit history is added to DB: {number}. Your score is: {creditHistoryScore}");
            }
            /*//////////////////////////////////////////////*/

            // Credit History Expire
            Console.WriteLine($"PLease enter how many credits have you expired , please enter number");
            expireHistoryCheck:int customerExpireCreditHistory = Convert.ToInt32(Console.ReadLine());

            int overSevenCredits = -3;
            int fiveToSeven = -2;
            int fourCredits = -1;
            int underThreeCredits = 0;
            int expireScore = 0;

            switch (customerExpireCreditHistory)
            {
                case >7:
                    expireScore = overSevenCredits;
                    fiveToSeven = 0;
                    fourCredits = 0;
                    underThreeCredits = 0;
                    Console.WriteLine($"You have expired {customerExpireCreditHistory} Credits :(((((");
                    break;
                case int g when ((g==5)&&(g<=7)):// need to past OR ||
                    expireScore = fiveToSeven;
                    overSevenCredits = 0;
                    fourCredits = 0;
                    underThreeCredits = 0;
                    Console.WriteLine($"You have expired {customerExpireCreditHistory} Credits :(((((");
                    break;
                case 4:
                    expireScore = fourCredits;
                    overSevenCredits = 0;
                    fiveToSeven = 0;
                    underThreeCredits = 0;
                    Console.WriteLine($"You have expired {customerExpireCreditHistory} Credits :(((((");
                    break;
                case <=3:
                    expireScore = underThreeCredits;
                    overSevenCredits = 0;
                    fiveToSeven = 0;
                    fourCredits = 0;
                    Console.WriteLine($"You have expired {customerExpireCreditHistory} Credits :(((((");
                    break;
            }

            string expireCommandText = $"INSERT INTO CreditExpireHistory(OverSevenTimes,FiveSevenTimes,FourTimes,UnderThreeTimes) VALUES('{overSevenCredits}','{fiveToSeven}','{fourCredits}','{underThreeCredits}')";

            using (SqlConnection connection = new SqlConnection(conString))
            {
                connection.Open();
                SqlCommand expireCommand = new SqlCommand(expireCommandText,connection);
                int number = expireCommand.ExecuteNonQuery();
                Console.WriteLine($"Credit expire history is added to DB: {number}. Your score is: {expireScore}");

            }
            /*/////////////////////////////////////////////////////*/


            // Goal of Credit
            Console.WriteLine($"PLease enter purpose of taking credit you have four options 'homeStuff','repair','telephone','other'.\nPlease enter one of those options in text format!!!");
            creditGoalCheck:string customerCreditPurpose = Console.ReadLine();

            int homeStuff = 2;
            int repair = 1;
            int telephone = 0;
            int other = -1;
            int purposeScore = 0;

            switch (customerCreditPurpose)
            {
                case "homeStuff":
                    purposeScore = homeStuff;
                    repair = 0;
                    telephone = 0;
                    other = 0;
                    Console.WriteLine($"Your credit purpose is: {customerCreditPurpose}");
                    break;
                case "repair":
                    purposeScore = repair;
                    homeStuff = 0;
                    telephone = 0;
                    other = 0;
                    Console.WriteLine($"Your credit purpose is: {customerCreditPurpose}");
                    break;
                case "telephone":
                    purposeScore = telephone;
                    homeStuff = 0;
                    repair = 0;
                    other = 0;
                    Console.WriteLine($"Your credit purpose is: {customerCreditPurpose}");
                    break;
                case "other":
                    purposeScore = other;
                    homeStuff = 0;
                    repair = 0;
                    telephone = 0;
                    Console.WriteLine($"Your credit purpose is: {customerCreditPurpose}");
                    break;
            }

            string purposeCommandText = $"INSERT INTO PurposeOfCredit(ConsumerElectronics,Repairs,Telephone,Other) VALUES('{homeStuff}','{repair}','{telephone}','{other}')";

            using (SqlConnection connection=new SqlConnection(conString))
            {
                connection.Open();
                SqlCommand command = new SqlCommand(purposeCommandText, connection);
                int number = command.ExecuteNonQuery();
                Console.WriteLine($"Purpose of credit is added to DB: {number}. Your score is: {purposeScore}");

            }
            /*////////////////////////////////////////////////*/
            
            // Result can we give Credit or NO ???
            
            Console.WriteLine($"Dear Customer we have sum all scores according to your Questionnier answers to reveal can we give you credit or no. If your score is equal to 11 or less Sorry we can not give credit. If your score is greater than 11 Congratulations. ");
            int sumScore = ((genderScore + familyScore)+(ageScore+nationalityScore))+((amountScore+creditHistoryScore)+(expireScore+purposeScore)+crediPeriodScore);
            
            Console.WriteLine($"Dear Customer your total score is: {sumScore}");
            
            // Every month customer payment
            int everyMonthCredit = priceOfObject / customerCreditPeriod;

            switch (sumScore)
            {
                case >11: 
                    Console.WriteLine($"Congratulations your credit is approved. If you want to know you extinction schedule please enter 1 , if no please enter 0 .");
                    int scheduleCommand = Convert.ToInt32(Console.ReadLine());
                    switch (scheduleCommand)
                    {
                        case 1:
                            for (int i = 1; i < 12; i++)
                            {
                                Console.WriteLine($"Month {i} you need to pay: {everyMonthCredit}");
                            }
                            break;
                        case 0:
                            Console.WriteLine($"How you wish). But if you you want to know it later please come to room B212, our friendly specialists will provide you with any information you want.");
                            break;
                    }
                    break;
                case <=11:
                    Console.WriteLine($"Sorry dear customer your score is {sumScore}. Unfortunately we can not give you credit. But you can try later.)) ");
                    break;
                
            }
            
            /*/////////////////////////////////////////////////////*/

        }
    }

    
}