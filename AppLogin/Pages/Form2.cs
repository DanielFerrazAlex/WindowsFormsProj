using MySql.Data.MySqlClient;
using System;
using System.Windows.Forms;

namespace AppLogin.Pages
{
    public partial class Form2 : Form
    {
        MySqlConnection con = new MySqlConnection("Server=localhost;Database=cadastro;Uid=root;Pwd=Onaganet0;");
        MySqlCommand cmd;
        string strSQL;
        public string MessageError = "";
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                strSQL = "INSERT INTO CLIENTES (Login, Senha, Email) VALUES (@Login, @Senha, @Email)";
                cmd = new MySqlCommand(strSQL, con);
                cmd.Parameters.AddWithValue("@Login", TextBLogin.Text);
                cmd.Parameters.AddWithValue("@Senha", TextBSenha.Text);
                cmd.Parameters.AddWithValue("@Email", TextBEmail.Text);

                con.Open();
                cmd.ExecuteNonQuery();
                MessageBox.Show("Cadastro Realizado!");
                this.Hide();
            }
            catch(MySqlException)
            {
                this.MessageError = "Error with DataBase";
            }
            finally
            {
                con.Close();
            }
        }
    }
}
