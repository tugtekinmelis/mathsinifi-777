using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace math_sınıfı_777
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnHesapla_Click(object sender, EventArgs e)
        {
            double sayi = Convert.ToSingle(txtSayi.Text); // sayısal olarak texti çevirdik.

            // islemler.

            double sayiMutlak = Math.Abs(sayi);
            double sayiUs = Math.Pow(sayi, 2); // txt içindeki sayının karesi (2. kuvveti)
            double sayiKarekok = Math.Sqrt(sayi);
            double sayiYukariYuvarla = Math.Ceiling(sayi);
            double sayiAsagiYuvarla = Math.Floor(sayi);
            double sayiYuvarlama = Math.Round(sayi);
            // Round , Floor , Ceiling


            // sonucları yazdır.
            lblMutlak.Text = "Sayının mutlak değeri" + sayiMutlak.ToString();
            lblUs.Text = "Sayının kuvveti" + sayiUs.ToString();
            lblKarekok.Text = "Sayının karekökü" + sayiKarekok.ToString();
            lblYukari.Text = "Sayının yukarı yuvarlandırılması" + sayiYukariYuvarla.ToString();
            lblAsagi.Text = "Sayının aşağı yuvarlandırılması" + sayiAsagiYuvarla.ToString();
            lblYuvarla.Text = "Sayının yuvarlaması" + sayiYuvarlama.ToString();
        }
    }
}
