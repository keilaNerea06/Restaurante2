using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Restaurante2
{
    public partial class frmMenuGeneral : Form
    {
        private Conexion cn;
        private DataGridView DVGPedido;

        public frmMenuGeneral()
        {
            InitializeComponent();
            cn = new Conexion(); // corregido aquí
            //CargarDataTable();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        /*private void CargarDataTable() // es un método que muestra toda la tabla actualizada al instante 
        {
            ConexPedido ShowPedido = new ConexPedido();

            DVGPedido.DataSource = ShowPedido.Tabla_Pedido(); // corregido aquí también
        }*/

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmMenuComida menu = new frmMenuComida();
            menu.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Ticket ticket = new Ticket();
            ticket.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Personal personal = new Personal();
            personal.Show();
            this.Hide();
        }
    }
}