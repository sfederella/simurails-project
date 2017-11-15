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
            this.BindingSourceCoche = new System.Windows.Forms.BindingSource(this.components);
            this.locomotoraCheck = new MaterialSkin.Controls.MaterialCheckBox();
            this.capacidadLegalField = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.capacidadTotalField = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.materialDivider1 = new MaterialSkin.Controls.MaterialDivider();
            this.materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel3 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel4 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel7 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel8 = new MaterialSkin.Controls.MaterialLabel();
            this.asientosField = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.errorModeloLbl = new System.Windows.Forms.Label();
            this.errorAsientosLbl = new System.Windows.Forms.Label();
            this.errorMaximaLbl = new System.Windows.Forms.Label();
            this.errorLegalLbl = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.BindingSourceCoche)).BeginInit();
            this.SuspendLayout();
            // 
            // modeloField
            // 
            this.modeloField.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.modeloField.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.BindingSourceCoche, "Modelo", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.modeloField.Depth = 0;
            this.modeloField.Hint = "";
            this.modeloField.IsNumeric = false;
            this.modeloField.Location = new System.Drawing.Point(21, 42);
            this.modeloField.MaxLength = 32767;
            this.modeloField.MouseState = MaterialSkin.MouseState.HOVER;
            this.modeloField.Name = "modeloField";
            this.modeloField.PasswordChar = '\0';
            this.modeloField.SelectedText = "";
            this.modeloField.SelectionLength = 0;
            this.modeloField.SelectionStart = 0;
            this.modeloField.Size = new System.Drawing.Size(270, 23);
            this.modeloField.TabIndex = 0;
            this.modeloField.TabStop = false;
            this.modeloField.UseSystemPasswordChar = false;
            // 
            // BindingSourceCoche
            // 
            this.BindingSourceCoche.DataSource = typeof(SimuRails.Models.Coche);
            // 
            // locomotoraCheck
            // 
            this.locomotoraCheck.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.locomotoraCheck.AutoSize = true;
            this.locomotoraCheck.DataBindings.Add(new System.Windows.Forms.Binding("Checked", this.BindingSourceCoche, "EsLocomotora", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.locomotoraCheck.Depth = 0;
            this.locomotoraCheck.Font = new System.Drawing.Font("Roboto", 10F);
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
            this.capacidadLegalField.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.capacidadLegalField.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.BindingSourceCoche, "MaximoLegalPasajeros", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged, null, "N0"));
            this.capacidadLegalField.Depth = 0;
            this.capacidadLegalField.Hint = "Personas";
            this.capacidadLegalField.IsNumeric = false;
            this.capacidadLegalField.Location = new System.Drawing.Point(292, 173);
            this.capacidadLegalField.MaxLength = 32767;
            this.capacidadLegalField.MouseState = MaterialSkin.MouseState.HOVER;
            this.capacidadLegalField.Name = "capacidadLegalField";
            this.capacidadLegalField.PasswordChar = '\0';
            this.capacidadLegalField.SelectedText = "";
            this.capacidadLegalField.SelectionLength = 0;
            this.capacidadLegalField.SelectionStart = 0;
            this.capacidadLegalField.Size = new System.Drawing.Size(148, 23);
            this.capacidadLegalField.TabIndex = 5;
            this.capacidadLegalField.TabStop = false;
            this.capacidadLegalField.UseSystemPasswordChar = false;
            // 
            // capacidadTotalField
            // 
            this.capacidadTotalField.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.capacidadTotalField.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.BindingSourceCoche, "CapacidadMaximaPasajeros", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged, null, "N0"));
            this.capacidadTotalField.Depth = 0;
            this.capacidadTotalField.Hint = "Personas";
            this.capacidadTotalField.IsNumeric = false;
            this.capacidadTotalField.Location = new System.Drawing.Point(569, 173);
            this.capacidadTotalField.MaxLength = 32767;
            this.capacidadTotalField.MouseState = MaterialSkin.MouseState.HOVER;
            this.capacidadTotalField.Name = "capacidadTotalField";
            this.capacidadTotalField.PasswordChar = '\0';
            this.capacidadTotalField.SelectedText = "";
            this.capacidadTotalField.SelectionLength = 0;
            this.capacidadTotalField.SelectionStart = 0;
            this.capacidadTotalField.Size = new System.Drawing.Size(148, 23);
            this.capacidadTotalField.TabIndex = 6;
            this.capacidadTotalField.TabStop = false;
            this.capacidadTotalField.UseSystemPasswordChar = false;
            // 
            // materialDivider1
            // 
            this.materialDivider1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.materialDivider1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialDivider1.Depth = 0;
            this.materialDivider1.Location = new System.Drawing.Point(0, 99);
            this.materialDivider1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialDivider1.Name = "materialDivider1";
            this.materialDivider1.Size = new System.Drawing.Size(787, 2);
            this.materialDivider1.TabIndex = 16;
            this.materialDivider1.Text = "materialDivider1";
            // 
            // materialLabel2
            // 
            this.materialLabel2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.materialLabel2.AutoSize = true;
            this.materialLabel2.Depth = 0;
            this.materialLabel2.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel2.Location = new System.Drawing.Point(14, 116);
            this.materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel2.Name = "materialLabel2";
            this.materialLabel2.Size = new System.Drawing.Size(79, 19);
            this.materialLabel2.TabIndex = 17;
            this.materialLabel2.Text = "Capacidad";
            // 
            // materialLabel3
            // 
            this.materialLabel3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.materialLabel3.AutoSize = true;
            this.materialLabel3.Depth = 0;
            this.materialLabel3.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel3.Location = new System.Drawing.Point(288, 151);
            this.materialLabel3.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel3.Name = "materialLabel3";
            this.materialLabel3.Size = new System.Drawing.Size(115, 19);
            this.materialLabel3.TabIndex = 18;
            this.materialLabel3.Text = "Capacidad legal";
            // 
            // materialLabel4
            // 
            this.materialLabel4.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.materialLabel4.AutoSize = true;
            this.materialLabel4.Depth = 0;
            this.materialLabel4.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel4.Location = new System.Drawing.Point(565, 151);
            this.materialLabel4.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel4.Name = "materialLabel4";
            this.materialLabel4.Size = new System.Drawing.Size(136, 19);
            this.materialLabel4.TabIndex = 19;
            this.materialLabel4.Text = "Capacidad máxima";
            // 
            // materialLabel7
            // 
            this.materialLabel7.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.materialLabel7.AutoSize = true;
            this.materialLabel7.Depth = 0;
            this.materialLabel7.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel7.Location = new System.Drawing.Point(17, 20);
            this.materialLabel7.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel7.Name = "materialLabel7";
            this.materialLabel7.Size = new System.Drawing.Size(118, 19);
            this.materialLabel7.TabIndex = 22;
            this.materialLabel7.Text = "Nombre modelo";
            // 
            // materialLabel8
            // 
            this.materialLabel8.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.materialLabel8.AutoSize = true;
            this.materialLabel8.Depth = 0;
            this.materialLabel8.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel8.Location = new System.Drawing.Point(25, 151);
            this.materialLabel8.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel8.Name = "materialLabel8";
            this.materialLabel8.Size = new System.Drawing.Size(150, 19);
            this.materialLabel8.TabIndex = 25;
            this.materialLabel8.Text = "Cantidad de asientos";
            // 
            // asientosField
            // 
            this.asientosField.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.asientosField.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.BindingSourceCoche, "CantidadAsientos", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged, null, "N0"));
            this.asientosField.Depth = 0;
            this.asientosField.Hint = "Asientos";
            this.asientosField.IsNumeric = false;
            this.asientosField.Location = new System.Drawing.Point(29, 173);
            this.asientosField.MaxLength = 32767;
            this.asientosField.MouseState = MaterialSkin.MouseState.HOVER;
            this.asientosField.Name = "asientosField";
            this.asientosField.PasswordChar = '\0';
            this.asientosField.SelectedText = "";
            this.asientosField.SelectionLength = 0;
            this.asientosField.SelectionStart = 0;
            this.asientosField.Size = new System.Drawing.Size(148, 23);
            this.asientosField.TabIndex = 7;
            this.asientosField.TabStop = false;
            this.asientosField.UseSystemPasswordChar = false;
            // 
            // errorModeloLbl
            // 
            this.errorModeloLbl.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.errorModeloLbl.AutoSize = true;
            this.errorModeloLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.errorModeloLbl.ForeColor = System.Drawing.Color.DarkRed;
            this.errorModeloLbl.Location = new System.Drawing.Point(18, 68);
            this.errorModeloLbl.Name = "errorModeloLbl";
            this.errorModeloLbl.Size = new System.Drawing.Size(167, 15);
            this.errorModeloLbl.TabIndex = 26;
            this.errorModeloLbl.Text = "Este campo es requerido";
            this.errorModeloLbl.Visible = false;
            // 
            // errorAsientosLbl
            // 
            this.errorAsientosLbl.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.errorAsientosLbl.AutoSize = true;
            this.errorAsientosLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.errorAsientosLbl.ForeColor = System.Drawing.Color.DarkRed;
            this.errorAsientosLbl.Location = new System.Drawing.Point(26, 199);
            this.errorAsientosLbl.Name = "errorAsientosLbl";
            this.errorAsientosLbl.Size = new System.Drawing.Size(167, 15);
            this.errorAsientosLbl.TabIndex = 31;
            this.errorAsientosLbl.Text = "Este campo es requerido";
            this.errorAsientosLbl.Visible = false;
            // 
            // errorMaximaLbl
            // 
            this.errorMaximaLbl.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.errorMaximaLbl.AutoSize = true;
            this.errorMaximaLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.errorMaximaLbl.ForeColor = System.Drawing.Color.DarkRed;
            this.errorMaximaLbl.Location = new System.Drawing.Point(566, 199);
            this.errorMaximaLbl.Name = "errorMaximaLbl";
            this.errorMaximaLbl.Size = new System.Drawing.Size(167, 15);
            this.errorMaximaLbl.TabIndex = 32;
            this.errorMaximaLbl.Text = "Este campo es requerido";
            this.errorMaximaLbl.Visible = false;
            // 
            // errorLegalLbl
            // 
            this.errorLegalLbl.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.errorLegalLbl.AutoSize = true;
            this.errorLegalLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.errorLegalLbl.ForeColor = System.Drawing.Color.DarkRed;
            this.errorLegalLbl.Location = new System.Drawing.Point(289, 199);
            this.errorLegalLbl.Name = "errorLegalLbl";
            this.errorLegalLbl.Size = new System.Drawing.Size(167, 15);
            this.errorLegalLbl.TabIndex = 33;
            this.errorLegalLbl.Text = "Este campo es requerido";
            this.errorLegalLbl.Visible = false;
            // 
            // CocheAttrs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.Controls.Add(this.errorLegalLbl);
            this.Controls.Add(this.errorMaximaLbl);
            this.Controls.Add(this.errorAsientosLbl);
            this.Controls.Add(this.errorModeloLbl);
            this.Controls.Add(this.materialLabel8);
            this.Controls.Add(this.asientosField);
            this.Controls.Add(this.materialLabel7);
            this.Controls.Add(this.materialLabel4);
            this.Controls.Add(this.materialLabel3);
            this.Controls.Add(this.materialLabel2);
            this.Controls.Add(this.materialDivider1);
            this.Controls.Add(this.capacidadTotalField);
            this.Controls.Add(this.capacidadLegalField);
            this.Controls.Add(this.locomotoraCheck);
            this.Controls.Add(this.modeloField);
            this.Name = "CocheAttrs";
            this.Size = new System.Drawing.Size(791, 291);
            this.Load += new System.EventHandler(this.CocheAttrs_Load);
            ((System.ComponentModel.ISupportInitialize)(this.BindingSourceCoche)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialSingleLineTextField modeloField;
        private MaterialSkin.Controls.MaterialCheckBox locomotoraCheck;
        private MaterialSkin.Controls.MaterialSingleLineTextField capacidadLegalField;
        private MaterialSkin.Controls.MaterialSingleLineTextField capacidadTotalField;
        private MaterialSkin.Controls.MaterialDivider materialDivider1;
        private MaterialSkin.Controls.MaterialLabel materialLabel2;
        private MaterialSkin.Controls.MaterialLabel materialLabel3;
        private MaterialSkin.Controls.MaterialLabel materialLabel4;
        private MaterialSkin.Controls.MaterialLabel materialLabel7;
        private System.Windows.Forms.BindingSource BindingSourceCoche;
        private MaterialSkin.Controls.MaterialLabel materialLabel8;
        private MaterialSkin.Controls.MaterialSingleLineTextField asientosField;
        private System.Windows.Forms.Label errorModeloLbl;
        private System.Windows.Forms.Label errorAsientosLbl;
        private System.Windows.Forms.Label errorMaximaLbl;
        private System.Windows.Forms.Label errorLegalLbl;
    }
}
