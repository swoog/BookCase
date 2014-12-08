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

        public WoodenBoard(int width, int height, int thickness)
        {
            var sizes = new[] { width, height, thickness }.OrderBy(s => s).ToList();

            this.Width = sizes[1];
            this.Height = sizes[2];
            this.Thickness = sizes[0];
        }

        public int Width { get; set; }

        public int Height { get; set; }

        public int Thickness { get; set; }

        public override string ToString()
        {
            return string.Format("{0}x{1}x{2}", this.Width, this.Height, this.Thickness);
        }
    }
}