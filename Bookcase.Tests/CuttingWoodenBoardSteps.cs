namespace Bookcase.Tests
{
    using System.Collections.Generic;
    using System.Linq;

    using TechTalk.SpecFlow;

    using Xunit;

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
                WoodenBoardResultsEquality.ScrambledEquals(
                    expectedWoodenBoards,
                    this.woodenBoards,
                    new WoodenBoardResultsEquality()),
                string.Format("Expected : {0}\n Actual : {1}", string.Join(" | ", expectedWoodenBoards), string.Join(" | ", this.woodenBoards)));
        }
    }
}
