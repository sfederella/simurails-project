namespace SimuRails.Views.Components
{
    partial class RenglonDeTramo
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
            this.materialFlatButton1 = new MaterialSkin.Controls.MaterialFlatButton();
            this.destinoLbl = new MaterialSkin.Controls.MaterialLabel();
            this.origenLbl = new MaterialSkin.Controls.MaterialLabel();
            this.materialDivider1 = new MaterialSkin.Controls.MaterialDivider();
            this.distanciaLbl = new MaterialSkin.Controls.MaterialLabel();
            this.tiempoLbl = new MaterialSkin.Controls.MaterialLabel();
            this.SuspendLayout();
            // 
            // materialFlatButton1
            // 
            this.materialFlatButton1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.materialFlatButton1.AutoSize = true;
            this.materialFlatButton1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialFlatButton1.Depth = 0;
            this.materialFlatButton1.Icon = null;
            this.materialFlatButton1.Location = new System.Drawing.Point(662, 10);
            this.materialFlatButton1.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.materialFlatButton1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialFlatButton1.Name = "materialFlatButton1";
            this.materialFlatButton1.Primary = false;
            this.materialFlatButton1.Size = new System.Drawing.Size(74, 36);
            this.materialFlatButton1.TabIndex = 38;
            this.materialFlatButton1.Text = "Borrar";
            this.materialFlatButton1.UseVisualStyleBackColor = true;
            this.materialFlatButton1.Click += new System.EventHandler(this.materialFlatButton1_Click);
            // 
            // destinoLbl
            // 
            this.destinoLbl.AutoSize = true;
            this.destinoLbl.Depth = 0;
            this.destinoLbl.Font = new System.Drawing.Font("Roboto", 11F);
            this.destinoLbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.destinoLbl.Location = new System.Drawing.Point(175, 18);
            this.destinoLbl.MouseState = MaterialSkin.MouseState.HOVER;
            this.destinoLbl.Name = "destinoLbl";
            this.destinoLbl.Size = new System.Drawing.Size(108, 19);
            this.destinoLbl.TabIndex = 37;
            this.destinoLbl.Text = "materialLabel3";
            // 
            // origenLbl
            // 
            this.origenLbl.AutoSize = true;
            this.origenLbl.Depth = 0;
            this.origenLbl.Font = new System.Drawing.Font("Roboto", 11F);
            this.origenLbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.origenLbl.Location = new System.Drawing.Point(4, 18);
            this.origenLbl.MouseState = MaterialSkin.MouseState.HOVER;
            this.origenLbl.Name = "origenLbl";
            this.origenLbl.Size = new System.Drawing.Size(108, 19);
            this.origenLbl.TabIndex = 36;
            this.origenLbl.Text = "materialLabel1";
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
            this.materialDivider1.Size = new System.Drawing.Size(732, 2);
            this.materialDivider1.TabIndex = 35;
            this.materialDivider1.Text = "materialDivider1";
            // 
            // distanciaLbl
            // 
            this.distanciaLbl.AutoSize = true;
            this.distanciaLbl.Depth = 0;
            this.distanciaLbl.Font = new System.Drawing.Font("Roboto", 11F);
            this.distanciaLbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.distanciaLbl.Location = new System.Drawing.Point(360, 18);
            this.distanciaLbl.MouseState = MaterialSkin.MouseState.HOVER;
            this.distanciaLbl.Name = "distanciaLbl";
            this.distanciaLbl.Size = new System.Drawing.Size(108, 19);
            this.distanciaLbl.TabIndex = 39;
            this.distanciaLbl.Text = "materialLabel3";
            // 
            // tiempoLbl
            // 
            this.tiempoLbl.AutoSize = true;
            this.tiempoLbl.Depth = 0;
            this.tiempoLbl.Font = new System.Drawing.Font("Roboto", 11F);
            this.tiempoLbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.tiempoLbl.Location = new System.Drawing.Point(506, 18);
            this.tiempoLbl.MouseState = MaterialSkin.MouseState.HOVER;
            this.tiempoLbl.Name = "tiempoLbl";
            this.tiempoLbl.Size = new System.Drawing.Size(108, 19);
            this.tiempoLbl.TabIndex = 40;
            this.tiempoLbl.Text = "materialLabel3";
            // 
            // RenglonDeTramo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tiempoLbl);
            this.Controls.Add(this.distanciaLbl);
            this.Controls.Add(this.materialFlatButton1);
            this.Controls.Add(this.destinoLbl);
            this.Controls.Add(this.origenLbl);
            this.Controls.Add(this.materialDivider1);
            this.Name = "RenglonDeTramo";
            this.Size = new System.Drawing.Size(731, 47);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialFlatButton materialFlatButton1;
        private MaterialSkin.Controls.MaterialLabel destinoLbl;
        private MaterialSkin.Controls.MaterialLabel origenLbl;
        private MaterialSkin.Controls.MaterialDivider materialDivider1;
        private MaterialSkin.Controls.MaterialLabel distanciaLbl;
        private MaterialSkin.Controls.MaterialLabel tiempoLbl;
    }
}
