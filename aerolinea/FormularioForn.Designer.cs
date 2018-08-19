namespace aerolinea
{
    partial class FormularioForn
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormularioForn));
            this.label1 = new System.Windows.Forms.Label();
            this.nombreBox = new System.Windows.Forms.TextBox();
            this.apellidoBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.edadBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.Registrar = new System.Windows.Forms.Button();
            this.Asiento = new System.Windows.Forms.Button();
            this.asientoBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(109, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "Vuelo";
            // 
            // nombreBox
            // 
            this.nombreBox.Location = new System.Drawing.Point(75, 88);
            this.nombreBox.Name = "nombreBox";
            this.nombreBox.Size = new System.Drawing.Size(174, 20);
            this.nombreBox.TabIndex = 2;
            this.nombreBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.nombreBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.nombreBox_KeyPress);
            // 
            // apellidoBox
            // 
            this.apellidoBox.Location = new System.Drawing.Point(75, 139);
            this.apellidoBox.Name = "apellidoBox";
            this.apellidoBox.Size = new System.Drawing.Size(174, 20);
            this.apellidoBox.TabIndex = 3;
            this.apellidoBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.apellidoBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.apellidoBox_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(111, 111);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 25);
            this.label2.TabIndex = 4;
            this.label2.Text = "Apellido";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Red;
            this.label3.Location = new System.Drawing.Point(110, 60);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(93, 25);
            this.label3.TabIndex = 5;
            this.label3.Text = "Nombre";
            // 
            // edadBox
            // 
            this.edadBox.Location = new System.Drawing.Point(122, 190);
            this.edadBox.MaxLength = 2;
            this.edadBox.Name = "edadBox";
            this.edadBox.Size = new System.Drawing.Size(76, 20);
            this.edadBox.TabIndex = 6;
            this.edadBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.edadBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.edadBox_KeyPress);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Red;
            this.label4.Location = new System.Drawing.Point(132, 162);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(66, 25);
            this.label4.TabIndex = 7;
            this.label4.Text = "Edad";
            // 
            // Registrar
            // 
            this.Registrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Registrar.ForeColor = System.Drawing.Color.Red;
            this.Registrar.Location = new System.Drawing.Point(195, 316);
            this.Registrar.Name = "Registrar";
            this.Registrar.Size = new System.Drawing.Size(108, 34);
            this.Registrar.TabIndex = 8;
            this.Registrar.Text = "Registrar";
            this.Registrar.UseVisualStyleBackColor = true;
            this.Registrar.Click += new System.EventHandler(this.Registrar_Click);
            // 
            // Asiento
            // 
            this.Asiento.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Asiento.ForeColor = System.Drawing.Color.Red;
            this.Asiento.Location = new System.Drawing.Point(115, 253);
            this.Asiento.Name = "Asiento";
            this.Asiento.Size = new System.Drawing.Size(102, 38);
            this.Asiento.TabIndex = 9;
            this.Asiento.Text = "Asiento";
            this.Asiento.UseVisualStyleBackColor = true;
            this.Asiento.Click += new System.EventHandler(this.Asiento_Click);
            // 
            // asientoBox
            // 
            this.asientoBox.Enabled = false;
            this.asientoBox.Location = new System.Drawing.Point(115, 227);
            this.asientoBox.Name = "asientoBox";
            this.asientoBox.Size = new System.Drawing.Size(100, 20);
            this.asientoBox.TabIndex = 10;
            this.asientoBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // FormularioForn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MediumTurquoise;
            this.ClientSize = new System.Drawing.Size(334, 362);
            this.Controls.Add(this.asientoBox);
            this.Controls.Add(this.Asiento);
            this.Controls.Add(this.Registrar);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.edadBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.apellidoBox);
            this.Controls.Add(this.nombreBox);
            this.Controls.Add(this.label1);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormularioForn";
            this.Text = "Formulario";
            this.Load += new System.EventHandler(this.FormularioForn_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox nombreBox;
        private System.Windows.Forms.TextBox apellidoBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox edadBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button Registrar;
        private System.Windows.Forms.Button Asiento;
        private System.Windows.Forms.TextBox asientoBox;
    }
}