using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;
using System.Windows.Shapes;

namespace _13_checkerBoard
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            double size = canvas.Width / 8;
            double x = 0;
            double y = 0;

            for (int i = 0; i < 8; i++)
            {
                for (int j = 0; j < 8; j++)
                {
                    if ((i + j) % 2 == 0)
                    {
                        DrawSquare(x, y, Brushes.Brown, canvas);
                    }
                    else
                    {
                        DrawSquare(x, y, Brushes.LightYellow, canvas);
                    }
                    x += size;
                }
                x = 0;
                y += size;
            }
        }

        public static void DrawSquare(double x, double y, SolidColorBrush color, Canvas canvas)
        {
            var square = new Rectangle()
            {
                Width = canvas.Width / 8,
                Height = canvas.Height / 8,
                Fill = color
            };
            Canvas.SetRight(square, x);
            Canvas.SetTop(square, y);
            canvas.Children.Add(square);
        }
    }
}
