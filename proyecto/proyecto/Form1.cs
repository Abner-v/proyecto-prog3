using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace proyecto
{
    public partial class login : Form
    {
        
        public login()
        {
            InitializeComponent();
        }

        static void main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new login());
        }
        private void Button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
           foreach(var l in Program.inicial().empleados)
            if (usuario.Text == l.nombre && pasword.Text ==(l.dni).ToString()) 
            {
                principal i = new principal();
                i.Show();                
                this.Hide();
            }
            else
                MessageBox.Show("NOMBRE DE USUARIO O CONTRASEÑA NO VALIDA","ERROR", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            usuario.Text = "abner";
            pasword.Text = "95468945";

        }
    }
}
