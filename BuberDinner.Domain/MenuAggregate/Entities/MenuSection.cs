using BuberDinner.Domain.Common.Models;
using BuberDinner.Domain.MenuAggregate.ValueObjects;

namespace BuberDinner.Domain.MenuAggregate.Entities;

public sealed class MenuSection : Entity<MenuSectionId>
{
    private readonly List<MenuItem> _menuItems = new();
    public string Name { get; }
    public string Description { get; }

    public IReadOnlyList<MenuItem> MenuItems => _menuItems.AsReadOnly();

    private MenuSection(MenuSectionId menuSectionId, string name, string description, List<MenuItem>? menuItems)
        : base(menuSectionId)
    {
        Name = name;
        Description = description;
        if (menuItems is not null)
        {
            _menuItems.AddRange(menuItems);
        }
    }

    public static MenuSection Create(string name, string description, List<MenuItem>? menuItems)
    {
        return new(MenuSectionId.CreateUnique(), name, description, menuItems);
    }
}