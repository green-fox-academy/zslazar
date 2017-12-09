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

namespace _12_Steps3D
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
            DrawRectangle(foxDraw);
        }

        public static void DrawRectangle(FoxDraw foxDraw)
        {
            foxDraw.FillColor(Colors.AliceBlue);
            int size = 20;

            for (int i = 0; i < 7; i++)
            {
                foxDraw.DrawRectangle(i * 20, i * 20, size, size);
                i = i * 2;
                size = size * 2;
            }

        }
    }
}
