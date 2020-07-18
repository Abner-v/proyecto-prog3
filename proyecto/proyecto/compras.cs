using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace proyecto
{
    public partial class compras : Form
    {
        int contador = 1;
        decimal totalcompra = 0;
        principal l = new principal();
        public compras()
        {
            InitializeComponent();
            foreach (var p in Program.inicial().provee)
            {
                pro.Items.Add(p.nombre);
            }
            foreach (var q in Program.inicial().articulos)
            {
                cod.Items.Add(q.codigo);
            }
        }

        private void Compras_FormClosed(object sender, FormClosedEventArgs e)
        {
         
            l.Show();
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            l.Show();
            this.Close();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            if (validar())
            {
                ListViewItem lista = new ListViewItem(contador.ToString());
                lista.SubItems.Add(cod.Text);
                foreach (var l in Program.inicial().articulos)
                {
                    if ((cod.SelectedItem).ToString() == (l.codigo).ToString())
                    {
                        lista.SubItems.Add(l.producto);
                    }
                }
                lista.SubItems.Add(costo.Text);
                lista.SubItems.Add(canti.Text);
                lista.SubItems.Add(descuento.Text);
                lista.SubItems.Add((decimal.Parse(costo.Text) * decimal.Parse(canti.Text)).ToString());
                listacom.Items.Add(lista);
                totalcompra += decimal.Parse(costo.Text) * decimal.Parse(canti.Text);
                tot.Text = totalcompra.ToString();
                button3.Enabled = true;
                costo.Text = "";
                canti.Text = "";
                precio_venta.Text = "";
                contador++;
            }
        }
        private bool validar()
        {
            bool ok = true;
            if(pro.Text==String.Empty)
            {
                errorProvider1.Clear();
                errorProvider1.SetError(pro, "seleccione un proveedor");
                ok = false;
            }
            else
            {
                if (cod.Text == String.Empty)
                {
                    errorProvider1.Clear();
                    errorProvider1.SetError(cod, "seleccione un codigo");
                    ok = false;
                }
                else
                {
                    if (costo.Text == String.Empty)
                    {
                        errorProvider1.Clear();
                        errorProvider1.SetError(costo, "ingrese el costo");
                        ok = false;
                    }
                    else
                    {
                        if (precio_venta.Text == String.Empty)
                        {
                            errorProvider1.Clear();
                            errorProvider1.SetError(precio_venta, "ingrese el precio de venta");
                            ok = false;
                        }
                        else
                        {
                            if (canti.Text == String.Empty)
                            {
                                errorProvider1.Clear();
                                errorProvider1.SetError(canti, "ingrese la cantidad");
                                ok = false;
                            }
                            else
                            {
                                if (descuento.Text == String.Empty)
                                {
                                    errorProvider1.Clear();
                                    errorProvider1.SetError(descuento, "ingrese el descuento ");
                                    ok = false;
                                }
                                else
                                {
                                    if (factura.Text == String.Empty)
                                    {
                                        errorProvider1.Clear();
                                        errorProvider1.SetError(factura, "ingrese el numero de factura");
                                        ok = false;
                                    }
                                }
                            }
                        }
                    }
                }

            }
            return ok;
        }
        private void Button3_Click(object sender, EventArgs e)
        {
            string nombre_pro="", factu="",codi="";
            float descuento=0;
            decimal costo=0, venta=0;
            int i=0,j =0, cantidad=0;

            for (i = 0; i < listacom.Items.Count; i++)
            {
               
                    nombre_pro = listacom.Items[i].SubItems[2].Text;
                    codi = listacom.Items[i].SubItems[1].Text;
                    costo = decimal.Parse(listacom.Items[i].SubItems[3].Text);
                cantidad = int.Parse(listacom.Items[i].SubItems[4].Text);
                
                    descuento = float.Parse(listacom.Items[i].SubItems[5].Text);
                    venta = decimal.Parse(listacom.Items[i].SubItems[6].Text);

                  //  MessageBox.Show(listacom.Items[i].SubItems[j].Text);
                
            }
            
            Compra com = new Compra(nombre_pro,codi,costo,venta,descuento,factu,cantidad);
            Program.inicial().agregarlistacompras(com);
            MessageBox.Show("operacion realizada con exito");
            l.Show();
            this.Close();
        }

        private void Button1_Click_1(object sender, EventArgs e)
        {
            AgregaArticulos agregaArticulos = new AgregaArticulos();
            agregaArticulos.Show();

        }

        private void Tot_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
