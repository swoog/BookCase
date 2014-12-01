using TechTalk.SpecFlow;

namespace Bookcase.Tests
{
    using Xunit;

    [Binding]
    public class WoodenBoardSteps
    {
        private WoodenBoard woodenBoard;

        [Given(@"a wooden board of ""(.*)"" mm")]
        public void GivenAWoodenBoardOfMm(string woodenSize)
        {
            this.woodenBoard = new WoodenBoard(woodenSize);
            ScenarioContext.Current.Add("woodenBoard", this.woodenBoard);
        }
        
        [Then(@"the width is (.*) mm")]
        public void ThenTheWidthIsMm(int width)
        {
            Assert.Equal(width, this.woodenBoard.Width);
        }
        
        [Then(@"the height is (.*) mm")]
        public void ThenTheHeightIsMm(int height)
        {
            Assert.Equal(height, this.woodenBoard.Height);
        }
        
        [Then(@"the thickness is (.*) mm")]
        public void ThenTheThicknessIsMm(int thickness)
        {
            Assert.Equal(thickness, this.woodenBoard.Thickness);
        }
    }
}
