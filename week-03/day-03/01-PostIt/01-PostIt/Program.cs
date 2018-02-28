using System;

namespace _01_PostIt
{
    class Program
    {
        public struct postIt
        {
            public string BackgroundColor;
            public string Text;
            public string TextColor;
        }

        static void Main(string[] args)
        {
            postIt idea1 = new postIt();
            idea1.BackgroundColor = "orange";
            idea1.Text = "Idea 1";
            idea1.TextColor = "blue";

            postIt awesome = new postIt();
            awesome.BackgroundColor = "pink";
            awesome.Text = "Awesome!!";
            awesome.TextColor = "Black";

            postIt superb = new postIt();
            superb.BackgroundColor = "yellow";
            superb.Text = "Superb!!";
            superb.TextColor = "green";
        }
    }
}
