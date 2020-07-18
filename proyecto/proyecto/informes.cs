using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace proyecto
{
    public partial class informes : Form
    {
        principal l = new principal();
        public informes()
        {
            InitializeComponent();
        }

        private void Informes_FormClosing(object sender, FormClosingEventArgs e)
        {
            l.Show();
            
        }

        private void Button5_Click(object sender, EventArgs e)
        {
            l.Show();
            this.Hide();

        }

        private void Button8_Click(object sender, EventArgs e)
        {
            stock n = new stock();
            n.Show();
            this.Hide();

        }
    }
}
