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
            this.bindingSourceFormacion = new System.Windows.Forms.BindingSource(this.components);
            this.consumoAndandoField = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.modeloField = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.materialSingleLineTextField1 = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.bindingSourceCocheEditando = new System.Windows.Forms.BindingSource(this.components);
            this.materialLabel3 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel4 = new MaterialSkin.Controls.MaterialLabel();
            this.agregarBtn = new MaterialSkin.Controls.MaterialRaisedButton();
            this.listadoCoches = new SimuRails.Views.Components.MaterialList();
            this.modeloCbo = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceFormacion)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceCocheEditando)).BeginInit();
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
            this.materialLabel7.Size = new System.Drawing.Size(62, 19);
            this.materialLabel7.TabIndex = 41;
            this.materialLabel7.Text = "Nombre";
            // 
            // materialLabel6
            // 
            this.materialLabel6.AutoSize = true;
            this.materialLabel6.Depth = 0;
            this.materialLabel6.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel6.Location = new System.Drawing.Point(581, 46);
            this.materialLabel6.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel6.Name = "materialLabel6";
            this.materialLabel6.Size = new System.Drawing.Size(68, 19);
            this.materialLabel6.TabIndex = 40;
            this.materialLabel6.Text = "Duración";
            // 
            // materialLabel5
            // 
            this.materialLabel5.AutoSize = true;
            this.materialLabel5.Depth = 0;
            this.materialLabel5.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel5.Location = new System.Drawing.Point(353, 46);
            this.materialLabel5.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel5.Name = "materialLabel5";
            this.materialLabel5.Size = new System.Drawing.Size(63, 19);
            this.materialLabel5.TabIndex = 39;
            this.materialLabel5.Text = "Vida útil";
            // 
            // materialLabel2
            // 
            this.materialLabel2.AutoSize = true;
            this.materialLabel2.Depth = 0;
            this.materialLabel2.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel2.Location = new System.Drawing.Point(19, 139);
            this.materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel2.Name = "materialLabel2";
            this.materialLabel2.Size = new System.Drawing.Size(59, 19);
            this.materialLabel2.TabIndex = 36;
            this.materialLabel2.Text = "Coches";
            // 
            // materialDivider1
            // 
            this.materialDivider1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.materialDivider1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialDivider1.Depth = 0;
            this.materialDivider1.Location = new System.Drawing.Point(4, 119);
            this.materialDivider1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialDivider1.Name = "materialDivider1";
            this.materialDivider1.Size = new System.Drawing.Size(867, 2);
            this.materialDivider1.TabIndex = 35;
            this.materialDivider1.Text = "materialDivider1";
            // 
            // consumoParadoField
            // 
            this.consumoParadoField.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bindingSourceFormacion, "DuracionMantenimiento", true));
            this.consumoParadoField.Depth = 0;
            this.consumoParadoField.Hint = "Min";
            this.consumoParadoField.Location = new System.Drawing.Point(585, 68);
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
            // bindingSourceFormacion
            // 
            this.bindingSourceFormacion.DataSource = typeof(SimuRails.Models.Formacion);
            // 
            // consumoAndandoField
            // 
            this.consumoAndandoField.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bindingSourceFormacion, "KilometrosMantenimiento", true));
            this.consumoAndandoField.Depth = 0;
            this.consumoAndandoField.Hint = "Kms";
            this.consumoAndandoField.Location = new System.Drawing.Point(357, 68);
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
            this.materialLabel1.Location = new System.Drawing.Point(326, 20);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(109, 19);
            this.materialLabel1.TabIndex = 34;
            this.materialLabel1.Text = "Mantenimiento";
            // 
            // modeloField
            // 
            this.modeloField.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bindingSourceFormacion, "Nombre", true));
            this.modeloField.Depth = 0;
            this.modeloField.Hint = "";
            this.modeloField.Location = new System.Drawing.Point(20, 68);
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
            // materialSingleLineTextField1
            // 
            this.materialSingleLineTextField1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bindingSourceCocheEditando, "Cantidad", true));
            this.materialSingleLineTextField1.Depth = 0;
            this.materialSingleLineTextField1.Hint = "";
            this.materialSingleLineTextField1.Location = new System.Drawing.Point(330, 198);
            this.materialSingleLineTextField1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialSingleLineTextField1.Name = "materialSingleLineTextField1";
            this.materialSingleLineTextField1.PasswordChar = '\0';
            this.materialSingleLineTextField1.SelectedText = "";
            this.materialSingleLineTextField1.SelectionLength = 0;
            this.materialSingleLineTextField1.SelectionStart = 0;
            this.materialSingleLineTextField1.Size = new System.Drawing.Size(172, 23);
            this.materialSingleLineTextField1.TabIndex = 43;
            this.materialSingleLineTextField1.UseSystemPasswordChar = false;
            // 
            // bindingSourceCocheEditando
            // 
            this.bindingSourceCocheEditando.DataSource = typeof(SimuRails.Models.AgrupacionCoche);
            // 
            // materialLabel3
            // 
            this.materialLabel3.AutoSize = true;
            this.materialLabel3.Depth = 0;
            this.materialLabel3.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel3.Location = new System.Drawing.Point(326, 167);
            this.materialLabel3.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel3.Name = "materialLabel3";
            this.materialLabel3.Size = new System.Drawing.Size(67, 19);
            this.materialLabel3.TabIndex = 44;
            this.materialLabel3.Text = "Cantidad";
            // 
            // materialLabel4
            // 
            this.materialLabel4.AutoSize = true;
            this.materialLabel4.Depth = 0;
            this.materialLabel4.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel4.Location = new System.Drawing.Point(37, 167);
            this.materialLabel4.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel4.Name = "materialLabel4";
            this.materialLabel4.Size = new System.Drawing.Size(59, 19);
            this.materialLabel4.TabIndex = 45;
            this.materialLabel4.Text = "Modelo";
            // 
            // agregarBtn
            // 
            this.agregarBtn.Depth = 0;
            this.agregarBtn.Location = new System.Drawing.Point(646, 194);
            this.agregarBtn.MouseState = MaterialSkin.MouseState.HOVER;
            this.agregarBtn.Name = "agregarBtn";
            this.agregarBtn.Primary = true;
            this.agregarBtn.Size = new System.Drawing.Size(107, 27);
            this.agregarBtn.TabIndex = 47;
            this.agregarBtn.Text = "Agregar";
            this.agregarBtn.UseVisualStyleBackColor = true;
            this.agregarBtn.Click += new System.EventHandler(this.agregarBtn_Click);
            // 
            // listadoCoches
            // 
            this.listadoCoches.BackColor = System.Drawing.SystemColors.Window;
            this.listadoCoches.Location = new System.Drawing.Point(22, 236);
            this.listadoCoches.Name = "listadoCoches";
            this.listadoCoches.Size = new System.Drawing.Size(752, 176);
            this.listadoCoches.TabIndex = 46;
            // 
            // modelosCbo
            // 
            this.modeloCbo.DataBindings.Add(new System.Windows.Forms.Binding("SelectedItem", this.bindingSourceCocheEditando, "Coche", true));
            this.modeloCbo.FormattingEnabled = true;
            this.modeloCbo.Location = new System.Drawing.Point(41, 198);
            this.modeloCbo.Name = "modelosCbo";
            this.modeloCbo.Size = new System.Drawing.Size(165, 21);
            this.modeloCbo.TabIndex = 48;
            // 
            // FormacionAttr
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.Controls.Add(this.modeloCbo);
            this.Controls.Add(this.agregarBtn);
            this.Controls.Add(this.listadoCoches);
            this.Controls.Add(this.materialLabel4);
            this.Controls.Add(this.materialLabel3);
            this.Controls.Add(this.materialSingleLineTextField1);
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
            this.Size = new System.Drawing.Size(871, 430);
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
        private MaterialSkin.Controls.MaterialSingleLineTextField consumoParadoField;
        private MaterialSkin.Controls.MaterialSingleLineTextField consumoAndandoField;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private MaterialSkin.Controls.MaterialSingleLineTextField modeloField;
        private System.Windows.Forms.BindingSource bindingSourceFormacion;
        private MaterialSkin.Controls.MaterialSingleLineTextField materialSingleLineTextField1;
        private MaterialSkin.Controls.MaterialLabel materialLabel3;
        private MaterialSkin.Controls.MaterialLabel materialLabel4;
        private MaterialList listadoCoches;
        private MaterialSkin.Controls.MaterialRaisedButton agregarBtn;
        private System.Windows.Forms.BindingSource bindingSourceCocheEditando;
        private System.Windows.Forms.ComboBox modeloCbo;
    }
}
