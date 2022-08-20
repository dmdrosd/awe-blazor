using Awe.Contracts.Settings.Enums.Viewer;

namespace Awe.Contracts.Settings.ViewerBuild
{
    /// <summary>
    /// DTO for building the viewer (properties, columns)
    /// </summary>
    public class ViewerPropListInfo
    {
        /// <summary>Id</summary>
        public int Id { get; set; }

        /// <summary>
        /// Short class name
        /// </summary>
        /// <remarks>
        /// Specified with a tilde ("~KatMCGridCtrlr")
        /// </remarks>
        public string ExtClassName { get; set; }

        /// <summary>
        /// Full class name
        /// </summary>
        public string ExtClassFName { get; set; }

        /// <summary>
        /// Viewer's property type <c>ViewerExtType</c>
        /// </summary>
        public ViewerExtType ViewerExtType { get; set; }

        /// <summary>
        /// Extended name of the property. It is rarely used in custom cases
        /// </summary>
        public string PropFName { get; set; }

        /// <summary>
        /// Property value
        /// </summary>
        public object ViewerExtVal { get; set; }

    }
}
