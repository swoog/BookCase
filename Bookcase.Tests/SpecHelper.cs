namespace Bookcase.Tests
{
    using System.Collections.Generic;

    using TechTalk.SpecFlow;

    public class SpecHelper
    {
        public static WoodenBoard WoodenBoard
        {
            get
            {
                return ScenarioContext.Current.Get<WoodenBoard>("woodenBoard");
            }
            set
            {
                ScenarioContext.Current["woodenBoard"] = value;
            }
        }

        public static List<WoodenBoardPattern> WoodenBoardPatterns
        {
            get
            {
                if (!ScenarioContext.Current.ContainsKey("woodenBoardsPattern"))
                {
                    ScenarioContext.Current["woodenBoardsPattern"] = new List<WoodenBoardPattern>();
                }

                return ScenarioContext.Current.Get<List<WoodenBoardPattern>>("woodenBoardsPattern");
            }
        }
    }
}