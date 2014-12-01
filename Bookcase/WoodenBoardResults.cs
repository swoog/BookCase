namespace Bookcase
{
    using System.Collections.Generic;

    public class WoodenBoardResults
    {
        public List<WoodenBoard> WoodenBoards { get; set; }

        public WoodenBoardResults(List<WoodenBoard> woodenBoards)
        {
            this.WoodenBoards = woodenBoards;
        }

        public override string ToString()
        {
            return string.Join(",", this.WoodenBoards);
        }
    }
}