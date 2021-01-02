using System;
using System.Collections.Generic;
using System.Text;

namespace OECSDK
{

    public enum OECResultCode
    {
        #region Success codes
        OK = 0,

        #endregion

        #region Module Errors
        INTERNAL_ERROR = 100,
        INIT_FAIL,
        #endregion

        #region Client Errors
        BAD_INPUT = 200,
        #endregion
    }
    public interface OECResult
    {

    }
}
