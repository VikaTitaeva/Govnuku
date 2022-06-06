
namespace PR_21
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
            this.fon_pctbx = new System.Windows.Forms.PictureBox();
            this.vid_lbl = new System.Windows.Forms.Label();
            this.forma_lbl = new System.Windows.Forms.Label();
            this.info_lbl = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.fon_pctbx)).BeginInit();
            this.SuspendLayout();
            // 
            // fon_pctbx
            // 
            this.fon_pctbx.Location = new System.Drawing.Point(17, 12);
            this.fon_pctbx.Name = "fon_pctbx";
            this.fon_pctbx.Size = new System.Drawing.Size(705, 441);
            this.fon_pctbx.TabIndex = 0;
            this.fon_pctbx.TabStop = false;
            this.fon_pctbx.Click += new System.EventHandler(this.fon_pctbx_Click);
            this.fon_pctbx.Paint += new System.Windows.Forms.PaintEventHandler(this.fon_pctbx_Click);
            this.fon_pctbx.MouseDown += new System.Windows.Forms.MouseEventHandler(this.fon_pctbx_MouseDown);
            this.fon_pctbx.MouseMove += new System.Windows.Forms.MouseEventHandler(this.fon_pctrbx_MouseMove);
            this.fon_pctbx.MouseUp += new System.Windows.Forms.MouseEventHandler(this.fon_pctbx_MouseUp);
            // 
            // vid_lbl
            // 
            this.vid_lbl.AutoSize = true;
            this.vid_lbl.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.vid_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.vid_lbl.Location = new System.Drawing.Point(77, 359);
            this.vid_lbl.MinimumSize = new System.Drawing.Size(100, 50);
            this.vid_lbl.Name = "vid_lbl";
            this.vid_lbl.Size = new System.Drawing.Size(100, 50);
            this.vid_lbl.TabIndex = 1;
            this.vid_lbl.Text = "ВИД";
            this.vid_lbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.vid_lbl.Click += new System.EventHandler(this.vid_lbl_Click);
            this.vid_lbl.MouseDown += new System.Windows.Forms.MouseEventHandler(this.fon_pctbx_MouseDown);
            this.vid_lbl.MouseMove += new System.Windows.Forms.MouseEventHandler(this.fon_pctbx_MouseUp);
            this.vid_lbl.MouseUp += new System.Windows.Forms.MouseEventHandler(this.fon_pctbx_MouseUp);
            // 
            // forma_lbl
            // 
            this.forma_lbl.AutoSize = true;
            this.forma_lbl.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.forma_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.forma_lbl.Location = new System.Drawing.Point(297, 359);
            this.forma_lbl.MinimumSize = new System.Drawing.Size(100, 50);
            this.forma_lbl.Name = "forma_lbl";
            this.forma_lbl.Size = new System.Drawing.Size(108, 50);
            this.forma_lbl.TabIndex = 2;
            this.forma_lbl.Text = "ФОРМА";
            this.forma_lbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.forma_lbl.MouseDown += new System.Windows.Forms.MouseEventHandler(this.fon_pctbx_MouseDown);
            this.forma_lbl.MouseMove += new System.Windows.Forms.MouseEventHandler(this.fon_pctrbx_MouseMove);
            this.forma_lbl.MouseUp += new System.Windows.Forms.MouseEventHandler(this.fon_pctbx_MouseUp);
            // 
            // info_lbl
            // 
            this.info_lbl.AutoSize = true;
            this.info_lbl.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.info_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.info_lbl.Location = new System.Drawing.Point(522, 359);
            this.info_lbl.MinimumSize = new System.Drawing.Size(100, 50);
            this.info_lbl.Name = "info_lbl";
            this.info_lbl.Size = new System.Drawing.Size(100, 50);
            this.info_lbl.TabIndex = 3;
            this.info_lbl.Text = "ИНФА";
            this.info_lbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.info_lbl.Click += new System.EventHandler(this.info_lbl_Click);
            this.info_lbl.MouseDown += new System.Windows.Forms.MouseEventHandler(this.fon_pctbx_MouseDown);
            this.info_lbl.MouseMove += new System.Windows.Forms.MouseEventHandler(this.fon_pctrbx_MouseMove);
            this.info_lbl.MouseUp += new System.Windows.Forms.MouseEventHandler(this.fon_pctbx_MouseUp);
            // 
            // Form1
            // 
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(734, 497);
            this.Controls.Add(this.info_lbl);
            this.Controls.Add(this.forma_lbl);
            this.Controls.Add(this.vid_lbl);
            this.Controls.Add(this.fon_pctbx);
            this.Name = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.fon_pctbx)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion


        private System.Windows.Forms.PictureBox fon_pctbx;
        private System.Windows.Forms.Label vid_lbl;
        private System.Windows.Forms.Label forma_lbl;
        private System.Windows.Forms.Label info_lbl;
    }
}

