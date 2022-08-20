using Abp.Events.Bus.Handlers;

namespace TGrant.Awe.Core.Action.Contracts;

public interface IActionEventService<in T> : IAsyncEventHandler<T>
    where T : WidgetEventData
{
}