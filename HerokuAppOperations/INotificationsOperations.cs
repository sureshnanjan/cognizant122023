using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HerokuAppOperations
{
    /// <summary>
    /// This interface is intended for the notification message sub page on horokuApp website.
    /// This will cover all the necessary operations and properties available on Notification message sub page
    /// </summary>
    public interface INotificationsOperations
    {
        /// <summary>
        /// This will be used to get the heading of the sub page named notification Messages. 
        /// here when user click and comes to the sub page, s/he will see the heading as "Notification Message" only
        /// </summary>
        /// <returns>The return value is a string as the heading of the sub page is alphanumeric. 
        /// The expected value is as mentioned "Notification Message"</returns>
        string getHeading();
        /// <summary>
        /// This will be used to get the sub heading of the sub page notification Messages. 
        /// here when user click and comes to notification Messages page, s/he will see the sub heading as 
        /// "The message displayed above the heading is a notification message. It is often used to convey information about an action previously taken by the user."
        /// </summary>
        /// <returns>The return value is a string as the sub heading of the sub page is alphanumeric. 
        /// </returns>
        string getFirstSubHeading();
        /// <summary>
        /// This will be used to get the sub heading of the sub page notification Messages. 
        /// here when user click and comes to notification Messages page, s/he will see the sub heading as 
        /// "Some rudimentary examples include 'Action successful', 'Action unsuccessful, please try again', etc. "
        /// </summary>
        /// <returns>The return value is a string as the sub heading of the sub page is alphanumeric. 
        /// </returns>
        string getSecondSubHeading();
        /// <summary>
        /// A third element on the page load is a hyperlink with a message
        /// as "Click here to load a new message."
        /// This should be seen when the page is loaded successfully
        /// </summary>
        /// <returns>return type is boolean (True/False) based on the visibility of the object</returns>
        bool hyperLinkMessageSeen();
        /// <summary>
        /// The hyperlink "Click here to load a new message." has a clickable text.
        /// When hovered over the Click Here hyperlink, the status bar should show the url link as
        /// "https://the-internet.herokuapp.com/notification_message"
        /// </summary>
        /// <returns>The return value is teh URL as mentioned above. It is alphanumeric hence a string data-typer</returns>
        string hoverClickHereHyperlinkToSeeMessage();
        /// <summary>
        /// The page when loaded, has a notification message on Blue Bra strip.
        /// the messag ereads as 'Action successful' along with an Exclamation mark.
        /// </summary>
        /// <returns> the return type is string with above message</returns>
        string notificationMessageOnBlueBarStrip();
    }
}
