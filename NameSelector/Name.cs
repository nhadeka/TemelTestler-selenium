using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

using System;
using System.Threading;

namespace NameSelector
{
    class Name
    {
        static void Main()
        {
            string URL = "http://testing.todorvachev.com/selectors/name/";
            string name = "myName";
            IWebDriver driver = new ChromeDriver();
            driver.Navigate().GoToUrl(URL);
            
            Thread.Sleep(1000);

            IWebElement element = driver.FindElement(By.Name(name));
            if (element.Displayed)
            {
                GreenMessage("element görünür durumda");

            }
            else
            {
                RedMessage("sorun var,element görünmüyor");
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




 