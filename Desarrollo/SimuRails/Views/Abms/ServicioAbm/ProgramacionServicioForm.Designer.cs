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
            this.importarExcel = new System.Windows.Forms.Button();
            this.btnInsertRow = new System.Windows.Forms.Button();
            this.aceptarButton = new System.Windows.Forms.Button();
            this.cancelarButton = new System.Windows.Forms.Button();
            this.openExcelDialog = new System.Windows.Forms.OpenFileDialog();
            this.btnClear = new System.Windows.Forms.Button();
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
            this.horariosGridView.Location = new System.Drawing.Point(184, 12);
            this.horariosGridView.Name = "horariosGridView";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.horariosGridView.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.horariosGridView.Size = new System.Drawing.Size(193, 414);
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
            this.importarExcel.Location = new System.Drawing.Point(29, 54);
            this.importarExcel.Name = "importarExcel";
            this.importarExcel.Size = new System.Drawing.Size(120, 30);
            this.importarExcel.TabIndex = 37;
            this.importarExcel.Text = "Importar Excel";
            this.importarExcel.UseVisualStyleBackColor = true;
            this.importarExcel.Click += new System.EventHandler(this.ImportarExcel_Click);
            // 
            // btnInsertRow
            // 
            this.btnInsertRow.Location = new System.Drawing.Point(29, 119);
            this.btnInsertRow.Name = "btnInsertRow";
            this.btnInsertRow.Size = new System.Drawing.Size(120, 30);
            this.btnInsertRow.TabIndex = 38;
            this.btnInsertRow.Text = "Insertar Fila";
            this.btnInsertRow.UseVisualStyleBackColor = true;
            this.btnInsertRow.Click += new System.EventHandler(this.BtnInsertRow_Click);
            // 
            // aceptarButton
            // 
            this.aceptarButton.Location = new System.Drawing.Point(29, 324);
            this.aceptarButton.Name = "aceptarButton";
            this.aceptarButton.Size = new System.Drawing.Size(120, 30);
            this.aceptarButton.TabIndex = 40;
            this.aceptarButton.Text = "Aceptar";
            this.aceptarButton.UseVisualStyleBackColor = true;
            this.aceptarButton.Click += new System.EventHandler(this.AceptarButton_Click);
            // 
            // cancelarButton
            // 
            this.cancelarButton.Location = new System.Drawing.Point(29, 360);
            this.cancelarButton.Name = "cancelarButton";
            this.cancelarButton.Size = new System.Drawing.Size(120, 30);
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
            this.btnClear.Location = new System.Drawing.Point(29, 155);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(120, 30);
            this.btnClear.TabIndex = 42;
            this.btnClear.Text = "Vaciar";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.BbtnClear_Click);
            // 
            // frmProgramacionServicio
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
            this.Name = "frmProgramacionServicio";
            this.Text = "Editor de Programación";
            this.Load += new System.EventHandler(this.FrmProgramacionServicio_Load);
            ((System.ComponentModel.ISupportInitialize)(this.horariosGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView horariosGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn Horarios;
        private System.Windows.Forms.Button importarExcel;
        private System.Windows.Forms.Button btnInsertRow;
        private System.Windows.Forms.Button aceptarButton;
        private System.Windows.Forms.Button cancelarButton;
        private System.Windows.Forms.OpenFileDialog openExcelDialog;
        private System.Windows.Forms.Button btnClear;
    }
}