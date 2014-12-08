﻿// ------------------------------------------------------------------------------
//  <auto-generated>
//      This code was generated by SpecFlow (http://www.specflow.org/).
//      SpecFlow Version:1.9.0.77
//      SpecFlow Generator Version:1.9.0.0
//      Runtime Version:4.0.30319.17929
// 
//      Changes to this file may cause incorrect behavior and will be lost if
//      the code is regenerated.
//  </auto-generated>
// ------------------------------------------------------------------------------
#region Designer generated code
#pragma warning disable
namespace Bookcase.Tests
{
    using TechTalk.SpecFlow;
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("TechTalk.SpecFlow", "1.9.0.77")]
    [System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    public partial class CuttingWoodenBoardFeature : Xunit.IUseFixture<CuttingWoodenBoardFeature.FixtureData>, System.IDisposable
    {
        
        private static TechTalk.SpecFlow.ITestRunner testRunner;
        
#line 1 "CuttingWoodenBoard.feature"
#line hidden
        
        public CuttingWoodenBoardFeature()
        {
            this.TestInitialize();
        }
        
        public static void FeatureSetup()
        {
            testRunner = TechTalk.SpecFlow.TestRunnerManager.GetTestRunner();
            TechTalk.SpecFlow.FeatureInfo featureInfo = new TechTalk.SpecFlow.FeatureInfo(new System.Globalization.CultureInfo("en-US"), "Cutting Wooden Board", "In order to avoid a bookcase\r\nAs a user\r\nI want to cut wooden board", ProgrammingLanguage.CSharp, ((string[])(null)));
            testRunner.OnFeatureStart(featureInfo);
        }
        
        public static void FeatureTearDown()
        {
            testRunner.OnFeatureEnd();
            testRunner = null;
        }
        
        public virtual void TestInitialize()
        {
        }
        
        public virtual void ScenarioTearDown()
        {
            testRunner.OnScenarioEnd();
        }
        
        public virtual void ScenarioSetup(TechTalk.SpecFlow.ScenarioInfo scenarioInfo)
        {
            testRunner.OnScenarioStart(scenarioInfo);
        }
        
        public virtual void ScenarioCleanup()
        {
            testRunner.CollectScenarioErrors();
        }
        
        public virtual void SetFixture(CuttingWoodenBoardFeature.FixtureData fixtureData)
        {
        }
        
        void System.IDisposable.Dispose()
        {
            this.ScenarioTearDown();
        }
        
        [Xunit.FactAttribute()]
        [Xunit.TraitAttribute("FeatureTitle", "Cutting Wooden Board")]
        [Xunit.TraitAttribute("Description", "Cutting wooden board")]
        public virtual void CuttingWoodenBoard()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Cutting wooden board", ((string[])(null)));
#line 6
this.ScenarioSetup(scenarioInfo);
#line 7
 testRunner.Given("a wooden board of \"400x400x15\" mm", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 8
 testRunner.And("I want a wooden board of \"400x400\" mm", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 9
 testRunner.When("I cut", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
            TechTalk.SpecFlow.Table table1 = new TechTalk.SpecFlow.Table(new string[] {
                        "Wooden board"});
            table1.AddRow(new string[] {
                        "400x400x15"});
#line 10
 testRunner.Then("I have this wooden boards :", ((string)(null)), table1, "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [Xunit.FactAttribute()]
        [Xunit.TraitAttribute("FeatureTitle", "Cutting Wooden Board")]
        [Xunit.TraitAttribute("Description", "Cutting wooden board from 400x800")]
        public virtual void CuttingWoodenBoardFrom400X800()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Cutting wooden board from 400x800", ((string[])(null)));
#line 14
this.ScenarioSetup(scenarioInfo);
#line 15
 testRunner.Given("a wooden board of \"400x800x15\" mm", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 16
 testRunner.And("I want a wooden board of \"400x400\" mm", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 17
 testRunner.When("I cut", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
            TechTalk.SpecFlow.Table table2 = new TechTalk.SpecFlow.Table(new string[] {
                        "Wooden board"});
            table2.AddRow(new string[] {
                        "400x400x15, 400x400x15"});
#line 18
 testRunner.Then("I have this wooden boards :", ((string)(null)), table2, "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [Xunit.FactAttribute()]
        [Xunit.TraitAttribute("FeatureTitle", "Cutting Wooden Board")]
        [Xunit.TraitAttribute("Description", "Cutting wooden board from 800x800")]
        public virtual void CuttingWoodenBoardFrom800X800()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Cutting wooden board from 800x800", ((string[])(null)));
#line 22
this.ScenarioSetup(scenarioInfo);
#line 23
 testRunner.Given("a wooden board of \"800x800x15\" mm", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 24
 testRunner.And("I want a wooden board of \"400x400\" mm", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 25
 testRunner.When("I cut", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
            TechTalk.SpecFlow.Table table3 = new TechTalk.SpecFlow.Table(new string[] {
                        "Wooden board"});
            table3.AddRow(new string[] {
                        "400x400x15,400x800x15,400x400x15"});
#line 26
 testRunner.Then("I have this wooden boards :", ((string)(null)), table3, "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [Xunit.FactAttribute()]
        [Xunit.TraitAttribute("FeatureTitle", "Cutting Wooden Board")]
        [Xunit.TraitAttribute("Description", "Cutting wooden board from 600x800")]
        public virtual void CuttingWoodenBoardFrom600X800()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Cutting wooden board from 600x800", ((string[])(null)));
#line 30
this.ScenarioSetup(scenarioInfo);
#line 31
 testRunner.Given("a wooden board of \"600x800x15\" mm", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 32
 testRunner.And("I want a wooden board of \"400x400\" mm", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 33
 testRunner.When("I cut", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
            TechTalk.SpecFlow.Table table4 = new TechTalk.SpecFlow.Table(new string[] {
                        "Wooden board"});
            table4.AddRow(new string[] {
                        "400x400x15,200x800x15,400x400x15"});
            table4.AddRow(new string[] {
                        "400x400x15,400x600x15,200x400x15"});
#line 34
 testRunner.Then("I have this wooden boards :", ((string)(null)), table4, "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [Xunit.FactAttribute()]
        [Xunit.TraitAttribute("FeatureTitle", "Cutting Wooden Board")]
        [Xunit.TraitAttribute("Description", "Cutting wooden board from 600x800 with rectangular surface")]
        public virtual void CuttingWoodenBoardFrom600X800WithRectangularSurface()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Cutting wooden board from 600x800 with rectangular surface", ((string[])(null)));
#line 40
this.ScenarioSetup(scenarioInfo);
#line 41
 testRunner.Given("a wooden board of \"600x800x15\" mm", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 42
 testRunner.And("I want a wooden board of \"200x400\" mm", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 43
 testRunner.When("I cut", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
            TechTalk.SpecFlow.Table table5 = new TechTalk.SpecFlow.Table(new string[] {
                        "Wooden board"});
            table5.AddRow(new string[] {
                        "200x400x15,400x600x15,200x800x15"});
            table5.AddRow(new string[] {
                        "200x400x15,200x200x15,600x600x15"});
            table5.AddRow(new string[] {
                        "200x400x15,200x400x15,400x800x15"});
            table5.AddRow(new string[] {
                        "200x400x15,400x400x15,400x600x15"});
#line 44
 testRunner.Then("I have this wooden boards :", ((string)(null)), table5, "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [System.CodeDom.Compiler.GeneratedCodeAttribute("TechTalk.SpecFlow", "1.9.0.77")]
        [System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
        public class FixtureData : System.IDisposable
        {
            
            public FixtureData()
            {
                CuttingWoodenBoardFeature.FeatureSetup();
            }
            
            void System.IDisposable.Dispose()
            {
                CuttingWoodenBoardFeature.FeatureTearDown();
            }
        }
    }
}
#pragma warning restore
#endregion
