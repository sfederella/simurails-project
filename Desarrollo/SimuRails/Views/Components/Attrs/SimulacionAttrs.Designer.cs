namespace SimuRails.Views.Components.Attrs
{
    partial class SimulacionAttrs
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
            this.nombreField = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.BindingSourceSimulacion = new System.Windows.Forms.BindingSource(this.components);
            this.BindingSourceTraza = new System.Windows.Forms.BindingSource(this.components);
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.duracionField = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.materialLabel5 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel7 = new MaterialSkin.Controls.MaterialLabel();
            this.ComboBoxTraza = new SimuRails.Report.MyComboBox();
            this.contadorMinutosText = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            this.infoMinutos = new System.Windows.Forms.Label();
            this.materialLabel3 = new MaterialSkin.Controls.MaterialLabel();
            ((System.ComponentModel.ISupportInitialize)(this.BindingSourceSimulacion)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BindingSourceTraza)).BeginInit();
            this.SuspendLayout();
            // 
            // nombreField
            // 
            this.nombreField.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.BindingSourceSimulacion, "Nombre", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.nombreField.Depth = 0;
            this.nombreField.Hint = "";
            this.nombreField.Location = new System.Drawing.Point(33, 42);
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
            // BindingSourceSimulacion
            // 
            this.BindingSourceSimulacion.DataSource = typeof(SimuRails.Models.Simulacion);
            // 
            // BindingSourceTraza
            // 
            this.BindingSourceTraza.DataSource = typeof(SimuRails.Models.Traza);
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel1.Location = new System.Drawing.Point(29, 78);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(112, 19);
            this.materialLabel1.TabIndex = 13;
            this.materialLabel1.Text = "Traza a simular";
            // 
            // duracionField
            // 
            this.duracionField.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.BindingSourceSimulacion, "Duracion", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged, null, "N0"));
            this.duracionField.Depth = 0;
            this.duracionField.Hint = "";
            this.duracionField.Location = new System.Drawing.Point(329, 42);
            this.duracionField.MaxLength = 32767;
            this.duracionField.MouseState = MaterialSkin.MouseState.HOVER;
            this.duracionField.Name = "duracionField";
            this.duracionField.PasswordChar = '\0';
            this.duracionField.SelectedText = "";
            this.duracionField.SelectionLength = 0;
            this.duracionField.SelectionStart = 0;
            this.duracionField.Size = new System.Drawing.Size(113, 23);
            this.duracionField.TabIndex = 1;
            this.duracionField.TabStop = false;
            this.duracionField.UseSystemPasswordChar = false;
            this.duracionField.KeyUp += new System.Windows.Forms.KeyEventHandler(this.duracionField_KeyUp);
            // 
            // materialLabel5
            // 
            this.materialLabel5.AutoSize = true;
            this.materialLabel5.Depth = 0;
            this.materialLabel5.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel5.Location = new System.Drawing.Point(325, 20);
            this.materialLabel5.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel5.Name = "materialLabel5";
            this.materialLabel5.Size = new System.Drawing.Size(69, 19);
            this.materialLabel5.TabIndex = 20;
            this.materialLabel5.Text = "Duración";
            // 
            // materialLabel7
            // 
            this.materialLabel7.AutoSize = true;
            this.materialLabel7.Depth = 0;
            this.materialLabel7.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel7.Location = new System.Drawing.Point(29, 20);
            this.materialLabel7.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel7.Name = "materialLabel7";
            this.materialLabel7.Size = new System.Drawing.Size(63, 19);
            this.materialLabel7.TabIndex = 22;
            this.materialLabel7.Text = "Nombre";
            // 
            // ComboBoxTraza
            // 
            this.ComboBoxTraza.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.ComboBoxTraza.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.ComboBoxTraza.BackColor = System.Drawing.SystemColors.Control;
            this.ComboBoxTraza.DataBindings.Add(new System.Windows.Forms.Binding("SelectedItem", this.BindingSourceSimulacion, "TrazaSimulada", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.ComboBoxTraza.DataSource = this.BindingSourceTraza;
            this.ComboBoxTraza.DisplayMember = "Nombre";
            this.ComboBoxTraza.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.ComboBoxTraza.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ComboBoxTraza.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ComboBoxTraza.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(35)))), ((int)(((byte)(49)))));
            this.ComboBoxTraza.FormattingEnabled = true;
            this.ComboBoxTraza.Location = new System.Drawing.Point(33, 105);
            this.ComboBoxTraza.Name = "ComboBoxTraza";
            this.ComboBoxTraza.Size = new System.Drawing.Size(270, 25);
            this.ComboBoxTraza.TabIndex = 23;
            // 
            // contadorMinutosText
            // 
            this.contadorMinutosText.AutoSize = true;
            this.contadorMinutosText.Depth = 0;
            this.contadorMinutosText.Font = new System.Drawing.Font("Roboto", 11F);
            this.contadorMinutosText.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.contadorMinutosText.Location = new System.Drawing.Point(519, 46);
            this.contadorMinutosText.MouseState = MaterialSkin.MouseState.HOVER;
            this.contadorMinutosText.Name = "contadorMinutosText";
            this.contadorMinutosText.Size = new System.Drawing.Size(17, 19);
            this.contadorMinutosText.TabIndex = 24;
            this.contadorMinutosText.Text = "0";
            // 
            // materialLabel2
            // 
            this.materialLabel2.AutoSize = true;
            this.materialLabel2.Depth = 0;
            this.materialLabel2.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel2.Location = new System.Drawing.Point(519, 20);
            this.materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel2.Name = "materialLabel2";
            this.materialLabel2.Size = new System.Drawing.Size(64, 19);
            this.materialLabel2.TabIndex = 25;
            this.materialLabel2.Text = "Minutos";
            // 
            // infoMinutos
            // 
            this.infoMinutos.BackColor = System.Drawing.Color.Transparent;
            this.infoMinutos.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.infoMinutos.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.infoMinutos.Image = global::SimuRails.Properties.Resources.ic_info_outline_black_18dp;
            this.infoMinutos.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.infoMinutos.Location = new System.Drawing.Point(584, 19);
            this.infoMinutos.Name = "infoMinutos";
            this.infoMinutos.Size = new System.Drawing.Size(24, 23);
            this.infoMinutos.TabIndex = 26;
            this.infoMinutos.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.infoMinutos.Click += new System.EventHandler(this.infoMinutos_Click);
            // 
            // materialLabel3
            // 
            this.materialLabel3.AutoSize = true;
            this.materialLabel3.Depth = 0;
            this.materialLabel3.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel3.Location = new System.Drawing.Point(448, 46);
            this.materialLabel3.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel3.Name = "materialLabel3";
            this.materialLabel3.Size = new System.Drawing.Size(37, 19);
            this.materialLabel3.TabIndex = 27;
            this.materialLabel3.Text = "días";
            // 
            // SimulacionAttrs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.Controls.Add(this.materialLabel3);
            this.Controls.Add(this.infoMinutos);
            this.Controls.Add(this.materialLabel2);
            this.Controls.Add(this.contadorMinutosText);
            this.Controls.Add(this.ComboBoxTraza);
            this.Controls.Add(this.materialLabel7);
            this.Controls.Add(this.materialLabel5);
            this.Controls.Add(this.duracionField);
            this.Controls.Add(this.materialLabel1);
            this.Controls.Add(this.nombreField);
            this.Name = "SimulacionAttrs";
            this.Size = new System.Drawing.Size(791, 291);
            ((System.ComponentModel.ISupportInitialize)(this.BindingSourceSimulacion)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BindingSourceTraza)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialSingleLineTextField nombreField;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private MaterialSkin.Controls.MaterialSingleLineTextField duracionField;
        private MaterialSkin.Controls.MaterialLabel materialLabel5;
        private MaterialSkin.Controls.MaterialLabel materialLabel7;
        private System.Windows.Forms.BindingSource BindingSourceSimulacion;
        private System.Windows.Forms.BindingSource BindingSourceTraza;
        private Report.MyComboBox ComboBoxTraza;
        private MaterialSkin.Controls.MaterialLabel contadorMinutosText;
        private MaterialSkin.Controls.MaterialLabel materialLabel2;
        private System.Windows.Forms.Label infoMinutos;
        private MaterialSkin.Controls.MaterialLabel materialLabel3;
    }
}
