namespace SimuRails.Views.Components.Attrs
{
    partial class ServicioAttrs
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
            this.BindingSourceServicio = new System.Windows.Forms.BindingSource(this.components);
            this.materialLabel7 = new MaterialSkin.Controls.MaterialLabel();
            this.nombreFormacionCbo = new System.Windows.Forms.ComboBox();
            this.bindingSourceFormacionEditando = new System.Windows.Forms.BindingSource(this.components);
            this.agregarBtn = new MaterialSkin.Controls.MaterialRaisedButton();
            this.materialLabel4 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel3 = new MaterialSkin.Controls.MaterialLabel();
            this.materialSingleLineTextField1 = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            this.origenTramoCbo = new System.Windows.Forms.ComboBox();
            this.bindingSourceTramoEditando = new System.Windows.Forms.BindingSource(this.components);
            this.materialRaisedButton1 = new MaterialSkin.Controls.MaterialRaisedButton();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel5 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel6 = new MaterialSkin.Controls.MaterialLabel();
            this.destinoTramoCbo = new System.Windows.Forms.ComboBox();
            this.materialLabel8 = new MaterialSkin.Controls.MaterialLabel();
            this.materialSingleLineTextField2 = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.materialLabel9 = new MaterialSkin.Controls.MaterialLabel();
            this.materialSingleLineTextField3 = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.listadoTramos = new SimuRails.Views.Components.MaterialList();
            this.listadoFormaciones = new SimuRails.Views.Components.MaterialList();
            this.materialLabel10 = new MaterialSkin.Controls.MaterialLabel();
            this.materialSingleLineTextField4 = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.materialLabel11 = new MaterialSkin.Controls.MaterialLabel();
            this.programacionIdaButton = new MaterialSkin.Controls.MaterialRaisedButton();
            this.programacionVueltaButton = new MaterialSkin.Controls.MaterialRaisedButton();
            ((System.ComponentModel.ISupportInitialize)(this.BindingSourceServicio)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceFormacionEditando)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceTramoEditando)).BeginInit();
            this.SuspendLayout();
            // 
            // nombreField
            // 
            this.nombreField.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.nombreField.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.BindingSourceServicio, "Nombre", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.nombreField.Depth = 0;
            this.nombreField.Hint = "";
            this.nombreField.Location = new System.Drawing.Point(14, 30);
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
            // BindingSourceServicio
            // 
            this.BindingSourceServicio.DataSource = typeof(SimuRails.Models.Servicio);
            // 
            // materialLabel7
            // 
            this.materialLabel7.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.materialLabel7.AutoSize = true;
            this.materialLabel7.Depth = 0;
            this.materialLabel7.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel7.Location = new System.Drawing.Point(10, 9);
            this.materialLabel7.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel7.Name = "materialLabel7";
            this.materialLabel7.Size = new System.Drawing.Size(63, 19);
            this.materialLabel7.TabIndex = 22;
            this.materialLabel7.Text = "Nombre";
            // 
            // nombreFormacionCbo
            // 
            this.nombreFormacionCbo.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.nombreFormacionCbo.DataBindings.Add(new System.Windows.Forms.Binding("SelectedItem", this.bindingSourceFormacionEditando, "Formacion", true));
            this.nombreFormacionCbo.FormattingEnabled = true;
            this.nombreFormacionCbo.Location = new System.Drawing.Point(692, 171);
            this.nombreFormacionCbo.Name = "nombreFormacionCbo";
            this.nombreFormacionCbo.Size = new System.Drawing.Size(165, 21);
            this.nombreFormacionCbo.TabIndex = 55;
            // 
            // bindingSourceFormacionEditando
            // 
            this.bindingSourceFormacionEditando.DataSource = typeof(SimuRails.Models.AgrupacionFormacion);
            // 
            // agregarBtn
            // 
            this.agregarBtn.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.agregarBtn.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.agregarBtn.Depth = 0;
            this.agregarBtn.Icon = null;
            this.agregarBtn.Location = new System.Drawing.Point(1048, 167);
            this.agregarBtn.MouseState = MaterialSkin.MouseState.HOVER;
            this.agregarBtn.Name = "agregarBtn";
            this.agregarBtn.Primary = true;
            this.agregarBtn.Size = new System.Drawing.Size(87, 27);
            this.agregarBtn.TabIndex = 54;
            this.agregarBtn.Text = "Agregar";
            this.agregarBtn.UseVisualStyleBackColor = true;
            this.agregarBtn.Click += new System.EventHandler(this.agregarBtn_Click);
            // 
            // materialLabel4
            // 
            this.materialLabel4.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.materialLabel4.AutoSize = true;
            this.materialLabel4.Depth = 0;
            this.materialLabel4.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel4.Location = new System.Drawing.Point(688, 143);
            this.materialLabel4.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel4.Name = "materialLabel4";
            this.materialLabel4.Size = new System.Drawing.Size(63, 19);
            this.materialLabel4.TabIndex = 52;
            this.materialLabel4.Text = "Nombre";
            // 
            // materialLabel3
            // 
            this.materialLabel3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.materialLabel3.AutoSize = true;
            this.materialLabel3.Depth = 0;
            this.materialLabel3.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel3.Location = new System.Drawing.Point(889, 144);
            this.materialLabel3.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel3.Name = "materialLabel3";
            this.materialLabel3.Size = new System.Drawing.Size(68, 19);
            this.materialLabel3.TabIndex = 51;
            this.materialLabel3.Text = "Cantidad";
            // 
            // materialSingleLineTextField1
            // 
            this.materialSingleLineTextField1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.materialSingleLineTextField1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bindingSourceFormacionEditando, "Cantidad", true));
            this.materialSingleLineTextField1.Depth = 0;
            this.materialSingleLineTextField1.Hint = "";
            this.materialSingleLineTextField1.Location = new System.Drawing.Point(893, 171);
            this.materialSingleLineTextField1.MaxLength = 32767;
            this.materialSingleLineTextField1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialSingleLineTextField1.Name = "materialSingleLineTextField1";
            this.materialSingleLineTextField1.PasswordChar = '\0';
            this.materialSingleLineTextField1.SelectedText = "";
            this.materialSingleLineTextField1.SelectionLength = 0;
            this.materialSingleLineTextField1.SelectionStart = 0;
            this.materialSingleLineTextField1.Size = new System.Drawing.Size(80, 23);
            this.materialSingleLineTextField1.TabIndex = 50;
            this.materialSingleLineTextField1.TabStop = false;
            this.materialSingleLineTextField1.UseSystemPasswordChar = false;
            // 
            // materialLabel2
            // 
            this.materialLabel2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.materialLabel2.AutoSize = true;
            this.materialLabel2.Depth = 0;
            this.materialLabel2.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel2.Location = new System.Drawing.Point(667, 9);
            this.materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel2.Name = "materialLabel2";
            this.materialLabel2.Size = new System.Drawing.Size(97, 19);
            this.materialLabel2.TabIndex = 49;
            this.materialLabel2.Text = "Formaciones";
            // 
            // origenTramoCbo
            // 
            this.origenTramoCbo.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.origenTramoCbo.DataBindings.Add(new System.Windows.Forms.Binding("SelectedItem", this.bindingSourceTramoEditando, "EstacionOrigen", true));
            this.origenTramoCbo.FormattingEnabled = true;
            this.origenTramoCbo.Location = new System.Drawing.Point(24, 171);
            this.origenTramoCbo.Name = "origenTramoCbo";
            this.origenTramoCbo.Size = new System.Drawing.Size(117, 21);
            this.origenTramoCbo.TabIndex = 62;
            // 
            // bindingSourceTramoEditando
            // 
            this.bindingSourceTramoEditando.DataSource = typeof(SimuRails.Models.Tramo);
            // 
            // materialRaisedButton1
            // 
            this.materialRaisedButton1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.materialRaisedButton1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialRaisedButton1.Depth = 0;
            this.materialRaisedButton1.Icon = null;
            this.materialRaisedButton1.Location = new System.Drawing.Point(470, 167);
            this.materialRaisedButton1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialRaisedButton1.Name = "materialRaisedButton1";
            this.materialRaisedButton1.Primary = true;
            this.materialRaisedButton1.Size = new System.Drawing.Size(94, 27);
            this.materialRaisedButton1.TabIndex = 61;
            this.materialRaisedButton1.Text = "Agregar";
            this.materialRaisedButton1.UseVisualStyleBackColor = true;
            this.materialRaisedButton1.Click += new System.EventHandler(this.agregarTramoClick);
            // 
            // materialLabel1
            // 
            this.materialLabel1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel1.Location = new System.Drawing.Point(20, 144);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(50, 19);
            this.materialLabel1.TabIndex = 59;
            this.materialLabel1.Text = "Salida";
            // 
            // materialLabel5
            // 
            this.materialLabel5.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.materialLabel5.AutoSize = true;
            this.materialLabel5.Depth = 0;
            this.materialLabel5.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel5.Location = new System.Drawing.Point(143, 144);
            this.materialLabel5.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel5.Name = "materialLabel5";
            this.materialLabel5.Size = new System.Drawing.Size(61, 19);
            this.materialLabel5.TabIndex = 58;
            this.materialLabel5.Text = "Llegada";
            // 
            // materialLabel6
            // 
            this.materialLabel6.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.materialLabel6.AutoSize = true;
            this.materialLabel6.Depth = 0;
            this.materialLabel6.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel6.Location = new System.Drawing.Point(10, 113);
            this.materialLabel6.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel6.Name = "materialLabel6";
            this.materialLabel6.Size = new System.Drawing.Size(61, 19);
            this.materialLabel6.TabIndex = 56;
            this.materialLabel6.Text = "Tramos";
            // 
            // destinoTramoCbo
            // 
            this.destinoTramoCbo.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.destinoTramoCbo.DataBindings.Add(new System.Windows.Forms.Binding("SelectedItem", this.bindingSourceTramoEditando, "EstacionDestino", true));
            this.destinoTramoCbo.FormattingEnabled = true;
            this.destinoTramoCbo.Location = new System.Drawing.Point(147, 171);
            this.destinoTramoCbo.Name = "destinoTramoCbo";
            this.destinoTramoCbo.Size = new System.Drawing.Size(115, 21);
            this.destinoTramoCbo.TabIndex = 63;
            // 
            // materialLabel8
            // 
            this.materialLabel8.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.materialLabel8.AutoSize = true;
            this.materialLabel8.Depth = 0;
            this.materialLabel8.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel8.Location = new System.Drawing.Point(371, 144);
            this.materialLabel8.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel8.Name = "materialLabel8";
            this.materialLabel8.Size = new System.Drawing.Size(60, 19);
            this.materialLabel8.TabIndex = 66;
            this.materialLabel8.Text = "Tiempo";
            // 
            // materialSingleLineTextField2
            // 
            this.materialSingleLineTextField2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.materialSingleLineTextField2.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bindingSourceTramoEditando, "Distancia", true));
            this.materialSingleLineTextField2.Depth = 0;
            this.materialSingleLineTextField2.Hint = "Km";
            this.materialSingleLineTextField2.Location = new System.Drawing.Point(278, 171);
            this.materialSingleLineTextField2.MaxLength = 32767;
            this.materialSingleLineTextField2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialSingleLineTextField2.Name = "materialSingleLineTextField2";
            this.materialSingleLineTextField2.PasswordChar = '\0';
            this.materialSingleLineTextField2.SelectedText = "";
            this.materialSingleLineTextField2.SelectionLength = 0;
            this.materialSingleLineTextField2.SelectionStart = 0;
            this.materialSingleLineTextField2.Size = new System.Drawing.Size(80, 23);
            this.materialSingleLineTextField2.TabIndex = 65;
            this.materialSingleLineTextField2.TabStop = false;
            this.materialSingleLineTextField2.UseSystemPasswordChar = false;
            // 
            // materialLabel9
            // 
            this.materialLabel9.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.materialLabel9.AutoSize = true;
            this.materialLabel9.Depth = 0;
            this.materialLabel9.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel9.Location = new System.Drawing.Point(274, 144);
            this.materialLabel9.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel9.Name = "materialLabel9";
            this.materialLabel9.Size = new System.Drawing.Size(72, 19);
            this.materialLabel9.TabIndex = 68;
            this.materialLabel9.Text = "Distancia";
            // 
            // materialSingleLineTextField3
            // 
            this.materialSingleLineTextField3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.materialSingleLineTextField3.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bindingSourceTramoEditando, "TiempoViaje", true));
            this.materialSingleLineTextField3.Depth = 0;
            this.materialSingleLineTextField3.Hint = "Min";
            this.materialSingleLineTextField3.Location = new System.Drawing.Point(375, 171);
            this.materialSingleLineTextField3.MaxLength = 32767;
            this.materialSingleLineTextField3.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialSingleLineTextField3.Name = "materialSingleLineTextField3";
            this.materialSingleLineTextField3.PasswordChar = '\0';
            this.materialSingleLineTextField3.SelectedText = "";
            this.materialSingleLineTextField3.SelectionLength = 0;
            this.materialSingleLineTextField3.SelectionStart = 0;
            this.materialSingleLineTextField3.Size = new System.Drawing.Size(80, 23);
            this.materialSingleLineTextField3.TabIndex = 67;
            this.materialSingleLineTextField3.TabStop = false;
            this.materialSingleLineTextField3.UseSystemPasswordChar = false;
            // 
            // listadoTramos
            // 
            this.listadoTramos.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.listadoTramos.BackColor = System.Drawing.SystemColors.Window;
            this.listadoTramos.Location = new System.Drawing.Point(14, 212);
            this.listadoTramos.Name = "listadoTramos";
            this.listadoTramos.Size = new System.Drawing.Size(550, 176);
            this.listadoTramos.TabIndex = 60;
            // 
            // listadoFormaciones
            // 
            this.listadoFormaciones.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.listadoFormaciones.BackColor = System.Drawing.SystemColors.Window;
            this.listadoFormaciones.Location = new System.Drawing.Point(671, 212);
            this.listadoFormaciones.Name = "listadoFormaciones";
            this.listadoFormaciones.Size = new System.Drawing.Size(464, 176);
            this.listadoFormaciones.TabIndex = 53;
            // 
            // materialLabel10
            // 
            this.materialLabel10.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.materialLabel10.AutoSize = true;
            this.materialLabel10.Depth = 0;
            this.materialLabel10.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel10.Location = new System.Drawing.Point(677, 43);
            this.materialLabel10.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel10.Name = "materialLabel10";
            this.materialLabel10.Size = new System.Drawing.Size(112, 19);
            this.materialLabel10.TabIndex = 70;
            this.materialLabel10.Text = "Cantidad Inicial";
            // 
            // materialSingleLineTextField4
            // 
            this.materialSingleLineTextField4.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.materialSingleLineTextField4.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.BindingSourceServicio, "CantidadFormacionesInicio", true));
            this.materialSingleLineTextField4.Depth = 0;
            this.materialSingleLineTextField4.Hint = "";
            this.materialSingleLineTextField4.Location = new System.Drawing.Point(692, 65);
            this.materialSingleLineTextField4.MaxLength = 32767;
            this.materialSingleLineTextField4.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialSingleLineTextField4.Name = "materialSingleLineTextField4";
            this.materialSingleLineTextField4.PasswordChar = '\0';
            this.materialSingleLineTextField4.SelectedText = "";
            this.materialSingleLineTextField4.SelectionLength = 0;
            this.materialSingleLineTextField4.SelectionStart = 0;
            this.materialSingleLineTextField4.Size = new System.Drawing.Size(165, 23);
            this.materialSingleLineTextField4.TabIndex = 69;
            this.materialSingleLineTextField4.TabStop = false;
            this.materialSingleLineTextField4.UseSystemPasswordChar = false;
            // 
            // materialLabel11
            // 
            this.materialLabel11.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.materialLabel11.AutoSize = true;
            this.materialLabel11.Depth = 0;
            this.materialLabel11.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel11.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel11.Location = new System.Drawing.Point(677, 112);
            this.materialLabel11.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel11.Name = "materialLabel11";
            this.materialLabel11.Size = new System.Drawing.Size(47, 19);
            this.materialLabel11.TabIndex = 71;
            this.materialLabel11.Text = "Tipos";
            // 
            // programacionIdaButton
            // 
            this.programacionIdaButton.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.programacionIdaButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.programacionIdaButton.Depth = 0;
            this.programacionIdaButton.Icon = null;
            this.programacionIdaButton.Location = new System.Drawing.Point(955, 9);
            this.programacionIdaButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.programacionIdaButton.Name = "programacionIdaButton";
            this.programacionIdaButton.Primary = true;
            this.programacionIdaButton.Size = new System.Drawing.Size(180, 27);
            this.programacionIdaButton.TabIndex = 72;
            this.programacionIdaButton.Text = "Programacion Ida";
            this.programacionIdaButton.UseVisualStyleBackColor = true;
            this.programacionIdaButton.Click += new System.EventHandler(this.programacionIdaButton_Click);
            // 
            // programacionVueltaButton
            // 
            this.programacionVueltaButton.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.programacionVueltaButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.programacionVueltaButton.Depth = 0;
            this.programacionVueltaButton.Icon = null;
            this.programacionVueltaButton.Location = new System.Drawing.Point(955, 43);
            this.programacionVueltaButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.programacionVueltaButton.Name = "programacionVueltaButton";
            this.programacionVueltaButton.Primary = true;
            this.programacionVueltaButton.Size = new System.Drawing.Size(180, 27);
            this.programacionVueltaButton.TabIndex = 73;
            this.programacionVueltaButton.Text = "Programacion Vuelta";
            this.programacionVueltaButton.UseVisualStyleBackColor = true;
            this.programacionVueltaButton.Click += new System.EventHandler(this.programacionVueltaButton_Click);
            // 
            // ServicioAttrs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.Controls.Add(this.programacionVueltaButton);
            this.Controls.Add(this.programacionIdaButton);
            this.Controls.Add(this.materialLabel11);
            this.Controls.Add(this.materialLabel10);
            this.Controls.Add(this.materialSingleLineTextField4);
            this.Controls.Add(this.materialLabel9);
            this.Controls.Add(this.materialSingleLineTextField3);
            this.Controls.Add(this.materialLabel8);
            this.Controls.Add(this.materialSingleLineTextField2);
            this.Controls.Add(this.destinoTramoCbo);
            this.Controls.Add(this.origenTramoCbo);
            this.Controls.Add(this.materialRaisedButton1);
            this.Controls.Add(this.listadoTramos);
            this.Controls.Add(this.materialLabel1);
            this.Controls.Add(this.materialLabel5);
            this.Controls.Add(this.materialLabel6);
            this.Controls.Add(this.nombreFormacionCbo);
            this.Controls.Add(this.agregarBtn);
            this.Controls.Add(this.listadoFormaciones);
            this.Controls.Add(this.materialLabel4);
            this.Controls.Add(this.materialLabel3);
            this.Controls.Add(this.materialSingleLineTextField1);
            this.Controls.Add(this.materialLabel2);
            this.Controls.Add(this.materialLabel7);
            this.Controls.Add(this.nombreField);
            this.Name = "ServicioAttrs";
            this.Size = new System.Drawing.Size(1154, 483);
            ((System.ComponentModel.ISupportInitialize)(this.BindingSourceServicio)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceFormacionEditando)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceTramoEditando)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialSingleLineTextField nombreField;
        private MaterialSkin.Controls.MaterialLabel materialLabel7;
        private System.Windows.Forms.BindingSource BindingSourceServicio;
        private System.Windows.Forms.ComboBox nombreFormacionCbo;
        private MaterialSkin.Controls.MaterialRaisedButton agregarBtn;
        private MaterialList listadoFormaciones;
        private MaterialSkin.Controls.MaterialLabel materialLabel4;
        private MaterialSkin.Controls.MaterialLabel materialLabel3;
        private MaterialSkin.Controls.MaterialSingleLineTextField materialSingleLineTextField1;
        private MaterialSkin.Controls.MaterialLabel materialLabel2;
        private System.Windows.Forms.BindingSource bindingSourceFormacionEditando;
        private System.Windows.Forms.ComboBox origenTramoCbo;
        private MaterialSkin.Controls.MaterialRaisedButton materialRaisedButton1;
        private MaterialList listadoTramos;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private MaterialSkin.Controls.MaterialLabel materialLabel5;
        private MaterialSkin.Controls.MaterialLabel materialLabel6;
        private System.Windows.Forms.ComboBox destinoTramoCbo;
        private MaterialSkin.Controls.MaterialLabel materialLabel8;
        private MaterialSkin.Controls.MaterialSingleLineTextField materialSingleLineTextField2;
        private MaterialSkin.Controls.MaterialLabel materialLabel9;
        private MaterialSkin.Controls.MaterialSingleLineTextField materialSingleLineTextField3;
        private System.Windows.Forms.BindingSource bindingSourceTramoEditando;
        private MaterialSkin.Controls.MaterialLabel materialLabel10;
        private MaterialSkin.Controls.MaterialSingleLineTextField materialSingleLineTextField4;
        private MaterialSkin.Controls.MaterialLabel materialLabel11;
        private MaterialSkin.Controls.MaterialRaisedButton programacionIdaButton;
        private MaterialSkin.Controls.MaterialRaisedButton programacionVueltaButton;
    }
}
