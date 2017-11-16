namespace SimuRails.Views
{
    partial class MaterialMessageBoxConfirmation
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
            this.siBtn = new MaterialSkin.Controls.MaterialFlatButton();
            this.noBtn = new MaterialSkin.Controls.MaterialFlatButton();
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
            // 
            // siBtn
            // 
            this.siBtn.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.siBtn.Depth = 0;
            this.siBtn.Icon = null;
            this.siBtn.Location = new System.Drawing.Point(344, 157);
            this.siBtn.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.siBtn.MouseState = MaterialSkin.MouseState.HOVER;
            this.siBtn.Name = "siBtn";
            this.siBtn.Primary = false;
            this.siBtn.Size = new System.Drawing.Size(108, 33);
            this.siBtn.TabIndex = 1;
            this.siBtn.Text = "Si";
            this.siBtn.UseVisualStyleBackColor = true;
            this.siBtn.Click += new System.EventHandler(this.siBtn_Click);
            // 
            // noBtn
            // 
            this.noBtn.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.noBtn.Depth = 0;
            this.noBtn.Icon = null;
            this.noBtn.Location = new System.Drawing.Point(228, 157);
            this.noBtn.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.noBtn.MouseState = MaterialSkin.MouseState.HOVER;
            this.noBtn.Name = "noBtn";
            this.noBtn.Primary = false;
            this.noBtn.Size = new System.Drawing.Size(108, 33);
            this.noBtn.TabIndex = 2;
            this.noBtn.Text = "No";
            this.noBtn.UseVisualStyleBackColor = true;
            this.noBtn.Click += new System.EventHandler(this.noBtn_Click);
            // 
            // MaterialMessageBoxConfirmation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(464, 205);
            this.Controls.Add(this.noBtn);
            this.Controls.Add(this.siBtn);
            this.Controls.Add(this.label);
            this.Name = "MaterialMessageBoxConfirmation";
            this.Text = "Confirmación";
            this.ResumeLayout(false);

        }

        #endregion

        private MaterialSkin.Controls.MaterialLabel label;
        private MaterialSkin.Controls.MaterialFlatButton siBtn;
        private MaterialSkin.Controls.MaterialFlatButton noBtn;
    }
}