﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Personel_kayıt_uygulaması
{
    public partial class Form5rapor : Form
    {
        SqlConnection baglanti = new SqlConnection("Data Source=VICTUS-16-JMT\\SQLEXPRESS;Initial Catalog=PersonelVeriTabani;Integrated Security=True");
        public Form5rapor()
        {
            InitializeComponent();
        }

        private void Form5rapor_Load(object sender, EventArgs e)
        {

            
        }

        private void reportViewer1_Load(object sender, EventArgs e)
        {

        }
    }
}
