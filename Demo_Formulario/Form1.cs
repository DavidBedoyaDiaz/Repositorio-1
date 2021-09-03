using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Demo_Formulario
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.BackColor = System.Drawing.Color.Blue;
        }

        private void BtnRojo_Click(object sender, EventArgs e)
        {
            this.BackColor = System.Drawing.Color.Red;
        }

        private void BtnSaludar_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Bienvenido CRACK");
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void BtnUsuario_Click(object sender, EventArgs e)
        {
            FrmUsuario frm1 = new FrmUsuario();
            frm1.ShowDialog();
        }

        private void BtnLogin_Click(object sender, EventArgs e)
        {
            FrmLogin frml1 = new FrmLogin();
            frml1.ShowDialog();

        }
    }
}
