
namespace filmOtomasyonProjesi
{
    partial class FormFatura
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
            this.lblOdemeBilgisi = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblFiyat = new System.Windows.Forms.Label();
            this.lblKartNumarasi = new System.Windows.Forms.Label();
            this.tbxKartNumarasi = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tbxGun = new System.Windows.Forms.TextBox();
            this.tbxYil = new System.Windows.Forms.TextBox();
            this.tbxAy = new System.Windows.Forms.TextBox();
            this.tbxGuvenlikKodu = new System.Windows.Forms.TextBox();
            this.lblGuvenlikKodu = new System.Windows.Forms.Label();
            this.btnBitiş = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblOdemeBilgisi
            // 
            this.lblOdemeBilgisi.AutoSize = true;
            this.lblOdemeBilgisi.Location = new System.Drawing.Point(42, 54);
            this.lblOdemeBilgisi.Name = "lblOdemeBilgisi";
            this.lblOdemeBilgisi.Size = new System.Drawing.Size(83, 15);
            this.lblOdemeBilgisi.TabIndex = 0;
            this.lblOdemeBilgisi.Text = "Ödeme Bilgisi:";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Kredi Kartı",
            "Hediye Kartı",
            "Nakit"});
            this.comboBox1.Location = new System.Drawing.Point(131, 51);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 23);
            this.comboBox1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(37, 233);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 15);
            this.label1.TabIndex = 2;
            this.label1.Text = "Fiyat:";
            // 
            // lblFiyat
            // 
            this.lblFiyat.AutoSize = true;
            this.lblFiyat.Location = new System.Drawing.Point(88, 233);
            this.lblFiyat.Name = "lblFiyat";
            this.lblFiyat.Size = new System.Drawing.Size(0, 15);
            this.lblFiyat.TabIndex = 3;
            // 
            // lblKartNumarasi
            // 
            this.lblKartNumarasi.AutoSize = true;
            this.lblKartNumarasi.Location = new System.Drawing.Point(42, 116);
            this.lblKartNumarasi.Name = "lblKartNumarasi";
            this.lblKartNumarasi.Size = new System.Drawing.Size(82, 15);
            this.lblKartNumarasi.TabIndex = 4;
            this.lblKartNumarasi.Text = "Kart Numarası";
            // 
            // tbxKartNumarasi
            // 
            this.tbxKartNumarasi.Location = new System.Drawing.Point(131, 113);
            this.tbxKartNumarasi.Name = "tbxKartNumarasi";
            this.tbxKartNumarasi.Size = new System.Drawing.Size(100, 23);
            this.tbxKartNumarasi.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(42, 159);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(111, 15);
            this.label2.TabIndex = 6;
            this.label2.Text = "Son Kullanma Tarihi";
            // 
            // tbxGun
            // 
            this.tbxGun.Location = new System.Drawing.Point(170, 159);
            this.tbxGun.Name = "tbxGun";
            this.tbxGun.Size = new System.Drawing.Size(22, 23);
            this.tbxGun.TabIndex = 7;
            // 
            // tbxYil
            // 
            this.tbxYil.Location = new System.Drawing.Point(226, 159);
            this.tbxYil.Name = "tbxYil";
            this.tbxYil.Size = new System.Drawing.Size(22, 23);
            this.tbxYil.TabIndex = 8;
            // 
            // tbxAy
            // 
            this.tbxAy.Location = new System.Drawing.Point(198, 159);
            this.tbxAy.Name = "tbxAy";
            this.tbxAy.Size = new System.Drawing.Size(22, 23);
            this.tbxAy.TabIndex = 9;
            // 
            // tbxGuvenlikKodu
            // 
            this.tbxGuvenlikKodu.Location = new System.Drawing.Point(131, 197);
            this.tbxGuvenlikKodu.Name = "tbxGuvenlikKodu";
            this.tbxGuvenlikKodu.Size = new System.Drawing.Size(100, 23);
            this.tbxGuvenlikKodu.TabIndex = 10;
            // 
            // lblGuvenlikKodu
            // 
            this.lblGuvenlikKodu.AutoSize = true;
            this.lblGuvenlikKodu.Location = new System.Drawing.Point(46, 204);
            this.lblGuvenlikKodu.Name = "lblGuvenlikKodu";
            this.lblGuvenlikKodu.Size = new System.Drawing.Size(84, 15);
            this.lblGuvenlikKodu.TabIndex = 11;
            this.lblGuvenlikKodu.Text = "Güvenlik Kodu";
            // 
            // btnBitiş
            // 
            this.btnBitiş.Location = new System.Drawing.Point(101, 299);
            this.btnBitiş.Name = "btnBitiş";
            this.btnBitiş.Size = new System.Drawing.Size(130, 38);
            this.btnBitiş.TabIndex = 12;
            this.btnBitiş.Text = "Bitiş";
            this.btnBitiş.UseVisualStyleBackColor = true;
            // 
            // FormFatura
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.ClientSize = new System.Drawing.Size(648, 450);
            this.Controls.Add(this.btnBitiş);
            this.Controls.Add(this.lblGuvenlikKodu);
            this.Controls.Add(this.tbxGuvenlikKodu);
            this.Controls.Add(this.tbxAy);
            this.Controls.Add(this.tbxYil);
            this.Controls.Add(this.tbxGun);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbxKartNumarasi);
            this.Controls.Add(this.lblKartNumarasi);
            this.Controls.Add(this.lblFiyat);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.lblOdemeBilgisi);
            this.Name = "FormFatura";
            this.Text = "Fatura";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblOdemeBilgisi;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblFiyat;
        private System.Windows.Forms.Label lblKartNumarasi;
        private System.Windows.Forms.TextBox tbxKartNumarasi;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbxGun;
        private System.Windows.Forms.TextBox tbxYil;
        private System.Windows.Forms.TextBox tbxAy;
        private System.Windows.Forms.TextBox tbxGuvenlikKodu;
        private System.Windows.Forms.Label lblGuvenlikKodu;
        private System.Windows.Forms.Button btnBitiş;
    }
}