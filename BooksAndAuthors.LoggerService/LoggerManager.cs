﻿namespace BooksAndAuthors.LoggerService
{
    using BooksAndAuthors.Contracts;
    using NLog;

    public class LoggerManager : ILoggerManager
    {
        /// <summary>
        /// The logger
        /// </summary>
        private static ILogger logger = LogManager.GetCurrentClassLogger();

        /// <summary>
        /// Initializes a new instance of the <see cref="LoggerManager"/> class.
        /// </summary>
        public LoggerManager()
        {
        }

        /// <summary>
        /// Logs the debug.
        /// </summary>
        /// <param name="message">The message.</param>
        public void LogDebug(string message) => logger.Debug(message);

        /// <summary>
        /// Logs the error.
        /// </summary>
        /// <param name="message">The message.</param>
        public void LogError(string message) => logger.Error(message);

        /// <summary>
        /// Logs the information.
        /// </summary>
        /// <param name="message">The message.</param>
        public void LogInfo(string message) => logger.Info(message);

        /// <summary>
        /// Logs the warn.
        /// </summary>
        /// <param name="message">The message.</param>
        public void LogWarn(string message) => logger.Warn(message);

    }
}
