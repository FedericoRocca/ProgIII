using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Multiforms
{
    public partial class Ayuda : Form
    {
        public Ayuda()
        {
            InitializeComponent();
        }

        private void Ayuda_Load(object sender, EventArgs e)
        {
            rtbAyuda.Text = "La idea de este programa es demostrar las distintas formas de abrir y controlar forms" + Environment.NewLine
                + "En este caso controlo mediante Application.OpenForms la apertura tipo singleton (Una única ventana de este tipo de form)"
                ;
        }

        private void rtbAyuda_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
