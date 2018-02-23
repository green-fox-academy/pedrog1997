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

namespace Triangles
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            int numberOfTriangles = 21;
            double smallTriangleBase = canvas.Width / numberOfTriangles;
            double spaceBetweenLines = (smallTriangleBase / 2) * Math.Tan((Math.PI) / 3);
            double xCenter = canvas.Width / 2;

            double x1Base = 0;
            double yBase = canvas.Height;
            double x2Base = canvas.Width;
            double x1Right = 0;
            double y1 = canvas.Height;
            double x2Right = xCenter;
            double y2 = canvas.Height - spaceBetweenLines * numberOfTriangles;
            double x1Left = canvas.Width;
            double x2Left = xCenter;

            for (int i = 0; i < numberOfTriangles; i++)
            {
                CreateLine(x1Base, yBase, x2Base, yBase, canvas);
                CreateLine(x1Right, y1, x2Right, y2, canvas);
                CreateLine(x1Left, y1, x2Left, y2, canvas);

                x1Base += smallTriangleBase / 2;
                yBase -= spaceBetweenLines;
                x2Base -= smallTriangleBase / 2;
                x1Right += smallTriangleBase;
                x2Right += smallTriangleBase / 2;
                y2 += spaceBetweenLines;
                x1Left -= smallTriangleBase;
                x2Left -= smallTriangleBase / 2;
            }
            

        }

        public static void CreateLine(double x1, double y1, double x2, double y2, Canvas canvas)
        {
            var line = new Line()
            {
                Stroke = Brushes.Black,
                X1 = x1,
                Y1 = y1,
                X2 = x2,
                Y2 = y2
            };
            canvas.Children.Add(line);
        }
    }
}
