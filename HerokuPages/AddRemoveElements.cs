using HerokuAppOperations;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;

namespace HerokuPages
{
    public class AddRemoveElements : HerokuApplication, IAddRemoveElements
    {
        private By addelementOperationLocator;
        private By addedElementsLocator;

        public AddRemoveElements(IWebDriver driver): base (driver)
        {
            addelementOperationLocator = By.CssSelector("button");
            addedElementsLocator = By.CssSelector(".added-manually");
        }

        public void addElement()
        {
            this._browser.FindElement(addelementOperationLocator).Click();
            //WebDriverWait wait = new WebDriverWait(driver, System.TimeSpan.FromSeconds(30));
            //wait.Until(driver => driver.FindElements(By.CssSelector(".added-manually")).Count > 0);

        }

        public int getAddedElemenstCount()
        {
            return this._browser.FindElements(addedElementsLocator).Count;
        }

        public void removeElement()
        {
            this._browser.FindElement(addedElementsLocator).Click();
        }
    }
}
