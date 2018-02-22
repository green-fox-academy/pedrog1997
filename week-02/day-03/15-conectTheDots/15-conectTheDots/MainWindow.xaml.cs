using System.Collections.Generic;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;
using System.Windows.Shapes;

namespace _15_conectTheDots
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            // Create a function that takes 1 parameter:
            // A list of (x, y) points
            // and connects them with green lines.

            var points = new List<Point> { new Point(10, 10), new Point(290, 10), new Point(290, 290), new Point(10, 290) };
            var points2 = new List<Point> { new Point(50, 100), new Point(70, 70), new Point(80, 90), new Point(90, 90), new Point(100, 70), new Point(120, 100), new Point(85, 130), new Point(50, 100) };

            ConnectDots(points2, canvas);
        }

        public static void ConnectDots(List<Point> Dots, Canvas canvas)
        {
            for (int i = 0; i < Dots.Count; i++)
            {
                int j;
                if (i + 1 >= Dots.Count)
                {
                    j = 0;
                }
                else
                {
                    j = i + 1;
                }
                var line = new Line()
                {
                    Stroke = Brushes.Green,
                    X1 = Dots[i].X,
                    Y1 = Dots[i].Y,
                    X2 = Dots[j].X,
                    Y2 = Dots[j].Y
                };
                canvas.Children.Add(line);
            }
        }
    }
}
