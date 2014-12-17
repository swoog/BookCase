using System;
using TechTalk.SpecFlow;

namespace Bookcase.Tests
{
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
}
