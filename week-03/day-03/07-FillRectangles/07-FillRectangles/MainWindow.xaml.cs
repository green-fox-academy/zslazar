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

namespace _07_FillRectangles
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
            Draw4Rectangles(foxDraw);

        }
        
        // draw four different size and color rectangles.
        public static void Draw4Rectangles(FoxDraw foxDraw)
        {
            Random random = new Random();
            for (int i = 0; i < 4; i++)
            {

            foxDraw.DrawRectangle(
                (double)random.Next(100), 
                (double)random.Next(100),
                (double)random.Next(100), 
                (double)random.Next(100));

            foxDraw.FillColor(Color.FromRgb(
                (byte)random.Next(255), 
                (byte)random.Next(255), 
                (byte)random.Next(255)));
            }
        }

    }


}
