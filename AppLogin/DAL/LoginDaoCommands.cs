using MySql.Data.MySqlClient;
using System;

namespace AppLogin.DAL
{
    class LoginDaoCommands
    {
        public bool tem = false;
        public string menssagem = "";
        MySqlCommand cmd = new MySqlCommand();
        Connections con = new Connections();
        MySqlDataReader dr;
        public bool VerificarLogin(string login, string senha)
        {
            cmd.CommandText = "SELECT * FROM registers WHERE login = @Login and senha = @Password";
            cmd.Parameters.AddWithValue("@Login", login);
            cmd.Parameters.AddWithValue("@Password", senha);
            try
            {
                cmd.Connection = con.conectar();
                dr = cmd.ExecuteReader();
                if (dr.HasRows)
                {
                    tem = true;
                }
            }
            catch (MySqlException)
            {

                this.menssagem = "Error with Database!";
            }
            return tem;
        }
        public String cadastrar(String login, String senha, String email)
        {
            return menssagem;
        }
    }
}
