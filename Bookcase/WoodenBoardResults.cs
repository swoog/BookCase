namespace Bookcase
{
    using System.Collections.Generic;

    public class WoodenBoardResults
    {
        public WoodenBoardResults(List<WoodenBoard> woodenBoards)
        {
            this.WoodenBoards = woodenBoards;
        }

        public List<WoodenBoard> WoodenBoards { get; set; }

        public override string ToString()
        {
            return string.Join(",", this.WoodenBoards);
        }
    }
}