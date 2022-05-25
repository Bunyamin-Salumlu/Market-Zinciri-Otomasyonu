using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Market_Zinciri_Otomasyonu
{
    public partial class FrmGiris : Form
    {
        public FrmGiris()
        {
            InitializeComponent();
        }

        private void btnGiris_Click(object sender, EventArgs e)
        {
            if (txtKullanici.Text == "Patron" && txtSifre.Text == "1234")
            {
                MessageBox.Show("Patron Girişi Yapılıyor...");
                frmIslemForm islem = new frmIslemForm();
                islem.PatronGirisi = true;
                islem.Show();
                this.Hide();
            }
            else if(txtKullanici.Text == "Müdür" && txtSifre.Text == "1234")
            {
                MessageBox.Show("Müdür Girişi Yapılıyor...");
                frmIslemForm islem = new frmIslemForm();
                islem.MudurGirisi = true;
                islem.Show();
                this.Hide();
            }
            else if(txtKullanici.Text == "MüdürYar" && txtSifre.Text == "1234")
            {
                MessageBox.Show("Müdür Yardımcısı Girişi Yapılıyor...");
                frmIslemForm islem = new frmIslemForm();
                islem.MudurYarGirisi = true;
                islem.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Kullanıcı Adını Veya Şifreyi Yanlış Girdiniz.");
            }
        }
    }
}
