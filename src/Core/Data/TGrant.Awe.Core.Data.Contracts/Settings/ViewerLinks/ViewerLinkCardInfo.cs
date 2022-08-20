using Awe.Contracts.Settings.Enums.ViewerLinks;

namespace Awe.Contracts.Settings.ViewerLinks
{
    public class ViewerLinkCardInfo
    {
        /// <summary>Id</summary>
        public int Id { get; set; }

        public string ViewerLinksName { get; set; }


        public int ViewerId { get; set; }

        public string ViewerAlias { get; set; }

        public string ViewerTypeName { get; set; }


        public int? ViViewerId { get; set; }

        public string ViViewerAlias { get; set; }

        public string ViViewerTypeName { get; set; }


        public string ViTypeName { get; set; }

        public bool IsAddMember { get; set; }

        public int ViLevel { get; set; }


        public int? MediateViewerId { get; set; }

        public string MediateViewerAlias { get; set; }

        public string MediateViewerTypeName { get; set; }


        public LevelFlag SaveType { get; set; }

        public LevelFlag RefreshType { get; set; }


        public string FilterColumnName { get; set; }

        public bool InputCountShow { get; set; }

        public string DescrColumnName { get; set; }

        public string EdIzmColumnName { get; set; }

        public string LimitColumnName { get; set; }

        public string DefaultColumnName { get; set; }

        public string FilterFlag { get; set; }

        public string Condition { get; set; }

        public string Descr { get; set; }

    }
}