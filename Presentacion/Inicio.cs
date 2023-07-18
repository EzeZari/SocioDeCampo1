using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FontAwesome.Sharp;

namespace Presentacion
{
    public partial class form2 : Form

    {
        List<string> elementosEliminados = new List<string>();
        List<String> listaJugadores = new List<string>();
       
        public form2()
        {
            InitializeComponent();
        }
       
        private void Inicio_Load(object sender, EventArgs e)
        {
            txtPosicion.Items.AddRange(elementosEliminados.ToArray());
        }

        private void btnInicio_Click(object sender, EventArgs e)
        {
           
        }



        private void gunaLabel5_Click(object sender, EventArgs e)
        {

        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if(txtNombre.Text == ""||txtApellido.Text == "" || txtNacionalidad.Text == "" || txtPosicion.Text == "")
            {
                MessageBox.Show("Existen datos vacios", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                string nomJugador;

                nomJugador = txtNombre.Text+ " "+txtApellido.Text+ " -Pos: "+ txtPosicion.Text+" -Nac: "+txtNacionalidad.Text;
                listaJugadores.Add(nomJugador);

                list_Jugadores.DataSource = null;
                list_Jugadores.DataSource = listaJugadores;
            }
        }

        private void gunaButton1_Click(object sender, EventArgs e)
        {
            txtApellido.Text=string.Empty;
            txtNombre.Text = string.Empty;
            txtNacionalidad.Text = string.Empty;

        }
    }
}
