using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace AnalogPaint
{
    public partial class MainViewForm
    {
        private void ToolBrush_Click(object sender, EventArgs e)
        {
            tool = Tools.Brush;
            
        }
        private void ToolPencil_Click(object sender, EventArgs e)
        {
            tool = Tools.Pencil;
        }
        private void ToolErase_Click(object sender, EventArgs e)
        {
            tool = Tools.Erase;
        }
    }
}
