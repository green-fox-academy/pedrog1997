using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace _10_rainbowFunction
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            // Create a square drawing function that takes 2 parameters:
            // The square size, and the fill color,
            // and draws a square of that size and color to the center of the canvas.
            // Create a loop that fills the canvas with rainbow colored squares.

            SolidColorBrush[] colors = 
                {
                Brushes.Red,
                Brushes.Orange,
                Brushes.Yellow,
                Brushes.Green,
                Brushes.Blue,
                Brushes.Indigo,
                Brushes.Violet
            };
            double size = canvas.Height / 7;
            double x = 0;
            double y = 0;
            int index = 0;

            for (int i = 0; i < 7; i++)
            {
                for (int j = 0; j < 7; j++)
                {
                    SquareDrawing(x, y, colors[index], canvas);
                    x += size;
                    if (index == 6)
                    {
                        index = 0;
                    }
                    else
                    {
                        index++;
                    }
                }
                index = i + 1;
                y += size;
                x = 0;
            }
        }

        public static void SquareDrawing(double x, double y, SolidColorBrush color, Canvas canvas)
        {
            double size = canvas.Height / 7;
            var square = new Rectangle()
            {
                Height = size,
                Width = size,
                Stroke = color,
                Fill = color
            };
            Canvas.SetLeft(square, x);
            Canvas.SetTop(square, y);
            canvas.Children.Add(square);
        }
    }
}
