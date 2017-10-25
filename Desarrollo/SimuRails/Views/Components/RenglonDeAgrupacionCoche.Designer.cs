namespace SimuRails.Views.Components
{
    partial class RenglonDeAgrupacionCoche
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
            this.cantidadLbl = new MaterialSkin.Controls.MaterialLabel();
            this.modeloLbl = new MaterialSkin.Controls.MaterialLabel();
            this.materialDivider1 = new MaterialSkin.Controls.MaterialDivider();
            this.SuspendLayout();
            // 
            // materialFlatButton1
            // 
            this.materialFlatButton1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.materialFlatButton1.AutoSize = true;
            this.materialFlatButton1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialFlatButton1.Depth = 0;
            this.materialFlatButton1.Location = new System.Drawing.Point(603, 10);
            this.materialFlatButton1.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.materialFlatButton1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialFlatButton1.Name = "materialFlatButton1";
            this.materialFlatButton1.Primary = false;
            this.materialFlatButton1.Size = new System.Drawing.Size(65, 36);
            this.materialFlatButton1.TabIndex = 30;
            this.materialFlatButton1.Text = "Borrar";
            this.materialFlatButton1.UseVisualStyleBackColor = true;
            this.materialFlatButton1.Click += new System.EventHandler(this.materialFlatButton1_Click);
            // 
            // cantidadLbl
            // 
            this.cantidadLbl.AutoSize = true;
            this.cantidadLbl.Depth = 0;
            this.cantidadLbl.Font = new System.Drawing.Font("Roboto", 11F);
            this.cantidadLbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.cantidadLbl.Location = new System.Drawing.Point(281, 18);
            this.cantidadLbl.MouseState = MaterialSkin.MouseState.HOVER;
            this.cantidadLbl.Name = "cantidadLbl";
            this.cantidadLbl.Size = new System.Drawing.Size(108, 18);
            this.cantidadLbl.TabIndex = 29;
            this.cantidadLbl.Text = "materialLabel3";
            // 
            // modeloLbl
            // 
            this.modeloLbl.AutoSize = true;
            this.modeloLbl.Depth = 0;
            this.modeloLbl.Font = new System.Drawing.Font("Roboto", 11F);
            this.modeloLbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.modeloLbl.Location = new System.Drawing.Point(17, 18);
            this.modeloLbl.MouseState = MaterialSkin.MouseState.HOVER;
            this.modeloLbl.Name = "modeloLbl";
            this.modeloLbl.Size = new System.Drawing.Size(108, 18);
            this.modeloLbl.TabIndex = 28;
            this.modeloLbl.Text = "materialLabel1";
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
            this.materialDivider1.Size = new System.Drawing.Size(673, 2);
            this.materialDivider1.TabIndex = 27;
            this.materialDivider1.Text = "materialDivider1";
            // 
            // RenglonDeAgrupacionCoche
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.materialFlatButton1);
            this.Controls.Add(this.cantidadLbl);
            this.Controls.Add(this.modeloLbl);
            this.Controls.Add(this.materialDivider1);
            this.Name = "RenglonDeAgrupacionCoche";
            this.Size = new System.Drawing.Size(672, 47);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialFlatButton materialFlatButton1;
        private MaterialSkin.Controls.MaterialLabel cantidadLbl;
        private MaterialSkin.Controls.MaterialLabel modeloLbl;
        private MaterialSkin.Controls.MaterialDivider materialDivider1;
    }
}
