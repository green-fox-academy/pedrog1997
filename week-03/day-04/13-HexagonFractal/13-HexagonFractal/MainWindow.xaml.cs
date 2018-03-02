using System;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;
using System.Windows.Shapes;

namespace _13_HexagonFractal
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            CreateHexagon(10, new Point(100, 350), 250, canvas);
        }

        static void CreateHexagon(int levelOfAbstraction, Point hexagonOrigin, double size, Canvas canvas)
        {
            if (levelOfAbstraction == 1)
            {
                PointCollection hexagonPoints = new PointCollection()
                    {
                    hexagonOrigin,
                    new Point(hexagonOrigin.X + size/2, hexagonOrigin.Y + (size/2)*Math.Tan(Math.PI/3)),
                    new Point(hexagonOrigin.X + (3.0/2.0)*size, hexagonOrigin.Y + (size/2)*Math.Tan(Math.PI/3)),
                    new Point(hexagonOrigin.X + 2*size, hexagonOrigin.Y),
                    new Point(hexagonOrigin.X + (3.0/2.0)*size, hexagonOrigin.Y - (size/2)*Math.Tan(Math.PI/3)),
                    new Point(hexagonOrigin.X + size/2, hexagonOrigin.Y - (size/2)*Math.Tan(Math.PI/3))
                    };

                var hexagon = new Polygon()
                {
                    Stroke = Brushes.Black,
                    Points = hexagonPoints
                };
                canvas.Children.Add(hexagon);
            }
            else
            {
                PointCollection hexagonPoints = new PointCollection()
                {
                hexagonOrigin,
                new Point(hexagonOrigin.X + size/2, hexagonOrigin.Y + (size/2)*Math.Tan(Math.PI/3)),
                new Point(hexagonOrigin.X + (3.0/2.0)*size, hexagonOrigin.Y + (size/2)*Math.Tan(Math.PI/3)),
                new Point(hexagonOrigin.X + 2*size, hexagonOrigin.Y),
                new Point(hexagonOrigin.X + (3.0/2.0)*size, hexagonOrigin.Y - (size/2)*Math.Tan(Math.PI/3)),
                new Point(hexagonOrigin.X + size/2, hexagonOrigin.Y - (size/2)*Math.Tan(Math.PI/3))
                };

                var hexagon = new Polygon()
                {
                    Stroke = Brushes.Black,
                    Points = hexagonPoints
                };
                canvas.Children.Add(hexagon);

                PointCollection pointsForNextHexagons = new PointCollection()
                {
                new Point(hexagonOrigin.X + size/4, hexagonOrigin.Y + (size/4)*Math.Tan(Math.PI/3)),
                new Point(hexagonOrigin.X + size, hexagonOrigin.Y),
                new Point(hexagonOrigin.X + size/4, hexagonOrigin.Y - (size/4)*Math.Tan(Math.PI/3))
                };

                CreateHexagon(levelOfAbstraction - 1, pointsForNextHexagons[0], size / 2, canvas);
                CreateHexagon(levelOfAbstraction - 1, pointsForNextHexagons[1], size / 2, canvas);
                CreateHexagon(levelOfAbstraction - 1, pointsForNextHexagons[2], size / 2, canvas);
            }
        }
    }
}
