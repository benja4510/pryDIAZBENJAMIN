using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pryDIAZBENJAMIN
{
    public partial class FrmLogin : Form
    {
        public FrmLogin()
        {
            InitializeComponent();
        }

        private void cmdCancelar_Click(object sender, EventArgs e)
        {
            txtContraseña.Text= string.Empty;  
            txtUsuario.Text= string.Empty;

        }

        private void cmdAceptar_Click(object sender, EventArgs e)
        {
            frmBienvenida = new frmBienvenida();
            frmBienvenida.ShowDialog();

        }
    }
}
