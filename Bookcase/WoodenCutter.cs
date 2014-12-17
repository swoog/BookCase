namespace Bookcase
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class WoodenCutter
    {
        public IList<WoodenBoardResults> Cuts(WoodenBoard woodenBoard, WoodenBoardPattern woodenBoardPattern)
        {
            return
                CreateCuts(woodenBoard, woodenBoardPattern)
                    .Where(r => r.WoodenBoards.Count > 0)
                    .Where(r => r.WoodenBoards.Select(w => w.Area).Sum() == woodenBoard.Area)
                    .Distinct(new WoodenBoardResultsEquality())
                    .ToList();
        }

        private static IEnumerable<WoodenBoardResults> CreateCuts(WoodenBoard woodenBoard, WoodenBoardPattern woodenBoardPattern)
        {
            var patternWidth = woodenBoardPattern.Width;
            var patternHeight = woodenBoardPattern.Height;

            yield return CreateWoodenBoardResult(woodenBoard, patternWidth, patternHeight);
            yield return CreateWoodenBoardResult(woodenBoard, patternHeight, patternWidth);
            yield return CreateWoodenBoardResult2(woodenBoard, patternWidth, patternHeight);
            yield return CreateWoodenBoardResult2(woodenBoard, patternHeight, patternWidth);
        }

        private static WoodenBoardResults CreateWoodenBoardResult2(
            WoodenBoard woodenBoard,
            int patternWidth,
            int patternHeight)
        {
            var woodenBoards = new List<WoodenBoard>();

            if (woodenBoard.Width >= patternWidth && woodenBoard.Height >= patternHeight)
            {
                woodenBoards.Add(new WoodenBoard(patternWidth, patternHeight, woodenBoard.Thickness));

                var boardHeight = woodenBoard.Height;

                if (boardHeight - patternHeight > 0)
                {
                    woodenBoards.Add(new WoodenBoard(boardHeight - patternHeight, woodenBoard.Width, woodenBoard.Thickness));

                    woodenBoards.AddRange(CreateWoodenBoard2(woodenBoard, patternWidth, patternHeight));
                }
                else if (boardHeight - patternHeight == 0)
                {
                    woodenBoards.AddRange(CreateWoodenBoard2(woodenBoard, boardHeight, patternWidth));
                }
            }

            return new WoodenBoardResults(woodenBoards);
        }

        private static IEnumerable<WoodenBoard> CreateWoodenBoard2(
    WoodenBoard woodenBoard,
    int patternWidth,
    int patternHeight)
        {
            if (woodenBoard.Width - patternWidth > 0)
            {
                yield return new WoodenBoard(patternHeight, woodenBoard.Width - patternWidth, woodenBoard.Thickness);
            }
        }

        private static WoodenBoardResults CreateWoodenBoardResult(
            WoodenBoard woodenBoard,
            int patternWidth,
            int patternHeight)
        {
            var woodenBoards = new List<WoodenBoard>();
            if (woodenBoard.Width >= patternWidth && woodenBoard.Height >= patternHeight)
            {
                woodenBoards.Add(new WoodenBoard(patternWidth, patternHeight, woodenBoard.Thickness));

                var boardWidth = woodenBoard.Width;

                if (boardWidth - patternWidth > 0)
                {
                    woodenBoards.Add(
                        new WoodenBoard(boardWidth - patternWidth, woodenBoard.Height, woodenBoard.Thickness));

                    woodenBoards.AddRange(CreateWoodenBoard(woodenBoard, patternWidth, patternHeight));
                }
                else if (boardWidth - patternWidth == 0)
                {
                    woodenBoards.AddRange(CreateWoodenBoard(woodenBoard, boardWidth, patternHeight));
                }
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