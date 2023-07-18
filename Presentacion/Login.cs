using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using Domain;

namespace Presentacion
{
    public partial class form1 : Form
    {
        public form1()
        {
            InitializeComponent();
        }

        private void txtusuario_TextChanged(object sender, EventArgs e)
        {

        }

        private void gunaPictureBox2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void gunaPictureBox3_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void txtusuario_Enter(object sender, EventArgs e)
        {
            if (txtusuario.Text == "Usuario")
            {
                txtusuario.Text = "";
                txtusuario.ForeColor = Color.Black;

            }
        }

        private void txtusuario_Leave(object sender, EventArgs e)
        { if (txtusuario.Text == "")
            {
                txtusuario.Text = "Usuario";
                txtusuario.ForeColor = Color.DimGray;
            }


        }

        private void txtContraseña_Enter(object sender, EventArgs e)
        {
            if (txtContraseña.Text == "Contraseña")
            {
                txtContraseña.Text = "";
                txtContraseña.ForeColor = Color.Black;
                txtContraseña.UseSystemPasswordChar = true;
            }
        }

        private void txtContraseña_Leave(object sender, EventArgs e)
        {
            if (txtContraseña.Text == "")
            {
                txtContraseña.Text = "Contraseña";
                txtContraseña.ForeColor = Color.DimGray;
                txtContraseña.UseSystemPasswordChar = false;
            }
        }

        private void btnEntrar_Click(object sender, EventArgs e)
        {

            if (txtusuario.Text != "Usuario")
            { if (txtContraseña.Text != "Contraseña")
                {

                    UserModel user = new UserModel();
                    var validLogin = user.LoginUser(txtusuario.Text, txtContraseña.Text);
                    //Si es verdadero instanciamos al form principal
                    if (validLogin == true)
                    {

                        form2 mainMenu = new form2();
                        mainMenu.Show();
                        this.Hide();
                    }
                    else
                    {
                        msgError("Usuario o Contraseña incorrectos /n Pruebe nuevamente!");
                        txtContraseña.ResetText();    //NO ME FUNCIONA EL CLEAR()
                        txtusuario.Focus();
                    }
                    }
                    else msgError("Ingresa tu contraseña.");
                }
                else msgError("Ingresa tu Usuario.");
               
            }
            private void msgError(string msg)
            {
                lblError.Text = "" + msg;
                lblError.Visible = true;
            } 
        } 
}
