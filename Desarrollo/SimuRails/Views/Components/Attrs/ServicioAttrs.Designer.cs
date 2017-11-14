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
            this.cantidadEnInicioField = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.materialLabel11 = new MaterialSkin.Controls.MaterialLabel();
            this.programacionIdaButton = new MaterialSkin.Controls.MaterialRaisedButton();
            this.programacionVueltaButton = new MaterialSkin.Controls.MaterialRaisedButton();
            this.errorNombreLbl = new System.Windows.Forms.Label();
            this.errorEstacionSalidaLbl = new System.Windows.Forms.Label();
            this.errorDistanciaLbl = new System.Windows.Forms.Label();
            this.errorCantidadLbl = new System.Windows.Forms.Label();
            this.errorEstacionLlegadaLbl = new System.Windows.Forms.Label();
            this.errorCantidadEnInicio = new System.Windows.Forms.Label();
            this.errorFormacionLbl = new System.Windows.Forms.Label();
            this.errorTiempoLbl = new System.Windows.Forms.Label();
            this.errorTramoLbl = new System.Windows.Forms.Label();
            this.errorFormacionesLbl = new System.Windows.Forms.Label();
            this.materialLabel12 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel13 = new MaterialSkin.Controls.MaterialLabel();
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
            this.nombreField.IsNumeric = false;
            this.nombreField.Location = new System.Drawing.Point(17, 39);
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
            this.materialLabel7.Location = new System.Drawing.Point(13, 18);
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
            this.nombreFormacionCbo.Location = new System.Drawing.Point(821, 192);
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
            this.agregarBtn.Location = new System.Drawing.Point(1187, 186);
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
            this.materialLabel4.Location = new System.Drawing.Point(817, 164);
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
            this.materialLabel3.Location = new System.Drawing.Point(1018, 165);
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
            this.materialSingleLineTextField1.IsNumeric = false;
            this.materialSingleLineTextField1.Location = new System.Drawing.Point(1022, 192);
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
            this.materialLabel2.Location = new System.Drawing.Point(795, 37);
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
            this.origenTramoCbo.Location = new System.Drawing.Point(27, 192);
            this.origenTramoCbo.Name = "origenTramoCbo";
            this.origenTramoCbo.Size = new System.Drawing.Size(159, 21);
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
            this.materialRaisedButton1.Location = new System.Drawing.Point(654, 188);
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
            this.materialLabel1.Location = new System.Drawing.Point(23, 167);
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
            this.materialLabel5.Location = new System.Drawing.Point(200, 170);
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
            this.materialLabel6.Location = new System.Drawing.Point(13, 136);
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
            this.destinoTramoCbo.Location = new System.Drawing.Point(204, 192);
            this.destinoTramoCbo.Name = "destinoTramoCbo";
            this.destinoTramoCbo.Size = new System.Drawing.Size(159, 21);
            this.destinoTramoCbo.TabIndex = 63;
            // 
            // materialLabel8
            // 
            this.materialLabel8.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.materialLabel8.AutoSize = true;
            this.materialLabel8.Depth = 0;
            this.materialLabel8.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel8.Location = new System.Drawing.Point(530, 167);
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
            this.materialSingleLineTextField2.IsNumeric = false;
            this.materialSingleLineTextField2.Location = new System.Drawing.Point(379, 192);
            this.materialSingleLineTextField2.MaxLength = 32767;
            this.materialSingleLineTextField2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialSingleLineTextField2.Name = "materialSingleLineTextField2";
            this.materialSingleLineTextField2.PasswordChar = '\0';
            this.materialSingleLineTextField2.SelectedText = "";
            this.materialSingleLineTextField2.SelectionLength = 0;
            this.materialSingleLineTextField2.SelectionStart = 0;
            this.materialSingleLineTextField2.Size = new System.Drawing.Size(68, 23);
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
            this.materialLabel9.Location = new System.Drawing.Point(375, 165);
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
            this.materialSingleLineTextField3.IsNumeric = false;
            this.materialSingleLineTextField3.Location = new System.Drawing.Point(534, 194);
            this.materialSingleLineTextField3.MaxLength = 32767;
            this.materialSingleLineTextField3.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialSingleLineTextField3.Name = "materialSingleLineTextField3";
            this.materialSingleLineTextField3.PasswordChar = '\0';
            this.materialSingleLineTextField3.SelectedText = "";
            this.materialSingleLineTextField3.SelectionLength = 0;
            this.materialSingleLineTextField3.SelectionStart = 0;
            this.materialSingleLineTextField3.Size = new System.Drawing.Size(67, 23);
            this.materialSingleLineTextField3.TabIndex = 67;
            this.materialSingleLineTextField3.TabStop = false;
            this.materialSingleLineTextField3.UseSystemPasswordChar = false;
            // 
            // listadoTramos
            // 
            this.listadoTramos.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.listadoTramos.AutoScroll = true;
            this.listadoTramos.BackColor = System.Drawing.SystemColors.Window;
            this.listadoTramos.Location = new System.Drawing.Point(17, 237);
            this.listadoTramos.Name = "listadoTramos";
            this.listadoTramos.Size = new System.Drawing.Size(731, 325);
            this.listadoTramos.TabIndex = 60;
            // 
            // listadoFormaciones
            // 
            this.listadoFormaciones.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.listadoFormaciones.AutoScroll = true;
            this.listadoFormaciones.BackColor = System.Drawing.SystemColors.Window;
            this.listadoFormaciones.Location = new System.Drawing.Point(810, 237);
            this.listadoFormaciones.Name = "listadoFormaciones";
            this.listadoFormaciones.Size = new System.Drawing.Size(464, 325);
            this.listadoFormaciones.TabIndex = 53;
            // 
            // materialLabel10
            // 
            this.materialLabel10.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.materialLabel10.AutoSize = true;
            this.materialLabel10.Depth = 0;
            this.materialLabel10.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel10.Location = new System.Drawing.Point(806, 60);
            this.materialLabel10.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel10.Name = "materialLabel10";
            this.materialLabel10.Size = new System.Drawing.Size(208, 19);
            this.materialLabel10.TabIndex = 70;
            this.materialLabel10.Text = "Cantidad en terminal de inicio";
            // 
            // cantidadEnInicioField
            // 
            this.cantidadEnInicioField.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.cantidadEnInicioField.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.BindingSourceServicio, "CantidadFormacionesInicio", true));
            this.cantidadEnInicioField.Depth = 0;
            this.cantidadEnInicioField.Hint = "";
            this.cantidadEnInicioField.IsNumeric = false;
            this.cantidadEnInicioField.Location = new System.Drawing.Point(810, 82);
            this.cantidadEnInicioField.MaxLength = 32767;
            this.cantidadEnInicioField.MouseState = MaterialSkin.MouseState.HOVER;
            this.cantidadEnInicioField.Name = "cantidadEnInicioField";
            this.cantidadEnInicioField.PasswordChar = '\0';
            this.cantidadEnInicioField.SelectedText = "";
            this.cantidadEnInicioField.SelectionLength = 0;
            this.cantidadEnInicioField.SelectionStart = 0;
            this.cantidadEnInicioField.Size = new System.Drawing.Size(212, 23);
            this.cantidadEnInicioField.TabIndex = 69;
            this.cantidadEnInicioField.TabStop = false;
            this.cantidadEnInicioField.UseSystemPasswordChar = false;
            // 
            // materialLabel11
            // 
            this.materialLabel11.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.materialLabel11.AutoSize = true;
            this.materialLabel11.Depth = 0;
            this.materialLabel11.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel11.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel11.Location = new System.Drawing.Point(806, 133);
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
            this.programacionIdaButton.Location = new System.Drawing.Point(358, 39);
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
            this.programacionVueltaButton.Location = new System.Drawing.Point(568, 39);
            this.programacionVueltaButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.programacionVueltaButton.Name = "programacionVueltaButton";
            this.programacionVueltaButton.Primary = true;
            this.programacionVueltaButton.Size = new System.Drawing.Size(180, 27);
            this.programacionVueltaButton.TabIndex = 73;
            this.programacionVueltaButton.Text = "Programacion Vuelta";
            this.programacionVueltaButton.UseVisualStyleBackColor = true;
            this.programacionVueltaButton.Click += new System.EventHandler(this.programacionVueltaButton_Click);
            // 
            // errorNombreLbl
            // 
            this.errorNombreLbl.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.errorNombreLbl.AutoSize = true;
            this.errorNombreLbl.Font = new System.Drawing.Font("Roboto Medium", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.errorNombreLbl.ForeColor = System.Drawing.Color.DarkRed;
            this.errorNombreLbl.Location = new System.Drawing.Point(14, 68);
            this.errorNombreLbl.Name = "errorNombreLbl";
            this.errorNombreLbl.Size = new System.Drawing.Size(162, 14);
            this.errorNombreLbl.TabIndex = 74;
            this.errorNombreLbl.Text = "Este campo es requerido";
            this.errorNombreLbl.Visible = false;
            // 
            // errorEstacionSalidaLbl
            // 
            this.errorEstacionSalidaLbl.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.errorEstacionSalidaLbl.AutoSize = true;
            this.errorEstacionSalidaLbl.Font = new System.Drawing.Font("Roboto Medium", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.errorEstacionSalidaLbl.ForeColor = System.Drawing.Color.DarkRed;
            this.errorEstacionSalidaLbl.Location = new System.Drawing.Point(24, 220);
            this.errorEstacionSalidaLbl.Name = "errorEstacionSalidaLbl";
            this.errorEstacionSalidaLbl.Size = new System.Drawing.Size(162, 14);
            this.errorEstacionSalidaLbl.TabIndex = 75;
            this.errorEstacionSalidaLbl.Text = "Este campo es requerido";
            this.errorEstacionSalidaLbl.Visible = false;
            // 
            // errorDistanciaLbl
            // 
            this.errorDistanciaLbl.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.errorDistanciaLbl.AutoSize = true;
            this.errorDistanciaLbl.Font = new System.Drawing.Font("Roboto Medium", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.errorDistanciaLbl.ForeColor = System.Drawing.Color.DarkRed;
            this.errorDistanciaLbl.Location = new System.Drawing.Point(376, 220);
            this.errorDistanciaLbl.Name = "errorDistanciaLbl";
            this.errorDistanciaLbl.Size = new System.Drawing.Size(128, 14);
            this.errorDistanciaLbl.TabIndex = 77;
            this.errorDistanciaLbl.Text = "Debe ser mayor a 0";
            this.errorDistanciaLbl.Visible = false;
            // 
            // errorCantidadLbl
            // 
            this.errorCantidadLbl.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.errorCantidadLbl.AutoSize = true;
            this.errorCantidadLbl.Font = new System.Drawing.Font("Roboto Medium", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.errorCantidadLbl.ForeColor = System.Drawing.Color.DarkRed;
            this.errorCantidadLbl.Location = new System.Drawing.Point(1019, 220);
            this.errorCantidadLbl.Name = "errorCantidadLbl";
            this.errorCantidadLbl.Size = new System.Drawing.Size(128, 14);
            this.errorCantidadLbl.TabIndex = 78;
            this.errorCantidadLbl.Text = "Debe ser mayor a 0";
            this.errorCantidadLbl.Visible = false;
            // 
            // errorEstacionLlegadaLbl
            // 
            this.errorEstacionLlegadaLbl.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.errorEstacionLlegadaLbl.AutoSize = true;
            this.errorEstacionLlegadaLbl.Font = new System.Drawing.Font("Roboto Medium", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.errorEstacionLlegadaLbl.ForeColor = System.Drawing.Color.DarkRed;
            this.errorEstacionLlegadaLbl.Location = new System.Drawing.Point(201, 220);
            this.errorEstacionLlegadaLbl.Name = "errorEstacionLlegadaLbl";
            this.errorEstacionLlegadaLbl.Size = new System.Drawing.Size(162, 14);
            this.errorEstacionLlegadaLbl.TabIndex = 79;
            this.errorEstacionLlegadaLbl.Text = "Este campo es requerido";
            this.errorEstacionLlegadaLbl.Visible = false;
            // 
            // errorCantidadEnInicio
            // 
            this.errorCantidadEnInicio.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.errorCantidadEnInicio.AutoSize = true;
            this.errorCantidadEnInicio.Font = new System.Drawing.Font("Roboto Medium", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.errorCantidadEnInicio.ForeColor = System.Drawing.Color.DarkRed;
            this.errorCantidadEnInicio.Location = new System.Drawing.Point(807, 108);
            this.errorCantidadEnInicio.Name = "errorCantidadEnInicio";
            this.errorCantidadEnInicio.Size = new System.Drawing.Size(116, 14);
            this.errorCantidadEnInicio.TabIndex = 80;
            this.errorCantidadEnInicio.Text = "Debe ser positivo";
            this.errorCantidadEnInicio.Visible = false;
            // 
            // errorFormacionLbl
            // 
            this.errorFormacionLbl.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.errorFormacionLbl.AutoSize = true;
            this.errorFormacionLbl.Font = new System.Drawing.Font("Roboto Medium", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.errorFormacionLbl.ForeColor = System.Drawing.Color.DarkRed;
            this.errorFormacionLbl.Location = new System.Drawing.Point(818, 220);
            this.errorFormacionLbl.Name = "errorFormacionLbl";
            this.errorFormacionLbl.Size = new System.Drawing.Size(162, 14);
            this.errorFormacionLbl.TabIndex = 81;
            this.errorFormacionLbl.Text = "Este campo es requerido";
            this.errorFormacionLbl.Visible = false;
            // 
            // errorTiempoLbl
            // 
            this.errorTiempoLbl.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.errorTiempoLbl.AutoSize = true;
            this.errorTiempoLbl.Font = new System.Drawing.Font("Roboto Medium", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.errorTiempoLbl.ForeColor = System.Drawing.Color.DarkRed;
            this.errorTiempoLbl.Location = new System.Drawing.Point(531, 220);
            this.errorTiempoLbl.Name = "errorTiempoLbl";
            this.errorTiempoLbl.Size = new System.Drawing.Size(128, 14);
            this.errorTiempoLbl.TabIndex = 82;
            this.errorTiempoLbl.Text = "Debe ser mayor a 0";
            this.errorTiempoLbl.Visible = false;
            // 
            // errorTramoLbl
            // 
            this.errorTramoLbl.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.errorTramoLbl.AutoSize = true;
            this.errorTramoLbl.Font = new System.Drawing.Font("Roboto Medium", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.errorTramoLbl.ForeColor = System.Drawing.Color.DarkRed;
            this.errorTramoLbl.Location = new System.Drawing.Point(167, 282);
            this.errorTramoLbl.Name = "errorTramoLbl";
            this.errorTramoLbl.Size = new System.Drawing.Size(196, 14);
            this.errorTramoLbl.TabIndex = 83;
            this.errorTramoLbl.Text = "Al menos debe tener un tramo";
            this.errorTramoLbl.Visible = false;
            // 
            // errorFormacionesLbl
            // 
            this.errorFormacionesLbl.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.errorFormacionesLbl.AutoSize = true;
            this.errorFormacionesLbl.Font = new System.Drawing.Font("Roboto Medium", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.errorFormacionesLbl.ForeColor = System.Drawing.Color.DarkRed;
            this.errorFormacionesLbl.Location = new System.Drawing.Point(942, 282);
            this.errorFormacionesLbl.Name = "errorFormacionesLbl";
            this.errorFormacionesLbl.Size = new System.Drawing.Size(231, 14);
            this.errorFormacionesLbl.TabIndex = 84;
            this.errorFormacionesLbl.Text = "Al menos debe tener una formación";
            this.errorFormacionesLbl.Visible = false;
            // 
            // materialLabel12
            // 
            this.materialLabel12.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.materialLabel12.AutoSize = true;
            this.materialLabel12.Depth = 0;
            this.materialLabel12.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel12.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel12.Location = new System.Drawing.Point(453, 194);
            this.materialLabel12.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel12.Name = "materialLabel12";
            this.materialLabel12.Size = new System.Drawing.Size(39, 19);
            this.materialLabel12.TabIndex = 87;
            this.materialLabel12.Text = "Kms";
            // 
            // materialLabel13
            // 
            this.materialLabel13.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.materialLabel13.AutoSize = true;
            this.materialLabel13.Depth = 0;
            this.materialLabel13.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel13.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel13.Location = new System.Drawing.Point(607, 194);
            this.materialLabel13.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel13.Name = "materialLabel13";
            this.materialLabel13.Size = new System.Drawing.Size(34, 19);
            this.materialLabel13.TabIndex = 88;
            this.materialLabel13.Text = "Min";
            // 
            // ServicioAttrs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.Controls.Add(this.materialLabel13);
            this.Controls.Add(this.materialLabel12);
            this.Controls.Add(this.errorFormacionesLbl);
            this.Controls.Add(this.errorTramoLbl);
            this.Controls.Add(this.errorTiempoLbl);
            this.Controls.Add(this.errorFormacionLbl);
            this.Controls.Add(this.errorCantidadEnInicio);
            this.Controls.Add(this.errorEstacionLlegadaLbl);
            this.Controls.Add(this.errorCantidadLbl);
            this.Controls.Add(this.errorDistanciaLbl);
            this.Controls.Add(this.errorEstacionSalidaLbl);
            this.Controls.Add(this.errorNombreLbl);
            this.Controls.Add(this.programacionVueltaButton);
            this.Controls.Add(this.programacionIdaButton);
            this.Controls.Add(this.materialLabel11);
            this.Controls.Add(this.materialLabel10);
            this.Controls.Add(this.cantidadEnInicioField);
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
            this.Size = new System.Drawing.Size(1314, 593);
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
        private MaterialSkin.Controls.MaterialSingleLineTextField cantidadEnInicioField;
        private MaterialSkin.Controls.MaterialLabel materialLabel11;
        private MaterialSkin.Controls.MaterialRaisedButton programacionIdaButton;
        private MaterialSkin.Controls.MaterialRaisedButton programacionVueltaButton;
        private System.Windows.Forms.Label errorNombreLbl;
        private System.Windows.Forms.Label errorEstacionSalidaLbl;
        private System.Windows.Forms.Label errorDistanciaLbl;
        private System.Windows.Forms.Label errorCantidadLbl;
        private System.Windows.Forms.Label errorEstacionLlegadaLbl;
        private System.Windows.Forms.Label errorCantidadEnInicio;
        private System.Windows.Forms.Label errorFormacionLbl;
        private System.Windows.Forms.Label errorTiempoLbl;
        private System.Windows.Forms.Label errorTramoLbl;
        private System.Windows.Forms.Label errorFormacionesLbl;
        private MaterialSkin.Controls.MaterialLabel materialLabel12;
        private MaterialSkin.Controls.MaterialLabel materialLabel13;
    }
}
