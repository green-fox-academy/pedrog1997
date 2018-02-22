using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;
using System.Windows.Shapes;

namespace _11_purpleSteps
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            // Reproduce this:
            // [https://github.com/greenfox-academy/teaching-materials/blob/master/workshop/drawing/purple-steps/r3.png]

            double size = canvas.Width / 19;
            double x = 0;
            double y = 0;
            for (int i = 0; i < 20; i++)
            {
                SquareDrawing(x, y, canvas);
                x += size;
                y += size;
            }

        }
        public static void SquareDrawing(double x, double y, Canvas canvas)
        {
            double size = canvas.Height / 19;
            var square = new Rectangle()
            {
                Height = size,
                Width = size,
                Stroke = Brushes.Purple,
                Fill = Brushes.Purple
            };
            Canvas.SetLeft(square, x);
            Canvas.SetTop(square, y);
            canvas.Children.Add(square);
        }
    }
}
