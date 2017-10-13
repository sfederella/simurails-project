namespace SimuRails.Views.Components
{
    partial class RenglonDeIncidente
    {
        /// <summary> 
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de componentes

        /// <summary> 
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.materialFlatButton2 = new MaterialSkin.Controls.MaterialFlatButton();
            this.materialFlatButton1 = new MaterialSkin.Controls.MaterialFlatButton();
            this.demoraLbl = new MaterialSkin.Controls.MaterialLabel();
            this.probabilidadLbl = new MaterialSkin.Controls.MaterialLabel();
            this.nombreLbl = new MaterialSkin.Controls.MaterialLabel();
            this.materialDivider1 = new MaterialSkin.Controls.MaterialDivider();
            this.SuspendLayout();
            // 
            // materialFlatButton2
            // 
            this.materialFlatButton2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.materialFlatButton2.AutoSize = true;
            this.materialFlatButton2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialFlatButton2.Depth = 0;
            this.materialFlatButton2.Location = new System.Drawing.Point(748, 10);
            this.materialFlatButton2.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.materialFlatButton2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialFlatButton2.Name = "materialFlatButton2";
            this.materialFlatButton2.Primary = false;
            this.materialFlatButton2.Size = new System.Drawing.Size(59, 36);
            this.materialFlatButton2.TabIndex = 33;
            this.materialFlatButton2.Text = "Editar";
            this.materialFlatButton2.UseVisualStyleBackColor = true;
            this.materialFlatButton2.Click += new System.EventHandler(this.materialFlatButton2_Click);
            // 
            // materialFlatButton1
            // 
            this.materialFlatButton1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.materialFlatButton1.AutoSize = true;
            this.materialFlatButton1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialFlatButton1.Depth = 0;
            this.materialFlatButton1.Location = new System.Drawing.Point(815, 10);
            this.materialFlatButton1.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.materialFlatButton1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialFlatButton1.Name = "materialFlatButton1";
            this.materialFlatButton1.Primary = false;
            this.materialFlatButton1.Size = new System.Drawing.Size(65, 36);
            this.materialFlatButton1.TabIndex = 32;
            this.materialFlatButton1.Text = "Borrar";
            this.materialFlatButton1.UseVisualStyleBackColor = true;
            this.materialFlatButton1.Click += new System.EventHandler(this.materialFlatButton1_Click);
            // 
            // demoraLbl
            // 
            this.demoraLbl.AutoSize = true;
            this.demoraLbl.Depth = 0;
            this.demoraLbl.Font = new System.Drawing.Font("Roboto", 11F);
            this.demoraLbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.demoraLbl.Location = new System.Drawing.Point(511, 18);
            this.demoraLbl.MouseState = MaterialSkin.MouseState.HOVER;
            this.demoraLbl.Name = "demoraLbl";
            this.demoraLbl.Size = new System.Drawing.Size(108, 19);
            this.demoraLbl.TabIndex = 31;
            this.demoraLbl.Text = "materialLabel4";
            this.demoraLbl.Click += new System.EventHandler(this.capacidadTotalLbl_Click);
            // 
            // probabilidadLbl
            // 
            this.probabilidadLbl.AutoSize = true;
            this.probabilidadLbl.Depth = 0;
            this.probabilidadLbl.Font = new System.Drawing.Font("Roboto", 11F);
            this.probabilidadLbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.probabilidadLbl.Location = new System.Drawing.Point(308, 18);
            this.probabilidadLbl.MouseState = MaterialSkin.MouseState.HOVER;
            this.probabilidadLbl.Name = "probabilidadLbl";
            this.probabilidadLbl.Size = new System.Drawing.Size(108, 19);
            this.probabilidadLbl.TabIndex = 30;
            this.probabilidadLbl.Text = "materialLabel3";
            this.probabilidadLbl.Click += new System.EventHandler(this.capacidadLegalLbl_Click);
            // 
            // nombreLbl
            // 
            this.nombreLbl.AutoSize = true;
            this.nombreLbl.Depth = 0;
            this.nombreLbl.Font = new System.Drawing.Font("Roboto", 11F);
            this.nombreLbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.nombreLbl.Location = new System.Drawing.Point(17, 18);
            this.nombreLbl.MouseState = MaterialSkin.MouseState.HOVER;
            this.nombreLbl.Name = "nombreLbl";
            this.nombreLbl.Size = new System.Drawing.Size(108, 19);
            this.nombreLbl.TabIndex = 29;
            this.nombreLbl.Text = "materialLabel1";
            this.nombreLbl.Click += new System.EventHandler(this.modeloLbl_Click);
            // 
            // materialDivider1
            // 
            this.materialDivider1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.materialDivider1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialDivider1.Depth = 0;
            this.materialDivider1.Location = new System.Drawing.Point(0, 1);
            this.materialDivider1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialDivider1.Name = "materialDivider1";
            this.materialDivider1.Size = new System.Drawing.Size(885, 2);
            this.materialDivider1.TabIndex = 28;
            this.materialDivider1.Text = "materialDivider1";
            this.materialDivider1.Click += new System.EventHandler(this.materialDivider1_Click);
            // 
            // RenglonDeIncidente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.materialFlatButton2);
            this.Controls.Add(this.materialFlatButton1);
            this.Controls.Add(this.demoraLbl);
            this.Controls.Add(this.probabilidadLbl);
            this.Controls.Add(this.nombreLbl);
            this.Controls.Add(this.materialDivider1);
            this.Name = "RenglonDeIncidente";
            this.Size = new System.Drawing.Size(884, 47);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialFlatButton materialFlatButton2;
        private MaterialSkin.Controls.MaterialFlatButton materialFlatButton1;
        private MaterialSkin.Controls.MaterialLabel demoraLbl;
        private MaterialSkin.Controls.MaterialLabel probabilidadLbl;
        private MaterialSkin.Controls.MaterialLabel nombreLbl;
        private MaterialSkin.Controls.MaterialDivider materialDivider1;
    }
}
