namespace odev_2_filimDukkani
{
    partial class frmMagzaninArayuz
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
            this.btnFilimEkle = new System.Windows.Forms.Button();
            this.btnFilimKirala = new System.Windows.Forms.Button();
            this.btnKisiEkle = new System.Windows.Forms.Button();
            this.btnDosyaYaz = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnDosyaOku = new System.Windows.Forms.Button();
            this.btnVerilerGoster = new System.Windows.Forms.Button();
            this.btnVerileriSil = new System.Windows.Forms.Button();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnFilimEkle
            // 
            this.btnFilimEkle.Location = new System.Drawing.Point(88, 12);
            this.btnFilimEkle.Name = "btnFilimEkle";
            this.btnFilimEkle.Size = new System.Drawing.Size(116, 47);
            this.btnFilimEkle.TabIndex = 0;
            this.btnFilimEkle.Text = "Filim Ekle";
            this.btnFilimEkle.UseVisualStyleBackColor = true;
            this.btnFilimEkle.Click += new System.EventHandler(this.btnFilimEkle_Click);
            // 
            // btnFilimKirala
            // 
            this.btnFilimKirala.Location = new System.Drawing.Point(251, 12);
            this.btnFilimKirala.Name = "btnFilimKirala";
            this.btnFilimKirala.Size = new System.Drawing.Size(116, 47);
            this.btnFilimKirala.TabIndex = 1;
            this.btnFilimKirala.Text = "Filim Kirala";
            this.btnFilimKirala.UseVisualStyleBackColor = true;
            this.btnFilimKirala.Click += new System.EventHandler(this.btnFilimKirala_Click);
            // 
            // btnKisiEkle
            // 
            this.btnKisiEkle.Location = new System.Drawing.Point(414, 12);
            this.btnKisiEkle.Name = "btnKisiEkle";
            this.btnKisiEkle.Size = new System.Drawing.Size(116, 47);
            this.btnKisiEkle.TabIndex = 2;
            this.btnKisiEkle.Text = "kisi Ekle";
            this.btnKisiEkle.UseVisualStyleBackColor = true;
            this.btnKisiEkle.Click += new System.EventHandler(this.btnKisiEkle_Click);
            // 
            // btnDosyaYaz
            // 
            this.btnDosyaYaz.Location = new System.Drawing.Point(88, 93);
            this.btnDosyaYaz.Name = "btnDosyaYaz";
            this.btnDosyaYaz.Size = new System.Drawing.Size(116, 47);
            this.btnDosyaYaz.TabIndex = 3;
            this.btnDosyaYaz.Text = "verilerin dosya\\Y";
            this.btnDosyaYaz.UseVisualStyleBackColor = true;
            this.btnDosyaYaz.Click += new System.EventHandler(this.btnDosyaYaz_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(2, 219);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 26;
            this.dataGridView1.Size = new System.Drawing.Size(652, 307);
            this.dataGridView1.TabIndex = 4;
            // 
            // btnDosyaOku
            // 
            this.btnDosyaOku.Location = new System.Drawing.Point(251, 93);
            this.btnDosyaOku.Name = "btnDosyaOku";
            this.btnDosyaOku.Size = new System.Drawing.Size(116, 47);
            this.btnDosyaOku.TabIndex = 5;
            this.btnDosyaOku.Text = "Verilerin Dosyadan\\Oku";
            this.btnDosyaOku.UseVisualStyleBackColor = true;
            this.btnDosyaOku.Click += new System.EventHandler(this.btnDosyaOku_Click);
            // 
            // btnVerilerGoster
            // 
            this.btnVerilerGoster.Location = new System.Drawing.Point(415, 93);
            this.btnVerilerGoster.Name = "btnVerilerGoster";
            this.btnVerilerGoster.Size = new System.Drawing.Size(116, 47);
            this.btnVerilerGoster.TabIndex = 6;
            this.btnVerilerGoster.Text = "Verileri Göster";
            this.btnVerilerGoster.UseVisualStyleBackColor = true;
            this.btnVerilerGoster.Click += new System.EventHandler(this.btnVerilerGoster_Click);
            // 
            // btnVerileriSil
            // 
            this.btnVerileriSil.Location = new System.Drawing.Point(251, 166);
            this.btnVerileriSil.Name = "btnVerileriSil";
            this.btnVerileriSil.Size = new System.Drawing.Size(116, 47);
            this.btnVerileriSil.TabIndex = 7;
            this.btnVerileriSil.Text = "Verileri Sil ";
            this.btnVerileriSil.UseVisualStyleBackColor = true;
            this.btnVerileriSil.Click += new System.EventHandler(this.btnVerileriSil_Click);
            // 
            // frmMagzaninArayuz
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(655, 579);
            this.Controls.Add(this.btnVerileriSil);
            this.Controls.Add(this.btnVerilerGoster);
            this.Controls.Add(this.btnDosyaOku);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnDosyaYaz);
            this.Controls.Add(this.btnKisiEkle);
            this.Controls.Add(this.btnFilimKirala);
            this.Controls.Add(this.btnFilimEkle);
            this.Name = "frmMagzaninArayuz";
            this.Text = "filimDukkaniform";
            this.Load += new System.EventHandler(this.frmMagzaninArayuz_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnFilimEkle;
        private System.Windows.Forms.Button btnFilimKirala;
        private System.Windows.Forms.Button btnKisiEkle;
        private System.Windows.Forms.Button btnDosyaYaz;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnDosyaOku;
        private System.Windows.Forms.Button btnVerilerGoster;
        private System.Windows.Forms.Button btnVerileriSil;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
    }
}

