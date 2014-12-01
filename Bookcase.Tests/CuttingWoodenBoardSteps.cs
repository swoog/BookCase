using TechTalk.SpecFlow;

namespace Bookcase.Tests
{
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    using Xunit;
    using Xunit.Extensions;

    [Binding]
    public class CuttingWoodenBoardSteps
    {
        private WoodenBoardPattern woodenBoardPattern;

        private WoodenCutter woodenCutter;

        private IList<WoodenBoardResults> woodenBoards;

        public WoodenBoard WoodenBoard
        {
            get
            {
                return ScenarioContext.Current.Get<WoodenBoard>("woodenBoard");
            }
        }

        [Given(@"I want a wooden board of ""(.*)"" mm")]
        public void GivenIWantAWoodenBoardOfMm(string woodenBoard)
        {
            this.woodenBoardPattern = new WoodenBoardPattern(woodenBoard);
        }

        [When(@"I cut")]
        public void WhenICut()
        {
            this.woodenCutter = new WoodenCutter();

            this.woodenBoards = this.woodenCutter.Cuts(this.WoodenBoard, this.woodenBoardPattern);
        }

        [Then(@"I have this wooden boards :")]
        public void ThenIHaveThisWoodenBoards(Table table)
        {
            var expectedWoodenBoards =
                table.Rows.Select(
                    r => new WoodenBoardResults(r["Wooden board"].Split(',').Select(s => new WoodenBoard(s)).ToList()))
                    .ToList();

            Assert.True(
                ScrambledEquals(expectedWoodenBoards, this.woodenBoards, new WoodenBoardResultsEquality()),
                string.Format(
                    "Expected : {0}\n Actual : {1}",
                    string.Join(" | ", expectedWoodenBoards),
                    string.Join(" | ", this.woodenBoards)));
        }

        public static bool ScrambledEquals<T>(IEnumerable<T> list1, IEnumerable<T> list2, IEqualityComparer<T> comparer)
        {
            var cnt = new Dictionary<T, int>(comparer);
            foreach (T s in list1)
            {
                if (cnt.ContainsKey(s))
                {
                    cnt[s]++;
                }
                else
                {
                    cnt.Add(s, 1);
                }
            }
            foreach (T s in list2)
            {
                if (cnt.ContainsKey(s))
                {
                    cnt[s]--;
                }
                else
                {
                    return false;
                }
            }
            return cnt.Values.All(c => c == 0);
        }
    }

    public class WoodenBoardResultsEquality : IEqualityComparer<WoodenBoardResults>
    {
        public bool Equals(WoodenBoardResults x, WoodenBoardResults y)
        {
            return CuttingWoodenBoardSteps.ScrambledEquals(x.WoodenBoards, y.WoodenBoards, new WoodenBoardEquality());
        }

        public int GetHashCode(WoodenBoardResults obj)
        {
            return 0;
        }
    }
}
