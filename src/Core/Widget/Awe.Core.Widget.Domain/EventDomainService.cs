using Volo.Abp.Domain.Services;
using Volo.Abp.EventBus.Local;

namespace Awe.Core.Widget.Domain;

public class EventDomainService : DomainService, IEventDomainService
{
    private readonly ILocalEventBus _eventBus;

    public EventDomainService()
    {
        _eventBus = NullLocalEventBus.Instance;
    }

    public void TriggerEvent<T>(T eventData)
        where T: WidgetEventData
    {
        _eventBus.PublishAsync(eventData);
        _eventBus.PublishAsync(new WidgetEventData());
    }
}