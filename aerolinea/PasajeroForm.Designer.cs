namespace aerolinea
{
    partial class PasajeroForm
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
            System.Windows.Forms.ColumnHeader indice;
            this.listViewPasajero = new System.Windows.Forms.ListView();
            this.pasajeroInd = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.edad = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.eliminarButton = new System.Windows.Forms.Button();
            this.busquedaBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            indice = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // indice
            // 
            indice.Text = "Indice";
            indice.Width = 0;
            // 
            // listViewPasajero
            // 
            this.listViewPasajero.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            indice,
            this.pasajeroInd,
            this.columnHeader1,
            this.columnHeader2,
            this.edad,
            this.columnHeader3});
            this.listViewPasajero.FullRowSelect = true;
            this.listViewPasajero.Location = new System.Drawing.Point(12, 12);
            this.listViewPasajero.Name = "listViewPasajero";
            this.listViewPasajero.Size = new System.Drawing.Size(358, 287);
            this.listViewPasajero.TabIndex = 0;
            this.listViewPasajero.UseCompatibleStateImageBehavior = false;
            this.listViewPasajero.View = System.Windows.Forms.View.Details;
            this.listViewPasajero.SelectedIndexChanged += new System.EventHandler(this.listViewPasajero_SelectedIndexChanged);
            // 
            // pasajeroInd
            // 
            this.pasajeroInd.Text = "indicePasajero";
            this.pasajeroInd.Width = 0;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Vuelo";
            this.columnHeader1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Nombre";
            this.columnHeader2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader2.Width = 150;
            // 
            // edad
            // 
            this.edad.Text = "Edad";
            this.edad.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Asiento";
            this.columnHeader3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader3.Width = 79;
            // 
            // eliminarButton
            // 
            this.eliminarButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.eliminarButton.Location = new System.Drawing.Point(402, 55);
            this.eliminarButton.Name = "eliminarButton";
            this.eliminarButton.Size = new System.Drawing.Size(91, 38);
            this.eliminarButton.TabIndex = 1;
            this.eliminarButton.Text = "Eliminar";
            this.eliminarButton.UseVisualStyleBackColor = true;
            this.eliminarButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // busquedaBox
            // 
            this.busquedaBox.Location = new System.Drawing.Point(393, 154);
            this.busquedaBox.Name = "busquedaBox";
            this.busquedaBox.Size = new System.Drawing.Size(100, 20);
            this.busquedaBox.TabIndex = 3;
            this.busquedaBox.TextChanged += new System.EventHandler(this.busquedaBox_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(388, 114);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(117, 25);
            this.label1.TabIndex = 4;
            this.label1.Text = "Busqueda";
            // 
            // PasajeroForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.ClientSize = new System.Drawing.Size(510, 311);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.busquedaBox);
            this.Controls.Add(this.eliminarButton);
            this.Controls.Add(this.listViewPasajero);
            this.Name = "PasajeroForm";
            this.Text = "PasajeroForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView listViewPasajero;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.Button eliminarButton;
        private System.Windows.Forms.ColumnHeader pasajeroInd;
        private System.Windows.Forms.ColumnHeader edad;
        private System.Windows.Forms.TextBox busquedaBox;
        private System.Windows.Forms.Label label1;
    }
}