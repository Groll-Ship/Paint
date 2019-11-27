namespace Paint
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.clear = new System.Windows.Forms.Button();
            this.sizeBrash = new System.Windows.Forms.TrackBar();
            this.color = new System.Windows.Forms.Button();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.менюToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.Pen = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sizeBrash)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Cross;
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Location = new System.Drawing.Point(0, 24);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(933, 490);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            this.pictureBox1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseDown_1);
            this.pictureBox1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseMove_1);
            this.pictureBox1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseUp_1);
            // 
            // clear
            // 
            this.clear.BackColor = System.Drawing.SystemColors.Control;
            this.clear.Cursor = System.Windows.Forms.Cursors.Hand;
            this.clear.FlatAppearance.BorderColor = System.Drawing.Color.Teal;
            this.clear.FlatAppearance.BorderSize = 0;
            this.clear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.clear.ForeColor = System.Drawing.SystemColors.ControlText;
            this.clear.Image = ((System.Drawing.Image)(resources.GetObject("clear.Image")));
            this.clear.Location = new System.Drawing.Point(149, 4);
            this.clear.Name = "clear";
            this.clear.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.clear.Size = new System.Drawing.Size(23, 23);
            this.clear.TabIndex = 1;
            this.clear.UseVisualStyleBackColor = false;
            this.clear.Click += new System.EventHandler(this.clear_Click);
            // 
            // sizeBrash
            // 
            this.sizeBrash.AllowDrop = true;
            this.sizeBrash.AutoSize = false;
            this.sizeBrash.Cursor = System.Windows.Forms.Cursors.Hand;
            this.sizeBrash.LargeChange = 1;
            this.sizeBrash.Location = new System.Drawing.Point(3, 45);
            this.sizeBrash.Name = "sizeBrash";
            this.sizeBrash.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.sizeBrash.Size = new System.Drawing.Size(169, 30);
            this.sizeBrash.TabIndex = 2;
            this.sizeBrash.TickStyle = System.Windows.Forms.TickStyle.TopLeft;
            this.sizeBrash.Scroll += new System.EventHandler(this.sizeBrash_Scroll);
            // 
            // color
            // 
            this.color.BackColor = System.Drawing.Color.Black;
            this.color.Cursor = System.Windows.Forms.Cursors.Hand;
            this.color.FlatAppearance.BorderSize = 0;
            this.color.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.color.Location = new System.Drawing.Point(32, 3);
            this.color.Name = "color";
            this.color.Size = new System.Drawing.Size(23, 23);
            this.color.TabIndex = 3;
            this.color.UseVisualStyleBackColor = false;
            this.color.Click += new System.EventHandler(this.color_Click);
            // 
            // colorDialog1
            // 
            this.colorDialog1.AnyColor = true;
            this.colorDialog1.FullOpen = true;
            this.colorDialog1.SolidColorOnly = true;
            // 
            // menuStrip1
            // 
            this.menuStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Visible;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.менюToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(933, 24);
            this.menuStrip1.TabIndex = 4;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // менюToolStripMenuItem
            // 
            this.менюToolStripMenuItem.Name = "менюToolStripMenuItem";
            this.менюToolStripMenuItem.Size = new System.Drawing.Size(53, 20);
            this.менюToolStripMenuItem.Text = "Меню";
            // 
            // panel1
            // 
            this.panel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 24);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(933, 88);
            this.panel1.TabIndex = 5;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Transparent;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel2.Controls.Add(this.clear);
            this.panel2.Controls.Add(this.sizeBrash);
            this.panel2.Controls.Add(this.Pen);
            this.panel2.Controls.Add(this.color);
            this.panel2.Location = new System.Drawing.Point(41, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(179, 82);
            this.panel2.TabIndex = 6;
            // 
            // Pen
            // 
            this.Pen.BackColor = System.Drawing.Color.Transparent;
            this.Pen.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Pen.FlatAppearance.BorderColor = System.Drawing.Color.LightGray;
            this.Pen.FlatAppearance.BorderSize = 0;
            this.Pen.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Pen.ForeColor = System.Drawing.Color.Transparent;
            this.Pen.Image = ((System.Drawing.Image)(resources.GetObject("Pen.Image")));
            this.Pen.Location = new System.Drawing.Point(2, 4);
            this.Pen.Name = "Pen";
            this.Pen.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Pen.Size = new System.Drawing.Size(23, 23);
            this.Pen.TabIndex = 7;
            this.Pen.UseVisualStyleBackColor = false;
            this.Pen.Click += new System.EventHandler(this.Pen_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(933, 514);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.menuStrip1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load_1);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sizeBrash)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button clear;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.Button color;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem менюToolStripMenuItem;
        private System.Windows.Forms.Panel panel1;
        public System.Windows.Forms.TrackBar sizeBrash;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button Pen;
    }
}

