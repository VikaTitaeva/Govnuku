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
    public partial class activityLevel : Form
    {
        public activityLevel()
        {
            InitializeComponent();
        }

        private void littleDescriptionLabel_Click(object sender, EventArgs e)
        {

        }

        private void exitPictureBox_Click(object sender, EventArgs e)
        {
            activityLevel.ActiveForm.Hide();
            BMRcalc form = new BMRcalc();
            form.Show();
        }
    }
}
