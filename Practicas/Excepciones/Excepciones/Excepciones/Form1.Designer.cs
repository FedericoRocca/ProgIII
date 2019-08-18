namespace Excepciones
{
    partial class frmExcepciones
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
            this.btnThrowOutOfRange = new System.Windows.Forms.Button();
            this.btnThrowInvalid = new System.Windows.Forms.Button();
            this.btnThrowWeb = new System.Windows.Forms.Button();
            this.btnThrowStack = new System.Windows.Forms.Button();
            this.btnThrowCast = new System.Windows.Forms.Button();
            this.btnThrowMemory = new System.Windows.Forms.Button();
            this.btnThrowDivide = new System.Windows.Forms.Button();
            this.btnThrowIO = new System.Windows.Forms.Button();
            this.lblHundandledExceptions = new System.Windows.Forms.Label();
            this.lblHandledExceptions = new System.Windows.Forms.Label();
            this.btnThrowHandledIO = new System.Windows.Forms.Button();
            this.btnThrowHandledDivide = new System.Windows.Forms.Button();
            this.btnThrowHandledMemory = new System.Windows.Forms.Button();
            this.btnThrowHandledCast = new System.Windows.Forms.Button();
            this.btnThrowHandledStack = new System.Windows.Forms.Button();
            this.btnThrowHandledWeb = new System.Windows.Forms.Button();
            this.btnThrowHandledInvalid = new System.Windows.Forms.Button();
            this.btnThrowHandledOutOfRange = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnThrowOutOfRange
            // 
            this.btnThrowOutOfRange.Location = new System.Drawing.Point(12, 25);
            this.btnThrowOutOfRange.Name = "btnThrowOutOfRange";
            this.btnThrowOutOfRange.Size = new System.Drawing.Size(148, 23);
            this.btnThrowOutOfRange.TabIndex = 0;
            this.btnThrowOutOfRange.Text = "IndexOutOfRangeException";
            this.btnThrowOutOfRange.UseVisualStyleBackColor = true;
            this.btnThrowOutOfRange.Click += new System.EventHandler(this.btnThrowOutOfRange_Click);
            // 
            // btnThrowInvalid
            // 
            this.btnThrowInvalid.Location = new System.Drawing.Point(12, 199);
            this.btnThrowInvalid.Name = "btnThrowInvalid";
            this.btnThrowInvalid.Size = new System.Drawing.Size(148, 23);
            this.btnThrowInvalid.TabIndex = 3;
            this.btnThrowInvalid.Text = "InvalidOperationException";
            this.btnThrowInvalid.UseVisualStyleBackColor = true;
            this.btnThrowInvalid.Click += new System.EventHandler(this.btnThrowInvalid_Click);
            // 
            // btnThrowWeb
            // 
            this.btnThrowWeb.Location = new System.Drawing.Point(12, 83);
            this.btnThrowWeb.Name = "btnThrowWeb";
            this.btnThrowWeb.Size = new System.Drawing.Size(148, 23);
            this.btnThrowWeb.TabIndex = 7;
            this.btnThrowWeb.Text = "Net.WebException";
            this.btnThrowWeb.UseVisualStyleBackColor = true;
            this.btnThrowWeb.Click += new System.EventHandler(this.btnThrowWeb_Click);
            // 
            // btnThrowStack
            // 
            this.btnThrowStack.Location = new System.Drawing.Point(12, 112);
            this.btnThrowStack.Name = "btnThrowStack";
            this.btnThrowStack.Size = new System.Drawing.Size(148, 23);
            this.btnThrowStack.TabIndex = 8;
            this.btnThrowStack.Text = "StackOverflowException";
            this.btnThrowStack.UseVisualStyleBackColor = true;
            this.btnThrowStack.Click += new System.EventHandler(this.btnThrowStack_Click);
            // 
            // btnThrowCast
            // 
            this.btnThrowCast.Location = new System.Drawing.Point(12, 170);
            this.btnThrowCast.Name = "btnThrowCast";
            this.btnThrowCast.Size = new System.Drawing.Size(148, 23);
            this.btnThrowCast.TabIndex = 12;
            this.btnThrowCast.Text = "InvalidCastException";
            this.btnThrowCast.UseVisualStyleBackColor = true;
            this.btnThrowCast.Click += new System.EventHandler(this.btnThrowCast_Click);
            // 
            // btnThrowMemory
            // 
            this.btnThrowMemory.Location = new System.Drawing.Point(12, 141);
            this.btnThrowMemory.Name = "btnThrowMemory";
            this.btnThrowMemory.Size = new System.Drawing.Size(148, 23);
            this.btnThrowMemory.TabIndex = 13;
            this.btnThrowMemory.Text = "OutOfMemoryException";
            this.btnThrowMemory.UseVisualStyleBackColor = true;
            this.btnThrowMemory.Click += new System.EventHandler(this.btnThrowMemory_Click);
            // 
            // btnThrowDivide
            // 
            this.btnThrowDivide.Location = new System.Drawing.Point(12, 228);
            this.btnThrowDivide.Name = "btnThrowDivide";
            this.btnThrowDivide.Size = new System.Drawing.Size(148, 23);
            this.btnThrowDivide.TabIndex = 19;
            this.btnThrowDivide.Text = "DivideByZeroException";
            this.btnThrowDivide.UseVisualStyleBackColor = true;
            this.btnThrowDivide.Click += new System.EventHandler(this.btnThrowDivide_Click);
            // 
            // btnThrowIO
            // 
            this.btnThrowIO.Location = new System.Drawing.Point(12, 54);
            this.btnThrowIO.Name = "btnThrowIO";
            this.btnThrowIO.Size = new System.Drawing.Size(148, 23);
            this.btnThrowIO.TabIndex = 20;
            this.btnThrowIO.Text = "IO.IOException";
            this.btnThrowIO.UseVisualStyleBackColor = true;
            this.btnThrowIO.Click += new System.EventHandler(this.btnThrowIO_Click);
            // 
            // lblHundandledExceptions
            // 
            this.lblHundandledExceptions.AutoSize = true;
            this.lblHundandledExceptions.Location = new System.Drawing.Point(12, 9);
            this.lblHundandledExceptions.Name = "lblHundandledExceptions";
            this.lblHundandledExceptions.Size = new System.Drawing.Size(114, 13);
            this.lblHundandledExceptions.TabIndex = 25;
            this.lblHundandledExceptions.Text = "Unhandled Exceptions";
            // 
            // lblHandledExceptions
            // 
            this.lblHandledExceptions.AutoSize = true;
            this.lblHandledExceptions.Location = new System.Drawing.Point(197, 9);
            this.lblHandledExceptions.Name = "lblHandledExceptions";
            this.lblHandledExceptions.Size = new System.Drawing.Size(102, 13);
            this.lblHandledExceptions.TabIndex = 26;
            this.lblHandledExceptions.Text = "Handled Exceptions";
            // 
            // btnThrowHandledIO
            // 
            this.btnThrowHandledIO.Location = new System.Drawing.Point(200, 54);
            this.btnThrowHandledIO.Name = "btnThrowHandledIO";
            this.btnThrowHandledIO.Size = new System.Drawing.Size(148, 23);
            this.btnThrowHandledIO.TabIndex = 35;
            this.btnThrowHandledIO.Text = "IO.IOException";
            this.btnThrowHandledIO.UseVisualStyleBackColor = true;
            this.btnThrowHandledIO.Click += new System.EventHandler(this.btnThrowHandledIO_Click);
            // 
            // btnThrowHandledDivide
            // 
            this.btnThrowHandledDivide.Location = new System.Drawing.Point(200, 228);
            this.btnThrowHandledDivide.Name = "btnThrowHandledDivide";
            this.btnThrowHandledDivide.Size = new System.Drawing.Size(148, 23);
            this.btnThrowHandledDivide.TabIndex = 34;
            this.btnThrowHandledDivide.Text = "DivideByZeroException";
            this.btnThrowHandledDivide.UseVisualStyleBackColor = true;
            this.btnThrowHandledDivide.Click += new System.EventHandler(this.btnThrowHandledDivide_Click);
            // 
            // btnThrowHandledMemory
            // 
            this.btnThrowHandledMemory.Location = new System.Drawing.Point(200, 141);
            this.btnThrowHandledMemory.Name = "btnThrowHandledMemory";
            this.btnThrowHandledMemory.Size = new System.Drawing.Size(148, 23);
            this.btnThrowHandledMemory.TabIndex = 32;
            this.btnThrowHandledMemory.Text = "OutOfMemoryException";
            this.btnThrowHandledMemory.UseVisualStyleBackColor = true;
            this.btnThrowHandledMemory.Click += new System.EventHandler(this.btnThrowHandledMemory_Click);
            // 
            // btnThrowHandledCast
            // 
            this.btnThrowHandledCast.Location = new System.Drawing.Point(200, 170);
            this.btnThrowHandledCast.Name = "btnThrowHandledCast";
            this.btnThrowHandledCast.Size = new System.Drawing.Size(148, 23);
            this.btnThrowHandledCast.TabIndex = 31;
            this.btnThrowHandledCast.Text = "InvalidCastException";
            this.btnThrowHandledCast.UseVisualStyleBackColor = true;
            this.btnThrowHandledCast.Click += new System.EventHandler(this.btnThrowHandledCast_Click);
            // 
            // btnThrowHandledStack
            // 
            this.btnThrowHandledStack.Location = new System.Drawing.Point(200, 112);
            this.btnThrowHandledStack.Name = "btnThrowHandledStack";
            this.btnThrowHandledStack.Size = new System.Drawing.Size(148, 23);
            this.btnThrowHandledStack.TabIndex = 30;
            this.btnThrowHandledStack.Text = "StackOverflowException";
            this.btnThrowHandledStack.UseVisualStyleBackColor = true;
            this.btnThrowHandledStack.Click += new System.EventHandler(this.btnThrowHandledStack_Click);
            // 
            // btnThrowHandledWeb
            // 
            this.btnThrowHandledWeb.Location = new System.Drawing.Point(200, 83);
            this.btnThrowHandledWeb.Name = "btnThrowHandledWeb";
            this.btnThrowHandledWeb.Size = new System.Drawing.Size(148, 23);
            this.btnThrowHandledWeb.TabIndex = 29;
            this.btnThrowHandledWeb.Text = "Net.WebException";
            this.btnThrowHandledWeb.UseVisualStyleBackColor = true;
            this.btnThrowHandledWeb.Click += new System.EventHandler(this.btnThrowHandledWeb_Click);
            // 
            // btnThrowHandledInvalid
            // 
            this.btnThrowHandledInvalid.Location = new System.Drawing.Point(200, 199);
            this.btnThrowHandledInvalid.Name = "btnThrowHandledInvalid";
            this.btnThrowHandledInvalid.Size = new System.Drawing.Size(148, 23);
            this.btnThrowHandledInvalid.TabIndex = 28;
            this.btnThrowHandledInvalid.Text = "InvalidOperationException";
            this.btnThrowHandledInvalid.UseVisualStyleBackColor = true;
            this.btnThrowHandledInvalid.Click += new System.EventHandler(this.btnThrowHandledInvalid_Click);
            // 
            // btnThrowHandledOutOfRange
            // 
            this.btnThrowHandledOutOfRange.Location = new System.Drawing.Point(200, 25);
            this.btnThrowHandledOutOfRange.Name = "btnThrowHandledOutOfRange";
            this.btnThrowHandledOutOfRange.Size = new System.Drawing.Size(148, 23);
            this.btnThrowHandledOutOfRange.TabIndex = 27;
            this.btnThrowHandledOutOfRange.Text = "IndexOutOfRangeException";
            this.btnThrowHandledOutOfRange.UseVisualStyleBackColor = true;
            this.btnThrowHandledOutOfRange.Click += new System.EventHandler(this.btnThrowHandledOutOfRange_Click);
            // 
            // frmExcepciones
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(360, 260);
            this.Controls.Add(this.btnThrowHandledIO);
            this.Controls.Add(this.btnThrowHandledDivide);
            this.Controls.Add(this.btnThrowHandledMemory);
            this.Controls.Add(this.btnThrowHandledCast);
            this.Controls.Add(this.btnThrowHandledStack);
            this.Controls.Add(this.btnThrowHandledWeb);
            this.Controls.Add(this.btnThrowHandledInvalid);
            this.Controls.Add(this.btnThrowHandledOutOfRange);
            this.Controls.Add(this.lblHandledExceptions);
            this.Controls.Add(this.lblHundandledExceptions);
            this.Controls.Add(this.btnThrowIO);
            this.Controls.Add(this.btnThrowDivide);
            this.Controls.Add(this.btnThrowMemory);
            this.Controls.Add(this.btnThrowCast);
            this.Controls.Add(this.btnThrowStack);
            this.Controls.Add(this.btnThrowWeb);
            this.Controls.Add(this.btnThrowInvalid);
            this.Controls.Add(this.btnThrowOutOfRange);
            this.Name = "frmExcepciones";
            this.Text = "Practica de excepciones";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnThrowOutOfRange;
        private System.Windows.Forms.Button btnThrowInvalid;
        private System.Windows.Forms.Button btnThrowWeb;
        private System.Windows.Forms.Button btnThrowStack;
        private System.Windows.Forms.Button btnThrowCast;
        private System.Windows.Forms.Button btnThrowMemory;
        private System.Windows.Forms.Button btnThrowDivide;
        private System.Windows.Forms.Button btnThrowIO;
        private System.Windows.Forms.Label lblHundandledExceptions;
        private System.Windows.Forms.Label lblHandledExceptions;
        private System.Windows.Forms.Button btnThrowHandledIO;
        private System.Windows.Forms.Button btnThrowHandledDivide;
        private System.Windows.Forms.Button btnThrowHandledMemory;
        private System.Windows.Forms.Button btnThrowHandledCast;
        private System.Windows.Forms.Button btnThrowHandledStack;
        private System.Windows.Forms.Button btnThrowHandledWeb;
        private System.Windows.Forms.Button btnThrowHandledInvalid;
        private System.Windows.Forms.Button btnThrowHandledOutOfRange;
    }
}

