using System;
using System.Windows;
using System.Windows.Media;

namespace _02_coloredBox
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
            // Draw a box that has different colored lines on each edge. 

            foxDraw.StrokeColor(Colors.Green);
            foxDraw.DrawLine(100, 100, canvas.Width - 100, 100);
            foxDraw.StrokeColor(Colors.Red);
            foxDraw.DrawLine(canvas.Width - 100, 100, canvas.Width - 100, canvas.Height - 100);
            foxDraw.StrokeColor(Colors.Purple);
            foxDraw.DrawLine(canvas.Width - 100, canvas.Height - 100, 100, canvas.Height - 100);
            foxDraw.StrokeColor(Colors.Plum);
            foxDraw.DrawLine(100, canvas.Height - 100, 100, 100);
        }
    }
}
