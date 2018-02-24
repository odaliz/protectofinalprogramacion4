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
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.cbcargo = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tbdireccion = new System.Windows.Forms.TextBox();
            this.tbsueldo = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tbapellido = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.tbnombre = new System.Windows.Forms.TextBox();
            this.Label6 = new System.Windows.Forms.Label();
            this.tbcedula = new System.Windows.Forms.TextBox();
            this.Label2 = new System.Windows.Forms.Label();
            this.Label7 = new System.Windows.Forms.Label();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Image = ((System.Drawing.Image)(resources.GetObject("btnLimpiar.Image")));
            this.btnLimpiar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLimpiar.Location = new System.Drawing.Point(125, 215);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(100, 52);
            this.btnLimpiar.TabIndex = 176;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnLimpiar.UseVisualStyleBackColor = true;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.Image = ((System.Drawing.Image)(resources.GetObject("btnSalir.Image")));
            this.btnSalir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSalir.Location = new System.Drawing.Point(235, 215);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(63, 52);
            this.btnSalir.TabIndex = 175;
            this.btnSalir.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // btnGuardar
            // 
            this.btnGuardar.Image = ((System.Drawing.Image)(resources.GetObject("btnGuardar.Image")));
            this.btnGuardar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGuardar.Location = new System.Drawing.Point(12, 215);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(101, 52);
            this.btnGuardar.TabIndex = 174;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.cbcargo);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.tbdireccion);
            this.groupBox2.Controls.Add(this.tbsueldo);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.tbapellido);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.tbnombre);
            this.groupBox2.Controls.Add(this.Label6);
            this.groupBox2.Controls.Add(this.tbcedula);
            this.groupBox2.Controls.Add(this.Label2);
            this.groupBox2.Controls.Add(this.Label7);
            this.groupBox2.Location = new System.Drawing.Point(12, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(286, 197);
            this.groupBox2.TabIndex = 173;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Registro";
            // 
            // cbcargo
            // 
            this.cbcargo.FormattingEnabled = true;
            this.cbcargo.Location = new System.Drawing.Point(57, 101);
            this.cbcargo.Name = "cbcargo";
            this.cbcargo.Size = new System.Drawing.Size(219, 21);
            this.cbcargo.TabIndex = 178;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(5, 104);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 13);
            this.label3.TabIndex = 177;
            this.label3.Text = "Cargo:";
            // 
            // tbdireccion
            // 
            this.tbdireccion.Location = new System.Drawing.Point(9, 142);
            this.tbdireccion.Multiline = true;
            this.tbdireccion.Name = "tbdireccion";
            this.tbdireccion.Size = new System.Drawing.Size(267, 47);
            this.tbdireccion.TabIndex = 175;
            // 
            // tbsueldo
            // 
            this.tbsueldo.Location = new System.Drawing.Point(212, 75);
            this.tbsueldo.Name = "tbsueldo";
            this.tbsueldo.Size = new System.Drawing.Size(64, 20);
            this.tbsueldo.TabIndex = 173;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(163, 78);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 174;
            this.label1.Text = "Sueldo:";
            // 
            // tbapellido
            // 
            this.tbapellido.Location = new System.Drawing.Point(57, 49);
            this.tbapellido.Name = "tbapellido";
            this.tbapellido.Size = new System.Drawing.Size(219, 20);
            this.tbapellido.TabIndex = 173;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(5, 78);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(43, 13);
            this.label8.TabIndex = 152;
            this.label8.Text = "Cedula:";
            // 
            // tbnombre
            // 
            this.tbnombre.Location = new System.Drawing.Point(57, 21);
            this.tbnombre.Name = "tbnombre";
            this.tbnombre.Size = new System.Drawing.Size(219, 20);
            this.tbnombre.TabIndex = 172;
            // 
            // Label6
            // 
            this.Label6.AutoSize = true;
            this.Label6.Location = new System.Drawing.Point(5, 51);
            this.Label6.Name = "Label6";
            this.Label6.Size = new System.Drawing.Size(52, 13);
            this.Label6.TabIndex = 168;
            this.Label6.Text = "Apellidos:";
            // 
            // tbcedula
            // 
            this.tbcedula.Location = new System.Drawing.Point(57, 75);
            this.tbcedula.MaxLength = 15;
            this.tbcedula.Name = "tbcedula";
            this.tbcedula.Size = new System.Drawing.Size(100, 20);
            this.tbcedula.TabIndex = 151;
            // 
            // Label2
            // 
            this.Label2.AutoSize = true;
            this.Label2.Location = new System.Drawing.Point(5, 24);
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(52, 13);
            this.Label2.TabIndex = 169;
            this.Label2.Text = "Nombres:";
            this.Label2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // Label7
            // 
            this.Label7.AutoSize = true;
            this.Label7.Location = new System.Drawing.Point(5, 127);
            this.Label7.Name = "Label7";
            this.Label7.Size = new System.Drawing.Size(55, 13);
            this.Label7.TabIndex = 157;
            this.Label7.Text = "Direccion:";
            // 
            // Empleado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(304, 272);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.groupBox2);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Empleado";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Registro de Empleados";
            this.Load += new System.EventHandler(this.Empleado_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.GroupBox groupBox2;
        public System.Windows.Forms.TextBox tbdireccion;
        public System.Windows.Forms.TextBox tbsueldo;
        private System.Windows.Forms.Label label1;
        internal System.Windows.Forms.TextBox tbapellido;
        internal System.Windows.Forms.Label label8;
        internal System.Windows.Forms.TextBox tbnombre;
        internal System.Windows.Forms.Label Label6;
        internal System.Windows.Forms.TextBox tbcedula;
        internal System.Windows.Forms.Label Label2;
        internal System.Windows.Forms.Label Label7;
        internal System.Windows.Forms.Label label3;
        public System.Windows.Forms.ComboBox cbcargo;
    }
}