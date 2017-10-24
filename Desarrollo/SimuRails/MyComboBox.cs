
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace SimuRails.Report
{
    public sealed class MyComboBox : ComboBox
    {
        public List<string> listaDatos ;
        public MyComboBox()
        {
            DropDownStyle = ComboBoxStyle.DropDown;
            AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            AutoCompleteSource = AutoCompleteSource.ListItems;
            BackColor = System.Drawing.SystemColors.Control;
            FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(35)))), ((int)(((byte)(49)))));
            Validating += new System.ComponentModel.CancelEventHandler(this.MyComboBox_Validating);
            DrawMode = DrawMode.OwnerDrawFixed;
            DrawItem += new DrawItemEventHandler(this.MyComboBox_DrawItem);

        }
        private void MyComboBox_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (this.SelectedIndex == -1)
            {
                e.Cancel = true;
                this.SelectedIndex = 0;
            }
        }


        private void MyComboBox_DrawItem(object sender, System.Windows.Forms.DrawItemEventArgs e)
        {
            if (e.Index < 0)
                return;
            Rectangle rect = e.Bounds;        
            if ((e.State & DrawItemState.Selected) == DrawItemState.Selected)
            {
                e.Graphics.FillRectangle(Brushes.Gainsboro, rect);
            }
            else
            {
                e.Graphics.FillRectangle(SystemBrushes.Window, rect);
            }
            string str =this.listaDatos[e.Index];
            e.Graphics.DrawString(str, this.Font, Brushes.DarkSlateGray, rect.X, rect.Y);

        }
    }
}
