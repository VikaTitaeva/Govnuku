using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PR_23_24
{
    public partial class Form2 : Form
    {
        Color colorResult;
        public Form2()
        {
            InitializeComponent();
            hScrollBar1.Tag = numericUpDown1;
            hScrollBar2.Tag = numericUpDown2;
            hScrollBar3.Tag = numericUpDown3;
            numericUpDown1.Tag = hScrollBar1;
            numericUpDown2.Tag = hScrollBar2;
            numericUpDown3.Tag = hScrollBar3;
        }
        private void Form2_Load(object sender, EventArgs e)
        {

        }
        private void hScrollBar1_Scroll(object sender, ScrollEventArgs e)
        {
            ScrollBar scrollBar = (ScrollBar)sender;
            NumericUpDown numericUpDown = (NumericUpDown)scrollBar.Tag;
            numericUpDown.Value = scrollBar.Value;
            UpdateColor();
        }
        private void hScrollBar2_Scroll(object sender, ScrollEventArgs e)
        {
            ScrollBar scrollBar = (ScrollBar)sender;
            NumericUpDown numericUpDown = (NumericUpDown)scrollBar.Tag;
            numericUpDown.Value = scrollBar.Value;
            UpdateColor();
        }
        private void hScrollBar3_Scroll(object sender, ScrollEventArgs e)
        {
            ScrollBar scrollBar = (ScrollBar)sender;
            NumericUpDown numericUpDown = (NumericUpDown)scrollBar.Tag;
            numericUpDown.Value = scrollBar.Value;
            UpdateColor();
        }
        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            NumericUpDown numericUpDown = (NumericUpDown)sender;
            ScrollBar scrollBar = (ScrollBar)numericUpDown.Tag;
            scrollBar.Value = (int)numericUpDown.Value;
        }
        private void numericUpDown2_ValueChanged(object sender, EventArgs e)
        {
            NumericUpDown numericUpDown = (NumericUpDown)sender;
            ScrollBar scrollBar = (ScrollBar)numericUpDown.Tag;
            scrollBar.Value = (int)numericUpDown.Value;
        }
        private void numericUpDown3_ValueChanged(object sender, EventArgs e)
        {
            NumericUpDown numericUpDown = (NumericUpDown)sender;
            ScrollBar scrollBar = (ScrollBar)numericUpDown.Tag;
            scrollBar.Value = (int)numericUpDown.Value;
        }
        private void UpdateColor()
        {
            colorResult = Color.FromArgb(hScrollBar1.Value, hScrollBar2.Value, hScrollBar3.Value);
            pictureBox1.BackColor = colorResult;
        }
        private void button3_Click(object sender, EventArgs e)
        {
            ColorDialog colorDialog = new ColorDialog();
            if (colorDialog.ShowDialog() == DialogResult.OK)
            {
                hScrollBar1.Value = colorDialog.Color.R;
                hScrollBar2.Value = colorDialog.Color.G;
                hScrollBar3.Value = colorDialog.Color.B;
                colorResult = colorDialog.Color;
                UpdateColor();
            }
        }
        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            Form1 main = this.Owner as Form1;
            if (main != null)
            {
                Color col = main.currentPen.Color;
                main.currentPen.Color = colorResult;
            }
            this.Close();
        }
    }
}
