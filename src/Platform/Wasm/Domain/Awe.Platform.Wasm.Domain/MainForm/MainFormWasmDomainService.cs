using Abp.Dependency;
using Abp.Domain.Services;
using Awe.Core.Widget.Contracts.Domain;
using Awe.Core.Widget.Contracts.View.MainForm;

namespace Awe.Platform.Wasm.Domain.MainForm;

public class MainFormWasmDomainService : DomainService, IWMainFormDomainService, ISingletonDependency
{
    public IMainFormView BuildMainForm(string productInfo)
    {
        throw new NotImplementedException();
    }
}