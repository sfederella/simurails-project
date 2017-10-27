using MaterialSkin;
using MaterialSkin.Controls;
using SimuRails.Views.Abms;
using SimuRails.Views.Abms.FormacionAbm;
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
            embedForm(new SimulacionesListForm(this, tabSimulacion), tabSimulacion);
            embedForm(new ServiciosListForm(this,tabServicios), tabServicios);
            embedForm(new CompartirForm(this, tabEstaciones), tabEstaciones);
            embedForm(new CochesListForm(this, tabCoches), tabCoches);
            embedForm(new IncidentesListForm(this, tabIncidentes), tabIncidentes);
            embedForm(new TrazasListForm(this, tabTrazas), tabTrazas);
            embedForm(new FormacionListForm(this, tabFormaciones), tabFormaciones);
        }
        
        public void embedForm(Form form, TabPage tabPage)
        {
            form.TopLevel = false;
            form.Visible = true;
            form.FormBorderStyle = FormBorderStyle.None;
            form.Dock = DockStyle.Fill;
            tabPage.Controls.Add(form);
        }

        private void tabSimulacion_Click(object sender, System.EventArgs e)
        {

        }
    }
}
