using MorseTranslator.MorseTranslatorResources.Translator;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MorseTranslator
{
    public partial class Form1 : Form
    {
        string textToTranslate, translatedText;

        public Form1()
        {
            InitializeComponent();
        }

        private void TranslateButton_Click(object sender, EventArgs e)
        {
            TranslatorFromAlphabet translator = new TranslatorFromAlphabet();
            textToTranslate = inputText.Text;
            translatedText = translator.Translate(textToTranslate);
            outputText.Text = translatedText;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void ClearButton_Click(object sender, EventArgs e)
        {
            this.inputText.Clear();
            this.outputText.Clear();
        }
    }
}
