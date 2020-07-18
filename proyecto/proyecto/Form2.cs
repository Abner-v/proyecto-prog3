using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace proyecto
{
    public partial class principal : Form
    {
        public principal()
        {
            InitializeComponent();
        }

        private void Principal_Load(object sender, EventArgs e)
        {

        }
       
        private void Principal_FormClosing(object sender, FormClosingEventArgs e)
        {
           Application.Exit();
        }

        private void Button5_Click(object sender, EventArgs e)
        {
            Program.Guardar_archivo();
            Application.Exit();
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            matenimiento k = new matenimiento();
            k.Show();
            this.Hide();
        }

        private void PictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void Ventas_Click(object sender, EventArgs e)
        {
            ventas j = new ventas();
            j.Show();
            this.Hide();
        }

        private void Compras_Click(object sender, EventArgs e)
        {
            compras k = new compras();
            k.Show();
            this.Hide();
        }

        private void Info_Click(object sender, EventArgs e)
        {
            informes k = new informes();
            k.Show();
            this.Hide();
        }
    }
}
