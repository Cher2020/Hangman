using System;
using System.Drawing;
using System.Windows.Forms;
using System.IO;
using System.Drawing.Text;
using System.Linq;
using System.CodeDom.Compiler;
using Microsoft.EntityFrameworkCore.Metadata.Internal;

namespace Hangman
{


    public partial class FrmHangman : Form
    {

        private readonly Bitmap[] hangImages = { Hangman.Properties.Resources.Hang1, Hangman.Properties.Resources.Hang2, Hangman.Properties.Resources.Hang3, Hangman.Properties.Resources.Hang4, Hangman.Properties.Resources.Hang5, Hangman.Properties.Resources.Hang6, Hangman.Properties.Resources.Hang7, Properties.Resources.Hang8 };
        private int wrongGuesses = 0;
        private string current = "";
        private string copyCurrent = "";
        private string[] words;
        private readonly object find;
        private object temp;

        public FrmHangman()
        {
            InitializeComponent();
        }
        private void Loadwords()
        {
            char[] delimiterChars = { ',' };
            string[] readText = File.ReadAllLines("wordlist_hangman.csv");
            words = new string[readText.Length];
            int index = 0;
            foreach (string s in readText)

            {
                string[] line = string.s.Split(delimiterChars);
                words[index++] = line[1];
            }
        }
        private void GuessClick(object sender, EventArgs e)
        {
            Button choice = sender as Button;
            choice.Enabled = false;
            if (current.Contains(choice.Text))
            {
                char[] temp = copyCurrent.ToCharArray();
                char[] find = current.ToCharArray();
                char guessChar = choice.Text.ElementAt(0);
                for (int index = 0; index < find.Length; index++) ;
            }
            {
                if find[Index] == guessChar)
                {
                }
                else
                {
                    temp[Index] = guessChar;
                }
            }
            copyCurrent = new string(temp);
            displayCopy();



            else
            {
                wrongGuesses++;
            }
            if (wrongGuesses < 8)
            {
                hangImage.Image = hangImages[wrongGuesses];
            }
         
            object Private = null;
#pragma warning disable CS8321 // Local function is declared but never used
            Private }

        private static void updateCopy(char guess, object Private)
#pragma warning restore CS8321 // Local function is declared but never used
        {
            if (Private is null)
            {
                throw new ArgumentNullException(nameof(Private));
            }

            {


            else

                {
                    lblResult.Text = "You Crashed and Lost!!";
                    {
                        if copyCurrent.Equals(current))
                        {                                {}
                            else
                            {
                            }
                        }
                    }
                    {
                        lblResult.Text = "You Win!!";
                    }
                }
                private void frmHangman_Load(object sender, EventArgs e)
                {
                    Loadwords();
                    setupWordChoice();

                    Private void button23_Click(object sender, EventArgs e)
                    {
                        setupWordChoice();
                        lblResult.Text = "";

                    }

                    private void lblShowWord(object sender, EventArgs e)
                    {

                    }

                    {

                    }
                    private void button13_Click(object sender, EventArgs e)
                    {

                    }
                    private void label1_Click(object sender, EventArgs e)
                    {

                    }
                    private void Restart_Click(object sender, EventArgs e)
                    {

                    }
                    private void lblShowWord_Click(object sender, EventArgs e)
                    {

                    }
                    private void displayCopy()
                    {
                        throw new NotImplementedException();
                    }
                }

            }

            private void setupWordChoice()
            {
                wrongGuesses = 0;
                hangImage.Image = hangImages[wrongGuesses];
                int guessIndex = (new Random()).Next(words.Length);
                current = words[guessIndex];
                copyCurrent = "";
                for (int index = 0; index < current.Length; index++)
                {
                    copyCurrent += "_";
                }
                Private void displayCopy()
                {
                    for (int index = 0; index < copyCurrent.Length; index++)
                    {
                        lblShowWord.Text += copyCurrent.Substring(index, 1);
                        lblShowWord.Text += " ";
                    }
                }
            }
            private void updateCopy(char v1, object guess, object v2, object @private)
            {
                throw new NotImplementedException();
            }
        }
    }












