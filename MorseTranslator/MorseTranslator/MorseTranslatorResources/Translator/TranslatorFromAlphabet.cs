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
            return null;
        }

        public Boolean IsTextProperToTranslate(string text)
        {
            return false;
        }

        private string FormatText(string text)
        {
            return text.Trim().ToUpper();
        }

        private void CheckIfTextConsistOnlyLettersAndNumbers(string text)
        {
            text = FormatText(text);

            foreach(char letter in text)
            {
                if (!CheckIfCharIsLetterOrDigit(letter))
                {

                }
            }

        }

        private Boolean CheckIfCharIsLetterOrDigit(char chr)
        {
            return Char.IsLetterOrDigit(chr);
        }

    }
}
