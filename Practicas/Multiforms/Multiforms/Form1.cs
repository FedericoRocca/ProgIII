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
    public partial class Multiform : Form
    {
        public Multiform()
        {
            InitializeComponent();
        }

        private void Multiform_Load(object sender, EventArgs e)
        {

        }

        private void Ayuda_Click(object sender, EventArgs e)
        {
            bool isAyudaOpen = false;
            for (int i = 0; i < Application.OpenForms.Count; i++)
            {
                if( Application.OpenForms[i].GetType() == typeof(Ayuda) )
                {
                    isAyudaOpen = true;
                }
            }

            if( !isAyudaOpen )
            {
                Ayuda formAyuda = new Ayuda();
                formAyuda.MdiParent = this;
                formAyuda.Show();
            }
        }

        private void tsbNuevaVentana_Click(object sender, EventArgs e)
        {
            frmNuevaVentana NewWindow = new frmNuevaVentana();
            NewWindow.Show();
        }
    }
}
