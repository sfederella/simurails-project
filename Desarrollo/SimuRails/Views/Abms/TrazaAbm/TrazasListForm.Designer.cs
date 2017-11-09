namespace SimuRails.Views.Abms
{
    partial class TrazasListForm
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
            this.materialRaisedButton1 = new MaterialSkin.Controls.MaterialRaisedButton();
            this.label1 = new System.Windows.Forms.Label();
            this.listPanel = new System.Windows.Forms.Panel();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.seleccion = new MaterialSkin.Controls.MaterialLabel();
            this.ImportarButton = new MaterialSkin.Controls.MaterialRaisedButton();
            this.materialRaisedButtonLimpiar = new MaterialSkin.Controls.MaterialRaisedButton();
            this.listPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // materialRaisedButton1
            // 
            this.materialRaisedButton1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.materialRaisedButton1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialRaisedButton1.Depth = 0;
            this.materialRaisedButton1.Icon = null;
            this.materialRaisedButton1.Location = new System.Drawing.Point(879, 461);
            this.materialRaisedButton1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialRaisedButton1.Name = "materialRaisedButton1";
            this.materialRaisedButton1.Primary = true;
            this.materialRaisedButton1.Size = new System.Drawing.Size(105, 30);
            this.materialRaisedButton1.TabIndex = 22;
            this.materialRaisedButton1.Text = "Crear";
            this.materialRaisedButton1.UseVisualStyleBackColor = true;
            this.materialRaisedButton1.Click += new System.EventHandler(this.materialRaisedButton1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(65, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 26);
            this.label1.TabIndex = 21;
            this.label1.Text = "Trazas";
            // 
            // listPanel
            // 
            this.listPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listPanel.AutoSize = true;
            this.listPanel.Controls.Add(this.materialLabel1);
            this.listPanel.Controls.Add(this.seleccion);
            this.listPanel.Location = new System.Drawing.Point(70, 64);
            this.listPanel.Name = "listPanel";
            this.listPanel.Size = new System.Drawing.Size(914, 361);
            this.listPanel.TabIndex = 20;
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel1.Location = new System.Drawing.Point(270, 0);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(153, 19);
            this.materialLabel1.TabIndex = 12;
            this.materialLabel1.Text = "Cantidad de servicios";
            // 
            // seleccion
            // 
            this.seleccion.AutoSize = true;
            this.seleccion.Depth = 0;
            this.seleccion.Font = new System.Drawing.Font("Roboto", 11F);
            this.seleccion.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.seleccion.Location = new System.Drawing.Point(14, 0);
            this.seleccion.MouseState = MaterialSkin.MouseState.HOVER;
            this.seleccion.Name = "seleccion";
            this.seleccion.Size = new System.Drawing.Size(63, 19);
            this.seleccion.TabIndex = 10;
            this.seleccion.Text = "Nombre";
            // 
            // ImportarButton
            // 
            this.ImportarButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.ImportarButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ImportarButton.Depth = 0;
            this.ImportarButton.Icon = null;
            this.ImportarButton.Location = new System.Drawing.Point(768, 461);
            this.ImportarButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.ImportarButton.Name = "ImportarButton";
            this.ImportarButton.Primary = true;
            this.ImportarButton.Size = new System.Drawing.Size(105, 30);
            this.ImportarButton.TabIndex = 23;
            this.ImportarButton.Text = "Importar";
            this.ImportarButton.UseVisualStyleBackColor = true;
            this.ImportarButton.Click += new System.EventHandler(this.ImportarButton_Click);
            // 
            // materialRaisedButtonLimpiar
            // 
            this.materialRaisedButtonLimpiar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.materialRaisedButtonLimpiar.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialRaisedButtonLimpiar.Depth = 0;
            this.materialRaisedButtonLimpiar.Icon = null;
            this.materialRaisedButtonLimpiar.Location = new System.Drawing.Point(70, 461);
            this.materialRaisedButtonLimpiar.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialRaisedButtonLimpiar.Name = "materialRaisedButtonLimpiar";
            this.materialRaisedButtonLimpiar.Primary = true;
            this.materialRaisedButtonLimpiar.Size = new System.Drawing.Size(120, 30);
            this.materialRaisedButtonLimpiar.TabIndex = 24;
            this.materialRaisedButtonLimpiar.Text = "LIMPIAR TODO";
            this.materialRaisedButtonLimpiar.UseVisualStyleBackColor = true;
            this.materialRaisedButtonLimpiar.Click += new System.EventHandler(this.materialRaisedButtonLimpiar_Click);
            // 
            // TrazasListForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(1049, 503);
            this.Controls.Add(this.materialRaisedButtonLimpiar);
            this.Controls.Add(this.ImportarButton);
            this.Controls.Add(this.materialRaisedButton1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listPanel);
            this.Name = "TrazasListForm";
            this.Text = "TrazasListForm";
            this.Load += new System.EventHandler(this.TrazasListForm_Load_1);
            this.listPanel.ResumeLayout(false);
            this.listPanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialRaisedButton materialRaisedButton1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel listPanel;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private MaterialSkin.Controls.MaterialLabel seleccion;
        private MaterialSkin.Controls.MaterialRaisedButton ImportarButton;
        private MaterialSkin.Controls.MaterialRaisedButton materialRaisedButtonLimpiar;
    }
}