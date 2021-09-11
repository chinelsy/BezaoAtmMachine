using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BezaoAtmMachine
{
    public static class LanguageRunner
    {
        static readonly List<string> EnglishInstructions = new()
        {
            "Withdraw Money"
        };
        static readonly List<string> PidginInstructions = new()
        {
            "Comot Money"
        };
        static readonly List<string> IgboInstructions = new()
        {
            "Weree Ego"
        };

        public static void ChooseLanguage(Languages language)
        {
            if(language == Languages.English)
            {
                RunWithChoosenLanguage(EnglishInstructions);
                Console.WriteLine("you have choosen English as your language of choice");
            }
            else if (language == Languages.Pidgin)
            {
                RunWithChoosenLanguage(PidginInstructions);
                Console.WriteLine("you have choosen Pidgin as your language of choice");
            }
            else if (language == Languages.Igbo)
            {
                RunWithChoosenLanguage(IgboInstructions);
                Console.WriteLine("you have choosen Igbo as your language of choice");
            }
        }
        public static void RunWithChoosenLanguage(List<string> instructions)
        {
            Console.WriteLine(instructions[0]);
            
        }
    }
}
