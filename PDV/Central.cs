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
    public partial class Central : Form
    {
        public Central()
        {
            InitializeComponent();
        }

        public void Closeall()
        {

        }

        private void Central_Load(object sender, EventArgs e)
        {

        }

        private void menu_Click(object sender, EventArgs e)
        {
            if (MenuVertical.Width == 200)
            {
                MenuVertical.Width = 60;
            }
            else
            {
                MenuVertical.Width = 200;
            }
        }

        private void Fechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void bunifuImageButton3_Click(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Maximized)
            {

                this.WindowState = FormWindowState.Normal;
            }
            else
            {
                this.WindowState = FormWindowState.Maximized;
            }
        }

        private void bunifuImageButton2_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void AbrirFormInPanel(object FormInicio)
        {

            Form fh = FormInicio as Form;
            fh.TopLevel = false;
            fh.Dock = DockStyle.Fill;
            this.Centro.Controls.Add(fh);
            fh.Show();
            //Console.WriteLine(this.Centro.Controls);
            //this.Centro.Controls.RemoveAt(0);

            //if (this.Centro.Controls.Count > 0) 
            //{

            //}
     
        }
        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
        private void bunifuFlatButton7_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
    }
}
