using System.Drawing.Drawing2D;

namespace WinFormsDrawing10jan2024
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            // https://www.makeuseof.com/c-sharp-windows-form-graphics/
            Color black = Color.FromArgb(255, 0, 0, 0);
            Pen blackPen = new Pen(black);

            // The DrawLine() method from the Graphics class will draw a line using the pen.
            // This will start drawing a line from an x, y position to another x, y position.
            e.Graphics.DrawLine(blackPen, 300, 200, 800, 200);

            blackPen.Width = 20;
            blackPen.DashStyle = DashStyle.Dash;
            blackPen.StartCap = LineCap.ArrowAnchor;
            e.Graphics.DrawLine(blackPen, 300, 200, 800, 200);

            // You can use the shapes classes for different shapes, or draw shapes manually onto the canvas.

            // Create a Color and Pen object as shown in the previous steps.
            // Then, use the DrawRectangle() method to create the rectangle.
            // The arguments are the x and y coordinates for the top-left of the rectangle, along with its width and height.
            Color red = Color.FromArgb(255, 255, 0, 0);
            Pen redPen = new Pen(red);
            redPen.Width = 5;
            e.Graphics.DrawRectangle(redPen, 100, 100, 500, 200);

            // You can also create a rectangle using the Rectangle Class.
            // First, create a Rectangle object.
            // The arguments are also the x and y coordinates for the top-left corner, width, and height.
            Rectangle rectangle = new Rectangle(100, 350, 500, 200);

            // Use the DrawRectangle() function to draw the rectangle.
            // Instead of passing the x, y, width, and height like before, you can use the Rectangle object instead.
            e.Graphics.DrawRectangle(redPen, rectangle);

            // Use the DrawEllipse() function to draw a circle.
            Color green = Color.FromArgb(255, 0, 255, 0);
            Pen greenPen = new Pen(green);
            greenPen.Width = 5;
            e.Graphics.DrawEllipse(greenPen, 400, 150, 400, 400);
            // When you draw a circle, the x and y coordinates (x=400, y=150) refer to the top-left corner of the circle, not the center of the circle.

            // To draw other shapes such as triangles or hexagons, use the DrawPolygon() method.
            // Here you can specify a list of coordinates to represent the points of the shape.
            Color blue = Color.FromArgb(255, 0, 0, 255);
            Pen bluePen = new Pen(blue);
            bluePen.Width = 5;

            PointF[] coordinatesForTriangle = new PointF[] {
    new PointF(400, 150),
    new PointF(300, 300),
    new PointF(500, 300)
};

            e.Graphics.DrawPolygon(bluePen, coordinatesForTriangle);

            // You can use the FillRectangle(), FillEllipses() or FillTriangle() methods to create shapes with a solid color.
            Color purple = Color.FromArgb(255, 128, 0, 0);
            SolidBrush solidBrush = new SolidBrush(purple);

            e.Graphics.FillRectangle(solidBrush, 50, 50, 200, 250);
            e.Graphics.FillEllipse(solidBrush, 300, 50, 200, 200);
            e.Graphics.FillPolygon(solidBrush, new PointF[] { new PointF(700, 150), new PointF(600, 300), new PointF(800, 300) });

            Rectangle rectangle2 = new Rectangle(100, 350, 500, 200);
            e.Graphics.FillRectangle(solidBrush, rectangle2);

            // Use the HatchBrush to fill the shape using a different fill style, such as a horizontal or vertical pattern.
            Color blue2 = Color.FromArgb(255, 0, 0, 255);
            Color green2 = Color.FromArgb(255, 0, 255, 0);
            HatchBrush hatchBrush = new HatchBrush(HatchStyle.Horizontal, green2, blue2);
            e.Graphics.FillRectangle(hatchBrush, 50, 50, 200, 250);

            // You can use the TextureBrush to fill a shape using an image.
            // Here, create a bitmap by pointing to an image file.
            // Instead of creating a brush using a color, create it using the image.
            Bitmap image = (Bitmap)Image.FromFile(@"..\..\..\cat.bmp", true);
            TextureBrush textureBrush = new TextureBrush(image);
            e.Graphics.FillRectangle(textureBrush, 100, 100, 500, 400);

            // To render an image, create a PictureBox control object and add it to the form.
            PictureBox picture = new PictureBox();
            picture.ImageLocation = @"..\..\..\cat.bmp";

            // Set the size of the image and add it onto the form so it renders.
            picture.SizeMode = PictureBoxSizeMode.AutoSize;
            this.Controls.Add(picture);
        }
    }
}