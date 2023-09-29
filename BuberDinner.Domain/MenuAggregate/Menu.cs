using BuberDinner.Domain.Common.Models;
using BuberDinner.Domain.Common.ValueObjects;
using BuberDinner.Domain.Dinner.ValueObjects;
using BuberDinner.Domain.Host.ValueObjects;
using BuberDinner.Domain.MenuAggregate.Entities;
using BuberDinner.Domain.MenuAggregate.ValueObjects;
using BuberDinner.Domain.MenuReview.ValueObjects;

namespace BuberDinner.Domain.MenuAggregate;

public sealed class Menu : AggregateRoot<MenuId>
{
    private readonly List<MenuSection> _menuSections = new();

    private readonly List<DinnerId> _dinnerIds = new();

    private readonly List<MenuReviewId> _menuReviewIds = new();
    public string Name { get; }
    public string Description { get; }
    public AverageRating AverageRating { get; }

    public IReadOnlyList<MenuSection> MenuSections => _menuSections.AsReadOnly();

    public HostId HostId { get; }

    public IReadOnlyList<DinnerId> DinnerIds => _dinnerIds.AsReadOnly();

    public IReadOnlyList<MenuReviewId> MenuReviewIds => _menuReviewIds.AsReadOnly();

    public DateTime CreatedDateTime { get; }

    public DateTime UpdatedDateTime { get; }

    private Menu(
        MenuId menuId,
        string name,
        string description,
        AverageRating averageRating,
        HostId hostId,
        List<MenuSection>? menuSections,
        DateTime createdDateTime,
        DateTime updatedDateTime)
        : base(menuId)
    {
        Name = name;
        Description = description;
        AverageRating = averageRating;
        HostId = hostId;
        CreatedDateTime = createdDateTime;
        UpdatedDateTime = updatedDateTime;

        if (menuSections is not null)
        {
            _menuSections.AddRange(menuSections);
        }
    }

    public static Menu Create(
        HostId hostId,
        string name,
        string description,
        List<MenuSection>? menuSections)
    {
        return new(MenuId.CreateUnique(), name, description, AverageRating.CreateNew(), hostId, menuSections, DateTime.UtcNow,
            DateTime.UtcNow);
    }
}