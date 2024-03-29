namespace TP_1
{
    partial class Form_Ejercicio_3
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
            this.GRO_Sexo = new System.Windows.Forms.GroupBox();
            this.GRO_EstadoCivil = new System.Windows.Forms.GroupBox();
            this.RAD_Femenino = new System.Windows.Forms.RadioButton();
            this.RAD_Masculino = new System.Windows.Forms.RadioButton();
            this.RAD_Casado = new System.Windows.Forms.RadioButton();
            this.RAD_Soltero = new System.Windows.Forms.RadioButton();
            this.CHE_Puesto = new System.Windows.Forms.CheckedListBox();
            this.BTN_Borrar = new System.Windows.Forms.Button();
            this.GRO_Sexo.SuspendLayout();
            this.GRO_EstadoCivil.SuspendLayout();
            this.SuspendLayout();
            // 
            // GRO_Sexo
            // 
            this.GRO_Sexo.Controls.Add(this.RAD_Masculino);
            this.GRO_Sexo.Controls.Add(this.RAD_Femenino);
            this.GRO_Sexo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GRO_Sexo.Location = new System.Drawing.Point(42, 34);
            this.GRO_Sexo.Name = "GRO_Sexo";
            this.GRO_Sexo.Size = new System.Drawing.Size(249, 147);
            this.GRO_Sexo.TabIndex = 0;
            this.GRO_Sexo.TabStop = false;
            this.GRO_Sexo.Text = "Sexo";
            // 
            // GRO_EstadoCivil
            // 
            this.GRO_EstadoCivil.Controls.Add(this.RAD_Soltero);
            this.GRO_EstadoCivil.Controls.Add(this.RAD_Casado);
            this.GRO_EstadoCivil.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GRO_EstadoCivil.Location = new System.Drawing.Point(507, 34);
            this.GRO_EstadoCivil.Name = "GRO_EstadoCivil";
            this.GRO_EstadoCivil.Size = new System.Drawing.Size(249, 147);
            this.GRO_EstadoCivil.TabIndex = 1;
            this.GRO_EstadoCivil.TabStop = false;
            this.GRO_EstadoCivil.Text = "Estado Civil";
            // 
            // RAD_Femenino
            // 
            this.RAD_Femenino.AutoSize = true;
            this.RAD_Femenino.Location = new System.Drawing.Point(67, 45);
            this.RAD_Femenino.Name = "RAD_Femenino";
            this.RAD_Femenino.Size = new System.Drawing.Size(111, 24);
            this.RAD_Femenino.TabIndex = 0;
            this.RAD_Femenino.TabStop = true;
            this.RAD_Femenino.Text = "Femenino";
            this.RAD_Femenino.UseVisualStyleBackColor = true;
            // 
            // RAD_Masculino
            // 
            this.RAD_Masculino.AutoSize = true;
            this.RAD_Masculino.Location = new System.Drawing.Point(67, 90);
            this.RAD_Masculino.Name = "RAD_Masculino";
            this.RAD_Masculino.Size = new System.Drawing.Size(115, 24);
            this.RAD_Masculino.TabIndex = 1;
            this.RAD_Masculino.TabStop = true;
            this.RAD_Masculino.Text = "Masculino";
            this.RAD_Masculino.UseVisualStyleBackColor = true;
            // 
            // RAD_Casado
            // 
            this.RAD_Casado.AutoSize = true;
            this.RAD_Casado.Location = new System.Drawing.Point(77, 45);
            this.RAD_Casado.Name = "RAD_Casado";
            this.RAD_Casado.Size = new System.Drawing.Size(93, 24);
            this.RAD_Casado.TabIndex = 0;
            this.RAD_Casado.TabStop = true;
            this.RAD_Casado.Text = "Casado";
            this.RAD_Casado.UseVisualStyleBackColor = true;
            // 
            // RAD_Soltero
            // 
            this.RAD_Soltero.AutoSize = true;
            this.RAD_Soltero.Location = new System.Drawing.Point(77, 90);
            this.RAD_Soltero.Name = "RAD_Soltero";
            this.RAD_Soltero.Size = new System.Drawing.Size(90, 24);
            this.RAD_Soltero.TabIndex = 1;
            this.RAD_Soltero.TabStop = true;
            this.RAD_Soltero.Text = "Soltero";
            this.RAD_Soltero.UseVisualStyleBackColor = true;
            // 
            // CHE_Puesto
            // 
            this.CHE_Puesto.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.CHE_Puesto.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CHE_Puesto.FormattingEnabled = true;
            this.CHE_Puesto.Location = new System.Drawing.Point(278, 202);
            this.CHE_Puesto.Name = "CHE_Puesto";
            this.CHE_Puesto.Size = new System.Drawing.Size(249, 140);
            this.CHE_Puesto.TabIndex = 3;
            // 
            // BTN_Borrar
            // 
            this.BTN_Borrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTN_Borrar.Location = new System.Drawing.Point(593, 379);
            this.BTN_Borrar.Name = "BTN_Borrar";
            this.BTN_Borrar.Size = new System.Drawing.Size(163, 50);
            this.BTN_Borrar.TabIndex = 2;
            this.BTN_Borrar.Text = "Borrar";
            this.BTN_Borrar.UseVisualStyleBackColor = true;
            // 
            // Form_Ejercicio_3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.BTN_Borrar);
            this.Controls.Add(this.CHE_Puesto);
            this.Controls.Add(this.GRO_EstadoCivil);
            this.Controls.Add(this.GRO_Sexo);
            this.Name = "Form_Ejercicio_3";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ejercicio 3";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form_Ejercicio_3_FormClosed);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.GRO_Sexo.ResumeLayout(false);
            this.GRO_Sexo.PerformLayout();
            this.GRO_EstadoCivil.ResumeLayout(false);
            this.GRO_EstadoCivil.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox GRO_Sexo;
        private System.Windows.Forms.RadioButton RAD_Masculino;
        private System.Windows.Forms.RadioButton RAD_Femenino;
        private System.Windows.Forms.GroupBox GRO_EstadoCivil;
        private System.Windows.Forms.RadioButton RAD_Soltero;
        private System.Windows.Forms.RadioButton RAD_Casado;
        private System.Windows.Forms.CheckedListBox CHE_Puesto;
        private System.Windows.Forms.Button BTN_Borrar;
    }
}