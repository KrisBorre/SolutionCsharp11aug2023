using System.Diagnostics;
using System.Drawing.Drawing2D;
using System.Reflection;

namespace WinFormsDrawing13may2024
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            Rectangle gradientRect = new Rectangle(0, 0, 800, 600);
            LinearGradientBrush linearGradientBrush = new LinearGradientBrush(gradientRect, Color.Blue, Color.White, 45);
            e.Graphics.FillRectangle(linearGradientBrush, gradientRect);

            foreach (var r in Assembly.GetEntryAssembly().GetReferencedAssemblies())
            {
                var a = Assembly.Load(new AssemblyName(r.FullName));
                int methodCount = 0;

                foreach (var t in a.DefinedTypes)
                {
                    if (t.IsClass && t.GetMethods().Any(m => m.Name.Contains("Draw")))
                    {
                        Debug.WriteLine($"Class '{t.Name}' contains drawing methods.");
                    }

                    methodCount += t.GetMethods().Count();
                }

                Debug.WriteLine($"{a.DefinedTypes.Count():N0} types with {methodCount:N0} methods in {r.Name} assembly.");
            }

        }
    }
}
