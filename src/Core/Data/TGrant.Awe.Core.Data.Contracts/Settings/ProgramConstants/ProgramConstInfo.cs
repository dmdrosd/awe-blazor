using System;

namespace Awe.Contracts.Settings.ProgramConstants
{
    public class ProgramConstInfo
    {
        /// <summary>
        /// Installation path
        /// </summary>
        public string AnalitikaInstallPath { get; set; }

        /// <summary>
        /// Storage path
        /// </summary>
        public string StoragePath { get; set; }

        /// <summary>
        /// Template path
        /// </summary>
        public string TemplatePath { get; set; }

        /// <summary>
        /// Plugins path
        /// </summary>
        public string PluginsPath { get; set; }

        /// <summary>
        /// Api path
        /// </summary>
        public string ApiPath { get; set; }

        
        /// <summary>
        /// Enable / disable password encryption
        /// </summary>
        public bool CRYPTON { get; set; } = false;

        /// <summary>
        /// Menu bar visibility with hot buttons
        /// </summary>
        public bool TSActionMenuVisible { get; set; } = false;

        /// <summary>
        /// Ignoring special characters in printed OO reports
        /// </summary>
        public bool IgnoreBadSpecSymbol { get; set; } = false;

        /// <summary>
        /// Auto Login Enable
        /// </summary>
        public bool AutoLoginOn { get; set; } = false;

        /// <summary>
        /// Closing Period Date
        /// </summary>
        public DateTime? ClosingPeriodDate { get; set; }

        #region Custom section for Exam. Move to other Custom service

        /// <summary>
        /// Enabling catching messages from Angular client
        /// </summary>
        public bool MQMessagesOn { get; set; } = false;

        /// <summary>
        /// Automatic printing of control sheets
        /// </summary>
        public bool PrintKL { get; set; } = false;

        #endregion
    }
}
