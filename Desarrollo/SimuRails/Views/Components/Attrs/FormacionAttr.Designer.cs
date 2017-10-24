namespace SimuRails.Views.Components.Attrs
{
    partial class FormacionAttr
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
            this.components = new System.ComponentModel.Container();
            this.materialLabel7 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel6 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel5 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            this.materialDivider1 = new MaterialSkin.Controls.MaterialDivider();
            this.consumoParadoField = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.consumoAndandoField = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.modeloField = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.bindingSourceFormacion = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceFormacion)).BeginInit();
            this.SuspendLayout();
            // 
            // materialLabel7
            // 
            this.materialLabel7.AutoSize = true;
            this.materialLabel7.Depth = 0;
            this.materialLabel7.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel7.Location = new System.Drawing.Point(16, 20);
            this.materialLabel7.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel7.Name = "materialLabel7";
            this.materialLabel7.Size = new System.Drawing.Size(63, 19);
            this.materialLabel7.TabIndex = 41;
            this.materialLabel7.Text = "Nombre";
            // 
            // materialLabel6
            // 
            this.materialLabel6.AutoSize = true;
            this.materialLabel6.Depth = 0;
            this.materialLabel6.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel6.Location = new System.Drawing.Point(257, 121);
            this.materialLabel6.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel6.Name = "materialLabel6";
            this.materialLabel6.Size = new System.Drawing.Size(69, 19);
            this.materialLabel6.TabIndex = 40;
            this.materialLabel6.Text = "Duración";
            // 
            // materialLabel5
            // 
            this.materialLabel5.AutoSize = true;
            this.materialLabel5.Depth = 0;
            this.materialLabel5.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel5.Location = new System.Drawing.Point(29, 121);
            this.materialLabel5.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel5.Name = "materialLabel5";
            this.materialLabel5.Size = new System.Drawing.Size(64, 19);
            this.materialLabel5.TabIndex = 39;
            this.materialLabel5.Text = "Vida útil";
            // 
            // materialLabel2
            // 
            this.materialLabel2.AutoSize = true;
            this.materialLabel2.Depth = 0;
            this.materialLabel2.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel2.Location = new System.Drawing.Point(16, 212);
            this.materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel2.Name = "materialLabel2";
            this.materialLabel2.Size = new System.Drawing.Size(60, 19);
            this.materialLabel2.TabIndex = 36;
            this.materialLabel2.Text = "Coches";
            // 
            // materialDivider1
            // 
            this.materialDivider1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.materialDivider1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialDivider1.Depth = 0;
            this.materialDivider1.Location = new System.Drawing.Point(1, 184);
            this.materialDivider1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialDivider1.Name = "materialDivider1";
            this.materialDivider1.Size = new System.Drawing.Size(787, 2);
            this.materialDivider1.TabIndex = 35;
            this.materialDivider1.Text = "materialDivider1";
            // 
            // consumoParadoField
            // 
            this.consumoParadoField.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bindingSourceFormacion, "DuracionMantenimiento", true));
            this.consumoParadoField.Depth = 0;
            this.consumoParadoField.Hint = "Min";
            this.consumoParadoField.Location = new System.Drawing.Point(261, 143);
            this.consumoParadoField.MouseState = MaterialSkin.MouseState.HOVER;
            this.consumoParadoField.Name = "consumoParadoField";
            this.consumoParadoField.PasswordChar = '\0';
            this.consumoParadoField.SelectedText = "";
            this.consumoParadoField.SelectionLength = 0;
            this.consumoParadoField.SelectionStart = 0;
            this.consumoParadoField.Size = new System.Drawing.Size(148, 23);
            this.consumoParadoField.TabIndex = 30;
            this.consumoParadoField.UseSystemPasswordChar = false;
            // 
            // consumoAndandoField
            // 
            this.consumoAndandoField.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bindingSourceFormacion, "KilometrosMantenimiento", true));
            this.consumoAndandoField.Depth = 0;
            this.consumoAndandoField.Hint = "Kms";
            this.consumoAndandoField.Location = new System.Drawing.Point(33, 143);
            this.consumoAndandoField.MouseState = MaterialSkin.MouseState.HOVER;
            this.consumoAndandoField.Name = "consumoAndandoField";
            this.consumoAndandoField.PasswordChar = '\0';
            this.consumoAndandoField.SelectedText = "";
            this.consumoAndandoField.SelectionLength = 0;
            this.consumoAndandoField.SelectionStart = 0;
            this.consumoAndandoField.Size = new System.Drawing.Size(148, 23);
            this.consumoAndandoField.TabIndex = 29;
            this.consumoAndandoField.UseSystemPasswordChar = false;
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel1.Location = new System.Drawing.Point(16, 93);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(110, 19);
            this.materialLabel1.TabIndex = 34;
            this.materialLabel1.Text = "Mantenimiento";
            // 
            // modeloField
            // 
            this.modeloField.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bindingSourceFormacion, "Nombre", true));
            this.modeloField.Depth = 0;
            this.modeloField.Hint = "";
            this.modeloField.Location = new System.Drawing.Point(20, 42);
            this.modeloField.MouseState = MaterialSkin.MouseState.HOVER;
            this.modeloField.Name = "modeloField";
            this.modeloField.PasswordChar = '\0';
            this.modeloField.SelectedText = "";
            this.modeloField.SelectionLength = 0;
            this.modeloField.SelectionStart = 0;
            this.modeloField.Size = new System.Drawing.Size(270, 23);
            this.modeloField.TabIndex = 26;
            this.modeloField.UseSystemPasswordChar = false;
            // 
            // bindingSourceFormacion
            // 
            this.bindingSourceFormacion.DataSource = typeof(SimuRails.Models.Formacion);
            // 
            // FormacionAttr
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.Controls.Add(this.materialLabel7);
            this.Controls.Add(this.materialLabel6);
            this.Controls.Add(this.materialLabel5);
            this.Controls.Add(this.materialLabel2);
            this.Controls.Add(this.materialDivider1);
            this.Controls.Add(this.consumoParadoField);
            this.Controls.Add(this.consumoAndandoField);
            this.Controls.Add(this.materialLabel1);
            this.Controls.Add(this.modeloField);
            this.Name = "FormacionAttr";
            this.Size = new System.Drawing.Size(791, 346);
            this.Load += new System.EventHandler(this.FormacionAttr_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceFormacion)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private MaterialSkin.Controls.MaterialLabel materialLabel7;
        private MaterialSkin.Controls.MaterialLabel materialLabel6;
        private MaterialSkin.Controls.MaterialLabel materialLabel5;
        private MaterialSkin.Controls.MaterialLabel materialLabel2;
        private MaterialSkin.Controls.MaterialDivider materialDivider1;
        private MaterialSkin.Controls.MaterialSingleLineTextField consumoParadoField;
        private MaterialSkin.Controls.MaterialSingleLineTextField consumoAndandoField;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private MaterialSkin.Controls.MaterialSingleLineTextField modeloField;
        private System.Windows.Forms.BindingSource bindingSourceFormacion;
    }
}
