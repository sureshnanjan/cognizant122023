using HerokuAppOperations;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HerokuPages
{
    public class SortedDataTablesPage : ISortedDataTables
    {
        private IWebDriver _browser;
        private string _url = "https://the-internet.herokuapp.com/tables";
        private By headingLocator = By.TagName("h3");


        public SortedDataTablesPage()
        {
            _browser = new ChromeDriver();
            _browser.Navigate().GoToUrl(_url);
        }

        public void editRow()
        {
            throw new NotImplementedException();
        }

        public void deleteRow()
        {
            throw new NotImplementedException();
        }

        public void sortTableByEmail() 
        {  
            throw new NotImplementedException(); 
        }
        public int getRowCount()
        {
            throw new NotImplementedException();
        }

    }
}
