namespace TP_1
{
    partial class Form_Ejercicio_1
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
            this.LBL_IngresarNombre = new System.Windows.Forms.Label();
            this.TXT_NombreYApellido = new System.Windows.Forms.TextBox();
            this.BTN_Agregar = new System.Windows.Forms.Button();
            this.LST_Lista1 = new System.Windows.Forms.ListBox();
            this.LST_Lista2 = new System.Windows.Forms.ListBox();
            this.BTN_Flecha = new System.Windows.Forms.Button();
            this.BTN_FlechaDoble = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // LBL_IngresarNombre
            // 
            this.LBL_IngresarNombre.AutoSize = true;
            this.LBL_IngresarNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBL_IngresarNombre.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.LBL_IngresarNombre.Location = new System.Drawing.Point(31, 50);
            this.LBL_IngresarNombre.Name = "LBL_IngresarNombre";
            this.LBL_IngresarNombre.Size = new System.Drawing.Size(168, 20);
            this.LBL_IngresarNombre.TabIndex = 0;
            this.LBL_IngresarNombre.Text = "Nombre y Apellido:";
            // 
            // TXT_NombreYApellido
            // 
            this.TXT_NombreYApellido.Location = new System.Drawing.Point(235, 48);
            this.TXT_NombreYApellido.Name = "TXT_NombreYApellido";
            this.TXT_NombreYApellido.Size = new System.Drawing.Size(396, 22);
            this.TXT_NombreYApellido.TabIndex = 1;
            // 
            // BTN_Agregar
            // 
            this.BTN_Agregar.FlatAppearance.BorderSize = 3;
            this.BTN_Agregar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.BTN_Agregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTN_Agregar.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTN_Agregar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.BTN_Agregar.Location = new System.Drawing.Point(649, 42);
            this.BTN_Agregar.Name = "BTN_Agregar";
            this.BTN_Agregar.Size = new System.Drawing.Size(122, 35);
            this.BTN_Agregar.TabIndex = 2;
            this.BTN_Agregar.Text = "Agregar";
            this.BTN_Agregar.UseVisualStyleBackColor = true;
            this.BTN_Agregar.Click += new System.EventHandler(this.BTN_Agregar_Click);
            // 
            // LST_Lista1
            // 
            this.LST_Lista1.FormattingEnabled = true;
            this.LST_Lista1.ItemHeight = 16;
            this.LST_Lista1.Location = new System.Drawing.Point(36, 113);
            this.LST_Lista1.Name = "LST_Lista1";
            this.LST_Lista1.Size = new System.Drawing.Size(256, 292);
            this.LST_Lista1.TabIndex = 3;
            // 
            // LST_Lista2
            // 
            this.LST_Lista2.FormattingEnabled = true;
            this.LST_Lista2.ItemHeight = 16;
            this.LST_Lista2.Location = new System.Drawing.Point(515, 113);
            this.LST_Lista2.Name = "LST_Lista2";
            this.LST_Lista2.Size = new System.Drawing.Size(256, 292);
            this.LST_Lista2.TabIndex = 4;
            // 
            // BTN_Flecha
            // 
            this.BTN_Flecha.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTN_Flecha.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTN_Flecha.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.BTN_Flecha.Location = new System.Drawing.Point(362, 165);
            this.BTN_Flecha.Name = "BTN_Flecha";
            this.BTN_Flecha.Size = new System.Drawing.Size(75, 44);
            this.BTN_Flecha.TabIndex = 5;
            this.BTN_Flecha.Text = ">";
            this.BTN_Flecha.UseVisualStyleBackColor = true;
            this.BTN_Flecha.Click += new System.EventHandler(this.BTN_Flecha_Click);
            // 
            // BTN_FlechaDoble
            // 
            this.BTN_FlechaDoble.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTN_FlechaDoble.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTN_FlechaDoble.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.BTN_FlechaDoble.Location = new System.Drawing.Point(362, 289);
            this.BTN_FlechaDoble.Name = "BTN_FlechaDoble";
            this.BTN_FlechaDoble.Size = new System.Drawing.Size(75, 44);
            this.BTN_FlechaDoble.TabIndex = 6;
            this.BTN_FlechaDoble.Text = ">>";
            this.BTN_FlechaDoble.UseVisualStyleBackColor = true;
            // 
            // Form_Ejercicio_1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(29)))), ((int)(((byte)(36)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.BTN_FlechaDoble);
            this.Controls.Add(this.BTN_Flecha);
            this.Controls.Add(this.LST_Lista2);
            this.Controls.Add(this.LST_Lista1);
            this.Controls.Add(this.BTN_Agregar);
            this.Controls.Add(this.TXT_NombreYApellido);
            this.Controls.Add(this.LBL_IngresarNombre);
            this.Name = "Form_Ejercicio_1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ejercicio 1";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form_Ejercicio_1_FormClosed);
            this.Load += new System.EventHandler(this.Form_Ejercicio_1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LBL_IngresarNombre;
        private System.Windows.Forms.TextBox TXT_NombreYApellido;
        private System.Windows.Forms.Button BTN_Agregar;
        private System.Windows.Forms.ListBox LST_Lista1;
        private System.Windows.Forms.ListBox LST_Lista2;
        private System.Windows.Forms.Button BTN_Flecha;
        private System.Windows.Forms.Button BTN_FlechaDoble;
    }
}