namespace TP_1
{
    partial class Form_Ejercicio_2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.GRO_IngresoDatos = new System.Windows.Forms.GroupBox();
            this.GRO_Elementos = new System.Windows.Forms.GroupBox();
            this.LBL_Nombre = new System.Windows.Forms.Label();
            this.LBL_Apellido = new System.Windows.Forms.Label();
            this.TXT_Nombre = new System.Windows.Forms.TextBox();
            this.TXT_Apellido = new System.Windows.Forms.TextBox();
            this.BTN_Agregar = new System.Windows.Forms.Button();
            this.LST_Elementos = new System.Windows.Forms.ListBox();
            this.BTN_Borrar = new System.Windows.Forms.Button();
            this.GRO_IngresoDatos.SuspendLayout();
            this.GRO_Elementos.SuspendLayout();
            this.SuspendLayout();
            // 
            // GRO_IngresoDatos
            // 
            this.GRO_IngresoDatos.Controls.Add(this.BTN_Agregar);
            this.GRO_IngresoDatos.Controls.Add(this.TXT_Apellido);
            this.GRO_IngresoDatos.Controls.Add(this.TXT_Nombre);
            this.GRO_IngresoDatos.Controls.Add(this.LBL_Apellido);
            this.GRO_IngresoDatos.Controls.Add(this.LBL_Nombre);
            this.GRO_IngresoDatos.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GRO_IngresoDatos.Location = new System.Drawing.Point(43, 12);
            this.GRO_IngresoDatos.Name = "GRO_IngresoDatos";
            this.GRO_IngresoDatos.Size = new System.Drawing.Size(347, 426);
            this.GRO_IngresoDatos.TabIndex = 0;
            this.GRO_IngresoDatos.TabStop = false;
            this.GRO_IngresoDatos.Text = "Ingreso de Datos";
            this.GRO_IngresoDatos.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // GRO_Elementos
            // 
            this.GRO_Elementos.Controls.Add(this.BTN_Borrar);
            this.GRO_Elementos.Controls.Add(this.LST_Elementos);
            this.GRO_Elementos.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GRO_Elementos.Location = new System.Drawing.Point(417, 12);
            this.GRO_Elementos.Name = "GRO_Elementos";
            this.GRO_Elementos.Size = new System.Drawing.Size(347, 426);
            this.GRO_Elementos.TabIndex = 1;
            this.GRO_Elementos.TabStop = false;
            this.GRO_Elementos.Text = "Elementos";
            // 
            // LBL_Nombre
            // 
            this.LBL_Nombre.AutoSize = true;
            this.LBL_Nombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBL_Nombre.Location = new System.Drawing.Point(6, 223);
            this.LBL_Nombre.Name = "LBL_Nombre";
            this.LBL_Nombre.Size = new System.Drawing.Size(73, 20);
            this.LBL_Nombre.TabIndex = 0;
            this.LBL_Nombre.Text = "Nombre:";
            // 
            // LBL_Apellido
            // 
            this.LBL_Apellido.AutoSize = true;
            this.LBL_Apellido.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBL_Apellido.Location = new System.Drawing.Point(6, 265);
            this.LBL_Apellido.Name = "LBL_Apellido";
            this.LBL_Apellido.Size = new System.Drawing.Size(73, 20);
            this.LBL_Apellido.TabIndex = 1;
            this.LBL_Apellido.Text = "Apellido:";
            this.LBL_Apellido.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // TXT_Nombre
            // 
            this.TXT_Nombre.Location = new System.Drawing.Point(95, 216);
            this.TXT_Nombre.Name = "TXT_Nombre";
            this.TXT_Nombre.Size = new System.Drawing.Size(246, 30);
            this.TXT_Nombre.TabIndex = 2;
            // 
            // TXT_Apellido
            // 
            this.TXT_Apellido.Location = new System.Drawing.Point(95, 258);
            this.TXT_Apellido.Name = "TXT_Apellido";
            this.TXT_Apellido.Size = new System.Drawing.Size(246, 30);
            this.TXT_Apellido.TabIndex = 3;
            // 
            // BTN_Agregar
            // 
            this.BTN_Agregar.Location = new System.Drawing.Point(175, 376);
            this.BTN_Agregar.Name = "BTN_Agregar";
            this.BTN_Agregar.Size = new System.Drawing.Size(166, 44);
            this.BTN_Agregar.TabIndex = 4;
            this.BTN_Agregar.Text = "Agregar";
            this.BTN_Agregar.UseVisualStyleBackColor = true;
            // 
            // LST_Elementos
            // 
            this.LST_Elementos.FormattingEnabled = true;
            this.LST_Elementos.ItemHeight = 25;
            this.LST_Elementos.Location = new System.Drawing.Point(6, 40);
            this.LST_Elementos.Name = "LST_Elementos";
            this.LST_Elementos.Size = new System.Drawing.Size(335, 304);
            this.LST_Elementos.TabIndex = 0;
            // 
            // BTN_Borrar
            // 
            this.BTN_Borrar.Location = new System.Drawing.Point(175, 376);
            this.BTN_Borrar.Name = "BTN_Borrar";
            this.BTN_Borrar.Size = new System.Drawing.Size(166, 44);
            this.BTN_Borrar.TabIndex = 1;
            this.BTN_Borrar.Text = "Borrar";
            this.BTN_Borrar.UseVisualStyleBackColor = true;
            // 
            // Form_Ejercicio_2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.GRO_Elementos);
            this.Controls.Add(this.GRO_IngresoDatos);
            this.Name = "Form_Ejercicio_2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ejercicio 2";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form_Ejercicio_2_FormClosed);
            this.GRO_IngresoDatos.ResumeLayout(false);
            this.GRO_IngresoDatos.PerformLayout();
            this.GRO_Elementos.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox GRO_IngresoDatos;
        private System.Windows.Forms.GroupBox GRO_Elementos;
        private System.Windows.Forms.Label LBL_Apellido;
        private System.Windows.Forms.Label LBL_Nombre;
        private System.Windows.Forms.TextBox TXT_Nombre;
        private System.Windows.Forms.TextBox TXT_Apellido;
        private System.Windows.Forms.Button BTN_Agregar;
        private System.Windows.Forms.Button BTN_Borrar;
        private System.Windows.Forms.ListBox LST_Elementos;
    }
}