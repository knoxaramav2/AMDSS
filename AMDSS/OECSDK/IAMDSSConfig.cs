using System;
using System.Collections.Generic;
using System.Text;

namespace OECSDK
{
    public interface IAMDSSConfig
    {
        void WriteDefaultRegistry();
        string InstallPath { get; }
        string InstallUser { get; }

    }
}
