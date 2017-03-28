using NUnit.Framework;
using System.Collections;

namespace MorseTranslator.MorseTranslatorResources.Test
{
    public class MorseCodeTableTest
    {
        MorseCodeAlphabet MorseAlphabet = new MorseCodeAlphabet();

        [Test]
        public void IsTableContainsAllChars()
        {
            Assert.AreEqual(36, MorseAlphabet.Code.Count, "MorseCodeAlphabet not contain all characters");
        }

        [Test]
        public void IsAllPositionsAreFilled()
        {
            foreach(DictionaryEntry element in MorseAlphabet.Code)
            {
                Assert.Greater(element.Key.ToString().Length, 0);
                Assert.Greater(element.Value.ToString().Length, 0);
            }
        }

        [Test]
        public void GetMorseCodeofLetterInputRandomLetter()
        {
            Assert.IsNotEmpty(MorseAlphabet.GetMorseCodeOfLetter(Others.GetRandomLetter()));
        }



    }
}
