using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace proyecto
{
    public partial class stock : Form
    {
        informes n = new informes();
        public stock()
        {
            
            int contador = 1;
            InitializeComponent();

            foreach (var n in Program.inicial().articulos)
            {
                ListViewItem lista = new ListViewItem(contador.ToString());
                lista.SubItems.Add(n.producto);
                lista.SubItems.Add((n.codigo).ToString());
                lista.SubItems.Add((n.cantidad).ToString());
                lista.SubItems.Add((n.precio).ToString());
                listView1.Items.Add(lista);
                contador++;

            }
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            
            n.Show();
            this.Hide();
        }

        private void Stock_FormClosing(object sender, FormClosingEventArgs e)
        {
            n.Show();
            this.Hide();
        }
    }
}
