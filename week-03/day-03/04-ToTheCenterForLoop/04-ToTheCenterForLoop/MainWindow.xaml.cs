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

namespace ToTheCenterForLoop
{

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

            for (int i = 0; i < 3; i++)
            {
                foxDraw.DrawLine(10*i, 20*i, 263, 175);
            }

        }
    }
}