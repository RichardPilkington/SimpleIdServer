// ------------------------------------------------------------------------------
//  <auto-generated>
//      This code was generated by SpecFlow (http://www.specflow.org/).
//      SpecFlow Version:3.0.0.0
//      SpecFlow Generator Version:3.0.0.0
// 
//      Changes to this file may cause incorrect behavior and will be lost if
//      the code is regenerated.
//  </auto-generated>
// ------------------------------------------------------------------------------
#region Designer generated code
#pragma warning disable
namespace SimpleIdServer.Scim.Host.Acceptance.Tests.Features
{
    using TechTalk.SpecFlow;
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("TechTalk.SpecFlow", "3.0.0.0")]
    [System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    public partial class UsersFeature : Xunit.IClassFixture<UsersFeature.FixtureData>, System.IDisposable
    {
        
        private static TechTalk.SpecFlow.ITestRunner testRunner;
        
        private Xunit.Abstractions.ITestOutputHelper _testOutputHelper;
        
#line 1 "Users.feature"
#line hidden
        
        public UsersFeature(UsersFeature.FixtureData fixtureData, Xunit.Abstractions.ITestOutputHelper testOutputHelper)
        {
            this._testOutputHelper = testOutputHelper;
            this.TestInitialize();
        }
        
        public static void FeatureSetup()
        {
            testRunner = TechTalk.SpecFlow.TestRunnerManager.GetTestRunner();
            TechTalk.SpecFlow.FeatureInfo featureInfo = new TechTalk.SpecFlow.FeatureInfo(new System.Globalization.CultureInfo("en-US"), "Users", "\tCheck the /Users endpoint", ProgrammingLanguage.CSharp, ((string[])(null)));
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
        
        public virtual void ScenarioInitialize(TechTalk.SpecFlow.ScenarioInfo scenarioInfo)
        {
            testRunner.OnScenarioInitialize(scenarioInfo);
            testRunner.ScenarioContext.ScenarioContainer.RegisterInstanceAs<Xunit.Abstractions.ITestOutputHelper>(_testOutputHelper);
        }
        
        public virtual void ScenarioStart()
        {
            testRunner.OnScenarioStart();
        }
        
        public virtual void ScenarioCleanup()
        {
            testRunner.CollectScenarioErrors();
        }
        
        void System.IDisposable.Dispose()
        {
            this.ScenarioTearDown();
        }
        
        [Xunit.FactAttribute(DisplayName="Check User can be created")]
        [Xunit.TraitAttribute("FeatureTitle", "Users")]
        [Xunit.TraitAttribute("Description", "Check User can be created")]
        public virtual void CheckUserCanBeCreated()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Check User can be created", null, ((string[])(null)));
#line 4
this.ScenarioInitialize(scenarioInfo);
            this.ScenarioStart();
#line hidden
            TechTalk.SpecFlow.Table table7 = new TechTalk.SpecFlow.Table(new string[] {
                        "Key",
                        "Value"});
            table7.AddRow(new string[] {
                        "schemas",
                        "[ \"urn:ietf:params:scim:schemas:core:2.0:User\", \"urn:ietf:params:scim:schemas:ext" +
                            "ension:enterprise:2.0:User\" ]"});
            table7.AddRow(new string[] {
                        "userName",
                        "bjen"});
            table7.AddRow(new string[] {
                        "externalId",
                        "externalid"});
            table7.AddRow(new string[] {
                        "name",
                        "{ \"formatted\" : \"formatted\", \"familyName\": \"familyName\", \"givenName\": \"givenName\"" +
                            " }"});
            table7.AddRow(new string[] {
                        "employeeNumber",
                        "number"});
#line 5
 testRunner.When("execute HTTP POST JSON request \'http://localhost/Users\'", ((string)(null)), table7, "When ");
#line 13
 testRunner.And("extract JSON from body", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 15
 testRunner.Then("HTTP status code equals to \'201\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 16
 testRunner.Then("HTTP HEADER contains \'Location\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 17
 testRunner.Then("HTTP HEADER contains \'ETag\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 18
 testRunner.Then("JSON exists \'id\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 19
 testRunner.Then("JSON exists \'meta.created\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 20
 testRunner.Then("JSON exists \'meta.lastModified\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 21
 testRunner.Then("JSON exists \'meta.version\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 22
 testRunner.Then("JSON exists \'meta.location\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 23
 testRunner.Then("JSON \'employeeNumber\'=\'number\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 24
 testRunner.Then("JSON \'externalId\'=\'externalid\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 25
 testRunner.Then("JSON \'meta.resourceType\'=\'Users\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 26
 testRunner.Then("JSON \'userName\'=\'bjen\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 27
 testRunner.Then("JSON \'name.formatted\'=\'formatted\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 28
 testRunner.Then("JSON \'name.familyName\'=\'familyName\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 29
 testRunner.Then("JSON \'name.givenName\'=\'givenName\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 30
 testRunner.Then("JSON \'org\'=\'ENTREPRISE\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [Xunit.FactAttribute(DisplayName="Check attribute with a mutability equals to readOnly cannot be overriden")]
        [Xunit.TraitAttribute("FeatureTitle", "Users")]
        [Xunit.TraitAttribute("Description", "Check attribute with a mutability equals to readOnly cannot be overriden")]
        public virtual void CheckAttributeWithAMutabilityEqualsToReadOnlyCannotBeOverriden()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Check attribute with a mutability equals to readOnly cannot be overriden", null, ((string[])(null)));
#line 32
this.ScenarioInitialize(scenarioInfo);
            this.ScenarioStart();
#line hidden
            TechTalk.SpecFlow.Table table8 = new TechTalk.SpecFlow.Table(new string[] {
                        "Key",
                        "Value"});
            table8.AddRow(new string[] {
                        "schemas",
                        "[ \"urn:ietf:params:scim:schemas:core:2.0:User\", \"urn:ietf:params:scim:schemas:ext" +
                            "ension:enterprise:2.0:User\" ]"});
            table8.AddRow(new string[] {
                        "userName",
                        "bjen"});
            table8.AddRow(new string[] {
                        "name",
                        "{ \"formatted\" : \"formatted\", \"familyName\": \"familyName\", \"givenName\": \"givenName\"" +
                            " }"});
            table8.AddRow(new string[] {
                        "groups",
                        "[ { \"value\": \"group\" } ]"});
            table8.AddRow(new string[] {
                        "employeeNumber",
                        "number"});
#line 33
 testRunner.When("execute HTTP POST JSON request \'http://localhost/Users\'", ((string)(null)), table8, "When ");
#line 41
 testRunner.And("extract JSON from body", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 43
 testRunner.Then("HTTP status code equals to \'201\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 44
 testRunner.Then("HTTP HEADER contains \'Location\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 45
 testRunner.Then("HTTP HEADER contains \'ETag\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 46
 testRunner.Then("JSON doesn\'t exists \'groups\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [Xunit.FactAttribute(DisplayName="Check User can be returned")]
        [Xunit.TraitAttribute("FeatureTitle", "Users")]
        [Xunit.TraitAttribute("Description", "Check User can be returned")]
        public virtual void CheckUserCanBeReturned()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Check User can be returned", null, ((string[])(null)));
#line 48
this.ScenarioInitialize(scenarioInfo);
            this.ScenarioStart();
#line hidden
            TechTalk.SpecFlow.Table table9 = new TechTalk.SpecFlow.Table(new string[] {
                        "Key",
                        "Value"});
            table9.AddRow(new string[] {
                        "schemas",
                        "[ \"urn:ietf:params:scim:schemas:core:2.0:User\", \"urn:ietf:params:scim:schemas:ext" +
                            "ension:enterprise:2.0:User\" ]"});
            table9.AddRow(new string[] {
                        "userName",
                        "bjen"});
            table9.AddRow(new string[] {
                        "name",
                        "{ \"formatted\" : \"formatted\", \"familyName\": \"familyName\", \"givenName\": \"givenName\"" +
                            " }"});
            table9.AddRow(new string[] {
                        "employeeNumber",
                        "number"});
#line 49
 testRunner.When("execute HTTP POST JSON request \'http://localhost/Users\'", ((string)(null)), table9, "When ");
#line 56
 testRunner.And("extract JSON from body", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 57
 testRunner.And("extract \'id\' from JSON body", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 58
 testRunner.And("execute HTTP GET request \'http://localhost/Users/$id$\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 59
 testRunner.And("extract JSON from body", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 61
 testRunner.Then("HTTP status code equals to \'200\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 62
 testRunner.Then("HTTP HEADER contains \'Location\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 63
 testRunner.Then("HTTP HEADER contains \'ETag\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [Xunit.FactAttribute(DisplayName="Check user can be removed")]
        [Xunit.TraitAttribute("FeatureTitle", "Users")]
        [Xunit.TraitAttribute("Description", "Check user can be removed")]
        public virtual void CheckUserCanBeRemoved()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Check user can be removed", null, ((string[])(null)));
#line 65
this.ScenarioInitialize(scenarioInfo);
            this.ScenarioStart();
#line hidden
            TechTalk.SpecFlow.Table table10 = new TechTalk.SpecFlow.Table(new string[] {
                        "Key",
                        "Value"});
            table10.AddRow(new string[] {
                        "schemas",
                        "[ \"urn:ietf:params:scim:schemas:core:2.0:User\", \"urn:ietf:params:scim:schemas:ext" +
                            "ension:enterprise:2.0:User\" ]"});
            table10.AddRow(new string[] {
                        "userName",
                        "bjen"});
            table10.AddRow(new string[] {
                        "name",
                        "{ \"formatted\" : \"formatted\", \"familyName\": \"familyName\", \"givenName\": \"givenName\"" +
                            " }"});
            table10.AddRow(new string[] {
                        "employeeNumber",
                        "number"});
#line 66
 testRunner.When("execute HTTP POST JSON request \'http://localhost/Users\'", ((string)(null)), table10, "When ");
#line 73
 testRunner.And("extract JSON from body", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 74
 testRunner.And("extract \'id\' from JSON body", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 75
 testRunner.When("execute HTTP DELETE request \'http://localhost/Users/$id$\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 77
 testRunner.Then("HTTP status code equals to \'204\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [Xunit.FactAttribute(DisplayName="Check user can be filtered")]
        [Xunit.TraitAttribute("FeatureTitle", "Users")]
        [Xunit.TraitAttribute("Description", "Check user can be filtered")]
        public virtual void CheckUserCanBeFiltered()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Check user can be filtered", null, ((string[])(null)));
#line 79
this.ScenarioInitialize(scenarioInfo);
            this.ScenarioStart();
#line hidden
            TechTalk.SpecFlow.Table table11 = new TechTalk.SpecFlow.Table(new string[] {
                        "Key",
                        "Value"});
            table11.AddRow(new string[] {
                        "schemas",
                        "[ \"urn:ietf:params:scim:schemas:core:2.0:User\", \"urn:ietf:params:scim:schemas:ext" +
                            "ension:enterprise:2.0:User\" ]"});
            table11.AddRow(new string[] {
                        "userName",
                        "bjen"});
            table11.AddRow(new string[] {
                        "name",
                        "{ \"formatted\" : \"formatted\", \"familyName\": \"familyName\", \"givenName\": \"givenName\"" +
                            " }"});
            table11.AddRow(new string[] {
                        "phones",
                        "[ { \"phoneNumber\": \"01\", \"type\": \"mobile\" }, { \"phoneNumber\": \"02\", \"type\": \"home" +
                            "\" } ]"});
            table11.AddRow(new string[] {
                        "employeeNumber",
                        "number"});
#line 80
 testRunner.When("execute HTTP POST JSON request \'http://localhost/Users\'", ((string)(null)), table11, "When ");
#line 88
 testRunner.And("execute HTTP GET request \'http://localhost/Users?filter=userName%20eq%20bjen&coun" +
                    "t=3\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 89
 testRunner.And("extract JSON from body", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 91
 testRunner.Then("HTTP status code equals to \'200\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 92
 testRunner.Then("JSON exists \'Resources[0].phones\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 93
 testRunner.Then("JSON \'schemas[0]\'=\'urn:ietf:params:scim:api:messages:2.0:ListResponse\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 94
 testRunner.Then("JSON \'totalResults\'=\'1\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 95
 testRunner.Then("JSON \'startIndex\'=\'0\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 96
 testRunner.Then("JSON \'itemsPerPage\'=\'3\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 97
 testRunner.Then("JSON \'Resources[0].userName\'=\'bjen\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 98
 testRunner.Then("JSON \'Resources[0].name.formatted\'=\'formatted\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 99
 testRunner.Then("JSON \'Resources[0].name.familyName\'=\'familyName\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 100
 testRunner.Then("JSON \'Resources[0].name.givenName\'=\'givenName\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [Xunit.FactAttribute(DisplayName="Check the maxResults option is used when the client is trying to fetch more than " +
            "the allowed number of data")]
        [Xunit.TraitAttribute("FeatureTitle", "Users")]
        [Xunit.TraitAttribute("Description", "Check the maxResults option is used when the client is trying to fetch more than " +
            "the allowed number of data")]
        public virtual void CheckTheMaxResultsOptionIsUsedWhenTheClientIsTryingToFetchMoreThanTheAllowedNumberOfData()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Check the maxResults option is used when the client is trying to fetch more than " +
                    "the allowed number of data", null, ((string[])(null)));
#line 102
this.ScenarioInitialize(scenarioInfo);
            this.ScenarioStart();
#line hidden
            TechTalk.SpecFlow.Table table12 = new TechTalk.SpecFlow.Table(new string[] {
                        "Key",
                        "Value"});
            table12.AddRow(new string[] {
                        "schemas",
                        "[ \"urn:ietf:params:scim:schemas:core:2.0:User\", \"urn:ietf:params:scim:schemas:ext" +
                            "ension:enterprise:2.0:User\" ]"});
            table12.AddRow(new string[] {
                        "userName",
                        "bjen"});
            table12.AddRow(new string[] {
                        "name",
                        "{ \"formatted\" : \"formatted\", \"familyName\": \"familyName\", \"givenName\": \"givenName\"" +
                            " }"});
            table12.AddRow(new string[] {
                        "phones",
                        "[ { \"phoneNumber\": \"01\", \"type\": \"mobile\" }, { \"phoneNumber\": \"02\", \"type\": \"home" +
                            "\" } ]"});
            table12.AddRow(new string[] {
                        "employeeNumber",
                        "number"});
#line 103
 testRunner.When("execute HTTP POST JSON request \'http://localhost/Users\'", ((string)(null)), table12, "When ");
#line 111
 testRunner.And("execute HTTP GET request \'http://localhost/Users?filter=userName%20eq%20bjen&coun" +
                    "t=300\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 112
 testRunner.And("extract JSON from body", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 114
 testRunner.Then("HTTP status code equals to \'200\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 115
 testRunner.Then("JSON \'itemsPerPage\'=\'200\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [Xunit.FactAttribute(DisplayName="Use \'attributes=phones.phoneNumber\' to get only the phone numbers")]
        [Xunit.TraitAttribute("FeatureTitle", "Users")]
        [Xunit.TraitAttribute("Description", "Use \'attributes=phones.phoneNumber\' to get only the phone numbers")]
        public virtual void UseAttributesPhones_PhoneNumberToGetOnlyThePhoneNumbers()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Use \'attributes=phones.phoneNumber\' to get only the phone numbers", null, ((string[])(null)));
#line 117
this.ScenarioInitialize(scenarioInfo);
            this.ScenarioStart();
#line hidden
            TechTalk.SpecFlow.Table table13 = new TechTalk.SpecFlow.Table(new string[] {
                        "Key",
                        "Value"});
            table13.AddRow(new string[] {
                        "schemas",
                        "[ \"urn:ietf:params:scim:schemas:core:2.0:User\", \"urn:ietf:params:scim:schemas:ext" +
                            "ension:enterprise:2.0:User\" ]"});
            table13.AddRow(new string[] {
                        "userName",
                        "bjen"});
            table13.AddRow(new string[] {
                        "name",
                        "{ \"formatted\" : \"formatted\", \"familyName\": \"familyName\", \"givenName\": \"givenName\"" +
                            " }"});
            table13.AddRow(new string[] {
                        "phones",
                        "[ { \"phoneNumber\": \"01\", \"type\": \"mobile\" }, { \"phoneNumber\": \"02\", \"type\": \"home" +
                            "\" } ]"});
            table13.AddRow(new string[] {
                        "employeeNumber",
                        "number"});
#line 118
 testRunner.When("execute HTTP POST JSON request \'http://localhost/Users\'", ((string)(null)), table13, "When ");
#line 126
 testRunner.And("execute HTTP GET request \'http://localhost/Users?filter=userName%20eq%20bjen&coun" +
                    "t=3&attributes=phones.phoneNumber\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 127
 testRunner.And("extract JSON from body", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 129
 testRunner.Then("HTTP status code equals to \'200\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 130
 testRunner.Then("JSON exists \'Resources[0].phones\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 131
 testRunner.Then("JSON \'schemas[0]\'=\'urn:ietf:params:scim:api:messages:2.0:ListResponse\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 132
 testRunner.Then("JSON \'totalResults\'=\'1\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 133
 testRunner.Then("JSON \'startIndex\'=\'0\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 134
 testRunner.Then("JSON \'itemsPerPage\'=\'3\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 135
 testRunner.Then("JSON \'Resources[0].phones[0].phoneNumber\'=\'01\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 136
 testRunner.Then("JSON \'Resources[0].phones[1].phoneNumber\'=\'02\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [Xunit.FactAttribute(DisplayName="Check user can be updated (HTTP PUT)")]
        [Xunit.TraitAttribute("FeatureTitle", "Users")]
        [Xunit.TraitAttribute("Description", "Check user can be updated (HTTP PUT)")]
        public virtual void CheckUserCanBeUpdatedHTTPPUT()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Check user can be updated (HTTP PUT)", null, ((string[])(null)));
#line 138
this.ScenarioInitialize(scenarioInfo);
            this.ScenarioStart();
#line hidden
            TechTalk.SpecFlow.Table table14 = new TechTalk.SpecFlow.Table(new string[] {
                        "Key",
                        "Value"});
            table14.AddRow(new string[] {
                        "schemas",
                        "[ \"urn:ietf:params:scim:schemas:core:2.0:User\", \"urn:ietf:params:scim:schemas:ext" +
                            "ension:enterprise:2.0:User\" ]"});
            table14.AddRow(new string[] {
                        "userName",
                        "bjen"});
            table14.AddRow(new string[] {
                        "name",
                        "{ \"formatted\" : \"formatted\", \"familyName\": \"familyName\", \"givenName\": \"givenName\"" +
                            " }"});
            table14.AddRow(new string[] {
                        "phones",
                        "[ { \"phoneNumber\": \"01\", \"type\": \"mobile\" }, { \"phoneNumber\": \"02\", \"type\": \"home" +
                            "\" } ]"});
            table14.AddRow(new string[] {
                        "employeeNumber",
                        "number"});
#line 139
 testRunner.When("execute HTTP POST JSON request \'http://localhost/Users\'", ((string)(null)), table14, "When ");
#line 147
 testRunner.And("extract JSON from body", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 148
 testRunner.And("extract \'id\' from JSON body", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            TechTalk.SpecFlow.Table table15 = new TechTalk.SpecFlow.Table(new string[] {
                        "Key",
                        "Value"});
            table15.AddRow(new string[] {
                        "schemas",
                        "[ \"urn:ietf:params:scim:schemas:core:2.0:User\" ]"});
            table15.AddRow(new string[] {
                        "name",
                        "{ \"formatted\" : \"newFormatted\", \"familyName\": \"newFamilyName\", \"givenName\": \"newG" +
                            "ivenName\" }"});
#line 149
 testRunner.And("execute HTTP PUT JSON request \'http://localhost/Users/$id$\'", ((string)(null)), table15, "And ");
#line 154
 testRunner.And("execute HTTP GET request \'http://localhost/Users/$id$\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 155
 testRunner.And("extract JSON from body", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 157
 testRunner.Then("HTTP status code equals to \'200\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 158
 testRunner.Then("HTTP HEADER contains \'Location\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 159
 testRunner.Then("HTTP HEADER contains \'ETag\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 160
 testRunner.Then("JSON \'schemas[0]\'=\'urn:ietf:params:scim:schemas:core:2.0:User\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 161
 testRunner.Then("JSON \'userName\'=\'bjen\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 162
 testRunner.Then("JSON \'name.formatted\'=\'newFormatted\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 163
 testRunner.Then("JSON \'name.familyName\'=\'newFamilyName\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 164
 testRunner.Then("JSON \'name.givenName\'=\'newGivenName\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [Xunit.FactAttribute(DisplayName="Check user can be patched (HTTP PATCH)")]
        [Xunit.TraitAttribute("FeatureTitle", "Users")]
        [Xunit.TraitAttribute("Description", "Check user can be patched (HTTP PATCH)")]
        public virtual void CheckUserCanBePatchedHTTPPATCH()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Check user can be patched (HTTP PATCH)", null, ((string[])(null)));
#line 166
this.ScenarioInitialize(scenarioInfo);
            this.ScenarioStart();
#line hidden
            TechTalk.SpecFlow.Table table16 = new TechTalk.SpecFlow.Table(new string[] {
                        "Key",
                        "Value"});
            table16.AddRow(new string[] {
                        "schemas",
                        "[ \"urn:ietf:params:scim:schemas:core:2.0:User\", \"urn:ietf:params:scim:schemas:ext" +
                            "ension:enterprise:2.0:User\" ]"});
            table16.AddRow(new string[] {
                        "userName",
                        "bjen"});
            table16.AddRow(new string[] {
                        "name",
                        "{ \"formatted\" : \"formatted\", \"familyName\": \"familyName\", \"givenName\": \"givenName\"" +
                            " }"});
            table16.AddRow(new string[] {
                        "phones",
                        "[ { \"phoneNumber\": \"01\", \"type\": \"mobile\" }, { \"phoneNumber\": \"02\", \"type\": \"home" +
                            "\" } ]"});
            table16.AddRow(new string[] {
                        "employeeNumber",
                        "number"});
            table16.AddRow(new string[] {
                        "scores",
                        "{ \"math\" : [ { \"score\" : \"10\" } ] }"});
            table16.AddRow(new string[] {
                        "roles",
                        "[ \"role1\", \"role2\" ]"});
#line 167
 testRunner.When("execute HTTP POST JSON request \'http://localhost/Users\'", ((string)(null)), table16, "When ");
#line 177
 testRunner.And("extract JSON from body", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 178
 testRunner.And("extract \'id\' from JSON body", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            TechTalk.SpecFlow.Table table17 = new TechTalk.SpecFlow.Table(new string[] {
                        "Key",
                        "Value"});
            table17.AddRow(new string[] {
                        "schemas",
                        "[ \"urn:ietf:params:scim:api:messages:2.0:PatchOp\" ]"});
            table17.AddRow(new string[] {
                        "Operations",
                        @"[ { ""op"" : ""remove"", ""path"": ""phones[phoneNumber eq 01]"" }, { ""op"": ""add"", ""path"": ""phones"", ""value"": { ""phoneNumber"": ""03"", ""type"": ""mobile"" } }, { ""op"": ""replace"", ""path"": ""userName"", ""value"": ""cassandra"" }, { ""op"" : ""remove"", ""path"": ""scores.math[score eq \""10\""]"" }, { ""op"" : ""add"", ""path"": ""scores.math"", ""value"": { ""score"": ""20"" } }, { ""op"": ""add"", ""path"": ""roles"", ""value"": ""role3"" } ]"});
#line 179
 testRunner.And("execute HTTP PATCH JSON request \'http://localhost/Users/$id$\'", ((string)(null)), table17, "And ");
#line 184
 testRunner.And("execute HTTP GET request \'http://localhost/Users/$id$\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 185
 testRunner.And("extract JSON from body", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 187
 testRunner.Then("HTTP status code equals to \'200\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 188
 testRunner.Then("HTTP HEADER contains \'Location\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 189
 testRunner.Then("HTTP HEADER contains \'ETag\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 190
 testRunner.Then("JSON \'schemas[0]\'=\'urn:ietf:params:scim:schemas:core:2.0:User\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 191
 testRunner.Then("JSON \'userName\'=\'cassandra\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 192
 testRunner.Then("JSON \'phones[0].phoneNumber\'=\'02\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 193
 testRunner.Then("JSON \'phones[0].type\'=\'home\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 194
 testRunner.Then("JSON \'phones[1].phoneNumber\'=\'03\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 195
 testRunner.Then("JSON \'phones[1].type\'=\'mobile\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 196
 testRunner.Then("JSON \'scores.math[0].score\'=\'20\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 197
 testRunner.Then("JSON \'roles[0]\'=\'role1\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 198
 testRunner.Then("JSON \'roles[1]\'=\'role2\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 199
 testRunner.Then("JSON \'roles[2]\'=\'role3\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [System.CodeDom.Compiler.GeneratedCodeAttribute("TechTalk.SpecFlow", "3.0.0.0")]
        [System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
        public class FixtureData : System.IDisposable
        {
            
            public FixtureData()
            {
                UsersFeature.FeatureSetup();
            }
            
            void System.IDisposable.Dispose()
            {
                UsersFeature.FeatureTearDown();
            }
        }
    }
}
#pragma warning restore
#endregion
