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
            this.RAD_Masculino = new System.Windows.Forms.RadioButton();
            this.RAD_Femenino = new System.Windows.Forms.RadioButton();
            this.GRO_EstadoCivil = new System.Windows.Forms.GroupBox();
            this.RAD_Soltero = new System.Windows.Forms.RadioButton();
            this.RAD_Casado = new System.Windows.Forms.RadioButton();
            this.CHE_Puesto = new System.Windows.Forms.CheckedListBox();
            this.BTN_Borrar = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lblGender = new System.Windows.Forms.Label();
            this.lblIsMarried = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblTask = new System.Windows.Forms.Label();
            this.GRO_Sexo.SuspendLayout();
            this.GRO_EstadoCivil.SuspendLayout();
            this.SuspendLayout();
            // 
            // GRO_Sexo
            // 
            this.GRO_Sexo.Controls.Add(this.RAD_Masculino);
            this.GRO_Sexo.Controls.Add(this.RAD_Femenino);
            this.GRO_Sexo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GRO_Sexo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.GRO_Sexo.Location = new System.Drawing.Point(32, 28);
            this.GRO_Sexo.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.GRO_Sexo.Name = "GRO_Sexo";
            this.GRO_Sexo.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.GRO_Sexo.Size = new System.Drawing.Size(187, 119);
            this.GRO_Sexo.TabIndex = 0;
            this.GRO_Sexo.TabStop = false;
            this.GRO_Sexo.Text = "Sexo";
            // 
            // RAD_Masculino
            // 
            this.RAD_Masculino.AutoSize = true;
            this.RAD_Masculino.Location = new System.Drawing.Point(50, 73);
            this.RAD_Masculino.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.RAD_Masculino.Name = "RAD_Masculino";
            this.RAD_Masculino.Size = new System.Drawing.Size(98, 21);
            this.RAD_Masculino.TabIndex = 1;
            this.RAD_Masculino.Text = "Masculino";
            this.RAD_Masculino.UseVisualStyleBackColor = true;
            // 
            // RAD_Femenino
            // 
            this.RAD_Femenino.AutoSize = true;
            this.RAD_Femenino.Checked = true;
            this.RAD_Femenino.Location = new System.Drawing.Point(50, 37);
            this.RAD_Femenino.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.RAD_Femenino.Name = "RAD_Femenino";
            this.RAD_Femenino.Size = new System.Drawing.Size(96, 21);
            this.RAD_Femenino.TabIndex = 0;
            this.RAD_Femenino.TabStop = true;
            this.RAD_Femenino.Text = "Femenino";
            this.RAD_Femenino.UseVisualStyleBackColor = true;
            // 
            // GRO_EstadoCivil
            // 
            this.GRO_EstadoCivil.Controls.Add(this.RAD_Soltero);
            this.GRO_EstadoCivil.Controls.Add(this.RAD_Casado);
            this.GRO_EstadoCivil.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GRO_EstadoCivil.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.GRO_EstadoCivil.Location = new System.Drawing.Point(380, 28);
            this.GRO_EstadoCivil.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.GRO_EstadoCivil.Name = "GRO_EstadoCivil";
            this.GRO_EstadoCivil.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.GRO_EstadoCivil.Size = new System.Drawing.Size(187, 119);
            this.GRO_EstadoCivil.TabIndex = 1;
            this.GRO_EstadoCivil.TabStop = false;
            this.GRO_EstadoCivil.Text = "Estado Civil";
            // 
            // RAD_Soltero
            // 
            this.RAD_Soltero.AutoSize = true;
            this.RAD_Soltero.Location = new System.Drawing.Point(58, 73);
            this.RAD_Soltero.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.RAD_Soltero.Name = "RAD_Soltero";
            this.RAD_Soltero.Size = new System.Drawing.Size(78, 21);
            this.RAD_Soltero.TabIndex = 1;
            this.RAD_Soltero.Text = "Soltero";
            this.RAD_Soltero.UseVisualStyleBackColor = true;
            // 
            // RAD_Casado
            // 
            this.RAD_Casado.AutoSize = true;
            this.RAD_Casado.Checked = true;
            this.RAD_Casado.Location = new System.Drawing.Point(58, 37);
            this.RAD_Casado.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.RAD_Casado.Name = "RAD_Casado";
            this.RAD_Casado.Size = new System.Drawing.Size(80, 21);
            this.RAD_Casado.TabIndex = 0;
            this.RAD_Casado.TabStop = true;
            this.RAD_Casado.Text = "Casado";
            this.RAD_Casado.UseVisualStyleBackColor = true;
            // 
            // CHE_Puesto
            // 
            this.CHE_Puesto.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(29)))), ((int)(((byte)(36)))));
            this.CHE_Puesto.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CHE_Puesto.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.CHE_Puesto.FormattingEnabled = true;
            this.CHE_Puesto.Items.AddRange(new object[] {
            "Operador de PC",
            "Data Entry",
            "Programador",
            "Reparador de PC",
            "Tester"});
            this.CHE_Puesto.Location = new System.Drawing.Point(208, 164);
            this.CHE_Puesto.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.CHE_Puesto.Name = "CHE_Puesto";
            this.CHE_Puesto.Size = new System.Drawing.Size(188, 100);
            this.CHE_Puesto.TabIndex = 3;
            // 
            // BTN_Borrar
            // 
            this.BTN_Borrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTN_Borrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTN_Borrar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.BTN_Borrar.Location = new System.Drawing.Point(445, 421);
            this.BTN_Borrar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.BTN_Borrar.Name = "BTN_Borrar";
            this.BTN_Borrar.Size = new System.Drawing.Size(122, 41);
            this.BTN_Borrar.TabIndex = 2;
            this.BTN_Borrar.Text = "Borrar";
            this.BTN_Borrar.UseVisualStyleBackColor = true;
            this.BTN_Borrar.Click += new System.EventHandler(this.BTN_Borrar_Click);
            // 
            // button1
            // 
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.button1.Location = new System.Drawing.Point(32, 421);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(122, 41);
            this.button1.TabIndex = 4;
            this.button1.Text = "Mostrar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(201, 284);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(209, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Usted selecciono los siguientes elementos:";
            // 
            // lblGender
            // 
            this.lblGender.AutoSize = true;
            this.lblGender.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblGender.Location = new System.Drawing.Point(201, 308);
            this.lblGender.Name = "lblGender";
            this.lblGender.Size = new System.Drawing.Size(34, 13);
            this.lblGender.TabIndex = 6;
            this.lblGender.Text = "Sexo:";
            // 
            // lblIsMarried
            // 
            this.lblIsMarried.AutoSize = true;
            this.lblIsMarried.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblIsMarried.Location = new System.Drawing.Point(201, 336);
            this.lblIsMarried.Name = "lblIsMarried";
            this.lblIsMarried.Size = new System.Drawing.Size(68, 13);
            this.lblIsMarried.TabIndex = 7;
            this.lblIsMarried.Text = "Estado Civil: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label2.Location = new System.Drawing.Point(201, 363);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Funciones:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // lblTask
            // 
            this.lblTask.AutoSize = true;
            this.lblTask.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblTask.Location = new System.Drawing.Point(201, 385);
            this.lblTask.Name = "lblTask";
            this.lblTask.Size = new System.Drawing.Size(0, 13);
            this.lblTask.TabIndex = 9;
            // 
            // Form_Ejercicio_3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(29)))), ((int)(((byte)(36)))));
            this.ClientSize = new System.Drawing.Size(600, 487);
            this.Controls.Add(this.lblTask);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblIsMarried);
            this.Controls.Add(this.lblGender);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.BTN_Borrar);
            this.Controls.Add(this.CHE_Puesto);
            this.Controls.Add(this.GRO_EstadoCivil);
            this.Controls.Add(this.GRO_Sexo);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
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
            this.PerformLayout();

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
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblGender;
        private System.Windows.Forms.Label lblIsMarried;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblTask;
    }
}