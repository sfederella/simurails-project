namespace SimuRails.Views.Components.Attrs
{
    partial class IncidenteAttrs
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
            this.materialLabel4 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel3 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.demoraField = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.BindingSourceIncidente = new System.Windows.Forms.BindingSource(this.components);
            this.probabilidadField = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.nombreField = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.descripcionField = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.materialDivider1 = new MaterialSkin.Controls.MaterialDivider();
            this.materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            this.errorNombreLbl = new System.Windows.Forms.Label();
            this.errorOcurrenciaLbl = new System.Windows.Forms.Label();
            this.errorDemoraLbl = new System.Windows.Forms.Label();
            this.materialLabel5 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel6 = new MaterialSkin.Controls.MaterialLabel();
            ((System.ComponentModel.ISupportInitialize)(this.BindingSourceIncidente)).BeginInit();
            this.SuspendLayout();
            // 
            // materialLabel7
            // 
            this.materialLabel7.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.materialLabel7.AutoSize = true;
            this.materialLabel7.Depth = 0;
            this.materialLabel7.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel7.Location = new System.Drawing.Point(16, 20);
            this.materialLabel7.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel7.Name = "materialLabel7";
            this.materialLabel7.Size = new System.Drawing.Size(63, 19);
            this.materialLabel7.TabIndex = 37;
            this.materialLabel7.Text = "Nombre";
            // 
            // materialLabel4
            // 
            this.materialLabel4.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.materialLabel4.AutoSize = true;
            this.materialLabel4.Depth = 0;
            this.materialLabel4.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel4.Location = new System.Drawing.Point(320, 225);
            this.materialLabel4.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel4.Name = "materialLabel4";
            this.materialLabel4.Size = new System.Drawing.Size(135, 19);
            this.materialLabel4.TabIndex = 34;
            this.materialLabel4.Text = "Tiempo de demora";
            // 
            // materialLabel3
            // 
            this.materialLabel3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.materialLabel3.AutoSize = true;
            this.materialLabel3.Depth = 0;
            this.materialLabel3.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel3.Location = new System.Drawing.Point(29, 225);
            this.materialLabel3.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel3.Name = "materialLabel3";
            this.materialLabel3.Size = new System.Drawing.Size(187, 19);
            this.materialLabel3.TabIndex = 33;
            this.materialLabel3.Text = "Probabilidad de ocurrencia";
            // 
            // materialLabel1
            // 
            this.materialLabel1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel1.Location = new System.Drawing.Point(16, 93);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(89, 19);
            this.materialLabel1.TabIndex = 28;
            this.materialLabel1.Text = "Descripción";
            // 
            // demoraField
            // 
            this.demoraField.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.demoraField.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.BindingSourceIncidente, "TiempoDemora", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged, null, "N0"));
            this.demoraField.Depth = 0;
            this.demoraField.Hint = "";
            this.demoraField.IsNumeric = false;
            this.demoraField.Location = new System.Drawing.Point(324, 252);
            this.demoraField.MaxLength = 32767;
            this.demoraField.MouseState = MaterialSkin.MouseState.HOVER;
            this.demoraField.Name = "demoraField";
            this.demoraField.PasswordChar = '\0';
            this.demoraField.SelectedText = "";
            this.demoraField.SelectionLength = 0;
            this.demoraField.SelectionStart = 0;
            this.demoraField.Size = new System.Drawing.Size(89, 23);
            this.demoraField.TabIndex = 3;
            this.demoraField.TabStop = false;
            this.demoraField.UseSystemPasswordChar = false;
            // 
            // BindingSourceIncidente
            // 
            this.BindingSourceIncidente.DataSource = typeof(SimuRails.Models.Incidente);
            // 
            // probabilidadField
            // 
            this.probabilidadField.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.probabilidadField.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.BindingSourceIncidente, "ProbabilidadDeOcurrencia", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged, null, "N0"));
            this.probabilidadField.Depth = 0;
            this.probabilidadField.Hint = "";
            this.probabilidadField.IsNumeric = false;
            this.probabilidadField.Location = new System.Drawing.Point(33, 251);
            this.probabilidadField.MaxLength = 32767;
            this.probabilidadField.MouseState = MaterialSkin.MouseState.HOVER;
            this.probabilidadField.Name = "probabilidadField";
            this.probabilidadField.PasswordChar = '\0';
            this.probabilidadField.SelectedText = "";
            this.probabilidadField.SelectionLength = 0;
            this.probabilidadField.SelectionStart = 0;
            this.probabilidadField.Size = new System.Drawing.Size(72, 23);
            this.probabilidadField.TabIndex = 2;
            this.probabilidadField.TabStop = false;
            this.probabilidadField.UseSystemPasswordChar = false;
            // 
            // nombreField
            // 
            this.nombreField.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.nombreField.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.BindingSourceIncidente, "Nombre", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.nombreField.Depth = 0;
            this.nombreField.Hint = "";
            this.nombreField.IsNumeric = false;
            this.nombreField.Location = new System.Drawing.Point(20, 42);
            this.nombreField.MaxLength = 32767;
            this.nombreField.MouseState = MaterialSkin.MouseState.HOVER;
            this.nombreField.Name = "nombreField";
            this.nombreField.PasswordChar = '\0';
            this.nombreField.SelectedText = "";
            this.nombreField.SelectionLength = 0;
            this.nombreField.SelectionStart = 0;
            this.nombreField.Size = new System.Drawing.Size(270, 23);
            this.nombreField.TabIndex = 0;
            this.nombreField.TabStop = false;
            this.nombreField.UseSystemPasswordChar = false;
            // 
            // descripcionField
            // 
            this.descripcionField.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.descripcionField.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.BindingSourceIncidente, "Descripcion", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.descripcionField.Depth = 0;
            this.descripcionField.Hint = "";
            this.descripcionField.IsNumeric = false;
            this.descripcionField.Location = new System.Drawing.Point(20, 115);
            this.descripcionField.MaxLength = 32767;
            this.descripcionField.MouseState = MaterialSkin.MouseState.HOVER;
            this.descripcionField.Name = "descripcionField";
            this.descripcionField.PasswordChar = '\0';
            this.descripcionField.SelectedText = "";
            this.descripcionField.SelectionLength = 0;
            this.descripcionField.SelectionStart = 0;
            this.descripcionField.Size = new System.Drawing.Size(673, 23);
            this.descripcionField.TabIndex = 1;
            this.descripcionField.TabStop = false;
            this.descripcionField.UseSystemPasswordChar = false;
            // 
            // materialDivider1
            // 
            this.materialDivider1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.materialDivider1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialDivider1.Depth = 0;
            this.materialDivider1.Location = new System.Drawing.Point(2, 172);
            this.materialDivider1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialDivider1.Name = "materialDivider1";
            this.materialDivider1.Size = new System.Drawing.Size(787, 2);
            this.materialDivider1.TabIndex = 31;
            this.materialDivider1.Text = "materialDivider1";
            // 
            // materialLabel2
            // 
            this.materialLabel2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.materialLabel2.AutoSize = true;
            this.materialLabel2.Depth = 0;
            this.materialLabel2.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel2.Location = new System.Drawing.Point(16, 189);
            this.materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel2.Name = "materialLabel2";
            this.materialLabel2.Size = new System.Drawing.Size(55, 19);
            this.materialLabel2.TabIndex = 32;
            this.materialLabel2.Text = "Riesgo";
            // 
            // errorNombreLbl
            // 
            this.errorNombreLbl.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.errorNombreLbl.AutoSize = true;
            this.errorNombreLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.errorNombreLbl.ForeColor = System.Drawing.Color.DarkRed;
            this.errorNombreLbl.Location = new System.Drawing.Point(17, 68);
            this.errorNombreLbl.Name = "errorNombreLbl";
            this.errorNombreLbl.Size = new System.Drawing.Size(167, 15);
            this.errorNombreLbl.TabIndex = 38;
            this.errorNombreLbl.Text = "Este campo es requerido";
            this.errorNombreLbl.Visible = false;
            // 
            // errorOcurrenciaLbl
            // 
            this.errorOcurrenciaLbl.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.errorOcurrenciaLbl.AutoSize = true;
            this.errorOcurrenciaLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.errorOcurrenciaLbl.ForeColor = System.Drawing.Color.DarkRed;
            this.errorOcurrenciaLbl.Location = new System.Drawing.Point(30, 277);
            this.errorOcurrenciaLbl.Name = "errorOcurrenciaLbl";
            this.errorOcurrenciaLbl.Size = new System.Drawing.Size(167, 15);
            this.errorOcurrenciaLbl.TabIndex = 40;
            this.errorOcurrenciaLbl.Text = "Este campo es requerido";
            this.errorOcurrenciaLbl.Visible = false;
            // 
            // errorDemoraLbl
            // 
            this.errorDemoraLbl.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.errorDemoraLbl.AutoSize = true;
            this.errorDemoraLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.errorDemoraLbl.ForeColor = System.Drawing.Color.DarkRed;
            this.errorDemoraLbl.Location = new System.Drawing.Point(321, 278);
            this.errorDemoraLbl.Name = "errorDemoraLbl";
            this.errorDemoraLbl.Size = new System.Drawing.Size(167, 15);
            this.errorDemoraLbl.TabIndex = 41;
            this.errorDemoraLbl.Text = "Este campo es requerido";
            this.errorDemoraLbl.Visible = false;
            // 
            // materialLabel5
            // 
            this.materialLabel5.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.materialLabel5.AutoSize = true;
            this.materialLabel5.Depth = 0;
            this.materialLabel5.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel5.Location = new System.Drawing.Point(111, 251);
            this.materialLabel5.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel5.Name = "materialLabel5";
            this.materialLabel5.Size = new System.Drawing.Size(20, 19);
            this.materialLabel5.TabIndex = 42;
            this.materialLabel5.Text = "%";
            // 
            // materialLabel6
            // 
            this.materialLabel6.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.materialLabel6.AutoSize = true;
            this.materialLabel6.Depth = 0;
            this.materialLabel6.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel6.Location = new System.Drawing.Point(419, 255);
            this.materialLabel6.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel6.Name = "materialLabel6";
            this.materialLabel6.Size = new System.Drawing.Size(64, 19);
            this.materialLabel6.TabIndex = 43;
            this.materialLabel6.Text = "minutos";
            // 
            // IncidenteAttrs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.Controls.Add(this.materialLabel6);
            this.Controls.Add(this.materialLabel5);
            this.Controls.Add(this.errorDemoraLbl);
            this.Controls.Add(this.errorOcurrenciaLbl);
            this.Controls.Add(this.errorNombreLbl);
            this.Controls.Add(this.descripcionField);
            this.Controls.Add(this.materialLabel7);
            this.Controls.Add(this.materialLabel4);
            this.Controls.Add(this.materialLabel3);
            this.Controls.Add(this.materialLabel2);
            this.Controls.Add(this.materialDivider1);
            this.Controls.Add(this.materialLabel1);
            this.Controls.Add(this.demoraField);
            this.Controls.Add(this.probabilidadField);
            this.Controls.Add(this.nombreField);
            this.Name = "IncidenteAttrs";
            this.Size = new System.Drawing.Size(791, 323);
            ((System.ComponentModel.ISupportInitialize)(this.BindingSourceIncidente)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialLabel materialLabel7;
        private MaterialSkin.Controls.MaterialLabel materialLabel4;
        private MaterialSkin.Controls.MaterialLabel materialLabel3;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private MaterialSkin.Controls.MaterialSingleLineTextField demoraField;
        private MaterialSkin.Controls.MaterialSingleLineTextField probabilidadField;
        private MaterialSkin.Controls.MaterialSingleLineTextField nombreField;
        private MaterialSkin.Controls.MaterialSingleLineTextField descripcionField;
        private MaterialSkin.Controls.MaterialDivider materialDivider1;
        private MaterialSkin.Controls.MaterialLabel materialLabel2;
        private System.Windows.Forms.BindingSource BindingSourceIncidente;
        private System.Windows.Forms.Label errorNombreLbl;
        private System.Windows.Forms.Label errorOcurrenciaLbl;
        private System.Windows.Forms.Label errorDemoraLbl;
        private MaterialSkin.Controls.MaterialLabel materialLabel5;
        private MaterialSkin.Controls.MaterialLabel materialLabel6;
    }
}
