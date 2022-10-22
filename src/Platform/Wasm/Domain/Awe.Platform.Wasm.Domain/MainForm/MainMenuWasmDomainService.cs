using Abp.Dependency;
using Abp.Domain.Services;
using Awe.Core.Widget.Contracts;

namespace Awe.Platform.Wasm.Domain.MainForm;

public class MainMenuWasmDomainService : DomainService, IMainMenuDomainService, ISingletonDependency
{
    public void Build()
    {
        throw new NotImplementedException();
    }
}