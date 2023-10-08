using BuberDinner.Domain.MenuAggregate.Events;

using MediatR;

namespace BuberDinner.Application.Menus.Events;

public class DummyHandler : INotificationHandler<MenuCreated>
{
    public Task Handle(MenuCreated notification, CancellationToken cancellationToken)
    {
        return Task.CompletedTask;
    }

}