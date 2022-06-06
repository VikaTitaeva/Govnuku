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
    public partial class BMIcalc : Form
    {
        public BMIcalc()
        {
            InitializeComponent();
        }

        private void back_btn_Click(object sender, EventArgs e)
        {
            BMIcalc.ActiveForm.Hide();
            Form1 form = new Form1();
            form.Show();
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            BMIcalc.ActiveForm.Hide();
            Form1 form = new Form1();
            form.Show();
        }

        private void countButton_Click(object sender, EventArgs e)
        {
            try
            {
                double result;
                double height = Convert.ToInt32(heightTextBox.Text);
                double weight = Convert.ToInt32(fatTextBox.Text);
                result = weight / ((height / 100) * (height / 100));
                bmiNumberLabel.Text = result.ToString();
                if (result < 18)
                {
                    healthPictureBox.ImageLocation = $@"D:\.загрузки\underweigt.png";
                    cursorPanel.Location = new Point(464, 421);
                    healthLabel.Text = "Недостаточный";
                }
                else if (18 <= result && result < 25)
                {
                    healthPictureBox.ImageLocation = $@"D:\.загрузки\healthy.png";
                    cursorPanel.Location = new Point(560, 421);
                    healthLabel.Text = "Здоровый";
                }
                else if (25 <= result && result < 30)
                {
                    healthPictureBox.ImageLocation = $@"D:\.загрузки\over.png";
                    cursorPanel.Location = new Point(654, 421);
                    healthLabel.Text = "Избыточный";
                }
                else if (result >= 30)
                {
                    healthPictureBox.ImageLocation = $@"D:\.загрузки\obese.png";
                    cursorPanel.Location = new Point(750, 421);
                    healthLabel.Text = "Ожирение";
                }
                else
                {
                    MessageBox.Show("Ошибка в подсчетах");
                }
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }
        }
    }
    }

