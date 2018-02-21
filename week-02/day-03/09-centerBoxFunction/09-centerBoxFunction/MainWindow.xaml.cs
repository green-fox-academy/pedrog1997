using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;
using System.Windows.Shapes;

namespace _09_centerBoxFunction
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            // create a square drawing function that takes 1 parameter:
            // the square size
            // and draws a square of that size to the center of the canvas.
            // draw 3 squares with that function.
            // avoid code duplication.
            int[] size = { 100, 200, 400 };
            for (int i = 0; i < 3; i++)
            {
                SquareDrawing(size[i], canvas);
            }
        }

        public static void SquareDrawing(double size, Canvas canvas)
        {
            var square = new Rectangle()
            {
                Width = size,
                Height = size,
                Stroke = Brushes.Black
            };
            Canvas.SetLeft(square, canvas.Width / 2 - size / 2);
            Canvas.SetTop(square, canvas.Height / 2 - size / 2);
            canvas.Children.Add(square);
        }
    }
}
