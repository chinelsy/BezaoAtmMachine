using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BezaoAtmMachine
{

    public class Register
    {
        static List<AtmUser> atmUsers = new();

        public static void RegisterUser(AtmUser atmUser)
        {
            atmUsers.Add(atmUser);
            Console.WriteLine($"You have successfully registered {atmUser.FullName}, Your account number is {atmUser.AccountNumber}");
        }
    }
}
