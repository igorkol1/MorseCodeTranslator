using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MorseTranslator.MorseTranslatorResources.Translator
{
    class TranslatorFromMorseCode
    {
        public string  Translate(string morseCodeMessage)
        {
            
        }

        public bool CheckIfIsMorseCode(string textToCheck)
        {
            bool status = true;

            foreach(char chr in textToCheck)
            {
                if (!CheckIfCharIsElementOfMorseCode(chr))
                {
                    status = false;
                    break;
                }
            }
            return status;
        }

        private bool CheckIfCharIsSpace(char chr)
        {
            return chr == ' ';
                
        }

        private int GetIndexOfSpace(string text)
        {
            int index = -1;
            for(int i = 0; i <= text.Length; i++)
            {

            }
            return index
        }

        private bool CheckIfCharIsElementOfMorseCode(char chr)
        {
            bool status = true;

            char[] morseCodeElements = { ' ', '.', '_' };

            if (!morseCodeElements.Contains(chr))
            {
                status = false;
            }

            return status;
        }

    }
}
