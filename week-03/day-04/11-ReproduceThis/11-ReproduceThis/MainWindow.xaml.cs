using GreenFox;
using System;
using System.Windows;
using System.Windows.Media;

namespace _11_ReproduceThis
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            FoxDraw foxDraw = new FoxDraw(canvas);
            foxDraw.BackgroundColor(Colors.Yellow);
            foxDraw.FillColor(Colors.Yellow);
            foxDraw.StrokeColor(Colors.Black);
            float inputWidth = (float)canvas.Width;
            float inputHeight = (float)canvas.Height;
            float xStart = 0;
            float xEnd = 0;
            float inputLevel = 6;
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
                foxDraw.DrawRectangle(xInput, yInput, widthValue, heightValue);
                float width = widthValue / 3;
                float x0 = xInput;
                float x1 = x0 + width;
                float x2 = x0 + 2 * width;

                float height = heightValue / 3;
                float y0 = yInput;
                float y1 = y0 + height;
                float y2 = y0 + 2 * height;

                //DrawPattern(foxDraw, level - 1, width, height, x0, y0);
                DrawPattern(foxDraw, level - 1, width, height, x0, y1);
                //DrawPattern(foxDraw, level - 1, width, height, x0, y2);
                DrawPattern(foxDraw, level - 1, width, height, x1, y0);
                //DrawPattern(foxDraw, level - 1, width, height, x1, y1);
                DrawPattern(foxDraw, level - 1, width, height, x1, y2);
                //DrawPattern(foxDraw, level - 1, width, height, x2, y0);
                DrawPattern(foxDraw, level - 1, width, height, x2, y1);
                //DrawPattern(foxDraw, level - 1, width, height, x2, y2);
            }
        }
    }
}
