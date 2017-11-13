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
            this.tiempoEnManteField = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.bindingSourceFormacion = new System.Windows.Forms.BindingSource(this.components);
            this.distanciaManteField = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.nombreField = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.cantidadCocheField = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.bindingSourceCocheEditando = new System.Windows.Forms.BindingSource(this.components);
            this.materialLabel3 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel4 = new MaterialSkin.Controls.MaterialLabel();
            this.agregarBtn = new MaterialSkin.Controls.MaterialRaisedButton();
            this.modeloCbo = new System.Windows.Forms.ComboBox();
            this.errorNombreLbl = new System.Windows.Forms.Label();
            this.errorDistanciaLbl = new System.Windows.Forms.Label();
            this.errorTiempoManteLbl = new System.Windows.Forms.Label();
            this.errorModeloLbl = new System.Windows.Forms.Label();
            this.errorCantidadLbl = new System.Windows.Forms.Label();
            this.errorCochesLbl = new System.Windows.Forms.Label();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel8 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel9 = new MaterialSkin.Controls.MaterialLabel();
            this.listadoCoches = new SimuRails.Views.Components.MaterialList();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceFormacion)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceCocheEditando)).BeginInit();
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
            this.materialLabel7.TabIndex = 41;
            this.materialLabel7.Text = "Nombre";
            // 
            // materialLabel6
            // 
            this.materialLabel6.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.materialLabel6.AutoSize = true;
            this.materialLabel6.Depth = 0;
            this.materialLabel6.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel6.Location = new System.Drawing.Point(622, 36);
            this.materialLabel6.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel6.Name = "materialLabel6";
            this.materialLabel6.Size = new System.Drawing.Size(185, 19);
            this.materialLabel6.TabIndex = 40;
            this.materialLabel6.Text = "Tiempo en mantenimiento";
            // 
            // materialLabel5
            // 
            this.materialLabel5.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.materialLabel5.AutoSize = true;
            this.materialLabel5.Depth = 0;
            this.materialLabel5.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel5.Location = new System.Drawing.Point(353, 36);
            this.materialLabel5.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel5.Name = "materialLabel5";
            this.materialLabel5.Size = new System.Drawing.Size(172, 19);
            this.materialLabel5.TabIndex = 39;
            this.materialLabel5.Text = "Distancia hasta próximo";
            // 
            // materialLabel2
            // 
            this.materialLabel2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.materialLabel2.AutoSize = true;
            this.materialLabel2.Depth = 0;
            this.materialLabel2.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel2.Location = new System.Drawing.Point(19, 146);
            this.materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel2.Name = "materialLabel2";
            this.materialLabel2.Size = new System.Drawing.Size(60, 19);
            this.materialLabel2.TabIndex = 36;
            this.materialLabel2.Text = "Coches";
            // 
            // materialDivider1
            // 
            this.materialDivider1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.materialDivider1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialDivider1.Depth = 0;
            this.materialDivider1.Location = new System.Drawing.Point(4, 126);
            this.materialDivider1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialDivider1.Name = "materialDivider1";
            this.materialDivider1.Size = new System.Drawing.Size(867, 2);
            this.materialDivider1.TabIndex = 35;
            this.materialDivider1.Text = "materialDivider1";
            // 
            // tiempoEnManteField
            // 
            this.tiempoEnManteField.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.tiempoEnManteField.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bindingSourceFormacion, "DuracionMantenimiento", true));
            this.tiempoEnManteField.Depth = 0;
            this.tiempoEnManteField.Hint = "Min";
            this.tiempoEnManteField.IsNumeric = false;
            this.tiempoEnManteField.Location = new System.Drawing.Point(626, 68);
            this.tiempoEnManteField.MaxLength = 32767;
            this.tiempoEnManteField.MouseState = MaterialSkin.MouseState.HOVER;
            this.tiempoEnManteField.Name = "tiempoEnManteField";
            this.tiempoEnManteField.PasswordChar = '\0';
            this.tiempoEnManteField.SelectedText = "";
            this.tiempoEnManteField.SelectionLength = 0;
            this.tiempoEnManteField.SelectionStart = 0;
            this.tiempoEnManteField.Size = new System.Drawing.Size(111, 23);
            this.tiempoEnManteField.TabIndex = 30;
            this.tiempoEnManteField.TabStop = false;
            this.tiempoEnManteField.UseSystemPasswordChar = false;
            // 
            // bindingSourceFormacion
            // 
            this.bindingSourceFormacion.DataSource = typeof(SimuRails.Models.Formacion);
            // 
            // distanciaManteField
            // 
            this.distanciaManteField.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.distanciaManteField.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bindingSourceFormacion, "KilometrosMantenimiento", true));
            this.distanciaManteField.Depth = 0;
            this.distanciaManteField.Hint = "Kms";
            this.distanciaManteField.IsNumeric = false;
            this.distanciaManteField.Location = new System.Drawing.Point(357, 68);
            this.distanciaManteField.MaxLength = 32767;
            this.distanciaManteField.MouseState = MaterialSkin.MouseState.HOVER;
            this.distanciaManteField.Name = "distanciaManteField";
            this.distanciaManteField.PasswordChar = '\0';
            this.distanciaManteField.SelectedText = "";
            this.distanciaManteField.SelectionLength = 0;
            this.distanciaManteField.SelectionStart = 0;
            this.distanciaManteField.Size = new System.Drawing.Size(114, 23);
            this.distanciaManteField.TabIndex = 29;
            this.distanciaManteField.TabStop = false;
            this.distanciaManteField.UseSystemPasswordChar = false;
            // 
            // nombreField
            // 
            this.nombreField.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.nombreField.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bindingSourceFormacion, "Nombre", true));
            this.nombreField.Depth = 0;
            this.nombreField.Hint = "";
            this.nombreField.IsNumeric = false;
            this.nombreField.Location = new System.Drawing.Point(20, 68);
            this.nombreField.MaxLength = 32767;
            this.nombreField.MouseState = MaterialSkin.MouseState.HOVER;
            this.nombreField.Name = "nombreField";
            this.nombreField.PasswordChar = '\0';
            this.nombreField.SelectedText = "";
            this.nombreField.SelectionLength = 0;
            this.nombreField.SelectionStart = 0;
            this.nombreField.Size = new System.Drawing.Size(270, 23);
            this.nombreField.TabIndex = 26;
            this.nombreField.TabStop = false;
            this.nombreField.UseSystemPasswordChar = false;
            // 
            // cantidadCocheField
            // 
            this.cantidadCocheField.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.cantidadCocheField.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bindingSourceCocheEditando, "Cantidad", true));
            this.cantidadCocheField.Depth = 0;
            this.cantidadCocheField.Hint = "";
            this.cantidadCocheField.IsNumeric = false;
            this.cantidadCocheField.Location = new System.Drawing.Point(330, 205);
            this.cantidadCocheField.MaxLength = 32767;
            this.cantidadCocheField.MouseState = MaterialSkin.MouseState.HOVER;
            this.cantidadCocheField.Name = "cantidadCocheField";
            this.cantidadCocheField.PasswordChar = '\0';
            this.cantidadCocheField.SelectedText = "";
            this.cantidadCocheField.SelectionLength = 0;
            this.cantidadCocheField.SelectionStart = 0;
            this.cantidadCocheField.Size = new System.Drawing.Size(172, 23);
            this.cantidadCocheField.TabIndex = 43;
            this.cantidadCocheField.TabStop = false;
            this.cantidadCocheField.UseSystemPasswordChar = false;
            // 
            // bindingSourceCocheEditando
            // 
            this.bindingSourceCocheEditando.DataSource = typeof(SimuRails.Models.AgrupacionCoche);
            // 
            // materialLabel3
            // 
            this.materialLabel3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.materialLabel3.AutoSize = true;
            this.materialLabel3.Depth = 0;
            this.materialLabel3.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel3.Location = new System.Drawing.Point(326, 174);
            this.materialLabel3.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel3.Name = "materialLabel3";
            this.materialLabel3.Size = new System.Drawing.Size(68, 19);
            this.materialLabel3.TabIndex = 44;
            this.materialLabel3.Text = "Cantidad";
            // 
            // materialLabel4
            // 
            this.materialLabel4.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.materialLabel4.AutoSize = true;
            this.materialLabel4.Depth = 0;
            this.materialLabel4.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel4.Location = new System.Drawing.Point(37, 174);
            this.materialLabel4.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel4.Name = "materialLabel4";
            this.materialLabel4.Size = new System.Drawing.Size(60, 19);
            this.materialLabel4.TabIndex = 45;
            this.materialLabel4.Text = "Modelo";
            // 
            // agregarBtn
            // 
            this.agregarBtn.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.agregarBtn.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.agregarBtn.Depth = 0;
            this.agregarBtn.Icon = null;
            this.agregarBtn.Location = new System.Drawing.Point(646, 201);
            this.agregarBtn.MouseState = MaterialSkin.MouseState.HOVER;
            this.agregarBtn.Name = "agregarBtn";
            this.agregarBtn.Primary = true;
            this.agregarBtn.Size = new System.Drawing.Size(107, 27);
            this.agregarBtn.TabIndex = 47;
            this.agregarBtn.Text = "Agregar";
            this.agregarBtn.UseVisualStyleBackColor = true;
            this.agregarBtn.Click += new System.EventHandler(this.agregarBtn_Click);
            // 
            // modeloCbo
            // 
            this.modeloCbo.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.modeloCbo.DataBindings.Add(new System.Windows.Forms.Binding("SelectedItem", this.bindingSourceCocheEditando, "Coche", true));
            this.modeloCbo.FormattingEnabled = true;
            this.modeloCbo.Location = new System.Drawing.Point(41, 205);
            this.modeloCbo.Name = "modeloCbo";
            this.modeloCbo.Size = new System.Drawing.Size(165, 21);
            this.modeloCbo.TabIndex = 48;
            // 
            // errorNombreLbl
            // 
            this.errorNombreLbl.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.errorNombreLbl.AutoSize = true;
            this.errorNombreLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.errorNombreLbl.ForeColor = System.Drawing.Color.DarkRed;
            this.errorNombreLbl.Location = new System.Drawing.Point(17, 94);
            this.errorNombreLbl.Name = "errorNombreLbl";
            this.errorNombreLbl.Size = new System.Drawing.Size(167, 15);
            this.errorNombreLbl.TabIndex = 49;
            this.errorNombreLbl.Text = "Este campo es requerido";
            this.errorNombreLbl.Visible = false;
            // 
            // errorDistanciaLbl
            // 
            this.errorDistanciaLbl.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.errorDistanciaLbl.AutoSize = true;
            this.errorDistanciaLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.errorDistanciaLbl.ForeColor = System.Drawing.Color.DarkRed;
            this.errorDistanciaLbl.Location = new System.Drawing.Point(354, 94);
            this.errorDistanciaLbl.Name = "errorDistanciaLbl";
            this.errorDistanciaLbl.Size = new System.Drawing.Size(167, 15);
            this.errorDistanciaLbl.TabIndex = 50;
            this.errorDistanciaLbl.Text = "Este campo es requerido";
            this.errorDistanciaLbl.Visible = false;
            // 
            // errorTiempoManteLbl
            // 
            this.errorTiempoManteLbl.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.errorTiempoManteLbl.AutoSize = true;
            this.errorTiempoManteLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.errorTiempoManteLbl.ForeColor = System.Drawing.Color.DarkRed;
            this.errorTiempoManteLbl.Location = new System.Drawing.Point(623, 94);
            this.errorTiempoManteLbl.Name = "errorTiempoManteLbl";
            this.errorTiempoManteLbl.Size = new System.Drawing.Size(167, 15);
            this.errorTiempoManteLbl.TabIndex = 51;
            this.errorTiempoManteLbl.Text = "Este campo es requerido";
            this.errorTiempoManteLbl.Visible = false;
            // 
            // errorModeloLbl
            // 
            this.errorModeloLbl.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.errorModeloLbl.AutoSize = true;
            this.errorModeloLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.errorModeloLbl.ForeColor = System.Drawing.Color.DarkRed;
            this.errorModeloLbl.Location = new System.Drawing.Point(44, 229);
            this.errorModeloLbl.Name = "errorModeloLbl";
            this.errorModeloLbl.Size = new System.Drawing.Size(167, 15);
            this.errorModeloLbl.TabIndex = 52;
            this.errorModeloLbl.Text = "Este campo es requerido";
            this.errorModeloLbl.Visible = false;
            // 
            // errorCantidadLbl
            // 
            this.errorCantidadLbl.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.errorCantidadLbl.AutoSize = true;
            this.errorCantidadLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.errorCantidadLbl.ForeColor = System.Drawing.Color.DarkRed;
            this.errorCantidadLbl.Location = new System.Drawing.Point(327, 231);
            this.errorCantidadLbl.Name = "errorCantidadLbl";
            this.errorCantidadLbl.Size = new System.Drawing.Size(167, 15);
            this.errorCantidadLbl.TabIndex = 53;
            this.errorCantidadLbl.Text = "Este campo es requerido";
            this.errorCantidadLbl.Visible = false;
            // 
            // errorCochesLbl
            // 
            this.errorCochesLbl.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.errorCochesLbl.AutoSize = true;
            this.errorCochesLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.errorCochesLbl.ForeColor = System.Drawing.Color.DarkRed;
            this.errorCochesLbl.Location = new System.Drawing.Point(157, 314);
            this.errorCochesLbl.Name = "errorCochesLbl";
            this.errorCochesLbl.Size = new System.Drawing.Size(167, 15);
            this.errorCochesLbl.TabIndex = 54;
            this.errorCochesLbl.Text = "Este campo es requerido";
            this.errorCochesLbl.Visible = false;
            // 
            // materialLabel1
            // 
            this.materialLabel1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel1.Location = new System.Drawing.Point(337, 10);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(110, 19);
            this.materialLabel1.TabIndex = 34;
            this.materialLabel1.Text = "Mantenimiento";
            // 
            // materialLabel8
            // 
            this.materialLabel8.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.materialLabel8.AutoSize = true;
            this.materialLabel8.Depth = 0;
            this.materialLabel8.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel8.Location = new System.Drawing.Point(743, 68);
            this.materialLabel8.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel8.Name = "materialLabel8";
            this.materialLabel8.Size = new System.Drawing.Size(64, 19);
            this.materialLabel8.TabIndex = 55;
            this.materialLabel8.Text = "minutos";
            // 
            // materialLabel9
            // 
            this.materialLabel9.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.materialLabel9.AutoSize = true;
            this.materialLabel9.Depth = 0;
            this.materialLabel9.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel9.Location = new System.Drawing.Point(477, 68);
            this.materialLabel9.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel9.Name = "materialLabel9";
            this.materialLabel9.Size = new System.Drawing.Size(38, 19);
            this.materialLabel9.TabIndex = 56;
            this.materialLabel9.Text = "kms";
            // 
            // listadoCoches
            // 
            this.listadoCoches.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.listadoCoches.BackColor = System.Drawing.SystemColors.Window;
            this.listadoCoches.Location = new System.Drawing.Point(20, 269);
            this.listadoCoches.Name = "listadoCoches";
            this.listadoCoches.Size = new System.Drawing.Size(752, 176);
            this.listadoCoches.TabIndex = 46;
            // 
            // FormacionAttr
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.Controls.Add(this.materialLabel9);
            this.Controls.Add(this.materialLabel8);
            this.Controls.Add(this.errorCochesLbl);
            this.Controls.Add(this.errorCantidadLbl);
            this.Controls.Add(this.errorModeloLbl);
            this.Controls.Add(this.errorTiempoManteLbl);
            this.Controls.Add(this.errorDistanciaLbl);
            this.Controls.Add(this.errorNombreLbl);
            this.Controls.Add(this.modeloCbo);
            this.Controls.Add(this.agregarBtn);
            this.Controls.Add(this.listadoCoches);
            this.Controls.Add(this.materialLabel4);
            this.Controls.Add(this.materialLabel3);
            this.Controls.Add(this.cantidadCocheField);
            this.Controls.Add(this.materialLabel7);
            this.Controls.Add(this.materialLabel6);
            this.Controls.Add(this.materialLabel5);
            this.Controls.Add(this.materialLabel2);
            this.Controls.Add(this.materialDivider1);
            this.Controls.Add(this.tiempoEnManteField);
            this.Controls.Add(this.distanciaManteField);
            this.Controls.Add(this.materialLabel1);
            this.Controls.Add(this.nombreField);
            this.Name = "FormacionAttr";
            this.Size = new System.Drawing.Size(871, 478);
            this.Load += new System.EventHandler(this.FormacionAttr_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceFormacion)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceCocheEditando)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private MaterialSkin.Controls.MaterialLabel materialLabel7;
        private MaterialSkin.Controls.MaterialLabel materialLabel6;
        private MaterialSkin.Controls.MaterialLabel materialLabel5;
        private MaterialSkin.Controls.MaterialLabel materialLabel2;
        private MaterialSkin.Controls.MaterialDivider materialDivider1;
        private MaterialSkin.Controls.MaterialSingleLineTextField tiempoEnManteField;
        private MaterialSkin.Controls.MaterialSingleLineTextField distanciaManteField;
        private MaterialSkin.Controls.MaterialSingleLineTextField nombreField;
        private System.Windows.Forms.BindingSource bindingSourceFormacion;
        private MaterialSkin.Controls.MaterialSingleLineTextField cantidadCocheField;
        private MaterialSkin.Controls.MaterialLabel materialLabel3;
        private MaterialSkin.Controls.MaterialLabel materialLabel4;
        private MaterialList listadoCoches;
        private MaterialSkin.Controls.MaterialRaisedButton agregarBtn;
        private System.Windows.Forms.BindingSource bindingSourceCocheEditando;
        private System.Windows.Forms.ComboBox modeloCbo;
        private System.Windows.Forms.Label errorNombreLbl;
        private System.Windows.Forms.Label errorDistanciaLbl;
        private System.Windows.Forms.Label errorTiempoManteLbl;
        private System.Windows.Forms.Label errorModeloLbl;
        private System.Windows.Forms.Label errorCantidadLbl;
        private System.Windows.Forms.Label errorCochesLbl;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private MaterialSkin.Controls.MaterialLabel materialLabel8;
        private MaterialSkin.Controls.MaterialLabel materialLabel9;
    }
}
