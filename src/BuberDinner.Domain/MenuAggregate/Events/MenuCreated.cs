using BuberDinner.Domain.Common.Models;

namespace BuberDinner.Domain.MenuAggregate.Events;

public record MenuCreated(Menu Menu) : IDomainEvent;