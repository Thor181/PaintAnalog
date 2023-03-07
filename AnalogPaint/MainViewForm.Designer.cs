namespace AnalogPaint
{
    partial class MainViewForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainViewForm));
            this.Canvas = new System.Windows.Forms.PictureBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItem_NewFile = new System.Windows.Forms.ToolStripMenuItem();
            this.сохранитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.сохранитьКакToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.открытьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.настройкиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.выбратьЦветToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItemButton_WhiteColor = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItemButton_GrayColor = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItemButton_DarkGrayColor = new System.Windows.Forms.ToolStripMenuItem();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.ToolBrush = new System.Windows.Forms.Button();
            this.ToolPencil = new System.Windows.Forms.Button();
            this.ToolFill = new System.Windows.Forms.Button();
            this.ToolErase = new System.Windows.Forms.Button();
            this.ColorPicker = new System.Windows.Forms.ColorDialog();
            this.Button_ColorPicker = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.Numeric_ToolSize = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.Canvas)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.flowLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Numeric_ToolSize)).BeginInit();
            this.SuspendLayout();
            // 
            // Canvas
            // 
            this.Canvas.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Canvas.BackColor = System.Drawing.Color.White;
            this.Canvas.Location = new System.Drawing.Point(0, 78);
            this.Canvas.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Canvas.Name = "Canvas";
            this.Canvas.Size = new System.Drawing.Size(921, 489);
            this.Canvas.TabIndex = 0;
            this.Canvas.TabStop = false;
            this.Canvas.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Canvas_MouseDown);
            this.Canvas.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Canvas_MouseMove);
            this.Canvas.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Canvas_MouseUp);
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1,
            this.настройкиToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(4, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(921, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuItem_NewFile,
            this.сохранитьToolStripMenuItem,
            this.сохранитьКакToolStripMenuItem,
            this.открытьToolStripMenuItem});
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(48, 20);
            this.toolStripMenuItem1.Text = "Файл";
            // 
            // MenuItem_NewFile
            // 
            this.MenuItem_NewFile.Name = "MenuItem_NewFile";
            this.MenuItem_NewFile.Size = new System.Drawing.Size(154, 22);
            this.MenuItem_NewFile.Text = "Новый";
            this.MenuItem_NewFile.Click += new System.EventHandler(this.MenuItem_NewFile_Click);
            // 
            // сохранитьToolStripMenuItem
            // 
            this.сохранитьToolStripMenuItem.Name = "сохранитьToolStripMenuItem";
            this.сохранитьToolStripMenuItem.Size = new System.Drawing.Size(154, 22);
            this.сохранитьToolStripMenuItem.Text = "Сохранить";
            // 
            // сохранитьКакToolStripMenuItem
            // 
            this.сохранитьКакToolStripMenuItem.Name = "сохранитьКакToolStripMenuItem";
            this.сохранитьКакToolStripMenuItem.Size = new System.Drawing.Size(154, 22);
            this.сохранитьКакToolStripMenuItem.Text = "Сохранить как";
            // 
            // открытьToolStripMenuItem
            // 
            this.открытьToolStripMenuItem.Name = "открытьToolStripMenuItem";
            this.открытьToolStripMenuItem.Size = new System.Drawing.Size(154, 22);
            this.открытьToolStripMenuItem.Text = "Открыть";
            // 
            // настройкиToolStripMenuItem
            // 
            this.настройкиToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.выбратьЦветToolStripMenuItem});
            this.настройкиToolStripMenuItem.Name = "настройкиToolStripMenuItem";
            this.настройкиToolStripMenuItem.Size = new System.Drawing.Size(79, 20);
            this.настройкиToolStripMenuItem.Text = "Настройки";
            // 
            // выбратьЦветToolStripMenuItem
            // 
            this.выбратьЦветToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuItemButton_WhiteColor,
            this.MenuItemButton_GrayColor,
            this.MenuItemButton_DarkGrayColor});
            this.выбратьЦветToolStripMenuItem.Name = "выбратьЦветToolStripMenuItem";
            this.выбратьЦветToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.выбратьЦветToolStripMenuItem.Text = "Выбрать цвет фона";
            // 
            // MenuItemButton_WhiteColor
            // 
            this.MenuItemButton_WhiteColor.Name = "MenuItemButton_WhiteColor";
            this.MenuItemButton_WhiteColor.Size = new System.Drawing.Size(149, 22);
            this.MenuItemButton_WhiteColor.Text = "Белый";
            this.MenuItemButton_WhiteColor.Click += new System.EventHandler(this.MenuItemButton_WhiteColor_Click);
            // 
            // MenuItemButton_GrayColor
            // 
            this.MenuItemButton_GrayColor.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.MenuItemButton_GrayColor.Name = "MenuItemButton_GrayColor";
            this.MenuItemButton_GrayColor.Size = new System.Drawing.Size(149, 22);
            this.MenuItemButton_GrayColor.Text = "Серый";
            this.MenuItemButton_GrayColor.Click += new System.EventHandler(this.MenuItemButton_GrayColor_Click);
            // 
            // MenuItemButton_DarkGrayColor
            // 
            this.MenuItemButton_DarkGrayColor.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.MenuItemButton_DarkGrayColor.Name = "MenuItemButton_DarkGrayColor";
            this.MenuItemButton_DarkGrayColor.Size = new System.Drawing.Size(149, 22);
            this.MenuItemButton_DarkGrayColor.Text = "Темно-серый";
            this.MenuItemButton_DarkGrayColor.Click += new System.EventHandler(this.MenuItemButton_DarkGrayColor_Click);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.BackColor = System.Drawing.SystemColors.Menu;
            this.flowLayoutPanel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.flowLayoutPanel1.Controls.Add(this.ToolBrush);
            this.flowLayoutPanel1.Controls.Add(this.ToolPencil);
            this.flowLayoutPanel1.Controls.Add(this.ToolFill);
            this.flowLayoutPanel1.Controls.Add(this.ToolErase);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 24);
            this.flowLayoutPanel1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.flowLayoutPanel1.MaximumSize = new System.Drawing.Size(288, 54);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(288, 54);
            this.flowLayoutPanel1.TabIndex = 2;
            // 
            // ToolBrush
            // 
            this.ToolBrush.BackColor = System.Drawing.Color.Transparent;
            this.ToolBrush.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("ToolBrush.BackgroundImage")));
            this.ToolBrush.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ToolBrush.Location = new System.Drawing.Point(2, 2);
            this.ToolBrush.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.ToolBrush.Name = "ToolBrush";
            this.ToolBrush.Size = new System.Drawing.Size(19, 20);
            this.ToolBrush.TabIndex = 0;
            this.ToolBrush.UseVisualStyleBackColor = false;
            this.ToolBrush.Click += new System.EventHandler(this.ToolBrush_Click);
            // 
            // ToolPencil
            // 
            this.ToolPencil.BackColor = System.Drawing.Color.Transparent;
            this.ToolPencil.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("ToolPencil.BackgroundImage")));
            this.ToolPencil.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ToolPencil.Location = new System.Drawing.Point(25, 2);
            this.ToolPencil.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.ToolPencil.Name = "ToolPencil";
            this.ToolPencil.Size = new System.Drawing.Size(19, 20);
            this.ToolPencil.TabIndex = 1;
            this.ToolPencil.UseVisualStyleBackColor = false;
            this.ToolPencil.Click += new System.EventHandler(this.ToolPencil_Click);
            // 
            // ToolFill
            // 
            this.ToolFill.BackColor = System.Drawing.Color.Transparent;
            this.ToolFill.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("ToolFill.BackgroundImage")));
            this.ToolFill.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ToolFill.Location = new System.Drawing.Point(48, 2);
            this.ToolFill.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.ToolFill.Name = "ToolFill";
            this.ToolFill.Size = new System.Drawing.Size(19, 20);
            this.ToolFill.TabIndex = 3;
            this.ToolFill.UseVisualStyleBackColor = false;
            // 
            // ToolErase
            // 
            this.ToolErase.BackColor = System.Drawing.Color.Transparent;
            this.ToolErase.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("ToolErase.BackgroundImage")));
            this.ToolErase.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ToolErase.Location = new System.Drawing.Point(71, 2);
            this.ToolErase.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.ToolErase.Name = "ToolErase";
            this.ToolErase.Size = new System.Drawing.Size(19, 20);
            this.ToolErase.TabIndex = 2;
            this.ToolErase.UseVisualStyleBackColor = false;
            this.ToolErase.Click += new System.EventHandler(this.ToolErase_Click);
            // 
            // Button_ColorPicker
            // 
            this.Button_ColorPicker.BackColor = System.Drawing.Color.White;
            this.Button_ColorPicker.Location = new System.Drawing.Point(2, 2);
            this.Button_ColorPicker.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Button_ColorPicker.Name = "Button_ColorPicker";
            this.Button_ColorPicker.Size = new System.Drawing.Size(19, 20);
            this.Button_ColorPicker.TabIndex = 0;
            this.Button_ColorPicker.UseVisualStyleBackColor = false;
            this.Button_ColorPicker.Click += new System.EventHandler(this.Button_ColorPicker_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Menu;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.Button_ColorPicker);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(288, 24);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel1.MaximumSize = new System.Drawing.Size(65, 54);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(65, 54);
            this.panel1.TabIndex = 3;
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.flowLayoutPanel2.Controls.Add(this.label1);
            this.flowLayoutPanel2.Controls.Add(this.Numeric_ToolSize);
            this.flowLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.flowLayoutPanel2.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanel2.Location = new System.Drawing.Point(353, 24);
            this.flowLayoutPanel2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.flowLayoutPanel2.MaximumSize = new System.Drawing.Size(79, 56);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Size = new System.Drawing.Size(79, 56);
            this.flowLayoutPanel2.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(2, 0);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 39);
            this.label1.TabIndex = 0;
            this.label1.Text = "Размер инструмента";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // Numeric_ToolSize
            // 
            this.Numeric_ToolSize.Dock = System.Windows.Forms.DockStyle.Top;
            this.Numeric_ToolSize.Location = new System.Drawing.Point(72, 2);
            this.Numeric_ToolSize.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Numeric_ToolSize.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.Numeric_ToolSize.Name = "Numeric_ToolSize";
            this.Numeric_ToolSize.Size = new System.Drawing.Size(0, 20);
            this.Numeric_ToolSize.TabIndex = 1;
            this.Numeric_ToolSize.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.Numeric_ToolSize.ValueChanged += new System.EventHandler(this.Numeric_ToolSize_ValueChanged);
            // 
            // MainViewForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.MenuBar;
            this.ClientSize = new System.Drawing.Size(921, 567);
            this.Controls.Add(this.flowLayoutPanel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.Canvas);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "MainViewForm";
            this.Text = "Form1";
            this.Resize += new System.EventHandler(this.MainViewForm_Resize);
            ((System.ComponentModel.ISupportInitialize)(this.Canvas)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.flowLayoutPanel2.ResumeLayout(false);
            this.flowLayoutPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Numeric_ToolSize)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox Canvas;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem MenuItem_NewFile;
        private System.Windows.Forms.ToolStripMenuItem сохранитьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem сохранитьКакToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem открытьToolStripMenuItem;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.ToolStripMenuItem настройкиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem выбратьЦветToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem MenuItemButton_WhiteColor;
        private System.Windows.Forms.ToolStripMenuItem MenuItemButton_GrayColor;
        private System.Windows.Forms.ToolStripMenuItem MenuItemButton_DarkGrayColor;
        private System.Windows.Forms.ColorDialog ColorPicker;
        private System.Windows.Forms.Button Button_ColorPicker;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button ToolBrush;
        private System.Windows.Forms.Button ToolPencil;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown Numeric_ToolSize;
        private System.Windows.Forms.Button ToolErase;
        private System.Windows.Forms.Button ToolFill;
    }
}

