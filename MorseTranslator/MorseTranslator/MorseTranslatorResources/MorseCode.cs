using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MorseTranslator.MorseTranslatorResources
{
    class MorseCodeTable
    {
        public Hashtable MorseCode = new Hashtable();

        public MorseCodeTable()
        {
            MorseCode.Add("A", "_.");
            MorseCode.Add("B", "_...");
            MorseCode.Add("C", "_._.");
            MorseCode.Add("D", "_..");
            MorseCode.Add("E", ".");
            MorseCode.Add("F", ".._.");
            MorseCode.Add("G", "__.");
            MorseCode.Add("H", "....");
            MorseCode.Add("I", "..");
            MorseCode.Add("J", ".___");
            MorseCode.Add("K", "_._");
            MorseCode.Add("L", "._..");
            MorseCode.Add("M", "__");
            MorseCode.Add("N", "_.");
            MorseCode.Add("O", "___");
            MorseCode.Add("P", ".__.");
            MorseCode.Add("Q", "__._");
            MorseCode.Add("R", "._.");
            MorseCode.Add("S", "...");
            MorseCode.Add("T", "_");
            MorseCode.Add("U", ".._");
            MorseCode.Add("V", "..._");
            MorseCode.Add("W", ".__");
            MorseCode.Add("X", "_.._");
            MorseCode.Add("Y", "_.__");
            MorseCode.Add("Z", "__..");

            MorseCode.Add("1", ".____");
            MorseCode.Add("2", "..___");
            MorseCode.Add("3", "...__");
            MorseCode.Add("4", "...._");
            MorseCode.Add("5", ".....");
            MorseCode.Add("6", "_....");
            MorseCode.Add("7", "__...");
            MorseCode.Add("8", "___..");
            MorseCode.Add("9", "____.");
            MorseCode.Add("0", "_____");

        }


    }
}
