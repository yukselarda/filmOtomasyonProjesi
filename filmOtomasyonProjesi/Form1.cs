using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace filmOtomasyonProjesi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnHesapOlustur_Click(object sender, EventArgs e)
        {
            formHesapOlusturma f = new formHesapOlusturma();
            this.Hide();
            f.ShowDialog();
            this.Show();
        }

        private void btnGiris_Click(object sender, EventArgs e)
        {
            formSehir f = new formSehir();
            this.Hide();
            f.ShowDialog();
            this.Show();
        }
    }
}
