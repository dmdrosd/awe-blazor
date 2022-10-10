using Awe.Core.Widget.Contracts.Domain;
using Awe.Core.Widget.Contracts.View.MainForm;
using Volo.Abp.DependencyInjection;
using Volo.Abp.Domain.Services;

namespace Awe.Platform.Wasm.Domain.MainForm;

public class MainFormWasmDomainService : DomainService, IWMainFormDomainService, ISingletonDependency
{
    public IMainFormView BuildMainForm(string productInfo)
    {
        throw new NotImplementedException();
    }
}