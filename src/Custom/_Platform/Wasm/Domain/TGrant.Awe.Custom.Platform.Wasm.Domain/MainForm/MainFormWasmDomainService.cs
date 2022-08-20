using Abp.Dependency;
using Abp.Domain.Services;
using TGrant.Awe.Core.Widget.Contracts;
using TGrant.Awe.Core.Widget.Contracts.View;

namespace TGrant.Awe.Custom.Platform.Wasm.Domain.MainForm;

public class MainFormWasmDomainService : DomainService, IWMainFormDomainService, ISingletonDependency
{
    public IMainFormView BuildMainForm(string productInfo)
    {
        throw new NotImplementedException();
    }
}