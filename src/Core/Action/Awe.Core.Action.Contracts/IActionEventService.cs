using Volo.Abp.EventBus;

namespace Awe.Core.Action.Contracts;

public interface IActionEventService<in T> : ILocalEventHandler<T>
    where T : WidgetEventData
{
}