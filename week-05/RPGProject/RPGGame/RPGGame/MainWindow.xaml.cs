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

namespace RPGExample
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private FoxDraw FoxDraw;
        private Canvas Canvas;

        public MainWindow()
        {
            InitializeComponent();
            FoxDraw = new FoxDraw(canvas);
            FoxDraw.AddImage("Assets/boss.png", 0, 0);
        }

        private void KeyDownEvent(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.D) //right
            {
                double x = FoxDraw.GetLeft(FoxDraw.Tiles[0]) + 10;
                double y = FoxDraw.GetTop(FoxDraw.Tiles[0]) + 0;
                FoxDraw.SetPosition(FoxDraw.Tiles[0], x, y);
            }

            if (e.Key == Key.A) //left
            {
                double x = FoxDraw.GetLeft(FoxDraw.Tiles[0]) - 10;
                double y = FoxDraw.GetTop(FoxDraw.Tiles[0]) + 0;
                FoxDraw.SetPosition(FoxDraw.Tiles[0], x, y);
            }

            if (e.Key == Key.S) //down
            {
                double x = FoxDraw.GetLeft(FoxDraw.Tiles[0]) + 0;
                double y = FoxDraw.GetTop(FoxDraw.Tiles[0]) + 10;
                FoxDraw.SetPosition(FoxDraw.Tiles[0], x, y);
            }

            if (e.Key == Key.W) //up
            {
                double x = FoxDraw.GetLeft(FoxDraw.Tiles[0]) + 0;
                double y = FoxDraw.GetTop(FoxDraw.Tiles[0]) - 10;
                FoxDraw.SetPosition(FoxDraw.Tiles[0], x, y);
            }
        }
    }
}
