namespace Evidencia3
{
    partial class Registrarse
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
            this.Registro = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.CorreoRegistro = new System.Windows.Forms.TextBox();
            this.Contraseña = new System.Windows.Forms.TextBox();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // Registro
            // 
            this.Registro.Location = new System.Drawing.Point(349, 320);
            this.Registro.Name = "Registro";
            this.Registro.Size = new System.Drawing.Size(75, 23);
            this.Registro.TabIndex = 0;
            this.Registro.Text = "Registrate";
            this.Registro.UseVisualStyleBackColor = true;
            this.Registro.Click += new System.EventHandler(this.Registro_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(364, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Registrarse";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(364, 110);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Correo";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(346, 201);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Contraseña";
            // 
            // CorreoRegistro
            // 
            this.CorreoRegistro.Location = new System.Drawing.Point(335, 146);
            this.CorreoRegistro.Name = "CorreoRegistro";
            this.CorreoRegistro.Size = new System.Drawing.Size(100, 20);
            this.CorreoRegistro.TabIndex = 4;
            this.CorreoRegistro.TextChanged += new System.EventHandler(this.CorreoRegistro_TextChanged);
            // 
            // Contraseña
            // 
            this.Contraseña.Location = new System.Drawing.Point(335, 230);
            this.Contraseña.Name = "Contraseña";
            this.Contraseña.Size = new System.Drawing.Size(100, 20);
            this.Contraseña.TabIndex = 5;
            this.Contraseña.TextChanged += new System.EventHandler(this.Contraseña_TextChanged);
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Location = new System.Drawing.Point(316, 363);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(162, 13);
            this.linkLabel1.TabIndex = 6;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "¿Ya tienes cuenta? Inicia Sesion";
            // 
            // Registrarse
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.Contraseña);
            this.Controls.Add(this.CorreoRegistro);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Registro);
            this.Name = "Registrarse";
            this.Text = "Registrarse";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Registro;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox CorreoRegistro;
        private System.Windows.Forms.TextBox Contraseña;
        private System.Windows.Forms.LinkLabel linkLabel1;
    }
}