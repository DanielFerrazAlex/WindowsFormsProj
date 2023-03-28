using MySql.Data.MySqlClient;
using System;
using System.Windows.Forms;

namespace AppLogin.Pages
{
    public partial class Form2 : Form
    {
        MySqlConnection con;
        MySqlCommand command;
        MySqlDataAdapter da;
        MySqlDataReader dr;
        string strSQL;
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                con = new MySqlConnection("Server=localhost;Database=cadastro;Uid=root;Pwd=Onaganet0;");
                strSQL = "INSERT INTO CLIENTES (Login, Senha, Email) VALUES (@Login, @Senha, @Email)";

                command = new MySqlCommand(strSQL, con);
                command.Parameters.AddWithValue("@Login", TextBLogin.Text);
                command.Parameters.AddWithValue("@Senha", TextBSenha.Text);
                command.Parameters.AddWithValue("@Email", TextBEmail.Text);

                con.Open();
                command.ExecuteNonQuery();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
            finally
            {
                con.Close();
                con = null;
                command = null;
            }
        }


    }
}
