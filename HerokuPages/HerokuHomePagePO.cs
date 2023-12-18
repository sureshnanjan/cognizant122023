using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;

public class HerokuHomePage
{
    private Dictionary<string, string> data;
    private IWebDriver driver;
    private int timeout = 15;

    private IWebElement abTesting;

    private IWebElement addremoveElements;

    private IWebElement basicAuth;

    private IWebElement brokenImages;

    
    private IWebElement challengingDom;

    
    private IWebElement checkboxes;

    
    private IWebElement contextMenu;

    
    private IWebElement digestAuthentication;

    
    private IWebElement disappearingElements;

    
    private IWebElement dragAndDrop;

    
    private IWebElement dropdown;

    
    private IWebElement dynamicContent;

    
    private IWebElement dynamicControls;

    
    private IWebElement dynamicLoading;

    
    private IWebElement elementalSelenium;

    
    private IWebElement entryAd;

    
    private IWebElement exitIntent;

    
    private IWebElement fileDownload;

    
    private IWebElement fileUpload;

    
    private IWebElement floatingMenu;

    
    private IWebElement forgotPassword;

    
    private IWebElement forkMeOnGithub;

    
    private IWebElement formAuthentication;

    
    private IWebElement frames;

    
    private IWebElement geolocation;

    
    
    private IWebElement horizontalSlider;

    
    private IWebElement hovers;

    
    private IWebElement infiniteScroll;

    
    private IWebElement inputs;

    
    private IWebElement javascriptAlerts;

    
    private IWebElement javascriptOnloadEventError;

    
    private IWebElement jqueryUiMenus;

    
    private IWebElement keyPresses;

    
    private IWebElement largeDeepDom;

    
    private IWebElement multipleWindows;

    
    private IWebElement nestedFrames;

    
    private IWebElement notificationMessages;

    private readonly string pageLoadedText = "";

    private readonly string pageUrl = "/";

    
    private IWebElement redirectLink;

    
    private IWebElement secureFileDownload;

    
    private IWebElement shadowDom;

    
    private IWebElement shiftingContent;

    
    private IWebElement slowResources;

    
    private IWebElement sortableDataTables;

    
    private IWebElement statusCodes;

    
    private IWebElement typos;

    
    private IWebElement wysiwygEditor;

    public HerokuHomePage()
        : this(default(IWebDriver), new Dictionary<string, string>(), 15)
    {
    }

    public HerokuHomePage(IWebDriver driver)
        : this(driver, new Dictionary<string, string>(), 15)
    {
    }

    public HerokuHomePage(IWebDriver driver, Dictionary<string, string> data)
        : this(driver, data, 15)
    {
    }

    public HerokuHomePage(IWebDriver driver, Dictionary<string, string> data, int timeout)
    {
        this.driver = driver;
        this.data = data;
        this.timeout = timeout;
    }

    /// <summary>
    /// Click on Ab Testing Link.
    /// </summary>
    /// <returns>The HerokuHomePage class instance.</returns>
    public HerokuHomePage ClickAbTestingLink()
    {
        abTesting.Click();
        return this;
    }

    /// <summary>
    /// Click on Addremove Elements Link.
    /// </summary>
    /// <returns>The HerokuHomePage class instance.</returns>
    public HerokuHomePage ClickAddremoveElementsLink()
    {
        addremoveElements.Click();
        return this;
    }

    /// <summary>
    /// Click on Basic Auth Link.
    /// </summary>
    /// <returns>The HerokuHomePage class instance.</returns>
    public HerokuHomePage ClickBasicAuthLink()
    {
        basicAuth.Click();
        return this;
    }

    /// <summary>
    /// Click on Broken Images Link.
    /// </summary>
    /// <returns>The HerokuHomePage class instance.</returns>
    public HerokuHomePage ClickBrokenImagesLink()
    {
        brokenImages.Click();
        return this;
    }

    /// <summary>
    /// Click on Challenging Dom Link.
    /// </summary>
    /// <returns>The HerokuHomePage class instance.</returns>
    public HerokuHomePage ClickChallengingDomLink()
    {
        challengingDom.Click();
        return this;
    }

    /// <summary>
    /// Click on Checkboxes Link.
    /// </summary>
    /// <returns>The HerokuHomePage class instance.</returns>
    public HerokuHomePage ClickCheckboxesLink()
    {
        checkboxes.Click();
        return this;
    }

    /// <summary>
    /// Click on Context Menu Link.
    /// </summary>
    /// <returns>The HerokuHomePage class instance.</returns>
    public HerokuHomePage ClickContextMenuLink()
    {
        contextMenu.Click();
        return this;
    }

    /// <summary>
    /// Click on Digest Authentication Link.
    /// </summary>
    /// <returns>The HerokuHomePage class instance.</returns>
    public HerokuHomePage ClickDigestAuthenticationLink()
    {
        digestAuthentication.Click();
        return this;
    }

    /// <summary>
    /// Click on Disappearing Elements Link.
    /// </summary>
    /// <returns>The HerokuHomePage class instance.</returns>
    public HerokuHomePage ClickDisappearingElementsLink()
    {
        disappearingElements.Click();
        return this;
    }

    /// <summary>
    /// Click on Drag And Drop Link.
    /// </summary>
    /// <returns>The HerokuHomePage class instance.</returns>
    public HerokuHomePage ClickDragAndDropLink()
    {
        dragAndDrop.Click();
        return this;
    }

    /// <summary>
    /// Click on Dropdown Link.
    /// </summary>
    /// <returns>The HerokuHomePage class instance.</returns>
    public HerokuHomePage ClickDropdownLink()
    {
        dropdown.Click();
        return this;
    }

    /// <summary>
    /// Click on Dynamic Content Link.
    /// </summary>
    /// <returns>The HerokuHomePage class instance.</returns>
    public HerokuHomePage ClickDynamicContentLink()
    {
        dynamicContent.Click();
        return this;
    }

    /// <summary>
    /// Click on Dynamic Controls Link.
    /// </summary>
    /// <returns>The HerokuHomePage class instance.</returns>
    public HerokuHomePage ClickDynamicControlsLink()
    {
        dynamicControls.Click();
        return this;
    }

    /// <summary>
    /// Click on Dynamic Loading Link.
    /// </summary>
    /// <returns>The HerokuHomePage class instance.</returns>
    public HerokuHomePage ClickDynamicLoadingLink()
    {
        dynamicLoading.Click();
        return this;
    }

    /// <summary>
    /// Click on Elemental Selenium Link.
    /// </summary>
    /// <returns>The HerokuHomePage class instance.</returns>
    public HerokuHomePage ClickElementalSeleniumLink()
    {
        elementalSelenium.Click();
        return this;
    }

    /// <summary>
    /// Click on Entry Ad Link.
    /// </summary>
    /// <returns>The HerokuHomePage class instance.</returns>
    public HerokuHomePage ClickEntryAdLink()
    {
        entryAd.Click();
        return this;
    }

    /// <summary>
    /// Click on Exit Intent Link.
    /// </summary>
    /// <returns>The HerokuHomePage class instance.</returns>
    public HerokuHomePage ClickExitIntentLink()
    {
        exitIntent.Click();
        return this;
    }

    /// <summary>
    /// Click on File Download Link.
    /// </summary>
    /// <returns>The HerokuHomePage class instance.</returns>
    public HerokuHomePage ClickFileDownloadLink()
    {
        fileDownload.Click();
        return this;
    }

    /// <summary>
    /// Click on File Upload Link.
    /// </summary>
    /// <returns>The HerokuHomePage class instance.</returns>
    public HerokuHomePage ClickFileUploadLink()
    {
        fileUpload.Click();
        return this;
    }

    /// <summary>
    /// Click on Floating Menu Link.
    /// </summary>
    /// <returns>The HerokuHomePage class instance.</returns>
    public HerokuHomePage ClickFloatingMenuLink()
    {
        floatingMenu.Click();
        return this;
    }

    /// <summary>
    /// Click on Forgot Password Link.
    /// </summary>
    /// <returns>The HerokuHomePage class instance.</returns>
    public HerokuHomePage ClickForgotPasswordLink()
    {
        forgotPassword.Click();
        return this;
    }

    /// <summary>
    /// Click on Fork Me On Github Link.
    /// </summary>
    /// <returns>The HerokuHomePage class instance.</returns>
    public HerokuHomePage ClickForkMeOnGithubLink()
    {
        forkMeOnGithub.Click();
        return this;
    }

    /// <summary>
    /// Click on Form Authentication Link.
    /// </summary>
    /// <returns>The HerokuHomePage class instance.</returns>
    public HerokuHomePage ClickFormAuthenticationLink()
    {
        formAuthentication.Click();
        return this;
    }

    /// <summary>
    /// Click on Frames Link.
    /// </summary>
    /// <returns>The HerokuHomePage class instance.</returns>
    public HerokuHomePage ClickFramesLink()
    {
        frames.Click();
        return this;
    }

    /// <summary>
    /// Click on Geolocation Link.
    /// </summary>
    /// <returns>The HerokuHomePage class instance.</returns>
    public HerokuHomePage ClickGeolocationLink()
    {
        geolocation.Click();
        return this;
    }

    /// <summary>
    /// Click on Horizontal Slider Link.
    /// </summary>
    /// <returns>The HerokuHomePage class instance.</returns>
    public HerokuHomePage ClickHorizontalSliderLink()
    {
        horizontalSlider.Click();
        return this;
    }

    /// <summary>
    /// Click on Hovers Link.
    /// </summary>
    /// <returns>The HerokuHomePage class instance.</returns>
    public HerokuHomePage ClickHoversLink()
    {
        hovers.Click();
        return this;
    }

    /// <summary>
    /// Click on Infinite Scroll Link.
    /// </summary>
    /// <returns>The HerokuHomePage class instance.</returns>
    public HerokuHomePage ClickInfiniteScrollLink()
    {
        infiniteScroll.Click();
        return this;
    }

    /// <summary>
    /// Click on Inputs Link.
    /// </summary>
    /// <returns>The HerokuHomePage class instance.</returns>
    public HerokuHomePage ClickInputsLink()
    {
        inputs.Click();
        return this;
    }

    /// <summary>
    /// Click on Javascript Alerts Link.
    /// </summary>
    /// <returns>The HerokuHomePage class instance.</returns>
    public HerokuHomePage ClickJavascriptAlertsLink()
    {
        javascriptAlerts.Click();
        return this;
    }

    /// <summary>
    /// Click on Javascript Onload Event Error Link.
    /// </summary>
    /// <returns>The HerokuHomePage class instance.</returns>
    public HerokuHomePage ClickJavascriptOnloadEventErrorLink()
    {
        javascriptOnloadEventError.Click();
        return this;
    }

    /// <summary>
    /// Click on Jquery Ui Menus Link.
    /// </summary>
    /// <returns>The HerokuHomePage class instance.</returns>
    public HerokuHomePage ClickJqueryUiMenusLink()
    {
        jqueryUiMenus.Click();
        return this;
    }

    /// <summary>
    /// Click on Key Presses Link.
    /// </summary>
    /// <returns>The HerokuHomePage class instance.</returns>
    public HerokuHomePage ClickKeyPressesLink()
    {
        keyPresses.Click();
        return this;
    }

    /// <summary>
    /// Click on Large Deep Dom Link.
    /// </summary>
    /// <returns>The HerokuHomePage class instance.</returns>
    public HerokuHomePage ClickLargeDeepDomLink()
    {
        largeDeepDom.Click();
        return this;
    }

    /// <summary>
    /// Click on Multiple Windows Link.
    /// </summary>
    /// <returns>The HerokuHomePage class instance.</returns>
    public HerokuHomePage ClickMultipleWindowsLink()
    {
        multipleWindows.Click();
        return this;
    }

    /// <summary>
    /// Click on Nested Frames Link.
    /// </summary>
    /// <returns>The HerokuHomePage class instance.</returns>
    public HerokuHomePage ClickNestedFramesLink()
    {
        nestedFrames.Click();
        return this;
    }

    /// <summary>
    /// Click on Notification Messages Link.
    /// </summary>
    /// <returns>The HerokuHomePage class instance.</returns>
    public HerokuHomePage ClickNotificationMessagesLink()
    {
        notificationMessages.Click();
        return this;
    }

    /// <summary>
    /// Click on Redirect Link Link.
    /// </summary>
    /// <returns>The HerokuHomePage class instance.</returns>
    public HerokuHomePage ClickRedirectLinkLink()
    {
        redirectLink.Click();
        return this;
    }

    /// <summary>
    /// Click on Secure File Download Link.
    /// </summary>
    /// <returns>The HerokuHomePage class instance.</returns>
    public HerokuHomePage ClickSecureFileDownloadLink()
    {
        secureFileDownload.Click();
        return this;
    }

    /// <summary>
    /// Click on Shadow Dom Link.
    /// </summary>
    /// <returns>The HerokuHomePage class instance.</returns>
    public HerokuHomePage ClickShadowDomLink()
    {
        shadowDom.Click();
        return this;
    }

    /// <summary>
    /// Click on Shifting Content Link.
    /// </summary>
    /// <returns>The HerokuHomePage class instance.</returns>
    public HerokuHomePage ClickShiftingContentLink()
    {
        shiftingContent.Click();
        return this;
    }

    /// <summary>
    /// Click on Slow Resources Link.
    /// </summary>
    /// <returns>The HerokuHomePage class instance.</returns>
    public HerokuHomePage ClickSlowResourcesLink()
    {
        slowResources.Click();
        return this;
    }

    /// <summary>
    /// Click on Sortable Data Tables Link.
    /// </summary>
    /// <returns>The HerokuHomePage class instance.</returns>
    public HerokuHomePage ClickSortableDataTablesLink()
    {
        sortableDataTables.Click();
        return this;
    }

    /// <summary>
    /// Click on Status Codes Link.
    /// </summary>
    /// <returns>The HerokuHomePage class instance.</returns>
    public HerokuHomePage ClickStatusCodesLink()
    {
        statusCodes.Click();
        return this;
    }

    /// <summary>
    /// Click on Typos Link.
    /// </summary>
    /// <returns>The HerokuHomePage class instance.</returns>
    public HerokuHomePage ClickTyposLink()
    {
        typos.Click();
        return this;
    }

    /// <summary>
    /// Click on Wysiwyg Editor Link.
    /// </summary>
    /// <returns>The HerokuHomePage class instance.</returns>
    public HerokuHomePage ClickWysiwygEditorLink()
    {
        wysiwygEditor.Click();
        return this;
    }

    /// <summary>
    /// Verify that the page loaded completely.
    /// </summary>
    /// <returns>The HerokuHomePage class instance.</returns>
    public HerokuHomePage VerifyPageLoaded()
    {
        new WebDriverWait(driver, TimeSpan.FromSeconds(timeout)).Until<bool>((d) =>
        {
            return d.PageSource.Contains(pageLoadedText);
        });
        return this;
    }

    /// <summary>
    /// Verify that current page URL matches the expected URL.
    /// </summary>
    /// <returns>The HerokuHomePage class instance.</returns>
    public HerokuHomePage VerifyPageUrl()
    {
        new WebDriverWait(driver, TimeSpan.FromSeconds(timeout)).Until<bool>((d) =>
        {
            return d.Url.Contains(pageUrl);
        });
        return this;
    }
}
