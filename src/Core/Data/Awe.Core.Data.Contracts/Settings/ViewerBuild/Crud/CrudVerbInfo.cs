namespace GrantTechnologies.Core.DBLib.DBConnector.Awe.Contracts.Settings.ViewerBuild
{
    /// <summary>
    /// DTO for transferring information about the crudparams of the viewer.
    /// </summary>
    public class CrudVerbInfo
    {
        /// <summary>Name of service verb</summary>
        public string VerbName { get; set; }

        public ParamInfo[] InParams { get; set; }

        //public ParamInfo[] OutParam { get; set; }
        public ParamInfo OutParam { get; set; }
    }
}