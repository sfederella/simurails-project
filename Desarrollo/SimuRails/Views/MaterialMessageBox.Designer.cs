namespace SimuRails.Views
{
    partial class MaterialMessageBox
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
            this.label = new MaterialSkin.Controls.MaterialLabel();
            this.aceptarBtn = new MaterialSkin.Controls.MaterialFlatButton();
            this.SuspendLayout();
            // 
            // label
            // 
            this.label.BackColor = System.Drawing.Color.White;
            this.label.Depth = 0;
            this.label.Font = new System.Drawing.Font("Roboto", 11F);
            this.label.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label.Location = new System.Drawing.Point(12, 77);
            this.label.MouseState = MaterialSkin.MouseState.HOVER;
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(440, 74);
            this.label.TabIndex = 0;
            this.label.Text = "Label";
            this.label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // aceptarBtn
            // 
            this.aceptarBtn.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.aceptarBtn.Depth = 0;
            this.aceptarBtn.Icon = null;
            this.aceptarBtn.Location = new System.Drawing.Point(356, 157);
            this.aceptarBtn.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.aceptarBtn.MouseState = MaterialSkin.MouseState.HOVER;
            this.aceptarBtn.Name = "aceptarBtn";
            this.aceptarBtn.Primary = false;
            this.aceptarBtn.Size = new System.Drawing.Size(96, 33);
            this.aceptarBtn.TabIndex = 1;
            this.aceptarBtn.Text = "Aceptar";
            this.aceptarBtn.UseVisualStyleBackColor = true;
            this.aceptarBtn.Click += new System.EventHandler(this.AceptarBtn_Click);
            // 
            // MaterialMessageBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(464, 205);
            this.Controls.Add(this.aceptarBtn);
            this.Controls.Add(this.label);
            this.Name = "MaterialMessageBox";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Alerta";
            this.ResumeLayout(false);

        }

        #endregion

        private MaterialSkin.Controls.MaterialLabel label;
        private MaterialSkin.Controls.MaterialFlatButton aceptarBtn;
    }
}