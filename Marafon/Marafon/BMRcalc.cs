using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Marafon
{
    public partial class BMRcalc : Form
    {
        bool maleFemale = true;

        public BMRcalc()
        {
            InitializeComponent();
        }

        private void back_btn_Click(object sender, EventArgs e)
        {
            BMRcalc.ActiveForm.Hide();
            Form1 form = new Form1();
            form.Show();
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            BMRcalc.ActiveForm.Hide();
            Form1 form = new Form1();
            form.Show();
        }

        private void malePanel_Paint(object sender, PaintEventArgs e)
        {
            //malePanel.BorderStyle = BorderStyle.FixedSingle;
            //femalePanel.BorderStyle = BorderStyle.None;
            //maleFemale = true;
        }

        private void femalePanel_Paint(object sender, PaintEventArgs e)
        {
            //femalePanel.BorderStyle = BorderStyle.FixedSingle;
            //malePanel.BorderStyle = BorderStyle.None;
            //maleFemale = true;
        }

        private void countButton_Click(object sender, EventArgs e)
        {
            try
            {
                double fat, result, age, height;

                height = Convert.ToInt32(heightTextBox.Text);
                fat = Convert.ToInt32(fatTextBox.Text);
                age = Convert.ToInt32(ageTextBox.Text);
                if (maleFemale)
                {
                    result = 66.0 + (13.7 * height) + (5.0 * fat) + (6.8 * age);
                }
                else
                {
                    result = 655 + (9.6 * height) + (1.8 * fat) + (4.7 * age);
                }

                bmrNumberLabel.Text = result.ToString();
                sitNumberLabel.Text = (result * 1.2).ToString();
                lowNumberLabel.Text = (result * 1.375).ToString();
                normalNumberLabel.Text = (result * 1.55).ToString();
                bigNumberLabel.Text = (result * 1.725).ToString();
                maxNumberLabel.Text = (result * 1.9).ToString();
            }
            catch
            {
                MessageBox.Show("Ошибка в вводе");
            }
        }
        private void infoPictureBox_Click_1(object sender, EventArgs e)
        {
            activityLevel form = new activityLevel();
            form.ShowDialog();
        }

        private void malePictureBox_Click(object sender, EventArgs e)
        {

        }

        private void heightLabel_Click(object sender, EventArgs e)
        {

        }
    }
}
  