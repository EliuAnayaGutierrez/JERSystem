using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaPresentacion
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAcceder_Click(object sender, EventArgs e)
        {
            // Crea una instancia del formulario Inicio
            Inicio form = new Inicio();
            form.FormClosed += (s, args) =>
            {
                // Muestra nuevamente el formulario de Login cuando se cierra Inicio
                this.Show();
                // Limpia los TextBox
                txtUser.Clear();
                txtPassword.Clear();
            };
            // Muestra el formulario Inicio
            form.Show();
            // Esconde el formulario Login
            this.Hide();
        }
    }
}
