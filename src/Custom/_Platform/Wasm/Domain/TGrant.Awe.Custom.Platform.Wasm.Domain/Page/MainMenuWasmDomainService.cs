using Abp.Dependency;
using Abp.Domain.Services;
using TGrant.Awe.Core.Widget.Contracts;

namespace TGrant.Awe.Custom.Platform.Wasm.Domain.Page;

public class MainMenuWasmDomainService : DomainService, IMainMenuDomainService, ISingletonDependency
{
    public void Build()
    {
        throw new NotImplementedException();
    }
}