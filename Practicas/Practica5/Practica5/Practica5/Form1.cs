using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Practica5
{
    public partial class Practica5 : Form
    {
        public Practica5()
        {
            InitializeComponent();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {

            bool isFormCorrect = true;

            if( string.IsNullOrWhiteSpace(txbNombre.Text) )
            {
                txbNombre.BackColor = Color.Red;
                isFormCorrect = false;
            }
            else
            {
                txbNombre.BackColor = Color.White;
            }

            if (string.IsNullOrWhiteSpace(txbApellido.Text))
            {
                txbApellido.BackColor = Color.Red;
                isFormCorrect = false;
            }
            else
            {
                txbApellido.BackColor = Color.White;
            }

            if (string.IsNullOrWhiteSpace(txbEdad.Text))
            {
                txbEdad.BackColor = Color.Red;
                isFormCorrect = false;
            }
            else
            {
                txbEdad.BackColor = Color.White;
            }

            if (string.IsNullOrWhiteSpace(txbDireccion.Text))
            {
                txbDireccion.BackColor = Color.Red;
                isFormCorrect = false;
            }
            else
            {
                txbDireccion.BackColor = Color.White;
            }

            if( isFormCorrect )
            {
                rtbResultado.Text = "Apellido y nombre: " + txbApellido.Text + " " + txbNombre.Text;
                rtbResultado.Text += Environment.NewLine;
                rtbResultado.Text += "Edad: " + txbEdad.Text;
                rtbResultado.Text += Environment.NewLine;
                rtbResultado.Text += "Dirección: " + txbDireccion.Text;
            }
            else
            {
                rtbResultado.Text = "";
            }

        }

        private void txbEdad_TextChanged(object sender, EventArgs e)
        {
            if( !txbEdad.Text.All(char.IsDigit) )
            {
                txbEdad.Text = txbEdad.Text.Substring(0, txbEdad.Text.Length - 1);
                txbEdad.SelectionStart = txbEdad.Text.Length;
            }
        }

        private void txbNombre_TextChanged(object sender, EventArgs e)
        {
            txbNombre.Text = txbNombre.Text.ToUpper();
            txbNombre.SelectionStart = txbNombre.Text.Length;
        }

        private void txbApellido_TextChanged(object sender, EventArgs e)
        {
            txbApellido.Text = txbApellido.Text.ToUpper();
            txbApellido.SelectionStart = txbApellido.Text.Length;
        }

        private void txbDireccion_TextChanged(object sender, EventArgs e)
        {
            txbDireccion.Text = txbDireccion.Text.ToUpper();
            txbDireccion.SelectionStart = txbDireccion.Text.Length;
        }
    }
}
