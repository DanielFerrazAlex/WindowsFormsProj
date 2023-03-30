using MySql.Data.MySqlClient;
using System;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace AppLogin.Pages
{
    public partial class Form2 : Form
    {
        MySqlConnection con = new MySqlConnection("Server=localhost;Database=cadastro;Uid=root;Pwd=Onaganet0;");
        MySqlCommand cmd;
        string strSQL;
        public string MessageError = "";
        private bool isValid = true;

        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (String.IsNullOrWhiteSpace(TextBLogin.Text) || String.IsNullOrWhiteSpace(TextBSenha.Text) || String.IsNullOrWhiteSpace(TextBEmail.Text))
                {
                    MessageBox.Show("Cadastro inválido! Tente novamente ");
                }
                else if (TextBSenha.TextLength <= 4)
                {
                    MessageBox.Show("Senha muito pequena! Tente novamente");
                }
                else
                {
                    strSQL = "INSERT INTO CLIENTES (Login, Senha, Email) VALUES (@Login, @Senha, @Email)";
                    cmd = new MySqlCommand(strSQL, con);
                    cmd.Parameters.AddWithValue("@Login", TextBLogin.Text);
                    cmd.Parameters.AddWithValue("@Senha", TextBSenha.Text);
                    cmd.Parameters.AddWithValue("@Email", TextBEmail.Text);
                    if (TextBEmail.Text.Trim() != string.Empty)
                    {
                        var regex = new Regex(@"^([a-zA-Z0-9_\-])([a-zA-Z0-9_\-\.]*)@(\[((25[0-5]|2[0-4][0-9]|1[0-9][0-9]|[1-9][0-9]|[0-9])\.){3}|((([a-zA-Z0-9\-]+)\.)+))([a-zA-Z]{2,}|(25[0-5]|2[0-4][0-9]|1[0-9][0-9]|[1-9][0-9]|[0-9])\])$");
                        if (!regex.IsMatch(TextBEmail.Text.Trim()))
                        {
                            MessageBox.Show("E-mail inválido! Tente novamente");
                            return;
                        }
                    }
                    con.Open();
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Cadastro Realizado!");
                    this.Hide();
                }
                
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
