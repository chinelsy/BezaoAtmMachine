
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BezaoAtmMachine
{ 
    public class AtmUser
    {
        
        private static decimal _balance = 1000;
       
        private static int _accountNumber = 0123456789;
        public int AccountNumber { get; set; }
        public string FullName { get; set; }
        public int Pin{ get;} = 2334;
        public decimal Balance { get => _balance; set => _balance = value; }  

        public AtmUser(string fullName)
        {
            FullName = fullName;
            AccountNumber = _accountNumber;
            _accountNumber++;

        }
   
        public bool AccountValidation(int pin, int accountNum)
        {
            if(pin == Pin && accountNum == AccountNumber)
            {
                Console.ForegroundColor = ConsoleColor.DarkGreen;
                Console.WriteLine("You are successfully Logged-in");
                Console.ResetColor();
                return true;
            }
            else
            {
                return false; 
            }
          
        }

        
        public static string RequestPIN()
        {
            StringBuilder sb = new StringBuilder();
            ConsoleKeyInfo keyInfo;
            do
            {
                keyInfo = Console.ReadKey(true);
                if (sb.Length <= 3) 
                { 
                    if (char.IsDigit(keyInfo.KeyChar))
                    {
                        sb.Append(keyInfo.KeyChar);
                        Console.Write("*");

                    }
                }
              
            } while (keyInfo.Key != ConsoleKey.Enter);
            {
                Console.WriteLine();
                return sb.ToString();
            }
            
        }



    }
}
