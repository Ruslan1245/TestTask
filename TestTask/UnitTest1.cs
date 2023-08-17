using OpenQA.Selenium;

namespace TestTask
{
    public class Tests
    {


        private IWebDriver driver;

        [SetUp]
        public void Setup()
        {
            driver = new OpenQA.Selenium.Chrome.ChromeDriver();
            driver.Navigate().GoToUrl("https://diia.gov.ua");
            driver.Manage().Window.Maximize();
        }

        [Test]
        public void Test1()
        {
            driver.FindElement(By.XPath("/html/body/div[1]/header/div[4]/div[3]/form/div/div/div[1]/label/input")).SendKeys("народження дитини");
            driver.FindElement(By.XPath("/html/body/div[1]/header/div[4]/div[3]/form/div/div/div[1]/input")).Click();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(3);
            driver.FindElement(By.XPath("//*[@id=\"searchSideBarFilters\"]/div/div[2]/div[2]/div[1]"));
            driver.FindElement(By.XPath("/html/body/div[1]/main/section/div/div/div[4]/div/div/div[2]/div[2]/div[1]")).Click();
            driver.FindElement(By.XPath("//a[text()='Допомога при народженні дитини']")).Click();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(3);
            driver.FindElement(By.XPath("/html/body/div[1]/main/section[1]/div[1]/div/div[2]/div/a[2]/span")).Click();
            driver.FindElement(By.XPath("/html/body/div[1]/main/section[1]/div[2]/div/div/div[2]/form/div/input")).SendKeys("pishi_gdu@ukr.net");
            driver.FindElement(By.XPath("/html/body/div[1]/main/section[1]/div[2]/div/div/div[2]/form/button")).Click();
            driver.FindElement(By.XPath("//a[text()='На головну']")).Click();


        }
    }
}