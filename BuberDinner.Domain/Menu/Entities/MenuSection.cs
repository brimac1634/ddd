using BuberDinner.Domain.Common.Models;
using BuberDinner.Domain.Menu.ValueObjects;

namespace BuberDinner.Domain.Menu.Entities;

public sealed class MenuSection : Entity<MenuSectionId>
{
    private readonly List<MenuItem> _menuItems = new();
    public string Name { get; }
    public string Description { get; }

    public IReadOnlyList<MenuItem> MenuItems => _menuItems.AsReadOnly();

    private MenuSection(MenuSectionId menuSectionId, string name, string description)
        : base(menuSectionId)
    {
        Name = name;
        Description = description;
    }

    public static MenuSection Create(string name, string description)
    {
        return new(MenuSectionId.CreateUnique(), name, description);
    }
}