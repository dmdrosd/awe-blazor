using Abp.Dependency;
using Abp.Domain.Services;

namespace Awe.Platform.Wasm.Domain.Page;

public class MainMenuWasmDomainService : DomainService, IMainMenuDomainService, ISingletonDependency
{
    public void Build()
    {
        throw new NotImplementedException();
    }
}