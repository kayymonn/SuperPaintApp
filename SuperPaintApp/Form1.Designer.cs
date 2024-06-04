namespace SuperPaintApp
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            panel1 = new Panel();
            Btn_clear = new Button();
            Btn_load = new Button();
            Btn_save = new Button();
            Btn_line = new Button();
            Btn_rect = new Button();
            Btn_ellipse = new Button();
            Btn_eraser = new Button();
            Btn_pencil = new Button();
            Btn_color = new Button();
            pic_color = new Button();
            pic = new PictureBox();
            Btn_triangle = new Button();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pic).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ActiveBorder;
            panel1.Controls.Add(Btn_triangle);
            panel1.Controls.Add(Btn_clear);
            panel1.Controls.Add(Btn_load);
            panel1.Controls.Add(Btn_save);
            panel1.Controls.Add(Btn_line);
            panel1.Controls.Add(Btn_rect);
            panel1.Controls.Add(Btn_ellipse);
            panel1.Controls.Add(Btn_eraser);
            panel1.Controls.Add(Btn_pencil);
            panel1.Controls.Add(Btn_color);
            panel1.Controls.Add(pic_color);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(864, 119);
            panel1.TabIndex = 0;
            // 
            // Btn_clear
            // 
            Btn_clear.BackColor = SystemColors.AppWorkspace;
            Btn_clear.FlatAppearance.MouseDownBackColor = Color.Maroon;
            Btn_clear.FlatAppearance.MouseOverBackColor = Color.FromArgb(128, 64, 64);
            Btn_clear.ImageAlign = ContentAlignment.TopRight;
            Btn_clear.Location = new Point(666, 31);
            Btn_clear.Name = "Btn_clear";
            Btn_clear.Size = new Size(48, 44);
            Btn_clear.TabIndex = 9;
            Btn_clear.Text = "Clear";
            Btn_clear.UseVisualStyleBackColor = false;
            Btn_clear.Click += Btn_clear_Click;
            // 
            // Btn_load
            // 
            Btn_load.BackColor = SystemColors.AppWorkspace;
            Btn_load.FlatAppearance.MouseDownBackColor = Color.Maroon;
            Btn_load.FlatAppearance.MouseOverBackColor = Color.FromArgb(128, 64, 64);
            Btn_load.ImageAlign = ContentAlignment.TopRight;
            Btn_load.Location = new Point(612, 31);
            Btn_load.Name = "Btn_load";
            Btn_load.Size = new Size(48, 44);
            Btn_load.TabIndex = 8;
            Btn_load.Text = "Load";
            Btn_load.UseVisualStyleBackColor = false;
            Btn_load.Click += Btn_load_Click;
            // 
            // Btn_save
            // 
            Btn_save.BackColor = SystemColors.AppWorkspace;
            Btn_save.FlatAppearance.MouseDownBackColor = Color.Maroon;
            Btn_save.FlatAppearance.MouseOverBackColor = Color.FromArgb(128, 64, 64);
            Btn_save.ImageAlign = ContentAlignment.TopRight;
            Btn_save.Location = new Point(558, 31);
            Btn_save.Name = "Btn_save";
            Btn_save.Size = new Size(48, 44);
            Btn_save.TabIndex = 7;
            Btn_save.Text = "Save";
            Btn_save.UseVisualStyleBackColor = false;
            Btn_save.Click += Btn_save_Click;
            // 
            // Btn_line
            // 
            Btn_line.BackColor = SystemColors.AppWorkspace;
            Btn_line.Cursor = Cursors.Hand;
            Btn_line.FlatAppearance.MouseDownBackColor = Color.Maroon;
            Btn_line.FlatAppearance.MouseOverBackColor = Color.FromArgb(128, 64, 64);
            Btn_line.Image = Properties.Resources.line;
            Btn_line.ImageAlign = ContentAlignment.TopRight;
            Btn_line.Location = new Point(446, 31);
            Btn_line.Name = "Btn_line";
            Btn_line.Size = new Size(48, 44);
            Btn_line.TabIndex = 6;
            Btn_line.UseVisualStyleBackColor = false;
            Btn_line.Click += Btn_line_Click;
            // 
            // Btn_rect
            // 
            Btn_rect.BackColor = SystemColors.ActiveBorder;
            Btn_rect.Cursor = Cursors.Hand;
            Btn_rect.FlatAppearance.MouseDownBackColor = Color.Maroon;
            Btn_rect.FlatAppearance.MouseOverBackColor = Color.FromArgb(128, 64, 64);
            Btn_rect.Image = Properties.Resources.rectangle;
            Btn_rect.ImageAlign = ContentAlignment.TopRight;
            Btn_rect.Location = new Point(392, 31);
            Btn_rect.Name = "Btn_rect";
            Btn_rect.Size = new Size(48, 44);
            Btn_rect.TabIndex = 5;
            Btn_rect.UseVisualStyleBackColor = false;
            Btn_rect.Click += Btn_rect_Click;
            // 
            // Btn_ellipse
            // 
            Btn_ellipse.BackColor = SystemColors.AppWorkspace;
            Btn_ellipse.Cursor = Cursors.Hand;
            Btn_ellipse.FlatAppearance.MouseDownBackColor = Color.Maroon;
            Btn_ellipse.FlatAppearance.MouseOverBackColor = Color.FromArgb(128, 64, 64);
            Btn_ellipse.Image = Properties.Resources.circle;
            Btn_ellipse.ImageAlign = ContentAlignment.TopRight;
            Btn_ellipse.Location = new Point(338, 31);
            Btn_ellipse.Name = "Btn_ellipse";
            Btn_ellipse.Size = new Size(48, 44);
            Btn_ellipse.TabIndex = 4;
            Btn_ellipse.UseVisualStyleBackColor = false;
            Btn_ellipse.Click += Btn_ellipse_Click;
            // 
            // Btn_eraser
            // 
            Btn_eraser.BackColor = SystemColors.AppWorkspace;
            Btn_eraser.Cursor = Cursors.Hand;
            Btn_eraser.FlatAppearance.MouseDownBackColor = Color.Maroon;
            Btn_eraser.FlatAppearance.MouseOverBackColor = Color.FromArgb(128, 64, 64);
            Btn_eraser.Image = Properties.Resources.eraser;
            Btn_eraser.ImageAlign = ContentAlignment.MiddleRight;
            Btn_eraser.Location = new Point(284, 31);
            Btn_eraser.Name = "Btn_eraser";
            Btn_eraser.Size = new Size(48, 44);
            Btn_eraser.TabIndex = 3;
            Btn_eraser.UseVisualStyleBackColor = false;
            Btn_eraser.Click += Btn_eraser_Click;
            // 
            // Btn_pencil
            // 
            Btn_pencil.BackColor = SystemColors.AppWorkspace;
            Btn_pencil.Cursor = Cursors.Hand;
            Btn_pencil.FlatAppearance.MouseDownBackColor = Color.Maroon;
            Btn_pencil.FlatAppearance.MouseOverBackColor = Color.FromArgb(128, 64, 64);
            Btn_pencil.Image = Properties.Resources.pencil;
            Btn_pencil.ImageAlign = ContentAlignment.TopRight;
            Btn_pencil.Location = new Point(230, 31);
            Btn_pencil.Name = "Btn_pencil";
            Btn_pencil.Size = new Size(48, 44);
            Btn_pencil.TabIndex = 2;
            Btn_pencil.UseVisualStyleBackColor = false;
            Btn_pencil.Click += Btn_pencil_Click;
            // 
            // Btn_color
            // 
            Btn_color.BackColor = SystemColors.AppWorkspace;
            Btn_color.Cursor = Cursors.Hand;
            Btn_color.FlatAppearance.MouseDownBackColor = Color.Maroon;
            Btn_color.FlatAppearance.MouseOverBackColor = Color.FromArgb(128, 64, 64);
            Btn_color.Image = Properties.Resources.color;
            Btn_color.ImageAlign = ContentAlignment.MiddleRight;
            Btn_color.Location = new Point(176, 31);
            Btn_color.Name = "Btn_color";
            Btn_color.Size = new Size(48, 44);
            Btn_color.TabIndex = 1;
            Btn_color.UseVisualStyleBackColor = false;
            Btn_color.Click += Btn_color_Click;
            // 
            // pic_color
            // 
            pic_color.BackColor = Color.White;
            pic_color.Location = new Point(119, 27);
            pic_color.Name = "pic_color";
            pic_color.Size = new Size(51, 52);
            pic_color.TabIndex = 0;
            pic_color.UseVisualStyleBackColor = false;
            // 
            // pic
            // 
            pic.BackColor = Color.White;
            pic.Dock = DockStyle.Fill;
            pic.Location = new Point(0, 119);
            pic.Name = "pic";
            pic.Size = new Size(864, 392);
            pic.TabIndex = 1;
            pic.TabStop = false;
            pic.Paint += pic_Paint;
            pic.MouseDown += pic_MouseDown;
            pic.MouseMove += pic_MouseMove;
            pic.MouseUp += pic_MouseUp;
            // 
            // Btn_triangle
            // 
            Btn_triangle.BackColor = SystemColors.AppWorkspace;
            Btn_triangle.Location = new Point(500, 31);
            Btn_triangle.Name = "Btn_triangle";
            Btn_triangle.Size = new Size(52, 44);
            Btn_triangle.TabIndex = 10;
            Btn_triangle.Text = "Triangle";
            Btn_triangle.UseVisualStyleBackColor = false;
            Btn_triangle.Click += Btn_triangle_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(864, 511);
            Controls.Add(pic);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Paint";
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pic).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private PictureBox pic;
        private Button Btn_color;
        private Button Pic_Color;
        private Button Btn_eraser;
        private Button Btn_pencil;
        private Button Btn_line;
        private Button Btn_rect;
        private Button Btn_ellipse;
        private Button Btn_load;
        private Button Btn_save;
        private Button Btn_clear;
        private Button pic_Color;
        private Button pic_color;
        private Button Btn_triangle;
    }
}
