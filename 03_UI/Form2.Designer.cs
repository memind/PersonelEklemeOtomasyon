namespace _03_UI
{
    partial class Form2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.cbPersonel = new System.Windows.Forms.ComboBox();
            this.btnGirisGuncelleme = new System.Windows.Forms.Button();
            this.gbIletisimBilgisi = new System.Windows.Forms.GroupBox();
            this.btnKaydet = new System.Windows.Forms.Button();
            this.txtTelefon = new System.Windows.Forms.MaskedTextBox();
            this.txtAdres = new System.Windows.Forms.TextBox();
            this.txtEposta = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.btnYenipersonel = new System.Windows.Forms.Button();
            this.btnKayitlar = new System.Windows.Forms.Button();
            this.gbIletisimBilgisi.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(377, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Iletisim Bilgilerini Tamamlamak Icin Bir Personel Seciniz:";
            // 
            // cbPersonel
            // 
            this.cbPersonel.FormattingEnabled = true;
            this.cbPersonel.Location = new System.Drawing.Point(12, 44);
            this.cbPersonel.Name = "cbPersonel";
            this.cbPersonel.Size = new System.Drawing.Size(377, 28);
            this.cbPersonel.TabIndex = 1;
            // 
            // btnGirisGuncelleme
            // 
            this.btnGirisGuncelleme.Location = new System.Drawing.Point(12, 88);
            this.btnGirisGuncelleme.Name = "btnGirisGuncelleme";
            this.btnGirisGuncelleme.Size = new System.Drawing.Size(377, 61);
            this.btnGirisGuncelleme.TabIndex = 2;
            this.btnGirisGuncelleme.Text = "GIRIS VEYA GUNCELLEME YAP";
            this.btnGirisGuncelleme.UseVisualStyleBackColor = true;
            this.btnGirisGuncelleme.Click += new System.EventHandler(this.btnGirisGuncelleme_Click);
            // 
            // gbIletisimBilgisi
            // 
            this.gbIletisimBilgisi.Controls.Add(this.btnKaydet);
            this.gbIletisimBilgisi.Controls.Add(this.txtTelefon);
            this.gbIletisimBilgisi.Controls.Add(this.txtAdres);
            this.gbIletisimBilgisi.Controls.Add(this.txtEposta);
            this.gbIletisimBilgisi.Controls.Add(this.label4);
            this.gbIletisimBilgisi.Controls.Add(this.label3);
            this.gbIletisimBilgisi.Controls.Add(this.label2);
            this.gbIletisimBilgisi.Location = new System.Drawing.Point(12, 164);
            this.gbIletisimBilgisi.Name = "gbIletisimBilgisi";
            this.gbIletisimBilgisi.Size = new System.Drawing.Size(377, 297);
            this.gbIletisimBilgisi.TabIndex = 3;
            this.gbIletisimBilgisi.TabStop = false;
            this.gbIletisimBilgisi.Text = "Iletisim Bilgisi Giris Ekrani";
            // 
            // btnKaydet
            // 
            this.btnKaydet.Location = new System.Drawing.Point(256, 248);
            this.btnKaydet.Name = "btnKaydet";
            this.btnKaydet.Size = new System.Drawing.Size(115, 43);
            this.btnKaydet.TabIndex = 6;
            this.btnKaydet.Text = "KAYDET";
            this.btnKaydet.UseVisualStyleBackColor = true;
            this.btnKaydet.Click += new System.EventHandler(this.btnKaydet_Click);
            // 
            // txtTelefon
            // 
            this.txtTelefon.Location = new System.Drawing.Point(125, 80);
            this.txtTelefon.Mask = "(999) 000-0000";
            this.txtTelefon.Name = "txtTelefon";
            this.txtTelefon.Size = new System.Drawing.Size(246, 27);
            this.txtTelefon.TabIndex = 4;
            // 
            // txtAdres
            // 
            this.txtAdres.Location = new System.Drawing.Point(125, 124);
            this.txtAdres.Multiline = true;
            this.txtAdres.Name = "txtAdres";
            this.txtAdres.Size = new System.Drawing.Size(246, 109);
            this.txtAdres.TabIndex = 5;
            // 
            // txtEposta
            // 
            this.txtEposta.Location = new System.Drawing.Point(125, 33);
            this.txtEposta.Name = "txtEposta";
            this.txtEposta.Size = new System.Drawing.Size(246, 27);
            this.txtEposta.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(46, 127);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(73, 20);
            this.label4.TabIndex = 0;
            this.label4.Text = "Ev Adresi:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(50, 83);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 20);
            this.label3.TabIndex = 0;
            this.label3.Text = "Telefonu:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 36);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(109, 20);
            this.label2.TabIndex = 0;
            this.label2.Text = "E-posta Adresi:";
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // btnYenipersonel
            // 
            this.btnYenipersonel.Location = new System.Drawing.Point(12, 467);
            this.btnYenipersonel.Name = "btnYenipersonel";
            this.btnYenipersonel.Size = new System.Drawing.Size(148, 65);
            this.btnYenipersonel.TabIndex = 8;
            this.btnYenipersonel.Text = "YENI PERSONEL";
            this.btnYenipersonel.UseVisualStyleBackColor = true;
            this.btnYenipersonel.Click += new System.EventHandler(this.btnYenipersonel_Click);
            // 
            // btnKayitlar
            // 
            this.btnKayitlar.Location = new System.Drawing.Point(241, 467);
            this.btnKayitlar.Name = "btnKayitlar";
            this.btnKayitlar.Size = new System.Drawing.Size(148, 65);
            this.btnKayitlar.TabIndex = 7;
            this.btnKayitlar.Text = "TUM KAYITLAR";
            this.btnKayitlar.UseVisualStyleBackColor = true;
            this.btnKayitlar.Click += new System.EventHandler(this.btnKayitlar_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(399, 544);
            this.Controls.Add(this.btnKayitlar);
            this.Controls.Add(this.btnYenipersonel);
            this.Controls.Add(this.gbIletisimBilgisi);
            this.Controls.Add(this.btnGirisGuncelleme);
            this.Controls.Add(this.cbPersonel);
            this.Controls.Add(this.label1);
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.gbIletisimBilgisi.ResumeLayout(false);
            this.gbIletisimBilgisi.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private ComboBox cbPersonel;
        private Button btnGirisGuncelleme;
        private GroupBox gbIletisimBilgisi;
        private TextBox txtEposta;
        private Label label4;
        private Label label3;
        private Label label2;
        private TextBox txtAdres;
        private Button btnKaydet;
        private MaskedTextBox txtTelefon;
        private ContextMenuStrip contextMenuStrip1;
        private Button btnYenipersonel;
        private Button btnKayitlar;
    }
}