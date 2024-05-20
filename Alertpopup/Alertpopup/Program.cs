using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Alertpopup
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IWebDriver driver = new ChromeDriver();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(30);
            driver.Navigate().GoToUrl("https://demoqa.com/");


            driver.Manage().Window.Maximize();
            Thread.Sleep(1000);

            IJavaScriptExecutor obj = ((IJavaScriptExecutor)driver);
            obj.ExecuteScript("window. scrollBy(0,500)", "");


            driver.FindElement(By.XPath("/html/body/div/div/div/div/div/div/div")).Click();
            Thread.Sleep(2000);

            obj.ExecuteScript("window. scrollBy(0,700)", "");
            driver.FindElement(By.XPath("/html/body/div[2]/div/div/div[2]/div[1]/div/div/div[3]/span/div/div[1]")).Click() ;
            Thread.Sleep(2000);
            driver.FindElement(By.XPath("//span[text()='Alerts']")).Click();

          //  driver.FindElement(By.XPath("/html/body/div[2]/div/div/div[2]/div[2]/div[2]/div[1]/div[2]/button")).Click();
            //driver.SwitchTo().Alert().Accept();
            //driver.SwitchTo().Alert().Dismiss();

            driver.FindElement(By.XPath("//button[@id='timerAlertButton'and @type='button']")).Click();
            Thread.Sleep(5000);
            IAlert simpleAlert=driver.SwitchTo().Alert();

            String alertMessage =simpleAlert.Text;

            driver.Url = alertMessage;
            ((ITakesScreenshot)driver).GetScreenshot().SaveAsFile("D:\\screenshot\\alert_M.png");


            Console.WriteLine(alertMessage);
            simpleAlert.Accept();
            //driver.SwitchTo().Alert().Accept();

            driver.Url = "https://demoqa.com/alerts";
            ((ITakesScreenshot)driver).GetScreenshot().SaveAsFile("D:\\screenshot\\alert_Message.png");

            driver.Close();
           
            //dynamic screenshot

        }
    }
}
