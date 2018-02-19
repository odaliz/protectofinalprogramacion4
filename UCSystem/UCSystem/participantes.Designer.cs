namespace UCSystem
{
    partial class participantes
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(participantes));
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtmatriculap = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtapellidop = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtnombrep = new System.Windows.Forms.TextBox();
            this.Label6 = new System.Windows.Forms.Label();
            this.txtcedulap = new System.Windows.Forms.TextBox();
            this.Label2 = new System.Windows.Forms.Label();
            this.Label7 = new System.Windows.Forms.Label();
            this.txtdireccionp = new System.Windows.Forms.TextBox();
            this.button6 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtmatriculap);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.txtapellidop);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.txtnombrep);
            this.groupBox2.Controls.Add(this.Label6);
            this.groupBox2.Controls.Add(this.txtcedulap);
            this.groupBox2.Controls.Add(this.Label2);
            this.groupBox2.Controls.Add(this.Label7);
            this.groupBox2.Controls.Add(this.txtdireccionp);
            this.groupBox2.Location = new System.Drawing.Point(12, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(765, 124);
            this.groupBox2.TabIndex = 167;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Registro participantes";
            this.groupBox2.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // txtmatriculap
            // 
            this.txtmatriculap.Location = new System.Drawing.Point(57, 19);
            this.txtmatriculap.Name = "txtmatriculap";
            this.txtmatriculap.Size = new System.Drawing.Size(219, 20);
            this.txtmatriculap.TabIndex = 173;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(1, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 13);
            this.label1.TabIndex = 174;
            this.label1.Text = "Matricula";
            // 
            // txtapellidop
            // 
            this.txtapellidop.Location = new System.Drawing.Point(57, 75);
            this.txtapellidop.Name = "txtapellidop";
            this.txtapellidop.Size = new System.Drawing.Size(219, 20);
            this.txtapellidop.TabIndex = 173;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(321, 34);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(40, 13);
            this.label8.TabIndex = 152;
            this.label8.Text = "Cedula";
            // 
            // txtnombrep
            // 
            this.txtnombrep.Location = new System.Drawing.Point(57, 47);
            this.txtnombrep.Name = "txtnombrep";
            this.txtnombrep.Size = new System.Drawing.Size(219, 20);
            this.txtnombrep.TabIndex = 172;
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
            // txtcedulap
            // 
            this.txtcedulap.Location = new System.Drawing.Point(367, 27);
            this.txtcedulap.MaxLength = 15;
            this.txtcedulap.Name = "txtcedulap";
            this.txtcedulap.Size = new System.Drawing.Size(219, 20);
            this.txtcedulap.TabIndex = 151;
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
            this.Label7.Location = new System.Drawing.Point(309, 82);
            this.Label7.Name = "Label7";
            this.Label7.Size = new System.Drawing.Size(52, 13);
            this.Label7.TabIndex = 157;
            this.Label7.Text = "Direccion";
            // 
            // txtdireccionp
            // 
            this.txtdireccionp.Location = new System.Drawing.Point(367, 75);
            this.txtdireccionp.MaxLength = 10;
            this.txtdireccionp.Name = "txtdireccionp";
            this.txtdireccionp.Size = new System.Drawing.Size(219, 20);
            this.txtdireccionp.TabIndex = 161;
            // 
            // button6
            // 
            this.button6.Image = ((System.Drawing.Image)(resources.GetObject("button6.Image")));
            this.button6.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button6.Location = new System.Drawing.Point(275, 151);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(111, 52);
            this.button6.TabIndex = 172;
            this.button6.Text = "Limpiar";
            this.button6.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // button5
            // 
            this.button5.Image = ((System.Drawing.Image)(resources.GetObject("button5.Image")));
            this.button5.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button5.Location = new System.Drawing.Point(487, 151);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(111, 52);
            this.button5.TabIndex = 171;
            this.button5.Text = "Salir";
            this.button5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button3
            // 
            this.button3.Image = ((System.Drawing.Image)(resources.GetObject("button3.Image")));
            this.button3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button3.Location = new System.Drawing.Point(59, 151);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(113, 52);
            this.button3.TabIndex = 169;
            this.button3.Text = "Guardar";
            this.button3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // participantes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(777, 432);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.groupBox2);
            this.Name = "participantes";
            this.Text = "participantes";
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox2;
        internal System.Windows.Forms.Label label8;
        internal System.Windows.Forms.TextBox txtcedulap;
        internal System.Windows.Forms.Label Label7;
        internal System.Windows.Forms.TextBox txtdireccionp;
        internal System.Windows.Forms.TextBox txtapellidop;
        internal System.Windows.Forms.TextBox txtnombrep;
        internal System.Windows.Forms.Label Label6;
        internal System.Windows.Forms.Label Label2;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.TextBox txtmatriculap;
        private System.Windows.Forms.Label label1;
    }
}