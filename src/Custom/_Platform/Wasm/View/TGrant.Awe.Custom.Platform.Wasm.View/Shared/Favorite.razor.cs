using _Blazor.Starter.Global;
using _Blazor.Starter.Global.Nav.Model;
using Abp.Extensions;
using TGrant.Awe.Custom.Platform.Wasm.View.Data.Temp;

namespace TGrant.Awe.Custom.Platform.Wasm.View.Shared
{
    public partial class Favorite
    {
        private bool _open;
        private string? _search;
        
        private List<int> _favoriteMenus = FavoriteService.GetDefaultFavoriteMenuList();
        
        protected override void OnInitialized()
        {
            if (GlobalConfig.Favorite == "")
            {
                _favoriteMenus.Clear();
            }
            else if (GlobalConfig.Favorite is not null)
            {
                _favoriteMenus = GlobalConfig.Favorite.Split('|').Select(v => Convert.ToInt32(v)).ToList();
            }

            GlobalConfig.OnCurrentNavChanged += base.StateHasChanged;
        }

        private void OnOpen(bool open)
        {
            _open = open;
            if (open)
            {
                _search = null;
            }
        }

        private List<NavModel> GetNavs(string? search)
        {
            var sameLevelNavs = NavHelper.SameLevelNavs;

            var output = new List<NavModel>();
            output.AddRange(search.IsNullOrEmpty()
                ? sameLevelNavs.Where(n => _favoriteMenus.Contains(n.Id))
                : sameLevelNavs
                    .Where(n =>
                    {
                        var contains = n.Href is not null && GetI18nFullTitle(n.FullTitle)
                            .Contains(search, StringComparison.OrdinalIgnoreCase);
                        return contains;
                    }));

            return output;
        }

        private List<NavModel> GetFavoriteMenus() => GetNavs(null);

        private void AddOrRemoveFavoriteMenu(int id)
        {
            if (_favoriteMenus.Contains(id)) _favoriteMenus.Remove(id);
            else _favoriteMenus.Add(id);
            GlobalConfig.Favorite = string.Join("|", _favoriteMenus);
        }

        private string GetI18nFullTitle(string fullTitle)
        {
            var arr = fullTitle.Split(' ').ToList();
            if (arr.Count == 1) return T(fullTitle);
            else
            {
                var parent = arr[0];
                arr.RemoveAt(0);
                return $"{T(parent)} {T(string.Join(' ', arr))}";
            }
        }

        public void Dispose()
        {
            GlobalConfig.OnCurrentNavChanged -= base.StateHasChanged;
        }
    }
}
