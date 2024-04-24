using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace otopark
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Otopark otopark1;
        private void BtnOtoparkOluştur_Click(object sender, EventArgs e)
        {
            string OtoparkAdı = TxtOtoparkAdı.Text;
            int Kapasite = Int32.Parse(TxtKapasite.Text);
            otopark1= new Otopark(OtoparkAdı, Kapasite);
            BtnOtoparkOluştur.Enabled = false;
        }

        private void BtnAraçGiriş_Click(object sender, EventArgs e)
        {
            if(chkOtomobilMi.Checked)
            {
                otopark1.OtoparkGiriş(true);
                MessageBox.Show("otomobil giriş başarılı.");
            }
            else
            {
                otopark1.OtoparkGiriş(false);
                MessageBox.Show("diğer araç giriş başarılı.");
            }    
        }

        private void BtnAraçÇıkış_Click(object sender, EventArgs e)
        {
            otopark1.OtoparkÇıkış();
            MessageBox.Show("araç çıkış başarılı.");
        }

        private void BtnBakiye_Click(object sender, EventArgs e)
        {
            int toplambakiye = otopark1.BakiyeOgren();
            MessageBox.Show("bakiye: " + toplambakiye);

        }

        private void BtnKapasite_Click(object sender, EventArgs e)
        {
            int anlıkKapasite = otopark1.KapasiteOgren();
            MessageBox.Show("anlık kapasite:" + anlıkKapasite);
        }
    }
}
