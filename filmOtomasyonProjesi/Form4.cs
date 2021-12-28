using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace filmOtomasyonProjesi
{
    public partial class FormCinema : Form
    {
        public FormCinema()
        {
            InitializeComponent();
        }

        private void btnDevam_Click(object sender, EventArgs e)
        {
            FormCinema f = new FormCinema();
            this.Hide();
            f.ShowDialog();
            this.Show();
        }
    }
}
