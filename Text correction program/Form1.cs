using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Text_correction_program
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public void mainButton_Click(object sender, EventArgs e)
        {
            string line = mainTextBox.Text;
            mainTextBox.Text = Correction(mainTextBox.Text);
        }

        public string Correction(string str)
        {
            string[] upperWordArray = { "Пожалуйста", "Наверное", "К счастью"};
            string[] lowerWordArray = { "пожалуйста", "наверное", "к счастью"};

            string VocabularyCorrector(string[] vocabularyArray, string line, bool trueIfUpperReg)
            {
                if (trueIfUpperReg)
                {
                    foreach (string word in vocabularyArray)
                    {
                        if (line.Contains(word))
                        {
                            line = line.Replace(word, word + ",");
                        }
                    }
                }
                else
                {
                    foreach (string word in vocabularyArray)
                    {
                        if (line.Contains(word))
                        {
                            line = line.Replace(word, ", " + word + ",");
                        }
                    }
                }
                
                return line;
            }


            str = str.Replace("Еще", "Ещё").Replace("еще", "ещё").Replace("Вобщем", "В общем").Replace("вобщем", "в общем");

            str = VocabularyCorrector(upperWordArray, str, true);
            str = VocabularyCorrector(lowerWordArray, str, false);

            return str;
        }

    }
}
