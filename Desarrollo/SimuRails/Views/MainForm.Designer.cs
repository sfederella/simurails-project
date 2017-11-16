namespace SimuRails.Views
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.mainMaterialTabSelector2 = new MaterialSkin.Controls.MaterialTabSelector();
            this.mainMaterialTabControl = new MaterialSkin.Controls.MaterialTabControl();
            this.tabSimulacion = new System.Windows.Forms.TabPage();
            this.tabTrazas = new System.Windows.Forms.TabPage();
            this.tabServicios = new System.Windows.Forms.TabPage();
            this.tabFormaciones = new System.Windows.Forms.TabPage();
            this.tabCoches = new System.Windows.Forms.TabPage();
            this.tabEstaciones = new System.Windows.Forms.TabPage();
            this.tabIncidentes = new System.Windows.Forms.TabPage();
            this.materialTabSelector = new MaterialSkin.Controls.MaterialTabSelector();
            this.mainMaterialTabControl.SuspendLayout();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.label2.Image = global::SimuRails.Properties.Resources.ic_help_white_18dp;
            this.label2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label2.Location = new System.Drawing.Point(1102, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(24, 23);
            this.label2.TabIndex = 6;
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.toolTip1.SetToolTip(this.label2, "Ayuda");
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.label1.Image = global::SimuRails.Properties.Resources.ic_info_white_18pt;
            this.label1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label1.Location = new System.Drawing.Point(1128, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(24, 23);
            this.label1.TabIndex = 5;
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.toolTip1.SetToolTip(this.label1, "Información");
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // mainMaterialTabSelector2
            // 
            this.mainMaterialTabSelector2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.mainMaterialTabSelector2.BackColor = System.Drawing.SystemColors.Control;
            this.mainMaterialTabSelector2.BaseTabControl = this.mainMaterialTabControl;
            this.mainMaterialTabSelector2.Depth = 0;
            this.mainMaterialTabSelector2.Location = new System.Drawing.Point(168, 60);
            this.mainMaterialTabSelector2.MouseState = MaterialSkin.MouseState.HOVER;
            this.mainMaterialTabSelector2.Name = "mainMaterialTabSelector2";
            this.mainMaterialTabSelector2.Size = new System.Drawing.Size(807, 38);
            this.mainMaterialTabSelector2.TabIndex = 1;
            this.mainMaterialTabSelector2.Text = "mainMaterialTabSelector";
            // 
            // mainMaterialTabControl
            // 
            this.mainMaterialTabControl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.mainMaterialTabControl.Controls.Add(this.tabSimulacion);
            this.mainMaterialTabControl.Controls.Add(this.tabTrazas);
            this.mainMaterialTabControl.Controls.Add(this.tabServicios);
            this.mainMaterialTabControl.Controls.Add(this.tabFormaciones);
            this.mainMaterialTabControl.Controls.Add(this.tabCoches);
            this.mainMaterialTabControl.Controls.Add(this.tabEstaciones);
            this.mainMaterialTabControl.Controls.Add(this.tabIncidentes);
            this.mainMaterialTabControl.Depth = 0;
            this.mainMaterialTabControl.Location = new System.Drawing.Point(-3, 99);
            this.mainMaterialTabControl.Margin = new System.Windows.Forms.Padding(0);
            this.mainMaterialTabControl.MouseState = MaterialSkin.MouseState.HOVER;
            this.mainMaterialTabControl.Name = "mainMaterialTabControl";
            this.mainMaterialTabControl.Padding = new System.Drawing.Point(0, 0);
            this.mainMaterialTabControl.SelectedIndex = 0;
            this.mainMaterialTabControl.Size = new System.Drawing.Size(1169, 452);
            this.mainMaterialTabControl.TabIndex = 2;
            // 
            // tabSimulacion
            // 
            this.tabSimulacion.Location = new System.Drawing.Point(4, 22);
            this.tabSimulacion.Name = "tabSimulacion";
            this.tabSimulacion.Padding = new System.Windows.Forms.Padding(3);
            this.tabSimulacion.Size = new System.Drawing.Size(1161, 426);
            this.tabSimulacion.TabIndex = 0;
            this.tabSimulacion.Text = "Simulación";
            this.tabSimulacion.UseVisualStyleBackColor = true;
            // 
            // tabTrazas
            // 
            this.tabTrazas.Location = new System.Drawing.Point(4, 22);
            this.tabTrazas.Name = "tabTrazas";
            this.tabTrazas.Padding = new System.Windows.Forms.Padding(3);
            this.tabTrazas.Size = new System.Drawing.Size(1161, 426);
            this.tabTrazas.TabIndex = 1;
            this.tabTrazas.Text = "Trazas";
            this.tabTrazas.UseVisualStyleBackColor = true;
            // 
            // tabServicios
            // 
            this.tabServicios.Location = new System.Drawing.Point(4, 22);
            this.tabServicios.Name = "tabServicios";
            this.tabServicios.Size = new System.Drawing.Size(1161, 426);
            this.tabServicios.TabIndex = 2;
            this.tabServicios.Text = "Servicios";
            this.tabServicios.UseVisualStyleBackColor = true;
            // 
            // tabFormaciones
            // 
            this.tabFormaciones.Location = new System.Drawing.Point(4, 22);
            this.tabFormaciones.Name = "tabFormaciones";
            this.tabFormaciones.Size = new System.Drawing.Size(1161, 426);
            this.tabFormaciones.TabIndex = 3;
            this.tabFormaciones.Text = "Formaciones";
            this.tabFormaciones.UseVisualStyleBackColor = true;
            // 
            // tabCoches
            // 
            this.tabCoches.Location = new System.Drawing.Point(4, 22);
            this.tabCoches.Name = "tabCoches";
            this.tabCoches.Size = new System.Drawing.Size(1161, 426);
            this.tabCoches.TabIndex = 4;
            this.tabCoches.Text = "Coches";
            this.tabCoches.UseVisualStyleBackColor = true;
            // 
            // tabEstaciones
            // 
            this.tabEstaciones.Location = new System.Drawing.Point(4, 22);
            this.tabEstaciones.Name = "tabEstaciones";
            this.tabEstaciones.Size = new System.Drawing.Size(1161, 426);
            this.tabEstaciones.TabIndex = 5;
            this.tabEstaciones.Text = "Estaciones";
            this.tabEstaciones.UseVisualStyleBackColor = true;
            // 
            // tabIncidentes
            // 
            this.tabIncidentes.Location = new System.Drawing.Point(4, 22);
            this.tabIncidentes.Name = "tabIncidentes";
            this.tabIncidentes.Size = new System.Drawing.Size(1161, 426);
            this.tabIncidentes.TabIndex = 6;
            this.tabIncidentes.Text = "Incidentes";
            this.tabIncidentes.UseVisualStyleBackColor = true;
            // 
            // materialTabSelector
            // 
            this.materialTabSelector.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.materialTabSelector.BaseTabControl = null;
            this.materialTabSelector.Depth = 0;
            this.materialTabSelector.Location = new System.Drawing.Point(-3, 64);
            this.materialTabSelector.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialTabSelector.Name = "materialTabSelector";
            this.materialTabSelector.Size = new System.Drawing.Size(1169, 38);
            this.materialTabSelector.TabIndex = 3;
            this.materialTabSelector.Text = "materialTabSelector1";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1163, 548);
            this.Controls.Add(this.mainMaterialTabControl);
            this.Controls.Add(this.mainMaterialTabSelector2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.materialTabSelector);
            this.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SimuRails";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.mainMaterialTabControl.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Label label2;
        private MaterialSkin.Controls.MaterialTabSelector mainMaterialTabSelector2;
        private MaterialSkin.Controls.MaterialTabControl mainMaterialTabControl;
        private System.Windows.Forms.TabPage tabSimulacion;
        private System.Windows.Forms.TabPage tabTrazas;
        private System.Windows.Forms.TabPage tabServicios;
        private System.Windows.Forms.TabPage tabFormaciones;
        private System.Windows.Forms.TabPage tabCoches;
        private System.Windows.Forms.TabPage tabEstaciones;
        private System.Windows.Forms.TabPage tabIncidentes;
        private MaterialSkin.Controls.MaterialTabSelector materialTabSelector;
    }
}