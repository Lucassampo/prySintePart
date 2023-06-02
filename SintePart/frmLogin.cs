using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.Design;
using System.Data;
using System.Data.Common;
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
            string usuario = txtUsuario.Text;
            string contraseña = txtContraseña.Text;
            string modulo = cmbModulo.Text;
            frmAcceso acceso = new frmAcceso();
            switch (usuario)
            {
                case "Amd":
                    if (contraseña == "@1a" && (modulo == "AMD" || modulo == "COM" || modulo == "VTA"))
                    {
                        this.Hide();
                        acceso.ShowDialog();

                    }
                    else
                    {
                        MessageBox.Show("Contraseña y/o usuarios incorrecto");
                        varintentos++;
                    }
                    break;
                case "Jhon":
                    if (contraseña == "*@3c" && (modulo == "SIST"))
                    {
                        this.Hide();
                        acceso.ShowDialog();
                    }
                    else
                    {
                        MessageBox.Show("Contraseña y/o usuarios incorrectos");
                        varintentos++;
                    }
                    break;
                case "Ceci":
                    if(contraseña=="*2b" &&(modulo == "AMD"))
                    {
                        this.Hide();
                        acceso.ShowDialog();

                    }
                    else
                    {
                        MessageBox.Show("Contraseña y/o usuario incorrectos");
                        varintentos++;
                    }
                    break;
                case "God":
                    if(contraseña=="*@#4d" &&(modulo=="AMD" || modulo== "SIST" || modulo=="VTA" || modulo=="COM" ))
                    {
                        this.Hide();
                        acceso.ShowDialog();
                    }
                    else
                    {
                        MessageBox.Show("Contraseñas y/o usuario incorrectos");
                        varintentos++; 
                    }
                    break;
                     if(varintentos == 2)
                    {
                        MessageBox.Show("Demasiados intentos. Se cerrará el formulario.");
                        this.Close();
                    }  
                    







            }    
             
                       
                
        }

    }
}