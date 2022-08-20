using Awe.Contracts.Settings.Enums;

namespace Awe.Contracts.Settings.ViewerData
{
    /// <summary>
    /// Viewer data
    /// </summary>
    public class ViewerDataDto
    {
        public string TableName { get; set; }
        public string TableSchema { get; set; }
        public string DataTableString { get; set; }
        public CrudMode CrudMode { get; set; }
        public SerializableDataFormat SerializableDataFormat { get; set; }
    }

    public enum SerializableDataFormat
    {
        Json = 1,
        Xml = 2
    }
}
