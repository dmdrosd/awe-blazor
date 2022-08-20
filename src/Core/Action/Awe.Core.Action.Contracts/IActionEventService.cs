using Abp.Events.Bus.Handlers;

namespace Awe.Core.Action.Contracts;

public interface IActionEventService<in T> : IAsyncEventHandler<T>
    where T : WidgetEventData
{
}