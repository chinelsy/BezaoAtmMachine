using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BezaoAtmMachine
{
    static class ChooseALang
    {
        
        public static string ChooseLanguage()
        {
            Startoptions:
            Console.WriteLine("Please choose your prefered Language options: \n Press 1. English \n 2. Pidgin \n 3. Igbo \n 0. End");
            var LangOption = Console.ReadLine();
            if (LangOption == "1")
            {
                Console.WriteLine("You have selected English Language as your best option");
                return "English";
            }
            else if (LangOption == "2")
            {
                Console.WriteLine("You have selected Pidgin English as your best option");
                return "Pidgin";
            }
            else if (LangOption == "3")
            {
                Console.WriteLine("You have selectedIgbo Language as your best option");
                return "Igbo";
            }
            else if (LangOption.ToLower() == "0")
            {
                Console.WriteLine("End the transaction");
                return LangOption;
            }
            else
            {
                Console.WriteLine("You have made a wrong choice");
                Console.WriteLine("\n\n\n Please choose a correct option");
                Console.ReadLine();
                goto Startoptions;
                
            }
               
        }
    }
}
