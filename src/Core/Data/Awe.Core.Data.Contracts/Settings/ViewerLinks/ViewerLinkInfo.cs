using Awe.Contracts.Settings.Enums.ViewerLinks;
using Awe.Contracts.Settings.ViewerBuild;

namespace Awe.Contracts.Settings.ViewerLinks
{
    public class ViewerLinkInfo
    {
        /// <summary>Id</summary>
        public int Id { get; set; }

        public string ViewerLinksName { get; set; }
        
        public virtual viType ViType { get; set; }
        
        public ViewerInfo Viewer { get; set; }
        
        public ViewerInfo ViViewer { get; set; }
        
        public ViewerInfo MediateViewer { get; set; }
        
        public int ViLevel { get; set; }
        
        public bool IsAddMember { get; set; }

        
        public string FilterColumnName { get; set; }
        
        public bool InputCountShow { get; set; }
        
        public string DescrColumnName { get; set; }
        
        public string EdIzmColumnName { get; set; }
        
        public string LimitColumnName { get; set; }
        
        public string DefaultColumnName { get; set; }

        public LevelFlag SaveType { get; set; }
        
        public LevelFlag RefreshType { get; set; }
        
        public string FilterFlag { get; set; }
        
        public string Condition { get; set; }
        
        public string Descr { get; set; }

        public ViewerLinkParamInfo[] ViewerLinkParams { get; set; }
    }
}