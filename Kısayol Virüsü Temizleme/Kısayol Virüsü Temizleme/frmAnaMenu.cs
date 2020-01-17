using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Diagnostics;
namespace Kısayol_Virüsü_Temizleme
{
    public partial class frmAnaMenu : Form
    {
        public frmAnaMenu()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string[] suruculer = System.IO.Directory.GetLogicalDrives();
            for(int i = 0; i < suruculer.Length; i++) {
                comboSurucuListele.Items.Add(suruculer[i]);
            }

        }
        string aktar;
        private void comboSurucuListele_SelectedIndexChanged(object sender, EventArgs e)
        {
            string sec = comboSurucuListele.SelectedItem.ToString();
        aktar    = sec.Split(':').First();
            txtSecilenSurucu.Text = "seçtiğiniz sürücü " + aktar + " dir.";
        }

        private void btnBaslat_Click(object sender, EventArgs e)
        {

            if(comboSurucuListele.SelectedIndex == -1) {
                MessageBox.Show("Sürücü seçilmedi!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else {
                DialogResult dialog = MessageBox.Show("Seçilen Sürücü Cmd ile tarama işlemi yapılacaktır. Onaylıyor musunuz?", "Bilgilendirme", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                listBox1.Items.Add("Seçilen sürücü \n " + aktar);
                if (dialog == DialogResult.Yes)
                {
                    System.Diagnostics.Process process = new System.Diagnostics.Process();
                    process.StartInfo = new System.Diagnostics.ProcessStartInfo();

                    process.StartInfo.CreateNoWindow = true;
                    process.StartInfo.WindowStyle = System.Diagnostics.ProcessWindowStyle.Normal;
                    process.StartInfo.FileName = "cmd.exe";
                    listBox1.Items.Add("cmd.exe açıldı. \n");
                    process.StartInfo.Arguments = "/c " + aktar + ":";
                    process.StartInfo.Arguments = "/c attrib - h - r - s / s / d " + aktar + ":/*.*";
                    process.Start();
                    listBox1.Items.Add("Temizleme işlemi başlandı. \n");
                    lblsonuc.BackColor = Color.Green;
                    lblsonuc.ForeColor = Color.White;
                    lblsonuc.Text = "İşlem tamamlandı \n";
                    listBox1.Items.Add("Temizleme işlemi bitti. \n");
                }

            

            }

        }

        private void menuYardim_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Bilgisayarımdaki kısayol virüsü olan sürücünün harf yolunu bulun ve programdan sürücüyü seçin. // Yapım: Sefa Dönmez");

        }
    }
}
