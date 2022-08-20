using Awe.Core.Action.Contracts;

namespace TGrant.Awe.Core.Widget.Contracts;

public interface IEventDomainService
{
    void TriggerEvent<T>(T eventData)
        where T : WidgetEventData;
}