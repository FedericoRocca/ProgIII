namespace Multiforms
{
    partial class Multiform
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Multiform));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tsbAyuda = new System.Windows.Forms.ToolStripButton();
            this.tsbNuevaVentana = new System.Windows.Forms.ToolStripButton();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbAyuda,
            this.tsbNuevaVentana});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(728, 25);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // tsbAyuda
            // 
            this.tsbAyuda.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbAyuda.Image = ((System.Drawing.Image)(resources.GetObject("tsbAyuda.Image")));
            this.tsbAyuda.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbAyuda.Name = "tsbAyuda";
            this.tsbAyuda.Size = new System.Drawing.Size(23, 22);
            this.tsbAyuda.Text = "Abrir ayuda";
            this.tsbAyuda.Click += new System.EventHandler(this.Ayuda_Click);
            // 
            // tsbNuevaVentana
            // 
            this.tsbNuevaVentana.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbNuevaVentana.Image = ((System.Drawing.Image)(resources.GetObject("tsbNuevaVentana.Image")));
            this.tsbNuevaVentana.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbNuevaVentana.Name = "tsbNuevaVentana";
            this.tsbNuevaVentana.Overflow = System.Windows.Forms.ToolStripItemOverflow.Never;
            this.tsbNuevaVentana.Size = new System.Drawing.Size(23, 22);
            this.tsbNuevaVentana.Text = "Nueva ventana";
            this.tsbNuevaVentana.ToolTipText = "Abrir form en nueva ventana";
            this.tsbNuevaVentana.Click += new System.EventHandler(this.tsbNuevaVentana_Click);
            // 
            // Multiform
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(728, 417);
            this.Controls.Add(this.toolStrip1);
            this.IsMdiContainer = true;
            this.Name = "Multiform";
            this.Text = "Multiforms";
            this.Load += new System.EventHandler(this.Multiform_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton tsbAyuda;
        private System.Windows.Forms.ToolStripButton tsbNuevaVentana;
    }
}

