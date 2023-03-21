using System;
using System.Windows.Forms;

namespace AppLogin.Pages
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if(TextBLogin.Text != null && TextBSenha.Text != null && TextBEmail.Text != null)
                {
                    this.Hide();
                } 
            }
            catch (ArgumentException)
            {
                throw new ArgumentException("Algo deu errado! Tente novamente mais tarde");
            }
        }


    }
}
