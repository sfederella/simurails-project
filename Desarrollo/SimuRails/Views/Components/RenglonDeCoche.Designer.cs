namespace SimuRails.Views.Components
{
    partial class RenglonDeCoche
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
            this.capacidadTotalLbl = new MaterialSkin.Controls.MaterialLabel();
            this.capacidadLegalLbl = new MaterialSkin.Controls.MaterialLabel();
            this.modeloLbl = new MaterialSkin.Controls.MaterialLabel();
            this.materialDivider1 = new MaterialSkin.Controls.MaterialDivider();
            this.materialFlatButton2 = new MaterialSkin.Controls.MaterialFlatButton();
            this.materialFlatButton1 = new MaterialSkin.Controls.MaterialFlatButton();
            this.SuspendLayout();
            // 
            // capacidadTotalLbl
            // 
            this.capacidadTotalLbl.AutoSize = true;
            this.capacidadTotalLbl.Depth = 0;
            this.capacidadTotalLbl.Font = new System.Drawing.Font("Roboto", 11F);
            this.capacidadTotalLbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.capacidadTotalLbl.Location = new System.Drawing.Point(511, 20);
            this.capacidadTotalLbl.MouseState = MaterialSkin.MouseState.HOVER;
            this.capacidadTotalLbl.Name = "capacidadTotalLbl";
            this.capacidadTotalLbl.Size = new System.Drawing.Size(108, 19);
            this.capacidadTotalLbl.TabIndex = 25;
            this.capacidadTotalLbl.Text = "materialLabel4";
            // 
            // capacidadLegalLbl
            // 
            this.capacidadLegalLbl.AutoSize = true;
            this.capacidadLegalLbl.Depth = 0;
            this.capacidadLegalLbl.Font = new System.Drawing.Font("Roboto", 11F);
            this.capacidadLegalLbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.capacidadLegalLbl.Location = new System.Drawing.Point(308, 20);
            this.capacidadLegalLbl.MouseState = MaterialSkin.MouseState.HOVER;
            this.capacidadLegalLbl.Name = "capacidadLegalLbl";
            this.capacidadLegalLbl.Size = new System.Drawing.Size(108, 19);
            this.capacidadLegalLbl.TabIndex = 24;
            this.capacidadLegalLbl.Text = "materialLabel3";
            // 
            // modeloLbl
            // 
            this.modeloLbl.AutoSize = true;
            this.modeloLbl.Depth = 0;
            this.modeloLbl.Font = new System.Drawing.Font("Roboto", 11F);
            this.modeloLbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.modeloLbl.Location = new System.Drawing.Point(17, 20);
            this.modeloLbl.MouseState = MaterialSkin.MouseState.HOVER;
            this.modeloLbl.Name = "modeloLbl";
            this.modeloLbl.Size = new System.Drawing.Size(108, 19);
            this.modeloLbl.TabIndex = 22;
            this.modeloLbl.Text = "materialLabel1";
            // 
            // materialDivider1
            // 
            this.materialDivider1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.materialDivider1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialDivider1.Depth = 0;
            this.materialDivider1.Location = new System.Drawing.Point(0, 3);
            this.materialDivider1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialDivider1.Name = "materialDivider1";
            this.materialDivider1.Size = new System.Drawing.Size(885, 2);
            this.materialDivider1.TabIndex = 21;
            this.materialDivider1.Text = "materialDivider1";
            // 
            // materialFlatButton2
            // 
            this.materialFlatButton2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.materialFlatButton2.AutoSize = true;
            this.materialFlatButton2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialFlatButton2.Depth = 0;
            this.materialFlatButton2.Location = new System.Drawing.Point(748, 12);
            this.materialFlatButton2.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.materialFlatButton2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialFlatButton2.Name = "materialFlatButton2";
            this.materialFlatButton2.Primary = false;
            this.materialFlatButton2.Size = new System.Drawing.Size(59, 36);
            this.materialFlatButton2.TabIndex = 27;
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
            this.materialFlatButton1.Location = new System.Drawing.Point(815, 12);
            this.materialFlatButton1.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.materialFlatButton1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialFlatButton1.Name = "materialFlatButton1";
            this.materialFlatButton1.Primary = false;
            this.materialFlatButton1.Size = new System.Drawing.Size(65, 36);
            this.materialFlatButton1.TabIndex = 26;
            this.materialFlatButton1.Text = "Borrar";
            this.materialFlatButton1.UseVisualStyleBackColor = true;
            this.materialFlatButton1.Click += new System.EventHandler(this.materialFlatButton1_Click);
            // 
            // RenglonDeCoche
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.materialFlatButton2);
            this.Controls.Add(this.materialFlatButton1);
            this.Controls.Add(this.capacidadTotalLbl);
            this.Controls.Add(this.capacidadLegalLbl);
            this.Controls.Add(this.modeloLbl);
            this.Controls.Add(this.materialDivider1);
            this.Name = "RenglonDeCoche";
            this.Size = new System.Drawing.Size(884, 47);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialLabel capacidadTotalLbl;
        private MaterialSkin.Controls.MaterialLabel capacidadLegalLbl;
        private MaterialSkin.Controls.MaterialLabel modeloLbl;
        private MaterialSkin.Controls.MaterialDivider materialDivider1;
        private MaterialSkin.Controls.MaterialFlatButton materialFlatButton2;
        private MaterialSkin.Controls.MaterialFlatButton materialFlatButton1;
    }
}
