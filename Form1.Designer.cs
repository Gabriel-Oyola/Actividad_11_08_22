namespace Actividad_11_08_22
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblEdad = new System.Windows.Forms.Label();
            this.txt_Nombre = new System.Windows.Forms.TextBox();
            this.txtDni = new System.Windows.Forms.TextBox();
            this.btPersona = new System.Windows.Forms.Button();
            this.btEdad = new System.Windows.Forms.Button();
            this.txtFecha = new System.Windows.Forms.MaskedTextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(13, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nombre: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(28, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "D.N.I:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(2, 120);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(147, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "F.De Nacimiento:";
            // 
            // lblEdad
            // 
            this.lblEdad.AutoSize = true;
            this.lblEdad.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEdad.Location = new System.Drawing.Point(143, 197);
            this.lblEdad.Name = "lblEdad";
            this.lblEdad.Size = new System.Drawing.Size(57, 20);
            this.lblEdad.TabIndex = 3;
            this.lblEdad.Text = "label4";
            // 
            // txt_Nombre
            // 
            this.txt_Nombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Nombre.Location = new System.Drawing.Point(100, 24);
            this.txt_Nombre.Name = "txt_Nombre";
            this.txt_Nombre.Size = new System.Drawing.Size(100, 26);
            this.txt_Nombre.TabIndex = 4;
            this.txt_Nombre.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_Nombre_KeyPress);
            // 
            // txtDni
            // 
            this.txtDni.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDni.Location = new System.Drawing.Point(100, 68);
            this.txtDni.Name = "txtDni";
            this.txtDni.Size = new System.Drawing.Size(100, 26);
            this.txtDni.TabIndex = 5;
            this.txtDni.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtDni_KeyPress);
            // 
            // btPersona
            // 
            this.btPersona.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btPersona.Location = new System.Drawing.Point(241, 20);
            this.btPersona.Name = "btPersona";
            this.btPersona.Size = new System.Drawing.Size(114, 32);
            this.btPersona.TabIndex = 7;
            this.btPersona.Text = "Cargar";
            this.btPersona.UseVisualStyleBackColor = true;
            this.btPersona.Click += new System.EventHandler(this.btPersona_Click);
            // 
            // btEdad
            // 
            this.btEdad.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btEdad.Location = new System.Drawing.Point(241, 68);
            this.btEdad.Name = "btEdad";
            this.btEdad.Size = new System.Drawing.Size(114, 32);
            this.btEdad.TabIndex = 8;
            this.btEdad.Text = "Edad";
            this.btEdad.UseVisualStyleBackColor = true;
            this.btEdad.Click += new System.EventHandler(this.btEdad_Click);
            // 
            // txtFecha
            // 
            this.txtFecha.Location = new System.Drawing.Point(155, 120);
            this.txtFecha.Mask = "99/99/9999";
            this.txtFecha.Name = "txtFecha";
            this.txtFecha.Size = new System.Drawing.Size(115, 20);
            this.txtFecha.TabIndex = 9;
            this.txtFecha.ValidatingType = typeof(System.DateTime);
            this.txtFecha.Validated += new System.EventHandler(this.txtFecha_Validated);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(385, 255);
            this.Controls.Add(this.txtFecha);
            this.Controls.Add(this.btEdad);
            this.Controls.Add(this.btPersona);
            this.Controls.Add(this.txtDni);
            this.Controls.Add(this.txt_Nombre);
            this.Controls.Add(this.lblEdad);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblEdad;
        private System.Windows.Forms.TextBox txt_Nombre;
        private System.Windows.Forms.TextBox txtDni;
        private System.Windows.Forms.Button btPersona;
        private System.Windows.Forms.Button btEdad;
        private System.Windows.Forms.MaskedTextBox txtFecha;
    }
}

