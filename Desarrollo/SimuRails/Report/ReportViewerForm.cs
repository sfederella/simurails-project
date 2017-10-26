using System;
using System.Windows.Forms;

namespace SimuRails.Report
{

    public partial class ReportViewerForm : Form
    {
                public Microsoft.Reporting.WinForms.ReportViewer ReportViewerObject
        {
            get
            {
                return this.rvwForm;
            }
        }
        public ReportViewerForm()
        {
            InitializeComponent();
        }

        private void ReportViewerForm_Load(object sender, EventArgs e)
        {

            this.rvwForm.RefreshReport();
        }
    }
}
