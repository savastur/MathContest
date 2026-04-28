/*
 * [x] Make the name, grade, and age textbox appear yellow
 * [x] Limit grade 1-4 appear yellow when out of range
 * [x] Limit age 7-11 appear yellow when out of range
 * [x] Lock Submit button until all fields are filled ( grade, name, and age)
 * [] Lock the Summary button until the submit button has been clicked once
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
        void Defults()
        {
            addButton.Enabled = true;
            submitButton.Enabled = false;
            summeryButton.Enabled = false;
        }
        private int Numbers()
        {
            Random randomNumber = new Random();
            int randomValue = randomNumber.Next(1, 7);
            int[] numberIndex = new int[10];
            numberIndex[0] = 1;
            numberIndex[1] = 2;
            numberIndex[2] = 3;
            numberIndex[3] = 4;
            numberIndex[4] = 5;
            numberIndex[5] = 6;
            numberIndex[6] = 7;
            numberIndex[7] = 8;
            numberIndex[8] = 9;
            numberIndex[9] = 10;
            return numberIndex[randomValue];
        }
        void Verify()
        {
            string verifyName = nameBox.Text;
            string verifyAge = ageBox.Text;
            string verifyGrade = gradeBox.Text;
           
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

        private void nameBox_TextChanged(object sender, EventArgs e)
        {
            NameTracker();
            Verify();
        }
        private void gradeBox_TextChanged(object sender, EventArgs e)
        {
            Verify();
        }
        private void ageBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            Verify();
        }
        private bool ConfirmName()
        {
            string name = nameBox.Text;
            return NameTracker() == name;
        }
        private string NameTracker()
        {
            string[] name = new string[1];
            name[0] = nameBox.Text;
            return name[0];
        }
    }
}
