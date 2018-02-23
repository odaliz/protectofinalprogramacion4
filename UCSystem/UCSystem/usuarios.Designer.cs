namespace UCSystem
{
    partial class usuarios
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.cbcodempleado = new System.Windows.Forms.ComboBox();
            this.tbusuario = new System.Windows.Forms.TextBox();
            this.cbtiposusuarios = new System.Windows.Forms.ComboBox();
            this.tbclave = new System.Windows.Forms.TextBox();
            this.btnguardarusuario = new System.Windows.Forms.Button();
            this.btncancelar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Código Empleado:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Usuario:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 68);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(31, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Tipo:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 97);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(37, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Clave:";
            // 
            // cbcodempleado
            // 
            this.cbcodempleado.FormattingEnabled = true;
            this.cbcodempleado.Location = new System.Drawing.Point(108, 10);
            this.cbcodempleado.Name = "cbcodempleado";
            this.cbcodempleado.Size = new System.Drawing.Size(73, 21);
            this.cbcodempleado.TabIndex = 5;
            // 
            // tbusuario
            // 
            this.tbusuario.Location = new System.Drawing.Point(57, 37);
            this.tbusuario.Name = "tbusuario";
            this.tbusuario.Size = new System.Drawing.Size(124, 20);
            this.tbusuario.TabIndex = 6;
            // 
            // cbtiposusuarios
            // 
            this.cbtiposusuarios.FormattingEnabled = true;
            this.cbtiposusuarios.Location = new System.Drawing.Point(57, 64);
            this.cbtiposusuarios.Name = "cbtiposusuarios";
            this.cbtiposusuarios.Size = new System.Drawing.Size(124, 21);
            this.cbtiposusuarios.TabIndex = 7;
            // 
            // tbclave
            // 
            this.tbclave.Location = new System.Drawing.Point(56, 93);
            this.tbclave.Name = "tbclave";
            this.tbclave.PasswordChar = '*';
            this.tbclave.Size = new System.Drawing.Size(125, 20);
            this.tbclave.TabIndex = 8;
            // 
            // btnguardarusuario
            // 
            this.btnguardarusuario.Location = new System.Drawing.Point(187, 10);
            this.btnguardarusuario.Name = "btnguardarusuario";
            this.btnguardarusuario.Size = new System.Drawing.Size(90, 47);
            this.btnguardarusuario.TabIndex = 9;
            this.btnguardarusuario.Text = "Guardar";
            this.btnguardarusuario.UseVisualStyleBackColor = true;
            this.btnguardarusuario.Click += new System.EventHandler(this.btnguardarusuario_Click);
            // 
            // btncancelar
            // 
            this.btncancelar.Location = new System.Drawing.Point(187, 66);
            this.btncancelar.Name = "btncancelar";
            this.btncancelar.Size = new System.Drawing.Size(90, 47);
            this.btncancelar.TabIndex = 10;
            this.btncancelar.Text = "Cancelar";
            this.btncancelar.UseVisualStyleBackColor = true;
            this.btncancelar.Click += new System.EventHandler(this.btncancelar_Click);
            // 
            // usuarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 126);
            this.Controls.Add(this.btncancelar);
            this.Controls.Add(this.btnguardarusuario);
            this.Controls.Add(this.tbclave);
            this.Controls.Add(this.cbtiposusuarios);
            this.Controls.Add(this.tbusuario);
            this.Controls.Add(this.cbcodempleado);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "usuarios";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Creación de Usuarios";
            this.Load += new System.EventHandler(this.usuarios_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cbcodempleado;
        private System.Windows.Forms.TextBox tbusuario;
        private System.Windows.Forms.ComboBox cbtiposusuarios;
        private System.Windows.Forms.TextBox tbclave;
        private System.Windows.Forms.Button btnguardarusuario;
        private System.Windows.Forms.Button btncancelar;
    }
}