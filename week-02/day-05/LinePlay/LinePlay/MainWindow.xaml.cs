using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;
using System.Windows.Shapes;

namespace LinePlay
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            int numberOfLines = 20;
            double spaceBetweenLines = (canvas.Height-40) / numberOfLines;
            double x1 = 20;
            double y1 = 20;
            double x2 = spaceBetweenLines;
            double y2 = spaceBetweenLines;

            for (int i = 0; i < numberOfLines; i++)
            {
                CreateLine(0, y1, x2, canvas.Height, Brushes.Green, canvas);
                y1 += spaceBetweenLines;
                x2 += spaceBetweenLines;

                CreateLine(x1, 0, canvas.Width, y2, Brushes.Purple, canvas);
                x1 += spaceBetweenLines;
                y2 += spaceBetweenLines;
            }
        }

        public static void CreateLine(double x1, double y1, double x2, double y2, SolidColorBrush color, Canvas canvas)
        {
            var line = new Line()
            {
                Stroke = color,
                X1 = x1,
                Y1 = y1,
                X2 = x2,
                Y2 = y2
            };
            canvas.Children.Add(line);
        }
    }
}
