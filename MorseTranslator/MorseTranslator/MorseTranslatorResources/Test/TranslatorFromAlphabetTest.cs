using MorseTranslator.MorseTranslatorResources.Translator;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MorseTranslator.MorseTranslatorResources.Test
{

    class TranslatorFromAlphabetTest
    {
        TranslatorFromAlphabet translator = new TranslatorFromAlphabet();

        [Test]
        public void CheckIfTextConsistOnlyLettersAndNumbersTest()
        {
            Assert.True(translator.CheckIfTextConsistOnlyLettersAndNumbers("AASDFGsdftgss 125568"));

            Assert.False(translator.CheckIfTextConsistOnlyLettersAndNumbers("AASDFGsdftgss$^^%&%^#$@  125568"));
        }

        [Test]
        public void TranslateTest()
        {
            Assert.AreEqual("_.\t_...\t_._.\t", translator.Translate("ABC"));
            
            Assert.AreEqual("_.\t._..\t_.\t__\t_.\t_._\t___\t_\t_.\t", translator.Translate("Ala Ma Kota"));

            Assert.AreEqual("_.\t._..\t_.\t__\t_.\t_._\t___\t_\t_.\t", translator.Translate("Ala Ma Kota"));

            Assert.AreEqual("ERROR: Text contains invalid characters", translator.Translate("!@$"));
        }

    }
}
