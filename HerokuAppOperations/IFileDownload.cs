using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HerokuAppOperations
{
    /// <summary>
    /// This interface will be used to download file
    /// </summary>
    public interface IFileDownload
    {
        /// <summary>
        /// File Download
        /// </summary>
        /// <param name="strFileName"></param>
        /// <returns></returns>
        bool DownloadFile(string strFileName);
    }
}
