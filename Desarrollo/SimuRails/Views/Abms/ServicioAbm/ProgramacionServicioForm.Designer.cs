namespace SimuRails.Views.Abms.ServicioAbm
{
    partial class ProgramacionServicioForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ProgramacionServicioForm));
            this.horariosGridView = new System.Windows.Forms.DataGridView();
            this.Horarios = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.importarExcel = new MaterialSkin.Controls.MaterialRaisedButton();
            this.btnInsertRow = new MaterialSkin.Controls.MaterialFlatButton();
            this.aceptarButton = new MaterialSkin.Controls.MaterialRaisedButton();
            this.cancelarButton = new MaterialSkin.Controls.MaterialFlatButton();
            this.openExcelDialog = new System.Windows.Forms.OpenFileDialog();
            this.btnClear = new MaterialSkin.Controls.MaterialFlatButton();
            ((System.ComponentModel.ISupportInitialize)(this.horariosGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // horariosGridView
            // 
            this.horariosGridView.AllowUserToOrderColumns = true;
            this.horariosGridView.AllowUserToResizeColumns = false;
            this.horariosGridView.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.horariosGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.horariosGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.horariosGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Horarios});
            this.horariosGridView.Location = new System.Drawing.Point(184, 76);
            this.horariosGridView.Name = "horariosGridView";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.horariosGridView.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.horariosGridView.Size = new System.Drawing.Size(193, 350);
            this.horariosGridView.TabIndex = 0;
            this.horariosGridView.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.HorariosGridView_CellEndEdit);
            this.horariosGridView.SelectionChanged += new System.EventHandler(this.HorariosGridView_SelectionChanged);
            // 
            // Horarios
            // 
            this.Horarios.HeaderText = "Horarios de Salida";
            this.Horarios.Name = "Horarios";
            this.Horarios.ToolTipText = "Horario de salida empezando desde las 00:00 horas.";
            this.Horarios.Width = 150;
            // 
            // importarExcel
            // 
            this.importarExcel.Depth = 0;
            this.importarExcel.Location = new System.Drawing.Point(22, 97);
            this.importarExcel.MouseState = MaterialSkin.MouseState.HOVER;
            this.importarExcel.Name = "importarExcel";
            this.importarExcel.Primary = true;
            this.importarExcel.Size = new System.Drawing.Size(137, 30);
            this.importarExcel.TabIndex = 37;
            this.importarExcel.Text = "Importar Excel";
            this.importarExcel.UseVisualStyleBackColor = true;
            this.importarExcel.Click += new System.EventHandler(this.ImportarExcel_Click);
            // 
            // btnInsertRow
            // 
            this.btnInsertRow.AutoSize = true;
            this.btnInsertRow.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnInsertRow.Depth = 0;
            this.btnInsertRow.Location = new System.Drawing.Point(35, 136);
            this.btnInsertRow.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnInsertRow.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnInsertRow.Name = "btnInsertRow";
            this.btnInsertRow.Primary = false;
            this.btnInsertRow.Size = new System.Drawing.Size(108, 36);
            this.btnInsertRow.TabIndex = 38;
            this.btnInsertRow.Text = "Insertar Fila";
            this.btnInsertRow.UseVisualStyleBackColor = true;
            this.btnInsertRow.Click += new System.EventHandler(this.BtnInsertRow_Click);
            // 
            // aceptarButton
            // 
            this.aceptarButton.Depth = 0;
            this.aceptarButton.Location = new System.Drawing.Point(22, 330);
            this.aceptarButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.aceptarButton.Name = "aceptarButton";
            this.aceptarButton.Primary = true;
            this.aceptarButton.Size = new System.Drawing.Size(137, 30);
            this.aceptarButton.TabIndex = 40;
            this.aceptarButton.Text = "Aceptar";
            this.aceptarButton.UseVisualStyleBackColor = true;
            this.aceptarButton.Click += new System.EventHandler(this.AceptarButton_Click);
            // 
            // cancelarButton
            // 
            this.cancelarButton.AutoSize = true;
            this.cancelarButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.cancelarButton.Depth = 0;
            this.cancelarButton.Location = new System.Drawing.Point(47, 369);
            this.cancelarButton.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.cancelarButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.cancelarButton.Name = "cancelarButton";
            this.cancelarButton.Primary = false;
            this.cancelarButton.Size = new System.Drawing.Size(82, 36);
            this.cancelarButton.TabIndex = 41;
            this.cancelarButton.Text = "Cancelar";
            this.cancelarButton.UseVisualStyleBackColor = true;
            this.cancelarButton.Click += new System.EventHandler(this.CancelarButton_Click);
            // 
            // openExcelDialog
            // 
            this.openExcelDialog.DefaultExt = "xlsx";
            this.openExcelDialog.Filter = "Excel Workbook|*.xlsx|Excel Workbook (old)|*.xls|All files|*.*";
            this.openExcelDialog.Title = "Abrir Excel";
            // 
            // btnClear
            // 
            this.btnClear.AutoSize = true;
            this.btnClear.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnClear.Depth = 0;
            this.btnClear.Location = new System.Drawing.Point(58, 182);
            this.btnClear.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnClear.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnClear.Name = "btnClear";
            this.btnClear.Primary = false;
            this.btnClear.Size = new System.Drawing.Size(61, 36);
            this.btnClear.TabIndex = 42;
            this.btnClear.Text = "Vaciar";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.BbtnClear_Click);
            // 
            // ProgramacionServicioForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(389, 438);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.cancelarButton);
            this.Controls.Add(this.aceptarButton);
            this.Controls.Add(this.btnInsertRow);
            this.Controls.Add(this.importarExcel);
            this.Controls.Add(this.horariosGridView);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ProgramacionServicioForm";
            this.Text = "Editor de Programación";
            this.Load += new System.EventHandler(this.FrmProgramacionServicio_Load);
            ((System.ComponentModel.ISupportInitialize)(this.horariosGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView horariosGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn Horarios;
        private MaterialSkin.Controls.MaterialRaisedButton importarExcel;
        private MaterialSkin.Controls.MaterialFlatButton btnInsertRow;
        private MaterialSkin.Controls.MaterialRaisedButton aceptarButton;
        private MaterialSkin.Controls.MaterialFlatButton cancelarButton;
        private System.Windows.Forms.OpenFileDialog openExcelDialog;
        private MaterialSkin.Controls.MaterialFlatButton btnClear;
    }
}