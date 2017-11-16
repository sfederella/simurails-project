using MaterialSkin;
using MaterialSkin.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Globalization;
using System.Windows.Forms;
using Excel = Microsoft.Office.Interop.Excel;

namespace SimuRails.Views.Abms.ServicioAbm
{
    public partial class ProgramacionServicioForm : MaterialForm
    {
        DataGridViewCell cellWithError;

        public List<int> Programacion { get; private set; }

        private readonly MaterialSkinManager materialSkinManager;

        public ProgramacionServicioForm(List<int> programacionInicial)
        {
            Programacion = programacionInicial;
            InitializeComponent();
            materialSkinManager = MaterialSkin.MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.BlueGrey800, Primary.BlueGrey900, Primary.BlueGrey500, Accent.LightBlue200, TextShade.WHITE);
        }

        private void FrmProgramacionServicio_Load(object sender, EventArgs e)
        {
            for(var i=0; i< Programacion.Count; i++)
            {
                horariosGridView.Rows.Add((Programacion[i] / 60).ToString("D2") + ":" + (Programacion[i] % 60).ToString("D2"));
            }
        }

        private void AceptarButton_Click(object sender, EventArgs e)
        {
            Programacion.Clear();
            //this.horariosGridView.Sort(this.horariosGridView.Columns["Horarios"], ListSortDirection.Ascending);
            foreach (DataGridViewRow horarioRow in horariosGridView.Rows)
            {
                if (horarioRow.Cells[0].Value != null)
                {
                    string[] timeArr = horarioRow.Cells[0].Value.ToString().Split(':');
                    Programacion.Add(int.Parse(timeArr[0]) * 60 + int.Parse(timeArr[1]));
                }
            }
            if (!IsSorted(Programacion))
            {
                MaterialMessageBox.Show("Error", "La programación no se encuentra ordenada. Se ordenará automáticamente.");
                Programacion.Sort();
            }
            this.DialogResult = DialogResult.OK;
            Close();
        }

        private void CancelarButton_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            Close();
        }

        private void ImportarExcel_Click(object sender, EventArgs e)
        {
            var result  = openExcelDialog.ShowDialog();
            if (result == DialogResult.OK)
            {
                horariosGridView.Rows.Clear();
                horariosGridView.Rows.Add("Cargando...");

                Excel.Application app = new Microsoft.Office.Interop.Excel.Application();
                Excel.Workbook workbook = app.Workbooks.Open(openExcelDialog.FileName);
                Excel.Worksheet worksheet = workbook.ActiveSheet;

                int rcount = worksheet.UsedRange.Rows.Count;
                TimeSpan horarioCell;
                horariosGridView.Rows.Clear();
                for (int i = 0; i < rcount; i++)
                {
                    try
                    {
                        horarioCell = TimeSpan.FromDays(worksheet.Cells[i + 1, 1].Value);
                        horariosGridView.Rows.Add(horarioCell.ToString(@"hh\:mm"));
                    }
                    catch
                    {
                        MaterialMessageBox.Show("Error", "La fila nro " + i + " del excel tiene un formato inválido.");
                        horariosGridView.Rows.Clear();
                        break;
                    }
                }
            }
        }

        private void HorariosGridView_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            string value = (string) horariosGridView.CurrentCell.Value;
            if (string.IsNullOrEmpty(value))
            {
                if (e.RowIndex != horariosGridView.Rows.Count-1)
                {
                    horariosGridView.Rows.RemoveAt(e.RowIndex);
                }
            }
            else if (!EsHorarioValido(value))
            {
                cellWithError = horariosGridView.CurrentCell;
                MaterialMessageBox.Show("Error", "Formato inválido.");
                horariosGridView.Rows[e.RowIndex].Cells[e.ColumnIndex].Selected = false;
            }
        }

        private bool EsHorarioValido(string horario)
        {
            System.Globalization.CultureInfo provider = System.Globalization.CultureInfo.InvariantCulture;
            DateTime outDate;
            return DateTime.TryParseExact(horario, "HH:mm", CultureInfo.InvariantCulture, DateTimeStyles.None, out outDate);
        }

        private void HorariosGridView_SelectionChanged(object sender, EventArgs e)
        {
            if (cellWithError != null)
            {
                horariosGridView.CurrentCell = cellWithError;
                horariosGridView.BeginEdit(true);
                cellWithError = null;
            }
        }

        private void BbtnClear_Click(object sender, EventArgs e)
        {
            horariosGridView.Rows.Clear();
        }

        private void BtnInsertRow_Click(object sender, EventArgs e)
        {
            var rowIndex = horariosGridView.CurrentCell.RowIndex;
            var colIndex = horariosGridView.CurrentCell.ColumnIndex;
            horariosGridView.Rows.Insert(rowIndex, 1);
            horariosGridView.CurrentCell = horariosGridView.Rows[rowIndex].Cells[colIndex];
            horariosGridView.BeginEdit(true);
        }

        private bool IsSorted(List<int> list)
        {
            for (int i = 1; i < list.Count; i++)
            {
                if (list[i - 1] > list[i]) return false;
            }
            return true;
        }

    }
}
