using Awe.Contracts.Settings.Enums.ViewerLinks;

namespace Awe.Contracts.Settings.ViewerLinks
{
    public class ViewerLinkListInfo
    {
        /// <summary>Id</summary>
        public int Id { get; set; }

        public string ViewerLinksName { get; set; }

        public int ViewerId { get; set; }

        public string ViewerAlias { get; set; }

        public int? ViViewerId { get; set; }

        public string ViViewerAlias { get; set; }

        public string ViTypeName { get; set; }

        public bool IsAddMember { get; set; }

        public int ViLevel { get; set; }

        public int? MediateViewerId { get; set; }

        public string MediateViewerAlias { get; set; }

        public LevelFlag SaveType { get; set; }

        public LevelFlag RefreshType { get; set; }
    }
}