namespace Bookcase
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class WoodenCutter
    {
        public IList<WoodenBoardResults> Cuts(WoodenBoard woodenBoard, WoodenBoardPattern woodenBoardPattern)
        {
            return CreateCuts(woodenBoard, woodenBoardPattern).Distinct(new WoodenBoardResultsEquality()).ToList();
        }

        private static IEnumerable<WoodenBoardResults> CreateCuts(WoodenBoard woodenBoard, WoodenBoardPattern woodenBoardPattern)
        {
            var patternWidth = woodenBoardPattern.Width;
            var patternHeight = woodenBoardPattern.Height;

            yield return CreateWoodenBoardResult(woodenBoard, patternWidth, patternHeight);
            yield return CreateWoodenBoardResult(woodenBoard, patternHeight, patternWidth);
        }

        private static WoodenBoardResults CreateWoodenBoardResult(
            WoodenBoard woodenBoard,
            int patternWidth,
            int patternHeight)
        {
            var woodenBoards = new List<WoodenBoard>();
            woodenBoards.Add(new WoodenBoard(patternWidth, patternHeight, woodenBoard.Thickness));

            var boardWidth = woodenBoard.Width;

            if (boardWidth - patternWidth > 0)
            {
                woodenBoards.Add(new WoodenBoard(boardWidth - patternWidth, woodenBoard.Height, woodenBoard.Thickness));

                woodenBoards.AddRange(CreateWoodenBoard(woodenBoard, patternWidth, patternHeight));
            }
            else
            {
                woodenBoards.AddRange(CreateWoodenBoard(woodenBoard, boardWidth, patternHeight));
            }

            return new WoodenBoardResults(woodenBoards);
        }

        private static IEnumerable<WoodenBoard> CreateWoodenBoard(
            WoodenBoard woodenBoard,
            int patternWidth,
            int patternHeight)
        {
            if (woodenBoard.Height - patternHeight > 0)
            {
                yield return new WoodenBoard(patternWidth, woodenBoard.Height - patternHeight, woodenBoard.Thickness);
            }
        }
    }
}