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
    public partial class map : Form
    {
        public map()
        {
            InitializeComponent();
        }
        private void showInfo(string name, string d1, string d2, string d3) //Передача данных в окошко с информацией
        {
            infoPanel.Show();
            markNameLabel.Text = name;
            description1Label.Text = d1;
            description2Label.Text = d2;
            description3Label.Text = d3;
        }

        private void startPictureBox_Click(object sender, EventArgs e)
        {
            showInfo("Старт", "Начало марафона", "Болельщики", "Призы");
        }

        private void infoPictureBox_Click(object sender, EventArgs e)
        {
            showInfo("Стойка информации", "Получить информацию", "Купить сувениры", "Зарегистрироваться");
        }

        private void healthPictureBox_Click(object sender, EventArgs e)
        {
            showInfo("Медицинский пункт", "Получить первую помощь", "Завершить досрочно", "Взять воды");
        }

        private void drinkUpPictureBox_Click(object sender, EventArgs e)
        {
            showInfo("Стенд питья", "Взять воды", "Болельщики", "Место отдыха");
        }

        private void drinkBottomPictureBox_Click(object sender, EventArgs e)
        {
            showInfo("Стенд питья", "Взять воды", "Болельщики", "Место отдыха");
        }

        private void toiletPictureBox_Click(object sender, EventArgs e)
        {
            showInfo("Туалет", "Место отдыха", "Медицинский пункт", "Взять воды");
        }

        private void energyPictureBox_Click(object sender, EventArgs e)
        {
            showInfo("Энергетические батончики", "Взять воды", "Болельщики", "Купить сувениры");
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            map.ActiveForm.Hide();
            aboutMarathon form = new aboutMarathon();
            form.Show();
        }

        private void exitPictureBox_Click(object sender, EventArgs e)
        {
            infoPanel.Hide();
        }
        
    }
}
