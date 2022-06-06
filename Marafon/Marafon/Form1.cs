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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void marathonButton_Click(object sender, EventArgs e)
        {
            Form1.ActiveForm.Hide();
            aboutMarathon form = new aboutMarathon();
            form.Show();
        }

        private void durationButton_Click(object sender, EventArgs e)
        {
            Form1.ActiveForm.Hide();
            durationMarathon form = new durationMarathon();
            form.Show();
        }

        private void bmiButton_Click(object sender, EventArgs e)
        {
            Form1.ActiveForm.Hide();
            BMIcalc form = new BMIcalc();
            form.Show();
        }

        private void bmrButton_Click(object sender, EventArgs e)
        {
            Form1.ActiveForm.Hide();
            BMRcalc form = new BMRcalc();
            form.Show();
        }
    }
}
