using System.Data;
using MySql.Data.MySqlClient;


namespace Restaurante2
{
    public class Conexion
    {
        private MySqlConnection conexion;
        private readonly string cadenaConexion;

        public Conexion()
        {
            string server = "localhost";
            string database = "RestauranteDB";
            string user = "root";
            string password = "root";

            cadenaConexion = $"Server={server};Database={database};Uid={user};Pwd={password};";
            conexion = new MySqlConnection(cadenaConexion);
        }

        public MySqlConnection Connection
        {
            get
            {
                if (conexion.State != ConnectionState.Open)
                {
                    conexion.Open(); // Abrimos solo si está cerrada
                }

                return conexion;
            }
        }

        public void CloseConnection()
        {
            if (conexion.State == ConnectionState.Open)
            {
                conexion.Close();
            }
        }

        public MySqlConnection GetConnection()
        {
            if (conexion.State != ConnectionState.Open)
                conexion.Open();
            return conexion;
        }
    }
}