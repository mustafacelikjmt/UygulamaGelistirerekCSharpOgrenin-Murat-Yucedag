namespace Personel_kayıt_uygulaması
{
    partial class Form1main
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1main));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label7 = new System.Windows.Forms.Label();
            this.comboBoxsehir = new System.Windows.Forms.ComboBox();
            this.maskedTextBoxmaas = new System.Windows.Forms.MaskedTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.radioButtonbekar = new System.Windows.Forms.RadioButton();
            this.radioButtonevli = new System.Windows.Forms.RadioButton();
            this.textBoxmeslek = new System.Windows.Forms.TextBox();
            this.textBoxsoyad = new System.Windows.Forms.TextBox();
            this.textBoxad = new System.Windows.Forms.TextBox();
            this.textBoxid = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.labeltest = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.buttongrafikler = new System.Windows.Forms.Button();
            this.buttonistatistik = new System.Windows.Forms.Button();
            this.buttontemizle = new System.Windows.Forms.Button();
            this.buttonguncelle = new System.Windows.Forms.Button();
            this.buttonsil = new System.Windows.Forms.Button();
            this.buttonkaydet = new System.Windows.Forms.Button();
            this.buttonlistele = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.personelidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.perAdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.perSoyadDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.perŞehirDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.perMaasDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.perDurumDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.perMeslekDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.perTableBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.personelVeriTabaniDataSet = new Personel_kayıt_uygulaması.PersonelVeriTabaniDataSet();
            this.per_TableTableAdapter = new Personel_kayıt_uygulaması.PersonelVeriTabaniDataSetTableAdapters.Per_TableTableAdapter();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.perTableBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.personelVeriTabaniDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.comboBoxsehir);
            this.groupBox1.Controls.Add(this.maskedTextBoxmaas);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.radioButtonbekar);
            this.groupBox1.Controls.Add(this.radioButtonevli);
            this.groupBox1.Controls.Add(this.textBoxmeslek);
            this.groupBox1.Controls.Add(this.textBoxsoyad);
            this.groupBox1.Controls.Add(this.textBoxad);
            this.groupBox1.Controls.Add(this.textBoxid);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(15, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(338, 306);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Personel Kayıt";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(58, 226);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(47, 15);
            this.label7.TabIndex = 14;
            this.label7.Text = "Meslek";
            // 
            // comboBoxsehir
            // 
            this.comboBoxsehir.FormattingEnabled = true;
            this.comboBoxsehir.Location = new System.Drawing.Point(121, 133);
            this.comboBoxsehir.Name = "comboBoxsehir";
            this.comboBoxsehir.Size = new System.Drawing.Size(133, 23);
            this.comboBoxsehir.TabIndex = 4;
            // 
            // maskedTextBoxmaas
            // 
            this.maskedTextBoxmaas.Location = new System.Drawing.Point(121, 165);
            this.maskedTextBoxmaas.Mask = "00000";
            this.maskedTextBoxmaas.Name = "maskedTextBoxmaas";
            this.maskedTextBoxmaas.Size = new System.Drawing.Size(133, 21);
            this.maskedTextBoxmaas.TabIndex = 5;
            this.maskedTextBoxmaas.ValidatingType = typeof(int);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(69, 168);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(38, 15);
            this.label5.TabIndex = 13;
            this.label5.Text = "Maaş";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(61, 197);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(45, 15);
            this.label6.TabIndex = 12;
            this.label6.Text = "Durum";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(60, 106);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 15);
            this.label3.TabIndex = 11;
            this.label3.Text = "Soyad:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(72, 136);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(36, 15);
            this.label4.TabIndex = 10;
            this.label4.Text = "Şehir";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(85, 76);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(24, 15);
            this.label2.TabIndex = 9;
            this.label2.Text = "Ad:";
            // 
            // radioButtonbekar
            // 
            this.radioButtonbekar.AutoSize = true;
            this.radioButtonbekar.Location = new System.Drawing.Point(179, 195);
            this.radioButtonbekar.Name = "radioButtonbekar";
            this.radioButtonbekar.Size = new System.Drawing.Size(57, 19);
            this.radioButtonbekar.TabIndex = 8;
            this.radioButtonbekar.TabStop = true;
            this.radioButtonbekar.Text = "Bekar";
            this.radioButtonbekar.UseVisualStyleBackColor = true;
            this.radioButtonbekar.CheckedChanged += new System.EventHandler(this.radioButtonbekar_CheckedChanged);
            // 
            // radioButtonevli
            // 
            this.radioButtonevli.AutoSize = true;
            this.radioButtonevli.Location = new System.Drawing.Point(121, 196);
            this.radioButtonevli.Name = "radioButtonevli";
            this.radioButtonevli.Size = new System.Drawing.Size(44, 19);
            this.radioButtonevli.TabIndex = 7;
            this.radioButtonevli.TabStop = true;
            this.radioButtonevli.Text = "Evli";
            this.radioButtonevli.UseVisualStyleBackColor = true;
            this.radioButtonevli.CheckedChanged += new System.EventHandler(this.radioButtonevli_CheckedChanged);
            // 
            // textBoxmeslek
            // 
            this.textBoxmeslek.Location = new System.Drawing.Point(121, 223);
            this.textBoxmeslek.Name = "textBoxmeslek";
            this.textBoxmeslek.Size = new System.Drawing.Size(133, 21);
            this.textBoxmeslek.TabIndex = 6;
            // 
            // textBoxsoyad
            // 
            this.textBoxsoyad.Location = new System.Drawing.Point(121, 103);
            this.textBoxsoyad.Name = "textBoxsoyad";
            this.textBoxsoyad.Size = new System.Drawing.Size(133, 21);
            this.textBoxsoyad.TabIndex = 3;
            // 
            // textBoxad
            // 
            this.textBoxad.Location = new System.Drawing.Point(121, 73);
            this.textBoxad.Name = "textBoxad";
            this.textBoxad.Size = new System.Drawing.Size(133, 21);
            this.textBoxad.TabIndex = 2;
            // 
            // textBoxid
            // 
            this.textBoxid.Location = new System.Drawing.Point(121, 43);
            this.textBoxid.Name = "textBoxid";
            this.textBoxid.Size = new System.Drawing.Size(133, 21);
            this.textBoxid.TabIndex = 1;
            this.textBoxid.TextChanged += new System.EventHandler(this.textBoxid_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(91, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(20, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "İd:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.labeltest);
            this.groupBox2.Controls.Add(this.button1);
            this.groupBox2.Controls.Add(this.pictureBox1);
            this.groupBox2.Controls.Add(this.buttongrafikler);
            this.groupBox2.Controls.Add(this.buttonistatistik);
            this.groupBox2.Controls.Add(this.buttontemizle);
            this.groupBox2.Controls.Add(this.buttonguncelle);
            this.groupBox2.Controls.Add(this.buttonsil);
            this.groupBox2.Controls.Add(this.buttonkaydet);
            this.groupBox2.Controls.Add(this.buttonlistele);
            this.groupBox2.Location = new System.Drawing.Point(359, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(586, 306);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "İşlemler";
            // 
            // labeltest
            // 
            this.labeltest.AutoSize = true;
            this.labeltest.Location = new System.Drawing.Point(271, 251);
            this.labeltest.Name = "labeltest";
            this.labeltest.Size = new System.Drawing.Size(14, 15);
            this.labeltest.TabIndex = 8;
            this.labeltest.Text = "0";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(338, 231);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(242, 45);
            this.button1.TabIndex = 7;
            this.button1.Text = "Raporlama(arızalı)";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(338, 23);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(242, 202);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // buttongrafikler
            // 
            this.buttongrafikler.Location = new System.Drawing.Point(77, 245);
            this.buttongrafikler.Name = "buttongrafikler";
            this.buttongrafikler.Size = new System.Drawing.Size(177, 31);
            this.buttongrafikler.TabIndex = 6;
            this.buttongrafikler.Text = "Grafikler";
            this.buttongrafikler.UseVisualStyleBackColor = true;
            this.buttongrafikler.Click += new System.EventHandler(this.buttongrafikler_Click);
            // 
            // buttonistatistik
            // 
            this.buttonistatistik.Location = new System.Drawing.Point(77, 208);
            this.buttonistatistik.Name = "buttonistatistik";
            this.buttonistatistik.Size = new System.Drawing.Size(177, 31);
            this.buttonistatistik.TabIndex = 5;
            this.buttonistatistik.Text = "İstatistik";
            this.buttonistatistik.UseVisualStyleBackColor = true;
            this.buttonistatistik.Click += new System.EventHandler(this.buttonistatistik_Click);
            // 
            // buttontemizle
            // 
            this.buttontemizle.Location = new System.Drawing.Point(77, 171);
            this.buttontemizle.Name = "buttontemizle";
            this.buttontemizle.Size = new System.Drawing.Size(177, 31);
            this.buttontemizle.TabIndex = 4;
            this.buttontemizle.Text = "Temizle";
            this.buttontemizle.UseVisualStyleBackColor = true;
            this.buttontemizle.Click += new System.EventHandler(this.buttontemizle_Click);
            // 
            // buttonguncelle
            // 
            this.buttonguncelle.Location = new System.Drawing.Point(77, 134);
            this.buttonguncelle.Name = "buttonguncelle";
            this.buttonguncelle.Size = new System.Drawing.Size(177, 31);
            this.buttonguncelle.TabIndex = 3;
            this.buttonguncelle.Text = "Güncelle";
            this.buttonguncelle.UseVisualStyleBackColor = true;
            this.buttonguncelle.Click += new System.EventHandler(this.buttonguncelle_Click);
            // 
            // buttonsil
            // 
            this.buttonsil.Location = new System.Drawing.Point(77, 97);
            this.buttonsil.Name = "buttonsil";
            this.buttonsil.Size = new System.Drawing.Size(177, 31);
            this.buttonsil.TabIndex = 2;
            this.buttonsil.Text = "Sil";
            this.buttonsil.UseVisualStyleBackColor = true;
            this.buttonsil.Click += new System.EventHandler(this.buttonsil_Click);
            // 
            // buttonkaydet
            // 
            this.buttonkaydet.Location = new System.Drawing.Point(77, 60);
            this.buttonkaydet.Name = "buttonkaydet";
            this.buttonkaydet.Size = new System.Drawing.Size(177, 31);
            this.buttonkaydet.TabIndex = 1;
            this.buttonkaydet.Text = "Kaydet";
            this.buttonkaydet.UseVisualStyleBackColor = true;
            this.buttonkaydet.Click += new System.EventHandler(this.buttonkaydet_Click);
            // 
            // buttonlistele
            // 
            this.buttonlistele.Location = new System.Drawing.Point(77, 23);
            this.buttonlistele.Name = "buttonlistele";
            this.buttonlistele.Size = new System.Drawing.Size(177, 31);
            this.buttonlistele.TabIndex = 0;
            this.buttonlistele.Text = "Listele";
            this.buttonlistele.UseVisualStyleBackColor = true;
            this.buttonlistele.Click += new System.EventHandler(this.buttonlistele_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.dataGridView1);
            this.groupBox3.Location = new System.Drawing.Point(10, 324);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(935, 192);
            this.groupBox3.TabIndex = 1;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Kayıtlar";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.personelidDataGridViewTextBoxColumn,
            this.perAdDataGridViewTextBoxColumn,
            this.perSoyadDataGridViewTextBoxColumn,
            this.perŞehirDataGridViewTextBoxColumn,
            this.perMaasDataGridViewTextBoxColumn,
            this.perDurumDataGridViewCheckBoxColumn,
            this.perMeslekDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.perTableBindingSource;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(3, 17);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(929, 172);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellDoubleClick);
            // 
            // personelidDataGridViewTextBoxColumn
            // 
            this.personelidDataGridViewTextBoxColumn.DataPropertyName = "Personelid";
            this.personelidDataGridViewTextBoxColumn.HeaderText = "Personelid";
            this.personelidDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.personelidDataGridViewTextBoxColumn.Name = "personelidDataGridViewTextBoxColumn";
            this.personelidDataGridViewTextBoxColumn.ReadOnly = true;
            this.personelidDataGridViewTextBoxColumn.Width = 125;
            // 
            // perAdDataGridViewTextBoxColumn
            // 
            this.perAdDataGridViewTextBoxColumn.DataPropertyName = "PerAd";
            this.perAdDataGridViewTextBoxColumn.HeaderText = "PerAd";
            this.perAdDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.perAdDataGridViewTextBoxColumn.Name = "perAdDataGridViewTextBoxColumn";
            this.perAdDataGridViewTextBoxColumn.Width = 125;
            // 
            // perSoyadDataGridViewTextBoxColumn
            // 
            this.perSoyadDataGridViewTextBoxColumn.DataPropertyName = "PerSoyad";
            this.perSoyadDataGridViewTextBoxColumn.HeaderText = "PerSoyad";
            this.perSoyadDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.perSoyadDataGridViewTextBoxColumn.Name = "perSoyadDataGridViewTextBoxColumn";
            this.perSoyadDataGridViewTextBoxColumn.Width = 125;
            // 
            // perŞehirDataGridViewTextBoxColumn
            // 
            this.perŞehirDataGridViewTextBoxColumn.DataPropertyName = "PerŞehir";
            this.perŞehirDataGridViewTextBoxColumn.HeaderText = "PerŞehir";
            this.perŞehirDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.perŞehirDataGridViewTextBoxColumn.Name = "perŞehirDataGridViewTextBoxColumn";
            this.perŞehirDataGridViewTextBoxColumn.Width = 125;
            // 
            // perMaasDataGridViewTextBoxColumn
            // 
            this.perMaasDataGridViewTextBoxColumn.DataPropertyName = "PerMaas";
            this.perMaasDataGridViewTextBoxColumn.HeaderText = "PerMaas";
            this.perMaasDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.perMaasDataGridViewTextBoxColumn.Name = "perMaasDataGridViewTextBoxColumn";
            this.perMaasDataGridViewTextBoxColumn.Width = 125;
            // 
            // perDurumDataGridViewCheckBoxColumn
            // 
            this.perDurumDataGridViewCheckBoxColumn.DataPropertyName = "PerDurum";
            this.perDurumDataGridViewCheckBoxColumn.HeaderText = "PerDurum";
            this.perDurumDataGridViewCheckBoxColumn.MinimumWidth = 6;
            this.perDurumDataGridViewCheckBoxColumn.Name = "perDurumDataGridViewCheckBoxColumn";
            this.perDurumDataGridViewCheckBoxColumn.Width = 125;
            // 
            // perMeslekDataGridViewTextBoxColumn
            // 
            this.perMeslekDataGridViewTextBoxColumn.DataPropertyName = "PerMeslek";
            this.perMeslekDataGridViewTextBoxColumn.HeaderText = "PerMeslek";
            this.perMeslekDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.perMeslekDataGridViewTextBoxColumn.Name = "perMeslekDataGridViewTextBoxColumn";
            this.perMeslekDataGridViewTextBoxColumn.Width = 125;
            // 
            // perTableBindingSource
            // 
            this.perTableBindingSource.DataMember = "Per_Table";
            this.perTableBindingSource.DataSource = this.personelVeriTabaniDataSet;
            // 
            // personelVeriTabaniDataSet
            // 
            this.personelVeriTabaniDataSet.DataSetName = "PersonelVeriTabaniDataSet";
            this.personelVeriTabaniDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // per_TableTableAdapter
            // 
            this.per_TableTableAdapter.ClearBeforeFill = true;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form1main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(957, 528);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Name = "Form1main";
            this.Text = "Personel Kayıt";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.perTableBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.personelVeriTabaniDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.RadioButton radioButtonbekar;
        private System.Windows.Forms.RadioButton radioButtonevli;
        private System.Windows.Forms.ComboBox comboBoxsehir;
        private System.Windows.Forms.MaskedTextBox maskedTextBoxmaas;
        private System.Windows.Forms.TextBox textBoxmeslek;
        private System.Windows.Forms.TextBox textBoxsoyad;
        private System.Windows.Forms.TextBox textBoxad;
        private System.Windows.Forms.TextBox textBoxid;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private PersonelVeriTabaniDataSet personelVeriTabaniDataSet;
        private System.Windows.Forms.BindingSource perTableBindingSource;
        private PersonelVeriTabaniDataSetTableAdapters.Per_TableTableAdapter per_TableTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn personelidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn perAdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn perSoyadDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn perŞehirDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn perMaasDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn perDurumDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn perMeslekDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button buttongrafikler;
        private System.Windows.Forms.Button buttonistatistik;
        private System.Windows.Forms.Button buttontemizle;
        private System.Windows.Forms.Button buttonguncelle;
        private System.Windows.Forms.Button buttonsil;
        private System.Windows.Forms.Button buttonkaydet;
        private System.Windows.Forms.Button buttonlistele;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label labeltest;
        private System.Windows.Forms.Timer timer1;
    }
}

