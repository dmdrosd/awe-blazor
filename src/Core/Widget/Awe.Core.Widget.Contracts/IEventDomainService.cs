using Awe.Core.Action.Contracts;

namespace Awe.Core.Widget.Contracts;

public interface IEventDomainService
{
    void TriggerEvent<T>(T eventData)
        where T : WidgetEventData;
}