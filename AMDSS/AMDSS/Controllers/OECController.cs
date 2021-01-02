using System;
using System.Net;
using Microsoft.AspNetCore.Mvc;

using OECSDK;

namespace AMDSS.Controllers
{
    public class OECController : Controller
    {
        #region Server instance vars
        static IOEC iEoc;
        #endregion

        HttpStatusCode LoadOECModule(string moduleName)
        {
            if (iEoc == null)
            {
                //Unload EOC module
            }

            //Load EOC Module

            return HttpStatusCode.OK;
        }

        HttpStatusCode UploadOECModule(string moduleName, [FromBody] byte[] dllData)
        {


            return HttpStatusCode.OK;
        }

        IOECTransferObject DownloadOECModule(Guid moduleGuid)
        {


            return null;
        }

    }
}
