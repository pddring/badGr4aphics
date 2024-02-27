using System.Numerics;
using System.Text.RegularExpressions;

namespace badGr4aphics
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void leftRotate_Click(object sender, EventArgs e)
        {

        }

        private void updateButton_Click(object sender, EventArgs e)
        {
            Redraw();
        }

        private void Redraw()
        {
            SolidBrush brush = new SolidBrush(Color.Red);
            Bitmap bmp = new Bitmap(renderBox.Width, renderBox.Height);
            using (Graphics g = Graphics.FromImage(bmp))
            {
                foreach(Face f in model.faces)
                {
                    foreach(Vertex v in f.vertices)
                    {
                        int x = (int)((v.X + 1) * renderBox.Width / 2);
                        int y = (int)((v.Y + 1) * renderBox.Height / 2);
                        g.FillEllipse(brush, x, y, 5, 5);
                    }
                }
                
            }

            renderBox.BackgroundImage = bmp;
        }

        STL3DModel model = new STL3DModel();

        private void buttonLoad_Click(object sender, EventArgs e)
        {
            
            OpenFileDialog dlg = new OpenFileDialog();
            if(dlg.ShowDialog() != DialogResult.OK)
            {
                return;
            }

            model.LoadSTLFile(dlg.FileName);
            
            Redraw();
        }
    }
}