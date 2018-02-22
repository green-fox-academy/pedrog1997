using System;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;
using System.Windows.Shapes;

namespace _16_starryNight
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            SolidColorBrush[] colors = { Brushes.DarkGray, Brushes.DarkSlateGray, Brushes.FloralWhite, Brushes.GhostWhite, Brushes.Gray, Brushes.LightGray, Brushes.LightSlateGray, Brushes.NavajoWhite, Brushes.Silver, Brushes.SlateGray, Brushes.Snow, Brushes.White, Brushes.WhiteSmoke };
            Random randomInteger = new Random();

            for (int i = 0; i < 10000; i++)
            {
                int randomColor = randomInteger.Next(0, colors.Length - 1);
                double randomXPosition = RandomNumberBetween(0.00, canvas.Width);
                double randomYPosition = RandomNumberBetween(0.00, canvas.Height);
                CreateStar(randomXPosition, randomYPosition, colors[randomColor], canvas);
            }
        }

        public static void CreateStar(double x, double y, SolidColorBrush color, Canvas canvas)
        {
            var square = new Rectangle()
            {
                Width = 1,
                Height = 1,
                Fill = color,
            };
            Canvas.SetLeft(square, x);
            Canvas.SetTop(square, y);
            canvas.Children.Add(square);
        }

        private static readonly Random random = new Random();

        private static double RandomNumberBetween(double minValue, double maxValue)
        {
            var next = random.NextDouble();

            return minValue + (next * (maxValue - minValue));
        }
    }
}
