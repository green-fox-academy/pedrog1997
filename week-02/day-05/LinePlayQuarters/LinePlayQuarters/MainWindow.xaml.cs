using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;
using System.Windows.Shapes;

namespace LinePlayQuarters
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        public MainWindow()
        {
            InitializeComponent();
            int numberOfSquares = 1;

            double numberOfLines = 15;
            double spaceBetweenLines = (canvas.Width / ((numberOfSquares / 2) * numberOfLines + 1));

            double originX = 0;
            double originY = 0;


            for (int i = 0; i < numberOfSquares/2; i++)
            {
                for (int j = 0; j < numberOfSquares/2; j++)
                {
                    CreateSquare(originX, originY, spaceBetweenLines, numberOfSquares, numberOfLines, canvas);

                    originX += canvas.Width / (numberOfSquares / 2);
                    originY += 0;
                }

                originX = 0;
                originY += canvas.Width / (numberOfSquares / 2);
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

        public static void CreateSquare(double originX, double originY, double spaceBetweenLines, double numberOfSquares, double numberOfLines, Canvas canvas)
        {
            double x1 = 0 + originX;
            double y1 = 0 + originY;
            double x2 = spaceBetweenLines + originX;
            double y2 = (canvas.Height / (numberOfSquares / 2)) + originY;

            for (int i = 0; i < numberOfLines; i++)
            {
                CreateLine(x1, y1, x2, y2, Brushes.Green, canvas);
                CreateLine(x2, originY, (canvas.Width / (numberOfSquares / 2)) + originX, y1 + spaceBetweenLines, Brushes.Purple, canvas);

                y1 += spaceBetweenLines;
                x2 += spaceBetweenLines;
            }

        }
    }
}
