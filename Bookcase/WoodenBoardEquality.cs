namespace Bookcase
{
    using System.Collections.Generic;

    public class WoodenBoardEquality : IEqualityComparer<WoodenBoard>
    {
        public bool Equals(WoodenBoard x, WoodenBoard y)
        {
            return x.Height == y.Height && x.Width == y.Width && x.Thickness == y.Thickness;
        }

        public int GetHashCode(WoodenBoard obj)
        {
            return 0;
        }
    }
}