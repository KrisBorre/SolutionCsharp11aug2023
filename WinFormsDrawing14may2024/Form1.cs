namespace WinFormsDrawing14may2024
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            Bitmap image = (Bitmap)Image.FromFile(@"..\..\..\cat.bmp");
            image.RotateFlip(RotateFlipType.Rotate90FlipNone); // Rotate image 90 degrees
            e.Graphics.DrawImage(image, new Rectangle(100, 100, 300, 300)); // Draw the rotated image

            Pen customPen = new Pen(Color.Orange, 3);
            Point[] hexagonPoints = {
                new Point(150, 100),
                new Point(250, 100),
                new Point(300, 150),
                new Point(250, 200),
                new Point(150, 200),
                new Point(100, 150)
            };
            e.Graphics.DrawPolygon(customPen, hexagonPoints);
        }
    }
}
