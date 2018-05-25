

using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;

namespace ClassNameSelector
{
    class ClassName
    {
        static void Main()
        {
            string URL = "http://testing.todvachev.com/selectors/class-name/";
            string className = "testClass";
            IWebDriver driver = new ChromeDriver();
            driver.Navigate().GoToUrl(URL);
            IWebElement element = driver.FindElement(By.ClassName(className));
            Console.WriteLine(element.Text);
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
