using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MorseTranslator.MorseTranslatorResources.Translator
{
    class TranslatorFromAlphabet
    {
        MorseCodeAlphabet MorseAlphabet = new MorseCodeAlphabet();

        public string Translate(string textToTranslate)
        {
            string translatedText ="";

            textToTranslate = FormatText(textToTranslate);

            if (CheckIfTextConsistOnlyLettersAndNumbers(textToTranslate))
            {
                foreach (char letter in textToTranslate)
                {
                    translatedText += TranslateChar(letter)+ "\t";
                }
               
            }
            else
            {
                return "ERROR: Text contains invalid characters";
            }

            return translatedText;
        }

        private string TranslateChar(char chr)
        {
            return MorseAlphabet.GetMorseCodeOfLetter(chr.ToString());
        }

        private string FormatText(string text)
        {
            return text.ToUpper().Replace(" ","");
        }

        public bool CheckIfTextConsistOnlyLettersAndNumbers(string text)
        {
            bool status = true;

            text = FormatText(text);

            foreach(char letter in text)
            {
                if (!CheckIfCharIsLetterOrDigit(letter))
                {
                    status = false;
                    break;
                }
            }
            return status;
        }

        private bool CheckIfCharIsLetterOrDigit(char chr)
        {
            return Char.IsLetterOrDigit(chr);
        }

    }
}
