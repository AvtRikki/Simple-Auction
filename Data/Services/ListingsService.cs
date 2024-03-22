using Auctions.Models;
using Microsoft.EntityFrameworkCore;

namespace Auctions.Data.Services;

public class ListingsService : IListingsService
{
    private readonly ApplicationDbContext _context;
    
    public ListingsService(ApplicationDbContext context)
    {
        _context = context;
    }
    
    public IQueryable<Listing> GetAll()
    {
        var applicationDbContext = _context.Listings.Include(l => l.User);
        return applicationDbContext;
    }

    public async Task Add(Listing listing)
    {
        await _context.Listings.AddAsync(listing);
        await _context.SaveChangesAsync();
    }

    public async Task<Listing> GetById(int? id)
    {
        var result = await _context.Listings
            .Include(listing => listing.User)
            .Include(listing => listing.Comments)
            .Include(listing => listing.Bids)
            .ThenInclude(listing => listing.User)
            .FirstOrDefaultAsync(listing => listing.Id == id);

        return result;
    }

    public async Task SaveChanges()
    {
        await _context.SaveChangesAsync();
    }
}