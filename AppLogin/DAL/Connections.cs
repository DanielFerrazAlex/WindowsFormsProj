using MySql.Data.MySqlClient;

namespace AppLogin.DAL
{
    class Connections
    {
        MySqlConnection con = new MySqlConnection();
        public Connections()
        {
            con.ConnectionString = @"";
        }
        public MySqlConnection conectar()
        {
            if(con.State == System.Data.ConnectionState.Closed)
            {
                con.Open();
            }
            return con;
        }
        public void desconectar()
        {
            if (con.State == System.Data.ConnectionState.Open)
            {
                con.Close();
            }
        }
    }
}
