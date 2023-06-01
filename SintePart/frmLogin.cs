using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.Design;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SintePart
{
    public partial class frmLogin : Form
    {
        int varintentos;
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
            if (txtUsuario.Text == "Adm" && txtContraseña.Text == "@1a") 
            {
                if (cmbModulo.Text == "ADM" || cmbModulo.Text == "COM" || cmbModulo.Text == "VTA") 
                {
                    this.Hide();
                    frmAcceso acceso = new frmAcceso();
                    acceso.ShowDialog();
                    varintentos = 0;
                }
                else
                {
                    MessageBox.Show("Usuario y/o contraseñas incorrectos");
                    varintentos++;
                }
                if (txtUsuario.Text =="Jhon" && txtContraseña.Text =="*2b")
                {
                    if (cmbModulo.Text == "SIST")
                    {
                        this.Hide();
                        frmAcceso acceso = new frmAcceso();
                        acceso.ShowDialog();
                        varintentos = 0;
                    }
                    else
                    {
                        MessageBox.Show("Usuario y/o contreseñas incorrectos");
                        varintentos++;
                    }
                    if (txtUsuario.Text == "Ceci" && txtContraseña.Text =="*@3c")
                    { 
                      if(cmbModulo.Text == "AMD" || cmbModulo.Text =="VTA")
                      {
                            this.Hide();
                            frmAcceso acceso=new frmAcceso();
                            acceso.ShowDialog();
                            varintentos = 0;
                      }
                      if(txtUsuario.Text =="God" && txtContraseña.Text =="*@#4d")
                        {
                            if(cmbModulo.Text == "AMD" || cmbModulo.Text == "SIST" ||cmbModulo.Text == "VTA" ||cmbModulo.Text =="COM")
                            {
                                this.Hide();
                                frmAcceso acceso = new frmAcceso();
                                acceso.ShowDialog();
                                varintentos = 0;
                                    
                            }
                            else
                            {
                                MessageBox.Show("Usuario y/o contraseñas incorrectas");
                            }
                        }
                    }
                }
            }
        }
        
        
        
        }
    
}
