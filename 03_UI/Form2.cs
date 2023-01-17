using _01_Entity;
using _02_Data_Access;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _03_UI
{
    public partial class Form2 : Form
    {
        PersonelContext ctx;
        Personel personel;
        Form1 anaForm;
        public Form2(Form1 frm1)
        {
            anaForm = frm1;
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            ctx = new PersonelContext();
            foreach (Personel personel in ctx.Personeller)
            {
                cbPersonel.Items.Add(personel.IsimSoyisim.ToString());
            }
            gbIletisimBilgisi.Enabled = false;
        }

        private void btnYenipersonel_Click(object sender, EventArgs e)
        {
            this.Hide();
            anaForm.Show();
        }

        private void btnKayitlar_Click(object sender, EventArgs e)
        {
            Form3 frm3 = new Form3(this);

            this.Hide();
            frm3.Show();
        }

        private void btnGirisGuncelleme_Click(object sender, EventArgs e)
        {
            personel = ctx.Personeller.Find(cbPersonel.SelectedIndex + 1);

            if (personel != null)
            {
                gbIletisimBilgisi.Enabled = true;

                IletisimBilgisi bilgi = ctx.IletisimBilgileri.Find(personel.PersonelID);

                if (bilgi != null)
                {
                    txtAdres.Text = bilgi.Adres.ToString();
                    txtEposta.Text = bilgi.Eposta.ToString();
                    txtTelefon.Text = bilgi.Telefon.ToString();
                }
            }
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            IletisimBilgisi bilgi = ctx.IletisimBilgileri.Find(personel.PersonelID);

            if (bilgi != null)
            {
                bilgi.Eposta = txtEposta.Text;
                bilgi.Telefon = txtTelefon.Text;
                bilgi.Adres = txtAdres.Text;
            }

            else
            {
                bilgi = new IletisimBilgisi();
                bilgi.PersonelId = personel.PersonelID;
                bilgi.Eposta = txtEposta.Text;
                bilgi.Telefon = txtTelefon.Text;
                bilgi.Adres = txtAdres.Text;
                ctx.IletisimBilgileri.Add(bilgi);
            }

            ctx.SaveChanges();
            Temizle();
            gbIletisimBilgisi.Enabled = false;

            MessageBox.Show("Iletisim Bilgisi Basariyla Kaydedildi!");
        }

        private void Temizle()
        {
            cbPersonel.SelectedItem = null;
            foreach (Control kontrol in gbIletisimBilgisi.Controls)
            {
                if (kontrol is TextBox)
                    kontrol.Text = "";

                if (kontrol is MaskedTextBox)
                    kontrol.Text = "";
            }
        }
    }
}
