using NUnit.Framework;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MorseTranslator.MorseTranslatorResources.Test
{
     public class MorseCodeTableTest
    {
        MorseCodeTable MorseAlphabet = new MorseCodeTable();

        [Test]
        public void IsTableContainsAllChars()
        {
            Assert.AreEqual(36, MorseAlphabet.MorseCode.Count, "MorseCodeTable not contain all characters");
        }

        [Test]
        public void IsAllPositionsAreFilled()
        {
            foreach(DictionaryEntry element in MorseAlphabet.MorseCode)
            {
                Assert.Greater(element.Key.ToString().Length, 0);
                Assert.Greater(element.Value.ToString().Length, 0);
            }
        }

    }
}
