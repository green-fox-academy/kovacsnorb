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

namespace _07_FourRectangles
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            FoxDraw foxDraw = new FoxDraw(canvas);
            foxDraw.BackgroundColor(Colors.Wheat);
            // draw four different size and color rectangles.

            foxDraw.FillColor(Colors.DarkBlue);
            foxDraw.DrawRectangle(20, 30, 100, 45);

            foxDraw.FillColor(Colors.Aquamarine);
            foxDraw.DrawRectangle(70, 78, 24, 100);

            foxDraw.FillColor(Colors.Bisque);
            foxDraw.DrawRectangle(178, 121, 43, 90);

            foxDraw.FillColor(Colors.CornflowerBlue);
            foxDraw.DrawRectangle(200, 20, 31, 35);
        }
    }
}
