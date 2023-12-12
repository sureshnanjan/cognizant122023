using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HerokuAppOperations
{
    public interface IExitIntent
    {
        string ExitIntendPageHeading();

        string ExitIntendsubHeading();

        void VerifyPopupwindowprompting();

        string gettingwindowtext();

        void closewindow();

    }
}
