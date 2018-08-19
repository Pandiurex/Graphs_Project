namespace aerolinea
{
    partial class EliminarVuelo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EliminarVuelo));
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.eliminarVuelos = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(14, 16);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(253, 212);
            this.listBox1.TabIndex = 0;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // eliminarVuelos
            // 
            this.eliminarVuelos.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.eliminarVuelos.ForeColor = System.Drawing.Color.Red;
            this.eliminarVuelos.Location = new System.Drawing.Point(273, 44);
            this.eliminarVuelos.Name = "eliminarVuelos";
            this.eliminarVuelos.Size = new System.Drawing.Size(117, 43);
            this.eliminarVuelos.TabIndex = 1;
            this.eliminarVuelos.Text = "Eliminar";
            this.eliminarVuelos.UseVisualStyleBackColor = true;
            this.eliminarVuelos.Click += new System.EventHandler(this.eliminarVuelos_Click);
            // 
            // EliminarVuelo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(402, 236);
            this.Controls.Add(this.eliminarVuelos);
            this.Controls.Add(this.listBox1);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "EliminarVuelo";
            this.Text = "Eliminar Vuelo";
            this.Load += new System.EventHandler(this.EliminarVuelo_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button eliminarVuelos;
    }
}