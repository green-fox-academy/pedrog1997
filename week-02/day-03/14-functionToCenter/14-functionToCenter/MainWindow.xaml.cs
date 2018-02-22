using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;
using System.Windows.Shapes;

namespace _14_functionToCenter
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            // create a line drawing function that takes 2 parameters:
            // the x and y coordinates of the line's starting point
            // and draws a line from that point to the center of the canvas.
            // fill the canvas with lines from the edges, every 20 px, to the center.

            double x = 0;
            double y = 0;
            double x2 = canvas.Width;
            double y2 = canvas.Height;

            while (x < canvas.Width)
            {
                LineDrawing(x, 0, canvas);
                LineDrawing(0, y, canvas);
                x += 20;
                y += 20;
                LineDrawing(x2, canvas.Height, canvas);
                LineDrawing(canvas.Width, y2, canvas);
                x2 -= 20;
                y2 -= 20;
            }
        }

        public static void LineDrawing(double x, double y, Canvas canvas)
        {
            var line = new Line()
            {
                X1 = x,
                Y1 = y,
                X2 = canvas.Width / 2,
                Y2 = canvas.Height / 2,
                Stroke = Brushes.Black
            };
            canvas.Children.Add(line);
        }
    }
}
