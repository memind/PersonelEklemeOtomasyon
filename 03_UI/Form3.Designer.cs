namespace _03_UI
{
    partial class Form3
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
            this.gbBilgiler = new System.Windows.Forms.GroupBox();
            this.dgvPersoneller = new System.Windows.Forms.DataGridView();
            this.btnAra = new System.Windows.Forms.Button();
            this.btnBilgiTemizle = new System.Windows.Forms.Button();
            this.cbAramaSarti = new System.Windows.Forms.ComboBox();
            this.txtPersonel = new System.Windows.Forms.TextBox();
            this.btnAnaMenu = new System.Windows.Forms.Button();
            this.btnSil = new System.Windows.Forms.Button();
            this.gbBilgiler.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPersoneller)).BeginInit();
            this.SuspendLayout();
            // 
            // gbBilgiler
            // 
            this.gbBilgiler.Controls.Add(this.dgvPersoneller);
            this.gbBilgiler.Controls.Add(this.btnAra);
            this.gbBilgiler.Controls.Add(this.btnBilgiTemizle);
            this.gbBilgiler.Controls.Add(this.cbAramaSarti);
            this.gbBilgiler.Controls.Add(this.txtPersonel);
            this.gbBilgiler.Location = new System.Drawing.Point(17, 33);
            this.gbBilgiler.Name = "gbBilgiler";
            this.gbBilgiler.Size = new System.Drawing.Size(865, 389);
            this.gbBilgiler.TabIndex = 0;
            this.gbBilgiler.TabStop = false;
            this.gbBilgiler.Text = "Personel Bilgileri";
            // 
            // dgvPersoneller
            // 
            this.dgvPersoneller.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPersoneller.Location = new System.Drawing.Point(6, 59);
            this.dgvPersoneller.Name = "dgvPersoneller";
            this.dgvPersoneller.RowHeadersWidth = 51;
            this.dgvPersoneller.RowTemplate.Height = 29;
            this.dgvPersoneller.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPersoneller.Size = new System.Drawing.Size(853, 252);
            this.dgvPersoneller.TabIndex = 3;
            // 
            // btnAra
            // 
            this.btnAra.Location = new System.Drawing.Point(691, 24);
            this.btnAra.Name = "btnAra";
            this.btnAra.Size = new System.Drawing.Size(168, 29);
            this.btnAra.TabIndex = 2;
            this.btnAra.Text = "ARA";
            this.btnAra.UseVisualStyleBackColor = true;
            this.btnAra.Click += new System.EventHandler(this.btnAra_Click);
            // 
            // btnBilgiTemizle
            // 
            this.btnBilgiTemizle.Location = new System.Drawing.Point(6, 317);
            this.btnBilgiTemizle.Name = "btnBilgiTemizle";
            this.btnBilgiTemizle.Size = new System.Drawing.Size(853, 64);
            this.btnBilgiTemizle.TabIndex = 1;
            this.btnBilgiTemizle.Text = "TEMIZLE";
            this.btnBilgiTemizle.UseVisualStyleBackColor = true;
            this.btnBilgiTemizle.Click += new System.EventHandler(this.btnBilgiTemizle_Click);
            // 
            // cbAramaSarti
            // 
            this.cbAramaSarti.FormattingEnabled = true;
            this.cbAramaSarti.Items.AddRange(new object[] {
            "ile baslayan",
            "iceren",
            "ile biten"});
            this.cbAramaSarti.Location = new System.Drawing.Point(312, 25);
            this.cbAramaSarti.Name = "cbAramaSarti";
            this.cbAramaSarti.Size = new System.Drawing.Size(373, 28);
            this.cbAramaSarti.TabIndex = 1;
            // 
            // txtPersonel
            // 
            this.txtPersonel.Location = new System.Drawing.Point(6, 24);
            this.txtPersonel.Name = "txtPersonel";
            this.txtPersonel.Size = new System.Drawing.Size(300, 27);
            this.txtPersonel.TabIndex = 0;
            // 
            // btnAnaMenu
            // 
            this.btnAnaMenu.Location = new System.Drawing.Point(17, 428);
            this.btnAnaMenu.Name = "btnAnaMenu";
            this.btnAnaMenu.Size = new System.Drawing.Size(570, 62);
            this.btnAnaMenu.TabIndex = 2;
            this.btnAnaMenu.Text = "ANA MENU";
            this.btnAnaMenu.UseVisualStyleBackColor = true;
            this.btnAnaMenu.Click += new System.EventHandler(this.btnAnaMenu_Click);
            // 
            // btnSil
            // 
            this.btnSil.Location = new System.Drawing.Point(593, 428);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(289, 62);
            this.btnSil.TabIndex = 3;
            this.btnSil.Text = "Personeli Veritabanindan Sil";
            this.btnSil.UseVisualStyleBackColor = true;
            this.btnSil.Click += new System.EventHandler(this.btnSil_Click);
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(898, 498);
            this.Controls.Add(this.btnSil);
            this.Controls.Add(this.btnAnaMenu);
            this.Controls.Add(this.gbBilgiler);
            this.Name = "Form3";
            this.Text = "Form3";
            this.Load += new System.EventHandler(this.Form3_Load);
            this.gbBilgiler.ResumeLayout(false);
            this.gbBilgiler.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPersoneller)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private GroupBox gbBilgiler;
        private Button btnBilgiTemizle;
        private Button btnAra;
        private ComboBox cbAramaSarti;
        private TextBox txtPersonel;
        private Button btnAnaMenu;
        private Button btnSil;
        private DataGridView dgvPersoneller;
    }
}