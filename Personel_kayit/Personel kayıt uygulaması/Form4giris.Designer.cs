namespace Personel_kayıt_uygulaması
{
    partial class Form4giris
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
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxkullaniciad = new System.Windows.Forms.TextBox();
            this.textBoxsifre = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.buttongiris = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 79);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(151, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Kullanıcı Adı:";
            // 
            // textBoxkullaniciad
            // 
            this.textBoxkullaniciad.Location = new System.Drawing.Point(167, 75);
            this.textBoxkullaniciad.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.textBoxkullaniciad.Name = "textBoxkullaniciad";
            this.textBoxkullaniciad.Size = new System.Drawing.Size(116, 34);
            this.textBoxkullaniciad.TabIndex = 1;
            // 
            // textBoxsifre
            // 
            this.textBoxsifre.Location = new System.Drawing.Point(167, 130);
            this.textBoxsifre.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.textBoxsifre.Name = "textBoxsifre";
            this.textBoxsifre.Size = new System.Drawing.Size(116, 34);
            this.textBoxsifre.TabIndex = 3;
            this.textBoxsifre.UseSystemPasswordChar = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(92, 133);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 29);
            this.label2.TabIndex = 2;
            this.label2.Text = "Şifre:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(144, 10);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(166, 29);
            this.label3.TabIndex = 4;
            this.label3.Text = "Personel Giriş";
            // 
            // buttongiris
            // 
            this.buttongiris.Location = new System.Drawing.Point(98, 172);
            this.buttongiris.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.buttongiris.Name = "buttongiris";
            this.buttongiris.Size = new System.Drawing.Size(130, 59);
            this.buttongiris.TabIndex = 5;
            this.buttongiris.Text = "Giriş";
            this.buttongiris.UseVisualStyleBackColor = true;
            this.buttongiris.Click += new System.EventHandler(this.buttongiris_Click);
            // 
            // Form4giris
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(460, 340);
            this.Controls.Add(this.buttongiris);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBoxsifre);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxkullaniciad);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.Name = "Form4giris";
            this.Text = "Form4giris";
            this.Load += new System.EventHandler(this.Form4giris_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxkullaniciad;
        private System.Windows.Forms.TextBox textBoxsifre;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button buttongiris;
    }
}