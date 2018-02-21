using System.Windows;
using System.Windows.Media;


namespace WpfApp2
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

            // draw a red horizontal line to the canvas' middle.
            // draw a green vertical line to the canvas' middle.

            foxDraw.StrokeColor(Colors.Red);
            foxDraw.DrawLine(0, (canvas.Height / 2), canvas.Width, (canvas.Height/2));

            foxDraw.StrokeColor(Colors.Green);
            foxDraw.DrawLine(canvas.Width / 2, 0, canvas.Width / 2, canvas.Height);
        }
    }
}
