using JSEnhancedCRUD.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace JSEnhancedCRUD.Data;

public class JavaScriptDbContext(DbContextOptions<JavaScriptDbContext> options) : IdentityDbContext(options)
{
    public DbSet<Product> Products { get; set; }
}
