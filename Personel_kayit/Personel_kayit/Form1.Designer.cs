namespace Personel_kayit
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radioButtonbekar = new System.Windows.Forms.RadioButton();
            this.radioButtonevli = new System.Windows.Forms.RadioButton();
            this.comboBoxsehir = new System.Windows.Forms.ComboBox();
            this.maskedTextBoxmaas = new System.Windows.Forms.MaskedTextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.textBoxmeslek = new System.Windows.Forms.TextBox();
            this.textBoxsoyad = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxad = new System.Windows.Forms.TextBox();
            this.textBoxid = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonlistele = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.buttongrafikler = new System.Windows.Forms.Button();
            this.buttonistatistik = new System.Windows.Forms.Button();
            this.buttontemizle = new System.Windows.Forms.Button();
            this.buttonguncelle = new System.Windows.Forms.Button();
            this.buttonsil = new System.Windows.Forms.Button();
            this.buttonkaydet = new System.Windows.Forms.Button();
            this.Kayıtlar = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.personelidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.perAdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.perSoyadDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.perŞehirDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.perMaasDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.perDurumDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.perMeslekDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.table1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.personelVeriTabaniDataSet = new Personel_kayit.PersonelVeriTabaniDataSet();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.table_1TableAdapter = new Personel_kayit.PersonelVeriTabaniDataSetTableAdapters.Table_1TableAdapter();
            this.personelVeriTabaniDataSet1 = new Personel_kayit.PersonelVeriTabaniDataSet1();
            this.perTableBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.per_TableTableAdapter = new Personel_kayit.PersonelVeriTabaniDataSet1TableAdapters.Per_TableTableAdapter();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.Kayıtlar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.table1BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.personelVeriTabaniDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.personelVeriTabaniDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.perTableBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radioButtonbekar);
            this.groupBox1.Controls.Add(this.radioButtonevli);
            this.groupBox1.Controls.Add(this.comboBoxsehir);
            this.groupBox1.Controls.Add(this.maskedTextBoxmaas);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.textBoxmeslek);
            this.groupBox1.Controls.Add(this.textBoxsoyad);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.textBoxad);
            this.groupBox1.Controls.Add(this.textBoxid);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(13, 13);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(266, 301);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Personel Kayit";
            // 
            // radioButtonbekar
            // 
            this.radioButtonbekar.AutoSize = true;
            this.radioButtonbekar.Location = new System.Drawing.Point(158, 212);
            this.radioButtonbekar.Margin = new System.Windows.Forms.Padding(4);
            this.radioButtonbekar.Name = "radioButtonbekar";
            this.radioButtonbekar.Size = new System.Drawing.Size(68, 22);
            this.radioButtonbekar.TabIndex = 14;
            this.radioButtonbekar.TabStop = true;
            this.radioButtonbekar.Text = "Bekar";
            this.radioButtonbekar.UseVisualStyleBackColor = true;
            // 
            // radioButtonevli
            // 
            this.radioButtonevli.AutoSize = true;
            this.radioButtonevli.Location = new System.Drawing.Point(95, 212);
            this.radioButtonevli.Margin = new System.Windows.Forms.Padding(4);
            this.radioButtonevli.Name = "radioButtonevli";
            this.radioButtonevli.Size = new System.Drawing.Size(52, 22);
            this.radioButtonevli.TabIndex = 13;
            this.radioButtonevli.TabStop = true;
            this.radioButtonevli.Text = "Evli";
            this.radioButtonevli.UseVisualStyleBackColor = true;
            // 
            // comboBoxsehir
            // 
            this.comboBoxsehir.FormattingEnabled = true;
            this.comboBoxsehir.Location = new System.Drawing.Point(95, 146);
            this.comboBoxsehir.Margin = new System.Windows.Forms.Padding(4);
            this.comboBoxsehir.Name = "comboBoxsehir";
            this.comboBoxsehir.Size = new System.Drawing.Size(134, 26);
            this.comboBoxsehir.TabIndex = 4;
            // 
            // maskedTextBoxmaas
            // 
            this.maskedTextBoxmaas.Location = new System.Drawing.Point(95, 180);
            this.maskedTextBoxmaas.Margin = new System.Windows.Forms.Padding(4);
            this.maskedTextBoxmaas.Mask = "00000";
            this.maskedTextBoxmaas.Name = "maskedTextBoxmaas";
            this.maskedTextBoxmaas.Size = new System.Drawing.Size(134, 24);
            this.maskedTextBoxmaas.TabIndex = 5;
            this.maskedTextBoxmaas.ValidatingType = typeof(int);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(18, 244);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(60, 18);
            this.label7.TabIndex = 10;
            this.label7.Text = "Meslek:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(23, 214);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(57, 18);
            this.label6.TabIndex = 9;
            this.label6.Text = "Durum:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(29, 184);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(49, 18);
            this.label5.TabIndex = 8;
            this.label5.Text = "Maaş:";
            // 
            // textBoxmeslek
            // 
            this.textBoxmeslek.Location = new System.Drawing.Point(95, 241);
            this.textBoxmeslek.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxmeslek.Name = "textBoxmeslek";
            this.textBoxmeslek.Size = new System.Drawing.Size(134, 24);
            this.textBoxmeslek.TabIndex = 6;
            // 
            // textBoxsoyad
            // 
            this.textBoxsoyad.Location = new System.Drawing.Point(95, 115);
            this.textBoxsoyad.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxsoyad.Name = "textBoxsoyad";
            this.textBoxsoyad.Size = new System.Drawing.Size(134, 24);
            this.textBoxsoyad.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(32, 149);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 18);
            this.label3.TabIndex = 5;
            this.label3.Text = "Şehir:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(22, 118);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 18);
            this.label4.TabIndex = 4;
            this.label4.Text = "Soyad:";
            // 
            // textBoxad
            // 
            this.textBoxad.Location = new System.Drawing.Point(95, 83);
            this.textBoxad.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxad.Name = "textBoxad";
            this.textBoxad.Size = new System.Drawing.Size(134, 24);
            this.textBoxad.TabIndex = 2;
            // 
            // textBoxid
            // 
            this.textBoxid.Location = new System.Drawing.Point(95, 52);
            this.textBoxid.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxid.Name = "textBoxid";
            this.textBoxid.Size = new System.Drawing.Size(134, 24);
            this.textBoxid.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(49, 86);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 18);
            this.label2.TabIndex = 1;
            this.label2.Text = "Ad:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(55, 55);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(23, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "İd:";
            // 
            // buttonlistele
            // 
            this.buttonlistele.Location = new System.Drawing.Point(52, 23);
            this.buttonlistele.Margin = new System.Windows.Forms.Padding(4);
            this.buttonlistele.Name = "buttonlistele";
            this.buttonlistele.Size = new System.Drawing.Size(164, 32);
            this.buttonlistele.TabIndex = 1;
            this.buttonlistele.Text = "Listele";
            this.buttonlistele.UseVisualStyleBackColor = true;
            this.buttonlistele.Click += new System.EventHandler(this.buttonlistele_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.buttongrafikler);
            this.groupBox2.Controls.Add(this.buttonistatistik);
            this.groupBox2.Controls.Add(this.buttontemizle);
            this.groupBox2.Controls.Add(this.buttonguncelle);
            this.groupBox2.Controls.Add(this.buttonsil);
            this.groupBox2.Controls.Add(this.buttonkaydet);
            this.groupBox2.Controls.Add(this.buttonlistele);
            this.groupBox2.Location = new System.Drawing.Point(287, 13);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox2.Size = new System.Drawing.Size(270, 301);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "İşlemler";
            // 
            // buttongrafikler
            // 
            this.buttongrafikler.Location = new System.Drawing.Point(52, 260);
            this.buttongrafikler.Margin = new System.Windows.Forms.Padding(4);
            this.buttongrafikler.Name = "buttongrafikler";
            this.buttongrafikler.Size = new System.Drawing.Size(164, 32);
            this.buttongrafikler.TabIndex = 7;
            this.buttongrafikler.Text = "Grafikler";
            this.buttongrafikler.UseVisualStyleBackColor = true;
            // 
            // buttonistatistik
            // 
            this.buttonistatistik.Location = new System.Drawing.Point(52, 220);
            this.buttonistatistik.Margin = new System.Windows.Forms.Padding(4);
            this.buttonistatistik.Name = "buttonistatistik";
            this.buttonistatistik.Size = new System.Drawing.Size(164, 32);
            this.buttonistatistik.TabIndex = 6;
            this.buttonistatistik.Text = "İstatistik";
            this.buttonistatistik.UseVisualStyleBackColor = true;
            // 
            // buttontemizle
            // 
            this.buttontemizle.Location = new System.Drawing.Point(52, 181);
            this.buttontemizle.Margin = new System.Windows.Forms.Padding(4);
            this.buttontemizle.Name = "buttontemizle";
            this.buttontemizle.Size = new System.Drawing.Size(164, 32);
            this.buttontemizle.TabIndex = 5;
            this.buttontemizle.Text = "Temizle";
            this.buttontemizle.UseVisualStyleBackColor = true;
            // 
            // buttonguncelle
            // 
            this.buttonguncelle.Location = new System.Drawing.Point(52, 142);
            this.buttonguncelle.Margin = new System.Windows.Forms.Padding(4);
            this.buttonguncelle.Name = "buttonguncelle";
            this.buttonguncelle.Size = new System.Drawing.Size(164, 32);
            this.buttonguncelle.TabIndex = 4;
            this.buttonguncelle.Text = "Güncelle";
            this.buttonguncelle.UseVisualStyleBackColor = true;
            // 
            // buttonsil
            // 
            this.buttonsil.Location = new System.Drawing.Point(52, 103);
            this.buttonsil.Margin = new System.Windows.Forms.Padding(4);
            this.buttonsil.Name = "buttonsil";
            this.buttonsil.Size = new System.Drawing.Size(164, 32);
            this.buttonsil.TabIndex = 3;
            this.buttonsil.Text = "Sil";
            this.buttonsil.UseVisualStyleBackColor = true;
            // 
            // buttonkaydet
            // 
            this.buttonkaydet.Location = new System.Drawing.Point(52, 63);
            this.buttonkaydet.Margin = new System.Windows.Forms.Padding(4);
            this.buttonkaydet.Name = "buttonkaydet";
            this.buttonkaydet.Size = new System.Drawing.Size(164, 32);
            this.buttonkaydet.TabIndex = 2;
            this.buttonkaydet.Text = "Kaydet";
            this.buttonkaydet.UseVisualStyleBackColor = true;
            this.buttonkaydet.Click += new System.EventHandler(this.buttonkaydet_Click);
            // 
            // Kayıtlar
            // 
            this.Kayıtlar.Controls.Add(this.dataGridView1);
            this.Kayıtlar.Location = new System.Drawing.Point(13, 322);
            this.Kayıtlar.Margin = new System.Windows.Forms.Padding(4);
            this.Kayıtlar.Name = "Kayıtlar";
            this.Kayıtlar.Padding = new System.Windows.Forms.Padding(4);
            this.Kayıtlar.Size = new System.Drawing.Size(936, 199);
            this.Kayıtlar.TabIndex = 3;
            this.Kayıtlar.TabStop = false;
            this.Kayıtlar.Text = "groupBox3";
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
            this.dataGridView1.Location = new System.Drawing.Point(4, 21);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(928, 174);
            this.dataGridView1.TabIndex = 0;
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
            // table1BindingSource
            // 
            this.table1BindingSource.DataMember = "Table_1";
            this.table1BindingSource.DataSource = this.personelVeriTabaniDataSet;
            // 
            // personelVeriTabaniDataSet
            // 
            this.personelVeriTabaniDataSet.DataSetName = "PersonelVeriTabaniDataSet";
            this.personelVeriTabaniDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(564, 18);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(385, 297);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // table_1TableAdapter
            // 
            this.table_1TableAdapter.ClearBeforeFill = true;
            // 
            // personelVeriTabaniDataSet1
            // 
            this.personelVeriTabaniDataSet1.DataSetName = "PersonelVeriTabaniDataSet1";
            this.personelVeriTabaniDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // perTableBindingSource
            // 
            this.perTableBindingSource.DataMember = "Per_Table";
            this.perTableBindingSource.DataSource = this.personelVeriTabaniDataSet1;
            // 
            // per_TableTableAdapter
            // 
            this.per_TableTableAdapter.ClearBeforeFill = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(959, 534);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.Kayıtlar);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.Kayıtlar.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.table1BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.personelVeriTabaniDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.personelVeriTabaniDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.perTableBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox textBoxmeslek;
        private System.Windows.Forms.TextBox textBoxsoyad;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxad;
        private System.Windows.Forms.TextBox textBoxid;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.RadioButton radioButtonbekar;
        private System.Windows.Forms.RadioButton radioButtonevli;
        private System.Windows.Forms.ComboBox comboBoxsehir;
        private System.Windows.Forms.MaskedTextBox maskedTextBoxmaas;
        private System.Windows.Forms.Button buttonlistele;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button buttongrafikler;
        private System.Windows.Forms.Button buttonistatistik;
        private System.Windows.Forms.Button buttontemizle;
        private System.Windows.Forms.Button buttonguncelle;
        private System.Windows.Forms.Button buttonsil;
        private System.Windows.Forms.Button buttonkaydet;
        private System.Windows.Forms.GroupBox Kayıtlar;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private PersonelVeriTabaniDataSet personelVeriTabaniDataSet;
        private System.Windows.Forms.BindingSource table1BindingSource;
        private PersonelVeriTabaniDataSetTableAdapters.Table_1TableAdapter table_1TableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn personelidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn perAdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn perSoyadDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn perŞehirDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn perMaasDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn perDurumDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn perMeslekDataGridViewTextBoxColumn;
        private PersonelVeriTabaniDataSet1 personelVeriTabaniDataSet1;
        private System.Windows.Forms.BindingSource perTableBindingSource;
        private PersonelVeriTabaniDataSet1TableAdapters.Per_TableTableAdapter per_TableTableAdapter;
    }
}

