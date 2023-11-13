using System;
using System.Drawing;
using System.Windows.Forms;

namespace Bai2._4
{
    public partial class Form1 : Form
    {
        Random random = new Random();

        public Form1()
        {
            InitializeComponent();
            this.Paint += new PaintEventHandler(Form1_Paint);
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            int width = this.ClientSize.Width;
            int height = this.ClientSize.Height;
            e.Graphics.Clear(this.BackColor);
            int x = random.Next(0, width);
            int y = random.Next(0, height);
            e.Graphics.DrawString("Paint Event", new Font("Arial", 16), Brushes.Black, new Point(x, y));
        }
    }
}
