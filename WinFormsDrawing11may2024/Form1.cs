using System.Drawing.Drawing2D;

namespace WinFormsDrawing11may2024
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            // Create a red pen with a solid line and a blue pen with a dashed line
            Pen solidRedPen = new Pen(Color.Red, 5);
            Pen dashedBluePen = new Pen(Color.Blue, 5) { DashStyle = DashStyle.Dash };

            // Draw a solid red rectangle and a dashed blue ellipse
            e.Graphics.DrawRectangle(solidRedPen, 50, 50, 200, 150);
            e.Graphics.DrawEllipse(dashedBluePen, 300, 50, 200, 150);

            // Combine hatch and solid fills on a new shape
            HatchBrush hatchBrush2 = new HatchBrush(HatchStyle.Vertical, Color.Green, Color.Yellow);
            e.Graphics.FillEllipse(hatchBrush2, 100, 250, 200, 150);
        }
    }
}
