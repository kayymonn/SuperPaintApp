using System.Drawing.Imaging;
using System.Security.Cryptography;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace SuperPaintApp
{
    public partial class Form1 : Form
    {
        Bitmap bm;
        Graphics g;
        bool paint = false;
        Point px, py;
        Pen p = new Pen(Color.Black, 1);
        Pen erase = new Pen(Color.White, 10);
        int index;
        int x, y, sX, sY, cX, cY;

        ColorDialog cd = new ColorDialog();
        Color new_color;
        bool firstdialog = true;
        SaveFileDialog sfd = new SaveFileDialog();
        bool IsDocumentDirty = false;

        Stack<Bitmap> undoStack = new Stack<Bitmap>();
        Stack<Bitmap> redoStack = new Stack<Bitmap>();

        public Form1()
        {
            InitializeComponent();
            bm = new Bitmap(pic.Width, pic.Height);
            g = Graphics.FromImage(bm);
            g.Clear(Color.White);
            pic.Image = bm;
        }

        private void pic_MouseDown(object sender, MouseEventArgs e)
        {
            paint = true;
            py = e.Location;

            cX = e.X;
            cY = e.Y;
            sX = 0;
            sY = 0;

        }

        private void pic_MouseMove(object sender, MouseEventArgs e)
        {
            if (paint)
            {

                if (index == 1)
                {
                    px = e.Location;
                    g.DrawLine(p, px, py);
                    py = px;

                }
                if (index == 2)
                {
                    px = e.Location;
                    g.DrawLine(erase, px, py);
                    py = px;

                }

            }
            pic.Refresh();

            x = e.X;
            y = e.Y;
            sX = e.X - cX;
            sY = e.Y - cY;
        }

        private void pic_MouseUp(object sender, MouseEventArgs e)
        {
            paint = false;

            DrawObject(g);
            IsDocumentDirty = true;

            // Save the current state of the bitmap for undo
            undoStack.Push((Bitmap)bm.Clone());
            redoStack.Clear();
        }

        private void Btn_pencil_Click(object sender, EventArgs e)
        {
            index = 1;
        }

        private void Btn_eraser_Click(object sender, EventArgs e)
        {
            index = 2;
        }

        private void Btn_ellipse_Click(object sender, EventArgs e)
        {
            index = 3;
        }

        private void Btn_rect_Click(object sender, EventArgs e)
        {
            index = 4;
        }

        private void Btn_line_Click(object sender, EventArgs e)
        {
            index = 5;
        }

        private void pic_Paint(object sender, PaintEventArgs e)
        {
            if (paint)
            {
                Graphics previewg = e.Graphics;
                DrawObject(previewg);
            }
        }

        private void DrawObject(Graphics previewg)
        {
            if (index == 3)
            {
                previewg.DrawEllipse(p, cX, cY, sX, sY);
            }
            if (index == 4)
            {
                previewg.DrawPolygon(p, new Point[] { new Point(cX, cY), new Point(cX + sX, cY), new Point(cX + sX, cY + sY), new Point(cX, cY + sY) });
            }
            if (index == 5)
            {
                previewg.DrawLine(p, cX, cY, x, y);
            }
            if (index == 6)
            {
                Point[] points = new Point[]
                {
                                new Point(cX, cY),
                                new Point(cX + sX, cY + sY),
                                new Point(cX - sX, cY + sY)
                };
                previewg.DrawPolygon(p, points);
            }
        }

        private void Btn_clear_Click(object sender, EventArgs e)
        {
            g.Clear(Color.White);
            pic.Image = bm;
            index = 0;
        }

        private void Btn_color_Click(object sender, EventArgs e)
        {
            cd.ShowDialog();
            new_color = cd.Color;
            pic_color.BackColor = cd.Color;
            p.Color = cd.Color;
        }

        private void Btn_save_Click(object sender, EventArgs e)
        {
            if (firstdialog == true)
            {
                if (pic.Image != null)
                {
                    sfd.Filter = "Image(*.jpg)|*.jpeg|(*.*|*.*'";
                    sfd.FileName = "image.jpg";

                    if (sfd.ShowDialog() == DialogResult.OK)
                    {
                        firstdialog = false;
                    }
                }
            }

            Bitmap btm = bm;
            btm.Save(sfd.FileName, ImageFormat.Bmp);
            pic.Image = btm;
            IsDocumentDirty = false;
        }

        private void Btn_load_Click(object sender, EventArgs e)
        {
            var ofd = new OpenFileDialog();
            ofd.Filter = "Image(*.jpg)|*.jpeg|(*.*|*.*'";
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                Bitmap bm = new Bitmap(ofd.FileName);
                pic.Image = bm;
                g = Graphics.FromImage(bm);
            }
        }

        private void Btn_triangle_Click(object sender, EventArgs e)
        {
            index = 6;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Btn_new_Click(object sender, EventArgs e)
        {
            g.Clear(Color.White);
            firstdialog = true;
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (IsDocumentDirty)
            {
                DialogResult result = MessageBox.Show("Do you want to save changes?", "Warning", MessageBoxButtons.YesNoCancel);
                if (result == DialogResult.Yes)
                {
                    Btn_save_Click(sender, e);
                }
                else if (result == DialogResult.Cancel)
                {
                    e.Cancel = true;
                }
            }
        }

        private void Btn_redo_Click(object sender, EventArgs e)
        {
            if (redoStack.Count > 0)
            {
                Bitmap redoBitmap = redoStack.Pop();
                undoStack.Push((Bitmap)bm.Clone());
                bm = redoBitmap;
                g = Graphics.FromImage(bm);
                pic.Image = bm;
                pic.Refresh();
            }
        }

        private void Btn_undo_Click(object sender, EventArgs e)
        {
            if (undoStack.Count > 1)
            {
                Bitmap undoBitmap = undoStack.Pop();
                redoStack.Push((Bitmap)bm.Clone());
                bm = undoStack.Peek();
                g = Graphics.FromImage(bm);
                pic.Image = bm;
                pic.Refresh();
            }
            else if (undoStack.Count == 1)
            {
                Bitmap undoBitmap = undoStack.Pop();
                redoStack.Push((Bitmap)bm.Clone());
                g.Clear(Color.White);
                pic.Image = bm;
                pic.Refresh();
            }
        }
    }

}
