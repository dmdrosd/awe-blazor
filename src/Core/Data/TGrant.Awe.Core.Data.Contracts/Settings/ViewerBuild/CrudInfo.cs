namespace Awe.Contracts.Settings.ViewerBuild
{
    /// <summary>
    /// DTO for transferring information about the cruds of the viewer.
    /// </summary>
    public class CrudInfo
    {
        /// <summary>Id</summary>
        public int Id { get; set; }

        /// <summary></summary>
        public string Source { get; set; }

        /// <summary></summary>
        public string TbName { get; set; }

        /// <summary></summary>
        public string ViewerAlias { get; set; }

        /// <summary></summary>
        public string ServiceName { get; set; }

        /// <summary></summary>
        public string SelectName { get; set; }

        /// <summary></summary>
        public string InsertName { get; set; }

        /// <summary></summary>
        public string UpdateName { get; set; }

        /// <summary></summary>
        public string DeleteName { get; set; }

        /// <summary></summary>
        public string EditName { get; set; }

        /// <summary>
        /// The source is Api
        /// </summary>
        public bool IsApi { get; set; }
    }
}
