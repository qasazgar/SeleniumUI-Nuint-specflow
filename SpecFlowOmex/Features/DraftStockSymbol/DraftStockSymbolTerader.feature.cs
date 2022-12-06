﻿// ------------------------------------------------------------------------------
//  <auto-generated>
//      This code was generated by SpecFlow (https://www.specflow.org/).
//      SpecFlow Version:3.9.0.0
//      SpecFlow Generator Version:3.9.0.0
// 
//      Changes to this file may cause incorrect behavior and will be lost if
//      the code is regenerated.
//  </auto-generated>
// ------------------------------------------------------------------------------
#region Designer generated code
#pragma warning disable
namespace SpecFlowOmex.Features.DraftStockSymbol
{
    using TechTalk.SpecFlow;
    using System;
    using System.Linq;
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("TechTalk.SpecFlow", "3.9.0.0")]
    [System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [NUnit.Framework.TestFixtureAttribute()]
    [NUnit.Framework.DescriptionAttribute("DraftStockSymbolTerader")]
    public partial class DraftStockSymbolTeraderFeature
    {
        
        private TechTalk.SpecFlow.ITestRunner testRunner;
        
        private string[] _featureTags = ((string[])(null));
        
#line 1 "DraftStockSymbolTerader.feature"
#line hidden
        
        [NUnit.Framework.OneTimeSetUpAttribute()]
        public virtual void FeatureSetup()
        {
            testRunner = TechTalk.SpecFlow.TestRunnerManager.GetTestRunner();
            TechTalk.SpecFlow.FeatureInfo featureInfo = new TechTalk.SpecFlow.FeatureInfo(new System.Globalization.CultureInfo("en-US"), "Features/DraftStockSymbol", "DraftStockSymbolTerader", "\tBy Custmer\r\n\tI Want  Draft purchase of shares from the stock exchange symbol\r\n\ts" +
                    "o ", ProgrammingLanguage.CSharp, ((string[])(null)));
            testRunner.OnFeatureStart(featureInfo);
        }
        
        [NUnit.Framework.OneTimeTearDownAttribute()]
        public virtual void FeatureTearDown()
        {
            testRunner.OnFeatureEnd();
            testRunner = null;
        }
        
        [NUnit.Framework.SetUpAttribute()]
        public virtual void TestInitialize()
        {
        }
        
        [NUnit.Framework.TearDownAttribute()]
        public virtual void TestTearDown()
        {
            testRunner.OnScenarioEnd();
        }
        
        public virtual void ScenarioInitialize(TechTalk.SpecFlow.ScenarioInfo scenarioInfo)
        {
            testRunner.OnScenarioInitialize(scenarioInfo);
            testRunner.ScenarioContext.ScenarioContainer.RegisterInstanceAs<NUnit.Framework.TestContext>(NUnit.Framework.TestContext.CurrentContext);
        }
        
        public virtual void ScenarioStart()
        {
            testRunner.OnScenarioStart();
        }
        
        public virtual void ScenarioCleanup()
        {
            testRunner.CollectScenarioErrors();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Draft Buy stock symbol with  amount and  number of Range time")]
        [NUnit.Framework.CategoryAttribute("GotostationDev")]
        [NUnit.Framework.CategoryAttribute("LogoutUserStation")]
        [NUnit.Framework.CategoryAttribute("BuyMin")]
        [NUnit.Framework.CategoryAttribute("inTheDay")]
        [NUnit.Framework.CategoryAttribute("Positivetest")]
        [NUnit.Framework.TestCaseAttribute("min", "min", "0", "0", "روز", null)]
        [NUnit.Framework.TestCaseAttribute("min", "max", "0", "0", "انجام و حذف", null)]
        [NUnit.Framework.TestCaseAttribute("max", "max", "0", "0", "معتبر تا لغو", null)]
        [NUnit.Framework.TestCaseAttribute("max", "min", "0", "0", "معتبر تا تاریخ", null)]
        public virtual void DraftBuyStockSymbolWithAmountAndNumberOfRangeTime(string price, string number, string plusprice, string plusnumber, string timerange, string[] exampleTags)
        {
            string[] @__tags = new string[] {
                    "GotostationDev",
                    "LogoutUserStation",
                    "BuyMin",
                    "inTheDay",
                    "Positivetest"};
            if ((exampleTags != null))
            {
                @__tags = System.Linq.Enumerable.ToArray(System.Linq.Enumerable.Concat(@__tags, exampleTags));
            }
            string[] tagsOfScenario = @__tags;
            System.Collections.Specialized.OrderedDictionary argumentsOfScenario = new System.Collections.Specialized.OrderedDictionary();
            argumentsOfScenario.Add("price", price);
            argumentsOfScenario.Add("number", number);
            argumentsOfScenario.Add("plusprice", plusprice);
            argumentsOfScenario.Add("plusnumber", plusnumber);
            argumentsOfScenario.Add("timerange", timerange);
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Draft Buy stock symbol with  amount and  number of Range time", null, tagsOfScenario, argumentsOfScenario, this._featureTags);
#line 8
this.ScenarioInitialize(scenarioInfo);
#line hidden
            bool isScenarioIgnored = default(bool);
            bool isFeatureIgnored = default(bool);
            if ((tagsOfScenario != null))
            {
                isScenarioIgnored = tagsOfScenario.Where(__entry => __entry != null).Where(__entry => String.Equals(__entry, "ignore", StringComparison.CurrentCultureIgnoreCase)).Any();
            }
            if ((this._featureTags != null))
            {
                isFeatureIgnored = this._featureTags.Where(__entry => __entry != null).Where(__entry => String.Equals(__entry, "ignore", StringComparison.CurrentCultureIgnoreCase)).Any();
            }
            if ((isScenarioIgnored || isFeatureIgnored))
            {
                testRunner.SkipScenario();
            }
            else
            {
                this.ScenarioStart();
#line 9
 testRunner.Given("LoginUser Trader With Username testtrader And Password P@10+1020", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line hidden
#line 10
 testRunner.And("Search Stock Symbol  وپست", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 11
 testRunner.And("Search And Select Customer name نامنی باران سادات", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 12
 testRunner.And(string.Format("Order the stock symbol IRO1BPST0001 Enter the {0}imum price plus {1} and the {2}i" +
                            "mum number plus {3}", price, plusprice, number, plusnumber), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 13
 testRunner.And(string.Format("select Time range type {0}", timerange), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 14
 testRunner.When("Save stock symbol Draft order Trader information", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 15
 testRunner.Then("the result should Draft Buy shares of the Stock symbol", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            }
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Draft  Sell stock symbol with  amount and  number of Range time")]
        [NUnit.Framework.CategoryAttribute("GotostationDev")]
        [NUnit.Framework.CategoryAttribute("LogoutUserStation")]
        [NUnit.Framework.CategoryAttribute("BuyMin")]
        [NUnit.Framework.CategoryAttribute("inTheDay")]
        [NUnit.Framework.CategoryAttribute("Positivetest")]
        [NUnit.Framework.TestCaseAttribute("min", "min", "0", "0", "روز", null)]
        [NUnit.Framework.TestCaseAttribute("min", "max", "0", "0", "انجام و حذف", null)]
        [NUnit.Framework.TestCaseAttribute("max", "max", "0", "0", "معتبر تا لغو", null)]
        [NUnit.Framework.TestCaseAttribute("max", "min", "0", "0", "معتبر تا تاریخ", null)]
        public virtual void DraftSellStockSymbolWithAmountAndNumberOfRangeTime(string price, string number, string plusprice, string plusnumber, string timerange, string[] exampleTags)
        {
            string[] @__tags = new string[] {
                    "GotostationDev",
                    "LogoutUserStation",
                    "BuyMin",
                    "inTheDay",
                    "Positivetest"};
            if ((exampleTags != null))
            {
                @__tags = System.Linq.Enumerable.ToArray(System.Linq.Enumerable.Concat(@__tags, exampleTags));
            }
            string[] tagsOfScenario = @__tags;
            System.Collections.Specialized.OrderedDictionary argumentsOfScenario = new System.Collections.Specialized.OrderedDictionary();
            argumentsOfScenario.Add("price", price);
            argumentsOfScenario.Add("number", number);
            argumentsOfScenario.Add("plusprice", plusprice);
            argumentsOfScenario.Add("plusnumber", plusnumber);
            argumentsOfScenario.Add("timerange", timerange);
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Draft  Sell stock symbol with  amount and  number of Range time", null, tagsOfScenario, argumentsOfScenario, this._featureTags);
#line 25
this.ScenarioInitialize(scenarioInfo);
#line hidden
            bool isScenarioIgnored = default(bool);
            bool isFeatureIgnored = default(bool);
            if ((tagsOfScenario != null))
            {
                isScenarioIgnored = tagsOfScenario.Where(__entry => __entry != null).Where(__entry => String.Equals(__entry, "ignore", StringComparison.CurrentCultureIgnoreCase)).Any();
            }
            if ((this._featureTags != null))
            {
                isFeatureIgnored = this._featureTags.Where(__entry => __entry != null).Where(__entry => String.Equals(__entry, "ignore", StringComparison.CurrentCultureIgnoreCase)).Any();
            }
            if ((isScenarioIgnored || isFeatureIgnored))
            {
                testRunner.SkipScenario();
            }
            else
            {
                this.ScenarioStart();
#line 26
 testRunner.Given("LoginUser Trader With Username testtrader And Password P@10+1020", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line hidden
#line 27
 testRunner.And("Search Stock Symbol  وپست", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 28
 testRunner.And("Go to tab Sell Station", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 29
 testRunner.And("Search And Select Customer name نامنی باران سادات", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 30
 testRunner.And(string.Format("Order the stock symbol IRO1BPST0001 Enter the {0}imum price plus {1} and the {2}i" +
                            "mum number plus {3}", price, plusprice, number, plusnumber), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 31
 testRunner.And(string.Format("select Time range type {0}", timerange), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 32
 testRunner.When("Save stock symbol Draft order Trader information", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 33
 testRunner.Then("the result should Draft Sell shares of the Stock symbol", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            }
            this.ScenarioCleanup();
        }
    }
}
#pragma warning restore
#endregion
