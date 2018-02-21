using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;
using System.Windows.Shapes;

namespace _08_positionSquare
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            // create a square drawing function that takes 2 parameters:
            // the x and y coordinates of the square's top left corner
            // and draws a 50x50 square from that point.
            // draw 3 squares with that function.
            // avoid code duplication.   

            int[] x = { 100, 200, 300 };
            int y = 150;

            for (int i = 0; i < 3; i++)
            {
                squareDrawing(x[i], y, canvas);
            }
        }

        public static void squareDrawing(double x, double y, Canvas canvas)
        {
            var square = new Rectangle()
            {
                Width = 50,
                Height = 50,
                Stroke = Brushes.Black
            };
            Canvas.SetLeft(square, x);
            Canvas.SetTop(square, y);
            canvas.Children.Add(square);
        }
    }
}
