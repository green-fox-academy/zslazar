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

namespace _11_PurpleSteps
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
            DrawSquares(foxDraw);
        }

        public static void DrawSquares(FoxDraw foxDraw)
        {
            foxDraw.FillColor(Colors.Purple);

            for (int i = 0; i < 19; i++)
            {
                foxDraw.DrawRectangle(i * 10, i * 10, 10, 10);
            }
        }
    }
}
