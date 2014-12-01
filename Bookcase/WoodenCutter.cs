namespace Bookcase
{
    using System;
    using System.Collections.Generic;

    public class WoodenCutter
    {
        public IList<WoodenBoardResults> Cuts(WoodenBoard woodenBoard, WoodenBoardPattern woodenBoardPattern)
        {
            var woodenBoards = new List<WoodenBoard>();
            woodenBoards.Add(
                new WoodenBoard(woodenBoardPattern.Width, woodenBoardPattern.Height, woodenBoard.Thickness));

            if (woodenBoard.Width - woodenBoardPattern.Width > 0)
            {
                woodenBoards.Add(
                    new WoodenBoard(
                        woodenBoard.Width - woodenBoardPattern.Width,
                        woodenBoard.Height,
                        woodenBoard.Thickness));

                if (woodenBoard.Height - woodenBoardPattern.Height > 0)
                {
                    woodenBoards.Add(
                        new WoodenBoard(
                            woodenBoardPattern.Width,
                            woodenBoard.Height - woodenBoardPattern.Height,
                            woodenBoard.Thickness));
                }
            }
            else
            {
                if (woodenBoard.Height - woodenBoardPattern.Height > 0)
                {
                    woodenBoards.Add(
                        new WoodenBoard(
                            woodenBoard.Width,
                            woodenBoard.Height - woodenBoardPattern.Height,
                            woodenBoard.Thickness));
                }
            }

            return new WoodenBoardResults[] { new WoodenBoardResults(woodenBoards), };
        }
    }
}