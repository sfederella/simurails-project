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
            this.materialContextMenuStrip1 = new MaterialSkin.Controls.MaterialContextMenuStrip();
            this.item1ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.subitem1ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.item2ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
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
            this.materialContextMenuStrip1.SuspendLayout();
            this.mainMaterialTabControl.SuspendLayout();
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
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.label2.Image = global::SimuRails.Properties.Resources.signo_de_interrogacion;
            this.label2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label2.Location = new System.Drawing.Point(1097, 38);
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
            this.label1.Image = global::SimuRails.Properties.Resources.usuario_hombre;
            this.label1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label1.Location = new System.Drawing.Point(1127, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(24, 23);
            this.label1.TabIndex = 5;
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.toolTip1.SetToolTip(this.label1, "Sobre nosotros");
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // mainMaterialTabSelector2
            // 
            this.mainMaterialTabSelector2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.mainMaterialTabSelector2.BackColor = System.Drawing.SystemColors.Control;
            this.mainMaterialTabSelector2.BaseTabControl = this.mainMaterialTabControl;
            this.mainMaterialTabSelector2.Depth = 0;
            this.mainMaterialTabSelector2.Location = new System.Drawing.Point(168, 58);
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
            this.tabTrazas.Size = new System.Drawing.Size(1161, 658);
            this.tabTrazas.TabIndex = 1;
            this.tabTrazas.Text = "Trazas";
            this.tabTrazas.UseVisualStyleBackColor = true;
            // 
            // tabServicios
            // 
            this.tabServicios.Location = new System.Drawing.Point(4, 22);
            this.tabServicios.Name = "tabServicios";
            this.tabServicios.Size = new System.Drawing.Size(1161, 658);
            this.tabServicios.TabIndex = 2;
            this.tabServicios.Text = "Servicios";
            this.tabServicios.UseVisualStyleBackColor = true;
            // 
            // tabFormaciones
            // 
            this.tabFormaciones.Location = new System.Drawing.Point(4, 22);
            this.tabFormaciones.Name = "tabFormaciones";
            this.tabFormaciones.Size = new System.Drawing.Size(1161, 658);
            this.tabFormaciones.TabIndex = 3;
            this.tabFormaciones.Text = "Formaciones";
            this.tabFormaciones.UseVisualStyleBackColor = true;
            // 
            // tabCoches
            // 
            this.tabCoches.Location = new System.Drawing.Point(4, 22);
            this.tabCoches.Name = "tabCoches";
            this.tabCoches.Size = new System.Drawing.Size(1161, 658);
            this.tabCoches.TabIndex = 4;
            this.tabCoches.Text = "Coches";
            this.tabCoches.UseVisualStyleBackColor = true;
            // 
            // tabEstaciones
            // 
            this.tabEstaciones.Location = new System.Drawing.Point(4, 22);
            this.tabEstaciones.Name = "tabEstaciones";
            this.tabEstaciones.Size = new System.Drawing.Size(1161, 658);
            this.tabEstaciones.TabIndex = 5;
            this.tabEstaciones.Text = "Estaciones";
            this.tabEstaciones.UseVisualStyleBackColor = true;
            // 
            // tabIncidentes
            // 
            this.tabIncidentes.Location = new System.Drawing.Point(4, 22);
            this.tabIncidentes.Name = "tabIncidentes";
            this.tabIncidentes.Size = new System.Drawing.Size(1161, 658);
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
            this.ContextMenuStrip = this.materialContextMenuStrip1;
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
            this.materialContextMenuStrip1.ResumeLayout(false);
            this.mainMaterialTabControl.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private MaterialSkin.Controls.MaterialContextMenuStrip materialContextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem item1ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem subitem1ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem item2ToolStripMenuItem;
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