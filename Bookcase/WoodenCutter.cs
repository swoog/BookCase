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
                CreateCuts(woodenBoard, woodenBoardPattern, woodenBoard.Thickness)
                    .Where(r => r.WoodenBoards.Select(w => w.Area).Sum() == woodenBoard.Area)
                    .Distinct(new WoodenBoardResultsEquality())
                    .ToList();
        }

        private static IEnumerable<WoodenBoardResults> CreateCuts(WoodenBoard woodenBoard, WoodenBoardPattern woodenBoardPattern, int thickness)
        {
            var patternWidth = woodenBoardPattern.Width;
            var patternHeight = woodenBoardPattern.Height;

            var boardWidth = woodenBoard.Width;
            var boardHeight = woodenBoard.Height;

            yield return CreateWoodenBoardResult(patternWidth, patternHeight, boardWidth, boardHeight, thickness);
            yield return CreateWoodenBoardResult(patternHeight, patternWidth, boardWidth, boardHeight, thickness);
            yield return CreateWoodenBoardResult2(patternWidth, patternHeight, boardHeight, boardWidth, thickness);
            yield return CreateWoodenBoardResult2(patternHeight, patternWidth, boardHeight, boardWidth, thickness);
        }

        private static WoodenBoardResults CreateWoodenBoardResult2(int patternWidth, int patternHeight, int boardHeight, int boardWidth, int thickness)
        {
            var woodenBoards = new List<WoodenBoard>();

            woodenBoards.Add(new WoodenBoard(patternWidth, patternHeight, thickness));

            woodenBoards.AddRange(CreateWoodenBoard2(patternHeight, thickness, boardWidth, boardHeight));

            woodenBoards.AddRange(CreateWoodenBoard(patternHeight, patternWidth, thickness, boardWidth));

            return new WoodenBoardResults(woodenBoards);
        }

        private static WoodenBoardResults CreateWoodenBoardResult(int patternWidth, int patternHeight, int boardHeight, int boardWidth, int thickness)
        {
            var woodenBoards = new List<WoodenBoard>();

            woodenBoards.Add(new WoodenBoard(patternWidth, patternHeight, thickness));

            woodenBoards.AddRange(CreateWoodenBoard2(patternWidth, thickness, boardWidth, boardHeight));

            woodenBoards.AddRange(CreateWoodenBoard(patternWidth, patternHeight, thickness, boardWidth));

            return new WoodenBoardResults(woodenBoards);
        }

        private static IEnumerable<WoodenBoard> CreateWoodenBoard2(int patternWidth, int thickness, int boardWidth, int boardHeight)
        {
            if (boardHeight - patternWidth > 0)
            {
                yield return new WoodenBoard(boardHeight - patternWidth, boardWidth, thickness);
            }
        }

        private static IEnumerable<WoodenBoard> CreateWoodenBoard(
            int patternWidth,
            int patternHeight,
            int thickness,
            int boardHeight)
        {
            if (boardHeight - patternHeight > 0)
            {
                yield return new WoodenBoard(patternWidth, boardHeight - patternHeight, thickness);
            }
        }
    }
}