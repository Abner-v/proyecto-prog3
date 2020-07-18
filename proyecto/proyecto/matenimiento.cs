using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace proyecto
{
    public partial class matenimiento : Form
    {
        principal l = new principal();
        public matenimiento()
        {
            InitializeComponent();
        }

        private void Matenimiento_FormClosing(object sender, FormClosingEventArgs e)
        {
            l.Show();            
        }

        private void Button5_Click(object sender, EventArgs e)
        {
            l.Show();
            this.Close();
        }

        
            

        private void Button1_Click(object sender, EventArgs e)
        {
            
        }

        private void Button1_Click_1(object sender, EventArgs e)
        {
            usuario usu = new usuario();
            usu.Show();
            this.Hide();
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            proveedores prov = new proveedores();
            prov.Show();
            this.Hide();
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            AgregaArticulos agregaArticulos = new AgregaArticulos();
            agregaArticulos.Show();
            this.Hide();
        }

        private void Button4_Click(object sender, EventArgs e)
        {
            MessageBox.Show("DISCULPE LAS MOLESTIAS ESTA PARTE NO ESTA IMPLEMENTADA");
        }

        private void Button6_Click(object sender, EventArgs e)
        {
            actualizar_Precios actua = new actualizar_Precios();
            actua.Show();
            this.Hide();
        }
    }
}
