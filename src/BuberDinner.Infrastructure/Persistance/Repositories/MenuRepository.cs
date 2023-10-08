using BuberDinner.Application.Common.Interfaces.Persistance;
using BuberDinner.Domain.MenuAggregate;

namespace BuberDinner.Infrastructure.Persistance.Repositories;

public class MenuRepository : IMenuRepository
{
    private readonly BuberDinnerDbContext _dbContext;

    public MenuRepository(BuberDinnerDbContext dbContext)
    {
        _dbContext = dbContext;
    }

    public void Add(Menu menu)
    {
        _dbContext.Add(menu);
        _dbContext.SaveChanges();
    }

}