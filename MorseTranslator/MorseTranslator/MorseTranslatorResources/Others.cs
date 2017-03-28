using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MorseTranslator.MorseTranslatorResources
{
    public static class Others
    {
        public static string GetRandomLetter()
        {
            Random rdn = new Random();

            char[] letters = { 'A', 'B', 'C', 'D', 'E', 'F', 'G', 'H', 'I', 'J', 'K', 'L', 'M', 'N', 'O', 'P', 'Q', 'R', 'S', 'T', 'W', 'V', 'Y', 'Z' };

            return letters[rdn.Next(0, letters.Count())].ToString();
        }


    }
}
