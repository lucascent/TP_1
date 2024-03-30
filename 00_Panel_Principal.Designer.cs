namespace TP_1
{
    partial class Form_Panel_Principal
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
            this.BTN_Ejercicio_1 = new System.Windows.Forms.Button();
            this.BTN_Ejercicio_2 = new System.Windows.Forms.Button();
            this.BTN_Ejercicio_3 = new System.Windows.Forms.Button();
            this.ETI_INTEGRANTES = new System.Windows.Forms.Label();
            this.ETI_LISTA_INTEG = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // BTN_Ejercicio_1
            // 
            this.BTN_Ejercicio_1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(29)))), ((int)(((byte)(36)))));
            this.BTN_Ejercicio_1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTN_Ejercicio_1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTN_Ejercicio_1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.BTN_Ejercicio_1.Location = new System.Drawing.Point(50, 95);
            this.BTN_Ejercicio_1.Name = "BTN_Ejercicio_1";
            this.BTN_Ejercicio_1.Size = new System.Drawing.Size(220, 91);
            this.BTN_Ejercicio_1.TabIndex = 0;
            this.BTN_Ejercicio_1.Text = "EJERCICIO 1";
            this.BTN_Ejercicio_1.UseVisualStyleBackColor = false;
            this.BTN_Ejercicio_1.Click += new System.EventHandler(this.BTN_Ejercicio_1_Click);
            // 
            // BTN_Ejercicio_2
            // 
            this.BTN_Ejercicio_2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTN_Ejercicio_2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTN_Ejercicio_2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.BTN_Ejercicio_2.Location = new System.Drawing.Point(290, 95);
            this.BTN_Ejercicio_2.Name = "BTN_Ejercicio_2";
            this.BTN_Ejercicio_2.Size = new System.Drawing.Size(220, 91);
            this.BTN_Ejercicio_2.TabIndex = 1;
            this.BTN_Ejercicio_2.Text = "EJERCICIO 2";
            this.BTN_Ejercicio_2.UseVisualStyleBackColor = true;
            this.BTN_Ejercicio_2.Click += new System.EventHandler(this.BTN_Ejercicio_2_Click);
            // 
            // BTN_Ejercicio_3
            // 
            this.BTN_Ejercicio_3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTN_Ejercicio_3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTN_Ejercicio_3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.BTN_Ejercicio_3.Location = new System.Drawing.Point(530, 95);
            this.BTN_Ejercicio_3.Name = "BTN_Ejercicio_3";
            this.BTN_Ejercicio_3.Size = new System.Drawing.Size(220, 91);
            this.BTN_Ejercicio_3.TabIndex = 2;
            this.BTN_Ejercicio_3.Text = "EJERCICIO 3";
            this.BTN_Ejercicio_3.UseVisualStyleBackColor = true;
            this.BTN_Ejercicio_3.Click += new System.EventHandler(this.BTN_Ejercicio_3_Click);
            // 
            // ETI_INTEGRANTES
            // 
            this.ETI_INTEGRANTES.AutoSize = true;
            this.ETI_INTEGRANTES.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ETI_INTEGRANTES.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ETI_INTEGRANTES.Location = new System.Drawing.Point(106, 312);
            this.ETI_INTEGRANTES.Name = "ETI_INTEGRANTES";
            this.ETI_INTEGRANTES.Size = new System.Drawing.Size(164, 25);
            this.ETI_INTEGRANTES.TabIndex = 3;
            this.ETI_INTEGRANTES.Text = "INTEGRANTES";
            this.ETI_INTEGRANTES.Click += new System.EventHandler(this.label1_Click);
            // 
            // ETI_LISTA_INTEG
            // 
            this.ETI_LISTA_INTEG.AutoSize = true;
            this.ETI_LISTA_INTEG.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ETI_LISTA_INTEG.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ETI_LISTA_INTEG.Location = new System.Drawing.Point(331, 312);
            this.ETI_LISTA_INTEG.Name = "ETI_LISTA_INTEG";
            this.ETI_LISTA_INTEG.Size = new System.Drawing.Size(179, 100);
            this.ETI_LISTA_INTEG.TabIndex = 6;
            this.ETI_LISTA_INTEG.Text = "Abadín, Adrián\r\nCenturión, Lucas\r\nDi Candia, Enzo\r\nPoderoso, Sergio";
            this.ETI_LISTA_INTEG.Click += new System.EventHandler(this.ETI_LISTA_INTEG_Click);
            // 
            // Form_Panel_Principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(29)))), ((int)(((byte)(36)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.ETI_LISTA_INTEG);
            this.Controls.Add(this.ETI_INTEGRANTES);
            this.Controls.Add(this.BTN_Ejercicio_3);
            this.Controls.Add(this.BTN_Ejercicio_2);
            this.Controls.Add(this.BTN_Ejercicio_1);
            this.Name = "Form_Panel_Principal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Panel Principal";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BTN_Ejercicio_1;
        private System.Windows.Forms.Button BTN_Ejercicio_2;
        private System.Windows.Forms.Button BTN_Ejercicio_3;
        private System.Windows.Forms.Label ETI_INTEGRANTES;
        private System.Windows.Forms.Label ETI_LISTA_INTEG;
    }
}

