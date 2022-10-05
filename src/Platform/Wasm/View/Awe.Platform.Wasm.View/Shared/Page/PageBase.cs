using Awe.Core.Widget.Contracts.Domain;
using Awe.Core.Widget.Contracts.View.Page;

namespace Awe.Platform.Wasm.View.Shared.Page;

public abstract class PageBase<T> : ProComponentBase, IPageView
    where T : IPageDomainService
{
    public string Caption { get; set; }

    public void Show()
    {
        throw new NotImplementedException();
    }
}