using MorseTranslator.MorseTranslatorResources.Translator;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MorseTranslator.MorseTranslatorResources.Test
{
    class TranslatorFromMorseCodeTest
    {
        TranslatorFromMorseCode translator = new TranslatorFromMorseCode();

        [Test]
        public void CheckIfIsMorseCodeTest()
        {
            Assert.True(translator.CheckIfIsMorseCode("..__ ..  __.____"));

            Assert.False(translator.CheckIfIsMorseCode(".AbC!@#%^----___..___ _  &%$12456"));
            
        }

        [Test]
        public void TranslateTest()
        {

        }
    }
}
