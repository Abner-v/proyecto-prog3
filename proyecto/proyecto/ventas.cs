using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace proyecto
{
    public partial class ventas : Form
    {
        int contador = 1;
        principal l = new principal();
        List<string> artbuscado = new List<string>();
        decimal acumula = 0;
        public ventas()
        {

            InitializeComponent();
            fecha.Text = DateTime.Now.ToString("dd/MM/yyyy");
            foreach (var l in Program.inicial().articulos)
            {
                comboBox1.Items.Add(l.producto);
            }
            foreach (var n in Program.inicial().empleados)
            {
                comboBox3.Items.Add(n.nombre);
            }


        }

        private void Button1_Click(object sender, EventArgs e)
        {
            this.Close();
            l.Show();


        }

        private void Ventas_FormClosing(object sender, FormClosingEventArgs e)
        {
            l.Show();
        }

        private void Button2_Click(object sender, EventArgs e)
        {



            registrarventas venta = new registrarventas(Int32.Parse(numero_boleta.Text), artbuscado, acumula, DateTime.Today, " ERROR");
            Program.inicial().agregarlista_de_ventas(venta);
            contador = 1;
            acumula = 0;
            MessageBox.Show("operacion realizada con exito");
            this.Close();
            l.Show();

        }

        private void Numero_boleta_TextChanged(object sender, EventArgs e)
        {

        }

        private void Agrega_Click(object sender, EventArgs e)

        {
            if (validar())
            {
                foreach (var b in Program.inicial().articulos)
                {
                    if (comboBox1.Text == b.producto)
                    {
                        ListViewItem lista = new ListViewItem(contador.ToString());
                        if (b.cantidad == 0)
                            MessageBox.Show("el articulo no esta disponible en stock");
                        else
                        {
                             

                           if (int.Parse(cantidad.Text) > b.cantidad)
                            {
                                MessageBox.Show("cantidad disponible del producto es solo de :" + b.cantidad);
                                /*break;
                                cantidad.Text = (b.cantidad).ToString();

                                lista.SubItems.Add((b.codigo).ToString());
                                lista.SubItems.Add(b.producto);
                                artbuscado.Add(b.producto);
                                lista.SubItems.Add((b.precio).ToString());
                                lista.SubItems.Add(cantidad.Text);
                                lista.SubItems.Add((Program.Calcular(Int32.Parse(cantidad.Text), b.precio)).ToString());
                                listView1.Items.Add(lista);
                                contador += 1;
                                acumula += (Program.Calcular(Int32.Parse(cantidad.Text), b.precio));
                                Program.inicial().Actualizararticulos(b.producto, 0);*/


                            }
                            else
                            {
                                lista.SubItems.Add((b.codigo).ToString());
                                lista.SubItems.Add(b.producto);
                                artbuscado.Add(b.producto);
                                lista.SubItems.Add((b.precio).ToString());
                                lista.SubItems.Add(cantidad.Text);
                                lista.SubItems.Add((Program.Calcular(Int32.Parse(cantidad.Text), b.precio)).ToString());
                                listView1.Items.Add(lista);
                                contador += 1;
                                acumula += (Program.Calcular(Int32.Parse(cantidad.Text), b.precio));
                                Program.inicial().Actualizararticulos(b.producto, int.Parse(cantidad.Text) * -1);
                            }
                        }

                        
                    }



                }
                totales_venta.Text = acumula.ToString();
                button2.Enabled = true;
                cantidad.Text = " ";
                comboBox1.Text = " ";
            }
        }
        private bool validar()
        { bool ok = true;
          if(numero_boleta.Text==String.Empty)
            {
                ok = false;
                errorProvider1.SetError(numero_boleta, "Ingrese el numero de boleta");
            }
          else
            {
                errorProvider1.Clear();
                if (cantidad.Text == String.Empty)
                {
                    try
                    {
                        int i = int.Parse(cantidad.Text);
                    }
                    catch
                    {
                        errorProvider1.Clear();
                        ok = false;
                        errorProvider1.SetError(cantidad, "Ingrese la cantidad");
                    }
                }
                else
                {
                    errorProvider1.Clear();
                    if (comboBox1.Text == String.Empty)
                    {
                        ok = false;
                        errorProvider1.SetError(comboBox1, "Ingrese la cantidad");
                    }
                }
            }
            return ok;
                                 
         }
        private void ListView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
    

}
