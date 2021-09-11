using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BezaoAtmMachine
{
    public static class AtmServices
    {
        private static decimal _vault = 50000;

        public static List<AtmUser> atmUsers = new();
        



        public static decimal CheckAccountBalance(int accountNumber)
        {
            var user = atmUsers.FirstOrDefault(user => user.AccountNumber == accountNumber);
            
            return user.Balance;

        }

        public static decimal Withdrawal( decimal amount, decimal balance)
        {
            
           // Startoptions:
           //decimal balance = user.Balance;
            Console.WriteLine(balance);
            

            if (amount % 500 == 0 && amount % 1000 == 0)
            {
                
                


                if (amount < balance)
                {
                    if ( _vault > amount)
                    {
                        _vault -= amount;
                        balance -= amount;
                        Console.WriteLine($"You have successfully withdraw {amount} and your new balance is {balance}");
                        
                    }
                    else
                    {
                        Console.WriteLine($" ATM does not have sufficient funds");
                    }

                    return balance;

                }
                else
                {
                    Console.WriteLine($" Insufficient funds");
                    return balance;
                   
                }
               // goto Startoptions;




            }
            //Console.WriteLine($"{balance} inn AAtm services");
            // return balance;

            else
            {
                Console.WriteLine("You can only withdraw in multiples of 500 and 1000");
                return balance;
            }
        }


    }
        
       
    

    
}
