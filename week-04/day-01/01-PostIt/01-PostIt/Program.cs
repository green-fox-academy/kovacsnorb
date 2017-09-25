using System;

namespace _01_PostIt
{
    class Program
    {
        public struct PostIt
        {
            public string BackgoundColor;
            public string Text;
            public string TextColor;
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            PostIt postIt1;
            PostIt postIt2;
            PostIt postIt3;

            postIt1.BackgoundColor = "orange";
            postIt1.TextColor = "blue";
            postIt1.Text = "Idea 1";

            postIt2.BackgoundColor = "pink";
            postIt2.TextColor = "black";
            postIt2.Text = "Awsome";

            postIt3.BackgoundColor = "yellow";
            postIt3.TextColor = "green";
            postIt3.Text = "Superb";

            Console.WriteLine(postIt1.BackgoundColor + ", " + postIt1.TextColor + ", " + postIt1.Text);
            Console.WriteLine(postIt2.BackgoundColor + ", " + postIt2.TextColor + ", " + postIt2.Text);
            Console.WriteLine(postIt3.BackgoundColor + ", " + postIt3.TextColor + ", " + postIt3.Text);

            Console.ReadLine();
        }
    }
}
