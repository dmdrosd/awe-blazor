using _Blazor.Starter.Global.Nav.Model;

namespace Awe.Platform.Wasm.Domain.Navigation
{
    //TODO move to service
    internal static class NavLoader
    {
        public static List<NavModel> LoadItems()
        {
            return NavList;
        }

        public static List<NavModel> NavList { get; set; }
    }
}
