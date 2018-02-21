using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;
using System.Windows.Shapes;

namespace _04_goToCenter
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            // Create a line drawing function that takes 2 parameters:
            // The x and y coordinates of the line's starting point
            // and draws a line from that point to the center of the canvas.
            // Draw 3 lines with that function. Use loop for that.

            for (int i = 0; i < 3; i++)
            {
                LineToCenter(0, 100 * i, canvas);
            }

        } 

        public static void LineToCenter(double x, double y, Canvas canvas)
        {
            var line = new Line()
            {
                X1 = x,
                Y1 = y,
                X2 = canvas.Width / 2,
                Y2 = canvas.Height / 2
            };
            line.Stroke = Brushes.Black;
            line.StrokeThickness = 2;
            canvas.Children.Add(line);
        }
    }
}
