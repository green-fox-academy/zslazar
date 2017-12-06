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

namespace _09_CenteredBoxes
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
            double Size = 200;
            CenterSquares(foxDraw, Size);

            // create a square drawing function that takes 1 parameter:
            // the square size
            // and draws a square of that size to the center of the canvas.
            // draw 3 squares with that function.

        }

        public static void CenterSquares(FoxDraw foxDraw, double Size)
        {
                        
            for (int i = 1; i < 4; i++)
            {
                foxDraw.DrawRectangle(200 - Size/2, 200 - Size/2, Size, Size);
                Size = Size - 50;
            }
        }

    }
}
