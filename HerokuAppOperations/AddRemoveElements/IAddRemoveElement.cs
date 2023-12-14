using OpenQA.Selenium;

namespace HerokuAppOperations.AddRemoveElements
{
    /// <summary>
    /// Adding and removing elements
    /// </summary>
    public interface IAddRemoveElement
    {
        /// <summary>
        /// open site
        /// </summary>
        /// <param name="url"></param>
        void OpenSite(string url);

        /// <summary>
        /// get heading using tag name
        /// </summary>
        /// <param name="tagName"></param>
        /// <returns></returns>
        string GetSiteHeading(By tagName);


        /// <summary>
        /// Get Example Count
        /// </summary>
        /// <returns></returns>
        int GetExamplesCount();

        /// <summary>
        /// AddRemoveElementClickEvent
        /// </summary>
        /// <param name="name"></param>
        void AddRemoveElementClickEvent(string name);

        /// <summary>
        /// CountOfDeleteButton
        /// </summary>
        /// <returns></returns>
        int CountOfDeleteButton();

        /// <summary>
        /// AddElementClick
        /// </summary>
        void AddElementClick();
    }
}
