using Awe.Core.Widget.Contracts.View.MainForm;

namespace Awe.Core.Widget.Contracts.Domain;

public interface IWMainFormDomainService
{
    IMainFormView BuildMainForm(string productInfo);
}