using System;

namespace OECSDK
{
    public interface IOEC
    {
        #region Readonly fields
        public string ComponentName { get; }
        public string VersionString { get; }
        #endregion

        OECResultCode InitComponent();
        OECResult InvokeAction(string command, string[] args);
        OECResultCode RegisterListener();
    }
}
