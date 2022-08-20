using Awe.Contracts.Settings.Enums.ViewerLinks;

namespace Awe.Contracts.Settings.ViewerLinks
{
    public class ViewerLinkParamCardInfo
    {
        /// <summary>Id</summary>
        public int Id { get; set; }

        //---------------Destination---------------

        public StoreType StoreType { get; set; }
        public string DbColumnName { get; set; }

        //---------------Source--------------------
        
        public StoreType ViStoreType { get; set; }
        public string ViDbColumnName { get; set; }

        //---------------Value---------------------
        
        public DefaultValType DefaultValType { get; set; }
        public object DefaultValue { get; set; }

        //-----------------------------------------
        
        public bool IsViCall { get; set; }
        public string Descr { get; set; }
    }
}