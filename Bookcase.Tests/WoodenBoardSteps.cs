using System;
using TechTalk.SpecFlow;

namespace Bookcase.Tests
{
    [Binding]
    public class WoodenBoardSteps
    {
        [Given(@"a wooden board of ""(.*)"" mm")]
        public void GivenAWoodenBoardOfMm(string woodenSize)
        {
            ScenarioContext.Current.Pending();
        }
        
        [Then(@"the width is (.*) mm")]
        public void ThenTheWidthIsMm(int p0)
        {
            ScenarioContext.Current.Pending();
        }
        
        [Then(@"the height is (.*) mm")]
        public void ThenTheHeightIsMm(int p0)
        {
            ScenarioContext.Current.Pending();
        }
        
        [Then(@"the thickness is (.*) mm")]
        public void ThenTheThicknessIsMm(int p0)
        {
            ScenarioContext.Current.Pending();
        }
    }
}
