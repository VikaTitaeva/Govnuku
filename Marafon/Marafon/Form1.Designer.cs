
namespace Marafon
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.upPanel = new System.Windows.Forms.Panel();
            this.headerLabel = new System.Windows.Forms.Label();
            this.infoLabel = new System.Windows.Forms.Label();
            this.marathonButton = new System.Windows.Forms.Button();
            this.durationButton = new System.Windows.Forms.Button();
            this.bmrButton = new System.Windows.Forms.Button();
            this.bmiButton = new System.Windows.Forms.Button();
            this.downPanel = new System.Windows.Forms.Panel();
            this.timerLabel = new System.Windows.Forms.Label();
            this.upPanel.SuspendLayout();
            this.downPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // upPanel
            // 
            this.upPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.upPanel.Controls.Add(this.headerLabel);
            this.upPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.upPanel.Location = new System.Drawing.Point(0, 0);
            this.upPanel.Margin = new System.Windows.Forms.Padding(4);
            this.upPanel.Name = "upPanel";
            this.upPanel.Size = new System.Drawing.Size(1032, 85);
            this.upPanel.TabIndex = 9;
            // 
            // headerLabel
            // 
            this.headerLabel.AutoSize = true;
            this.headerLabel.Font = new System.Drawing.Font("Arial Black", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.headerLabel.ForeColor = System.Drawing.SystemColors.Control;
            this.headerLabel.Location = new System.Drawing.Point(225, 19);
            this.headerLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.headerLabel.Name = "headerLabel";
            this.headerLabel.Size = new System.Drawing.Size(575, 56);
            this.headerLabel.TabIndex = 1;
            this.headerLabel.Text = "MARATHON SKILLS 2016";
            // 
            // infoLabel
            // 
            this.infoLabel.AutoSize = true;
            this.infoLabel.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.infoLabel.ForeColor = System.Drawing.Color.Black;
            this.infoLabel.Location = new System.Drawing.Point(198, 109);
            this.infoLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.infoLabel.Name = "infoLabel";
            this.infoLabel.Size = new System.Drawing.Size(639, 35);
            this.infoLabel.TabIndex = 11;
            this.infoLabel.Text = "ИНФОРМАЦИЯ О MARATHON SKILLS 2016";
            // 
            // marathonButton
            // 
            this.marathonButton.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.marathonButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.marathonButton.Location = new System.Drawing.Point(149, 185);
            this.marathonButton.Margin = new System.Windows.Forms.Padding(4);
            this.marathonButton.Name = "marathonButton";
            this.marathonButton.Size = new System.Drawing.Size(332, 101);
            this.marathonButton.TabIndex = 12;
            this.marathonButton.Text = "Marathon Skills 2016";
            this.marathonButton.UseVisualStyleBackColor = true;
            this.marathonButton.Click += new System.EventHandler(this.marathonButton_Click);
            // 
            // durationButton
            // 
            this.durationButton.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.durationButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.durationButton.Location = new System.Drawing.Point(541, 185);
            this.durationButton.Margin = new System.Windows.Forms.Padding(4);
            this.durationButton.Name = "durationButton";
            this.durationButton.Size = new System.Drawing.Size(332, 101);
            this.durationButton.TabIndex = 15;
            this.durationButton.Text = "Насколько долгий марафон";
            this.durationButton.UseVisualStyleBackColor = true;
            this.durationButton.Click += new System.EventHandler(this.durationButton_Click);
            // 
            // bmrButton
            // 
            this.bmrButton.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.bmrButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.bmrButton.Location = new System.Drawing.Point(541, 313);
            this.bmrButton.Margin = new System.Windows.Forms.Padding(4);
            this.bmrButton.Name = "bmrButton";
            this.bmrButton.Size = new System.Drawing.Size(332, 101);
            this.bmrButton.TabIndex = 18;
            this.bmrButton.Text = "BMR калькулятор";
            this.bmrButton.UseVisualStyleBackColor = true;
            this.bmrButton.Click += new System.EventHandler(this.bmrButton_Click);
            // 
            // bmiButton
            // 
            this.bmiButton.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.bmiButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.bmiButton.Location = new System.Drawing.Point(149, 313);
            this.bmiButton.Margin = new System.Windows.Forms.Padding(4);
            this.bmiButton.Name = "bmiButton";
            this.bmiButton.Size = new System.Drawing.Size(332, 101);
            this.bmiButton.TabIndex = 17;
            this.bmiButton.Text = "BMI калькулятор";
            this.bmiButton.UseVisualStyleBackColor = true;
            this.bmiButton.Click += new System.EventHandler(this.bmiButton_Click);
            // 
            // downPanel
            // 
            this.downPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.downPanel.Controls.Add(this.timerLabel);
            this.downPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.downPanel.Location = new System.Drawing.Point(0, 532);
            this.downPanel.Margin = new System.Windows.Forms.Padding(4);
            this.downPanel.Name = "downPanel";
            this.downPanel.Size = new System.Drawing.Size(1032, 56);
            this.downPanel.TabIndex = 19;
            // 
            // timerLabel
            // 
            this.timerLabel.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.timerLabel.ForeColor = System.Drawing.SystemColors.Control;
            this.timerLabel.Location = new System.Drawing.Point(24, 8);
            this.timerLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.timerLabel.Name = "timerLabel";
            this.timerLabel.Size = new System.Drawing.Size(1008, 39);
            this.timerLabel.TabIndex = 41;
            this.timerLabel.Text = "18 дней 8 часов и 17 минут до старта марафона!";
            this.timerLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1032, 588);
            this.Controls.Add(this.downPanel);
            this.Controls.Add(this.bmrButton);
            this.Controls.Add(this.bmiButton);
            this.Controls.Add(this.durationButton);
            this.Controls.Add(this.marathonButton);
            this.Controls.Add(this.infoLabel);
            this.Controls.Add(this.upPanel);
            this.Name = "Form1";
            this.Text = "Form1";
            this.upPanel.ResumeLayout(false);
            this.upPanel.PerformLayout();
            this.downPanel.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel upPanel;
        private System.Windows.Forms.Label headerLabel;
        private System.Windows.Forms.Label infoLabel;
        private System.Windows.Forms.Button marathonButton;
        private System.Windows.Forms.Button durationButton;
        private System.Windows.Forms.Button bmrButton;
        private System.Windows.Forms.Button bmiButton;
        private System.Windows.Forms.Panel downPanel;
        private System.Windows.Forms.Label timerLabel;
    }
}

