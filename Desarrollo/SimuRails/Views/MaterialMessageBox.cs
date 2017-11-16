using MaterialSkin;
using MaterialSkin.Controls;
using System;
using System.Windows.Forms;

namespace SimuRails.Views
{
    public partial class MaterialMessageBox : MaterialForm
    {
        private readonly MaterialSkinManager materialSkinManager;

        public static DialogResult Show(string msg)
        {
            return Show("Alerta", msg);
        }

        public static DialogResult Show(string title, string msg)
        {
            return new MaterialMessageBox(title, msg).ShowDialog();
        }

        public MaterialMessageBox(string title, string msg)
        {
            InitializeComponent();
            materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.BlueGrey800, Primary.BlueGrey900, Primary.BlueGrey500, Accent.LightBlue200, TextShade.WHITE);
            this.Text = title;
            label.Text = msg;
        }

        private void AceptarBtn_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            Close();
        }
    }
}
