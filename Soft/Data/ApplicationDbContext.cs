using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Nc.Infra;

namespace Nc.Soft.Data; 
public class ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : IdentityDbContext(options) {
    protected override void OnModelCreating(ModelBuilder builder) {
        base.OnModelCreating(builder);
        NetworkDbContext.InitializeTables(builder);
    }
}