using Awe.Contracts.Settings.ViewerBuild;

namespace GrantTechnologies.Core.DBLib.DBConnector.Awe.Contracts.Settings.ViewerBuild
{
    public class ParamInfo
    {
        /// <summary>Name of DTO class</summary>
        /// <remarks>If ValueType is empty</remarks>></summary>
        public string DtoName { get; set; }

        /// <summary>Param name of DTO class</summary>
        public string ParamName { get; set; }

        /// <summary>Parameter type</summary>
        public ParamTypeName ParamTypeName { get; set; }
    }
}