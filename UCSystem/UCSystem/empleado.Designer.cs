namespace UCSystem
{
    partial class Empleado
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Empleado));
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.level = new System.Windows.Forms.Label();
            this.txtcodigoemple = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtapellidoem = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtnombreem = new System.Windows.Forms.TextBox();
            this.Label6 = new System.Windows.Forms.Label();
            this.txtcedulaem = new System.Windows.Forms.TextBox();
            this.Label2 = new System.Windows.Forms.Label();
            this.Label7 = new System.Windows.Forms.Label();
            this.txtdireccionem = new System.Windows.Forms.TextBox();
            this.btnlimpiar = new System.Windows.Forms.Button();
            this.btnsalir = new System.Windows.Forms.Button();
            this.btngualdar = new System.Windows.Forms.Button();
            this.txtidcargo = new System.Windows.Forms.TextBox();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtidcargo);
            this.groupBox2.Controls.Add(this.level);
            this.groupBox2.Controls.Add(this.txtcodigoemple);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.txtapellidoem);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.txtnombreem);
            this.groupBox2.Controls.Add(this.Label6);
            this.groupBox2.Controls.Add(this.txtcedulaem);
            this.groupBox2.Controls.Add(this.Label2);
            this.groupBox2.Controls.Add(this.Label7);
            this.groupBox2.Controls.Add(this.txtdireccionem);
            this.groupBox2.Location = new System.Drawing.Point(1, 1);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(763, 145);
            this.groupBox2.TabIndex = 173;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Registro Empleados";
            this.groupBox2.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // level
            // 
            this.level.AutoSize = true;
            this.level.Location = new System.Drawing.Point(423, 98);
            this.level.Name = "level";
            this.level.Size = new System.Drawing.Size(49, 13);
            this.level.TabIndex = 177;
            this.level.Text = "ID Cargo";
            // 
            // txtcodigoemple
            // 
            this.txtcodigoemple.Location = new System.Drawing.Point(95, 26);
            this.txtcodigoemple.Name = "txtcodigoemple";
            this.txtcodigoemple.Size = new System.Drawing.Size(219, 20);
            this.txtcodigoemple.TabIndex = 178;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(1, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 13);
            this.label1.TabIndex = 177;
            this.label1.Text = "codigo empleado";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // txtapellidoem
            // 
            this.txtapellidoem.Location = new System.Drawing.Point(95, 91);
            this.txtapellidoem.Name = "txtapellidoem";
            this.txtapellidoem.Size = new System.Drawing.Size(219, 20);
            this.txtapellidoem.TabIndex = 173;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(423, 13);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(40, 13);
            this.label8.TabIndex = 152;
            this.label8.Text = "Cedula";
            // 
            // txtnombreem
            // 
            this.txtnombreem.Location = new System.Drawing.Point(95, 54);
            this.txtnombreem.Name = "txtnombreem";
            this.txtnombreem.Size = new System.Drawing.Size(219, 20);
            this.txtnombreem.TabIndex = 172;
            // 
            // Label6
            // 
            this.Label6.AutoSize = true;
            this.Label6.Location = new System.Drawing.Point(1, 82);
            this.Label6.Name = "Label6";
            this.Label6.Size = new System.Drawing.Size(44, 13);
            this.Label6.TabIndex = 168;
            this.Label6.Text = "Apellido";
            // 
            // txtcedulaem
            // 
            this.txtcedulaem.Location = new System.Drawing.Point(494, 13);
            this.txtcedulaem.MaxLength = 15;
            this.txtcedulaem.Name = "txtcedulaem";
            this.txtcedulaem.Size = new System.Drawing.Size(219, 20);
            this.txtcedulaem.TabIndex = 151;
            // 
            // Label2
            // 
            this.Label2.AutoSize = true;
            this.Label2.Location = new System.Drawing.Point(1, 54);
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(44, 13);
            this.Label2.TabIndex = 169;
            this.Label2.Text = "Nombre";
            this.Label2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // Label7
            // 
            this.Label7.AutoSize = true;
            this.Label7.Location = new System.Drawing.Point(423, 54);
            this.Label7.Name = "Label7";
            this.Label7.Size = new System.Drawing.Size(52, 13);
            this.Label7.TabIndex = 157;
            this.Label7.Text = "Direccion";
            // 
            // txtdireccionem
            // 
            this.txtdireccionem.Location = new System.Drawing.Point(494, 51);
            this.txtdireccionem.MaxLength = 10;
            this.txtdireccionem.Name = "txtdireccionem";
            this.txtdireccionem.Size = new System.Drawing.Size(219, 20);
            this.txtdireccionem.TabIndex = 161;
            // 
            // btnlimpiar
            // 
            this.btnlimpiar.Image = ((System.Drawing.Image)(resources.GetObject("btnlimpiar.Image")));
            this.btnlimpiar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnlimpiar.Location = new System.Drawing.Point(283, 152);
            this.btnlimpiar.Name = "btnlimpiar";
            this.btnlimpiar.Size = new System.Drawing.Size(111, 52);
            this.btnlimpiar.TabIndex = 176;
            this.btnlimpiar.Text = "Limpiar";
            this.btnlimpiar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnlimpiar.UseVisualStyleBackColor = true;
            this.btnlimpiar.Click += new System.EventHandler(this.button6_Click);
            // 
            // btnsalir
            // 
            this.btnsalir.Image = ((System.Drawing.Image)(resources.GetObject("btnsalir.Image")));
            this.btnsalir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnsalir.Location = new System.Drawing.Point(495, 152);
            this.btnsalir.Name = "btnsalir";
            this.btnsalir.Size = new System.Drawing.Size(111, 52);
            this.btnsalir.TabIndex = 175;
            this.btnsalir.Text = "Salir";
            this.btnsalir.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnsalir.UseVisualStyleBackColor = true;
            this.btnsalir.Click += new System.EventHandler(this.button5_Click);
            // 
            // btngualdar
            // 
            this.btngualdar.Image = ((System.Drawing.Image)(resources.GetObject("btngualdar.Image")));
            this.btngualdar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btngualdar.Location = new System.Drawing.Point(67, 152);
            this.btngualdar.Name = "btngualdar";
            this.btngualdar.Size = new System.Drawing.Size(113, 52);
            this.btngualdar.TabIndex = 174;
            this.btngualdar.Text = "Guardar";
            this.btngualdar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btngualdar.UseVisualStyleBackColor = true;
            // 
            // txtidcargo
            // 
            this.txtidcargo.Location = new System.Drawing.Point(494, 95);
            this.txtidcargo.MaxLength = 10;
            this.txtidcargo.Name = "txtidcargo";
            this.txtidcargo.Size = new System.Drawing.Size(219, 20);
            this.txtidcargo.TabIndex = 179;
            // 
            // Empleado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(776, 373);
            this.Controls.Add(this.btnlimpiar);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.btnsalir);
            this.Controls.Add(this.btngualdar);
            this.Name = "Empleado";
            this.Text = "empleado";
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox2;
        internal System.Windows.Forms.TextBox txtapellidoem;
        internal System.Windows.Forms.Label label8;
        internal System.Windows.Forms.TextBox txtnombreem;
        internal System.Windows.Forms.Label Label6;
        internal System.Windows.Forms.TextBox txtcedulaem;
        internal System.Windows.Forms.Label Label2;
        internal System.Windows.Forms.Label Label7;
        internal System.Windows.Forms.TextBox txtdireccionem;
        private System.Windows.Forms.Button btnlimpiar;
        private System.Windows.Forms.Button btnsalir;
        private System.Windows.Forms.Button btngualdar;
        internal System.Windows.Forms.TextBox txtcodigoemple;
        internal System.Windows.Forms.Label label1;
        internal System.Windows.Forms.Label level;
        internal System.Windows.Forms.TextBox txtidcargo;
    }
}