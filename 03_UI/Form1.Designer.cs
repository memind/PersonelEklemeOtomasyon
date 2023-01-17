namespace _03_UI
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.gbPersonelKayit = new System.Windows.Forms.GroupBox();
            this.cbBirimi = new System.Windows.Forms.ComboBox();
            this.rbKadin = new System.Windows.Forms.RadioButton();
            this.rbErkek = new System.Windows.Forms.RadioButton();
            this.dtpDogumTarihi = new System.Windows.Forms.DateTimePicker();
            this.txtTcNo = new System.Windows.Forms.TextBox();
            this.txtSoyadi = new System.Windows.Forms.TextBox();
            this.txtAdi = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnTemizle = new System.Windows.Forms.Button();
            this.btnKaydet = new System.Windows.Forms.Button();
            this.btnIletisim = new System.Windows.Forms.Button();
            this.gbPersonelKayit.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbPersonelKayit
            // 
            this.gbPersonelKayit.Controls.Add(this.cbBirimi);
            this.gbPersonelKayit.Controls.Add(this.rbKadin);
            this.gbPersonelKayit.Controls.Add(this.rbErkek);
            this.gbPersonelKayit.Controls.Add(this.dtpDogumTarihi);
            this.gbPersonelKayit.Controls.Add(this.txtTcNo);
            this.gbPersonelKayit.Controls.Add(this.txtSoyadi);
            this.gbPersonelKayit.Controls.Add(this.txtAdi);
            this.gbPersonelKayit.Controls.Add(this.label6);
            this.gbPersonelKayit.Controls.Add(this.label5);
            this.gbPersonelKayit.Controls.Add(this.label4);
            this.gbPersonelKayit.Controls.Add(this.label3);
            this.gbPersonelKayit.Controls.Add(this.label2);
            this.gbPersonelKayit.Controls.Add(this.label1);
            this.gbPersonelKayit.Location = new System.Drawing.Point(30, 12);
            this.gbPersonelKayit.Name = "gbPersonelKayit";
            this.gbPersonelKayit.Size = new System.Drawing.Size(417, 318);
            this.gbPersonelKayit.TabIndex = 0;
            this.gbPersonelKayit.TabStop = false;
            this.gbPersonelKayit.Text = "PERSONEL KAYIT EKRANI";
            // 
            // cbBirimi
            // 
            this.cbBirimi.FormattingEnabled = true;
            this.cbBirimi.Items.AddRange(new object[] {
            "IT",
            "IK",
            "Yonetim",
            "Muhasebe",
            "Kalite"});
            this.cbBirimi.Location = new System.Drawing.Point(132, 270);
            this.cbBirimi.Name = "cbBirimi";
            this.cbBirimi.Size = new System.Drawing.Size(250, 28);
            this.cbBirimi.TabIndex = 7;
            // 
            // rbKadin
            // 
            this.rbKadin.AutoSize = true;
            this.rbKadin.Location = new System.Drawing.Point(280, 225);
            this.rbKadin.Name = "rbKadin";
            this.rbKadin.Size = new System.Drawing.Size(68, 24);
            this.rbKadin.TabIndex = 6;
            this.rbKadin.TabStop = true;
            this.rbKadin.Text = "Kadin";
            this.rbKadin.UseVisualStyleBackColor = true;
            // 
            // rbErkek
            // 
            this.rbErkek.AutoSize = true;
            this.rbErkek.Location = new System.Drawing.Point(162, 225);
            this.rbErkek.Name = "rbErkek";
            this.rbErkek.Size = new System.Drawing.Size(65, 24);
            this.rbErkek.TabIndex = 5;
            this.rbErkek.TabStop = true;
            this.rbErkek.Text = "Erkek";
            this.rbErkek.UseVisualStyleBackColor = true;
            // 
            // dtpDogumTarihi
            // 
            this.dtpDogumTarihi.Location = new System.Drawing.Point(132, 174);
            this.dtpDogumTarihi.Name = "dtpDogumTarihi";
            this.dtpDogumTarihi.Size = new System.Drawing.Size(250, 27);
            this.dtpDogumTarihi.TabIndex = 4;
            // 
            // txtTcNo
            // 
            this.txtTcNo.Location = new System.Drawing.Point(127, 129);
            this.txtTcNo.Name = "txtTcNo";
            this.txtTcNo.Size = new System.Drawing.Size(255, 27);
            this.txtTcNo.TabIndex = 3;
            // 
            // txtSoyadi
            // 
            this.txtSoyadi.Location = new System.Drawing.Point(127, 86);
            this.txtSoyadi.Name = "txtSoyadi";
            this.txtSoyadi.Size = new System.Drawing.Size(255, 27);
            this.txtSoyadi.TabIndex = 2;
            // 
            // txtAdi
            // 
            this.txtAdi.Location = new System.Drawing.Point(127, 35);
            this.txtAdi.Name = "txtAdi";
            this.txtAdi.Size = new System.Drawing.Size(255, 27);
            this.txtAdi.TabIndex = 1;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(73, 272);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(48, 20);
            this.label6.TabIndex = 0;
            this.label6.Text = "Birimi";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(57, 224);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(64, 20);
            this.label5.TabIndex = 0;
            this.label5.Text = "Cinsiyeti";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(23, 180);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(98, 20);
            this.label4.TabIndex = 0;
            this.label4.Text = "Dogum Tarihi";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(17, 132);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(104, 20);
            this.label3.TabIndex = 0;
            this.label3.Text = "T.C. Kimlik No:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(64, 86);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 20);
            this.label2.TabIndex = 0;
            this.label2.Text = "Soyadi:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(86, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Adi:";
            // 
            // btnTemizle
            // 
            this.btnTemizle.Location = new System.Drawing.Point(30, 349);
            this.btnTemizle.Name = "btnTemizle";
            this.btnTemizle.Size = new System.Drawing.Size(155, 72);
            this.btnTemizle.TabIndex = 9;
            this.btnTemizle.Text = "TEMIZLE";
            this.btnTemizle.UseVisualStyleBackColor = true;
            this.btnTemizle.Click += new System.EventHandler(this.btnTemizle_Click);
            // 
            // btnKaydet
            // 
            this.btnKaydet.Location = new System.Drawing.Point(292, 349);
            this.btnKaydet.Name = "btnKaydet";
            this.btnKaydet.Size = new System.Drawing.Size(155, 72);
            this.btnKaydet.TabIndex = 8;
            this.btnKaydet.Text = "KAYDET";
            this.btnKaydet.UseVisualStyleBackColor = true;
            this.btnKaydet.Click += new System.EventHandler(this.btnKaydet_Click);
            // 
            // btnIletisim
            // 
            this.btnIletisim.Location = new System.Drawing.Point(30, 441);
            this.btnIletisim.Name = "btnIletisim";
            this.btnIletisim.Size = new System.Drawing.Size(417, 61);
            this.btnIletisim.TabIndex = 10;
            this.btnIletisim.Text = "ILETISIM BILGILERINI GOSTER";
            this.btnIletisim.UseVisualStyleBackColor = true;
            this.btnIletisim.Click += new System.EventHandler(this.btnIletisim_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(479, 515);
            this.Controls.Add(this.btnIletisim);
            this.Controls.Add(this.btnKaydet);
            this.Controls.Add(this.btnTemizle);
            this.Controls.Add(this.gbPersonelKayit);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.gbPersonelKayit.ResumeLayout(false);
            this.gbPersonelKayit.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private GroupBox gbPersonelKayit;
        private ComboBox cbBirimi;
        private RadioButton rbKadin;
        private RadioButton rbErkek;
        private DateTimePicker dtpDogumTarihi;
        private TextBox txtTcNo;
        private TextBox txtSoyadi;
        private TextBox txtAdi;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private Button btnTemizle;
        private Button btnKaydet;
        private Button btnIletisim;
    }
}