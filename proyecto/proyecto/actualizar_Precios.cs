using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace proyecto
{
    public partial class actualizar_Precios : Form
    {

        matenimiento man = new matenimiento();
        string producto = "";
        public actualizar_Precios()
        {
            InitializeComponent();
            foreach (var l in Program.inicial().articulos)
            {
                comboBox1.Items.Add(l.producto);
            }

          
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            
            foreach (var l in Program.inicial().articulos)
            {
                if (comboBox1.Text == l.producto)
                {
                    label4.Text = "EL PRECIO ACTUAL ES DE :"+ l.precio;
                    producto = l.producto;
                }
            }
            
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            if (validar())
            {
                Program.inicial().Actualizararprecio(producto, decimal.Parse(textBox2.Text));


                man.Show();
                this.Hide();
            }
        }
        private bool validar()
        {
            bool ok = true;
           
            if (textBox2.Text ==String.Empty)
            {
                errorProvider1.Clear();
                ok = false;
                errorProvider1.SetError(textBox2, "ingrese el nuevo precio");
            }
            return ok;
        }

        private void Actualizar_Precios_FormClosing(object sender, FormClosingEventArgs e)
        {
            man.Show();
            this.Hide();

        }
    } }
