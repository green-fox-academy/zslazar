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

namespace _02_ColoredBox
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
            DrawBox(foxDraw);            
        }
            // draw a box that has different colored lines on each edge.

        public static void DrawBox(FoxDraw foxDraw)
        {
            foxDraw.StrokeColor(Colors.Turquoise);
            foxDraw.DrawLine(10, 20, 100, 20);

            foxDraw.StrokeColor(Colors.Aqua);
            foxDraw.DrawLine(100, 20, 100, 40);

            foxDraw.StrokeColor(Colors.PowderBlue);
            foxDraw.DrawLine(100, 40, 10, 40);

            foxDraw.StrokeColor(Colors.AliceBlue);
            foxDraw.DrawLine(10, 40, 10, 20);
        }
    }
}
