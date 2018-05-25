using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Threading;

namespace AlertBox
{
    //not: id,name > csspath > xpath
    class alertBox
    {
        static IWebDriver driver = new ChromeDriver();
        static IWebElement image;
        static IAlert alert;
        
        static void Main()
        {
            string URL = "http://testing.todvachev.com/special-elements/alert-box/";
            driver.Navigate().GoToUrl(URL);
            alert = driver.SwitchTo().Alert();
            //alert mesajında ne yazdığını görelim
            Console.WriteLine(alert.Text);
            //alert i bekletelim
            Thread.Sleep(2000);
            alert.Accept();
            image = driver.FindElement(By.CssSelector("#post-119 > div > figure > img"));
            try
            {
                if (image.Displayed)
                {
                    Console.WriteLine("alert penceresi kabul edildi,resim göründü");
                }
            }
            catch (NoSuchElementException)
            {

                Console.WriteLine("sorun var");
            }
            driver.Quit();
        }
    }
}
