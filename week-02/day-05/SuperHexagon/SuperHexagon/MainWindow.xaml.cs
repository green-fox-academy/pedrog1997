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

namespace SuperHexagon
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            var startingPoint = new Point(150, 200);
            double sideOfHexagon = 30;
            for (int i = 0; i < 4; i++)
            {
                RowOfHexagons(i + 4, startingPoint, sideOfHexagon, canvas);
                startingPoint.X += sideOfHexagon + 0.5 * sideOfHexagon;
                startingPoint.Y -= sideOfHexagon * Math.Sin((Math.PI) / 3);
            }
            startingPoint.Y += 2*sideOfHexagon * Math.Sin((Math.PI) / 3);
            for (int i = 4 - 1; i > 0; i--)
            {
                RowOfHexagons(i + 3, startingPoint, sideOfHexagon, canvas);
                startingPoint.X += sideOfHexagon + 0.5 * sideOfHexagon;
                startingPoint.Y += sideOfHexagon * Math.Sin((Math.PI) / 3);
            }
        }

        public static void MakeHexagon(Point originOfHexagon, double sideOfHexagon, Canvas canvas)
        {
            PointCollection pointsOfHexagon = new PointCollection
            {
                new Point { X = originOfHexagon.X, Y = originOfHexagon.Y},
                new Point {X = originOfHexagon.X + sideOfHexagon, Y = originOfHexagon.Y},
                new Point {X = originOfHexagon.X + 1.5 * sideOfHexagon, Y = originOfHexagon.Y + sideOfHexagon * Math.Sin((Math.PI)/3)},
                new Point {X = originOfHexagon.X + sideOfHexagon, Y = originOfHexagon.Y + 2 * sideOfHexagon * Math.Sin((Math.PI)/3)},
                new Point {X = originOfHexagon.X, Y = originOfHexagon.Y + 2 * sideOfHexagon * Math.Sin((Math.PI)/3)},
                new Point {X = originOfHexagon.X - 0.5 * sideOfHexagon, Y = originOfHexagon.Y + sideOfHexagon * Math.Sin((Math.PI)/3)}
            };

            var hexagon = new Polygon()
            {
                Points = pointsOfHexagon,
                Stroke = Brushes.Black
            };
            canvas.Children.Add(hexagon);
        }

        public static void RowOfHexagons(int numberOfHexagons, Point startingPoint, double sideOfHexagon, Canvas canvas)
        {
            for (int i = 0; i < numberOfHexagons; i++)
            {
                MakeHexagon(startingPoint, sideOfHexagon, canvas);
                startingPoint.Y += 2 * sideOfHexagon * Math.Sin((Math.PI) / 3);
            }

        }
    }
}
