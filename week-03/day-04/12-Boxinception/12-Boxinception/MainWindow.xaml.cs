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

namespace _12_Boxinception
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        public MainWindow()
        {
            InitializeComponent();
            Boxinception(6, new Point(250, 100), 500, canvas);
        }

        static void Boxinception(int level, Point boxOrigin, double size, Canvas canvas)
        {
            var box = new Rectangle()
            {
                Stroke = Brushes.Black,
                StrokeThickness = 0.75,
                Width = size,
                Height = size
            };
            Canvas.SetLeft(box, boxOrigin.X);
            Canvas.SetTop(box, boxOrigin.Y);
            canvas.Children.Add(box);

            Point[] pointsOfBoxes =
                {
                new Point(boxOrigin.X, boxOrigin.Y + size/3),
                new Point(boxOrigin.X + size/3.0, (boxOrigin.Y + (2.0/3.0)*size)),
                new Point(boxOrigin.X + (2.0/3.0)*size, boxOrigin.Y + size/3.0),
                new Point(boxOrigin.X + size/3.0, boxOrigin.Y)
            };
            if (level != 1)
            {
            size /= 3;

            Boxinception(level - 1, pointsOfBoxes[0], size, canvas);
            Boxinception(level - 1, pointsOfBoxes[1], size, canvas);
            Boxinception(level - 1, pointsOfBoxes[2], size, canvas);
            Boxinception(level - 1, pointsOfBoxes[3], size, canvas);

            }

        }
    }
}
