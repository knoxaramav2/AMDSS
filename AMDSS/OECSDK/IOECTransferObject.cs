using System;
using System.Collections.Generic;
using System.Text;

namespace OECSDK
{
    public interface IOECTransferObject
    {
        IOEC metadata { get; set; }
        byte[] payload { get; set; }
    }
}
