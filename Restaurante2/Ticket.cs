using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Restaurante2
{
    public partial class Ticket : Form
    {
        private Conexion miConexion;
        private MySqlDataAdapter adapterPedido;
        private MySqlDataAdapter adapterTicket;
        private DataTable dtPedido;
        private DataTable dtTicket;

        public Ticket()
        {
            InitializeComponent();
            miConexion = new Conexion();
            this.Load += Ticket_Load;
        }

        private void Ticket_Load(object sender, EventArgs e)
        {
            CargarDatos();
        }

        private void CargarDatos()
        {
            try
            {
                // Consultas SQL
                string queryPedido = "SELECT * FROM Pedido";
                string queryTicket = "SELECT * FROM Ticket";

                // Adaptadores
                adapterPedido = new MySqlDataAdapter(queryPedido, miConexion.GetConnection());
                adapterTicket = new MySqlDataAdapter(queryTicket, miConexion.GetConnection());

                // Tablas de datos
                dtPedido = new DataTable();
                dtTicket = new DataTable();

                // Llenar los DataTables
                adapterPedido.Fill(dtPedido);
                adapterTicket.Fill(dtTicket);

                // Asignar al DataGridView
                dataGridView1.DataSource = dtPedido;
                dataGridView2.DataSource = dtTicket;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar los datos: " + ex.Message);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Conexion cn = new Conexion();

            string ID_Pedido = dataGridView2.CurrentRow.Cells[0].Value.ToString();

            string comsulta = $"delete from Pedido where id_pedido = '{ID_Pedido}'";

            MySqlCommand MCcomando = new MySqlCommand(comsulta, cn.GetConnection());
            MCcomando.ExecuteNonQuery();

            MessageBox.Show("Se elimino con exito");

            txtIdPedido1.Text = "";

            CargarDatos();
        }

        private void button2_Click(object sender, EventArgs e) //Eliminar
        {

            Conexion cn = new Conexion();

            string ID_ticket = dataGridView2.CurrentRow.Cells[0].Value.ToString();

            string comsulta = $"delete from Ticket where id_ticket = '{ID_ticket}'";

            MySqlCommand MCcomando = new MySqlCommand(comsulta, cn.GetConnection());
            MCcomando.ExecuteNonQuery();

            MessageBox.Show("Se elimino con exito");

            txtIdTicket.Text = "";

            CargarDatos();

            /*if (dataGridView1.CurrentRow != null)
            {
                dataGridView1.Rows.RemoveAt(dataGridView1.CurrentRow.Index);
            }*/
        }

        private void button3_Click(object sender, EventArgs e) //Agregar  TICKET
        {
            Conexion cn = new Conexion();

            string consulta = $"Insert into Ticket (id_ticket, id_pedido, fecha_pago, metodo_pago, monto) values  (@id_ticket, @id_pedido, @fecha_pago, @metodo_pago, @monto)";

            using (MySqlCommand comando = new MySqlCommand(consulta, cn.GetConnection()))
            {
                comando.Parameters.AddWithValue("@id_ticket", txtIdTicket.Text);
                comando.Parameters.AddWithValue("@id_pedido", txtIdPedido.Text);
                comando.Parameters.AddWithValue("@fecha_pago", DateTime.Now);
                comando.Parameters.AddWithValue("@metodo_pago", txtMetodoPago.Text);
                comando.Parameters.AddWithValue("@monto", txtMonto.Text);

                comando.ExecuteNonQuery();

                txtIdTicket.Text = "";
                txtIdPedido.Text = "";
                txtMetodoPago.Text = "";
                txtMonto.Text = "";

            }

            CargarDatos();

            try
            {
                MySqlCommandBuilder builderTicket = new MySqlCommandBuilder(adapterTicket);
                adapterTicket.Update(dtTicket);
                MessageBox.Show("Datos de Ticket actualizados correctamente.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al actualizar Ticket: " + ex.Message);
            }
        }


        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e) //Agregar pedido (Id_pedido sale error de duplicado)
        {
            Conexion cn = new Conexion();

            string consulta = $"Insert into Pedido (id_pedido, id_plato, id_estado, id_camarero, Cantida, Fecha_hora) values  (@id_pedido, @id_plato, @id_estado, @id_camarero, @Cantida, @Fecha_hora)";

            using (MySqlCommand comando = new MySqlCommand(consulta, cn.GetConnection()))
            {
                comando.Parameters.AddWithValue("@id_pedido", txtIdPedido1.Text);
                comando.Parameters.AddWithValue("@id_plato", txtIdPlato.Text);
                comando.Parameters.AddWithValue("@id_estado", txtEstado.Text);
                comando.Parameters.AddWithValue("@id_camarero", txtIdCamarero.Text);
                comando.Parameters.AddWithValue("@Cantida", txtCantidad.Text);
                comando.Parameters.AddWithValue("@Fecha_hora", DateTime.Now);

                comando.ExecuteNonQuery();

                txtIdPedido1.Text = "";
                txtIdPlato.Text = "";
                txtEstado.Text = "";
                txtIdCamarero.Text = "";
                txtCantidad.Text = "";

            }

            CargarDatos();

            try
            {
                MySqlCommandBuilder builderPedido = new MySqlCommandBuilder(adapterPedido);
                adapterPedido.Update(dtPedido);
                MessageBox.Show("Datos de pedidos actualizados correctamente.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al actualizar pedidos: " + ex.Message);
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            frmMenuGeneral frm2 = new frmMenuGeneral();
            frm2.Show();
            this.Close();
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtI_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}

