using AppLogin.Pages;
using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Windows.Forms;

namespace AppLogin
{
    public partial class Form1 : Form
    {
        MySqlConnection con = new MySqlConnection(@"Data Source=localhost;Port=3306;Database=cadastro;User Id=root;password=Onaganet0;");
        public string MessageError = "";
        int i;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                MySqlCommand cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "SELECT * FROM clientes WHERE Login = '" + TextBLogin.Text + "' AND Senha = '" + TextBSenha.Text + "'";
                cmd.ExecuteNonQuery();
                DataTable dt = new DataTable();
                MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                da.Fill(dt);
                i = Convert.ToInt32(dt.Rows.Count.ToString());

                if (i == 0)
                {
                    MessageBox.Show("Login ou Senha inválido!");
                }
                else
                {
                    this.Hide();
                    var Form = new Form3();
                    Form.ShowDialog();
                }
            }
            catch (MySqlException)
            {

                this.MessageError = "Error with DataBase";
            }
            finally 
            {
                con.Close();
            }
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            var Form = new Form2();
            Form.ShowDialog(); 
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            var Form = new Form4();
            Form.ShowDialog();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
           
        }
    }
}
