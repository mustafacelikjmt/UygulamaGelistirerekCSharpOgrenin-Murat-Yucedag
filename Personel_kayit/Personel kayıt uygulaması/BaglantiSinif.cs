using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Personel_kayıt_uygulaması
{
    class BaglantiSinif
    {
        public string Adres = System.IO.File.ReadAllText(@"C:\Test.txt");
        public static string Adress = System.IO.File.ReadAllText(@"C:\Test.txt");
        public static SqlConnection bagla = new SqlConnection(Adress);
        
    }
}
