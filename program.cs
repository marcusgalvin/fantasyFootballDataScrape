using System;
using OpenQA.Selenium.Chrome;

namespace espnScraper
{
    class MainClass
    {
        public static void Main(string[] args)
        {


            var options = new ChromeOptions();
            options.AddArguments("--disable-gpu");

            var chromeDriver = new ChromeDriver(options);



            chromeDriver.Navigate().GoToUrl("https://fantasy.nfl.com/research/scoringleaders?position=1");


            chromeDriver.FindElementById("searchQuery").SendKeys("Patrick Mahomes");
            chromeDriver.FindElementByName("jSubmit").Click();

            //chromeDriver.FindElementById("email").SendKeys("marcusgalvin@gmail.com");


            //chromeDriver.Keyboard

            //chromeDriver.FindElementById("pass").SendKeys("magnetpaper");

        }
    }
}
