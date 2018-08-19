namespace aerolinea
{
    partial class DikstraForm
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
            this.buttonCost = new System.Windows.Forms.Button();
            this.buttonTime = new System.Windows.Forms.Button();
            this.dikstra = new System.Windows.Forms.Panel();
            this.origenBox = new System.Windows.Forms.TextBox();
            this.destinoBox = new System.Windows.Forms.TextBox();
            this.showRoute = new System.Windows.Forms.ListView();
            this.comprar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonCost
            // 
            this.buttonCost.Location = new System.Drawing.Point(451, 47);
            this.buttonCost.Name = "buttonCost";
            this.buttonCost.Size = new System.Drawing.Size(96, 53);
            this.buttonCost.TabIndex = 2;
            this.buttonCost.Text = "Costo";
            this.buttonCost.UseVisualStyleBackColor = true;
            this.buttonCost.Click += new System.EventHandler(this.buttonCost_Click);
            // 
            // buttonTime
            // 
            this.buttonTime.Location = new System.Drawing.Point(567, 47);
            this.buttonTime.Name = "buttonTime";
            this.buttonTime.Size = new System.Drawing.Size(96, 53);
            this.buttonTime.TabIndex = 3;
            this.buttonTime.Text = "Tiempo";
            this.buttonTime.UseVisualStyleBackColor = true;
            this.buttonTime.Click += new System.EventHandler(this.buttonTime_Click);
            // 
            // dikstra
            // 
            this.dikstra.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.dikstra.Location = new System.Drawing.Point(12, 3);
            this.dikstra.Name = "dikstra";
            this.dikstra.Size = new System.Drawing.Size(433, 375);
            this.dikstra.TabIndex = 4;
            this.dikstra.Paint += new System.Windows.Forms.PaintEventHandler(this.dikstra_Paint);
            // 
            // origenBox
            // 
            this.origenBox.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.origenBox.Location = new System.Drawing.Point(480, 12);
            this.origenBox.MaxLength = 1;
            this.origenBox.Name = "origenBox";
            this.origenBox.Size = new System.Drawing.Size(54, 20);
            this.origenBox.TabIndex = 5;
            this.origenBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // destinoBox
            // 
            this.destinoBox.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.destinoBox.Location = new System.Drawing.Point(588, 12);
            this.destinoBox.MaxLength = 1;
            this.destinoBox.Name = "destinoBox";
            this.destinoBox.Size = new System.Drawing.Size(49, 20);
            this.destinoBox.TabIndex = 6;
            this.destinoBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // showRoute
            // 
            this.showRoute.Location = new System.Drawing.Point(451, 121);
            this.showRoute.Name = "showRoute";
            this.showRoute.Size = new System.Drawing.Size(139, 283);
            this.showRoute.TabIndex = 7;
            this.showRoute.UseCompatibleStateImageBehavior = false;
            // 
            // comprar
            // 
            this.comprar.Location = new System.Drawing.Point(602, 170);
            this.comprar.Name = "comprar";
            this.comprar.Size = new System.Drawing.Size(88, 57);
            this.comprar.TabIndex = 8;
            this.comprar.Text = "Comprar";
            this.comprar.UseVisualStyleBackColor = true;
            this.comprar.Click += new System.EventHandler(this.comprar_Click);
            // 
            // DikstraForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(699, 416);
            this.Controls.Add(this.comprar);
            this.Controls.Add(this.showRoute);
            this.Controls.Add(this.destinoBox);
            this.Controls.Add(this.origenBox);
            this.Controls.Add(this.dikstra);
            this.Controls.Add(this.buttonTime);
            this.Controls.Add(this.buttonCost);
            this.Name = "DikstraForm";
            this.Text = "DikstraForm";
            this.Load += new System.EventHandler(this.DikstraForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonCost;
        private System.Windows.Forms.Button buttonTime;
        private System.Windows.Forms.Panel dikstra;
        private System.Windows.Forms.TextBox origenBox;
        private System.Windows.Forms.TextBox destinoBox;
        private System.Windows.Forms.ListView showRoute;
        private System.Windows.Forms.Button comprar;
    }
}