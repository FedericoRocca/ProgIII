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
    public partial class frmNuevaVentana : Form
    {
        public frmNuevaVentana()
        {
            InitializeComponent();
        }

        private void frmNuevaVentana_Load(object sender, EventArgs e)
        {
            rtbDescripcion.Text = "De esta manera abro el form en una nueva ventana";
        }
    }
}
