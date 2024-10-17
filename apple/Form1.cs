using System.Drawing.Drawing2D;

namespace apple
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int x = 10, y = 10, w = 100, h = 100;
        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;

            g.FillEllipse(Brushes.Red, x + w * 10 / 500, y + h * 100 / 500, w * 200 / 500, h * 200 / 500);
            g.FillEllipse(Brushes.Red, x +  w * 100 / 500, y + h* 100 / 500, w * 200 / 500, h * 200 / 500);
            g.FillPolygon(Brushes.Black, new Point[] {
                new Point(x + w * 150/500, y+ h*120/500),
                new Point(x + w* 170/500,y + h* 10/500),
                new Point(x + w* 180/500,y + h* 20/500),
                new Point(x + w* 160/500,y + h* 120/500) });
        }

        private void Form1_SizeChanged(object sender, EventArgs e)
        {
            x = ClientSize.Width/4;
            y = ClientSize.Height /4;
            w = Math.Min(this.ClientSize.Width, this.ClientSize.Height);
            h = Math.Min(this.ClientSize.Width, this.ClientSize.Height);
            Invalidate();
        }
    }
}
