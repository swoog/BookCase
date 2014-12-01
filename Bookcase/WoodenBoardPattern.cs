namespace Bookcase
{
    using System;
    using System.Linq;

    public class WoodenBoardPattern
    {
        public WoodenBoardPattern(string woodenBoard)
        {
            var sizes = woodenBoard.Split('x').Select(s => Convert.ToInt32(s)).OrderBy(s => s).ToList();

            this.Width = sizes[0];
            this.Height = sizes[1];
        }

        public int Width { get; set; }

        public int Height { get; set; }
    }
}