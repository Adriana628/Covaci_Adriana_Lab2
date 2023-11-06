using Microsoft.EntityFrameworkCore;

internal class LibraryIdentityContext : DbContext
{
    public LibraryIdentityContext(DbContextOptions<LibraryIdentityContext> options) : base(options)
    {
    }
}