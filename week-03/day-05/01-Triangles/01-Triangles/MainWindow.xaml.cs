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

namespace _01_Triangles
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            FoxDraw foxDraw = new FoxDraw(canvas);
            foxDraw.StrokeColor(Colors.Black);
            foxDraw.FillColor(Colors.White);
            float level = 8;
            float inputWidth = (float)canvas.Width;
            float inputHeight = (float)canvas.Height;
            float xStart = 0;
            float xEnd = 0;

            var pointsOfTriangle = new List<Point>();
            
            TriangleDrawer(foxDraw, level, inputWidth, inputHeight, xStart, xEnd);
            Console.ReadLine();
        }

        public void TriangleDrawer(FoxDraw foxDraw, float levelInput, float widthValue, float heightValue, float xInput, float yInput)
        {
            if (levelInput == 0)
            {
                return;
            }
            else
            {
                var pointsOfTriangle = new List<Point>();

                pointsOfTriangle.Add(new Point(xInput, yInput));
                pointsOfTriangle.Add(new Point(xInput + widthValue, yInput));
                pointsOfTriangle.Add(new Point(xInput + widthValue / 2, yInput + heightValue));

                foxDraw.DrawPolygon(pointsOfTriangle);

                float width = widthValue / 2;
                float height = heightValue / 2;

                float x0 = xInput;
                float x1 = xInput + width;
                float x2 = xInput + width / 2;

                float y0 = yInput;
                float y2 = yInput + height;

                TriangleDrawer(foxDraw, levelInput - 1, width, height, x0, y0);
                TriangleDrawer(foxDraw, levelInput - 1, width, height, x1, y0);
                TriangleDrawer(foxDraw, levelInput - 1, width, height, x2, y2);
            }
        }
    }
}