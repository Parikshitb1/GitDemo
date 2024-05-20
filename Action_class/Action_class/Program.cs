using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Interactions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Action_class
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IWebDriver driver = new ChromeDriver();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(30);
            driver.Navigate().GoToUrl("https://www.amazon.in/");

            driver.Manage().Window.Maximize();
            Thread.Sleep(1000);
             

            Actions act = new Actions(driver);
            act.MoveToElement(driver.FindElement(By.XPath("/html/body/div[1]/header/div/div[1]/div[3]/div/a[2]/span"))).Build().Perform();
            Thread.Sleep(1000);

            // IWebElement move = driver.FindElement(By.Id("twotabsearchtextbox"));
            //driver.FindElement(By.Id("twotabsearchtextbox")).SendKeys("mobile  ");
            //act.MoveToElement(driver.FindElement(By.Id("twotabsearchtextbox"))).KeyDown(Keys.F6).SendKeys("mobile").Build().Perform();
            //act.MoveToElement(driver.FindElement(By.Id("twotabsearchtextbox"))).SendKeys(,"iphone latest").Build().Perform();


            IWebElement Textfield = driver.FindElement(By.Id("twotabsearchtextbox"));
            act.KeyDown(Keys.Shift).SendKeys(Textfield, "iphone latest");

            //act.SendKeys(Textfield, "iphone latest").KeyDown(Keys.Shift);
                //act.MoveToElement(driver.FindElement(By.Id("twotabsearchtextbox"))).SendKeys("iphone latest").Build().Perform();

            // act.MoveToElement(driver.FindElement(By.Id("twotabsearchtextbox"))).KeyUp(Keys.ArrowDown).Build().Perform();

            //act.ClickAndHold();
            Thread.Sleep(3000);
            driver.FindElement(By.Id("twotabsearchtextbox")).Clear();

            act.ClickAndHold(driver.FindElement(By.XPath("/html/body"))).Build().Perform();

            Thread.Sleep(3000);
            IWebElement contextaction = driver.FindElement(By.Id("twotabsearchtextbox"));
            act.ContextClick(contextaction);

            Thread.Sleep(2000);
            IWebElement Doubleclick=driver.FindElement(By.XPath("/html/body/div[1]/header/div/div[1]/div[3]/div/a[4]/div[2]/span[2]"));
            act.DoubleClick(Doubleclick);

            IWebElement source = driver.FindElement(By.XPath("/html/body/div[1]/div[1]/div[2]/div[1]/div[1]/div/div/h2"));
            IWebElement dest = driver.FindElement(By.XPath("//*[@id=\"twotabsearchtextbox\"]"));

            act.DragAndDrop(source, dest).Build().Perform();
            Thread.Sleep(3000);
            driver.Quit();

            
        }
    }
}
