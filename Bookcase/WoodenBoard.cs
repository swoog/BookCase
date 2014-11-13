namespace Bookcase
{
    using System;
    using System.Linq;

    public class WoodenBoard
    {
        public WoodenBoard(string woodenSize)
        {
            var sizes = woodenSize.Split('x').Select(s => Convert.ToInt32(s)).OrderBy(s => s).ToList();

            this.Thickness = sizes[0];
            this.Width = sizes[1];
            this.Height = sizes[2];
        }

        public int Width { get; set; }

        public int Height { get; set; }

        public int Thickness { get; set; }
    }
}