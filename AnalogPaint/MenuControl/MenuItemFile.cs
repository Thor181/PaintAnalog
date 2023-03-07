using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace AnalogPaint
{
    public partial class MainViewForm
    {
        private void MenuItem_NewFile_Click(object sender, EventArgs e)
        {
            SetSize();
            Canvas.Image = bitmap;
        }
    }
}
