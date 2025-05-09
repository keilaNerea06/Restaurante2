using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Windows.Forms;

namespace Restaurante2
{
    public partial class frmMenuComida : Form
    {
        private Conexion miConexion;
        private MySqlDataAdapter adapter;
        private DataTable dt;

        public frmMenuComida()
        {
            InitializeComponent();
            miConexion = new Conexion();
            this.Load += Menu_Load;
        }

        private void Menu_Load(object sender, EventArgs e)
        {
            CargarMenu();
        }

        private void CargarMenu()
        {
            try
            {
                string query = "SELECT * FROM Menu";
                adapter = new MySqlDataAdapter(query, miConexion.Connection);
                dt = new DataTable();
                adapter.Fill(dt);
                dataGridView2.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar datos: " + ex.Message);
            }
        }

        private void button1_Click(object sender, EventArgs e) // agregar fila
        {
            DataRow nuevaFila = dt.NewRow();
            dt.Rows.Add(nuevaFila);
            CargarMenu();
        }

        private void button2_Click(object sender, EventArgs e) //para eleminar fila
        {
            Conexion cn = new Conexion();

            string ID_plato = dataGridView2.CurrentRow.Cells[0].Value.ToString();

            string comsulta = $"delete from Menu where id_plato = '{ID_plato}'";

            MySqlCommand MCcomando = new MySqlCommand(comsulta, cn.GetConnection());
            MCcomando.ExecuteNonQuery();

            MessageBox.Show("Se elimino con exito");

            textBox3.Text = "";

            CargarMenu();

            /*if (dataGridView2.CurrentRow != null)
            {
                dataGridView2.Rows.RemoveAt(dataGridView2.CurrentRow.Index);
            }*/
        }

        private void button3_Click(object sender, EventArgs e) //insertar nuevos -Nombre_plato - Precio-
        {
            Conexion cn = new Conexion();

            string consulta = "Insert into Menu (id_plato, Nombre_plato, precio) values (@id_plato, @Nombre_plato, @precio)";

            using (MySqlCommand comando = new MySqlCommand(consulta, cn.GetConnection()))
            {
                comando.Parameters.AddWithValue("@id_plato", textBox3.Text);
                comando.Parameters.AddWithValue("@Nombre_plato", textBox2.Text);
                comando.Parameters.AddWithValue("@precio", textBox1.Text); // Asegurate de que sea numérico si `precio` es `DECIMAL`

                comando.ExecuteNonQuery();
            }

            CargarMenu();

            try
            {
                MySqlCommandBuilder builder = new MySqlCommandBuilder(adapter);
                adapter.Update(dt);
                MessageBox.Show("Datos actualizados correctamente.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al actualizar datos: " + ex.Message);
            }

        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // No es obligatorio implementar esto por ahora
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            frmMenuGeneral frm2 = new frmMenuGeneral();
            frm2.Show();
            this.Close();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}