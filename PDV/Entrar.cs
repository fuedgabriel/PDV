using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PDV
{
    public partial class Entrar : Form
    {
        public Entrar()
        {
            InitializeComponent();
        }

        private void login_Click(object sender, EventArgs e)
        {
            if (user.Text == "")
            {
                MessageBox.Show("Usuário e senha vázio");

            }
            else {

                this.Hide();
                Central cads = new Central();
                cads.ShowDialog();
                this.Show();
            }
            
        }

        private void Fechar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
