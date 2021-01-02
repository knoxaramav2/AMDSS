using System;
using System.Collections.Generic;
using System.Text;

namespace OECSDK
{
    interface IAMDSSConfig
    {
        void WriteDefaultRegistry();
        string InstallPath { get; }
        string InstallUser { get; }

    }
}
