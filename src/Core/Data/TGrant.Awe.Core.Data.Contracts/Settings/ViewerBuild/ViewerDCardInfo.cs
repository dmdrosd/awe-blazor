namespace Awe.Contracts.Settings.ViewerBuild
{
    /// <summary>
    /// DTO for building the viewer double card
    /// </summary>
    public class ViewerDCardInfo
    {
        /// <summary>Id</summary>
        public int Id { get; set; }

        /// <summary>
        /// Viewer name
        /// </summary>
        /// <remarks>
        /// In English.
        /// </remarks>
        public string Alias { get; set; }

        /// <summary>
        /// Viewer type Id
        /// </summary>
        public int ViewerTypeId { get; set; }

        /// <summary>
        /// Viewer type Name
        /// </summary>
        public string ViewerTypeName { get; set; }

        /// <summary>
        /// Viewer text title
        /// </summary>
        /// <remarks>
        /// In Russian.
        /// It is displayed on the form.
        /// </remarks>
        public string Caption { get; set; }

        /// <summary>
        /// Viewer level
        /// </summary>
        /// <remarks>
        /// To indicate the level of the viewer, in the case of complex forms
        /// </remarks>
        public int ViewerLevel { get; set; }

        /// <summary>Main Viewer Id</summary>
        public int? MainViewerId { get; set; }

        /// <summary>
        /// Main Viewer name
        /// </summary>
        /// <remarks>
        /// In English.
        /// </remarks>
        public string MainViewerAlias { get; set; }

        /// <summary>
        /// The ability of the viewer to change
        /// </summary>
        /// <remarks>
        /// Not used
        /// </remarks>
        public bool ReadOnly { get; set; }

        /// <summary>
        /// IsFirmaFilter. For tenant filtering
        /// </summary>
        public bool IsFirmaFilter { get; set; }

        /// <summary>
        /// Name of the column by which the period-end closing is checked
        /// </summary>
        public string ClosingPeriodDateClmnName { get; set; }

        /// <summary>Source</summary>
        public string Source { get; set; }

        /// <summary>Table name</summary>
        public string TbName { get; set; }

        /// <summary>Crud source</summary>
        public string SelectName { get; set; }

        /// <summary>Insert stored procedure name</summary>
        public string InsertName { get; set; }

        /// <summary>Update stored procedure name</summary>
        public string UpdateName { get; set; }

        /// <summary>Delete stored procedure name</summary>
        public string DeleteName { get; set; }

        /// <summary>Edit name</summary>
        public string EditName { get; set; }
    }
}