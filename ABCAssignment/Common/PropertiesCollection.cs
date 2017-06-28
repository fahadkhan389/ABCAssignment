using OpenQA.Selenium;

namespace OnlineRacingBet.Common
{
    public enum IdentityType
    {
        Id,
        Xpath,
        Name
    }

    public class PropertiesCollection
    {
        public static IWebDriver driver { get; set; }
    }
}
