namespace aerolinea
{
    partial class GrafoForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GrafoForm));
            this.panel1 = new System.Windows.Forms.Panel();
            this.listView1 = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.button1 = new System.Windows.Forms.Button();
            this.kruskall = new System.Windows.Forms.Button();
            this.primm = new System.Windows.Forms.Button();
            this.kruskallbox = new System.Windows.Forms.TextBox();
            this.primmbox = new System.Windows.Forms.TextBox();
            this.ListaArsitas = new System.Windows.Forms.ListView();
            this.Origen = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Destino = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Diksjtra = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.panel1.Location = new System.Drawing.Point(27, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(433, 375);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2});
            this.listView1.FullRowSelect = true;
            this.listView1.Location = new System.Drawing.Point(466, 12);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(69, 183);
            this.listView1.TabIndex = 1;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            this.listView1.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Width = 0;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Ciudades";
            this.columnHeader2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader2.Width = 66;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(559, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(104, 43);
            this.button1.TabIndex = 2;
            this.button1.Text = "Eliminar Ciudad";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // kruskall
            // 
            this.kruskall.Location = new System.Drawing.Point(484, 339);
            this.kruskall.Name = "kruskall";
            this.kruskall.Size = new System.Drawing.Size(81, 38);
            this.kruskall.TabIndex = 3;
            this.kruskall.Text = "Kruskall";
            this.kruskall.UseVisualStyleBackColor = true;
            this.kruskall.Click += new System.EventHandler(this.button2_Click);
            // 
            // primm
            // 
            this.primm.Location = new System.Drawing.Point(582, 336);
            this.primm.Name = "primm";
            this.primm.Size = new System.Drawing.Size(81, 41);
            this.primm.TabIndex = 4;
            this.primm.Text = "Primm";
            this.primm.UseVisualStyleBackColor = true;
            this.primm.Click += new System.EventHandler(this.primm_Click);
            // 
            // kruskallbox
            // 
            this.kruskallbox.Enabled = false;
            this.kruskallbox.Location = new System.Drawing.Point(494, 299);
            this.kruskallbox.Name = "kruskallbox";
            this.kruskallbox.Size = new System.Drawing.Size(71, 20);
            this.kruskallbox.TabIndex = 5;
            this.kruskallbox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // primmbox
            // 
            this.primmbox.Enabled = false;
            this.primmbox.Location = new System.Drawing.Point(596, 299);
            this.primmbox.Name = "primmbox";
            this.primmbox.Size = new System.Drawing.Size(67, 20);
            this.primmbox.TabIndex = 6;
            this.primmbox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // ListaArsitas
            // 
            this.ListaArsitas.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Origen,
            this.Destino});
            this.ListaArsitas.Location = new System.Drawing.Point(559, 129);
            this.ListaArsitas.Name = "ListaArsitas";
            this.ListaArsitas.Size = new System.Drawing.Size(102, 135);
            this.ListaArsitas.TabIndex = 9;
            this.ListaArsitas.UseCompatibleStateImageBehavior = false;
            this.ListaArsitas.View = System.Windows.Forms.View.Details;
            // 
            // Origen
            // 
            this.Origen.Text = "Origen";
            this.Origen.Width = 48;
            // 
            // Destino
            // 
            this.Destino.Text = "Destino";
            this.Destino.Width = 50;
            // 
            // Diksjtra
            // 
            this.Diksjtra.Location = new System.Drawing.Point(703, 161);
            this.Diksjtra.Name = "Diksjtra";
            this.Diksjtra.Size = new System.Drawing.Size(104, 68);
            this.Diksjtra.TabIndex = 10;
            this.Diksjtra.Text = "Dikstra";
            this.Diksjtra.UseVisualStyleBackColor = true;
            this.Diksjtra.Click += new System.EventHandler(this.Diksjtra_Click);
            // 
            // GrafoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.ClientSize = new System.Drawing.Size(831, 403);
            this.Controls.Add(this.Diksjtra);
            this.Controls.Add(this.ListaArsitas);
            this.Controls.Add(this.primmbox);
            this.Controls.Add(this.kruskallbox);
            this.Controls.Add(this.primm);
            this.Controls.Add(this.kruskall);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "GrafoForm";
            this.Text = "GrafoForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button kruskall;
        private System.Windows.Forms.Button primm;
        private System.Windows.Forms.TextBox kruskallbox;
        private System.Windows.Forms.TextBox primmbox;
        private System.Windows.Forms.ListView ListaArsitas;
        private System.Windows.Forms.ColumnHeader Origen;
        private System.Windows.Forms.ColumnHeader Destino;
        private System.Windows.Forms.Button Diksjtra;
    }
}