using BuberDinner.Domain.Common.Models;
using BuberDinner.Domain.MenuAggregate.ValueObjects;

namespace BuberDinner.Domain.MenuAggregate.Entities;

public sealed class MenuSection : Entity<MenuSectionId>
{
    private readonly List<MenuItem> _items = new();
    public string Name { get; private set; }
    public string Description { get; private set; }

    public IReadOnlyList<MenuItem> Items => _items.AsReadOnly();

    private MenuSection(MenuSectionId menuSectionId, string name, string description, List<MenuItem>? menuItems)
        : base(menuSectionId)
    {
        Name = name;
        Description = description;
        if (menuItems is not null)
        {
            _items.AddRange(menuItems);
        }
    }

    #pragma warning disable CS8618
    private MenuSection()
    {
        
    }
    #pragma warning restore CS8618

    public static MenuSection Create(string name, string description, List<MenuItem>? menuItems)
    {
        return new(MenuSectionId.CreateUnique(), name, description, menuItems);
    }
}