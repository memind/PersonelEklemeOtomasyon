using _01_Entity;
using _02_Data_Access;

namespace _03_UI
{
    public partial class Form1 : Form
    {
        PersonelContext ctx;
        public Form1()
        {
            InitializeComponent();
        }

        private void btnTemizle_Click(object sender, EventArgs e)
        {
            Temizle();
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            ctx = new PersonelContext();
            Personel personel = new Personel();

            personel.Isim = txtAdi.Text;
            personel.Soyisim = txtSoyadi.Text;
            personel.TcKimlikNo = txtTcNo.Text;
            personel.DogumTarihi = dtpDogumTarihi.Value;
            personel.Birim = cbBirimi.SelectedItem.ToString();
            personel.Cinsiyet = (rbErkek.Checked & !rbKadin.Checked) ? personel.Cinsiyet = true : personel.Cinsiyet = false;

            ctx.Personeller.Add(personel);
            ctx.SaveChanges();

            MessageBox.Show("Personel Basariyla Kaydedildi!");
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            PersonelContext ctx;
        }

        private void btnIletisim_Click(object sender, EventArgs e)
        {
            Form2 frm2 = new Form2(this);

            frm2.Show();
            this.Hide();
        }

        private void Temizle()
        {
            foreach (Control kontrol in gbPersonelKayit.Controls)
            {
                if (kontrol is TextBox)
                    kontrol.Text = "";

                if (kontrol is ComboBox)
                    kontrol.Text = "";

                rbErkek.Checked = false;
                rbKadin.Checked = false;
                dtpDogumTarihi.Value = DateTime.Now;
            }
        }
    }
}