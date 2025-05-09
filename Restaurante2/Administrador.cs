using MySql.Data.MySqlClient;

namespace Restaurante2
{
    internal class Administrador
    {
        public static bool ValidarUsuario(string Usuario, string Contrasenia)
        {
            Conexion cn = new Conexion();
            bool esValido = false;

            string Consulta = "SELECT COUNT(*) FROM RestauranteDB.Administrador WHERE Usuario = @usuario AND Contrasenia = @Contrasenia";

            using (MySqlCommand Command = new MySqlCommand(Consulta, cn.GetConnection()))
            {
                Command.Parameters.AddWithValue("@usuario", Usuario);
                Command.Parameters.AddWithValue("@Contrasenia", Contrasenia);

                int cantidad = Convert.ToInt32(Command.ExecuteScalar());
                if (cantidad > 0)
                    esValido = true;
            }

            cn.CloseConnection(); ;
            return esValido;
        }
    }
}