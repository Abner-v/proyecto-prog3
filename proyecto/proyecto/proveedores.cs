using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace proyecto
{
    public partial class proveedores : Form
    {
        matenimiento man = new matenimiento();
        public proveedores()
        {
            InitializeComponent();
        }

        private void Button2_Click(object sender, EventArgs e)
        {
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
                lista.SubItems.Add(textBox5.Text);
                listView1.Items.Add(lista);

                label6.Enabled = false;
                textBox5.Enabled = false;
                button1.Enabled = false;
                button2.Enabled = false;
                panel1.Enabled = true;
                panel1.Visible = true;
            }
        }
        private bool validar()
        {
            bool ok = true;
            if(textBox1.Text==String.Empty)
            {
                errorProvider1.Clear();
                errorProvider1.SetError(textBox1, "Ingrese el nombre y apellido");
                ok = false;
            }
            else
            {
                if (textBox2.Text == String.Empty)
                {
                    errorProvider1.Clear();
                    errorProvider1.SetError(textBox2, "Ingrese direccion");
                    ok = false;
                }
                else
                {
                    if (textBox3.Text == String.Empty)
                    {
                        errorProvider1.Clear();
                        errorProvider1.SetError(textBox3, "Ingrese telefono");
                        ok = false;
                    }
                    else
                    {
                        if (textBox4.Text == String.Empty)
                        {
                            errorProvider1.Clear();
                            errorProvider1.SetError(textBox4, "Ingrese codigo");
                            ok = false;
                        }
                        else
                        {
                            if (textBox5.Text == String.Empty)
                            {
                                errorProvider1.Clear();
                                errorProvider1.SetError(textBox5, "Empresa");
                                ok = false;
                            }
                        }
                    }
                }
            }
            return ok;
        }
        private void Button4_Click(object sender, EventArgs e)
        {
            listView1.Items.Clear();
            panel1.Enabled = false;
            panel1.Visible = false;
            label6.Enabled = true;
            textBox5.Enabled = true;
            button1.Enabled = true;
            button2.Enabled = true;
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            proveedor proveen = new proveedor(textBox1.Text, textBox2.Text, int.Parse(textBox3.Text), textBox4.Text, textBox5.Text);
            Program.inicial().agregarlista_de_proveedor(proveen);
            man.Show();
            this.Hide();
        }

        private void Proveedores_FormClosing(object sender, FormClosingEventArgs e)
        {
            man.Show();
            this.Hide();
        }
    }
}
