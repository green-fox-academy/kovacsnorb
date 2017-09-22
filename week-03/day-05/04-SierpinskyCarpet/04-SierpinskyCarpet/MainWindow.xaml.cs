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

namespace _04_SierpinskyCarpet
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            FoxDraw foxDraw = new FoxDraw(canvas);



            float inputWidth = (float)canvas.Width;
            float inputHeight = (float)canvas.Height;
            float xStart = 0;
            float xEnd = 0;
            float inputLevel = 7;
            DrawPattern(foxDraw, inputLevel, inputWidth, inputHeight, xStart, xEnd);
            Console.ReadLine();
        }

        public void DrawPattern(FoxDraw foxDraw, float level, float widthValue, float heightValue, float xInput, float yInput)
        {
            if (level == 0)
            {
                return;
            }
            else
            {
                foxDraw.BackgroundColor(Colors.Black);
                foxDraw.FillColor(Colors.Black);
                foxDraw.StrokeColor(Colors.White);
                foxDraw.DrawRectangle(xInput, yInput, widthValue, heightValue);
                float width = widthValue / 3;
                float x0 = xInput;
                float x1 = x0 + width;
                float x2 = x0 + 2 * width;

                float height = heightValue / 3;
                float y0 = yInput;
                float y1 = y0 + height;
                float y2 = y0 + 2 * height;
                
                DrawPattern(foxDraw, level - 1, width, height, x0, y0);
                DrawPattern(foxDraw, level - 1, width, height, x0, y1);
                DrawPattern(foxDraw, level - 1, width, height, x0, y2);
                DrawPattern(foxDraw, level - 1, width, height, x1, y0);
               // DrawPattern(foxDraw, level - 1, width, height, x1, y1);
                DrawPattern(foxDraw, level - 1, width, height, x1, y2);
                DrawPattern(foxDraw, level - 1, width, height, x2, y0);
                DrawPattern(foxDraw, level - 1, width, height, x2, y1);
                DrawPattern(foxDraw, level - 1, width, height, x2, y2);

            }
        }
    }
}
