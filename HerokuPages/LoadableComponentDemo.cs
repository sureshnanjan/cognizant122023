using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;

namespace HerokuPages
{
    public class HypotheticalLoadableComponent : ILoadableComponent
    {
        ILoadableComponent parent;
        public HypotheticalLoadableComponent(ILoadableComponent parent)
        { this.parent = parent; }

        public ILoadableComponent Load()
        {
            throw new System.NotImplementedException();
        }

        
    }
}