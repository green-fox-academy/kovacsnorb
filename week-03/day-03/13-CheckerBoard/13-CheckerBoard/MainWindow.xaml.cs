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

namespace _13_CheckerBoard
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            FoxDraw foxDraw = new FoxDraw(canvas);
            // fill the canvas with a checkerboard pattern.

            for (int i = 0; i < 8; i++)
            {
                for (int j = 0; j < 8; j++)
                {
                    DrawSquare(foxDraw, 15, j, i);
                }
            }
        }

        public void DrawSquare(FoxDraw foxDraw, double size, double multiplierX, double multiplierY)
        {
            foxDraw.StrokeColor(Colors.Black);
            if ((multiplierX + multiplierY) % 2 == 0)
            {
                foxDraw.FillColor(Colors.Black);
            }
            else
            {
                foxDraw.FillColor(Colors.White);
            }
            foxDraw.DrawRectangle(size * (multiplierX + 1), size * (multiplierY + 1), size, size);
        }
    }
}
