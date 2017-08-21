namespace SimuRails
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
            this.materialContextMenuStrip1 = new MaterialSkin.Controls.MaterialContextMenuStrip();
            this.item1ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.subitem1ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.item2ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mainMaterialTabSelector = new MaterialSkin.Controls.MaterialTabSelector();
            this.mainMaterialTabControl = new MaterialSkin.Controls.MaterialTabControl();
            this.tabSimulacion = new System.Windows.Forms.TabPage();
            this.materialFlatButton2 = new MaterialSkin.Controls.MaterialFlatButton();
            this.materialSingleLineTextField1 = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.materialDivider1 = new MaterialSkin.Controls.MaterialDivider();
            this.materialFlatButton1 = new MaterialSkin.Controls.MaterialFlatButton();
            this.tabCompartir = new System.Windows.Forms.TabPage();
            this.tabTrazas = new System.Windows.Forms.TabPage();
            this.tabServicios = new System.Windows.Forms.TabPage();
            this.tabFormaciones = new System.Windows.Forms.TabPage();
            this.tabCoches = new System.Windows.Forms.TabPage();
            this.tabEstaciones = new System.Windows.Forms.TabPage();
            this.tabIncidentes = new System.Windows.Forms.TabPage();
            this.materialContextMenuStrip1.SuspendLayout();
            this.mainMaterialTabControl.SuspendLayout();
            this.tabSimulacion.SuspendLayout();
            this.SuspendLayout();
            // 
            // materialContextMenuStrip1
            // 
            this.materialContextMenuStrip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.materialContextMenuStrip1.Depth = 0;
            this.materialContextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.item1ToolStripMenuItem,
            this.item2ToolStripMenuItem});
            this.materialContextMenuStrip1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialContextMenuStrip1.Name = "materialContextMenuStrip1";
            this.materialContextMenuStrip1.Size = new System.Drawing.Size(108, 48);
            // 
            // item1ToolStripMenuItem
            // 
            this.item1ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.subitem1ToolStripMenuItem});
            this.item1ToolStripMenuItem.Name = "item1ToolStripMenuItem";
            this.item1ToolStripMenuItem.Size = new System.Drawing.Size(107, 22);
            this.item1ToolStripMenuItem.Text = "Item 1";
            // 
            // subitem1ToolStripMenuItem
            // 
            this.subitem1ToolStripMenuItem.Name = "subitem1ToolStripMenuItem";
            this.subitem1ToolStripMenuItem.Size = new System.Drawing.Size(127, 22);
            this.subitem1ToolStripMenuItem.Text = "Subitem 1";
            // 
            // item2ToolStripMenuItem
            // 
            this.item2ToolStripMenuItem.Name = "item2ToolStripMenuItem";
            this.item2ToolStripMenuItem.Size = new System.Drawing.Size(107, 22);
            this.item2ToolStripMenuItem.Text = "Item2";
            // 
            // mainMaterialTabSelector
            // 
            this.mainMaterialTabSelector.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.mainMaterialTabSelector.BaseTabControl = this.mainMaterialTabControl;
            this.mainMaterialTabSelector.Depth = 0;
            this.mainMaterialTabSelector.Location = new System.Drawing.Point(0, 64);
            this.mainMaterialTabSelector.MouseState = MaterialSkin.MouseState.HOVER;
            this.mainMaterialTabSelector.Name = "mainMaterialTabSelector";
            this.mainMaterialTabSelector.Size = new System.Drawing.Size(1093, 43);
            this.mainMaterialTabSelector.TabIndex = 1;
            this.mainMaterialTabSelector.Text = "mainMaterialTabSelector";
            // 
            // mainMaterialTabControl
            // 
            this.mainMaterialTabControl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.mainMaterialTabControl.Controls.Add(this.tabSimulacion);
            this.mainMaterialTabControl.Controls.Add(this.tabCompartir);
            this.mainMaterialTabControl.Controls.Add(this.tabTrazas);
            this.mainMaterialTabControl.Controls.Add(this.tabServicios);
            this.mainMaterialTabControl.Controls.Add(this.tabFormaciones);
            this.mainMaterialTabControl.Controls.Add(this.tabCoches);
            this.mainMaterialTabControl.Controls.Add(this.tabEstaciones);
            this.mainMaterialTabControl.Controls.Add(this.tabIncidentes);
            this.mainMaterialTabControl.Depth = 0;
            this.mainMaterialTabControl.Location = new System.Drawing.Point(12, 113);
            this.mainMaterialTabControl.MouseState = MaterialSkin.MouseState.HOVER;
            this.mainMaterialTabControl.Name = "mainMaterialTabControl";
            this.mainMaterialTabControl.SelectedIndex = 0;
            this.mainMaterialTabControl.Size = new System.Drawing.Size(1069, 304);
            this.mainMaterialTabControl.TabIndex = 2;
            // 
            // tabSimulacion
            // 
            this.tabSimulacion.BackColor = System.Drawing.Color.White;
            this.tabSimulacion.Controls.Add(this.materialFlatButton2);
            this.tabSimulacion.Controls.Add(this.materialSingleLineTextField1);
            this.tabSimulacion.Controls.Add(this.materialLabel1);
            this.tabSimulacion.Controls.Add(this.materialDivider1);
            this.tabSimulacion.Controls.Add(this.materialFlatButton1);
            this.tabSimulacion.Location = new System.Drawing.Point(4, 22);
            this.tabSimulacion.Name = "tabSimulacion";
            this.tabSimulacion.Padding = new System.Windows.Forms.Padding(3);
            this.tabSimulacion.Size = new System.Drawing.Size(1061, 278);
            this.tabSimulacion.TabIndex = 0;
            this.tabSimulacion.Text = "Simulación";
            // 
            // materialFlatButton2
            // 
            this.materialFlatButton2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.materialFlatButton2.AutoSize = true;
            this.materialFlatButton2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialFlatButton2.Depth = 0;
            this.materialFlatButton2.Location = new System.Drawing.Point(887, 236);
            this.materialFlatButton2.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.materialFlatButton2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialFlatButton2.Name = "materialFlatButton2";
            this.materialFlatButton2.Primary = false;
            this.materialFlatButton2.Size = new System.Drawing.Size(82, 36);
            this.materialFlatButton2.TabIndex = 6;
            this.materialFlatButton2.Text = "Cancelar";
            this.materialFlatButton2.UseVisualStyleBackColor = true;
            // 
            // materialSingleLineTextField1
            // 
            this.materialSingleLineTextField1.Depth = 0;
            this.materialSingleLineTextField1.Hint = "Segundos";
            this.materialSingleLineTextField1.Location = new System.Drawing.Point(30, 46);
            this.materialSingleLineTextField1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialSingleLineTextField1.Name = "materialSingleLineTextField1";
            this.materialSingleLineTextField1.PasswordChar = '\0';
            this.materialSingleLineTextField1.SelectedText = "";
            this.materialSingleLineTextField1.SelectionLength = 0;
            this.materialSingleLineTextField1.SelectionStart = 0;
            this.materialSingleLineTextField1.Size = new System.Drawing.Size(225, 23);
            this.materialSingleLineTextField1.TabIndex = 5;
            this.materialSingleLineTextField1.UseSystemPasswordChar = false;
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel1.Location = new System.Drawing.Point(26, 24);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(96, 19);
            this.materialLabel1.TabIndex = 4;
            this.materialLabel1.Text = "Tiempo Final";
            // 
            // materialDivider1
            // 
            this.materialDivider1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.materialDivider1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialDivider1.Depth = 0;
            this.materialDivider1.Location = new System.Drawing.Point(0, 228);
            this.materialDivider1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialDivider1.Name = "materialDivider1";
            this.materialDivider1.Size = new System.Drawing.Size(1065, 1);
            this.materialDivider1.TabIndex = 3;
            this.materialDivider1.Text = "materialDivider1";
            // 
            // materialFlatButton1
            // 
            this.materialFlatButton1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.materialFlatButton1.AutoSize = true;
            this.materialFlatButton1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialFlatButton1.Depth = 0;
            this.materialFlatButton1.Location = new System.Drawing.Point(981, 236);
            this.materialFlatButton1.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.materialFlatButton1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialFlatButton1.Name = "materialFlatButton1";
            this.materialFlatButton1.Primary = false;
            this.materialFlatButton1.Size = new System.Drawing.Size(73, 36);
            this.materialFlatButton1.TabIndex = 2;
            this.materialFlatButton1.Text = "Aceptar";
            this.materialFlatButton1.UseVisualStyleBackColor = true;
            // 
            // tabCompartir
            // 
            this.tabCompartir.Location = new System.Drawing.Point(4, 22);
            this.tabCompartir.Name = "tabCompartir";
            this.tabCompartir.Padding = new System.Windows.Forms.Padding(3);
            this.tabCompartir.Size = new System.Drawing.Size(1061, 278);
            this.tabCompartir.TabIndex = 1;
            this.tabCompartir.Text = "Compartir";
            this.tabCompartir.UseVisualStyleBackColor = true;
            // 
            // tabTrazas
            // 
            this.tabTrazas.Location = new System.Drawing.Point(4, 22);
            this.tabTrazas.Name = "tabTrazas";
            this.tabTrazas.Size = new System.Drawing.Size(1061, 278);
            this.tabTrazas.TabIndex = 2;
            this.tabTrazas.Text = "Trazas";
            this.tabTrazas.UseVisualStyleBackColor = true;
            // 
            // tabServicios
            // 
            this.tabServicios.Location = new System.Drawing.Point(4, 22);
            this.tabServicios.Name = "tabServicios";
            this.tabServicios.Size = new System.Drawing.Size(1061, 278);
            this.tabServicios.TabIndex = 3;
            this.tabServicios.Text = "Servicios";
            this.tabServicios.UseVisualStyleBackColor = true;
            // 
            // tabFormaciones
            // 
            this.tabFormaciones.Location = new System.Drawing.Point(4, 22);
            this.tabFormaciones.Name = "tabFormaciones";
            this.tabFormaciones.Size = new System.Drawing.Size(1061, 278);
            this.tabFormaciones.TabIndex = 4;
            this.tabFormaciones.Text = "Formaciones";
            this.tabFormaciones.UseVisualStyleBackColor = true;
            // 
            // tabCoches
            // 
            this.tabCoches.Location = new System.Drawing.Point(4, 22);
            this.tabCoches.Name = "tabCoches";
            this.tabCoches.Size = new System.Drawing.Size(1061, 278);
            this.tabCoches.TabIndex = 5;
            this.tabCoches.Text = "Coches";
            this.tabCoches.UseVisualStyleBackColor = true;
            // 
            // tabEstaciones
            // 
            this.tabEstaciones.Location = new System.Drawing.Point(4, 22);
            this.tabEstaciones.Name = "tabEstaciones";
            this.tabEstaciones.Size = new System.Drawing.Size(1061, 278);
            this.tabEstaciones.TabIndex = 6;
            this.tabEstaciones.Text = "Estaciones";
            this.tabEstaciones.UseVisualStyleBackColor = true;
            // 
            // tabIncidentes
            // 
            this.tabIncidentes.Location = new System.Drawing.Point(4, 22);
            this.tabIncidentes.Name = "tabIncidentes";
            this.tabIncidentes.Size = new System.Drawing.Size(1061, 278);
            this.tabIncidentes.TabIndex = 7;
            this.tabIncidentes.Text = "Incidentes";
            this.tabIncidentes.UseVisualStyleBackColor = true;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1093, 429);
            this.ContextMenuStrip = this.materialContextMenuStrip1;
            this.Controls.Add(this.mainMaterialTabControl);
            this.Controls.Add(this.mainMaterialTabSelector);
            this.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.Name = "MainForm";
            this.Text = "SimuRails";
            this.materialContextMenuStrip1.ResumeLayout(false);
            this.mainMaterialTabControl.ResumeLayout(false);
            this.tabSimulacion.ResumeLayout(false);
            this.tabSimulacion.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private MaterialSkin.Controls.MaterialContextMenuStrip materialContextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem item1ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem subitem1ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem item2ToolStripMenuItem;
        private MaterialSkin.Controls.MaterialTabSelector mainMaterialTabSelector;
        private MaterialSkin.Controls.MaterialTabControl mainMaterialTabControl;
        private System.Windows.Forms.TabPage tabSimulacion;
        private System.Windows.Forms.TabPage tabCompartir;
        private System.Windows.Forms.TabPage tabTrazas;
        private System.Windows.Forms.TabPage tabServicios;
        private System.Windows.Forms.TabPage tabFormaciones;
        private System.Windows.Forms.TabPage tabCoches;
        private System.Windows.Forms.TabPage tabEstaciones;
        private System.Windows.Forms.TabPage tabIncidentes;
        private MaterialSkin.Controls.MaterialSingleLineTextField materialSingleLineTextField1;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private MaterialSkin.Controls.MaterialDivider materialDivider1;
        private MaterialSkin.Controls.MaterialFlatButton materialFlatButton1;
        private MaterialSkin.Controls.MaterialFlatButton materialFlatButton2;
    }
}