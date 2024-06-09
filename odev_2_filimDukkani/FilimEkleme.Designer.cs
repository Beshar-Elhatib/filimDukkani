namespace odev_2_filimDukkani
{
    partial class frmFilimEkle
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.lbFilimAdi = new System.Windows.Forms.Label();
            this.lbFilimKiralamaBedeli = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnFilimEkle
            // 
            this.btnFilimEkle.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFilimEkle.Location = new System.Drawing.Point(264, 205);
            this.btnFilimEkle.Name = "btnFilimEkle";
            this.btnFilimEkle.Size = new System.Drawing.Size(209, 40);
            this.btnFilimEkle.TabIndex = 0;
            this.btnFilimEkle.Text = "Filim Ekle";
            this.btnFilimEkle.UseVisualStyleBackColor = true;
            this.btnFilimEkle.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(264, 80);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(390, 31);
            this.textBox1.TabIndex = 1;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(264, 143);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(390, 31);
            this.textBox2.TabIndex = 2;
            // 
            // lbFilimAdi
            // 
            this.lbFilimAdi.AutoSize = true;
            this.lbFilimAdi.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbFilimAdi.Location = new System.Drawing.Point(134, 87);
            this.lbFilimAdi.Name = "lbFilimAdi";
            this.lbFilimAdi.Size = new System.Drawing.Size(99, 24);
            this.lbFilimAdi.TabIndex = 3;
            this.lbFilimAdi.Text = "Filim Adı :";
            // 
            // lbFilimKiralamaBedeli
            // 
            this.lbFilimKiralamaBedeli.AutoSize = true;
            this.lbFilimKiralamaBedeli.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbFilimKiralamaBedeli.Location = new System.Drawing.Point(48, 150);
            this.lbFilimKiralamaBedeli.Name = "lbFilimKiralamaBedeli";
            this.lbFilimKiralamaBedeli.Size = new System.Drawing.Size(200, 24);
            this.lbFilimKiralamaBedeli.TabIndex = 4;
            this.lbFilimKiralamaBedeli.Text = "Filim Kirlama Bedeli :";
            // 
            // frmFilimEkle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lbFilimKiralamaBedeli);
            this.Controls.Add(this.lbFilimAdi);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.btnFilimEkle);
            this.Name = "frmFilimEkle";
            this.Text = "Filim Ekleme Formu";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnFilimEkle;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label lbFilimAdi;
        private System.Windows.Forms.Label lbFilimKiralamaBedeli;
    }
}