using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;
using AnalogPaint.Properties;

namespace AnalogPaint
{
    public partial class MainViewForm //Set color to background of main form
    {
        private void MenuItemButton_WhiteColor_Click(object sender, EventArgs e) => SetColor(sender);

        private void MenuItemButton_GrayColor_Click(object sender, EventArgs e) => SetColor(sender);

        private void MenuItemButton_DarkGrayColor_Click(object sender, EventArgs e) => SetColor(sender);

        private void SetColor(object sender)
        {
            Color color = (sender as ToolStripMenuItem).BackColor;
            this.BackColor = color;
            Settings.Default.SetProp_ColorMainBackground = color;
            Settings.Default.Save();
        }
    }
}
