using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppClaseII
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void BtnDividir_Click(object sender, EventArgs e)
        {
            try
            {
                MessageBox.Show(dividir(int.Parse(txtNro1.Text), int.Parse(TxtNro2.Text)).ToString());
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.ToString());
                MessageBox.Show(ex.Message);
            }
            //catch (FormatException ex)
            //{
            //    MessageBox.Show("Se ingresó un dato incorrectos.");
            //}
            //catch (DivideByZeroException ex)
            //{
            //    MessageBox.Show("No se puede dividir por cero.");
            //}
        }

        private double dividir(int a, int b)
        {
                return a / b;
        }
    }
}
