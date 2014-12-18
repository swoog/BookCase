namespace Bookcase
{
    using System.Collections.Generic;
    using System.Linq;

    public class CountCuttingBoard
    {
        public int CountCutting(WoodenBoard woodenBoard, List<WoodenBoardPattern> patterns)
        {
            int c = 1;
            CountCutting(woodenBoard, patterns, ref c);

            return c;
        }

        private static bool CountCutting(WoodenBoard woodenBoard, List<WoodenBoardPattern> patterns, ref int board)
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
                            c++;
                            if (!CountCutting(woodenBoard, patterns.Except(new[] { pattern }).ToList(), ref c))
                            {
                                break;
                            }
                        }
                    }
                    else
                    {
                        if (woodenBoardResultse.WoodenBoards.Count > 1)
                        {
                            var board1 = woodenBoardResultse.WoodenBoards[1];

                            if (!CountCutting(board1, patterns.Except(new[] { pattern }).ToList(), ref c))
                            {
                                c++;
                                if (!CountCutting(woodenBoard, patterns.Except(new[] { pattern }).ToList(), ref c))
                                {
                                    break;
                                }
                            }
                        }

                        if (woodenBoardResultse.WoodenBoards.Count > 2)
                        {
                            var board2 = woodenBoardResultse.WoodenBoards[2];

                            CountCutting(board2, patterns.Except(new[] { pattern }).ToList(), ref c);

                            if (!CountCutting(board2, patterns.Except(new[] { pattern }).ToList(), ref c))
                            {
                                c++;
                                if (!CountCutting(woodenBoard, patterns.Except(new[] { pattern }).ToList(), ref c))
                                {
                                    break;
                                }
                            }
                        }
                    }

                    boardsCount.Add(c);
                }
            }

            if (boardsCount.Count != 0)
            {
                board = boardsCount.Min();

                return true;
            }

            return false;
        }
    }
}