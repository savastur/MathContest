/*
 * [x] Make the name, grade, and age textbox appear yellow
 * [x] Limit grade 1-4 appear yellow when out of range
 * [x] Limit age 7-11 appear yellow when out of range
 * [x] Lock Submit button until all fields are filled ( grade, name, and age)
 * [] Lock the Summary button until the submit button has been clicked once
 * [] Allow selection of add, divde, multiply, and subtract operations
 * [x] set up message box for submit button
 * [] set up message box for summary
 * [] verify the student answer when the they press the submit button
 * [] Creat a tally of how many the student got correct
*/
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Security;
using System.Security;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MathContest
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            Defults();
        }
        /// Sets the defults of the program
        void Defults()
        {
            addButton.Checked = true;
            submitButton.Enabled = false;
            summeryButton.Enabled = false;
        }
        private int FirstNumber()
        {
            Random randomNumber = new Random();
            int randomValue = randomNumber.Next(1, 11);
            firstNumbertext.Text = randomValue.ToString();
            return randomValue;
        }
        private int SecondNumber()
        {
            Random randomNumber = new Random();
            int randomValue = randomNumber.Next(1, 11); 
            secondNumbertext.Text = randomValue.ToString();
            return randomValue;
        }
        void Verify()
        {
            string verifyName = nameBox.Text;
            string verifyAge = ageBox.Text;
            string verifyGrade = gradeBox.Text;
           ///Let's the user know when the name box is improperly filled 
            if(verifyName == "")
            {
                nameBox.BackColor = Color.LightYellow;
            }
            else
            {
                nameBox.BackColor= Color.White;
            }
            if(verifyName == "")
            {
                ageBox.BackColor = Color.LightYellow;
            }
            /// Lets the user know when the age box is imporperly filled 
            try
            {
                int ageNumber = Convert.ToInt16(verifyAge);
                if(ageNumber < 7 ||  ageNumber > 11)
                {
                    ageBox.BackColor = Color.LightYellow;
                    ageBox.SelectedIndex = 0;
                }
                if (ageNumber >= 7 || ageNumber <= 11)
                {
                    ageBox.BackColor = Color.White;
                }
            }
            catch
            {
                ageBox.BackColor = Color.LightYellow;
                ageBox.Text = "";
            }
            if(verifyGrade == "")
            {
                gradeBox.BackColor = Color.LightYellow;
            }
            /// Let's the user know when grade box is imporperly filled 
            try
            {
                int gradeNumber = Convert.ToInt16(verifyGrade);
                if (gradeNumber < 1 || gradeNumber > 4)
                {
                    gradeBox.BackColor = Color.LightYellow;
                    gradeBox.Text = "";
                }
                gradeBox.BackColor= Color.White;
            }
            catch
            {
                gradeBox.BackColor = Color.LightYellow;
                gradeBox.Text = "";
            }
            /// Verification to enbale teh submit button
            if(verifyAge != "" && verifyGrade != "")
            {
                int ageNumber = Convert.ToInt16(verifyAge);
                int gradeNumber = Convert.ToInt16(verifyGrade);
                int grade = gradeNumber;
                int age = ageNumber;
                bool gradeConfirmed = grade <= 4 && grade >= 1;
                bool ageConfirmed = age >= 7 && age <= 11;
                bool nameConfirmed = ConfirmName();
                if (nameConfirmed && gradeConfirmed && ageConfirmed == true)
                {
                    submitButton.Enabled = true;
                }
            }
        }
        ///Only Enterd when name is changed 
        ///Will disable if value changes
        private void nameBox_TextChanged(object sender, EventArgs e)
        {
            Defults();
            NameTracker();
            Verify();
        }
        /// Only enterd when grade box is changed
        /// Will disable if value changes
        private void gradeBox_TextChanged(object sender, EventArgs e)
        {
            Defults();
            Verify();
        }
        /// Only entered when age box is changed
        /// Will disable if value changes
        private void ageBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            Defults();
            Verify();
        }
        /// Confirm name creates a bool for the verficaton process only for the name.
        private bool ConfirmName()
        {
            string name = nameBox.Text;
            return NameTracker() == name;
        }
        /// Name tracker creates a memory of the name that's wich can be called uppon when needed.
        private string NameTracker()
        {
            string[] name = new string[1];
            name[0] = nameBox.Text;
            return name[0];
        }

        private void submitButton_Click(object sender, EventArgs e)
        {
            int answer = Operations(out answer);
            string contestentAnswer = studentAnswer.Text;
            string answercComparison = answer.ToString();
            if (answercComparison == contestentAnswer)
            {
                MessageBox.Show("That is the correct answer");
            }
            if (answercComparison != contestentAnswer)
            {
                MessageBox.Show($"That is not the correct answer, the answer is {answer}.");
            }
        }
        private int Operations(out int answer)
        {
           if (addButton.Checked  == true)
           {
                answer = FirstNumber() + SecondNumber();
                return  answer;
           }
           if (subtractButton.Checked == true)
           {
               answer = FirstNumber() - SecondNumber();
               return answer;
           }
           if (divideButton.Checked == true)
           {
                answer = FirstNumber() / SecondNumber();
                return answer;
           }
           if (multiplyButton.Checked == true)
           {
                answer = FirstNumber() * SecondNumber();
                return answer;
           }
           return answer = 0;
        }
    }
}
