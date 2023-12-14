using OpenQA.Selenium;

namespace HerokuAppOperations.AddRemoveElements
{
    /// <summary>
    /// Add Remove Element
    /// </summary>
    public class AddRemoveElementData : IAddRemoveElement
    {
        private IWebDriver _browser;

        /// <summary>
        /// Contructor
        /// </summary>
        /// <param name="_browser"></param>
        public AddRemoveElementData(IWebDriver _browser)
        {
            this._browser = _browser;
        }

        /// <summary>
        /// Open particular site
        /// </summary>
        /// <param name="url"></param>
        public void OpenSite(string url)
        {
            _browser.Navigate().GoToUrl(url);
        }

        /// <summary>
        /// Get Heading from site
        /// </summary>
        /// <param name="tagName"></param>
        /// <returns></returns>
        public string GetSiteHeading(By tagName)
        {
            return _browser.FindElement(tagName).Text;
        }

        /// <summary>
        /// Get Element count
        /// </summary>
        /// <returns></returns>
        public int GetExamplesCount()
        {
            var getCount = _browser.FindElements(By.XPath("//*[@id='content']/ul/li/a")).Count;
            return getCount;
        }

        /// <summary>
        /// Get click event
        /// </summary>
        /// <param name="name"></param>
        /// <returns></returns>
        public void AddRemoveElementClickEvent(string name)
        {
            _browser.FindElement(By.LinkText(name)).Click();
        }

        /// <summary>
        /// Get click event
        /// </summary>
        /// <returns></returns>
        public int CountOfDeleteButton()
        {
            return _browser.FindElements(By.ClassName("added-manually")).Count;
        }

        /// <summary>
        /// AddElementClick
        /// </summary>
        public void AddElementClick()
        {
            _browser.FindElement(By.TagName("button")).Click();

        }
    }
}
