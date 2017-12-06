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
using GreenFox;

namespace _04_To_the_center
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            var foxDraw = new FoxDraw(canvas);
            DrawThreeLines(foxDraw);
            // create a line drawing function that takes 2 parameters:
            // the x and y coordinates of the line's starting point
            // and draws a line from that point to the center of the canvas.
            // draw 3 lines with that function.

        }
        public static void DrawThreeLines(FoxDraw foxDraw)
        {
            foxDraw.StrokeColor(Colors.Green);
            
            var startPoint = new Point(0, 0);
            var endPoint = new Point(263, 175);
            foxDraw.DrawLine(startPoint, endPoint);

            foxDraw.StrokeColor(Colors.Red);

            var startPoint2 = new Point(0, 175);
            //var endPoint2 = new Point(263, 175);
            foxDraw.DrawLine(startPoint2, endPoint);

            foxDraw.StrokeColor(Colors.Yellow);

            var startPoint3 = new Point(0, 350);
            //var endPoint3 = new Point(263, 175);
            foxDraw.DrawLine(startPoint3, endPoint);

        }
    }
}
