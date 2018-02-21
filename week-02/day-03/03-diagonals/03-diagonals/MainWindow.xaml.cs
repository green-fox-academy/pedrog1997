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

namespace _03_diagonals
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            var foxDraw = new FoxDraw(canvas);
            // Draw the canvas' diagonals.
            // If it starts from the upper-left corner it should be green, otherwise it should be red.
            Point topLeftCorner = new Point(0, 0);
            Point topRightCorner = new Point(canvas.Width, 0);
            Point lowerLeftCorner = new Point(0, canvas.Height);
            Point lowerRightCorner = new Point(canvas.Width, canvas.Height);

            foxDraw.StrokeColor(Colors.Green);
            foxDraw.DrawLine(topLeftCorner, lowerRightCorner);
            foxDraw.StrokeColor(Colors.Red);
            foxDraw.DrawLine(topRightCorner, lowerLeftCorner);
        }
    }
}
