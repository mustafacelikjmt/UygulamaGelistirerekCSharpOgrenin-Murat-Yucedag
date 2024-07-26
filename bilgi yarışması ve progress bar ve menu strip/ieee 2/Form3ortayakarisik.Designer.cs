namespace ieee_2
{
    partial class Form3ortayakarisik
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
            this.components = new System.ComponentModel.Container();
            this.button1 = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.timer3 = new System.Windows.Forms.Timer(this.components);
            this.timer4 = new System.Windows.Forms.Timer(this.components);
            this.timer5 = new System.Windows.Forms.Timer(this.components);
            this.progressBar2 = new System.Windows.Forms.ProgressBar();
            this.progressBar3 = new System.Windows.Forms.ProgressBar();
            this.yukle = new System.Windows.Forms.Label();
            this.indir = new System.Windows.Forms.Label();
            this.tamamla = new System.Windows.Forms.Label();
            this.progressBar4 = new System.Windows.Forms.ProgressBar();
            this.progressBar5 = new System.Windows.Forms.ProgressBar();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(234, 188);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(94, 29);
            this.button1.TabIndex = 0;
            this.button1.Text = "timer";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 20;
            this.listBox1.Location = new System.Drawing.Point(35, 47);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(150, 104);
            this.listBox1.TabIndex = 1;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(339, 73);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "label1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(368, 188);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(17, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "0";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(446, 188);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(17, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "0";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(534, 188);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(17, 20);
            this.label4.TabIndex = 5;
            this.label4.Text = "0";
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(368, 136);
            this.progressBar1.Maximum = 60;
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(216, 29);
            this.progressBar1.TabIndex = 6;
            // 
            // timer2
            // 
            this.timer2.Interval = 10;
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // timer3
            // 
            this.timer3.Interval = 10;
            this.timer3.Tick += new System.EventHandler(this.timer3_Tick);
            // 
            // timer4
            // 
            this.timer4.Interval = 10;
            this.timer4.Tick += new System.EventHandler(this.timer4_Tick);
            // 
            // timer5
            // 
            this.timer5.Interval = 40;
            this.timer5.Tick += new System.EventHandler(this.timer5_Tick);
            // 
            // progressBar2
            // 
            this.progressBar2.Location = new System.Drawing.Point(234, 243);
            this.progressBar2.Name = "progressBar2";
            this.progressBar2.Size = new System.Drawing.Size(216, 29);
            this.progressBar2.TabIndex = 7;
            // 
            // progressBar3
            // 
            this.progressBar3.Location = new System.Drawing.Point(234, 298);
            this.progressBar3.Name = "progressBar3";
            this.progressBar3.Size = new System.Drawing.Size(216, 29);
            this.progressBar3.TabIndex = 8;
            // 
            // yukle
            // 
            this.yukle.AutoSize = true;
            this.yukle.Location = new System.Drawing.Point(234, 275);
            this.yukle.Name = "yukle";
            this.yukle.Size = new System.Drawing.Size(76, 20);
            this.yukle.TabIndex = 9;
            this.yukle.Text = "yükleniyor";
            // 
            // indir
            // 
            this.indir.AutoSize = true;
            this.indir.Location = new System.Drawing.Point(234, 220);
            this.indir.Name = "indir";
            this.indir.Size = new System.Drawing.Size(72, 20);
            this.indir.TabIndex = 10;
            this.indir.Text = "indiriliyor";
            // 
            // tamamla
            // 
            this.tamamla.AutoSize = true;
            this.tamamla.Location = new System.Drawing.Point(234, 330);
            this.tamamla.Name = "tamamla";
            this.tamamla.Size = new System.Drawing.Size(101, 20);
            this.tamamla.TabIndex = 11;
            this.tamamla.Text = "tamamlanıyor";
            // 
            // progressBar4
            // 
            this.progressBar4.Location = new System.Drawing.Point(234, 353);
            this.progressBar4.Name = "progressBar4";
            this.progressBar4.Size = new System.Drawing.Size(216, 29);
            this.progressBar4.TabIndex = 12;
            // 
            // progressBar5
            // 
            this.progressBar5.Location = new System.Drawing.Point(507, 298);
            this.progressBar5.Name = "progressBar5";
            this.progressBar5.Size = new System.Drawing.Size(216, 29);
            this.progressBar5.TabIndex = 13;
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.progressBar5);
            this.Controls.Add(this.progressBar4);
            this.Controls.Add(this.tamamla);
            this.Controls.Add(this.indir);
            this.Controls.Add(this.yukle);
            this.Controls.Add(this.progressBar3);
            this.Controls.Add(this.progressBar2);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.button1);
            this.Name = "Form3";
            this.Text = "Form3";
            this.Load += new System.EventHandler(this.Form3_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button button1;
        private ListBox listBox1;
        private System.Windows.Forms.Timer timer1;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private ProgressBar progressBar1;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.Timer timer3;
        private System.Windows.Forms.Timer timer4;
        private System.Windows.Forms.Timer timer5;
        private ProgressBar progressBar2;
        private ProgressBar progressBar3;
        private Label yukle;
        private Label indir;
        private Label tamamla;
        private ProgressBar progressBar4;
        private ProgressBar progressBar5;
    }
}