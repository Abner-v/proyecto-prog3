using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace proyecto
{
    public partial class usuario : Form
    {
        matenimiento man = new matenimiento();
        public usuario()
        {
            InitializeComponent();
        }

        private void Label6_Click(object sender, EventArgs e)
        {

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            if (validar())
            {
                ListViewItem lista = new ListViewItem(nombre_apellido.Text);
                lista.SubItems.Add(dni.Text);
                lista.SubItems.Add(direcc.Text);
                lista.SubItems.Add(telef.Text);
                lista.SubItems.Add(codis.Text);
                lista.SubItems.Add(horari.Text);
                listView1.Items.Add(lista);

                label6.Enabled = false;
                horari.Enabled = false;
                button1.Enabled = false;
                button2.Enabled = false;
                panel1.Enabled = true;
                panel1.Visible = true;
            }
        }
        private bool validar()
        {
            bool ok = true;
            if (nombre_apellido.Text == String.Empty)
            {
                errorProvider1.Clear();
                errorProvider1.SetError(nombre_apellido, "Ingrese el nombre y apellido");
                ok = false;
            }
            else
            {
                if (direcc.Text == String.Empty)
                {
                    errorProvider1.Clear();
                    errorProvider1.SetError(direcc, "Ingrese direccion");
                    ok = false;
                }
                else
                {
                    if (dni.Text == String.Empty)
                    {
                        errorProvider1.Clear();
                        errorProvider1.SetError(dni, "Ingrese DNI");
                        ok = false;
                    }
                    else
                    {
                        if (telef.Text == String.Empty)
                        {
                            errorProvider1.Clear();
                            errorProvider1.SetError(telef, "Ingrese telefono");
                            ok = false;
                        }
                        else
                        {
                            if (codis.Text == String.Empty)
                            {
                                errorProvider1.Clear();
                                errorProvider1.SetError(codis, "ingrese un codigo");
                                ok = false;
                            }
                            else
                            {
                                if (horari.Text == String.Empty)
                                {
                                    errorProvider1.Clear();
                                    errorProvider1.SetError(horari, "ingrese un codigo");
                                    ok = false;
                                }

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
            horari.Enabled = true;
            button1.Enabled = true;
            button2.Enabled = true;
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            man.Show();
            this.Hide();
        }

        private void Usuario_FormClosing(object sender, FormClosingEventArgs e)
        {
            man.Show();
            this.Hide();
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            empleado empleable = new empleado(nombre_apellido.Text,int.Parse(dni.Text), direcc.Text,int.Parse(telef.Text),codis.Text,horari.Text);
            Program.inicial().agregarempleado(empleable);
            man.Show();
            this.Hide();
        }
    }
}
