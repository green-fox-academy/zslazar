﻿using System;
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

namespace _10_RainBow
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
            double Size = 600;
            Rainbow(foxDraw, Size);
            // create a square drawing function that takes 2 parameters:
            // the square size, and the fill color,
            // and draws a square of that size and color to the center of the canvas.
            // create a loop that fills the canvas with rainbow colored squares.

        }

        public static void Rainbow(FoxDraw foxDraw, double Size)
        {
            for (int i = 1; i < 10; i++)
            {
                foxDraw.DrawRectangle(300 - Size / 2, 300 - Size / 2, Size, Size);
                Size = Size - (i + 1)* 10;
                //foxDraw.FillColor(color);
            }

        }
       
    }
}
