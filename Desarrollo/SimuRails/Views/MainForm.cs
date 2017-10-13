using MaterialSkin;
using MaterialSkin.Controls;
using SimuRails.Views;
using SimuRails.Views.Abms;
using SimuRails.Views.Abms.IncidenteAbm;
using SimuRails.Views.Abms.EstacionAbm;
using System.Windows.Forms;

namespace SimuRails.Views
{
    public partial class MainForm : MaterialForm
    {
        private readonly MaterialSkinManager materialSkinManager;
        public MainForm()
        {
            InitializeComponent();
            materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.BlueGrey800, Primary.BlueGrey900, Primary.BlueGrey500, Accent.LightBlue200, TextShade.WHITE);
        }

        private void MainForm_Load(object sender, System.EventArgs e)
        {
            // Embeber formularios en los tabs respectivos
            embedForm(new Simulacion(this, tabSimulacion), tabSimulacion);
            embedForm(new ServiciosListForm(), tabServicios);
            embedForm(new EstacionesListForm(this, tabEstaciones), tabEstaciones);
            embedForm(new CochesListForm(this, tabCoches), tabCoches);
            embedForm(new IncidentesListForm(this, tabIncidentes), tabIncidentes);
        }
        
        public void embedForm(Form form, TabPage tabPage)
        {
            form.TopLevel = false;
            form.Visible = true;
            form.FormBorderStyle = FormBorderStyle.None;
            form.Dock = DockStyle.Fill;
            tabPage.Controls.Add(form);
        }
    }
}
