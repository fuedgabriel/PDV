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
    public partial class Form1 : Form
    {
        public Form1()
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
    }
}
