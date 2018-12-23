using System;

namespace KBS.TestCases
{
    public struct TestCaseConfiguration
    {
        #region general configuration

        /// <summary>
        /// Amount of messages to send
        /// </summary>
        public int MessagesCount { get; set; }

        #endregion general configuration

        #region message configuration

        /// <summary>
        /// Message size in bytes (a message will be filled with a byte array of the given size)
        /// </summary>
        public int FillerSize { get; set; }

        #endregion message configuration
    }
}
