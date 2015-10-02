
namespace Network_Info_Win
{
    internal enum ErrorCode
    {
        Ok = 0,
        Error = -1,

        /// <summary>
        /// Authentication error.
        /// </summary>
        Auth = -2,

        /// <summary>
        /// Skip and passthrough the given ODB backend.
        /// </summary>
        PassThrough = -3,

        /// <summary>
        /// There are no more entries left to iterate.
        /// </summary>
        IterOver = -4,

        /// <summary>
        /// RPC Unavailable
        /// </summary>
        RPCUnavailable = -5,

        /// <summary>
        /// Non windows OS
        /// </summary>
        NonWindows = -6,
    }
}
