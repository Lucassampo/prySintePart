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
    public partial class formSintePart : Form
    {
        public formSintePart()
        {
            InitializeComponent();
        }

        private void cmdEntrar_Click(object sender, EventArgs e)
        {
            frmLogin ventanaLogin = new frmLogin();
            ventanaLogin.ShowDialog();
        }
    }
}
