using Auctions.Models;

namespace Auctions.Data.Services;

public class CommentsService(ApplicationDbContext context) : ICommentsService
{
    public async Task Add(Comment comment)
    {
        context.Comments.Add(comment);
        await context.SaveChangesAsync();
    }
}