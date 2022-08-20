namespace TGrant.Awe.Core.Action.Contracts
{
    public class MenuClickEventData : WidgetEventData
    {
        public int MenuId { get; }
        public int ViewerId { get; }

        public MenuClickEventData(int menuId, int viewerId)
        {
            MenuId = menuId;
            ViewerId = viewerId;
        }
    }
}
