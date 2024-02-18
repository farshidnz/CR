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
namespace CashrewardsOffers.Application.AcceptanceTests.Features.EdmMerchants
{
    using TechTalk.SpecFlow;
    using System;
    using System.Linq;
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("TechTalk.SpecFlow", "3.9.0.0")]
    [System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [NUnit.Framework.TestFixtureAttribute()]
    [NUnit.Framework.DescriptionAttribute("GetEdmMerchants")]
    public partial class GetEdmMerchantsFeature
    {
        
        private TechTalk.SpecFlow.ITestRunner testRunner;
        
        private static string[] featureTags = ((string[])(null));
        
#line 1 "GetEdmMerchants.feature"
#line hidden
        
        [NUnit.Framework.OneTimeSetUpAttribute()]
        public virtual void FeatureSetup()
        {
            testRunner = TechTalk.SpecFlow.TestRunnerManager.GetTestRunner();
            TechTalk.SpecFlow.FeatureInfo featureInfo = new TechTalk.SpecFlow.FeatureInfo(new System.Globalization.CultureInfo("en-AU"), "Features/EdmMerchants", "GetEdmMerchants", "An API that gets merchant information in a format to be consumed by Electronic Di" +
                    "rect Mail provider LeanPlum.", ProgrammingLanguage.CSharp, featureTags);
            testRunner.OnFeatureStart(featureInfo);
        }
        
        [NUnit.Framework.OneTimeTearDownAttribute()]
        public virtual void FeatureTearDown()
        {
            testRunner.OnFeatureEnd();
            testRunner = null;
        }
        
        [NUnit.Framework.SetUpAttribute()]
        public void TestInitialize()
        {
        }
        
        [NUnit.Framework.TearDownAttribute()]
        public void TestTearDown()
        {
            testRunner.OnScenarioEnd();
        }
        
        public void ScenarioInitialize(TechTalk.SpecFlow.ScenarioInfo scenarioInfo)
        {
            testRunner.OnScenarioInitialize(scenarioInfo);
            testRunner.ScenarioContext.ScenarioContainer.RegisterInstanceAs<NUnit.Framework.TestContext>(NUnit.Framework.TestContext.CurrentContext);
        }
        
        public void ScenarioStart()
        {
            testRunner.OnScenarioStart();
        }
        
        public void ScenarioCleanup()
        {
            testRunner.CollectScenarioErrors();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Default merchants without any personalisation")]
        public void DefaultMerchantsWithoutAnyPersonalisation()
        {
            string[] tagsOfScenario = ((string[])(null));
            System.Collections.Specialized.OrderedDictionary argumentsOfScenario = new System.Collections.Specialized.OrderedDictionary();
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Default merchants without any personalisation", null, tagsOfScenario, argumentsOfScenario, featureTags);
#line 5
this.ScenarioInitialize(scenarioInfo);
#line hidden
            if ((TagHelper.ContainsIgnoreTag(tagsOfScenario) || TagHelper.ContainsIgnoreTag(featureTags)))
            {
                testRunner.SkipScenario();
            }
            else
            {
                this.ScenarioStart();
#line 6
 testRunner.Given("default merchants exist in the ShopGo database", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line hidden
#line 7
 testRunner.Given("the merchant sync job has run", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line hidden
#line 8
 testRunner.When("I send an EDM merchant query", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
                TechTalk.SpecFlow.Table table122 = new TechTalk.SpecFlow.Table(new string[] {
                            "MerchantHyphenatedString"});
                table122.AddRow(new string[] {
                            "amazon-australia"});
                table122.AddRow(new string[] {
                            "the-iconic"});
                table122.AddRow(new string[] {
                            "myer"});
                table122.AddRow(new string[] {
                            "david-jones"});
                table122.AddRow(new string[] {
                            "bonds"});
                table122.AddRow(new string[] {
                            "groupon"});
#line 9
 testRunner.Then("I should receive EDM merchants in the correct order", ((string)(null)), table122, "Then ");
#line hidden
            }
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Exclude unavailable merchants")]
        public void ExcludeUnavailableMerchants()
        {
            string[] tagsOfScenario = ((string[])(null));
            System.Collections.Specialized.OrderedDictionary argumentsOfScenario = new System.Collections.Specialized.OrderedDictionary();
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Exclude unavailable merchants", null, tagsOfScenario, argumentsOfScenario, featureTags);
#line 20
this.ScenarioInitialize(scenarioInfo);
#line hidden
            if ((TagHelper.ContainsIgnoreTag(tagsOfScenario) || TagHelper.ContainsIgnoreTag(featureTags)))
            {
                testRunner.SkipScenario();
            }
            else
            {
                this.ScenarioStart();
#line 21
 testRunner.Given("default merchants exist in the ShopGo database", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line hidden
#line 22
 testRunner.Given("the merchant \'amazon-australia\' is unavailable", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line hidden
#line 23
 testRunner.Given("the merchant sync job has run", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line hidden
#line 24
 testRunner.When("I send an EDM merchant query", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
                TechTalk.SpecFlow.Table table123 = new TechTalk.SpecFlow.Table(new string[] {
                            "MerchantHyphenatedString"});
                table123.AddRow(new string[] {
                            "the-iconic"});
                table123.AddRow(new string[] {
                            "myer"});
                table123.AddRow(new string[] {
                            "david-jones"});
                table123.AddRow(new string[] {
                            "bonds"});
                table123.AddRow(new string[] {
                            "groupon"});
#line 25
 testRunner.Then("I should receive EDM merchants in the correct order", ((string)(null)), table123, "Then ");
#line hidden
            }
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Include persons favourites first")]
        public void IncludePersonsFavouritesFirst()
        {
            string[] tagsOfScenario = ((string[])(null));
            System.Collections.Specialized.OrderedDictionary argumentsOfScenario = new System.Collections.Specialized.OrderedDictionary();
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Include persons favourites first", null, tagsOfScenario, argumentsOfScenario, featureTags);
#line 35
this.ScenarioInitialize(scenarioInfo);
#line hidden
            if ((TagHelper.ContainsIgnoreTag(tagsOfScenario) || TagHelper.ContainsIgnoreTag(featureTags)))
            {
                testRunner.SkipScenario();
            }
            else
            {
                this.ScenarioStart();
#line 36
 testRunner.Given("default merchants exist in the ShopGo database", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line hidden
#line 37
 testRunner.Given("person with CognitoId \'100\' and NewMemberId \'300\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line hidden
                TechTalk.SpecFlow.Table table124 = new TechTalk.SpecFlow.Table(new string[] {
                            "MerchantId",
                            "HyphenatedString"});
                table124.AddRow(new string[] {
                            "1003604",
                            "apple"});
                table124.AddRow(new string[] {
                            "1004971",
                            "big-w"});
                table124.AddRow(new string[] {
                            "1003511",
                            "veronika-maine"});
#line 38
 testRunner.Given("merchants exist in the ShopGo database", ((string)(null)), table124, "Given ");
#line hidden
                TechTalk.SpecFlow.Table table125 = new TechTalk.SpecFlow.Table(new string[] {
                            "CognitoId",
                            "MerchantId",
                            "hyphenatedString",
                            "SelectionOrder"});
                table125.AddRow(new string[] {
                            "100",
                            "1003604",
                            "apple",
                            "0"});
                table125.AddRow(new string[] {
                            "100",
                            "1004971",
                            "big-w",
                            "1"});
#line 43
 testRunner.Given("person has selected favourites", ((string)(null)), table125, "Given ");
#line hidden
#line 47
 testRunner.Given("the merchant sync job has run", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line hidden
#line 48
 testRunner.When("I send an EDM merchant query with NewMemberId \'300\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
                TechTalk.SpecFlow.Table table126 = new TechTalk.SpecFlow.Table(new string[] {
                            "MerchantHyphenatedString"});
                table126.AddRow(new string[] {
                            "apple"});
                table126.AddRow(new string[] {
                            "big-w"});
                table126.AddRow(new string[] {
                            "amazon-australia"});
                table126.AddRow(new string[] {
                            "the-iconic"});
                table126.AddRow(new string[] {
                            "myer"});
                table126.AddRow(new string[] {
                            "david-jones"});
#line 49
 testRunner.Then("I should receive EDM merchants in the correct order", ((string)(null)), table126, "Then ");
#line hidden
            }
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Include all persons favourites without any default merchants")]
        public void IncludeAllPersonsFavouritesWithoutAnyDefaultMerchants()
        {
            string[] tagsOfScenario = ((string[])(null));
            System.Collections.Specialized.OrderedDictionary argumentsOfScenario = new System.Collections.Specialized.OrderedDictionary();
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Include all persons favourites without any default merchants", null, tagsOfScenario, argumentsOfScenario, featureTags);
#line 60
this.ScenarioInitialize(scenarioInfo);
#line hidden
            if ((TagHelper.ContainsIgnoreTag(tagsOfScenario) || TagHelper.ContainsIgnoreTag(featureTags)))
            {
                testRunner.SkipScenario();
            }
            else
            {
                this.ScenarioStart();
#line 61
 testRunner.Given("default merchants exist in the ShopGo database", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line hidden
#line 62
 testRunner.Given("person with CognitoId \'100\' and NewMemberId \'300\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line hidden
                TechTalk.SpecFlow.Table table127 = new TechTalk.SpecFlow.Table(new string[] {
                            "MerchantId",
                            "HyphenatedString"});
                table127.AddRow(new string[] {
                            "1003604",
                            "apple"});
                table127.AddRow(new string[] {
                            "1004971",
                            "big-w"});
                table127.AddRow(new string[] {
                            "1001460",
                            "get-wines-direct"});
                table127.AddRow(new string[] {
                            "1003511",
                            "veronika-maine"});
                table127.AddRow(new string[] {
                            "1003663",
                            "liquorland"});
                table127.AddRow(new string[] {
                            "1003877",
                            "dell-australia"});
                table127.AddRow(new string[] {
                            "1002933",
                            "hotels-com"});
#line 63
 testRunner.Given("merchants exist in the ShopGo database", ((string)(null)), table127, "Given ");
#line hidden
                TechTalk.SpecFlow.Table table128 = new TechTalk.SpecFlow.Table(new string[] {
                            "CognitoId",
                            "MerchantId",
                            "hyphenatedString",
                            "SelectionOrder"});
                table128.AddRow(new string[] {
                            "100",
                            "1004971",
                            "big-w",
                            "1"});
                table128.AddRow(new string[] {
                            "100",
                            "1001460",
                            "get-wines-direct",
                            "2"});
                table128.AddRow(new string[] {
                            "100",
                            "1003511",
                            "veronika-maine",
                            "3"});
                table128.AddRow(new string[] {
                            "100",
                            "1003663",
                            "liquorland",
                            "4"});
                table128.AddRow(new string[] {
                            "100",
                            "1003877",
                            "dell-australia",
                            "5"});
                table128.AddRow(new string[] {
                            "100",
                            "1002933",
                            "hotels-com",
                            "6"});
#line 72
 testRunner.Given("person has selected favourites", ((string)(null)), table128, "Given ");
#line hidden
#line 80
 testRunner.Given("the merchant sync job has run", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line hidden
#line 81
 testRunner.When("I send an EDM merchant query with NewMemberId \'300\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
                TechTalk.SpecFlow.Table table129 = new TechTalk.SpecFlow.Table(new string[] {
                            "MerchantHyphenatedString"});
                table129.AddRow(new string[] {
                            "big-w"});
                table129.AddRow(new string[] {
                            "get-wines-direct"});
                table129.AddRow(new string[] {
                            "veronika-maine"});
                table129.AddRow(new string[] {
                            "liquorland"});
                table129.AddRow(new string[] {
                            "dell-australia"});
                table129.AddRow(new string[] {
                            "hotels-com"});
#line 82
 testRunner.Then("I should receive EDM merchants in the correct order", ((string)(null)), table129, "Then ");
#line hidden
            }
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("When a person selects a default merchant as favourite then it appears first")]
        public void WhenAPersonSelectsADefaultMerchantAsFavouriteThenItAppearsFirst()
        {
            string[] tagsOfScenario = ((string[])(null));
            System.Collections.Specialized.OrderedDictionary argumentsOfScenario = new System.Collections.Specialized.OrderedDictionary();
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("When a person selects a default merchant as favourite then it appears first", null, tagsOfScenario, argumentsOfScenario, featureTags);
#line 93
this.ScenarioInitialize(scenarioInfo);
#line hidden
            if ((TagHelper.ContainsIgnoreTag(tagsOfScenario) || TagHelper.ContainsIgnoreTag(featureTags)))
            {
                testRunner.SkipScenario();
            }
            else
            {
                this.ScenarioStart();
#line 94
 testRunner.Given("default merchants exist in the ShopGo database", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line hidden
#line 95
 testRunner.Given("person with CognitoId \'100\' and NewMemberId \'300\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line hidden
                TechTalk.SpecFlow.Table table130 = new TechTalk.SpecFlow.Table(new string[] {
                            "CognitoId",
                            "MerchantId",
                            "hyphenatedString",
                            "SelectionOrder"});
                table130.AddRow(new string[] {
                            "100",
                            "1001527",
                            "bonds",
                            "0"});
#line 96
 testRunner.Given("person has selected favourites", ((string)(null)), table130, "Given ");
#line hidden
#line 99
 testRunner.Given("the merchant sync job has run", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line hidden
#line 100
 testRunner.When("I send an EDM merchant query with NewMemberId \'300\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
                TechTalk.SpecFlow.Table table131 = new TechTalk.SpecFlow.Table(new string[] {
                            "MerchantHyphenatedString"});
                table131.AddRow(new string[] {
                            "bonds"});
                table131.AddRow(new string[] {
                            "amazon-australia"});
                table131.AddRow(new string[] {
                            "the-iconic"});
                table131.AddRow(new string[] {
                            "myer"});
                table131.AddRow(new string[] {
                            "david-jones"});
                table131.AddRow(new string[] {
                            "groupon"});
#line 101
 testRunner.Then("I should receive EDM merchants in the correct order", ((string)(null)), table131, "Then ");
#line hidden
            }
            this.ScenarioCleanup();
        }
    }
}
#pragma warning restore
#endregion