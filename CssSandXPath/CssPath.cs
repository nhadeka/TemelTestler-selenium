using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;


namespace CssPathXPath
{
    class CssPath
    {
        static void Main()
        {
            string URL = "http://testing.todvachev.com/selectors/css-path/";

            string cssPath = "#post-108 > div > figure > img";

            //*[@id="post - 108"]/div/figure/img => //*[@id=\"post-108\"]/div/figure/img değiştirdik.
            string xPath = "//*[@id=\"post-108\"]/div/figure/img";
            IWebDriver driver = new ChromeDriver();
            driver.Navigate().GoToUrl(URL);
            IWebElement cssPathElement;
            IWebElement xPathElement = driver.FindElement(By.XPath(xPath));
            try
            {
                cssPathElement = driver.FindElement(By.CssSelector(cssPath));
                if (cssPathElement.Displayed)
                {
                    GreenMessage("cssPathElement görünüyor");
                }

            }
            catch (NoSuchElementException)
            {

                RedMessage("sorun var,cssPathElement görünmüyor");
            }
           
          
            if (xPathElement.Displayed)
            {
                GreenMessage("xPathElement görünüyor");
            }
            else
            {
                RedMessage("sorun var,xPathElement görünmüyor");
            }
            driver.Quit();

        }

        static void RedMessage(string mesaj)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(mesaj);
            Console.ForegroundColor = ConsoleColor.White;
        }
        static void GreenMessage(string mesaj)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine(mesaj);
            Console.ForegroundColor = ConsoleColor.White;
        }
    }
}
