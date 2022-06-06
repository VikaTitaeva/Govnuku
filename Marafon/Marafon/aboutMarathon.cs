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
    public partial class aboutMarathon : Form
    {
        public aboutMarathon()
        {
            InitializeComponent();
        }

        private void aboutTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void upPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void back_btn_Click(object sender, EventArgs e)
        {
            aboutMarathon.ActiveForm.Hide();
            Form1 form = new Form1();
            form.Show();
        }

        private void mapPictureBox_Click(object sender, EventArgs e)
        {
            aboutMarathon.ActiveForm.Hide();
            map form = new map();
            form.Show();
        }

        private void timerLabel_Click(object sender, EventArgs e)
        {

        }
    }
}
