using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;
using System.Windows.Shapes;

namespace _06_centerdSquare
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            // Draw a green 10x10 square to the canvas' center.
            
            var square = new Rectangle()
            {
                Width = 10,
                Height = 10,
                Stroke = Brushes.Green,
                Fill = Brushes.Green
            };

            Canvas.SetLeft(square, canvas.Width/2 -5);
            Canvas.SetTop(square, canvas.Height/2 -5);
            canvas.Children.Add(square);
        }
    }
}
