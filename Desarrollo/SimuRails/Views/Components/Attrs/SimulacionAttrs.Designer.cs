﻿namespace SimuRails.Views.Components.Attrs
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
            ((System.ComponentModel.ISupportInitialize)(this.BindingSourceSimulacion)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BindingSourceTraza)).BeginInit();
            this.SuspendLayout();
            // 
            // nombreField
            // 
            this.nombreField.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.BindingSourceSimulacion, "Nombre", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.nombreField.Depth = 0;
            this.nombreField.Hint = "";
            this.nombreField.Location = new System.Drawing.Point(21, 42);
            this.nombreField.MouseState = MaterialSkin.MouseState.HOVER;
            this.nombreField.Name = "nombreField";
            this.nombreField.PasswordChar = '\0';
            this.nombreField.SelectedText = "";
            this.nombreField.SelectionLength = 0;
            this.nombreField.SelectionStart = 0;
            this.nombreField.Size = new System.Drawing.Size(270, 23);
            this.nombreField.TabIndex = 0;
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
            this.materialLabel1.Location = new System.Drawing.Point(17, 78);
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
            this.duracionField.Hint = "minutos";
            this.duracionField.Location = new System.Drawing.Point(313, 42);
            this.duracionField.MouseState = MaterialSkin.MouseState.HOVER;
            this.duracionField.Name = "duracionField";
            this.duracionField.PasswordChar = '\0';
            this.duracionField.SelectedText = "";
            this.duracionField.SelectionLength = 0;
            this.duracionField.SelectionStart = 0;
            this.duracionField.Size = new System.Drawing.Size(148, 23);
            this.duracionField.TabIndex = 1;
            this.duracionField.UseSystemPasswordChar = false;
            // 
            // materialLabel5
            // 
            this.materialLabel5.AutoSize = true;
            this.materialLabel5.Depth = 0;
            this.materialLabel5.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel5.Location = new System.Drawing.Point(309, 20);
            this.materialLabel5.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel5.Name = "materialLabel5";
            this.materialLabel5.Size = new System.Drawing.Size(69, 19);
            this.materialLabel5.TabIndex = 20;
            this.materialLabel5.Text = "Duracion";
            // 
            // materialLabel7
            // 
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
            this.ComboBoxTraza.Location = new System.Drawing.Point(21, 105);
            this.ComboBoxTraza.Name = "ComboBoxTraza";
            this.ComboBoxTraza.Size = new System.Drawing.Size(270, 25);
            this.ComboBoxTraza.TabIndex = 23;
            // 
            // SimulacionAttrs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
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
    }
}
