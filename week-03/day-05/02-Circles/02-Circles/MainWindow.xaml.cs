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

namespace _02_Circles
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            FoxDraw foxDraw = new FoxDraw(canvas);
            foxDraw.FillColor(Colors.Transparent);
            float level = 5;
            float xCoordinate = 0;
            float yCoordinate = 0;
            float side1 = (float)canvas.Width;
            float side2 = (float)canvas.Height;

            CirclePattern(foxDraw, level, xCoordinate, yCoordinate, side1, side2);
            Console.ReadLine();

        }

        public void CirclePattern(FoxDraw foxDraw, float levelInput, float xInput, float yInput, float side1Input, float side2Input)
        {

            if (levelInput == 0)
            {
                return;
            }
            else
            {
                foxDraw.DrawEllipse(xInput, yInput, side1Input, side2Input);

                float width = side1Input / 2;
                float height = side2Input / 2;

                float x0 = xInput;
                float x1 = xInput + width * (((float)Math.Pow((3 / 2), (1 / 2))) * 1/2);
                float x2 = xInput + width;

                float y0 = yInput;
                float y1 = yInput + height *  (((float)Math.Pow((3 / 2), (1 / 2)) * 1/2));

                CirclePattern(foxDraw, levelInput - 1, x0, y1, width, height);
                CirclePattern(foxDraw, levelInput - 1, x1, y0, width, height);
                CirclePattern(foxDraw, levelInput - 1, x2, y1, width, height);
            }




        }
    }
}
