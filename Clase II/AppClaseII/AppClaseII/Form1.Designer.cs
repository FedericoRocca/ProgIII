namespace AppClaseII
{
    partial class Form1
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
            this.txtNro1 = new System.Windows.Forms.TextBox();
            this.TxtNro2 = new System.Windows.Forms.TextBox();
            this.btnDividir = new System.Windows.Forms.Button();
            this.lblNro1 = new System.Windows.Forms.Label();
            this.lblNro2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtNro1
            // 
            this.txtNro1.Location = new System.Drawing.Point(53, 9);
            this.txtNro1.Name = "txtNro1";
            this.txtNro1.Size = new System.Drawing.Size(100, 20);
            this.txtNro1.TabIndex = 0;
            // 
            // TxtNro2
            // 
            this.TxtNro2.Location = new System.Drawing.Point(53, 45);
            this.TxtNro2.Name = "TxtNro2";
            this.TxtNro2.Size = new System.Drawing.Size(100, 20);
            this.TxtNro2.TabIndex = 1;
            // 
            // btnDividir
            // 
            this.btnDividir.Location = new System.Drawing.Point(66, 71);
            this.btnDividir.Name = "btnDividir";
            this.btnDividir.Size = new System.Drawing.Size(75, 23);
            this.btnDividir.TabIndex = 2;
            this.btnDividir.Text = "Dividir";
            this.btnDividir.UseVisualStyleBackColor = true;
            this.btnDividir.Click += new System.EventHandler(this.BtnDividir_Click);
            // 
            // lblNro1
            // 
            this.lblNro1.AutoSize = true;
            this.lblNro1.Location = new System.Drawing.Point(12, 12);
            this.lblNro1.Name = "lblNro1";
            this.lblNro1.Size = new System.Drawing.Size(30, 13);
            this.lblNro1.TabIndex = 3;
            this.lblNro1.Text = "Nro1";
            // 
            // lblNro2
            // 
            this.lblNro2.AutoSize = true;
            this.lblNro2.Location = new System.Drawing.Point(12, 48);
            this.lblNro2.Name = "lblNro2";
            this.lblNro2.Size = new System.Drawing.Size(30, 13);
            this.lblNro2.TabIndex = 4;
            this.lblNro2.Text = "Nro2";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblNro2);
            this.Controls.Add(this.lblNro1);
            this.Controls.Add(this.btnDividir);
            this.Controls.Add(this.TxtNro2);
            this.Controls.Add(this.txtNro1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtNro1;
        private System.Windows.Forms.TextBox TxtNro2;
        private System.Windows.Forms.Button btnDividir;
        private System.Windows.Forms.Label lblNro1;
        private System.Windows.Forms.Label lblNro2;
    }
}

