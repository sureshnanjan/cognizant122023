using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HerokuAppOperations
{
    public interface IInputs
    {
        /// <summary>
        /// For getting the heading of the page
        /// </summary>
        /// <returns></returns>
        string getHeading();
        /// <summary>
        /// For getting the paragraph description of input field
        /// </summary>
        /// <returns></returns>
        string getDescriptionOfInputField();
        /// <summary>
        /// For entering the input text into the element
        /// </summary>
        /// <returns></returns>
        void setInput(string inputText);
        /// <summary>
        /// for closing the page
        /// </summary>
        void exitApplication();
    }
}
