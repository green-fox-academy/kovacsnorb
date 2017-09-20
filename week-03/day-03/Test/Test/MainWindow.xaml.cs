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

namespace Test
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
            DrawGreenLines(foxDraw);
            DrawEllipse(foxDraw);
        }

        public static void DrawGreenLines(FoxDraw foxDraw)
        {
            foxDraw.StrokeColor(Colors.Green);
            foxDraw.DrawLine(0, 10, 100, 10);

            var startPoint = new Point(0, 20);
            var endPoint = new Point(100, 20);
            foxDraw.DrawLine(startPoint, endPoint);
        }

        public static void DrawEllipse(FoxDraw foxDraw)
        {
            foxDraw.DrawEllipse(70, 70, 150, 150);
        }

        //Step by step guide:
        //- Create WPF Project
        //- Add `<Canvas Name = "canvas" Width="300" Height="300"/>` line to the MainWindow.xaml
        //- Add FoxDraw.cs to your project
        //- Add `using GreenFox;` line to the MainWindow.xaml.cs
        //- Add `var foxDraw = new FoxDraw(canvas);` line to the MainWindow.xaml.cs
    }
}
