namespace aerolinea
{
    partial class VueloForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(VueloForm));
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.ventas = new System.Windows.Forms.Button();
            this.ordenarAsiento = new System.Windows.Forms.Button();
            this.ordenarFecha = new System.Windows.Forms.Button();
            this.busquedaVuelo = new System.Windows.Forms.TextBox();
            this.registroVuelo = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.actualizarFecha = new System.Windows.Forms.Button();
            this.vueloTextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(12, 12);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(380, 225);
            this.listBox1.TabIndex = 0;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // ventas
            // 
            this.ventas.Enabled = false;
            this.ventas.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ventas.ForeColor = System.Drawing.Color.Red;
            this.ventas.Location = new System.Drawing.Point(414, 58);
            this.ventas.Name = "ventas";
            this.ventas.Size = new System.Drawing.Size(109, 40);
            this.ventas.TabIndex = 1;
            this.ventas.Text = "Comprar";
            this.ventas.UseVisualStyleBackColor = true;
            this.ventas.Click += new System.EventHandler(this.button1_Click);
            // 
            // ordenarAsiento
            // 
            this.ordenarAsiento.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ordenarAsiento.ForeColor = System.Drawing.Color.Red;
            this.ordenarAsiento.Location = new System.Drawing.Point(414, 183);
            this.ordenarAsiento.Name = "ordenarAsiento";
            this.ordenarAsiento.Size = new System.Drawing.Size(109, 83);
            this.ordenarAsiento.TabIndex = 2;
            this.ordenarAsiento.Text = "Ordenar por Numero de Asientos";
            this.ordenarAsiento.UseVisualStyleBackColor = true;
            this.ordenarAsiento.Click += new System.EventHandler(this.ordenarAsiento_Click);
            // 
            // ordenarFecha
            // 
            this.ordenarFecha.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ordenarFecha.ForeColor = System.Drawing.Color.Red;
            this.ordenarFecha.Location = new System.Drawing.Point(414, 272);
            this.ordenarFecha.Name = "ordenarFecha";
            this.ordenarFecha.Size = new System.Drawing.Size(109, 58);
            this.ordenarFecha.TabIndex = 3;
            this.ordenarFecha.Text = "Ordenar por Fecha";
            this.ordenarFecha.UseVisualStyleBackColor = true;
            this.ordenarFecha.Click += new System.EventHandler(this.ordenarFecha_Click);
            // 
            // busquedaVuelo
            // 
            this.busquedaVuelo.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.busquedaVuelo.Location = new System.Drawing.Point(229, 257);
            this.busquedaVuelo.MaxLength = 2;
            this.busquedaVuelo.Name = "busquedaVuelo";
            this.busquedaVuelo.Size = new System.Drawing.Size(57, 20);
            this.busquedaVuelo.TabIndex = 4;
            this.busquedaVuelo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.busquedaVuelo.TextChanged += new System.EventHandler(this.busquedaVuelo_TextChanged_1);
            this.busquedaVuelo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.busquedaVuelo_KeyPress);
            // 
            // registroVuelo
            // 
            this.registroVuelo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.registroVuelo.ForeColor = System.Drawing.Color.Red;
            this.registroVuelo.Location = new System.Drawing.Point(414, 12);
            this.registroVuelo.Name = "registroVuelo";
            this.registroVuelo.Size = new System.Drawing.Size(109, 40);
            this.registroVuelo.TabIndex = 5;
            this.registroVuelo.Text = "Registrar Vuelo";
            this.registroVuelo.UseVisualStyleBackColor = true;
            this.registroVuelo.Click += new System.EventHandler(this.registroVuelo_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(67, 257);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 24);
            this.label1.TabIndex = 6;
            this.label1.Text = "Busqueda";
            // 
            // actualizarFecha
            // 
            this.actualizarFecha.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.actualizarFecha.ForeColor = System.Drawing.Color.Red;
            this.actualizarFecha.Location = new System.Drawing.Point(414, 117);
            this.actualizarFecha.Name = "actualizarFecha";
            this.actualizarFecha.Size = new System.Drawing.Size(108, 48);
            this.actualizarFecha.TabIndex = 7;
            this.actualizarFecha.Text = "Eliminar vuelos anteriores";
            this.actualizarFecha.UseVisualStyleBackColor = true;
            this.actualizarFecha.Click += new System.EventHandler(this.actualizarFecha_Click);
            // 
            // vueloTextBox
            // 
            this.vueloTextBox.Enabled = false;
            this.vueloTextBox.Location = new System.Drawing.Point(177, 257);
            this.vueloTextBox.Name = "vueloTextBox";
            this.vueloTextBox.Size = new System.Drawing.Size(46, 20);
            this.vueloTextBox.TabIndex = 8;
            // 
            // VueloForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.ClientSize = new System.Drawing.Size(575, 361);
            this.Controls.Add(this.vueloTextBox);
            this.Controls.Add(this.actualizarFecha);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.registroVuelo);
            this.Controls.Add(this.busquedaVuelo);
            this.Controls.Add(this.ordenarFecha);
            this.Controls.Add(this.ordenarAsiento);
            this.Controls.Add(this.ventas);
            this.Controls.Add(this.listBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "VueloForm";
            this.Text = "Vuelo";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button ventas;
        private System.Windows.Forms.Button ordenarAsiento;
        private System.Windows.Forms.Button ordenarFecha;
        private System.Windows.Forms.TextBox busquedaVuelo;
        private System.Windows.Forms.Button registroVuelo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button actualizarFecha;
        private System.Windows.Forms.TextBox vueloTextBox;
    }
}