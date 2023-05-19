using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SintePart
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void cmdCancelar_Click(object sender, EventArgs e)
        {
            this.Close();   
    }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtUsuario_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void cmdAceptar_Click(object sender, EventArgs e)
        {
            if (txtUsuario.Text == "Adm" && txtContraseña.Text == "@1a") ;
            {



            }
        }
    }
}
