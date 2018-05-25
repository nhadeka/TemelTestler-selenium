using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Threading;



namespace CheckBox
{
    class checkBox
    {
      static  IWebDriver driver = new ChromeDriver();
      static  IWebElement element;
        static void Main()
        {
            string URL = "http://testing.todvachev.com/special-elements/check-button-test-3/";
            string option = "2";
            driver.Navigate().GoToUrl(URL);
            // //*[@id="post-33"]/div/p[6]/input[2]=>//*[@id=\"post-33\"]/div/p[6]/input["+ option +"] değiştirdik
            element = driver.FindElement(By.XPath("//*[@id=\"post-33\"]/div/p[6]/input["+ option +"]"));

          
            bool isChecked = bool.TryParse(element.GetAttribute("checked"), out isChecked);
            if (isChecked)
            {
                Console.WriteLine("tiklenmiş");
            }
            else
            {
                Console.WriteLine("kutu tiklenmemiş");
            }
            driver.Quit();
        }
    }
}
