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

namespace EnvelopeStar
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            int numberOfLines =20;
            double spaceBetweenLines = canvas.Width / (numberOfLines * 2);
            double center = canvas.Width/2;

            double x1 = center;
            double y1Top = 0;
            double y1Bottom = canvas.Height;
            double x2Right = center;
            double x2Left = center;
            double y2 = center;

            for (int i = 0; i < numberOfLines; i++)
            {
                CreateLine(center, y1Top, x2Right, center, canvas);
                CreateLine(center, y1Top, x2Left, center, canvas);
                CreateLine(center, y1Bottom, x2Left, center, canvas);
                CreateLine(center, y1Bottom, x2Right, center, canvas);
                y1Top += spaceBetweenLines;
                y1Bottom -= spaceBetweenLines;
                x2Right += spaceBetweenLines;
                x2Left -= spaceBetweenLines;

            }
        }

        public static void CreateLine(double x1, double y1, double x2, double y2, Canvas canvas)
        {
            var line = new Line()
            {
                Stroke = Brushes.Green,
                X1 = x1,
                Y1 = y1,
                X2 = x2,
                Y2 = y2
            };
            canvas.Children.Add(line);
        }
    }
}
