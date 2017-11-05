namespace SimuRails.Views.Components.Attrs
{
    partial class EstacionAttrs
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
            this.materialLabel3 = new MaterialSkin.Controls.MaterialLabel();
            this.esperandoMinIdaField = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.BindingSourceEstacion = new System.Windows.Forms.BindingSource(this.components);
            this.nombreField = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.materialDivider1 = new MaterialSkin.Controls.MaterialDivider();
            this.materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.esperandoMaxIdaField = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.materialDivider2 = new MaterialSkin.Controls.MaterialDivider();
            this.EsMantenimientoCheck = new MaterialSkin.Controls.MaterialCheckBox();
            this.materialLabel5 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel6 = new MaterialSkin.Controls.MaterialLabel();
            this.materialDivider3 = new MaterialSkin.Controls.MaterialDivider();
            this.materialLabel8 = new MaterialSkin.Controls.MaterialLabel();
            this.esperandoMaxVueltaField = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.materialLabel9 = new MaterialSkin.Controls.MaterialLabel();
            this.esperandoMinVueltaField = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.materialLabel10 = new MaterialSkin.Controls.MaterialLabel();
            this.desciendenMaxVueltaField = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.materialLabel11 = new MaterialSkin.Controls.MaterialLabel();
            this.desciendenMinVueltaField = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.materialDivider4 = new MaterialSkin.Controls.MaterialDivider();
            this.materialLabel12 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel13 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel14 = new MaterialSkin.Controls.MaterialLabel();
            this.desciendenMaxIdaField = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.materialLabel15 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel16 = new MaterialSkin.Controls.MaterialLabel();
            this.desciendenMinIdaField = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.ListBoxAsignados = new System.Windows.Forms.ListBox();
            this.BindingSourceIncidentesAsignados = new System.Windows.Forms.BindingSource(this.components);
            this.ButtonDesasignar = new MaterialSkin.Controls.MaterialRaisedButton();
            this.ButtonAsignar = new MaterialSkin.Controls.MaterialRaisedButton();
            this.materialLabel4 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel17 = new MaterialSkin.Controls.MaterialLabel();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.BindingSourceIncidentesDisponibles = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.BindingSourceEstacion)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BindingSourceIncidentesAsignados)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BindingSourceIncidentesDisponibles)).BeginInit();
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
            this.materialLabel7.TabIndex = 37;
            this.materialLabel7.Text = "Nombre";
            // 
            // materialLabel3
            // 
            this.materialLabel3.AutoSize = true;
            this.materialLabel3.Depth = 0;
            this.materialLabel3.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel3.Location = new System.Drawing.Point(36, 145);
            this.materialLabel3.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel3.Name = "materialLabel3";
            this.materialLabel3.Size = new System.Drawing.Size(59, 19);
            this.materialLabel3.TabIndex = 33;
            this.materialLabel3.Text = "Mínima";
            // 
            // esperandoMinIdaField
            // 
            this.esperandoMinIdaField.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.BindingSourceEstacion, "PersonasEsperandoMinIda", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged, null, "N0"));
            this.esperandoMinIdaField.Depth = 0;
            this.esperandoMinIdaField.Hint = "Cant. de personas";
            this.esperandoMinIdaField.Location = new System.Drawing.Point(40, 167);
            this.esperandoMinIdaField.MaxLength = 32767;
            this.esperandoMinIdaField.MouseState = MaterialSkin.MouseState.HOVER;
            this.esperandoMinIdaField.Name = "esperandoMinIdaField";
            this.esperandoMinIdaField.PasswordChar = '\0';
            this.esperandoMinIdaField.SelectedText = "";
            this.esperandoMinIdaField.SelectionLength = 0;
            this.esperandoMinIdaField.SelectionStart = 0;
            this.esperandoMinIdaField.Size = new System.Drawing.Size(126, 23);
            this.esperandoMinIdaField.TabIndex = 2;
            this.esperandoMinIdaField.TabStop = false;
            this.esperandoMinIdaField.UseSystemPasswordChar = false;
            // 
            // BindingSourceEstacion
            // 
            this.BindingSourceEstacion.DataSource = typeof(SimuRails.Models.Estacion);
            // 
            // nombreField
            // 
            this.nombreField.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.BindingSourceEstacion, "Nombre", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.nombreField.Depth = 0;
            this.nombreField.Hint = "";
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
            // materialDivider1
            // 
            this.materialDivider1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.materialDivider1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialDivider1.Depth = 0;
            this.materialDivider1.Location = new System.Drawing.Point(4, 71);
            this.materialDivider1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialDivider1.Name = "materialDivider1";
            this.materialDivider1.Size = new System.Drawing.Size(953, 2);
            this.materialDivider1.TabIndex = 31;
            this.materialDivider1.Text = "materialDivider1";
            // 
            // materialLabel2
            // 
            this.materialLabel2.AutoSize = true;
            this.materialLabel2.Depth = 0;
            this.materialLabel2.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel2.Location = new System.Drawing.Point(35, 85);
            this.materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel2.Name = "materialLabel2";
            this.materialLabel2.Size = new System.Drawing.Size(308, 19);
            this.materialLabel2.TabIndex = 32;
            this.materialLabel2.Text = "Cantidad de personas esperando en el andén";
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel1.Location = new System.Drawing.Point(36, 205);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(62, 19);
            this.materialLabel1.TabIndex = 39;
            this.materialLabel1.Text = "Máxima";
            // 
            // esperandoMaxIdaField
            // 
            this.esperandoMaxIdaField.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.BindingSourceEstacion, "PersonasEsperandoMaxIda", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged, null, "N0"));
            this.esperandoMaxIdaField.Depth = 0;
            this.esperandoMaxIdaField.Hint = "Cant. de personas";
            this.esperandoMaxIdaField.Location = new System.Drawing.Point(40, 227);
            this.esperandoMaxIdaField.MaxLength = 32767;
            this.esperandoMaxIdaField.MouseState = MaterialSkin.MouseState.HOVER;
            this.esperandoMaxIdaField.Name = "esperandoMaxIdaField";
            this.esperandoMaxIdaField.PasswordChar = '\0';
            this.esperandoMaxIdaField.SelectedText = "";
            this.esperandoMaxIdaField.SelectionLength = 0;
            this.esperandoMaxIdaField.SelectionStart = 0;
            this.esperandoMaxIdaField.Size = new System.Drawing.Size(126, 23);
            this.esperandoMaxIdaField.TabIndex = 3;
            this.esperandoMaxIdaField.TabStop = false;
            this.esperandoMaxIdaField.UseSystemPasswordChar = false;
            // 
            // materialDivider2
            // 
            this.materialDivider2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.materialDivider2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialDivider2.Depth = 0;
            this.materialDivider2.Location = new System.Drawing.Point(382, 71);
            this.materialDivider2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialDivider2.Name = "materialDivider2";
            this.materialDivider2.Size = new System.Drawing.Size(2, 412);
            this.materialDivider2.TabIndex = 42;
            this.materialDivider2.Text = "materialDivider2";
            // 
            // EsMantenimientoCheck
            // 
            this.EsMantenimientoCheck.AutoSize = true;
            this.EsMantenimientoCheck.DataBindings.Add(new System.Windows.Forms.Binding("Checked", this.BindingSourceEstacion, "EsEstacionDeMantenimiento", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.EsMantenimientoCheck.Depth = 0;
            this.EsMantenimientoCheck.Font = new System.Drawing.Font("Roboto", 10F);
            this.EsMantenimientoCheck.Location = new System.Drawing.Point(348, 32);
            this.EsMantenimientoCheck.Margin = new System.Windows.Forms.Padding(0);
            this.EsMantenimientoCheck.MouseLocation = new System.Drawing.Point(-1, -1);
            this.EsMantenimientoCheck.MouseState = MaterialSkin.MouseState.HOVER;
            this.EsMantenimientoCheck.Name = "EsMantenimientoCheck";
            this.EsMantenimientoCheck.Ripple = true;
            this.EsMantenimientoCheck.Size = new System.Drawing.Size(216, 30);
            this.EsMantenimientoCheck.TabIndex = 1;
            this.EsMantenimientoCheck.Text = "Es estación de mantenimiento";
            this.EsMantenimientoCheck.UseVisualStyleBackColor = true;
            // 
            // materialLabel5
            // 
            this.materialLabel5.AutoSize = true;
            this.materialLabel5.Depth = 0;
            this.materialLabel5.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel5.Location = new System.Drawing.Point(76, 114);
            this.materialLabel5.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel5.Name = "materialLabel5";
            this.materialLabel5.Size = new System.Drawing.Size(29, 19);
            this.materialLabel5.TabIndex = 47;
            this.materialLabel5.Text = "Ida";
            // 
            // materialLabel6
            // 
            this.materialLabel6.AutoSize = true;
            this.materialLabel6.Depth = 0;
            this.materialLabel6.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel6.Location = new System.Drawing.Point(247, 114);
            this.materialLabel6.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel6.Name = "materialLabel6";
            this.materialLabel6.Size = new System.Drawing.Size(52, 19);
            this.materialLabel6.TabIndex = 48;
            this.materialLabel6.Text = "Vuelta";
            // 
            // materialDivider3
            // 
            this.materialDivider3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialDivider3.Depth = 0;
            this.materialDivider3.Location = new System.Drawing.Point(198, 114);
            this.materialDivider3.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialDivider3.Name = "materialDivider3";
            this.materialDivider3.Size = new System.Drawing.Size(2, 135);
            this.materialDivider3.TabIndex = 49;
            this.materialDivider3.Text = "materialDivider3";
            // 
            // materialLabel8
            // 
            this.materialLabel8.AutoSize = true;
            this.materialLabel8.Depth = 0;
            this.materialLabel8.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel8.Location = new System.Drawing.Point(215, 205);
            this.materialLabel8.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel8.Name = "materialLabel8";
            this.materialLabel8.Size = new System.Drawing.Size(62, 19);
            this.materialLabel8.TabIndex = 53;
            this.materialLabel8.Text = "Máxima";
            // 
            // esperandoMaxVueltaField
            // 
            this.esperandoMaxVueltaField.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.BindingSourceEstacion, "PersonasEsperandoMaxVuelta", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged, null, "N0"));
            this.esperandoMaxVueltaField.Depth = 0;
            this.esperandoMaxVueltaField.Hint = "Cant. de personas";
            this.esperandoMaxVueltaField.Location = new System.Drawing.Point(219, 227);
            this.esperandoMaxVueltaField.MaxLength = 32767;
            this.esperandoMaxVueltaField.MouseState = MaterialSkin.MouseState.HOVER;
            this.esperandoMaxVueltaField.Name = "esperandoMaxVueltaField";
            this.esperandoMaxVueltaField.PasswordChar = '\0';
            this.esperandoMaxVueltaField.SelectedText = "";
            this.esperandoMaxVueltaField.SelectionLength = 0;
            this.esperandoMaxVueltaField.SelectionStart = 0;
            this.esperandoMaxVueltaField.Size = new System.Drawing.Size(126, 23);
            this.esperandoMaxVueltaField.TabIndex = 5;
            this.esperandoMaxVueltaField.TabStop = false;
            this.esperandoMaxVueltaField.UseSystemPasswordChar = false;
            // 
            // materialLabel9
            // 
            this.materialLabel9.AutoSize = true;
            this.materialLabel9.Depth = 0;
            this.materialLabel9.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel9.Location = new System.Drawing.Point(215, 145);
            this.materialLabel9.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel9.Name = "materialLabel9";
            this.materialLabel9.Size = new System.Drawing.Size(59, 19);
            this.materialLabel9.TabIndex = 51;
            this.materialLabel9.Text = "Mínima";
            // 
            // esperandoMinVueltaField
            // 
            this.esperandoMinVueltaField.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.BindingSourceEstacion, "PersonasEsperandoMinVuelta", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged, null, "N0"));
            this.esperandoMinVueltaField.Depth = 0;
            this.esperandoMinVueltaField.Hint = "Cant. de personas";
            this.esperandoMinVueltaField.Location = new System.Drawing.Point(219, 167);
            this.esperandoMinVueltaField.MaxLength = 32767;
            this.esperandoMinVueltaField.MouseState = MaterialSkin.MouseState.HOVER;
            this.esperandoMinVueltaField.Name = "esperandoMinVueltaField";
            this.esperandoMinVueltaField.PasswordChar = '\0';
            this.esperandoMinVueltaField.SelectedText = "";
            this.esperandoMinVueltaField.SelectionLength = 0;
            this.esperandoMinVueltaField.SelectionStart = 0;
            this.esperandoMinVueltaField.Size = new System.Drawing.Size(126, 23);
            this.esperandoMinVueltaField.TabIndex = 4;
            this.esperandoMinVueltaField.TabStop = false;
            this.esperandoMinVueltaField.UseSystemPasswordChar = false;
            // 
            // materialLabel10
            // 
            this.materialLabel10.AutoSize = true;
            this.materialLabel10.Depth = 0;
            this.materialLabel10.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel10.Location = new System.Drawing.Point(217, 393);
            this.materialLabel10.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel10.Name = "materialLabel10";
            this.materialLabel10.Size = new System.Drawing.Size(62, 19);
            this.materialLabel10.TabIndex = 65;
            this.materialLabel10.Text = "Máxima";
            // 
            // desciendenMaxVueltaField
            // 
            this.desciendenMaxVueltaField.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.BindingSourceEstacion, "PersonasDesciendenMaxVuelta", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged, null, "N0"));
            this.desciendenMaxVueltaField.Depth = 0;
            this.desciendenMaxVueltaField.Hint = "Cant. de personas";
            this.desciendenMaxVueltaField.Location = new System.Drawing.Point(221, 415);
            this.desciendenMaxVueltaField.MaxLength = 32767;
            this.desciendenMaxVueltaField.MouseState = MaterialSkin.MouseState.HOVER;
            this.desciendenMaxVueltaField.Name = "desciendenMaxVueltaField";
            this.desciendenMaxVueltaField.PasswordChar = '\0';
            this.desciendenMaxVueltaField.SelectedText = "";
            this.desciendenMaxVueltaField.SelectionLength = 0;
            this.desciendenMaxVueltaField.SelectionStart = 0;
            this.desciendenMaxVueltaField.Size = new System.Drawing.Size(126, 23);
            this.desciendenMaxVueltaField.TabIndex = 9;
            this.desciendenMaxVueltaField.TabStop = false;
            this.desciendenMaxVueltaField.UseSystemPasswordChar = false;
            // 
            // materialLabel11
            // 
            this.materialLabel11.AutoSize = true;
            this.materialLabel11.Depth = 0;
            this.materialLabel11.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel11.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel11.Location = new System.Drawing.Point(217, 333);
            this.materialLabel11.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel11.Name = "materialLabel11";
            this.materialLabel11.Size = new System.Drawing.Size(59, 19);
            this.materialLabel11.TabIndex = 63;
            this.materialLabel11.Text = "Mínima";
            // 
            // desciendenMinVueltaField
            // 
            this.desciendenMinVueltaField.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.BindingSourceEstacion, "PersonasDesciendenMinVuelta", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged, null, "N0"));
            this.desciendenMinVueltaField.Depth = 0;
            this.desciendenMinVueltaField.Hint = "Cant. de personas";
            this.desciendenMinVueltaField.Location = new System.Drawing.Point(221, 355);
            this.desciendenMinVueltaField.MaxLength = 32767;
            this.desciendenMinVueltaField.MouseState = MaterialSkin.MouseState.HOVER;
            this.desciendenMinVueltaField.Name = "desciendenMinVueltaField";
            this.desciendenMinVueltaField.PasswordChar = '\0';
            this.desciendenMinVueltaField.SelectedText = "";
            this.desciendenMinVueltaField.SelectionLength = 0;
            this.desciendenMinVueltaField.SelectionStart = 0;
            this.desciendenMinVueltaField.Size = new System.Drawing.Size(126, 23);
            this.desciendenMinVueltaField.TabIndex = 8;
            this.desciendenMinVueltaField.TabStop = false;
            this.desciendenMinVueltaField.UseSystemPasswordChar = false;
            // 
            // materialDivider4
            // 
            this.materialDivider4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialDivider4.Depth = 0;
            this.materialDivider4.Location = new System.Drawing.Point(200, 302);
            this.materialDivider4.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialDivider4.Name = "materialDivider4";
            this.materialDivider4.Size = new System.Drawing.Size(2, 135);
            this.materialDivider4.TabIndex = 61;
            this.materialDivider4.Text = "materialDivider4";
            // 
            // materialLabel12
            // 
            this.materialLabel12.AutoSize = true;
            this.materialLabel12.Depth = 0;
            this.materialLabel12.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel12.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel12.Location = new System.Drawing.Point(249, 302);
            this.materialLabel12.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel12.Name = "materialLabel12";
            this.materialLabel12.Size = new System.Drawing.Size(52, 19);
            this.materialLabel12.TabIndex = 60;
            this.materialLabel12.Text = "Vuelta";
            // 
            // materialLabel13
            // 
            this.materialLabel13.AutoSize = true;
            this.materialLabel13.Depth = 0;
            this.materialLabel13.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel13.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel13.Location = new System.Drawing.Point(78, 302);
            this.materialLabel13.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel13.Name = "materialLabel13";
            this.materialLabel13.Size = new System.Drawing.Size(29, 19);
            this.materialLabel13.TabIndex = 59;
            this.materialLabel13.Text = "Ida";
            // 
            // materialLabel14
            // 
            this.materialLabel14.AutoSize = true;
            this.materialLabel14.Depth = 0;
            this.materialLabel14.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel14.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel14.Location = new System.Drawing.Point(38, 393);
            this.materialLabel14.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel14.Name = "materialLabel14";
            this.materialLabel14.Size = new System.Drawing.Size(62, 19);
            this.materialLabel14.TabIndex = 58;
            this.materialLabel14.Text = "Máxima";
            // 
            // desciendenMaxIdaField
            // 
            this.desciendenMaxIdaField.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.BindingSourceEstacion, "PersonasDesciendenMaxIda", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged, null, "N0"));
            this.desciendenMaxIdaField.Depth = 0;
            this.desciendenMaxIdaField.Hint = "Cant. de personas";
            this.desciendenMaxIdaField.Location = new System.Drawing.Point(42, 415);
            this.desciendenMaxIdaField.MaxLength = 32767;
            this.desciendenMaxIdaField.MouseState = MaterialSkin.MouseState.HOVER;
            this.desciendenMaxIdaField.Name = "desciendenMaxIdaField";
            this.desciendenMaxIdaField.PasswordChar = '\0';
            this.desciendenMaxIdaField.SelectedText = "";
            this.desciendenMaxIdaField.SelectionLength = 0;
            this.desciendenMaxIdaField.SelectionStart = 0;
            this.desciendenMaxIdaField.Size = new System.Drawing.Size(126, 23);
            this.desciendenMaxIdaField.TabIndex = 7;
            this.desciendenMaxIdaField.TabStop = false;
            this.desciendenMaxIdaField.UseSystemPasswordChar = false;
            // 
            // materialLabel15
            // 
            this.materialLabel15.AutoSize = true;
            this.materialLabel15.Depth = 0;
            this.materialLabel15.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel15.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel15.Location = new System.Drawing.Point(38, 333);
            this.materialLabel15.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel15.Name = "materialLabel15";
            this.materialLabel15.Size = new System.Drawing.Size(59, 19);
            this.materialLabel15.TabIndex = 56;
            this.materialLabel15.Text = "Mínima";
            // 
            // materialLabel16
            // 
            this.materialLabel16.AutoSize = true;
            this.materialLabel16.Depth = 0;
            this.materialLabel16.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel16.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel16.Location = new System.Drawing.Point(27, 273);
            this.materialLabel16.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel16.Name = "materialLabel16";
            this.materialLabel16.Size = new System.Drawing.Size(331, 19);
            this.materialLabel16.TabIndex = 55;
            this.materialLabel16.Text = "Cantidad de personas que descienden del andén";
            // 
            // desciendenMinIdaField
            // 
            this.desciendenMinIdaField.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.BindingSourceEstacion, "PersonasDesciendenMinIda", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged, null, "N0"));
            this.desciendenMinIdaField.Depth = 0;
            this.desciendenMinIdaField.Hint = "Cant. de personas";
            this.desciendenMinIdaField.Location = new System.Drawing.Point(42, 355);
            this.desciendenMinIdaField.MaxLength = 32767;
            this.desciendenMinIdaField.MouseState = MaterialSkin.MouseState.HOVER;
            this.desciendenMinIdaField.Name = "desciendenMinIdaField";
            this.desciendenMinIdaField.PasswordChar = '\0';
            this.desciendenMinIdaField.SelectedText = "";
            this.desciendenMinIdaField.SelectionLength = 0;
            this.desciendenMinIdaField.SelectionStart = 0;
            this.desciendenMinIdaField.Size = new System.Drawing.Size(126, 23);
            this.desciendenMinIdaField.TabIndex = 6;
            this.desciendenMinIdaField.TabStop = false;
            this.desciendenMinIdaField.UseSystemPasswordChar = false;
            // 
            // ListBoxAsignados
            // 
            this.ListBoxAsignados.DataSource = this.BindingSourceIncidentesAsignados;
            this.ListBoxAsignados.DisplayMember = "Valor";
            this.ListBoxAsignados.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ListBoxAsignados.FormattingEnabled = true;
            this.ListBoxAsignados.ItemHeight = 18;
            this.ListBoxAsignados.Location = new System.Drawing.Point(711, 107);
            this.ListBoxAsignados.Name = "ListBoxAsignados";
            this.ListBoxAsignados.Size = new System.Drawing.Size(241, 202);
            this.ListBoxAsignados.TabIndex = 71;
            this.ListBoxAsignados.ValueMember = "Clave";
            // 
            // BindingSourceIncidentesAsignados
            // 
            this.BindingSourceIncidentesAsignados.DataSource = typeof(SimuRails.KeyValue);
            // 
            // ButtonDesasignar
            // 
            this.ButtonDesasignar.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ButtonDesasignar.Depth = 0;
            this.ButtonDesasignar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonDesasignar.Icon = null;
            this.ButtonDesasignar.Location = new System.Drawing.Point(641, 217);
            this.ButtonDesasignar.MouseState = MaterialSkin.MouseState.HOVER;
            this.ButtonDesasignar.Name = "ButtonDesasignar";
            this.ButtonDesasignar.Primary = true;
            this.ButtonDesasignar.Size = new System.Drawing.Size(62, 23);
            this.ButtonDesasignar.TabIndex = 67;
            this.ButtonDesasignar.Text = "<";
            this.ButtonDesasignar.UseVisualStyleBackColor = true;
            this.ButtonDesasignar.Click += new System.EventHandler(this.ButtonDesasignar_Click);
            // 
            // ButtonAsignar
            // 
            this.ButtonAsignar.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ButtonAsignar.Depth = 0;
            this.ButtonAsignar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonAsignar.Icon = null;
            this.ButtonAsignar.Location = new System.Drawing.Point(641, 161);
            this.ButtonAsignar.MouseState = MaterialSkin.MouseState.HOVER;
            this.ButtonAsignar.Name = "ButtonAsignar";
            this.ButtonAsignar.Primary = true;
            this.ButtonAsignar.Size = new System.Drawing.Size(62, 23);
            this.ButtonAsignar.TabIndex = 66;
            this.ButtonAsignar.Text = ">";
            this.ButtonAsignar.UseVisualStyleBackColor = true;
            this.ButtonAsignar.Click += new System.EventHandler(this.ButtonAsignar_Click);
            // 
            // materialLabel4
            // 
            this.materialLabel4.AutoSize = true;
            this.materialLabel4.Depth = 0;
            this.materialLabel4.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel4.Location = new System.Drawing.Point(707, 85);
            this.materialLabel4.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel4.Name = "materialLabel4";
            this.materialLabel4.Size = new System.Drawing.Size(153, 19);
            this.materialLabel4.TabIndex = 70;
            this.materialLabel4.Text = "Incidentes Asignados";
            // 
            // materialLabel17
            // 
            this.materialLabel17.AutoSize = true;
            this.materialLabel17.Depth = 0;
            this.materialLabel17.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel17.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel17.Location = new System.Drawing.Point(390, 85);
            this.materialLabel17.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel17.Name = "materialLabel17";
            this.materialLabel17.Size = new System.Drawing.Size(161, 19);
            this.materialLabel17.TabIndex = 69;
            this.materialLabel17.Text = "Incidentes Disponibles";
            // 
            // listBox1
            // 
            this.listBox1.DataSource = this.BindingSourceIncidentesDisponibles;
            this.listBox1.DisplayMember = "Nombre";
            this.listBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 18;
            this.listBox1.Location = new System.Drawing.Point(394, 107);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(241, 202);
            this.listBox1.TabIndex = 68;
            this.listBox1.ValueMember = "Id";
            // 
            // BindingSourceIncidentesDisponibles
            // 
            this.BindingSourceIncidentesDisponibles.DataSource = typeof(SimuRails.Models.Incidente);
            // 
            // EstacionAttrs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.Controls.Add(this.ListBoxAsignados);
            this.Controls.Add(this.ButtonDesasignar);
            this.Controls.Add(this.ButtonAsignar);
            this.Controls.Add(this.materialLabel4);
            this.Controls.Add(this.materialLabel17);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.materialLabel10);
            this.Controls.Add(this.desciendenMaxVueltaField);
            this.Controls.Add(this.materialLabel11);
            this.Controls.Add(this.desciendenMinVueltaField);
            this.Controls.Add(this.materialDivider4);
            this.Controls.Add(this.materialLabel12);
            this.Controls.Add(this.materialLabel13);
            this.Controls.Add(this.materialLabel14);
            this.Controls.Add(this.desciendenMaxIdaField);
            this.Controls.Add(this.materialLabel15);
            this.Controls.Add(this.materialLabel16);
            this.Controls.Add(this.desciendenMinIdaField);
            this.Controls.Add(this.materialLabel8);
            this.Controls.Add(this.esperandoMaxVueltaField);
            this.Controls.Add(this.materialLabel9);
            this.Controls.Add(this.esperandoMinVueltaField);
            this.Controls.Add(this.materialDivider3);
            this.Controls.Add(this.materialLabel6);
            this.Controls.Add(this.materialLabel5);
            this.Controls.Add(this.EsMantenimientoCheck);
            this.Controls.Add(this.materialDivider2);
            this.Controls.Add(this.materialLabel1);
            this.Controls.Add(this.esperandoMaxIdaField);
            this.Controls.Add(this.materialLabel7);
            this.Controls.Add(this.materialLabel3);
            this.Controls.Add(this.materialLabel2);
            this.Controls.Add(this.materialDivider1);
            this.Controls.Add(this.esperandoMinIdaField);
            this.Controls.Add(this.nombreField);
            this.Name = "EstacionAttrs";
            this.Size = new System.Drawing.Size(957, 482);
            ((System.ComponentModel.ISupportInitialize)(this.BindingSourceEstacion)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BindingSourceIncidentesAsignados)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BindingSourceIncidentesDisponibles)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialLabel materialLabel7;
        private MaterialSkin.Controls.MaterialLabel materialLabel3;
        private MaterialSkin.Controls.MaterialSingleLineTextField esperandoMinIdaField;
        private MaterialSkin.Controls.MaterialSingleLineTextField nombreField;
        private MaterialSkin.Controls.MaterialDivider materialDivider1;
        private MaterialSkin.Controls.MaterialLabel materialLabel2;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private MaterialSkin.Controls.MaterialSingleLineTextField esperandoMaxIdaField;
        private MaterialSkin.Controls.MaterialDivider materialDivider2;
        private MaterialSkin.Controls.MaterialCheckBox EsMantenimientoCheck;
        private MaterialSkin.Controls.MaterialLabel materialLabel5;
        private MaterialSkin.Controls.MaterialLabel materialLabel6;
        private MaterialSkin.Controls.MaterialDivider materialDivider3;
        private MaterialSkin.Controls.MaterialLabel materialLabel8;
        private MaterialSkin.Controls.MaterialSingleLineTextField esperandoMaxVueltaField;
        private MaterialSkin.Controls.MaterialLabel materialLabel9;
        private MaterialSkin.Controls.MaterialSingleLineTextField esperandoMinVueltaField;
        private MaterialSkin.Controls.MaterialLabel materialLabel10;
        private MaterialSkin.Controls.MaterialSingleLineTextField desciendenMaxVueltaField;
        private MaterialSkin.Controls.MaterialLabel materialLabel11;
        private MaterialSkin.Controls.MaterialSingleLineTextField desciendenMinVueltaField;
        private MaterialSkin.Controls.MaterialDivider materialDivider4;
        private MaterialSkin.Controls.MaterialLabel materialLabel12;
        private MaterialSkin.Controls.MaterialLabel materialLabel13;
        private MaterialSkin.Controls.MaterialLabel materialLabel14;
        private MaterialSkin.Controls.MaterialSingleLineTextField desciendenMaxIdaField;
        private MaterialSkin.Controls.MaterialLabel materialLabel15;
        private MaterialSkin.Controls.MaterialLabel materialLabel16;
        private MaterialSkin.Controls.MaterialSingleLineTextField desciendenMinIdaField;
        private System.Windows.Forms.BindingSource BindingSourceEstacion;
        private System.Windows.Forms.ListBox ListBoxAsignados;
        private MaterialSkin.Controls.MaterialRaisedButton ButtonDesasignar;
        private MaterialSkin.Controls.MaterialRaisedButton ButtonAsignar;
        private MaterialSkin.Controls.MaterialLabel materialLabel4;
        private MaterialSkin.Controls.MaterialLabel materialLabel17;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.BindingSource BindingSourceIncidentesDisponibles;
        private System.Windows.Forms.BindingSource BindingSourceIncidentesAsignados;
    }
}
