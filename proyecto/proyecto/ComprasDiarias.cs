using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace proyecto
{
    public partial class ComprasDiarias : Form
    {
        informes n = new informes();
      /*  public ComprasDiarias()
        {
            int contador = 1;
            InitializeComponent();
            foreach (var n in Program.inicial().compre)
            {
                ListViewItem lista = new ListViewItem(contador.ToString());
                lista.SubItems.Add(n.nombre);
                lista.SubItems.Add((n.nombre).ToString());
                lista.SubItems.Add((n.).ToString());
                lista.SubItems.Add((n.costo).ToString());
                listView1.Items.Add(lista);
                contador++;

            }
        }*/

        private void Button1_Click(object sender, EventArgs e)
        {
            n.Show();
            this.Hide();
        }

        private void ComprasDiarias_FormClosing(object sender, FormClosingEventArgs e)
        {
            n.Show();
            this.Hide();
        }
    }
}
