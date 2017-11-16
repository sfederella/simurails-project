using MaterialSkin;
using MaterialSkin.Controls;
using System;
using System.Windows.Forms;

namespace SimuRails.Views
{
    public partial class MaterialMessageBoxConfirmation : MaterialForm
    {
        private readonly MaterialSkinManager materialSkinManager;

        public static DialogResult Show(string msg)
        {
            return Show("Confirmación",msg);
        }

        public static DialogResult Show(string title, string msg)
        {
            return new MaterialMessageBoxConfirmation(title, msg).ShowDialog();
        }

        public MaterialMessageBoxConfirmation(string title, string msg)
        {
            InitializeComponent();
            materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.BlueGrey800, Primary.BlueGrey900, Primary.BlueGrey500, Accent.LightBlue200, TextShade.WHITE);
            this.Text = title;
            label.Text = msg;
        }

        private void noBtn_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.No;
            Close();
        }

        private void siBtn_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Yes;
            Close();
        }
    }
}
