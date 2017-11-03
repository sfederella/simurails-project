using MaterialSkin;
using MaterialSkin.Controls;
using SimuRails.Views.Abms;
using SimuRails.Views.Abms.FormacionAbm;
using System.Diagnostics;
using System.IO;
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
            EmbedForm(new SimulacionesListForm(this, tabSimulacion), tabSimulacion);
            EmbedForm(new ServiciosListForm(this,tabServicios), tabServicios);
            EmbedForm(new EstacionesListForm(this, tabEstaciones), tabEstaciones);
            EmbedForm(new CochesListForm(this, tabCoches), tabCoches);
            EmbedForm(new IncidentesListForm(this, tabIncidentes), tabIncidentes);
            EmbedForm(new TrazasListForm(this, tabTrazas), tabTrazas);
            EmbedForm(new FormacionListForm(this, tabFormaciones), tabFormaciones);
        }
        
        public void EmbedForm(Form form, TabPage tabPage)
        {
            form.TopLevel = false;
            form.Visible = true;
            form.FormBorderStyle = FormBorderStyle.None;
            form.Dock = DockStyle.Fill;
            tabPage.Controls.Add(form);
        }
        private void label1_Click(object sender, System.EventArgs e)
        {
            SobreNosotrosForm frm = new SobreNosotrosForm();
            frm.ShowDialog();
        }

        private void label2_Click(object sender, System.EventArgs e)
        {
            string pathManual = Path.Combine(Application.StartupPath, "ManualDeUsuario.pdf");
            try
            {
                //Process.Start(pathManual);
                string openPDFFile =Path.Combine(Application.StartupPath,"ManualUsuario.PDF");
                System.IO.File.WriteAllBytes(openPDFFile, global::SimuRails.Properties.Resources.ManualDeUsuario);
                System.Diagnostics.Process.Start(openPDFFile);    
            }
            catch
            {
                MessageBox.Show("No se puede acceder al Manual de Usuario.", "Error de Apertura");
            }         
        }
    }
}
