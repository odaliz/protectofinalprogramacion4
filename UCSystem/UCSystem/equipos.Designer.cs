namespace UCSystem
{
    partial class equipos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(equipos));
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.Label2 = new System.Windows.Forms.Label();
            this.txtcodigo = new System.Windows.Forms.TextBox();
            this.Label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button6 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.txtcliente = new System.Windows.Forms.TextBox();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtcodigo);
            this.groupBox2.Controls.Add(this.txtcliente);
            this.groupBox2.Controls.Add(this.Label1);
            this.groupBox2.Controls.Add(this.Label2);
            this.groupBox2.Location = new System.Drawing.Point(12, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(603, 133);
            this.groupBox2.TabIndex = 167;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Equipos";
            // 
            // Label2
            // 
            this.Label2.AutoSize = true;
            this.Label2.Location = new System.Drawing.Point(7, 50);
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(66, 13);
            this.Label2.TabIndex = 169;
            this.Label2.Text = "Descripción ";
            this.Label2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // txtcodigo
            // 
            this.txtcodigo.Enabled = false;
            this.txtcodigo.Location = new System.Drawing.Point(79, 22);
            this.txtcodigo.Name = "txtcodigo";
            this.txtcodigo.Size = new System.Drawing.Size(148, 20);
            this.txtcodigo.TabIndex = 171;
            // 
            // Label1
            // 
            this.Label1.AutoSize = true;
            this.Label1.Location = new System.Drawing.Point(8, 25);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(54, 13);
            this.Label1.TabIndex = 170;
            this.Label1.Text = "ID Equipo";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button6);
            this.groupBox1.Controls.Add(this.button5);
            this.groupBox1.Controls.Add(this.button4);
            this.groupBox1.Controls.Add(this.button3);
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Location = new System.Drawing.Point(12, 166);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(589, 84);
            this.groupBox1.TabIndex = 168;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Mantenimiento";
            // 
            // button6
            // 
            this.button6.Image = ((System.Drawing.Image)(resources.GetObject("button6.Image")));
            this.button6.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button6.Location = new System.Drawing.Point(232, 19);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(111, 52);
            this.button6.TabIndex = 4;
            this.button6.Text = "Modificar";
            this.button6.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button6.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            this.button5.Image = ((System.Drawing.Image)(resources.GetObject("button5.Image")));
            this.button5.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button5.Location = new System.Drawing.Point(463, 19);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(111, 52);
            this.button5.TabIndex = 3;
            this.button5.Text = "Salir";
            this.button5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button5.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Image = ((System.Drawing.Image)(resources.GetObject("button4.Image")));
            this.button4.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button4.Location = new System.Drawing.Point(345, 19);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(115, 52);
            this.button4.TabIndex = 2;
            this.button4.Text = "Eliminar";
            this.button4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button4.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Image = ((System.Drawing.Image)(resources.GetObject("button3.Image")));
            this.button3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button3.Location = new System.Drawing.Point(113, 19);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(113, 52);
            this.button3.TabIndex = 1;
            this.button3.Text = "Insertar";
            this.button3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Image = ((System.Drawing.Image)(resources.GetObject("button2.Image")));
            this.button2.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.button2.Location = new System.Drawing.Point(11, 19);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(101, 52);
            this.button2.TabIndex = 0;
            this.button2.Text = "Nuevo";
            this.button2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button2.UseVisualStyleBackColor = true;
            // 
            // txtcliente
            // 
            this.txtcliente.Location = new System.Drawing.Point(79, 50);
            this.txtcliente.Name = "txtcliente";
            this.txtcliente.Size = new System.Drawing.Size(148, 20);
            this.txtcliente.TabIndex = 172;
            // 
            // equipos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(615, 353);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.Name = "equipos";
            this.Text = "equipos";
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox2;
        internal System.Windows.Forms.TextBox txtcodigo;
        internal System.Windows.Forms.Label Label1;
        internal System.Windows.Forms.Label Label2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        internal System.Windows.Forms.TextBox txtcliente;
    }
}