namespace SimuRails.Views.Components.Attrs
{
    partial class TrazaAttrs
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
            this.BindingSourceTraza = new System.Windows.Forms.BindingSource(this.components);
            this.materialDivider1 = new MaterialSkin.Controls.MaterialDivider();
            this.materialLabel7 = new MaterialSkin.Controls.MaterialLabel();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.BindingSourceServiciosDisponibles = new System.Windows.Forms.BindingSource(this.components);
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            this.ButtonAsignar = new MaterialSkin.Controls.MaterialRaisedButton();
            this.ButtonDesasignar = new MaterialSkin.Controls.MaterialRaisedButton();
            this.ListBoxAsignados = new System.Windows.Forms.ListBox();
            this.BindingSourceServiciosAsignados = new System.Windows.Forms.BindingSource(this.components);
            this.errorNombreLbl = new System.Windows.Forms.Label();
            this.errorServiciosLbl = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.BindingSourceTraza)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BindingSourceServiciosDisponibles)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BindingSourceServiciosAsignados)).BeginInit();
            this.SuspendLayout();
            // 
            // nombreField
            // 
            this.nombreField.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.nombreField.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.BindingSourceTraza, "Nombre", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.nombreField.Depth = 0;
            this.nombreField.Hint = "";
            this.nombreField.IsNumeric = false;
            this.nombreField.Location = new System.Drawing.Point(21, 42);
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
            // BindingSourceTraza
            // 
            this.BindingSourceTraza.DataSource = typeof(SimuRails.Models.Traza);
            // 
            // materialDivider1
            // 
            this.materialDivider1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.materialDivider1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialDivider1.Depth = 0;
            this.materialDivider1.Location = new System.Drawing.Point(2, 102);
            this.materialDivider1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialDivider1.Name = "materialDivider1";
            this.materialDivider1.Size = new System.Drawing.Size(787, 2);
            this.materialDivider1.TabIndex = 16;
            this.materialDivider1.Text = "materialDivider1";
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
            this.materialLabel7.Size = new System.Drawing.Size(63, 19);
            this.materialLabel7.TabIndex = 22;
            this.materialLabel7.Text = "Nombre";
            // 
            // listBox1
            // 
            this.listBox1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.listBox1.DataSource = this.BindingSourceServiciosDisponibles;
            this.listBox1.DisplayMember = "Nombre";
            this.listBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 18;
            this.listBox1.Location = new System.Drawing.Point(58, 156);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(272, 202);
            this.listBox1.TabIndex = 23;
            this.listBox1.ValueMember = "Id";
            // 
            // BindingSourceServiciosDisponibles
            // 
            this.BindingSourceServiciosDisponibles.DataSource = typeof(SimuRails.Models.Servicio);
            // 
            // materialLabel1
            // 
            this.materialLabel1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel1.Location = new System.Drawing.Point(54, 134);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(154, 19);
            this.materialLabel1.TabIndex = 24;
            this.materialLabel1.Text = "Servicios Disponibles";
            // 
            // materialLabel2
            // 
            this.materialLabel2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.materialLabel2.AutoSize = true;
            this.materialLabel2.Depth = 0;
            this.materialLabel2.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel2.Location = new System.Drawing.Point(402, 134);
            this.materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel2.Name = "materialLabel2";
            this.materialLabel2.Size = new System.Drawing.Size(146, 19);
            this.materialLabel2.TabIndex = 25;
            this.materialLabel2.Text = "Servicios Asignados";
            // 
            // ButtonAsignar
            // 
            this.ButtonAsignar.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.ButtonAsignar.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ButtonAsignar.Depth = 0;
            this.ButtonAsignar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonAsignar.Icon = null;
            this.ButtonAsignar.Location = new System.Drawing.Point(336, 210);
            this.ButtonAsignar.MouseState = MaterialSkin.MouseState.HOVER;
            this.ButtonAsignar.Name = "ButtonAsignar";
            this.ButtonAsignar.Primary = true;
            this.ButtonAsignar.Size = new System.Drawing.Size(62, 23);
            this.ButtonAsignar.TabIndex = 1;
            this.ButtonAsignar.Text = ">";
            this.ButtonAsignar.UseVisualStyleBackColor = true;
            this.ButtonAsignar.Click += new System.EventHandler(this.ButtonAsignar_Click);
            // 
            // ButtonDesasignar
            // 
            this.ButtonDesasignar.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.ButtonDesasignar.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ButtonDesasignar.Depth = 0;
            this.ButtonDesasignar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonDesasignar.Icon = null;
            this.ButtonDesasignar.Location = new System.Drawing.Point(336, 266);
            this.ButtonDesasignar.MouseState = MaterialSkin.MouseState.HOVER;
            this.ButtonDesasignar.Name = "ButtonDesasignar";
            this.ButtonDesasignar.Primary = true;
            this.ButtonDesasignar.Size = new System.Drawing.Size(62, 23);
            this.ButtonDesasignar.TabIndex = 2;
            this.ButtonDesasignar.Text = "<";
            this.ButtonDesasignar.UseVisualStyleBackColor = true;
            this.ButtonDesasignar.Click += new System.EventHandler(this.ButtonDesasignar_Click);
            // 
            // ListBoxAsignados
            // 
            this.ListBoxAsignados.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.ListBoxAsignados.DataSource = this.BindingSourceServiciosAsignados;
            this.ListBoxAsignados.DisplayMember = "Valor";
            this.ListBoxAsignados.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ListBoxAsignados.FormattingEnabled = true;
            this.ListBoxAsignados.ItemHeight = 18;
            this.ListBoxAsignados.Location = new System.Drawing.Point(406, 156);
            this.ListBoxAsignados.Name = "ListBoxAsignados";
            this.ListBoxAsignados.Size = new System.Drawing.Size(278, 202);
            this.ListBoxAsignados.TabIndex = 28;
            this.ListBoxAsignados.ValueMember = "Clave";
            // 
            // BindingSourceServiciosAsignados
            // 
            this.BindingSourceServiciosAsignados.DataSource = typeof(SimuRails.KeyValue);
            // 
            // errorNombreLbl
            // 
            this.errorNombreLbl.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.errorNombreLbl.AutoSize = true;
            this.errorNombreLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.errorNombreLbl.ForeColor = System.Drawing.Color.DarkRed;
            this.errorNombreLbl.Location = new System.Drawing.Point(18, 68);
            this.errorNombreLbl.Name = "errorNombreLbl";
            this.errorNombreLbl.Size = new System.Drawing.Size(167, 15);
            this.errorNombreLbl.TabIndex = 51;
            this.errorNombreLbl.Text = "Este campo es requerido";
            this.errorNombreLbl.Visible = false;
            // 
            // errorServiciosLbl
            // 
            this.errorServiciosLbl.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.errorServiciosLbl.AutoSize = true;
            this.errorServiciosLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.errorServiciosLbl.ForeColor = System.Drawing.Color.DarkRed;
            this.errorServiciosLbl.Location = new System.Drawing.Point(403, 361);
            this.errorServiciosLbl.Name = "errorServiciosLbl";
            this.errorServiciosLbl.Size = new System.Drawing.Size(281, 15);
            this.errorServiciosLbl.TabIndex = 52;
            this.errorServiciosLbl.Text = "Debe haber al menos un servicio asignado";
            this.errorServiciosLbl.Visible = false;
            // 
            // TrazaAttrs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.Controls.Add(this.errorServiciosLbl);
            this.Controls.Add(this.errorNombreLbl);
            this.Controls.Add(this.ListBoxAsignados);
            this.Controls.Add(this.ButtonDesasignar);
            this.Controls.Add(this.ButtonAsignar);
            this.Controls.Add(this.materialLabel2);
            this.Controls.Add(this.materialLabel1);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.materialLabel7);
            this.Controls.Add(this.materialDivider1);
            this.Controls.Add(this.nombreField);
            this.Name = "TrazaAttrs";
            this.Size = new System.Drawing.Size(791, 439);
            this.Load += new System.EventHandler(this.TrazaAttrs_Load);
            ((System.ComponentModel.ISupportInitialize)(this.BindingSourceTraza)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BindingSourceServiciosDisponibles)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BindingSourceServiciosAsignados)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialSingleLineTextField nombreField;
        private MaterialSkin.Controls.MaterialDivider materialDivider1;
        private MaterialSkin.Controls.MaterialLabel materialLabel7;
        private System.Windows.Forms.BindingSource BindingSourceTraza;
        private System.Windows.Forms.ListBox listBox1;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private MaterialSkin.Controls.MaterialLabel materialLabel2;
        private MaterialSkin.Controls.MaterialRaisedButton ButtonAsignar;
        private MaterialSkin.Controls.MaterialRaisedButton ButtonDesasignar;
        private System.Windows.Forms.ListBox ListBoxAsignados;
        private System.Windows.Forms.BindingSource BindingSourceServiciosDisponibles;
        private System.Windows.Forms.BindingSource BindingSourceServiciosAsignados;
        private System.Windows.Forms.Label errorNombreLbl;
        private System.Windows.Forms.Label errorServiciosLbl;
    }
}
