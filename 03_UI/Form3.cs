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
    public partial class Form3 : Form
    {
        PersonelContext ctx = new PersonelContext();
        Form2 form2;
        public Form3(Form2 frm2)
        {
            form2 = frm2;
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            DataDoldur();
        }

        private void btnAnaMenu_Click(object sender, EventArgs e)
        {
            Form1 frm1 = new Form1();

            this.Hide();
            frm1.Show();
        }

        private void btnAra_Click(object sender, EventArgs e)
        {
            switch (cbAramaSarti.SelectedIndex)
            {
                case 0:
                    var ileBaslayan = ctx.Personeller.Where(x => x.Isim.StartsWith(txtPersonel.Text) || x.Soyisim.StartsWith(txtPersonel.Text));
                    dgvPersoneller.DataSource = ileBaslayan.ToList();
                    break;

                case 1:
                    var iceren = ctx.Personeller.Where(x => x.Isim.Contains(txtPersonel.Text) || x.Soyisim.Contains(txtPersonel.Text));
                    dgvPersoneller.DataSource = iceren.ToList();
                    break;

                case 2:
                    var ileBiten = ctx.Personeller.Where(x => x.Isim.EndsWith(txtPersonel.Text) || x.Soyisim.EndsWith(txtPersonel.Text));
                    dgvPersoneller.DataSource = ileBiten.ToList();
                    break;

                default:
                    break;
            }
        }

        private void btnBilgiTemizle_Click(object sender, EventArgs e)
        {
            DataDoldur();
            Temizle();
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            int personelId = int.Parse(dgvPersoneller.SelectedRows[0].Cells[0].Value.ToString());

            Personel personel = ctx.Personeller.Find(personelId);

            if (personel != null)
                ctx.Personeller.Remove(personel);

            ctx.SaveChanges();
            Temizle();
            DataDoldur();
        }

        private void DataDoldur()
        {
            dgvPersoneller.DataSource = ctx.Personeller.ToList();

            dgvPersoneller.Columns["IletisimBilgisi"].Visible = false;
            dgvPersoneller.Columns["IsimSoyisim"].Visible = false;
            dgvPersoneller.Columns["Cinsiyet"].Visible = false;
        }

        private void DataDoldur(IQueryable liste)
        {
            dgvPersoneller.DataSource = liste;

            dgvPersoneller.Columns["IletisimBilgisi"].Visible = false;
            dgvPersoneller.Columns["IsimSoyisim"].Visible = false;
            dgvPersoneller.Columns["Cinsiyet"].Visible = false;
        }

        private void Temizle()
        {
            foreach (Control kontrol in gbBilgiler.Controls)
            {
                if (kontrol is TextBox)
                    kontrol.Text = "";

                if (kontrol is ComboBox)
                    kontrol.Text = "";
            }
        }
    }
}