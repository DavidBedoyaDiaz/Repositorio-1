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
    public partial class FrmUsuario : Form
    {
        public FrmUsuario()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void BtnGuardar_Click(object sender, EventArgs e)
        {
            Usuario us1 = new Usuario();
            us1.NombreUsuario = TxtUsuario.Text;
            us1.Password = us1.GetSHA1(TxtPassword.Text);
            us1.Email = TxtCorreo.Text;
            us1.Perfil = CboPerfil.SelectedItem.ToString();
            us1.GuardarUsuario();//Crear la logica 
            us1.ConsultarUsuario();
                

            string usuario;
            usuario = us1.NombreUsuario + ", " +
               us1.Password + ", " +
                us1.Password + ", " + us1.Perfil;

            LstUsuarios.Items.Add(usuario);
            TxtUsuario.Clear();
            TxtPassword.Clear();
            TxtCorreo.Clear();
            CboPerfil.SelectedIndex = 0;
         }

        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
