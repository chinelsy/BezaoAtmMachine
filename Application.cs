

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace BezaoAtmMachine
{
    static class Application
    {
        public static decimal amountDeposited = 0;
        
        public static void Run()
        {

            //tmUser atmUser = new AtmUser();
           
            Console.Title = "BEZAO ATM MACHINE";
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("Hellow Awesome person \n");
            Console.WriteLine("Dear customer please choose your language");

           var language = ChooseALang.ChooseLanguage();
           

            if (language == Languages.English.ToString())
            {
                Console.WriteLine("Please enter your 4 digit pin: ");
                int Pin = Convert.ToInt32(AtmUser.RequestPIN());

                Console.WriteLine("please enter your 10 digit Account Number: ");
                int accountNumber = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("what is your name");
                var name = Console.ReadLine();
                 
                var user = new AtmUser(name);
                 
                AtmServices.atmUsers.Add(user);


                while (!user.AccountValidation(Pin, accountNumber)) {

                    Console.WriteLine("INVALID USER");
                    Console.WriteLine("Enter your Pin");
                    Pin = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Enter Account Number");
                    accountNumber = Convert.ToInt32(Console.ReadLine());
                    user.AccountValidation(Pin, accountNumber);
                }

                 user.Balance = AtmServices.CheckAccountBalance(accountNumber);

                Console.ForegroundColor = ConsoleColor.DarkGreen;
                Console.WriteLine($"YOUR TOTAL BALANCE IS {user.Balance}");
                Console.WriteLine("\n ENTER THE DEPOSIT AMOUNT");
                amountDeposited = decimal.Parse(Console.ReadLine());
                user.Balance += amountDeposited;
                Console.WriteLine("YOUR AMOUNT HAS BEEN DEPOSITED SUCCESSFULLY");
                Console.WriteLine($"You balance is now N{user.Balance:n}");
                Console.ResetColor();

                Console.WriteLine("ENTER THE AMOUNT TO WITHDRAW: ");
                decimal amount = Convert.ToDecimal(Console.ReadLine());
               user.Balance = AtmServices.Withdrawal(amount, user.Balance);
                Console.WriteLine(user.Balance);

            }
            






            // Speaking another Language
            else if (language == Languages.Pidgin.ToString())
            {
                Console.WriteLine("Speaking Pidgin");
            }


        }




        //Console.WriteLine("please enter your name: ");
        //string fullName = Console.ReadLine();



    }
}
