using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Net;
using System.Data.SqlClient;

namespace Excepciones
{
    public partial class frmExcepciones : Form
    {
        public frmExcepciones()
        {
            InitializeComponent();
        }

        private void btnThrowOutOfRange_Click(object sender, EventArgs e)
        {
            throw new IndexOutOfRangeException();
        }

        private void btnThrowIO_Click(object sender, EventArgs e)
        {
            throw new IOException();
        }

        private void btnThrowWeb_Click(object sender, EventArgs e)
        {
            throw new WebException();
        }

        private void btnThrowStack_Click(object sender, EventArgs e)
        {
            throw new StackOverflowException();
        }

        private void btnThrowMemory_Click(object sender, EventArgs e)
        {
            throw new OutOfMemoryException();
        }

        private void btnThrowCast_Click(object sender, EventArgs e)
        {
            throw new InvalidCastException();
        }

        private void btnThrowInvalid_Click(object sender, EventArgs e)
        {
            throw new InvalidOperationException();
        }

        private void btnThrowDivide_Click(object sender, EventArgs e)
        {
            throw new DivideByZeroException();
        }

        private void btnThrowHandledOutOfRange_Click(object sender, EventArgs e)
        {
            try
            {
                throw new IndexOutOfRangeException();
            }
            catch (IndexOutOfRangeException ex)
            {
                MessageBox.Show("Excepción: " + ex.Message);
                MessageBox.Show("Detalle: " + ex);
            }
        }

        private void btnThrowHandledIO_Click(object sender, EventArgs e)
        {
            try
            {
                throw new IOException();
            }
            catch (IOException ex)
            {
                MessageBox.Show("Excepción: " + ex.Message);
                MessageBox.Show("Detalle: " + ex);
            }
        }

        private void btnThrowHandledWeb_Click(object sender, EventArgs e)
        {
            try
            {
                throw new WebException();
            }
            catch (WebException ex)
            {
                MessageBox.Show("Excepción: " + ex.Message);
                MessageBox.Show("Detalle: " + ex);
            }
        }

        private void btnThrowHandledStack_Click(object sender, EventArgs e)
        {
            try
            {
                throw new StackOverflowException();
            }
            catch (StackOverflowException ex)
            {
                MessageBox.Show("Excepción: " + ex.Message);
                MessageBox.Show("Detalle: " + ex);
            }
        }

        private void btnThrowHandledMemory_Click(object sender, EventArgs e)
        {
            try
            {
                throw new OutOfMemoryException();
            }
            catch (OutOfMemoryException ex)
            {
                MessageBox.Show("Excepción: " + ex.Message);
                MessageBox.Show("Detalle: " + ex);
            }
        }

        private void btnThrowHandledCast_Click(object sender, EventArgs e)
        {
            try
            {
                throw new InvalidCastException();
            }
            catch (InvalidCastException ex)
            {
                MessageBox.Show("Excepción: " + ex.Message);
                MessageBox.Show("Detalle: " + ex);
            }
        }

        private void btnThrowHandledInvalid_Click(object sender, EventArgs e)
        {
            try
            {
                throw new InvalidOperationException();
            }
            catch (InvalidOperationException ex)
            {
                MessageBox.Show("Excepción: " + ex.Message);
                MessageBox.Show("Detalle: " + ex);
            }
        }

        private void btnThrowHandledDivide_Click(object sender, EventArgs e)
        {
            try
            {
                throw new DivideByZeroException();
            }
            catch (DivideByZeroException ex)
            {
                MessageBox.Show("Excepción: " + ex.Message);
                MessageBox.Show("Detalle: " + ex);
            }
        }
    }
}
