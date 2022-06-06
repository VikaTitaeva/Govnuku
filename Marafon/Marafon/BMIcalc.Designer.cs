
namespace Marafon
{
    partial class BMIcalc
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BMIcalc));
            this.back_btn = new System.Windows.Forms.Button();
            this.headerLabel = new System.Windows.Forms.Label();
            this.upPanel = new System.Windows.Forms.Panel();
            this.timerLabel = new System.Windows.Forms.Label();
            this.downPanel = new System.Windows.Forms.Panel();
            this.infoLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tooMuchLabel = new System.Windows.Forms.Label();
            this.biggerLabel = new System.Windows.Forms.Label();
            this.healthyLabel = new System.Windows.Forms.Label();
            this.notEnoughLabel = new System.Windows.Forms.Label();
            this.cursorPanel = new System.Windows.Forms.Panel();
            this.bmiNumberLabel = new System.Windows.Forms.Label();
            this.cursorPictureBox = new System.Windows.Forms.PictureBox();
            this.tooMuchPanel = new System.Windows.Forms.Panel();
            this.notEnoughPanel = new System.Windows.Forms.Panel();
            this.biggerPanel = new System.Windows.Forms.Panel();
            this.healthyPanel = new System.Windows.Forms.Panel();
            this.healthPanel = new System.Windows.Forms.Panel();
            this.healthLabel = new System.Windows.Forms.Label();
            this.healthPictureBox = new System.Windows.Forms.PictureBox();
            this.malePanel = new System.Windows.Forms.Panel();
            this.maleLabel = new System.Windows.Forms.Label();
            this.malePictureBox = new System.Windows.Forms.PictureBox();
            this.smLabel = new System.Windows.Forms.Label();
            this.kgLabel = new System.Windows.Forms.Label();
            this.cancelButton = new System.Windows.Forms.Button();
            this.fatLabel = new System.Windows.Forms.Label();
            this.heightTextBox = new System.Windows.Forms.MaskedTextBox();
            this.fatTextBox = new System.Windows.Forms.MaskedTextBox();
            this.countButton = new System.Windows.Forms.Button();
            this.heightLabel = new System.Windows.Forms.Label();
            this.descriptionLabel = new System.Windows.Forms.Label();
            this.femalePanel = new System.Windows.Forms.Panel();
            this.femaleLabel = new System.Windows.Forms.Label();
            this.femalePictureBox = new System.Windows.Forms.PictureBox();
            this.upPanel.SuspendLayout();
            this.downPanel.SuspendLayout();
            this.cursorPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cursorPictureBox)).BeginInit();
            this.healthPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.healthPictureBox)).BeginInit();
            this.malePanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.malePictureBox)).BeginInit();
            this.femalePanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.femalePictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // back_btn
            // 
            this.back_btn.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.back_btn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.back_btn.Location = new System.Drawing.Point(13, 18);
            this.back_btn.Margin = new System.Windows.Forms.Padding(4);
            this.back_btn.Name = "back_btn";
            this.back_btn.Size = new System.Drawing.Size(108, 48);
            this.back_btn.TabIndex = 11;
            this.back_btn.Text = "Назад";
            this.back_btn.UseVisualStyleBackColor = true;
            this.back_btn.Click += new System.EventHandler(this.back_btn_Click);
            // 
            // headerLabel
            // 
            this.headerLabel.AutoSize = true;
            this.headerLabel.Font = new System.Drawing.Font("Arial Black", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.headerLabel.ForeColor = System.Drawing.SystemColors.Control;
            this.headerLabel.Location = new System.Drawing.Point(144, 18);
            this.headerLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.headerLabel.Name = "headerLabel";
            this.headerLabel.Size = new System.Drawing.Size(575, 56);
            this.headerLabel.TabIndex = 1;
            this.headerLabel.Text = "MARATHON SKILLS 2016";
            // 
            // upPanel
            // 
            this.upPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.upPanel.Controls.Add(this.back_btn);
            this.upPanel.Controls.Add(this.headerLabel);
            this.upPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.upPanel.Location = new System.Drawing.Point(0, 0);
            this.upPanel.Margin = new System.Windows.Forms.Padding(4);
            this.upPanel.Name = "upPanel";
            this.upPanel.Size = new System.Drawing.Size(1097, 85);
            this.upPanel.TabIndex = 83;
            // 
            // timerLabel
            // 
            this.timerLabel.Font = new System.Drawing.Font("Arial", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.timerLabel.ForeColor = System.Drawing.SystemColors.Control;
            this.timerLabel.Location = new System.Drawing.Point(22, 10);
            this.timerLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.timerLabel.Name = "timerLabel";
            this.timerLabel.Size = new System.Drawing.Size(1101, 39);
            this.timerLabel.TabIndex = 41;
            this.timerLabel.Text = "18 дней 8 часов и 17 минут до старта марафона!";
            this.timerLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // downPanel
            // 
            this.downPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.downPanel.Controls.Add(this.timerLabel);
            this.downPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.downPanel.Location = new System.Drawing.Point(0, 680);
            this.downPanel.Margin = new System.Windows.Forms.Padding(4);
            this.downPanel.Name = "downPanel";
            this.downPanel.Size = new System.Drawing.Size(1097, 55);
            this.downPanel.TabIndex = 84;
            // 
            // infoLabel
            // 
            this.infoLabel.AutoSize = true;
            this.infoLabel.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.infoLabel.ForeColor = System.Drawing.Color.Black;
            this.infoLabel.Location = new System.Drawing.Point(415, 113);
            this.infoLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.infoLabel.Name = "infoLabel";
            this.infoLabel.Size = new System.Drawing.Size(247, 35);
            this.infoLabel.TabIndex = 85;
            this.infoLabel.Text = "BMI калькулятор";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(339, 365);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 35);
            this.label1.TabIndex = 86;
            // 
            // tooMuchLabel
            // 
            this.tooMuchLabel.AutoSize = true;
            this.tooMuchLabel.Font = new System.Drawing.Font("Arial", 10F);
            this.tooMuchLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))));
            this.tooMuchLabel.Location = new System.Drawing.Point(938, 593);
            this.tooMuchLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.tooMuchLabel.Name = "tooMuchLabel";
            this.tooMuchLabel.Size = new System.Drawing.Size(86, 19);
            this.tooMuchLabel.TabIndex = 107;
            this.tooMuchLabel.Text = "Ожирение";
            // 
            // biggerLabel
            // 
            this.biggerLabel.AutoSize = true;
            this.biggerLabel.Font = new System.Drawing.Font("Arial", 10F);
            this.biggerLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))));
            this.biggerLabel.Location = new System.Drawing.Point(810, 593);
            this.biggerLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.biggerLabel.Name = "biggerLabel";
            this.biggerLabel.Size = new System.Drawing.Size(106, 19);
            this.biggerLabel.TabIndex = 106;
            this.biggerLabel.Text = "Избыточный";
            // 
            // healthyLabel
            // 
            this.healthyLabel.AutoSize = true;
            this.healthyLabel.Font = new System.Drawing.Font("Arial", 10F);
            this.healthyLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))));
            this.healthyLabel.Location = new System.Drawing.Point(698, 593);
            this.healthyLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.healthyLabel.Name = "healthyLabel";
            this.healthyLabel.Size = new System.Drawing.Size(86, 19);
            this.healthyLabel.TabIndex = 105;
            this.healthyLabel.Text = "Здоровый";
            // 
            // notEnoughLabel
            // 
            this.notEnoughLabel.AutoSize = true;
            this.notEnoughLabel.Font = new System.Drawing.Font("Arial", 10F);
            this.notEnoughLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))));
            this.notEnoughLabel.Location = new System.Drawing.Point(545, 593);
            this.notEnoughLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.notEnoughLabel.Name = "notEnoughLabel";
            this.notEnoughLabel.Size = new System.Drawing.Size(130, 19);
            this.notEnoughLabel.TabIndex = 104;
            this.notEnoughLabel.Text = "Недостаточный";
            // 
            // cursorPanel
            // 
            this.cursorPanel.Controls.Add(this.bmiNumberLabel);
            this.cursorPanel.Controls.Add(this.cursorPictureBox);
            this.cursorPanel.Location = new System.Drawing.Point(702, 508);
            this.cursorPanel.Margin = new System.Windows.Forms.Padding(4);
            this.cursorPanel.Name = "cursorPanel";
            this.cursorPanel.Size = new System.Drawing.Size(79, 63);
            this.cursorPanel.TabIndex = 103;
            // 
            // bmiNumberLabel
            // 
            this.bmiNumberLabel.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.bmiNumberLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.bmiNumberLabel.Location = new System.Drawing.Point(4, 6);
            this.bmiNumberLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.bmiNumberLabel.Name = "bmiNumberLabel";
            this.bmiNumberLabel.Size = new System.Drawing.Size(71, 27);
            this.bmiNumberLabel.TabIndex = 61;
            this.bmiNumberLabel.Text = "24.2";
            this.bmiNumberLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cursorPictureBox
            // 
            this.cursorPictureBox.Image = ((System.Drawing.Image)(resources.GetObject("cursorPictureBox.Image")));
            this.cursorPictureBox.Location = new System.Drawing.Point(9, 37);
            this.cursorPictureBox.Margin = new System.Windows.Forms.Padding(4);
            this.cursorPictureBox.Name = "cursorPictureBox";
            this.cursorPictureBox.Size = new System.Drawing.Size(55, 23);
            this.cursorPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.cursorPictureBox.TabIndex = 59;
            this.cursorPictureBox.TabStop = false;
            // 
            // tooMuchPanel
            // 
            this.tooMuchPanel.BackColor = System.Drawing.Color.Red;
            this.tooMuchPanel.Location = new System.Drawing.Point(933, 577);
            this.tooMuchPanel.Margin = new System.Windows.Forms.Padding(4);
            this.tooMuchPanel.Name = "tooMuchPanel";
            this.tooMuchPanel.Size = new System.Drawing.Size(129, 12);
            this.tooMuchPanel.TabIndex = 102;
            // 
            // notEnoughPanel
            // 
            this.notEnoughPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.notEnoughPanel.Location = new System.Drawing.Point(549, 577);
            this.notEnoughPanel.Margin = new System.Windows.Forms.Padding(4);
            this.notEnoughPanel.Name = "notEnoughPanel";
            this.notEnoughPanel.Size = new System.Drawing.Size(129, 12);
            this.notEnoughPanel.TabIndex = 99;
            // 
            // biggerPanel
            // 
            this.biggerPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.biggerPanel.Location = new System.Drawing.Point(808, 577);
            this.biggerPanel.Margin = new System.Windows.Forms.Padding(4);
            this.biggerPanel.Name = "biggerPanel";
            this.biggerPanel.Size = new System.Drawing.Size(129, 12);
            this.biggerPanel.TabIndex = 101;
            // 
            // healthyPanel
            // 
            this.healthyPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(223)))), ((int)(((byte)(0)))));
            this.healthyPanel.Location = new System.Drawing.Point(678, 577);
            this.healthyPanel.Margin = new System.Windows.Forms.Padding(4);
            this.healthyPanel.Name = "healthyPanel";
            this.healthyPanel.Size = new System.Drawing.Size(129, 12);
            this.healthyPanel.TabIndex = 100;
            // 
            // healthPanel
            // 
            this.healthPanel.BackColor = System.Drawing.Color.LightGray;
            this.healthPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.healthPanel.Controls.Add(this.healthLabel);
            this.healthPanel.Controls.Add(this.healthPictureBox);
            this.healthPanel.Location = new System.Drawing.Point(678, 178);
            this.healthPanel.Margin = new System.Windows.Forms.Padding(4);
            this.healthPanel.Name = "healthPanel";
            this.healthPanel.Size = new System.Drawing.Size(243, 294);
            this.healthPanel.TabIndex = 98;
            // 
            // healthLabel
            // 
            this.healthLabel.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.healthLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.healthLabel.Location = new System.Drawing.Point(4, 257);
            this.healthLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.healthLabel.Name = "healthLabel";
            this.healthLabel.Size = new System.Drawing.Size(233, 27);
            this.healthLabel.TabIndex = 53;
            this.healthLabel.Text = "Здоровый";
            this.healthLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // healthPictureBox
            // 
            this.healthPictureBox.BackColor = System.Drawing.Color.LightGray;
            this.healthPictureBox.Image = ((System.Drawing.Image)(resources.GetObject("healthPictureBox.Image")));
            this.healthPictureBox.Location = new System.Drawing.Point(4, 40);
            this.healthPictureBox.Margin = new System.Windows.Forms.Padding(4);
            this.healthPictureBox.Name = "healthPictureBox";
            this.healthPictureBox.Size = new System.Drawing.Size(233, 191);
            this.healthPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.healthPictureBox.TabIndex = 51;
            this.healthPictureBox.TabStop = false;
            // 
            // malePanel
            // 
            this.malePanel.BackColor = System.Drawing.Color.LightGray;
            this.malePanel.Controls.Add(this.maleLabel);
            this.malePanel.Controls.Add(this.malePictureBox);
            this.malePanel.Location = new System.Drawing.Point(50, 236);
            this.malePanel.Margin = new System.Windows.Forms.Padding(4);
            this.malePanel.Name = "malePanel";
            this.malePanel.Size = new System.Drawing.Size(175, 154);
            this.malePanel.TabIndex = 97;
            // 
            // maleLabel
            // 
            this.maleLabel.BackColor = System.Drawing.Color.LightGray;
            this.maleLabel.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.maleLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.maleLabel.Location = new System.Drawing.Point(7, 124);
            this.maleLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.maleLabel.Name = "maleLabel";
            this.maleLabel.Size = new System.Drawing.Size(164, 27);
            this.maleLabel.TabIndex = 54;
            this.maleLabel.Text = "Мужской";
            this.maleLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // malePictureBox
            // 
            this.malePictureBox.BackColor = System.Drawing.Color.LightGray;
            this.malePictureBox.Image = ((System.Drawing.Image)(resources.GetObject("malePictureBox.Image")));
            this.malePictureBox.Location = new System.Drawing.Point(4, 17);
            this.malePictureBox.Margin = new System.Windows.Forms.Padding(4);
            this.malePictureBox.Name = "malePictureBox";
            this.malePictureBox.Size = new System.Drawing.Size(167, 103);
            this.malePictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.malePictureBox.TabIndex = 50;
            this.malePictureBox.TabStop = false;
            // 
            // smLabel
            // 
            this.smLabel.AutoSize = true;
            this.smLabel.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.smLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.smLabel.Location = new System.Drawing.Point(227, 403);
            this.smLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.smLabel.Name = "smLabel";
            this.smLabel.Size = new System.Drawing.Size(41, 27);
            this.smLabel.TabIndex = 95;
            this.smLabel.Text = "см";
            // 
            // kgLabel
            // 
            this.kgLabel.AutoSize = true;
            this.kgLabel.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.kgLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.kgLabel.Location = new System.Drawing.Point(227, 464);
            this.kgLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.kgLabel.Name = "kgLabel";
            this.kgLabel.Size = new System.Drawing.Size(32, 27);
            this.kgLabel.TabIndex = 94;
            this.kgLabel.Text = "кг";
            // 
            // cancelButton
            // 
            this.cancelButton.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cancelButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.cancelButton.Location = new System.Drawing.Point(232, 508);
            this.cancelButton.Margin = new System.Windows.Forms.Padding(4);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(175, 37);
            this.cancelButton.TabIndex = 93;
            this.cancelButton.Text = "Отмена";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // fatLabel
            // 
            this.fatLabel.AutoSize = true;
            this.fatLabel.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.fatLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.fatLabel.Location = new System.Drawing.Point(51, 464);
            this.fatLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.fatLabel.Name = "fatLabel";
            this.fatLabel.Size = new System.Drawing.Size(60, 27);
            this.fatLabel.TabIndex = 92;
            this.fatLabel.Text = "Вес:";
            // 
            // heightTextBox
            // 
            this.heightTextBox.Font = new System.Drawing.Font("Arial", 14.25F);
            this.heightTextBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.heightTextBox.Location = new System.Drawing.Point(134, 399);
            this.heightTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.heightTextBox.Mask = "000";
            this.heightTextBox.Name = "heightTextBox";
            this.heightTextBox.Size = new System.Drawing.Size(84, 35);
            this.heightTextBox.TabIndex = 91;
            // 
            // fatTextBox
            // 
            this.fatTextBox.Font = new System.Drawing.Font("Arial", 14.25F);
            this.fatTextBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.fatTextBox.Location = new System.Drawing.Point(134, 456);
            this.fatTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.fatTextBox.Mask = "000";
            this.fatTextBox.Name = "fatTextBox";
            this.fatTextBox.Size = new System.Drawing.Size(84, 35);
            this.fatTextBox.TabIndex = 90;
            // 
            // countButton
            // 
            this.countButton.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.countButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.countButton.Location = new System.Drawing.Point(49, 508);
            this.countButton.Margin = new System.Windows.Forms.Padding(4);
            this.countButton.Name = "countButton";
            this.countButton.Size = new System.Drawing.Size(175, 37);
            this.countButton.TabIndex = 89;
            this.countButton.Text = "Рассчитать";
            this.countButton.UseVisualStyleBackColor = true;
            this.countButton.Click += new System.EventHandler(this.countButton_Click);
            // 
            // heightLabel
            // 
            this.heightLabel.AutoSize = true;
            this.heightLabel.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.heightLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.heightLabel.Location = new System.Drawing.Point(51, 403);
            this.heightLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.heightLabel.Name = "heightLabel";
            this.heightLabel.Size = new System.Drawing.Size(70, 27);
            this.heightLabel.TabIndex = 88;
            this.heightLabel.Text = "Рост:";
            // 
            // descriptionLabel
            // 
            this.descriptionLabel.AutoSize = true;
            this.descriptionLabel.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.descriptionLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.descriptionLabel.Location = new System.Drawing.Point(45, 178);
            this.descriptionLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.descriptionLabel.Name = "descriptionLabel";
            this.descriptionLabel.Size = new System.Drawing.Size(414, 54);
            this.descriptionLabel.TabIndex = 87;
            this.descriptionLabel.Text = "Информация о том, что такое BMI и\r\nкак калькулятор работает\r\n";
            this.descriptionLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // femalePanel
            // 
            this.femalePanel.BackColor = System.Drawing.Color.LightGray;
            this.femalePanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.femalePanel.Controls.Add(this.femaleLabel);
            this.femalePanel.Controls.Add(this.femalePictureBox);
            this.femalePanel.Location = new System.Drawing.Point(233, 236);
            this.femalePanel.Margin = new System.Windows.Forms.Padding(4);
            this.femalePanel.Name = "femalePanel";
            this.femalePanel.Size = new System.Drawing.Size(174, 153);
            this.femalePanel.TabIndex = 96;
            // 
            // femaleLabel
            // 
            this.femaleLabel.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.femaleLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.femaleLabel.Location = new System.Drawing.Point(4, 123);
            this.femaleLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.femaleLabel.Name = "femaleLabel";
            this.femaleLabel.Size = new System.Drawing.Size(164, 27);
            this.femaleLabel.TabIndex = 53;
            this.femaleLabel.Text = "Женский";
            this.femaleLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // femalePictureBox
            // 
            this.femalePictureBox.BackColor = System.Drawing.Color.LightGray;
            this.femalePictureBox.Image = ((System.Drawing.Image)(resources.GetObject("femalePictureBox.Image")));
            this.femalePictureBox.Location = new System.Drawing.Point(0, 16);
            this.femalePictureBox.Margin = new System.Windows.Forms.Padding(4);
            this.femalePictureBox.Name = "femalePictureBox";
            this.femalePictureBox.Size = new System.Drawing.Size(173, 103);
            this.femalePictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.femalePictureBox.TabIndex = 51;
            this.femalePictureBox.TabStop = false;
            // 
            // BMIcalc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1097, 735);
            this.Controls.Add(this.tooMuchLabel);
            this.Controls.Add(this.biggerLabel);
            this.Controls.Add(this.healthyLabel);
            this.Controls.Add(this.notEnoughLabel);
            this.Controls.Add(this.cursorPanel);
            this.Controls.Add(this.tooMuchPanel);
            this.Controls.Add(this.notEnoughPanel);
            this.Controls.Add(this.biggerPanel);
            this.Controls.Add(this.healthyPanel);
            this.Controls.Add(this.healthPanel);
            this.Controls.Add(this.malePanel);
            this.Controls.Add(this.smLabel);
            this.Controls.Add(this.kgLabel);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.fatLabel);
            this.Controls.Add(this.heightTextBox);
            this.Controls.Add(this.fatTextBox);
            this.Controls.Add(this.countButton);
            this.Controls.Add(this.heightLabel);
            this.Controls.Add(this.descriptionLabel);
            this.Controls.Add(this.femalePanel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.infoLabel);
            this.Controls.Add(this.upPanel);
            this.Controls.Add(this.downPanel);
            this.Name = "BMIcalc";
            this.Text = "BMIcalc";
            this.upPanel.ResumeLayout(false);
            this.upPanel.PerformLayout();
            this.downPanel.ResumeLayout(false);
            this.cursorPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.cursorPictureBox)).EndInit();
            this.healthPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.healthPictureBox)).EndInit();
            this.malePanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.malePictureBox)).EndInit();
            this.femalePanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.femalePictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button back_btn;
        private System.Windows.Forms.Label headerLabel;
        private System.Windows.Forms.Panel upPanel;
        private System.Windows.Forms.Label timerLabel;
        private System.Windows.Forms.Panel downPanel;
        private System.Windows.Forms.Label infoLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label tooMuchLabel;
        private System.Windows.Forms.Label biggerLabel;
        private System.Windows.Forms.Label healthyLabel;
        private System.Windows.Forms.Label notEnoughLabel;
        private System.Windows.Forms.Panel cursorPanel;
        private System.Windows.Forms.Label bmiNumberLabel;
        private System.Windows.Forms.PictureBox cursorPictureBox;
        private System.Windows.Forms.Panel tooMuchPanel;
        private System.Windows.Forms.Panel notEnoughPanel;
        private System.Windows.Forms.Panel biggerPanel;
        private System.Windows.Forms.Panel healthyPanel;
        private System.Windows.Forms.Panel healthPanel;
        private System.Windows.Forms.Label healthLabel;
        private System.Windows.Forms.PictureBox healthPictureBox;
        private System.Windows.Forms.Panel malePanel;
        private System.Windows.Forms.Label maleLabel;
        private System.Windows.Forms.PictureBox malePictureBox;
        private System.Windows.Forms.Label smLabel;
        private System.Windows.Forms.Label kgLabel;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.Label fatLabel;
        private System.Windows.Forms.MaskedTextBox heightTextBox;
        private System.Windows.Forms.MaskedTextBox fatTextBox;
        private System.Windows.Forms.Button countButton;
        private System.Windows.Forms.Label heightLabel;
        private System.Windows.Forms.Label descriptionLabel;
        private System.Windows.Forms.Panel femalePanel;
        private System.Windows.Forms.Label femaleLabel;
        private System.Windows.Forms.PictureBox femalePictureBox;
    }
}