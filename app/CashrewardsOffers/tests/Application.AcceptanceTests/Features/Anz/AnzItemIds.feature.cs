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
namespace CashrewardsOffers.Application.AcceptanceTests.Features.Anz
{
    using TechTalk.SpecFlow;
    using System;
    using System.Linq;
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("TechTalk.SpecFlow", "3.9.0.0")]
    [System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [NUnit.Framework.TestFixtureAttribute()]
    [NUnit.Framework.DescriptionAttribute("ANZ Offers API - ID")]
    public partial class ANZOffersAPI_IDFeature
    {
        
        private TechTalk.SpecFlow.ITestRunner testRunner;
        
        private static string[] featureTags = ((string[])(null));
        
#line 1 "AnzItemIds.feature"
#line hidden
        
        [NUnit.Framework.OneTimeSetUpAttribute()]
        public virtual void FeatureSetup()
        {
            testRunner = TechTalk.SpecFlow.TestRunnerManager.GetTestRunner();
            TechTalk.SpecFlow.FeatureInfo featureInfo = new TechTalk.SpecFlow.FeatureInfo(new System.Globalization.CultureInfo("en-AU"), "Features/Anz", "ANZ Offers API - ID", @"    As PM
    I want to create an API for ANZ to show the ID for a list of merchants and offers from the following carousels:
    Max+ANZ offers carousel
    Popular Stores carousel
    Featured Offers carousel
    In-Store carousel

    So that ANZ can get a list of updated merchants and offers to be stored in their system to be displayed on the ANZ app for users to view CR offers and merchants and be redirected to the CR site", ProgrammingLanguage.CSharp, featureTags);
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
        [NUnit.Framework.DescriptionAttribute("Available fields in API response for ANZ")]
        [NUnit.Framework.TestCaseAttribute("TotalOffersCount", "mandatory", null)]
        [NUnit.Framework.TestCaseAttribute("Items[].Id", "mandatory", null)]
        [NUnit.Framework.TestCaseAttribute("Items[].Merchant.Id", "mandatory", null)]
        [NUnit.Framework.TestCaseAttribute("Items[].Offer.Id", "optional", null)]
        public void AvailableFieldsInAPIResponseForANZ(string fields, string mandatory, string[] exampleTags)
        {
            string[] tagsOfScenario = exampleTags;
            System.Collections.Specialized.OrderedDictionary argumentsOfScenario = new System.Collections.Specialized.OrderedDictionary();
            argumentsOfScenario.Add("fields", fields);
            argumentsOfScenario.Add("mandatory", mandatory);
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Available fields in API response for ANZ", null, tagsOfScenario, argumentsOfScenario, featureTags);
#line 12
    this.ScenarioInitialize(scenarioInfo);
#line hidden
            if ((TagHelper.ContainsIgnoreTag(tagsOfScenario) || TagHelper.ContainsIgnoreTag(featureTags)))
            {
                testRunner.SkipScenario();
            }
            else
            {
                this.ScenarioStart();
#line 14
        testRunner.Given("API for ANZ is available", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line hidden
#line 15
        testRunner.When("I call the api", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 16
        testRunner.And("auth token is valid", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 17
        testRunner.Then(string.Format("the API returns the \'{0}\' for Merchant and Offer in the response as \'{1}\'", fields, mandatory), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            }
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("List of Offers in Featured Offers Carousel")]
        [NUnit.Framework.TestCaseAttribute("Yes", "ANZ", "exclude", null)]
        [NUnit.Framework.TestCaseAttribute("Yes", "ANZ, CR", "include", null)]
        [NUnit.Framework.TestCaseAttribute("Yes", "ANZ, CR, MME", "include", null)]
        [NUnit.Framework.TestCaseAttribute("Yes", "CR", "include", null)]
        [NUnit.Framework.TestCaseAttribute("Yes", "CR, MME", "include", null)]
        [NUnit.Framework.TestCaseAttribute("Yes", "MME", "exclude", null)]
        [NUnit.Framework.TestCaseAttribute("NO", "ANZ", "exclude", null)]
        [NUnit.Framework.TestCaseAttribute("No", "ANZ, CR", "exclude", null)]
        [NUnit.Framework.TestCaseAttribute("No", "ANZ, CR, MME", "exclude", null)]
        [NUnit.Framework.TestCaseAttribute("No", "CR", "exclude", null)]
        [NUnit.Framework.TestCaseAttribute("No", "CR, MME", "exclude", null)]
        [NUnit.Framework.TestCaseAttribute("No", "MME", "exclude", null)]
        public void ListOfOffersInFeaturedOffersCarousel(string currentlyFeatured, string clientMapping, string result, string[] exampleTags)
        {
            string[] tagsOfScenario = exampleTags;
            System.Collections.Specialized.OrderedDictionary argumentsOfScenario = new System.Collections.Specialized.OrderedDictionary();
            argumentsOfScenario.Add("currently featured", currentlyFeatured);
            argumentsOfScenario.Add("client mapping", clientMapping);
            argumentsOfScenario.Add("result", result);
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("List of Offers in Featured Offers Carousel", null, tagsOfScenario, argumentsOfScenario, featureTags);
#line 28
    this.ScenarioInitialize(scenarioInfo);
#line hidden
            if ((TagHelper.ContainsIgnoreTag(tagsOfScenario) || TagHelper.ContainsIgnoreTag(featureTags)))
            {
                testRunner.SkipScenario();
            }
            else
            {
                this.ScenarioStart();
#line 30
        testRunner.Given("API for ANZ is available", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line hidden
#line 31
        testRunner.And(string.Format("Offer is set to currently featured \'{0}\'", currentlyFeatured), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 32
        testRunner.And(string.Format("Offer is mapped to \'{0}\'", clientMapping), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 33
        testRunner.When("I call the api", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 34
        testRunner.And("auth token is valid", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 35
        testRunner.Then(string.Format("the API \'{0}\' the offer in the response with the specified fields", result), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            }
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("List of Merchants in Popular Stores Carousel")]
        [NUnit.Framework.TestCaseAttribute("Yes", "ANZ", "exclude", null)]
        [NUnit.Framework.TestCaseAttribute("Yes", "ANZ, CR", "include", null)]
        [NUnit.Framework.TestCaseAttribute("Yes", "ANZ, CR, MME", "include", null)]
        [NUnit.Framework.TestCaseAttribute("Yes", "CR", "include", null)]
        [NUnit.Framework.TestCaseAttribute("Yes", "CR, MME", "include", null)]
        [NUnit.Framework.TestCaseAttribute("Yes", "MME", "exclude", null)]
        [NUnit.Framework.TestCaseAttribute("NO", "ANZ", "exclude", null)]
        [NUnit.Framework.TestCaseAttribute("No", "ANZ, CR", "exclude", null)]
        [NUnit.Framework.TestCaseAttribute("No", "ANZ, CR, MME", "exclude", null)]
        [NUnit.Framework.TestCaseAttribute("No", "CR", "exclude", null)]
        [NUnit.Framework.TestCaseAttribute("No", "CR, MME", "exclude", null)]
        [NUnit.Framework.TestCaseAttribute("No", "MME", "exclude", null)]
        public void ListOfMerchantsInPopularStoresCarousel(string popular, string clientMapping, string result, string[] exampleTags)
        {
            string[] tagsOfScenario = exampleTags;
            System.Collections.Specialized.OrderedDictionary argumentsOfScenario = new System.Collections.Specialized.OrderedDictionary();
            argumentsOfScenario.Add("Popular", popular);
            argumentsOfScenario.Add("client mapping", clientMapping);
            argumentsOfScenario.Add("result", result);
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("List of Merchants in Popular Stores Carousel", null, tagsOfScenario, argumentsOfScenario, featureTags);
#line 53
    this.ScenarioInitialize(scenarioInfo);
#line hidden
            if ((TagHelper.ContainsIgnoreTag(tagsOfScenario) || TagHelper.ContainsIgnoreTag(featureTags)))
            {
                testRunner.SkipScenario();
            }
            else
            {
                this.ScenarioStart();
#line 55
        testRunner.Given("API for ANZ is available", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line hidden
#line 56
        testRunner.And(string.Format("Merchant is set to \'{0}\'", popular), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 57
        testRunner.And(string.Format("Merchant is mapped to \'{0}\'", clientMapping), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 58
        testRunner.When("I call the api", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 59
        testRunner.And("auth token is valid", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 60
        testRunner.Then(string.Format("the API \'{0}\' the Merchant in the response with the specified fields", result), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            }
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("List of Merchants in In-Store Carousel")]
        [NUnit.Framework.TestCaseAttribute("InStore", "ANZ", "exclude", null)]
        [NUnit.Framework.TestCaseAttribute("InStore", "ANZ, CR", "include", null)]
        [NUnit.Framework.TestCaseAttribute("InStore", "ANZ, CR, MME", "include", null)]
        [NUnit.Framework.TestCaseAttribute("InStore", "CR", "include", null)]
        [NUnit.Framework.TestCaseAttribute("InStore", "CR, MME", "include", null)]
        [NUnit.Framework.TestCaseAttribute("InStore", "MME", "exclude", null)]
        [NUnit.Framework.TestCaseAttribute("Other network", "ANZ", "exclude", null)]
        [NUnit.Framework.TestCaseAttribute("Other network", "ANZ, CR", "exclude", null)]
        [NUnit.Framework.TestCaseAttribute("Other network", "ANZ, CR, MME", "exclude", null)]
        [NUnit.Framework.TestCaseAttribute("Other network", "CR", "exclude", null)]
        [NUnit.Framework.TestCaseAttribute("Other network", "CR, MME", "exclude", null)]
        [NUnit.Framework.TestCaseAttribute("NOther networko", "MME", "exclude", null)]
        public void ListOfMerchantsInIn_StoreCarousel(string networkName, string clientMapping, string result, string[] exampleTags)
        {
            string[] tagsOfScenario = exampleTags;
            System.Collections.Specialized.OrderedDictionary argumentsOfScenario = new System.Collections.Specialized.OrderedDictionary();
            argumentsOfScenario.Add("NetworkName", networkName);
            argumentsOfScenario.Add("client mapping", clientMapping);
            argumentsOfScenario.Add("result", result);
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("List of Merchants in In-Store Carousel", null, tagsOfScenario, argumentsOfScenario, featureTags);
#line 78
    this.ScenarioInitialize(scenarioInfo);
#line hidden
            if ((TagHelper.ContainsIgnoreTag(tagsOfScenario) || TagHelper.ContainsIgnoreTag(featureTags)))
            {
                testRunner.SkipScenario();
            }
            else
            {
                this.ScenarioStart();
#line 80
        testRunner.Given("API for ANZ is available", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line hidden
#line 81
        testRunner.And(string.Format("Merchants network is set to \'{0}\'", networkName), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 82
        testRunner.And(string.Format("Merchant is mapped to \'{0}\'", clientMapping), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 83
        testRunner.When("I call the api", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 84
        testRunner.And("auth token is valid", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 85
        testRunner.Then(string.Format("the API \'{0}\' the Merchant in the response with the specified fields", result), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            }
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Display ANZ merchant and offers enabled for Mobile")]
        [NUnit.Framework.TestCaseAttribute("Featured offers", "Yes", "Yes", "Yes", "include", null)]
        [NUnit.Framework.TestCaseAttribute("Featured offers", "Yes", "Yes", "No", "include", null)]
        [NUnit.Framework.TestCaseAttribute("Featured offers", "Yes", "No", "Yes", "include", null)]
        [NUnit.Framework.TestCaseAttribute("Featured offers", "Yes", "No", "No", "include", null)]
        [NUnit.Framework.TestCaseAttribute("Featured offers", "No", "Yes", "Yes", "exclude", null)]
        [NUnit.Framework.TestCaseAttribute("Featured offers", "No", "Yes", "No", "exclude", null)]
        [NUnit.Framework.TestCaseAttribute("Featured offers", "No", "No", "Yes", "exclude", null)]
        [NUnit.Framework.TestCaseAttribute("Featured offers", "No", "No", "No", "exclude", null)]
        [NUnit.Framework.TestCaseAttribute("In-Store", "Yes", "Yes", "Yes", "include", null)]
        [NUnit.Framework.TestCaseAttribute("In-Store", "Yes", "Yes", "No", "include", null)]
        [NUnit.Framework.TestCaseAttribute("In-Store", "Yes", "No", "Yes", "include", null)]
        [NUnit.Framework.TestCaseAttribute("In-Store", "Yes", "No", "No", "include", null)]
        [NUnit.Framework.TestCaseAttribute("In-Store", "No", "Yes", "Yes", "exclude", null)]
        [NUnit.Framework.TestCaseAttribute("In-Store", "No", "Yes", "No", "exclude", null)]
        [NUnit.Framework.TestCaseAttribute("In-Store", "No", "No", "Yes", "exclude", null)]
        [NUnit.Framework.TestCaseAttribute("In-Store", "No", "No", "No", "exclude", null)]
        [NUnit.Framework.TestCaseAttribute("Popular Store", "Yes", "Yes", "Yes", "include", null)]
        [NUnit.Framework.TestCaseAttribute("Popular Store", "Yes", "Yes", "No", "include", null)]
        [NUnit.Framework.TestCaseAttribute("Popular Store", "Yes", "No", "Yes", "include", null)]
        [NUnit.Framework.TestCaseAttribute("Popular Store", "Yes", "No", "No", "include", null)]
        [NUnit.Framework.TestCaseAttribute("Popular Store", "No", "Yes", "Yes", "exclude", null)]
        [NUnit.Framework.TestCaseAttribute("Popular Store", "No", "Yes", "No", "exclude", null)]
        [NUnit.Framework.TestCaseAttribute("Popular Store", "No", "No", "Yes", "exclude", null)]
        [NUnit.Framework.TestCaseAttribute("Popular Store", "No", "No", "No", "exclude", null)]
        public void DisplayANZMerchantAndOffersEnabledForMobile(string aPI, string mobileEnabled, string tabletEnabled, string mobileAppEnabled, string result, string[] exampleTags)
        {
            string[] tagsOfScenario = exampleTags;
            System.Collections.Specialized.OrderedDictionary argumentsOfScenario = new System.Collections.Specialized.OrderedDictionary();
            argumentsOfScenario.Add("API", aPI);
            argumentsOfScenario.Add("MobileEnabled", mobileEnabled);
            argumentsOfScenario.Add("TabletEnabled", tabletEnabled);
            argumentsOfScenario.Add("MobileAppEnabled", mobileAppEnabled);
            argumentsOfScenario.Add("result", result);
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Display ANZ merchant and offers enabled for Mobile", null, tagsOfScenario, argumentsOfScenario, featureTags);
#line 103
    this.ScenarioInitialize(scenarioInfo);
#line hidden
            if ((TagHelper.ContainsIgnoreTag(tagsOfScenario) || TagHelper.ContainsIgnoreTag(featureTags)))
            {
                testRunner.SkipScenario();
            }
            else
            {
                this.ScenarioStart();
#line 105
        testRunner.Given(string.Format("\'{0}\' for ANZ is available", aPI), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line hidden
#line 106
        testRunner.And(string.Format("Merchants Mobile Enabled is set to \'{0}\'", mobileEnabled), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 107
        testRunner.And(string.Format("Merchants Tablet Enabled is set to \'{0}\'", mobileAppEnabled), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 108
        testRunner.And(string.Format("Merchants Mobile App Enabled is set to \'{0}\'", mobileAppEnabled), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 109
        testRunner.When("I call the api", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 110
        testRunner.And("auth token is valid", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 111
        testRunner.Then(string.Format("the API \'{0}\' the Merchant and Offer in the response with the specified fields", result), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            }
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Suppressed merchants not displayed in any carousels of ANZ app")]
        [NUnit.Framework.TestCaseAttribute("Featured offers", "0", "include", null)]
        [NUnit.Framework.TestCaseAttribute("Featured offers", "1", "exclude", null)]
        [NUnit.Framework.TestCaseAttribute("In-Store", "0", "include", null)]
        [NUnit.Framework.TestCaseAttribute("In-Store", "1", "exclude", null)]
        [NUnit.Framework.TestCaseAttribute("Popular Store", "0", "include", null)]
        [NUnit.Framework.TestCaseAttribute("Popular Store", "1", "exclude", null)]
        public void SuppressedMerchantsNotDisplayedInAnyCarouselsOfANZApp(string aPI, string isPremiumDisabled, string result, string[] exampleTags)
        {
            string[] tagsOfScenario = exampleTags;
            System.Collections.Specialized.OrderedDictionary argumentsOfScenario = new System.Collections.Specialized.OrderedDictionary();
            argumentsOfScenario.Add("API", aPI);
            argumentsOfScenario.Add("IsPremiumDisabled", isPremiumDisabled);
            argumentsOfScenario.Add("result", result);
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Suppressed merchants not displayed in any carousels of ANZ app", null, tagsOfScenario, argumentsOfScenario, featureTags);
#line 141
    this.ScenarioInitialize(scenarioInfo);
#line hidden
            if ((TagHelper.ContainsIgnoreTag(tagsOfScenario) || TagHelper.ContainsIgnoreTag(featureTags)))
            {
                testRunner.SkipScenario();
            }
            else
            {
                this.ScenarioStart();
#line 143
        testRunner.Given(string.Format("\'{0}\' for ANZ is available", aPI), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line hidden
#line 144
        testRunner.And(string.Format("Merchants Suppressed for Max member is set to \'{0}\'", isPremiumDisabled), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 145
        testRunner.When("I call the api", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 146
        testRunner.And("auth token is valid", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 147
        testRunner.Then(string.Format("the API \'{0}\' the Merchant and Offer in the response with the specified fields", result), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            }
            this.ScenarioCleanup();
        }
    }
}
#pragma warning restore
#endregion
