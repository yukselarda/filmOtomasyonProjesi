
namespace filmOtomasyonProjesi
{
    partial class lblSeansVeKoltuk
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
            this.lblSeans = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.lblKoltuk = new System.Windows.Forms.Label();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.btnDevam = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblSeans
            // 
            this.lblSeans.AutoSize = true;
            this.lblSeans.Location = new System.Drawing.Point(171, 36);
            this.lblSeans.Name = "lblSeans";
            this.lblSeans.Size = new System.Drawing.Size(43, 15);
            this.lblSeans.TabIndex = 0;
            this.lblSeans.Text = "Seans :";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(230, 36);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 23);
            this.comboBox1.TabIndex = 1;
            // 
            // lblKoltuk
            // 
            this.lblKoltuk.AutoSize = true;
            this.lblKoltuk.Location = new System.Drawing.Point(266, 80);
            this.lblKoltuk.Name = "lblKoltuk";
            this.lblKoltuk.Size = new System.Drawing.Size(41, 15);
            this.lblKoltuk.TabIndex = 2;
            this.lblKoltuk.Text = "Koltuk";
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Location = new System.Drawing.Point(98, 127);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(396, 237);
            this.flowLayoutPanel1.TabIndex = 3;
            // 
            // btnDevam
            // 
            this.btnDevam.Location = new System.Drawing.Point(230, 382);
            this.btnDevam.Name = "btnDevam";
            this.btnDevam.Size = new System.Drawing.Size(121, 41);
            this.btnDevam.TabIndex = 4;
            this.btnDevam.Text = "Devam";
            this.btnDevam.UseVisualStyleBackColor = true;
            // 
            // lblSeansVeKoltuk
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.ClientSize = new System.Drawing.Size(646, 462);
            this.Controls.Add(this.btnDevam);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.lblKoltuk);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.lblSeans);
            this.Name = "lblSeansVeKoltuk";
            this.Text = "Seans Ve Koltuk";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblSeans;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label lblKoltuk;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Button btnDevam;
    }
}