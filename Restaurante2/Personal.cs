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
    public partial class Personal : Form
    {

        private Conexion miConexion;
        private MySqlDataAdapter adapterCamarero;
        private MySqlDataAdapter adapterCocinero;
        private DataTable dtCamarero;
        private DataTable dtCocinero;

        private object Cocinero;


        public Personal()
        {
            InitializeComponent();
            miConexion = new Conexion();
            this.Load += Personal_Load;
        }

        private void Personal_Load(object sender, EventArgs e)
        {
            CargarCamareros();
            CargarCocineros();
        }

        private void CargarCamareros()
        {
            try
            {
                string query = "SELECT * FROM Camarero";
                adapterCamarero = new MySqlDataAdapter(query, miConexion.Connection);
                dtCamarero = new DataTable();
                adapterCamarero.Fill(dtCamarero);
                dataGridView1.DataSource = dtCamarero;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar camareros: " + ex.Message);
            }
        }

        private void CargarCocineros()
        {
            try
            {
                string query = "SELECT * FROM Cocinero";
                adapterCocinero = new MySqlDataAdapter(query, miConexion.Connection);
                dtCocinero = new DataTable();
                adapterCocinero.Fill(dtCocinero);
                dataGridView2.DataSource = dtCocinero;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar cocineros: " + ex.Message);
            }
        }


        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // Puedes dejar esto vacío por ahora
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // Puedes dejar esto vacío por ahora
        }

        private void button1_Click(object sender, EventArgs e) //Eleminar Camarero
        {
            Conexion cn = new Conexion();

            string ID_camarero = dataGridView1.CurrentRow.Cells[0].Value.ToString();

            string comsulta = $"delete from Camarero where id_camarero = '{ID_camarero}'";

            MySqlCommand MCcomando = new MySqlCommand(comsulta, cn.GetConnection());
            MCcomando.ExecuteNonQuery();

            MessageBox.Show("Se elimino con exito");

            textBox1.Text = "";
            

            CargarCamareros();


        }

        private void button2_Click(object sender, EventArgs e) //Agregar  Camarero
        {
            Conexion cn = new Conexion();

            string consulta = $"Insert into Camarero (id_camarero, nombre, DNI) values  (@id_camarero, @nombre, @DNI)";

            using (MySqlCommand comando = new MySqlCommand(consulta, cn.GetConnection()))
            {
                comando.Parameters.AddWithValue("@id_camarero", textBox1.Text);
                comando.Parameters.AddWithValue("@nombre", textBox2.Text);
                comando.Parameters.AddWithValue("@DNI", textBox5.Text);

                comando.ExecuteNonQuery();


                textBox1.Text = "";
                textBox2.Text = "";
                textBox5.Text = "";
            }

            CargarCamareros();

            try
            {
                MySqlCommandBuilder builderTicket = new MySqlCommandBuilder(adapterCocinero);
                adapterCocinero.Update(dtCocinero);
                MessageBox.Show("Datos de Camarero actualizados correctamente.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al actualizar Camarero: " + ex.Message);
            }
        }





        private void button3_Click_1(object sender, EventArgs e) // Eleminar Cocinero
        {
            Conexion cn = new Conexion();

            string ID_cocinero = dataGridView2.CurrentRow.Cells[0].Value.ToString();

            string comsulta = $"delete from Cocinero where id_cocinero = '{ID_cocinero}'";

            MySqlCommand MCcomando = new MySqlCommand(comsulta, cn.GetConnection());
            MCcomando.ExecuteNonQuery();

            MessageBox.Show("Se elimino con exito");

            textBox3.Text = "";

            CargarCocineros();
        }

        private void button4_Click_1(object sender, EventArgs e) // Agregar Camarero
        {
            Conexion cn = new Conexion();

            string consulta = $"Insert into Cocinero (id_cocinero, nombre, DNI) values  (@id_cocinero, @nombre, @DNI)";

            using (MySqlCommand comando = new MySqlCommand(consulta, cn.GetConnection()))
            {
                comando.Parameters.AddWithValue("@id_cocinero", textBox3.Text);
                comando.Parameters.AddWithValue("@nombre", textBox4.Text);
                comando.Parameters.AddWithValue("@DNI", textBox6.Text);

                comando.ExecuteNonQuery();


                textBox3.Text = "";
                textBox4.Text = "";
                textBox6.Text = "";
            }
            CargarCocineros();

            try
            {
                MySqlCommandBuilder builderTicket = new MySqlCommandBuilder(adapterCocinero);
                adapterCocinero.Update(dtCocinero);
                MessageBox.Show("Datos de Cocinero actualizados correctamente.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al actualizar Cocinero: " + ex.Message);
            }
        }

        private void button5_Click(object sender, EventArgs e) // Atras
        {
            frmMenuGeneral frm2 = new frmMenuGeneral();
            frm2.Show();
            this.Close();
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }
    }
}


