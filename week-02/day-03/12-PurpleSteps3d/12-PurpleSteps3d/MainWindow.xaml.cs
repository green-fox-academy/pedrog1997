using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;
using System.Windows.Shapes;

namespace _12_PurpleSteps3d
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            double x = 20;
            double size = 20;

            for (int i = 0; i < 6; i++)
            {
                SquareDrawing(x, size, canvas);
                x += size;
                size += 20;
            }
        }

        public static void SquareDrawing(double x, double size, Canvas canvas)
        {
            var square = new Rectangle()
            {
                Height = size,
                Width = size,
                Stroke = Brushes.Purple,
                Fill = Brushes.Purple
            };
            Canvas.SetLeft(square, x);
            Canvas.SetTop(square, x);
            canvas.Children.Add(square);
        }
    }
}
