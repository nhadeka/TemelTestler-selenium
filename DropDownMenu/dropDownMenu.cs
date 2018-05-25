using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Threading;

namespace DropDownMenu
{
    /// <summary>
    
    /// </summary>
    class dropDownMenu
    {
        static IWebDriver driver = new ChromeDriver();
        static IWebElement dropdownmenu;
        static IWebElement elementFromDropDownMenu;
        static void Main()
        {

            string URL = "http://testing.todvachev.com/special-elements/drop-down-menu-test/";
            string dropDownMenuElements = "#post-6 > div > p:nth-child(6) > select > option:nth-child(3)";
            driver.Navigate().GoToUrl(URL);
            dropdownmenu = driver.FindElement(By.Name("DropDownTest"));
            Console.WriteLine("ilk değer, " + dropdownmenu.GetAttribute("value"));

            elementFromDropDownMenu = driver.FindElement(By.CssSelector(dropDownMenuElements));
           
            Console.WriteLine("3. seçenek, " + elementFromDropDownMenu.GetAttribute("value"));

            elementFromDropDownMenu.Click();
            Console.WriteLine("seçilen değer," + dropdownmenu.GetAttribute("value"));
            Thread.Sleep(4000);

            for (int i = 1; i <4; i++)
            {
                dropDownMenuElements = "#post-6 > div > p:nth-child(6) > select > option:nth-child(" + i + ")";
                elementFromDropDownMenu = driver.FindElement(By.CssSelector(dropDownMenuElements));
                Console.WriteLine("the " + i + ". seçenek, " + elementFromDropDownMenu.GetAttribute("value"));

            }
            Thread.Sleep(2000);
            driver.Quit();
        }
    }
}
