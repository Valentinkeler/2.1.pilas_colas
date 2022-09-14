namespace _2._1.pilas_colas
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
            this.estaVacio = new System.Windows.Forms.Button();
            this.rbtTrue = new System.Windows.Forms.RadioButton();
            this.rbtFalse = new System.Windows.Forms.RadioButton();
            this.button2 = new System.Windows.Forms.Button();
            this.txtPrimero = new System.Windows.Forms.TextBox();
            this.button3 = new System.Windows.Forms.Button();
            this.txtAnadir = new System.Windows.Forms.TextBox();
            this.button4 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // estaVacio
            // 
            this.estaVacio.Location = new System.Drawing.Point(188, 43);
            this.estaVacio.Name = "estaVacio";
            this.estaVacio.Size = new System.Drawing.Size(75, 23);
            this.estaVacio.TabIndex = 0;
            this.estaVacio.Text = "estaVacio";
            this.estaVacio.UseVisualStyleBackColor = true;
            this.estaVacio.Click += new System.EventHandler(this.estaVacio_Click);
            // 
            // rbtTrue
            // 
            this.rbtTrue.AutoSize = true;
            this.rbtTrue.Location = new System.Drawing.Point(282, 43);
            this.rbtTrue.Name = "rbtTrue";
            this.rbtTrue.Size = new System.Drawing.Size(43, 17);
            this.rbtTrue.TabIndex = 1;
            this.rbtTrue.TabStop = true;
            this.rbtTrue.Text = "true";
            this.rbtTrue.UseVisualStyleBackColor = true;
            // 
            // rbtFalse
            // 
            this.rbtFalse.AutoSize = true;
            this.rbtFalse.Location = new System.Drawing.Point(366, 43);
            this.rbtFalse.Name = "rbtFalse";
            this.rbtFalse.Size = new System.Drawing.Size(47, 17);
            this.rbtFalse.TabIndex = 2;
            this.rbtFalse.TabStop = true;
            this.rbtFalse.Text = "false";
            this.rbtFalse.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(82, 118);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 3;
            this.button2.Text = "extraer";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // txtPrimero
            // 
            this.txtPrimero.Location = new System.Drawing.Point(208, 158);
            this.txtPrimero.Name = "txtPrimero";
            this.txtPrimero.Size = new System.Drawing.Size(100, 20);
            this.txtPrimero.TabIndex = 6;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(82, 189);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 5;
            this.button3.Text = "primero";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // txtAnadir
            // 
            this.txtAnadir.Location = new System.Drawing.Point(527, 119);
            this.txtAnadir.Name = "txtAnadir";
            this.txtAnadir.Size = new System.Drawing.Size(100, 20);
            this.txtAnadir.TabIndex = 8;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(395, 117);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 23);
            this.button4.TabIndex = 7;
            this.button4.Text = "añadir";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(701, 308);
            this.Controls.Add(this.txtAnadir);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.txtPrimero);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.rbtFalse);
            this.Controls.Add(this.rbtTrue);
            this.Controls.Add(this.estaVacio);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button estaVacio;
        private System.Windows.Forms.RadioButton rbtTrue;
        private System.Windows.Forms.RadioButton rbtFalse;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox txtPrimero;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.TextBox txtAnadir;
        private System.Windows.Forms.Button button4;
    }
}

