using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Threading;

namespace RadioButton
{
    class radioButton
    {
        static IWebDriver driver = new ChromeDriver();
        static IWebElement radiobuton;
        static void Main()
        {
            string URL = "http://testing.todvachev.com/special-elements/radio-button-test/";
            string[] option = { "1", "3", "5" }; //radiobuton child(no) noları csspath ile kontrol et.
            driver.Navigate().GoToUrl(URL);
            for (int i = 0; i <option.Length; i++)
            {
                radiobuton = driver.FindElement(By.CssSelector("#post-10 > div > form > p:nth-child(6) > input[type=\"radio\"]:nth-child("+option[i]+")"));
                if (radiobuton.GetAttribute("checked")=="true")
                {
                    Console.WriteLine(" " + (i + 1) + ". tiklenmiş");
                }
                else
                {
                    Console.WriteLine("tiklenmemiş buton");
                }

            }
            driver.Quit();

        }
    }
}
