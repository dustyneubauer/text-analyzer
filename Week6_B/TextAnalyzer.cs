using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Week6_B
{
    public partial class TextAnalyzer : Form
    {

        //the count instances method counts the number of times the user inputted phrase appears in the 
        //text and displays the result in a label

        private void CountInstances()
        {
            string text = enterTextTextBox.Text;
            string phrase = wordPhraseTextBox.Text;
            int count = 0; //holds the count for the number of times the phrase is found

            int position = text.IndexOf(phrase);

            while (position < text.Length)
            {
                if (position >= -1)
                {
                    indexListBox.Items.Add(position);
                    count++;
                }
                else
                {
                    MessageBox.Show("phrase not found");
                }
            }

            phraseLabel.Text = count.ToString();
        }

        private string GetPassword()
        {
            string password; //holds the user entered password

            password = passwordTextBox.ToString();

            return password;
        }

        //the number uppercase reads the number of uppercase characters in the password 
        private int NumUpperCase()
        {
            int upperCase = 0; //holds the number of uppercase characters
            string password;  //holds the password

            password = GetPassword();

            //count the uppercase characters in password
            foreach (char ch in password)
            {
                if (char.IsUpper(ch))
                {
                    upperCase++;
                }
            }

            return upperCase;
        }

        //the number lowercase reads the number of lowercase characters in the password 
        private int NumLowerCase()
        {
            int lowerCase = 0; //holds the number of uppercase characters
            string password;  //holds the password

            password = GetPassword();

            //count the uppercase characters in password
            foreach (char ch in password)
            {
                if (char.IsLower(ch))
                {
                    lowerCase++;
                }
            }

            return lowerCase;
        }

        //the number numdigits reads the number of digits in the password 
        private int NumDigits()
        {
            int digits = 0; //holds the number of uppercase characters
            string password;  //holds the password

            password = GetPassword();

            //count the uppercase characters in password
            foreach (char ch in password)
            {
                if (char.IsDigit(ch))
                {
                    digits++;
                }
            }

            return digits;
        }

        //the number special characters reads the number of special characters in the password 
        private int NumSpecialCharacter()
        {
            int special = 0; //holds the number of special characters
            string password;  //holds the password

            password = GetPassword();

            //count the special characters in password
            foreach (char ch in password)
            {
                if (char.IsPunctuation(ch))
                {
                    special++;
                }
            }

            return special;
        }
        private void analyzeButton_Click(object sender, EventArgs e)
        {
            CountInstances();
        }

        private void passwordTextBox_TextChanged(object sender, EventArgs e)
        {
            //validate the password
            if (NumLowerCase() >= 1 &&
                NumUpperCase() >= 1 &&
                NumDigits() >= 1 &&
                NumSpecialCharacter() >= 1)
            {
                passwordTextBox.BackColor = Color.Green;
            }
            else
            {
                passwordTextBox.BackColor = Color.Red;
            }

            //checks the uppercase checkbox
            if (NumUpperCase() >= 1)
            {
                upperCaseCheckBox.Checked = true;
            }
            else
            {
                lowerCaseCheckBox.Checked = false;
            }

            //checks the lowercase checkbox
            if (NumLowerCase() >= 1)
            {
                lowerCaseCheckBox.Checked = true;
            }
            else
            {
                lowerCaseCheckBox.Checked = false;
            }

            //Checks the digits checkbox
            if (NumDigits() >= 1)
            {
                numberCheckBox.Checked = true;
            }
            else
            {
                numberCheckBox.Checked = false;
            }

            //checks the special characters check box
            if (NumSpecialCharacter() >= 1)
            {
                specialCharacterCheckBox.Checked = true;
            }
            else
            {
                specialCharacterCheckBox.Checked = false;
            }
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            enterTextTextBox.Text = "";
            wordPhraseTextBox.Text = "";
            phraseLabel.Text = "";
            indexListBox.Items.Clear();
        }
    }



}
