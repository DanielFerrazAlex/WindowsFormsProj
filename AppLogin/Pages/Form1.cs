using AppLogin.Pages;
using System;
using System.Windows.Forms;

namespace AppLogin
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(TextBLogin.Text == "Daniel" && TextBSenha.Text == "Daniel")
            {
                this.Hide();
                var Form = new Form3();
                Form.ShowDialog();
            }
            else
            {
                MessageBox.Show("Senha invalida!");
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
