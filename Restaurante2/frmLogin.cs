using System;
using System.Windows.Forms;

namespace Restaurante2
{
    public partial class frmLogin : Form
    {
        private Conexion cn;

        public frmLogin()
        {
            InitializeComponent();
            cn = new Conexion();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string Usuario = textBox1.Text;
            string Contrasenia = textBox2.Text;

            if (Administrador.ValidarUsuario(Usuario, Contrasenia))
            {
                MessageBox.Show("Inicio de sesión exitoso");
                frmMenuGeneral frm2 = new frmMenuGeneral();
                frm2.Show();
            }
            else
            {
                MessageBox.Show("Usuario o contraseña incorrectos");
            }
        }
    }
}