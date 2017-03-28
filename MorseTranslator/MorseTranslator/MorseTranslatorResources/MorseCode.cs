using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MorseTranslator.MorseTranslatorResources
{
    class MorseCodeAlphabet
    {
        public Hashtable Code = new Hashtable();

        public MorseCodeAlphabet()
        {
            Code.Add("A", "_.");
            Code.Add("B", "_...");
            Code.Add("C", "_._.");
            Code.Add("D", "_..");
            Code.Add("E", ".");
            Code.Add("F", ".._.");
            Code.Add("G", "__.");
            Code.Add("H", "....");
            Code.Add("I", "..");
            Code.Add("J", ".___");
            Code.Add("K", "_._");
            Code.Add("L", "._..");
            Code.Add("M", "__");
            Code.Add("N", "_.");
            Code.Add("O", "___");
            Code.Add("P", ".__.");
            Code.Add("Q", "__._");
            Code.Add("R", "._.");
            Code.Add("S", "...");
            Code.Add("T", "_");
            Code.Add("U", ".._");
            Code.Add("V", "..._");
            Code.Add("W", ".__");
            Code.Add("X", "_.._");
            Code.Add("Y", "_.__");
            Code.Add("Z", "__..");

            Code.Add("1", ".____");
            Code.Add("2", "..___");
            Code.Add("3", "...__");
            Code.Add("4", "...._");
            Code.Add("5", ".....");
            Code.Add("6", "_....");
            Code.Add("7", "__...");
            Code.Add("8", "___..");
            Code.Add("9", "____.");
            Code.Add("0", "_____");

        }

        public string GetMorseCodeOfLetter(string letter)
        {
            return Code[letter].ToString();          
        }

        public string GetLetterOfMorseCode(string code)
        {
            //TODO
            return null;
        }



    }
}
