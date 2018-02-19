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
            this.txtcliente = new System.Windows.Forms.TextBox();
            this.Label2 = new System.Windows.Forms.Label();
            this.button6 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.txtidequipo = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtidequipo);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.txtcliente);
            this.groupBox2.Controls.Add(this.Label2);
            this.groupBox2.Location = new System.Drawing.Point(12, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(603, 133);
            this.groupBox2.TabIndex = 167;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Equipos";
            // 
            // txtcliente
            // 
            this.txtcliente.Location = new System.Drawing.Point(79, 50);
            this.txtcliente.Name = "txtcliente";
            this.txtcliente.Size = new System.Drawing.Size(148, 20);
            this.txtcliente.TabIndex = 172;
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
            // button6
            // 
            this.button6.Image = ((System.Drawing.Image)(resources.GetObject("button6.Image")));
            this.button6.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button6.Location = new System.Drawing.Point(235, 174);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(111, 52);
            this.button6.TabIndex = 175;
            this.button6.Text = "Limpiar";
            this.button6.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button6.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            this.button5.Image = ((System.Drawing.Image)(resources.GetObject("button5.Image")));
            this.button5.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button5.Location = new System.Drawing.Point(447, 174);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(111, 52);
            this.button5.TabIndex = 174;
            this.button5.Text = "Salir";
            this.button5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button5.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Image = ((System.Drawing.Image)(resources.GetObject("button3.Image")));
            this.button3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button3.Location = new System.Drawing.Point(19, 174);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(113, 52);
            this.button3.TabIndex = 173;
            this.button3.Text = "Guardar";
            this.button3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button3.UseVisualStyleBackColor = true;
            // 
            // txtidequipo
            // 
            this.txtidequipo.Location = new System.Drawing.Point(79, 24);
            this.txtidequipo.Name = "txtidequipo";
            this.txtidequipo.Size = new System.Drawing.Size(148, 20);
            this.txtidequipo.TabIndex = 177;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 13);
            this.label1.TabIndex = 176;
            this.label1.Text = "ID equipo";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // equipos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(615, 353);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.button3);
            this.Name = "equipos";
            this.Text = "equipos";
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox2;
        internal System.Windows.Forms.Label Label2;
        internal System.Windows.Forms.TextBox txtcliente;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button3;
        internal System.Windows.Forms.TextBox txtidequipo;
        internal System.Windows.Forms.Label label1;
    }
}