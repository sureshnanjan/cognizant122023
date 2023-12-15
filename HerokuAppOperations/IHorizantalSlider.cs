using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HerokuAppOperations
{
    /// <summary>
    /// 
    /// </summary>
    public interface IHorizantalSlider
    {
        /// <summary>
        /// Get the heading text from the Page
        /// </summary>
        /// <returns></returns>
        string getHeading();

        string getDescription();

        int getResults();

        /// <summary>
        /// 
        /// </summary>
        /// <param name="direction"> Left or Right</param>
        /// <param name="times"> How many times to press the arrwo key</param>
        void KeyboardMove(string direction, int times);

        void MouseClick(int offsetPosition);

        void MouseDrag(int from_left);
    }
}
