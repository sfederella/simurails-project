namespace SimuRails.Views.Components
{
    partial class CocheAttrs
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
            this.modeloField = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.locomotoraCheck = new MaterialSkin.Controls.MaterialCheckBox();
            this.capacidadLegalField = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.capacidadTotalField = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.consumoCombo = new System.Windows.Forms.ComboBox();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.consumoParadoField = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.consumoAndandoField = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.materialDivider1 = new MaterialSkin.Controls.MaterialDivider();
            this.materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel3 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel4 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel5 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel6 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel7 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel8 = new MaterialSkin.Controls.MaterialLabel();
            this.materialSingleLineTextField1 = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.BindingSourceCoche = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.BindingSourceCoche)).BeginInit();
            this.SuspendLayout();
            // 
            // modeloField
            // 
            this.modeloField.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.BindingSourceCoche, "Modelo", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.modeloField.Depth = 0;
            this.modeloField.Hint = "";
            this.modeloField.Location = new System.Drawing.Point(21, 42);
            this.modeloField.MouseState = MaterialSkin.MouseState.HOVER;
            this.modeloField.Name = "modeloField";
            this.modeloField.PasswordChar = '\0';
            this.modeloField.SelectedText = "";
            this.modeloField.SelectionLength = 0;
            this.modeloField.SelectionStart = 0;
            this.modeloField.Size = new System.Drawing.Size(270, 23);
            this.modeloField.TabIndex = 0;
            this.modeloField.UseSystemPasswordChar = false;
            // 
            // locomotoraCheck
            // 
            this.locomotoraCheck.AutoSize = true;
            this.locomotoraCheck.DataBindings.Add(new System.Windows.Forms.Binding("Checked", this.BindingSourceCoche, "EsLocomotora", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.locomotoraCheck.Depth = 0;
            this.locomotoraCheck.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.locomotoraCheck.Location = new System.Drawing.Point(346, 35);
            this.locomotoraCheck.Margin = new System.Windows.Forms.Padding(0);
            this.locomotoraCheck.MouseLocation = new System.Drawing.Point(-1, -1);
            this.locomotoraCheck.MouseState = MaterialSkin.MouseState.HOVER;
            this.locomotoraCheck.Name = "locomotoraCheck";
            this.locomotoraCheck.Ripple = true;
            this.locomotoraCheck.Size = new System.Drawing.Size(105, 30);
            this.locomotoraCheck.TabIndex = 1;
            this.locomotoraCheck.Text = "Locomotora";
            this.locomotoraCheck.UseVisualStyleBackColor = true;
            // 
            // capacidadLegalField
            // 
            this.capacidadLegalField.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.BindingSourceCoche, "MaximoLegalPasajeros", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged, null, "N0"));
            this.capacidadLegalField.Depth = 0;
            this.capacidadLegalField.Hint = "Personas";
            this.capacidadLegalField.Location = new System.Drawing.Point(34, 247);
            this.capacidadLegalField.MouseState = MaterialSkin.MouseState.HOVER;
            this.capacidadLegalField.Name = "capacidadLegalField";
            this.capacidadLegalField.PasswordChar = '\0';
            this.capacidadLegalField.SelectedText = "";
            this.capacidadLegalField.SelectionLength = 0;
            this.capacidadLegalField.SelectionStart = 0;
            this.capacidadLegalField.Size = new System.Drawing.Size(148, 23);
            this.capacidadLegalField.TabIndex = 5;
            this.capacidadLegalField.UseSystemPasswordChar = false;
            // 
            // capacidadTotalField
            // 
            this.capacidadTotalField.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.BindingSourceCoche, "CapacidadMaximaPasajeros", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged, null, "N0"));
            this.capacidadTotalField.Depth = 0;
            this.capacidadTotalField.Hint = "Personas";
            this.capacidadTotalField.Location = new System.Drawing.Point(325, 247);
            this.capacidadTotalField.MouseState = MaterialSkin.MouseState.HOVER;
            this.capacidadTotalField.Name = "capacidadTotalField";
            this.capacidadTotalField.PasswordChar = '\0';
            this.capacidadTotalField.SelectedText = "";
            this.capacidadTotalField.SelectionLength = 0;
            this.capacidadTotalField.SelectionStart = 0;
            this.capacidadTotalField.Size = new System.Drawing.Size(148, 23);
            this.capacidadTotalField.TabIndex = 6;
            this.capacidadTotalField.UseSystemPasswordChar = false;
            // 
            // consumoCombo
            // 
            this.consumoCombo.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.BindingSourceCoche, "TipoDeConsumo", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.consumoCombo.Enabled = false;
            this.consumoCombo.FormattingEnabled = true;
            this.consumoCombo.Items.AddRange(new object[] {
            "Electrico",
            "Diesel",
            "Carbón"});
            this.consumoCombo.Location = new System.Drawing.Point(21, 135);
            this.consumoCombo.Name = "consumoCombo";
            this.consumoCombo.Size = new System.Drawing.Size(213, 21);
            this.consumoCombo.TabIndex = 2;
            this.consumoCombo.Text = "Seleccionar...";
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.materialLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel1.Location = new System.Drawing.Point(17, 93);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(74, 18);
            this.materialLabel1.TabIndex = 13;
            this.materialLabel1.Text = "Consumo";
            // 
            // consumoParadoField
            // 
            this.consumoParadoField.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.BindingSourceCoche, "ConsumoParado", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged, null, "N0"));
            this.consumoParadoField.Depth = 0;
            this.consumoParadoField.Hint = "$";
            this.consumoParadoField.Location = new System.Drawing.Point(553, 135);
            this.consumoParadoField.MouseState = MaterialSkin.MouseState.HOVER;
            this.consumoParadoField.Name = "consumoParadoField";
            this.consumoParadoField.PasswordChar = '\0';
            this.consumoParadoField.SelectedText = "";
            this.consumoParadoField.SelectionLength = 0;
            this.consumoParadoField.SelectionStart = 0;
            this.consumoParadoField.Size = new System.Drawing.Size(148, 23);
            this.consumoParadoField.TabIndex = 4;
            this.consumoParadoField.UseSystemPasswordChar = false;
            // 
            // consumoAndandoField
            // 
            this.consumoAndandoField.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.BindingSourceCoche, "ConsumoMovimiento", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged, null, "N0"));
            this.consumoAndandoField.Depth = 0;
            this.consumoAndandoField.Hint = "$";
            this.consumoAndandoField.Location = new System.Drawing.Point(325, 135);
            this.consumoAndandoField.MouseState = MaterialSkin.MouseState.HOVER;
            this.consumoAndandoField.Name = "consumoAndandoField";
            this.consumoAndandoField.PasswordChar = '\0';
            this.consumoAndandoField.SelectedText = "";
            this.consumoAndandoField.SelectionLength = 0;
            this.consumoAndandoField.SelectionStart = 0;
            this.consumoAndandoField.Size = new System.Drawing.Size(148, 23);
            this.consumoAndandoField.TabIndex = 3;
            this.consumoAndandoField.UseSystemPasswordChar = false;
            // 
            // materialDivider1
            // 
            this.materialDivider1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.materialDivider1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialDivider1.Depth = 0;
            this.materialDivider1.Location = new System.Drawing.Point(3, 172);
            this.materialDivider1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialDivider1.Name = "materialDivider1";
            this.materialDivider1.Size = new System.Drawing.Size(787, 2);
            this.materialDivider1.TabIndex = 16;
            this.materialDivider1.Text = "materialDivider1";
            // 
            // materialLabel2
            // 
            this.materialLabel2.AutoSize = true;
            this.materialLabel2.Depth = 0;
            this.materialLabel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.materialLabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel2.Location = new System.Drawing.Point(17, 189);
            this.materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel2.Name = "materialLabel2";
            this.materialLabel2.Size = new System.Drawing.Size(78, 18);
            this.materialLabel2.TabIndex = 17;
            this.materialLabel2.Text = "Capacidad";
            // 
            // materialLabel3
            // 
            this.materialLabel3.AutoSize = true;
            this.materialLabel3.Depth = 0;
            this.materialLabel3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.materialLabel3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel3.Location = new System.Drawing.Point(30, 225);
            this.materialLabel3.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel3.Name = "materialLabel3";
            this.materialLabel3.Size = new System.Drawing.Size(43, 18);
            this.materialLabel3.TabIndex = 18;
            this.materialLabel3.Text = "Legal";
            // 
            // materialLabel4
            // 
            this.materialLabel4.AutoSize = true;
            this.materialLabel4.Depth = 0;
            this.materialLabel4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.materialLabel4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel4.Location = new System.Drawing.Point(321, 225);
            this.materialLabel4.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel4.Name = "materialLabel4";
            this.materialLabel4.Size = new System.Drawing.Size(60, 18);
            this.materialLabel4.TabIndex = 19;
            this.materialLabel4.Text = "Máxima";
            // 
            // materialLabel5
            // 
            this.materialLabel5.AutoSize = true;
            this.materialLabel5.Depth = 0;
            this.materialLabel5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.materialLabel5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel5.Location = new System.Drawing.Point(321, 113);
            this.materialLabel5.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel5.Name = "materialLabel5";
            this.materialLabel5.Size = new System.Drawing.Size(107, 18);
            this.materialLabel5.TabIndex = 20;
            this.materialLabel5.Text = "En Movimiento";
            // 
            // materialLabel6
            // 
            this.materialLabel6.AutoSize = true;
            this.materialLabel6.Depth = 0;
            this.materialLabel6.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.materialLabel6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel6.Location = new System.Drawing.Point(549, 113);
            this.materialLabel6.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel6.Name = "materialLabel6";
            this.materialLabel6.Size = new System.Drawing.Size(56, 18);
            this.materialLabel6.TabIndex = 21;
            this.materialLabel6.Text = "Parado";
            // 
            // materialLabel7
            // 
            this.materialLabel7.AutoSize = true;
            this.materialLabel7.Depth = 0;
            this.materialLabel7.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.materialLabel7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel7.Location = new System.Drawing.Point(17, 20);
            this.materialLabel7.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel7.Name = "materialLabel7";
            this.materialLabel7.Size = new System.Drawing.Size(58, 18);
            this.materialLabel7.TabIndex = 22;
            this.materialLabel7.Text = "Modelo";
            // 
            // materialLabel8
            // 
            this.materialLabel8.AutoSize = true;
            this.materialLabel8.Depth = 0;
            this.materialLabel8.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.materialLabel8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel8.Location = new System.Drawing.Point(560, 225);
            this.materialLabel8.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel8.Name = "materialLabel8";
            this.materialLabel8.Size = new System.Drawing.Size(146, 18);
            this.materialLabel8.TabIndex = 25;
            this.materialLabel8.Text = "Cantidad de asientos";
            // 
            // materialSingleLineTextField1
            // 
            this.materialSingleLineTextField1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.BindingSourceCoche, "CantidadAsientos", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged, null, "N0"));
            this.materialSingleLineTextField1.Depth = 0;
            this.materialSingleLineTextField1.Hint = "Asientos";
            this.materialSingleLineTextField1.Location = new System.Drawing.Point(564, 247);
            this.materialSingleLineTextField1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialSingleLineTextField1.Name = "materialSingleLineTextField1";
            this.materialSingleLineTextField1.PasswordChar = '\0';
            this.materialSingleLineTextField1.SelectedText = "";
            this.materialSingleLineTextField1.SelectionLength = 0;
            this.materialSingleLineTextField1.SelectionStart = 0;
            this.materialSingleLineTextField1.Size = new System.Drawing.Size(148, 23);
            this.materialSingleLineTextField1.TabIndex = 7;
            this.materialSingleLineTextField1.UseSystemPasswordChar = false;
            // 
            // BindingSourceCoche
            // 
            this.BindingSourceCoche.DataSource = typeof(SimuRails.Models.Coche);
            // 
            // CocheAttrs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.Controls.Add(this.materialLabel8);
            this.Controls.Add(this.materialSingleLineTextField1);
            this.Controls.Add(this.materialLabel7);
            this.Controls.Add(this.materialLabel6);
            this.Controls.Add(this.materialLabel5);
            this.Controls.Add(this.materialLabel4);
            this.Controls.Add(this.materialLabel3);
            this.Controls.Add(this.materialLabel2);
            this.Controls.Add(this.materialDivider1);
            this.Controls.Add(this.consumoParadoField);
            this.Controls.Add(this.consumoAndandoField);
            this.Controls.Add(this.materialLabel1);
            this.Controls.Add(this.consumoCombo);
            this.Controls.Add(this.capacidadTotalField);
            this.Controls.Add(this.capacidadLegalField);
            this.Controls.Add(this.locomotoraCheck);
            this.Controls.Add(this.modeloField);
            this.Name = "CocheAttrs";
            this.Size = new System.Drawing.Size(791, 291);
            ((System.ComponentModel.ISupportInitialize)(this.BindingSourceCoche)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialSingleLineTextField modeloField;
        private MaterialSkin.Controls.MaterialCheckBox locomotoraCheck;
        private MaterialSkin.Controls.MaterialSingleLineTextField capacidadLegalField;
        private MaterialSkin.Controls.MaterialSingleLineTextField capacidadTotalField;
        private System.Windows.Forms.ComboBox consumoCombo;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private MaterialSkin.Controls.MaterialSingleLineTextField consumoParadoField;
        private MaterialSkin.Controls.MaterialSingleLineTextField consumoAndandoField;
        private MaterialSkin.Controls.MaterialDivider materialDivider1;
        private MaterialSkin.Controls.MaterialLabel materialLabel2;
        private MaterialSkin.Controls.MaterialLabel materialLabel3;
        private MaterialSkin.Controls.MaterialLabel materialLabel4;
        private MaterialSkin.Controls.MaterialLabel materialLabel5;
        private MaterialSkin.Controls.MaterialLabel materialLabel6;
        private MaterialSkin.Controls.MaterialLabel materialLabel7;
        private System.Windows.Forms.BindingSource BindingSourceCoche;
        private MaterialSkin.Controls.MaterialLabel materialLabel8;
        private MaterialSkin.Controls.MaterialSingleLineTextField materialSingleLineTextField1;
    }
}
