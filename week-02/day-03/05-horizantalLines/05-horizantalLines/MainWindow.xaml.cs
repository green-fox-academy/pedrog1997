using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;
using System.Windows.Shapes;

namespace _05_horizantalLines
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
            // and draws a 50 long horizontal line from that point.
            // Draw 3 lines with that function. Use loop for that.

            for (int i = 0; i < 3; i++)
            {
                HorizontalLines(100 * i +50, 100 * i +50, canvas);
            }
        }

        public static void HorizontalLines(double x, double y, Canvas canvas)
        {
            var line = new Line()
            {
                X1 = x,
                Y1 = y,
                X2 = x + 50,
                Y2 = y,
                Stroke = Brushes.Black
            };
            canvas.Children.Add(line);
        }
    }
}
