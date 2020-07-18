using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace proyecto
{
    public partial class AgregaArticulos : Form
    {
        matenimiento man = new matenimiento();
        public AgregaArticulos()
        {
            InitializeComponent();
        }

        private void Label2_Click(object sender, EventArgs e)
        {

        }

        private void Button2_Click(object sender, EventArgs e)
        {
            string producto = "";
            decimal precio=0;
            int i = 0,codigo=0,cantidad=0;
            for (i = 0; i < listView1.Items.Count; i++)
            {

                producto= listView1.Items[i].SubItems[0].Text;
                codigo = int.Parse(listView1.Items[i].SubItems[1].Text);
                cantidad = int.Parse(listView1.Items[i].SubItems[2].Text);
                precio = decimal.Parse(listView1.Items[i].SubItems[3].Text);                
                
                articulo arte = new articulo(producto, codigo, cantidad, precio);
                Program.inicial().agregarlistaArt(arte);
             }

            
            MessageBox.Show("operacion realizada con exito");



            man.Show();
            this.Hide();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            if (validar())
            {
                ListViewItem lista = new ListViewItem(textBox1.Text);
                lista.SubItems.Add(textBox2.Text);
                lista.SubItems.Add(textBox3.Text);
                lista.SubItems.Add(textBox4.Text);
                listView1.Items.Add(lista);

                textBox1.Text = "";
                textBox2.Text = "";
                textBox3.Text = "";
                textBox4.Text = "";
            }
        }
        private bool validar()
        {
            bool ok = true;
            if (textBox1.Text == String.Empty)
            {
                errorProvider1.SetError(textBox1, "ingrese un producto");
                ok = false;
            }
            else
            {
                errorProvider1.Clear();
                if (textBox2.Text == String.Empty)
                {
                    errorProvider1.SetError(textBox2, "ingrese un codigo");
                    ok = false;
                }
                else
                {
                    errorProvider1.Clear();
                    if (textBox3.Text == String.Empty)
                    {
                        errorProvider1.SetError(textBox3, "ingrese cantidad");
                        ok = false;
                    }
                    else
                    {
                        errorProvider1.Clear();
                        if (textBox4.Text == String.Empty)
                        {
                            errorProvider1.SetError(textBox4, "ingrese precio");
                            ok = false;
                        }
                    }
                }
            }
            return ok;

        }
        private void Button3_Click(object sender, EventArgs e)
        {

            man.Show();
            this.Hide();
        }

        private void AgregaArticulos_FormClosing(object sender, FormClosingEventArgs e)
        {
            man.Show();
            this.Hide();

        }
    }
}
