using System;
using TechTalk.SpecFlow;

namespace Bookcase.Tests
{
    using System.Collections.Generic;
    using System.Linq;

    using Xunit;

    [Binding]
    public class CountCuttingBoardSteps
    {
        private int result;

        [When(@"I count cut")]
        public void WhenICountCut()
        {
            var countCuttingBoard = new CountCuttingBoard();

            this.result = countCuttingBoard.CountCutting(SpecHelper.WoodenBoard, SpecHelper.WoodenBoardPatterns);
        }

        [Then(@"I have this (.*) wooden board")]
        public void ThenIHaveThisWoodenBoard(int countBoard)
        {
            Assert.Equal(countBoard, this.result);
        }
    }

    public class CountCuttingBoard
    {
        public int CountCutting(WoodenBoard woodenBoard, List<WoodenBoardPattern> patterns)
        {
            return CountCutting(woodenBoard, patterns, 1);
        }

        private static int CountCutting(WoodenBoard woodenBoard, List<WoodenBoardPattern> patterns, int board)
        {
            var woodenCutter = new WoodenCutter();

            var boardsCount = new List<int>();

            foreach (var pattern in patterns)
            {
                var results = woodenCutter.Cuts(woodenBoard, pattern);
                foreach (var woodenBoardResultse in results)
                {
                    int c = board;
                    if (woodenBoardResultse.WoodenBoards.Count == 1)
                    {
                        if (patterns.Count > 1)
                        {
                            c = CountCutting(woodenBoard, patterns.Except(new[] { pattern }).ToList(), c + 1);
                        }
                    }
                    else
                    {
                        if (woodenBoardResultse.WoodenBoards.Count > 1)
                        {
                            var board1 = woodenBoardResultse.WoodenBoards[1];

                            c = CountCutting(board1, patterns.Except(new[] { pattern }).ToList(), c);
                        }

                        if (woodenBoardResultse.WoodenBoards.Count > 2)
                        {
                            var board2 = woodenBoardResultse.WoodenBoards[2];

                            c = CountCutting(board2, patterns.Except(new[] { pattern }).ToList(), c);
                        }
                    }

                    boardsCount.Add(c);
                }
            }

            if (boardsCount.Count == 0)
            {
                return board;
            }

            return boardsCount.Min();
        }
    }
}
