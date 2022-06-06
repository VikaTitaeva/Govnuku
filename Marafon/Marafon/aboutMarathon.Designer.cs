
namespace Marafon
{
    partial class aboutMarathon
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(aboutMarathon));
            this.headerLabel = new System.Windows.Forms.Label();
            this.upPanel = new System.Windows.Forms.Panel();
            this.back_btn = new System.Windows.Forms.Button();
            this.mapPictureBox = new System.Windows.Forms.PictureBox();
            this.infoLabel = new System.Windows.Forms.Label();
            this.info4PictureBox = new System.Windows.Forms.PictureBox();
            this.info2PictureBox = new System.Windows.Forms.PictureBox();
            this.info3PictureBox = new System.Windows.Forms.PictureBox();
            this.info1PictureBox = new System.Windows.Forms.PictureBox();
            this.aboutTextBox = new System.Windows.Forms.TextBox();
            this.timerLabel = new System.Windows.Forms.Label();
            this.downPanel = new System.Windows.Forms.Panel();
            this.upPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mapPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.info4PictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.info2PictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.info3PictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.info1PictureBox)).BeginInit();
            this.downPanel.SuspendLayout();
            this.SuspendLayout();
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
            this.upPanel.Size = new System.Drawing.Size(1159, 85);
            this.upPanel.TabIndex = 10;
            this.upPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.upPanel_Paint);
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
            // mapPictureBox
            // 
            this.mapPictureBox.BackColor = System.Drawing.SystemColors.Control;
            this.mapPictureBox.Image = ((System.Drawing.Image)(resources.GetObject("mapPictureBox.Image")));
            this.mapPictureBox.Location = new System.Drawing.Point(40, 162);
            this.mapPictureBox.Margin = new System.Windows.Forms.Padding(4);
            this.mapPictureBox.Name = "mapPictureBox";
            this.mapPictureBox.Size = new System.Drawing.Size(419, 235);
            this.mapPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.mapPictureBox.TabIndex = 72;
            this.mapPictureBox.TabStop = false;
            this.mapPictureBox.Click += new System.EventHandler(this.mapPictureBox_Click);
            // 
            // infoLabel
            // 
            this.infoLabel.AutoSize = true;
            this.infoLabel.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.infoLabel.ForeColor = System.Drawing.Color.Black;
            this.infoLabel.Location = new System.Drawing.Point(300, 108);
            this.infoLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.infoLabel.Name = "infoLabel";
            this.infoLabel.Size = new System.Drawing.Size(510, 35);
            this.infoLabel.TabIndex = 73;
            this.infoLabel.Text = "Информация о Marathon Skills 2016";
            // 
            // info4PictureBox
            // 
            this.info4PictureBox.BackColor = System.Drawing.SystemColors.Control;
            this.info4PictureBox.Image = ((System.Drawing.Image)(resources.GetObject("info4PictureBox.Image")));
            this.info4PictureBox.Location = new System.Drawing.Point(256, 544);
            this.info4PictureBox.Margin = new System.Windows.Forms.Padding(4);
            this.info4PictureBox.Name = "info4PictureBox";
            this.info4PictureBox.Size = new System.Drawing.Size(203, 119);
            this.info4PictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.info4PictureBox.TabIndex = 79;
            this.info4PictureBox.TabStop = false;
            // 
            // info2PictureBox
            // 
            this.info2PictureBox.BackColor = System.Drawing.SystemColors.Control;
            this.info2PictureBox.Image = ((System.Drawing.Image)(resources.GetObject("info2PictureBox.Image")));
            this.info2PictureBox.Location = new System.Drawing.Point(256, 418);
            this.info2PictureBox.Margin = new System.Windows.Forms.Padding(4);
            this.info2PictureBox.Name = "info2PictureBox";
            this.info2PictureBox.Size = new System.Drawing.Size(203, 119);
            this.info2PictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.info2PictureBox.TabIndex = 78;
            this.info2PictureBox.TabStop = false;
            // 
            // info3PictureBox
            // 
            this.info3PictureBox.BackColor = System.Drawing.SystemColors.Control;
            this.info3PictureBox.Image = ((System.Drawing.Image)(resources.GetObject("info3PictureBox.Image")));
            this.info3PictureBox.Location = new System.Drawing.Point(40, 544);
            this.info3PictureBox.Margin = new System.Windows.Forms.Padding(4);
            this.info3PictureBox.Name = "info3PictureBox";
            this.info3PictureBox.Size = new System.Drawing.Size(203, 119);
            this.info3PictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.info3PictureBox.TabIndex = 77;
            this.info3PictureBox.TabStop = false;
            // 
            // info1PictureBox
            // 
            this.info1PictureBox.BackColor = System.Drawing.SystemColors.Control;
            this.info1PictureBox.Image = ((System.Drawing.Image)(resources.GetObject("info1PictureBox.Image")));
            this.info1PictureBox.Location = new System.Drawing.Point(40, 418);
            this.info1PictureBox.Margin = new System.Windows.Forms.Padding(4);
            this.info1PictureBox.Name = "info1PictureBox";
            this.info1PictureBox.Size = new System.Drawing.Size(203, 119);
            this.info1PictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.info1PictureBox.TabIndex = 76;
            this.info1PictureBox.TabStop = false;
            // 
            // aboutTextBox
            // 
            this.aboutTextBox.BackColor = System.Drawing.SystemColors.Control;
            this.aboutTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.aboutTextBox.Font = new System.Drawing.Font("Arial", 14.25F);
            this.aboutTextBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.aboutTextBox.Location = new System.Drawing.Point(504, 162);
            this.aboutTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.aboutTextBox.Multiline = true;
            this.aboutTextBox.Name = "aboutTextBox";
            this.aboutTextBox.ReadOnly = true;
            this.aboutTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.aboutTextBox.Size = new System.Drawing.Size(606, 501);
            this.aboutTextBox.TabIndex = 80;
            this.aboutTextBox.Text = resources.GetString("aboutTextBox.Text");
            this.aboutTextBox.TextChanged += new System.EventHandler(this.aboutTextBox_TextChanged);
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
            this.timerLabel.Click += new System.EventHandler(this.timerLabel_Click);
            // 
            // downPanel
            // 
            this.downPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.downPanel.Controls.Add(this.timerLabel);
            this.downPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.downPanel.Location = new System.Drawing.Point(0, 720);
            this.downPanel.Margin = new System.Windows.Forms.Padding(4);
            this.downPanel.Name = "downPanel";
            this.downPanel.Size = new System.Drawing.Size(1159, 55);
            this.downPanel.TabIndex = 81;
            // 
            // aboutMarathon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1159, 775);
            this.Controls.Add(this.downPanel);
            this.Controls.Add(this.aboutTextBox);
            this.Controls.Add(this.info4PictureBox);
            this.Controls.Add(this.info2PictureBox);
            this.Controls.Add(this.info3PictureBox);
            this.Controls.Add(this.info1PictureBox);
            this.Controls.Add(this.infoLabel);
            this.Controls.Add(this.mapPictureBox);
            this.Controls.Add(this.upPanel);
            this.Name = "aboutMarathon";
            this.Text = "aboutMarathon";
            this.upPanel.ResumeLayout(false);
            this.upPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mapPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.info4PictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.info2PictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.info3PictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.info1PictureBox)).EndInit();
            this.downPanel.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label headerLabel;
        private System.Windows.Forms.Panel upPanel;
        private System.Windows.Forms.Button back_btn;
        private System.Windows.Forms.PictureBox mapPictureBox;
        private System.Windows.Forms.Label infoLabel;
        private System.Windows.Forms.PictureBox info4PictureBox;
        private System.Windows.Forms.PictureBox info2PictureBox;
        private System.Windows.Forms.PictureBox info3PictureBox;
        private System.Windows.Forms.PictureBox info1PictureBox;
        private System.Windows.Forms.TextBox aboutTextBox;
        private System.Windows.Forms.Label timerLabel;
        private System.Windows.Forms.Panel downPanel;
    }
}