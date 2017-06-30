using System;
using ABCAssignment.Pages;
using ABCAssignment.Common;
using TechTalk.SpecFlow;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Net;
using Newtonsoft.Json;
using System.Runtime.Serialization;

namespace ABCAssignment.Steps
{
    [Binding]
    public class APIintegrationSteps
    {
        string url1 = System.Configuration.ConfigurationManager.AppSettings["URLpart1"];
        string environment = System.Configuration.ConfigurationManager.AppSettings["Environment"];
        string url2 = System.Configuration.ConfigurationManager.AppSettings["URLpart2"];
        string ProgramID = System.Configuration.ConfigurationManager.AppSettings["ProgramUniqueID"];

        [When(@"I have access the URL and i should be able to verify Json Values")]
        public void WhenIHaveAccessTheURL()
        {
            try
            {
                string EnvURL = url1 + environment + url2+ ProgramID;
                string json = new WebClient().DownloadString(EnvURL);
                RadioProg radioprog = JsonConvert.DeserializeObject<RadioProg>(json);
                Assert.IsTrue(string.Equals(radioprog.entity, "Program"));
                Assert.IsTrue(string.Equals(radioprog.arid, "ppJj0E8g2R"));
                Assert.IsTrue(string.Equals(radioprog.title, "Mornings"));
                Assert.IsTrue(string.Equals(radioprog.mini_synopsis, "Mornings presents local news and issues, talking with everyday folk about current issues"));
                Assert.IsTrue(string.Equals(radioprog.short_synopsis, "Mornings presents local news and issues, talking with everyday folk about current issues."));
                Assert.IsTrue(string.Equals(radioprog.medium_synopsis, "Mornings presents local news and issues, talking with everyday folk about current issues. Local stories and issues are at the heart of the Mornings program, bringing you fresh local and regional information - including your opportunity to ask direct questions to the ACT Chief Minster each Friday"));

            }
            catch (Exception e)
            {
                throw e;
            }

            
        }

        [DataContract]
        class RadioProg
        {
            [DataMember]
            internal string entity { get; set; }

            [DataMember]
            internal string arid { get; set; }

            [DataMember]
            internal string title { get; set; }
            [DataMember]
            internal string mini_synopsis { get; set; }

            [DataMember]
            internal string short_synopsis { get; set; }
            [DataMember]
            internal string medium_synopsis { get; set; }
            [DataMember]
            internal string created_utc { get; set; }
            [DataMember]
            internal string last_updated_utc { get; set; }
            [DataMember]
            internal string service_airport_code { get; set; }

        }
    }


}
