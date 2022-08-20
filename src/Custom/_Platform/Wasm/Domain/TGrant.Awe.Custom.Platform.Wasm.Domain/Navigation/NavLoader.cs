using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using _Blazor.Starter.Global.Nav.Model;

namespace TGrant.Awe.Custom.Platform.Wasm.Domain.Navigation
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
