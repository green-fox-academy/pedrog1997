using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;
using System.Windows.Shapes;

namespace _07_fourRectangles
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            // draw four different size and color rectangles.
            // avoid code duplication.

            SolidColorBrush[] colors = new SolidColorBrush[] { Brushes.Black, Brushes.Blue, Brushes.Green, Brushes.Indigo };
            int[] position = { 0, 75, 200, 400 };


            for (int i = 0; i < 4; i++)
            {
                var rectangle = new Rectangle()
                {
                    //Stroke = Brushes.Black,
                    Height = 50*i+35,
                    Width = 100*i+20,
                    Fill = colors[i],
                };
                Canvas.SetLeft(rectangle, position[i]);
                Canvas.SetTop(rectangle, position[i]);
                canvas.Children.Add(rectangle);

            }
        }
    }
}
