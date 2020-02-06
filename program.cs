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

            Console.WriteLine("Fantasy Football Stats Scrape");
            Console.WriteLine("select a player to search");
            var playerOne = Console.ReadLine();

            chromeDriver.FindElementById("searchQuery").SendKeys(playerOne);
            chromeDriver.FindElementByName("jSubmit").Click();


            chromeDriver.FindElementByClassName("playerCard").Click();

            var table = chromeDriver.FindElementByTagName("tbody");

            //opponent
            //var playerOneOpponent = chromeDriver.FindElementByClassName("weeklyPlayerOpponentStaus").Text;
            //Console.WriteLine(playerOne + "vs" + playerOneOpponent);

            //player one passing yards
            var playerOnePassingYards = chromeDriver.FindElementByClassName("statId-5").Text;
            Console.WriteLine("Passing Yards: " + playerOnePassingYards);

            //player one passing touchdowns
            var playerOnePassingTouchDowns = chromeDriver.FindElementByClassName("statId-6").Text;
            Console.WriteLine("Passing Touchdowns: " + playerOnePassingTouchDowns);

            //player one picks
            var playerOneInterceptions = chromeDriver.FindElementByClassName("statId-7").Text;
            Console.WriteLine("Interceptions: " + playerOneInterceptions);

            //player one rushing yards
            var playerOneRushingYards = chromeDriver.FindElementByClassName("statId-14").Text;
            Console.WriteLine("Rushing Yards: " + playerOneRushingYards);

            //player one lost fumbles
            var playerOneLostFumbles = chromeDriver.FindElementByClassName("statId-30").Text;
            Console.WriteLine("Lost Fumbles: " + playerOneLostFumbles);

            var playerOneTotalFantasyPoints = chromeDriver.FindElementByClassName("playerSeasonTotal").Text;
            Console.WriteLine("Total Fantasy Points: " + playerOneTotalFantasyPoints);


            //var yards = chromeDriver.FindElementsByXPath("/html/body/div/div[5]/div/div[3]/div[1]/div[4]/div[3]/div/div/table/tbody/tr[1]/td[3]");




            //var row = chromeDriver.FindElementByClassName("playerOpponenet");


            //Console.WriteLine(table);


            //Console.WriteLine(table);


            //chromeDriver.FindElementById("email").SendKeys("marcusgalvin@gmail.com");


            //chromeDriver.Keyboard


        }
    }
}
