using BuberDinner.Domain.MenuAggregate;

namespace BuberDinner.Application.Common.Interfaces.Persistance;

public interface IMenuRepository
{
    void Add(Menu menu);
}