using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Threading;

namespace TextBox
{
    class textBox
    {
        static IWebDriver driver=new ChromeDriver();
        static IWebElement textbox;
        static void Main()
        {
            string URL = "http://testing.todvachev.com/special-elements/text-input-field/";
            driver.Navigate().GoToUrl(URL);
            textbox = driver.FindElement(By.Name("username"));
            textbox.SendKeys("test metini");
            Thread.Sleep(2000);
            
            Console.WriteLine(textbox.GetAttribute("maxlength"));
            Console.WriteLine(textbox.GetAttribute("value"));
            Thread.Sleep(2000);
            driver.Quit();

        }
    }
}
