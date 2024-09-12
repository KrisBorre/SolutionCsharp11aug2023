namespace WinFormsDrawing12may2024
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            // Draw a Bezier curve from four control points
            Pen curvePen = new Pen(Color.Purple, 4);
            e.Graphics.DrawBezier(curvePen, new Point(100, 200), new Point(200, 100), new Point(300, 300), new Point(400, 200));

            // Draw an arc representing a portion of an ellipse
            e.Graphics.DrawArc(curvePen, 500, 100, 200, 150, 45, 270);

            Font drawFont = new Font("Arial", 16);
            SolidBrush textBrush = new SolidBrush(Color.Black);
            e.Graphics.DrawString("My Shape Drawing", drawFont, textBrush, new PointF(50, 20));
        }
    }
}
