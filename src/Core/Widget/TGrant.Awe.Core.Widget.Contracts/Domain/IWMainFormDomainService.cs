using TGrant.Awe.Core.Widget.Contracts.View;

namespace TGrant.Awe.Core.Widget.Contracts;

public interface IWMainFormDomainService
{
    IMainFormView BuildMainForm(string productInfo);
}