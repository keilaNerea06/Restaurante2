using MySql.Data.MySqlClient;
using System.Data;

namespace Restaurante2;

internal class ConexPedido
{
    public DataTable Tabla_Pedido()
    {
        Conexion cn = new Conexion();

        string consulta = "select * from Pedido p join Menu m on m.id_plato = p.id_plato";
        MySqlDataAdapter DAdapter = new MySqlDataAdapter(consulta, cn.Connection);
        var Dtable = new DataTable();
        DAdapter.Fill(Dtable);
        return Dtable;
    }
}
