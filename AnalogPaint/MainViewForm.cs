using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AnalogPaint.Properties;

namespace AnalogPaint
{
    public partial class MainViewForm : Form
    {
        Color mainColor = Color.Black;
        private bool isMouse = false;
        private ArrayPoints arrayPoints = new ArrayPoints(2);
        Bitmap bitmap;
        Graphics graphics;
        Pen pen;
        Tools tool = Tools.Brush;
        float toolSize = 1f;

        enum Tools
        {
            Brush = 1,
            Pencil = 2,
            Erase = 3
        }

        public MainViewForm()
        {
            InitializeComponent();
            this.BackColor = Settings.Default.SetProp_ColorMainBackground;
            Button_ColorPicker.BackColor = mainColor;
            
            SetSize();
        }

        private void SetSize(bool resize = false)
        {
            if (!(resize == true && (Canvas.Width < bitmap.Width && Canvas.Height < bitmap.Height)))
            {
                bitmap = new Bitmap(Canvas.Width, Canvas.Height);
            }
            graphics = Graphics.FromImage(bitmap);
        }

        private void SetPenSettings()
        {
            if (tool == Tools.Pencil)
            {
                pen = new Pen(Color.FromArgb(15, mainColor), toolSize);
            }
            else if (tool == Tools.Erase)
            {
                pen = new Pen(Color.White, toolSize);
            }
            else
            {
                pen = new Pen(mainColor, toolSize);
            }
            var cap = System.Drawing.Drawing2D.LineCap.Round;
            pen.StartCap = cap;
            pen.EndCap = cap;
        }

        private void Button_ColorPicker_Click(object sender, EventArgs e)
        {
            ColorDialog colorPicker = ColorPicker;
            if (colorPicker.ShowDialog() == DialogResult.OK)
            {
                mainColor = colorPicker.Color;
                Button_ColorPicker.BackColor = mainColor;
            }
        }
        
        private void Canvas_MouseDown(object sender, MouseEventArgs e)
        {
            isMouse = true;
            SetPenSettings();
            
        }

        private void Canvas_MouseUp(object sender, MouseEventArgs e)
        {
            isMouse = false;
            arrayPoints.ResetCurrentIndex();
        }

        private void Canvas_MouseMove(object sender, MouseEventArgs e)
        {
            if (isMouse != true) 
                return;
            Draw(e);
            
        }

        private void Draw(MouseEventArgs e, bool oneClick = false)
        {
            arrayPoints.SetPoint(e.X, e.Y);

            if (arrayPoints.GetCountPoints() >= 2)
            {
                graphics.DrawLines(pen, arrayPoints.GetPoints());
                Canvas.Image = bitmap;
                arrayPoints.SetPoint(e.X, e.Y);
            }

        }


        private void Numeric_ToolSize_ValueChanged(object sender, EventArgs e)
        {
            toolSize = (float)(sender as NumericUpDown).Value;
        }

        private void MainViewForm_Resize(object sender, EventArgs e)
        {
            var bufferImage = bitmap;
            SetSize(true);
            graphics.DrawImage(bufferImage, 0, 0);            
        }

    }
} 
