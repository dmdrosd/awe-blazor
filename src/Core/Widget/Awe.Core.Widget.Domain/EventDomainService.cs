using Abp.Domain.Services;
using Abp.Events.Bus;

namespace Awe.Core.Widget.Domain;

public class EventDomainService : DomainService, IEventDomainService
{
    private readonly EventBus _eventBus;

    public EventDomainService()
    {
        _eventBus = EventBus.Default;
    }

    public void TriggerEvent<T>(T eventData)
        where T: WidgetEventData
    {
        _eventBus.Trigger(eventData);

        EventBus.Default.Trigger(new WidgetEventData());
    }
}